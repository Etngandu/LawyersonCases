using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Reflection;

namespace LawyerOffice.Data.EF
{
  public static class OwnerValidator
    {
        private static readonly Dictionary<Type, string> _parentAttributes = new Dictionary<Type, string>();

        public static void ValidateEntity(DbContext context, EntityEntry entity, Type type)
        {
            if (entity.State == EntityState.Modified)
            {
                if (!_parentAttributes.ContainsKey(type))
                {
                    var properties = from attributedProperty in type.GetProperties()
                                     select new
                                     {
                                         attributedProperty,
                                         attributes = attributedProperty.GetCustomAttributes(true)
                                             .Where(attribute => attribute is OwnerAttribute)
                                     };
                    properties = properties.Where(p => p.attributes.Any());
                    _parentAttributes.Add(type,
                                          properties.Any()
                                              ? properties.First().attributedProperty.Name
                                              : string.Empty);
                }

                if (!string.IsNullOrEmpty(_parentAttributes[type]))
                {
                    if (entity.Reference(_parentAttributes[type]).CurrentValue == null)
                    {
                        context.Set(type).Remove(entity.Entity);
                    }
                }
            }

        }

        public static IQueryable Set(this DbContext context, Type T)
        {
            // Get the generic type definition
            MethodInfo method = typeof(DbContext).GetMethod(nameof(DbContext.Set), BindingFlags.Public | BindingFlags.Instance);

            var method1 = typeof(DbContext).GetMethods().Single(p =>
            p.Name == nameof(DbContext.Set) && p.ContainsGenericParameters && !p.GetParameters().Any());


            // Build a method with the specific type argument you're interested in
            method = method.MakeGenericMethod(T);

            return method.Invoke(context, null) as IQueryable;
        }

        public static IQueryable Remove(this IQueryable result, object T)
        {
            return result.Remove(T);
        }


        
    }
}
