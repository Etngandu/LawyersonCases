using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace LawyerOffice.Entities.Collections
{
  /// <summary>
  /// Serves as the base class for all collections.
  /// </summary>
  /// <typeparam name="T">A type parameter to determine the type in the collection.</typeparam>
  public abstract class CollectionBase<T> : Collection<T>, IList<T>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CollectionBase&lt;T&gt;"/> class.
    /// </summary>
    protected CollectionBase() : base(new List<T>()) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="CollectionBase&lt;T&gt;"/> class.
    /// </summary>
    /// <param name="initialList">Accepts an IList of T as the initial list.</param>
    protected CollectionBase(IList<T> initialList) : base(initialList) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="CollectionBase&lt;T&gt;"/> class.
    /// </summary>
    /// <param name="initialList">Accepts a CollectionBase of T as the initial list.</param>
    protected CollectionBase(CollectionBase<T> initialList) : base(initialList) { }

    /// <summary>
    /// Sorts the collection based on the specified comparer.
    /// </summary>
    /// <param name="comparer">The comparer.</param>
    public void Sort(IComparer<T> comparer)
    {
      var list = Items as List<T>;
      if (list != null)
      {
        list.Sort(comparer);
      }
    }

    /// <summary>
    /// Sorts the collection based on the specified comparer. Uses equals on the objects being compared.
    /// </summary>
    public void Sort()
    {
      var list = Items as List<T>;
      if (list != null)
      {
        list.Sort();
      }
    }

    /// <summary>
    /// Adds a range of T instances to the current collection.
    /// </summary>
    /// <param name="collection">The collection of T instances that must be added.</param>
    public void AddRange(IEnumerable<T> collection)
    {
      if (collection == null)
      {
        throw new ArgumentNullException("collection", "Parameter collection is null.");
      }
      foreach (var item in collection)
      {
        Add(item);
      }
    }
  }
}
