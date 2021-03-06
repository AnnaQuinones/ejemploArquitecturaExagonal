using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Owner
    {
        public Owner()
        {
            Property = new HashSet<Property>();
        }

        public int IdOwner { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual ICollection<Property> Property { get; set; }
    }
}
