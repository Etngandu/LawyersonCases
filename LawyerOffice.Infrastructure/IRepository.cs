using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LawyerOffice.Infrastructure
{
  /// <summary>
  /// Defines various methods for working with data in the system.
  /// </summary>
  public interface IRepository<T, K> where T : class
  {
    /// <summary>
    /// Finds an item by its unique ID.
    /// </summary>
    /// <param name="id">The unique ID of the item in the database.</param>
    /// <param name="includeProperties">An expression of additional properties to eager load. For example: x => x.SomeCollection, x => x.SomeOtherCollection.</param>
    /// <returns>The requested item when found, or null otherwise.</returns>
    T FindById(K id, params Expression<Func<T, object>>[] includeProperties);

    /// <summary>
    /// Returns an IQueryable of all items of type T.
    /// </summary>
    /// <param name="includeProperties">An expression of additional properties to eager load. For example: x => x.SomeCollection, x => x.SomeOtherCollection.</param>
    /// <returns>An IQueryable of the requested type T.</returns>
    IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);

    /// <summary>
    /// Returns an IQueryable of items of type T.
    /// </summary>
    /// <param name="predicate">A predicate to limit the items being returned.</param>
    /// <param name="includeProperties">An expression of additional properties to eager load. For example: x => x.SomeCollection, x => x.SomeOtherCollection.</param>
    /// <returns>An IEnumerable of the requested type T.</returns>
    IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

    /// <summary>
    /// Adds an entity to the underlying collection.
    /// </summary>
    /// <param name="entity">The entity that should be added.</param>
     void Add(T entity);

    /// <summary>
    /// Removes an entity from the underlying collection.
    /// </summary>
    /// <param name="entity">The entity that should be removed.</param>
    void Remove(T entity);

    /// <summary>
    /// Removes an entity from the underlying collection.
    /// </summary>
    /// <param name="id">The ID of the entity that should be removed.</param>
    void Remove(K id);
  }
}
