using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using S11_aula146_exeExceptions.Entities.Exceptions;

namespace S11_aula146_exeExceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double initialBalance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Deposit(initialBalance);
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void WithDraw(double amount) {
            if (amount > WithdrawLimit) {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");               
            } else if  (amount > Balance) {
                throw new DomainException("Withdraw error: Not enough balance");
            } else {
                Balance -= amount;                
            }
        }

        public override string ToString() {
            return Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
