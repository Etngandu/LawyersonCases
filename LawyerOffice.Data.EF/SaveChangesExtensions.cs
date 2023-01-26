using LawyerOffice.Infrastructure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StatusGeneric;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LawyerOffice.Data.EF
{
   public static class  SaveChangesExtensions
    {
        // JON P SMITH VALIDATION

        public const int SqlServerViolationOfUniqueIndex = 2601;
        public const int SqlServerViolationOfUniqueConstraint = 2627;

        public static IStatusGeneric SaveChangesExceptionHandler(Exception e, DbContext context)
        {
            var dbUpdateEx = e as DbUpdateException;
            var sqlEx = dbUpdateEx?.InnerException as SqlException;
            if (sqlEx != null)
            {
                //This is a DbUpdateException on a SQL database

                if (sqlEx.Number == SqlServerViolationOfUniqueIndex ||
                    sqlEx.Number == SqlServerViolationOfUniqueConstraint)
                {
                    //We have an error we can process
                    var valError = UniqueErrorFormatter(sqlEx, dbUpdateEx.Entries);
                    if (valError != null)
                    {
                        var status = new StatusGenericHandler();
                        status.AddValidationResult(valError);
                        return status;
                    }
                    //else check for other SQL errors
                }
            }

            //add code to check for other types of exception you can handle


            //otherwise exception wasn't handled, so return null
            return null;
        }
        /// <summary>
        /// /////////////////////////////////////////////////////
        /// </summary>

        private static readonly Regex UniqueConstraintRegex =
        new Regex("'UniqueError_([a-zA-Z0-9]*)_([a-zA-Z0-9]*)'", RegexOptions.Compiled);

        public static ValidationResult UniqueErrorFormatter(SqlException ex, IReadOnlyList<EntityEntry> entitiesNotSaved)
        {
            var message = ex.Errors[0].Message;
            var matches = UniqueConstraintRegex.Matches(message);

            if (matches.Count == 0)
                return null;

            //currently the entitiesNotSaved is empty for unique constraints - see https://github.com/aspnet/EntityFrameworkCore/issues/7829
            var entityDisplayName = entitiesNotSaved.Count == 1
                ? entitiesNotSaved.Single().Entity.GetType().GetNameForClass()
                : matches[0].Groups[1].Value;

            var returnError = "Cannot have a duplicate " +
                              matches[0].Groups[2].Value + " in " +
                              entityDisplayName + ".";

            var openingBadValue = message.IndexOf("(");
            if (openingBadValue > 0)
            {
                var dupPart = message.Substring(openingBadValue + 1,
                    message.Length - openingBadValue - 3);
                returnError += $" Duplicate value was '{dupPart}'.";
            }

            return new ValidationResult(returnError, new[] { matches[0].Groups[2].Value });
        }
        /// <summary>
        /// //////////////////////
        /// </summary>
        /// <param name="context"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IStatusGeneric SaveChangesWithValidation(this DbContext context)
        {
            var status = context.ExecuteValidation();
            if (!status.IsValid) return status;

            context.ChangeTracker.AutoDetectChangesEnabled = false;
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                var exStatus = SaveChangesExceptionHandler(e, context);
                if (exStatus == null) throw;       //error wasn't handled, so rethrow
                status.CombineStatuses(exStatus);
            }
            finally
            {
                context.ChangeTracker.AutoDetectChangesEnabled = true;
            }

            return status;
        }

        /// <summary>
        /// //////////////////////
        /// </summary>
        /// <param name="context"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// 

        public static IStatusGeneric ExecuteValidation(this DbContext context)
        {
            var status = new StatusGenericHandler();
            foreach (var entry in
                context.ChangeTracker.Entries()
                    .Where(e =>
                        (e.State == EntityState.Added) ||
                        (e.State == EntityState.Modified)))
            {
                var entity = entry.Entity;
                var valProvider = new ValidationDbContextServiceProvider(context);
                var valContext = new ValidationContext(entity, valProvider, null);
                var entityErrors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(
                    entity, valContext, entityErrors, true))
                {
                    status.AddValidationResults(entityErrors);
                }
            }

            return status;
        }
    }
}
