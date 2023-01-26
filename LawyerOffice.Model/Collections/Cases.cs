using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LawyerOffice.Entities.Collections
{
    /// <summary>
    /// Represents a collection of EmailAddress instances in the system.
    /// </summary>
    public class Cases : CollectionBase<Case>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cases"/> class.
        /// </summary>
        public Cases() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cases"/> class.
        /// </summary>
        /// <param name="initialList">Accepts an IList of EmailAddress as the initial list.</param>
        public Cases(IList<Case> initialList) : base(initialList) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPickings"/> class.
        /// </summary>
        /// <param name="initialList">Accepts a CollectionBase of EmailAddress as the initial list.</param>
        public Cases(CollectionBase<Case> initialList) : base(initialList) { }

        /// <summary>
        /// Adds a new instance of EmailAddress to the collection.
        /// </summary>
        /// <param name="emailAddressText">The e-mail address text.</param>
        /// <param name="contactType">The type of the e-mail address.</param>
        //public void Add(string emailAddressText, ProfileType profileType)
        //{
        //    Add(new EmailAddress { ProfileType = profileType, EmailAddressText = emailAddressText });
        //}

        /// <summary>
        /// Validates the current collection by validating each individual item in the collection.
        /// </summary>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public IEnumerable<ValidationResult> Validate()
        {
            var errors = new List<ValidationResult>();
            foreach (var mcase in this)
            {
                errors.AddRange(mcase.Validate());
            }
            return errors;
        }

       
    }
}
