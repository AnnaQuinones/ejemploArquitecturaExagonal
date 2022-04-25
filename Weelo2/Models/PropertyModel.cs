using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weelo2.Models
{
    public class PropertyRequest
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// CodeInternal
        /// </summary>
        public string CodeInternal { get; set; }

        /// <summary>
        /// Year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// IdOwner
        /// </summary>
        public int IdOwner { get; set; }
    }

    public class PropertyResponse
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// CodeInternal
        /// </summary>
        public string CodeInternal { get; set; }

        /// <summary>
        /// Year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// IdOwner
        /// </summary>
        public int IdOwner { get; set; }
    }
}
