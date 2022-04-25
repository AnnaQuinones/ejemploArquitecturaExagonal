using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weelo2.Models
{
    public class OwnerRequest
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
        /// Photo
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Birthday
        /// </summary>
        public DateTime Birthday { get; set; }
    }

    public class OwnerResponse
    {
        /// <summary>
        /// IdOwner
        /// </summary>
        public string IdOwner { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Photo
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Birthday
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
