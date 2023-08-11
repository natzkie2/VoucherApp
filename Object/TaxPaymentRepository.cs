using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Object
{
    public class TaxPaymentRepository
    {
        private List<TaxPayment> taxPayments = new List<TaxPayment>();


        public void AddtaxPaymentList(TaxPayment newList)
        {
            taxPayments.Add(newList);
        }

        public List<TaxPayment> GetTaxPaymentList()
        {
            return taxPayments;
        }

    }
}
