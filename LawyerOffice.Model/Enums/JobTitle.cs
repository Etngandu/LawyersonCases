using System.ComponentModel.DataAnnotations;

namespace LawyerOffice.Entities
{
    /// <summary>
    /// Determines the type of a contact record.
    /// </summary>
    public enum JobTitle
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a Junior Lawyer.
        /// </summary>
        [Display(Name = "Summer Associate")]
        Summer_Associate = 1,

        /// <summary>
        /// Indicates a Senior Lawyer.
        /// </summary>
        [Display(Name = "Junior Associate")]
        Junior_Associate = 2,

        /// <summary>
        /// Indicates a personal contact record.
        /// </summary>
        [Display(Name = "Senior Associate")]
        Senior_Associate = 3,

        /// <summary>
        /// Indicates a personal contact record.
        /// </summary>
        [Display(Name = "Partner")]
        Partner = 4,

        /// <summary>
        /// Indicates a personal contact record.
        /// </summary>
        [Display(Name = "Managing Partner")]
        Managing_Partner = 5,

        /// <summary>
        /// Indicates a personal contact record.
        /// </summary>
        [Display(Name = "Of Counsel Attorney")]
        Of_Counsel_Attorney = 6


    }
}
