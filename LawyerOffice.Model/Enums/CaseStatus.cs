namespace LawyerOffice.Entities
{
  /// <summary>
  /// Determines the type of a contact record.
  /// </summary>
  public enum CaseStatus
  {
    /// <summary>
    /// Indicates an unidentified value.
    /// </summary>
    None = 0,

    /// <summary>
    /// Indicates a business contact record.
    /// </summary>
    Open = 1,

    /// <summary>
    /// Indicates a personal contact record.
    /// </summary>
    Closed = 2
  }
}
