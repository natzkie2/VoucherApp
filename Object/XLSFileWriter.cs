using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Object
{
    public class XLSFileWriter
    {
        private string isSelfService;
        private double checkAmount;
        private string sourceAccount;
        private string isPayeeAccountOnly;
        private string checkDate;
        private string preferredCheckNumber;
        private string usePreferredCheckNumber;
        private string payeeName;
        private string payeeEmail;
        private string countryCode;
        private string mobileNumber;
        private string clientReferenceNumber;
        private string pickupOrDelivery;
        private string pickupBranchCode;
        private string deliveryAddressCode;
        private string isClaimantPayee;
        private string authorizedRepresentative;
        private string validIdNumber;
        private string particulars;
        private string remarks;

        public string IsSelfService { get => isSelfService; set => isSelfService = value; }
        public double CheckAmount { get => checkAmount; set => checkAmount = value; }
        public string SourceAccount { get => sourceAccount; set => sourceAccount = value; }
        public string IsPayeeAccountOnly { get => isPayeeAccountOnly; set => isPayeeAccountOnly = value; }
        public string CheckDate { get => checkDate; set => checkDate = value; }
        public string PreferredCheckNumber { get => preferredCheckNumber; set => preferredCheckNumber = value; }
        public string UsePreferredCheckNumber { get => usePreferredCheckNumber; set => usePreferredCheckNumber = value; }
        public string PayeeName { get => payeeName; set => payeeName = value; }
        public string PayeeEmail { get => payeeEmail; set => payeeEmail = value; }
        public string CountryCode { get => countryCode; set => countryCode = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public string ClientReferenceNumber { get => clientReferenceNumber; set => clientReferenceNumber = value; }
        public string PickupOrDelivery { get => pickupOrDelivery; set => pickupOrDelivery = value; }
        public string PickupBranchCode { get => pickupBranchCode; set => pickupBranchCode = value; }
        public string DeliveryAddressCode { get => deliveryAddressCode; set => deliveryAddressCode = value; }
        public string IsClaimantPayee { get => isClaimantPayee; set => isClaimantPayee = value; }
        public string AuthorizedRepresentative { get => authorizedRepresentative; set => authorizedRepresentative = value; }
        public string ValidIdNumber { get => validIdNumber; set => validIdNumber = value; }
        public string Particulars { get => particulars; set => particulars = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
