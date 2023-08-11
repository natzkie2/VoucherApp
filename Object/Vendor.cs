using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Object
{
    public class Vendor
    {
        private string name;
        private string address;
        private string tin;
        private string zip;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Tin { get => tin; set => tin = value; }
        public string Zip { get => zip; set => zip = value; }
    }
}
