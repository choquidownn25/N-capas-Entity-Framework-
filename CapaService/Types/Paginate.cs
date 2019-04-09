using System;
using System.Collections.Generic;
using System.Text;

namespace CapaService.Types
{
    /// <summary>
    /// Paginate Class.
    /// </summary>
    public class Paginate
    {
        /// <summary>
        /// Gets or sets the index of the page.
        /// </summary>
        /// <value>
        /// The index of the page.
        /// </value>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the total records.
        /// </summary>
        /// <value>
        /// The total records.
        /// </value>
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets the order properties.
        /// </summary>
        /// <value>
        /// The order properties.
        /// </value>
        public List<Order> OrderProperties { get; set; }
    }
}
