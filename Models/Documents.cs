namespace API_ABS.Models
{
    public class Documents
    {
        public string numdoc { get; set; }
        public string creationDate { get; set; }
        public string documentDate { get; set; }
        public string debit { get; set; }
        public string currencyDebit { get; set; }
        public string amountDebit { get; set; }
        public string credit { get; set; }
        public string currencyCredit { get; set; }
        public string amountCredit { get; set; }
        public string BIKbankSender { get; set; }
        public string corrAccountBankSender { get; set; }
        public string innSender { get; set; }
        public string kppSender { get; set; }
        public string nameSender { get; set; }
        public string BIKbankRecipient { get; set; }
        public string corrAccountBankRecipient { get; set; }
        public string bankRecipient { get; set; }
        public string accountRecipient { get; set; }
        public string innRecipient { get; set; }
        public string kppRecipient { get; set; }
        public string nameRecipient { get; set; }
        public string paymentPurpose { get; set; }
        public string nomerDoc { get; set; }
    }
}