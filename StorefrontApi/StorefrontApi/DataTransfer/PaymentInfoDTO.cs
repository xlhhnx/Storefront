using System;

namespace StorefrontApi.DataTransfer
{
    public class PaymentInfoDTO
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public string Cvn { get; set; }
        public string ZipCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        // TODO: Add alternative payment methods (e.g. paypal)
    }
}
