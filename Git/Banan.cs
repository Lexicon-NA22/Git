using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    internal class Banan
    {
        public string Color { get; set; }
        public int Count { get; set; }

        [DisplayName("Davids Property")]
        public string DavidsPropertyNy { get; set; }

        public string Dimitris { get; set; }
        public string DimitrisPropNew { get; set; }
    }
}
