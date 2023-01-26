using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LawyerOffice.Infrastructure
{
  /// <summary>
  /// Serves as the base class for all entities in the system.
  /// </summary>
  /// <typeparam name="T">The type of the key for the entity.</typeparam>
  public abstract class DomainEntity<T> : IValidatableObject
  {
    /// <summary>
    /// Gets or sets the unique ID of the entity in the underlying data store.
    /// </summary>
    public T Id { get; set; }

    /// <summary>
    /// Checks if the current domain entity has an identity.
    /// </summary>
    /// <returns>True if the domain entity is transient (i.e. has no identity yet), false otherwise.</returns>
    public bool IsTransient()
    {
      return Id.Equals(default(T));
    }

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.
    /// </summary>
    /// <returns>
    /// true if the specified object  is equal to the current object; otherwise, false.
    /// </returns>
    /// <param name="obj">
    /// The object to compare with the current object. 
    /// </param>
    public override bool Equals(object obj)
    {
      if (obj == null || !(obj is DomainEntity<T>))
      {
        return false;
      }

      if (GetType() != obj.GetType())
      {
        return false;
      }

      if (ReferenceEquals(this, obj))
      {
        return true;
      }

      var item = (DomainEntity<T>)obj;

      if (item.IsTransient() || IsTransient())
      {
        return false;
      }
      return item.Id.Equals(Id);
    }

    /// <summary>
    /// Serves as a hash function for a particular type. 
    /// </summary>
    /// <returns>
    /// A hash code for the current <see cref="T:System.Object" />.
    /// </returns>
    public override int GetHashCode()
    {
      if (!IsTransient())
      {
        return Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)
      }
      return base.GetHashCode();
    }

    /// <summary>
    /// Compares two instances for equality.
    /// </summary>
    /// <param name="left">The left instance to compare.</param>
    /// <param name="right">The right instance to compare.</param>
    /// <returns>True when the objects are the same, false otherwise.</returns>
    public static bool operator ==(DomainEntity<T> left, DomainEntity<T> right)
  {
    if (Equals(left, null))
    {
      return Equals(right, null);
    }
      return left.Equals(right);
  }

    /// <summary>
    /// Compares two instances for inequality.
    /// </summary>
    /// <param name="left">The left instance to compare.</param>
    /// <param name="right">The right instance to compare.</param>
    /// <returns>False when the objects are the same, true otherwise.</returns>
    public static bool operator !=(DomainEntity<T> left, DomainEntity<T> right)
    {
      return !(left == right);
    }

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
  }
}
