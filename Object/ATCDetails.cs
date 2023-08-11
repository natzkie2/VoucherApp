using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Object
{
    class ATCDetails
    {
        private string id;
        private string name;
        private double percent;
        private string description;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Percent { get => percent; set => percent = value; }
    }
}
