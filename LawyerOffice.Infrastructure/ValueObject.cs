using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace LawyerOffice.Infrastructure
{
  /// <summary>
  /// Base class for value objects in the domain.
  /// </summary>
  /// <typeparam name="T">The type of this value object</typeparam>
  public abstract class ValueObject<T> : IEquatable<T>, IValidatableObject where T : ValueObject<T>
  {
    /// <summary>
    /// Determines whether this object is valid or not.
    /// </summary>
    /// <param name="validationContext">Describes the context in which a validation check is performed.</param>
    /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
    public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);

    /// <summary>
    /// Determines whether this object is valid or not.
    /// </summary>
    /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
    public IEnumerable<ValidationResult> Validate()
    {
      var validationErrors = new List<ValidationResult>();
      var ctx = new ValidationContext(this, null, null);
      Validator.TryValidateObject(this, ctx, validationErrors, true);
      return validationErrors;
    }

    private bool CheckValue(PropertyInfo p, T other)
    {
      var left = p.GetValue(this, null);
      var right = p.GetValue(other, null);
      if (left == null || right == null)
      {
        return false;
      }

      if (typeof(T).IsAssignableFrom(left.GetType()))
      {
        //check not self-references...
        return ReferenceEquals(left, right);
      }
      return left.Equals(right);
    }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <returns>
    /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
    /// </returns>
    /// <param name="other">
    /// An object to compare with this object.
    /// </param>
    public bool Equals(T other)
    {
      if ((object)other == null)
      {
        return false;
      }

      if (ReferenceEquals(this, other))
      {
        return true;
      }

      //compare all public properties
      PropertyInfo[] publicProperties = GetType().GetProperties();

      if (publicProperties.Any())
      {
        return publicProperties.All(p => CheckValue(p, other));
      }
      return true;
    }

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>
    /// True if the specified object  is equal to the current object; otherwise, false.
    /// </returns>
    public override bool Equals(object obj)
    {
      if ((object)obj == null)
      {
        return false;
      }

      if (ReferenceEquals(this, obj))
      {
        return true;

      }
      var item = obj as ValueObject<T>;

      if ((object)item != null)
      {
        return Equals((T)item);
      }
      return false;
    }

    /// <summary>
    /// Serves as a hash function for a particular type. 
    /// </summary>
    /// <returns>
    /// A hash code for the current <see cref="T:System.Object" />.
    /// </returns>
    public override int GetHashCode()
    {
      int hashCode = 31;
      bool changeMultiplier = false;
      int index = 1;

      //compare all public properties
      PropertyInfo[] publicProperties = this.GetType().GetProperties();

      if (publicProperties.Any())
      {
        foreach (var item in publicProperties)
        {
          object value = item.GetValue(this, null);

          if ((object)value != null)
          {
            hashCode = hashCode * ((changeMultiplier) ? 59 : 114) + value.GetHashCode();
            changeMultiplier = !changeMultiplier;
          }
          else
          {
            hashCode = hashCode ^ (index * 13);//only for support {"a",null,null,"a"} <> {null,"a","a",null}
          }
        }
      }
      return hashCode;
    }

    /// <summary>
    /// Override the equality comparer.
    /// </summary>
    /// <param name="left">The left side to compare.</param>
    /// <param name="right">The right side to compare.</param>
    /// <returns>True when the two objects are equal; false otherwise.</returns>
    public static bool operator ==(ValueObject<T> left, ValueObject<T> right)
    {
      if (Equals(left, null))
      {
        return (Equals(right, null)) ? true : false;
      }
      return left.Equals(right);
    }

    /// <summary>
    /// Override the not equals comparer.
    /// </summary>
    /// <param name="left">The left side to compare.</param>
    /// <param name="right">The right side to compare.</param>
    /// <returns>True when the two objects are not equal; false otherwise.</returns>
    public static bool operator !=(ValueObject<T> left, ValueObject<T> right)
    {
      return !(left == right);
    }
  }
}

