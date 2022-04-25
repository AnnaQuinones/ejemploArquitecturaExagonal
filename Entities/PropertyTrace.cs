using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class PropertyTrace
    {
        public int IdPropertyTrace { get; set; }
        public byte[] DateSale { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public int? Tax { get; set; }
        public int? IdProperty { get; set; }

        public virtual Property IdPropertyNavigation { get; set; }
    }
}
