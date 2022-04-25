using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SearchFilters
    {
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CodeInternal
        /// </summary>
        public string? CodeInternal { get; set; }

        /// <summary>
        /// PriceMin
        /// </summary>
        public int? PriceMin { get; set; }

        /// <summary>
        /// PriceMax
        /// </summary>
        public int? PriceMax { get; set; }
    }
}
