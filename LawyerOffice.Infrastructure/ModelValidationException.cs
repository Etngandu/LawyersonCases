using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LawyerOffice.Infrastructure
{
  /// <summary>
  /// A base class for validation exceptions thrown from a model.
  /// </summary>
  public class ModelValidationException : Exception
  {
    private readonly IEnumerable<ValidationResult> _validationErrors;

    /// <summary>
    /// Initializes a new instance of the PeopleController class.
    /// </summary>
    public ModelValidationException()
    {

    }
    /// <summary>
    /// Initializes a new instance of the PeopleController class.
    /// </summary>
    /// <param name="message">The error message for this exception.</param>
    public ModelValidationException(string message)
      : base(message)
    {
      
    }

    /// <summary>
    /// Initializes a new instance of the PeopleController class.
    /// </summary>
    /// <param name="message">The error message for this exception.</param>
    /// <param name="innerException">The inner exception that is wrapped in this exception.</param>
    public ModelValidationException(string message, Exception innerException)
      : base(message, innerException)
    {
      
    }

    /// <summary>
    /// Initializes a new instance of the PeopleController class.
    /// </summary>
    /// <param name="message">The error message for this exception.</param>
    /// <param name="innerException">The inner exception that is wrapped in this exception.</param>
    /// <param name="validationErrors">A collection of validation errors.</param>
    public ModelValidationException(string message, Exception innerException, IEnumerable<ValidationResult> validationErrors)
      : base(message, innerException)
    {
      _validationErrors = validationErrors;

    }

    /// <summary>
    /// Initializes a new instance of the PeopleController class.
    /// </summary>
    /// <param name="message">The error message for this exception.</param>
    /// <param name="validationErrors">A collection of validation errors.</param>
    public ModelValidationException(string message, IEnumerable<ValidationResult> validationErrors)
      : base(message)
    {
      _validationErrors = validationErrors;

    }

    /// <summary>
    /// Initializes a new instance of the PeopleController class.
    /// </summary>
    protected ModelValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
      : base(info, context)
    {
      
    }

    /// <summary>
    /// A collection of validation errors for the entity that failed validation.
    /// </summary>
    public IEnumerable<ValidationResult> ValidationErrors
    {
      get
      {
        return _validationErrors;
      }
    }
  }
}
