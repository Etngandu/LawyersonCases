namespace LawyerOffice.Entities
{
    /// <summary>
    /// Determines the type of a contact person.
    /// </summary>
    public enum RefSpeciality
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a Divorce Lawyer.
        /// </summary>
        Divorce = 1,

        /// <summary>
        /// Indicates Bankruptcy Lawyer.
        /// </summary>
        Bankruptcy = 2,

        /// <summary>
        /// Indicates Employment Lawyer.
        /// </summary>
        Employment = 3,
        /// <summary>
        /// Indicates a Immigration Lawyer.
        /// </summary>
        Immigration = 4,

        /// <summary>
        /// Indicates a Criminal Lawyer.
        /// </summary>
        Criminal = 5,

        /// <summary>
        /// Indicates a Tax Lawyer.
        /// </summary>
        Tax = 6,
        /// <summary>
        /// Indicates a Family Lawyer.
        /// </summary>
        Family = 7
    }
}
