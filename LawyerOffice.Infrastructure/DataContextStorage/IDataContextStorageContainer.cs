namespace LawyerOffice.Infrastructure.DataContextStorage
{
  /// <summary>
  /// Defines methods to create, store and create objects from a storage container.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IDataContextStorageContainer<T>
  {
    /// <summary>
    /// Returns an object from the container when it exists. Returns null otherwise.
    /// </summary>
    /// <returns>The object from the container when it exists, null otherwise.</returns>
    T GetDataContext();

    /// <summary>
    /// Stores the object in HttpContext.Current.Items.
    /// </summary>
    /// <param name="objectContext">The object to store.</param>
    void Store(T objectContext);

    /// <summary>
    /// Clears the object from the container.
    /// </summary>
    void Clear();
  }
}
