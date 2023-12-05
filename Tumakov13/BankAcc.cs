using System;
using System.Collections.Generic;
using System.IO;

namespace Tumakov13
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
        private List<BankTransaction> transactionList = new List<BankTransaction>();
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

        public List<BankTransaction> TransactionList
        {
            get
            {
                return transactionList;
            }
        }

        public BankTransaction this[int index]
        {
            get
            {
                return transactionList[index];
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
                BankTransaction bankTransaction = new BankTransaction(-withdrawalAmount);
                transactionList.Add(bankTransaction);
                return true;
            }

            return false;
        }

        public bool PutMoney(decimal depositedAmoun)
        {
            if (depositedAmoun > 0)
            {
                accBalance += depositedAmoun;
                BankTransaction bankTransaction = new BankTransaction(depositedAmoun);
                transactionList.Add(bankTransaction);
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
                BankTransaction bankTransaction = new BankTransaction(-withdrawalAmount);
                transactionList.Add(bankTransaction);
                return true;
            }

            return false;
        }

        public void Dispose(BankAcc bankAccount)
        {
            for (int i = 0; i < transactionList.Count; i++)
            {
                BankTransaction transaction = transactionList[i];

                if (transaction.AmountChange < 0)
                {
                    File.AppendAllText("check", $"Снятие {transaction.TransactionDate}, {-transaction.AmountChange} рублей".ToString() + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText("check", $"Пополнение {transaction.TransactionDate}, {transaction.AmountChange} рублей".ToString() + Environment.NewLine);
                }
            }

            transactionList = new List<BankTransaction>();
            GC.SuppressFinalize(bankAccount);
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
            accBalance = 10000000;
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
