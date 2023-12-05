using System;
using System.Diagnostics;

namespace Tumakov14
{
    public enum AccType
    {
        Текущий_счет,
        Сберегательный_счет
    }

    class BankAcc
    {
        private static int numOfBankAccs;
        private int accNum;
        private decimal accBalance;
        private string accHolder;
        private AccType bankAccType;

        public int AccNum
        {
            get
            {
                return accNum;
            }
        }

        public decimal AccBalance
        {
            get
            {
                return accBalance;
            }
        }

        public string AccHolder
        {
            get
            {
                return accHolder;
            }
            set
            {
                accHolder = value;
            }
        }

        public AccType BankAccType
        {
            get
            {
                return bankAccType;
            }
        }

        private void ChangeNumOfBankAccs()
        {
            numOfBankAccs++;
        }

        public bool MoreMoney(decimal withdrawalAmount)
        {
            if ((accBalance - withdrawalAmount > 0) && (withdrawalAmount > 0))
            {
                accBalance -= withdrawalAmount;
                return true;
            }

            return false;
        }

        public bool PutMoney(decimal depositedAmoun)
        {
            if (depositedAmoun > 0)
            {
                accBalance += depositedAmoun;
                return true;
            }

            return false;
        }

        public bool TransMoney(BankAcc withdrawalAccount, decimal withdrawalAmount)
        {
            if ((withdrawalAmount > 0) && (withdrawalAccount.AccBalance - withdrawalAmount > 0))
            {
                accBalance += withdrawalAmount;
                withdrawalAccount.accBalance -= withdrawalAmount;
                return true;
            }

            return false;
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"{bankAccType} под номером {accNum}: {accBalance} рублей. Владелец {accHolder}");
        }

        public BankAcc(decimal accBalance, string bankAccHolder)
        {
            this.accBalance = accBalance;
            this.accHolder = bankAccHolder;
            bankAccType = AccType.Текущий_счет;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public BankAcc(AccType bankAccType)
        {
            this.bankAccType = bankAccType;
            accBalance = 0;
            accHolder = "Рустам";
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public BankAcc(decimal accBalance, AccType bankAccType)
        {
            this.accBalance = accBalance;
            this.bankAccType = bankAccType;
            accHolder = "Рустам";
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }
    }
}
