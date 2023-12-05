using System;

namespace Tumakov13
{
    class BankTransaction
    {
        private DateTime transactionDate;
        private decimal amountChange;

        public DateTime TransactionDate
        {
            get
            {
                return transactionDate;
            }
        }

        public decimal AmountChange
        {
            get
            {
                return amountChange;
            }
        }

        public BankTransaction(decimal amountChange)
        {
            this.amountChange = amountChange;
            transactionDate = DateTime.Now;
        }
    }
}
