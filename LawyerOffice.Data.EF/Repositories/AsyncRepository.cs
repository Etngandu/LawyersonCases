using LawyerOffice.Infrastructure;
using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Data.EF.Repositories
{
    /// <summary>
    /// Serves as a generic base class for concrete repositories to support basic CRUD oprations on data in the system.
    /// </summary>
    /// <typeparam name="T">The type of entity this repository works with. Must be a class inheriting DomainEntity.</typeparam>
    public class AsyncRepository<T> : IAsyncRepository<T, int>, IAsyncDisposable where T : DomainEntity<int>
    {
        private readonly IDataContextStorageContainer<OfficeLawyerContext> _cdataContextFactory;

        protected AsyncRepository(IDataContextStorageContainer<OfficeLawyerContext> cdataContextFactory)
        {
            _cdataContextFactory = cdataContextFactory;
        }
        /// <summary>
        /// Finds an item by its unique ID.
        /// </summary>
        /// <param name="id">The unique ID of the item in the database.</param>
        /// <param name="includeProperties">An expression of additional properties to eager load. For example: x => x.SomeCollection, x => x.SomeOtherCollection.</param>
        /// <returns>The requested item when found, or null otherwise.</returns>
        public virtual async Task<T> FindById(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            return await FindAll(includeProperties).SingleOrDefaultAsync(x => x.Id == id);           
        }

        /// <summary>
        /// Returns an IQueryable of all items of type T.
        /// </summary>
        /// <param name="includeProperties">An expression of additional properties to eager load. For example: x => x.SomeCollection, x => x.SomeOtherCollection.</param>
        /// <returns>An IQueryable of the requested type T.</returns>
        public virtual IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> items = _cdataContextFactory.GetDataContext().Set<T>();

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            
            return items;
        }

        /// <summary>
        /// Returns an IQueryable of items of type T.
        /// </summary>
        /// <param name="predicate">A predicate to limit the items being returned.</param>
        /// <param name="includeProperties">An expression of additional properties to eager load. For example: x => x.SomeCollection, x => x.SomeOtherCollection.</param>
        /// <returns>An IEnumerable of the requested type T.</returns>
        public async Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items =  _cdataContextFactory.GetDataContext().Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items =  items.Include(includeProperty);
                }
            }

            return await (Task<IEnumerable<T>>)(items.Where(predicate));
        }

        /// <summary>
        /// Adds an entity to the underlying DbContext.
        /// </summary>
        /// <param name="entity">The entity that should be added.</param>
        public virtual async Task Add(T entity)
        {

            await _cdataContextFactory.GetDataContext().Set<T>().AddAsync(entity);
           
        }

        /// <summary>
        /// Removes an entity from the underlying DbContext.
        /// </summary>
        /// <param name="entity">The entity that should be removed.</param>
        public virtual void Remove(T entity)
        {
            _cdataContextFactory.GetDataContext().Set<T>().Remove(entity);
           
        }

        /// <summary>
        /// Removes an entity from the underlying DbContext. Calls <see cref="FindById" /> to resolve the item.
        /// </summary>
        /// <param name="id">The ID of the entity that should be removed.</param>
        public virtual void Remove(int id)
        {
            _cdataContextFactory.GetDataContext().Set<T>().Remove(FindById(id));
            
        }


        /// <summary>
        /// Removes an entity from the underlying DbContext. Calls <see cref="FindById" /> to resolve the item.
        /// </summary>
        /// <param name="id">The ID of the entity that should be removed.</param>
        public virtual async Task AddRange(IEnumerable<T> entities)
        {
          await  _cdataContextFactory.GetDataContext().Set<T>().AddRangeAsync(entities);
           
        }

        /// <summary>
        /// Removes an entity from the underlying DbContext. Calls <see cref="FindById" /> to resolve the item.
        /// </summary>
        /// <param name="id">The ID of the entity that should be removed.</param>
        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _cdataContextFactory.GetDataContext().Set<T>().RemoveRange(entities);
           
        }
        /// <summary>
        /// Disposes the underlying data context.
        /// </summary>
        public async ValueTask  DisposeAsync()
        {
            if (_cdataContextFactory.GetDataContext() != null)
            {
              await  _cdataContextFactory.GetDataContext().DisposeAsync();
            }
        }

        
    }
}
