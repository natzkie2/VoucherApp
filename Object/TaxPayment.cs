using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Object
{
    public class TaxPayment
    {
        private string details;
        private string atc;
        private double firstQuarter;
        private double secondQuarter;
        private double thirdQuarter;
        private double total;
        private double tax;

        public string Details { get => details; set => details = value; }
        public string Atc { get => atc; set => atc = value; }
        public double FirstQuarter { get => firstQuarter; set => firstQuarter = value; }
        public double SecondQuarter { get => secondQuarter; set => secondQuarter = value; }
        public double ThirdQuarter { get => thirdQuarter; set => thirdQuarter = value; }
        public double Total { get => total; set => total = value; }
        public double Tax { get => tax; set => tax = value; }
    }
}
