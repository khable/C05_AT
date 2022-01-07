using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClient
{
    public class BankAccount
    {
        #region Constants
        public const string DebitAmountExceedsBalanceMessage = "Debit Amount Exceeds Balance";
        public const string DebitAmountLessThanZeroMessage = "Debit Amount Less ThanZero";
        #endregion

        #region Constructors
        public BankAccount(string cn, double b)
        {
            CustomerName = cn;
            Balance = b;
        }
        #endregion

        #region Properties
        public string CustomerName { get; } //read-only
        public double Balance { get; set; } //read and write
        #endregion

        #region Methods
        public void Debit(double amount)
        {
            if (amount > Balance)
            {
                throw new System.ArgumentOutOfRangeException("amount",amount, DebitAmountExceedsBalanceMessage);
            }

            else if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }
            // Erro intencional
            //Balance += amount;  // Erro: estar a creditar em vez de debitar

            // Correção
            Balance -= amount;

        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance += amount;
        }
        #endregion
    }
}
