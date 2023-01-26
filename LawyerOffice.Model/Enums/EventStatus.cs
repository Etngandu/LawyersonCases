using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Entities
{
    /// <summary>
    /// Determines the Status of an LawyerEvent record.
    /// </summary>

    public enum EventStatus
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates LawyerEvent Planned.
        /// </summary>
        [Display(Name = "Planned")]
        orange = 1,

        /// <summary>
        /// Indicates LawyerEvent Confirmed.
        /// </summary>
        [Display(Name = "Confirmed")]
        green = 2,

        /// <summary>
        /// Indicates LawyerEvent changed.
        /// </summary>
        [Display(Name = "Changed")]
        red = 3,

        /// <summary>
        /// Indicates LawyerEvent Completed.
        /// </summary>
        [Display(Name = "Completed")]
        darkcyan = 4       


    }
}
