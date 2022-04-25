using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weelo2.Models
{
    public class PropertyImageRequest
    {
        /// <summary>
        /// File
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// IdProperty
        /// </summary>
        public int IdProperty { get; set; }
    }

    public class PropertyImageResponse
    {
        /// <summary>
        /// IdPropertyImage
        /// </summary>
        public int IdPropertyImage { get; set; }

        /// <summary>
        /// File
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// IdProperty
        /// </summary>
        public int IdProperty { get; set; }
    }
}
