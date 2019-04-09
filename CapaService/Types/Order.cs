using System;
using System.Collections.Generic;
using System.Text;

namespace CapaService.Types
{
    /// <summary>
    /// Order Class.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        /// <value>
        /// The name of the property.
        /// </value>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        /// <value>
        /// The sort direction.
        /// </value>
        public SortDirection SortDirection { get; set; }
    }
}
