using System;
namespace LawyerOffice.Entities
{
  /// <summary>
  /// Defines an interface for objects whose creation and modified dates are kept track of.
  /// </summary>
  public interface IDateTracking
  {
    /// <summary>
    /// Gets or sets the date and time the object was created.
    /// </summary>
    DateTime DateCreated { get; set; }

    /// <summary>
    /// Gets or sets the date and time the object was last modified.
    /// </summary>
    DateTime DateModified { get; set; }
  }
}
