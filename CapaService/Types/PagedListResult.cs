using System;
using System.Collections.Generic;
using System.Text;

namespace CapaService.Types
{
    /// <summary>
    /// Paged List.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public class PagedListResult<TEntity>
    {
        ///// <summary>
        ///// Gets or sets a value indicating whether this instance has next.
        ///// </summary>
        ///// <value>
        /////   <c>true</c> if this instance has next; otherwise, <c>false</c>.
        ///// </value>
        //public bool HasNext { get; set; }

        ///// <summary>
        ///// Gets or sets a value indicating whether this instance has previous.
        ///// </summary>
        ///// <value>
        ///// <c>true</c> if this instance has previous; otherwise, <c>false</c>.
        ///// </value>
        //public bool HasPrevious { get; set; }

        ///// <summary>
        ///// Gets or sets the count.
        ///// </summary>
        ///// <value>
        ///// The count.
        ///// </value>
        //public long Count { get; set; }

        public Paginate Paginate { get; set; }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        public IEnumerable<TEntity> Entities { get; set; }
    }
}
