using System;
using System.Collections;
using System.Threading;

namespace LawyerOffice.Infrastructure.DataContextStorage
{
  /// <summary>
  /// A Helper class to store objects like a DataContext in a static HashTable indexed by the name of a thread.
  /// </summary>
  /// <typeparam name="T">The type of object to store.</typeparam>
  public class ThreadDataContextStorageContainer<T> : IDataContextStorageContainer<T> where T : class
  {
    private static readonly Hashtable StoredContexts = new Hashtable();

    /// <summary>
    /// Returns an object from the container when it exists. Returns null otherwise.
    /// </summary>
    /// <returns>The object from the container when it exists, null otherwise.</returns>
    public T GetDataContext()
    {
      T context = null;

      if (StoredContexts.Contains(GetThreadName()))
      {
        context = (T)StoredContexts[GetThreadName()];
      }
      return context;
    }

    /// <summary>
    /// Clears the object from the container.
    /// </summary>
    public void Clear()
    {
      if (StoredContexts.Contains(GetThreadName()))
      {
        StoredContexts[GetThreadName()] = null;
      }
    }

    /// <summary>
    /// Stores the object in the hashtable indexed by the thread's name.
    /// </summary>
    /// <param name="objectContext">The object to store.</param>
    public void Store(T objectContext)
    {
      if (StoredContexts.Contains(GetThreadName()))
      {
        StoredContexts[GetThreadName()] = objectContext;
      }
      else
      {
        StoredContexts.Add(GetThreadName(), objectContext);
      }
    }

    private static string GetThreadName()
    {
      if (string.IsNullOrEmpty(Thread.CurrentThread.Name))
      {
        Thread.CurrentThread.Name = Guid.NewGuid().ToString();
      }
      return Thread.CurrentThread.Name;
    }
  }
}