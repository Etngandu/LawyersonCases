using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection;
using StatusGeneric;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using LawyerOffice.Data.EF.ConfigurationEntity;

namespace LawyerOffice.Data.EF
{
    /// <summary>
    /// This is the main DbContext to work with data in the database.
    /// </summary>
    public class OfficeLawyerContext : IdentityDbContext<ApplicationUser>
    {
        
        
        public OfficeLawyerContext(DbContextOptions<OfficeLawyerContext> options)
            : base(options)
        {

        }

        

        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Case> Cases { get; set; }




        /// <summary>
        /// Hooks into the Save process to get a last-minute chance to look at the entities and change them. Also intercepts exceptions and 
        /// wraps them in a new Exception type.
        /// </summary>
        /// <returns>The number of affected rows.</returns>
        public override int SaveChanges()
        {
            // Need to manually delete all "owned objects" that have been removed from their owner, otherwise they'll be orphaned.
           
            
            var orphanedObjects = ChangeTracker.Entries().Where(
              e => (e.State == EntityState.Modified || e.State == EntityState.Added));

            


            foreach (var orphanedObject in orphanedObjects)
            {
                OwnerValidator.ValidateEntity(this, orphanedObject, orphanedObject.Entity.GetType());

            }
            // SaveChangesExtensions.SaveChangesWithValidation(this);
            try
            {
                var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
                foreach (EntityEntry item in modified)
                {
                    var changedOrAddedItem = item.Entity as IDateTracking;
                    if (changedOrAddedItem != null)
                    {
                        if (item.State == EntityState.Added)
                        {
                            changedOrAddedItem.DateCreated = DateTime.Now;
                        }
                        changedOrAddedItem.DateModified = DateTime.Now;
                    }
                    var valProvider = new ValidationDbContextServiceProvider(this);
                    var validationContext = new ValidationContext(item, valProvider, null);
                    Validator.ValidateObject(item, validationContext);
                }
               
            }
            catch (Exception )
            {
                //var errors = entityException.InnerException;
                //var result = new StringBuilder();
                //var allErrors = new List<ValidationResult>();
                //foreach (var error in errors)
                //{
                //    foreach (var validationError in error.ValidationErrors)
                //    {
                //        result.AppendFormat("\r\n  Entity of type {0} has validation error \"{1}\" for property {2}.\r\n", error.Entry.Entity.GetType().ToString(), validationError.ErrorMessage, validationError.PropertyName);
                //        var domainEntity = error.Entry.Entity as DomainEntity<int>;
                //        if (domainEntity != null)
                //        {
                //            result.Append(domainEntity.IsTransient() ? "  This entity was added in this session.\r\n" : string.Format("  The Id of the entity is {0}.\r\n", domainEntity.Id));
                //        }
                //        allErrors.Add(new ValidationResult(validationError.ErrorMessage, new[] { validationError.PropertyName }));
                //    }
                //}
                //throw new ModelValidationException(result.ToString(), entityException, allErrors);
                //var exStatus = SaveChangesExtensions.SaveChangesExceptionHandler(e, this);
                //if (exStatus == null) throw;       //error wasn't handled, so rethrow
                //status.CombineStatuses(exStatus);
            }
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken=default)
        {
            

            var orphanedObjects = ChangeTracker.Entries().Where(
              e => (e.State == EntityState.Modified || e.State == EntityState.Added));




            foreach (var orphanedObject in orphanedObjects)
            {
                OwnerValidator.ValidateEntity(this, orphanedObject, orphanedObject.Entity.GetType());

            }
            // SaveChangesExtensions.SaveChangesWithValidation(this);
            try
            {
                var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
                foreach (EntityEntry item in modified)
                {
                    var changedOrAddedItem = item.Entity as IDateTracking;
                    if (changedOrAddedItem != null)
                    {
                        if (item.State == EntityState.Added)
                        {
                            changedOrAddedItem.DateCreated = DateTime.Now;
                        }
                        changedOrAddedItem.DateModified = DateTime.Now;
                    }
                    ////var valProvider = new ValidationDbContextServiceProvider(this);
                    ////var validationContext = new ValidationContext(item, valProvider, null);
                    ////Validator.ValidateObject(item, validationContext);
                   
                }
                // return base.SaveChanges();
            }
            catch (Exception e)
            {

               // throw new ModelValidationException(result.ToString(), entityException, allErrors);
                var exStatus = SaveChangesExtensions.SaveChangesExceptionHandler(e, this);
                if (exStatus == null) throw;       //error wasn't handled, so rethrow
                var status = SaveChangesExtensions.ExecuteValidation(this);
                status.CombineStatuses(exStatus);
            }
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess:true,cancellationToken);
        }

        private string cstr = "Server=desktop-chqki35\\sqlexpress01;Database=LawyerEFCore;Trusted_Connection=True;MultipleActiveResultSets=true;";
        /// <summary>
        /// Configures the EF context.
        /// </summary>
        /// <param name="modelBuilder">The model builder that needs to be configured.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cstr, b =>
                 b.MigrationsAssembly("LawyerOffice.Data.EF"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }


    }
}