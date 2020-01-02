using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Bank
{
    class BankAccount
    {
        public int AccNum { get; private set; }
        public string OwnerName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int accNum, string ownerName)
        {
            AccNum = accNum;
            OwnerName = ownerName;
            Balance = 0;
        }

        public BankAccount(int accNum, string ownerName, double depVal) : this (accNum, ownerName)
        {
            Deposit(depVal);
        }

        public void Deposit(double depVal)
        {
            Balance += depVal;
        }

        public void Withdraw(double drawVal)
        {
            Balance -= drawVal + 5;
        }

        public override string ToString()
        {
            return $"Conta: {AccNum}, Titular: {OwnerName}, Saldo: ${Balance.ToString("F2")}";
        }

        //Commit Test

    }
}
