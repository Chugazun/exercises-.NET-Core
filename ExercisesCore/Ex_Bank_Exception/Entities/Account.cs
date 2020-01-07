﻿using ExercisesCore.Ex_Bank_Exception.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Bank_Exception.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount <= 0) throw new DomainException("Not enough balance");
            if (amount > WithdrawLimit) throw new DomainException("The amount exceeds withdraw limit");
            Balance -= amount;            
        }
    }
}