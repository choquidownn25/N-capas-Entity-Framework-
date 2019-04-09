using CapaService.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaService.Behaviors
{
    
        /// <summary>
        /// Common Operation Entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        public interface ICommonOperationEntity<TEntity> where TEntity : class
        {
            /// <summary>
            /// Inserts the specified entity.
            /// </summary>
            /// <param name="entity">The entity.</param>
            /// <returns></returns>
            TEntity Insert(TEntity entity);

            /// <summary>
            /// Updates the specified entity.
            /// </summary>
            /// <param name="entity">The entity.</param>
            /// <returns></returns>
            TEntity Update(TEntity entity);

            /// <summary>
            /// Deletes the specified entity.
            /// </summary>
            /// <param name="entity">The entity.</param>
            /// <returns></returns>
            TEntity Delete(TEntity entity);

            /// <summary>
            /// Gets all.
            /// </summary>
            /// <param name="entity">The entity.</param>
            /// <param name="paginate">The paginate.</param>
            /// <returns></returns>
            PagedListResult<TEntity> GetAll(TEntity entity = null, Paginate paginate = null);

            /// <summary>
            /// Gets the specified entity.
            /// </summary>
            /// <param name="entity">The entity.</param>
            /// <returns></returns>
            TEntity Get(TEntity entity);
        }
    
}
