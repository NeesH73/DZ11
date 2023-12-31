﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace Tymakov14
{
    internal class Bank2
    {
        private static int generationnumber = 1;
        private int account_number;
        private double account_balance;
        private List<BankTransaction> transactions = new List<BankTransaction>();
        private BankType account_type;
        private string holder;
        public int AccountNumber
        {
            get { return account_number; }
        }
        public double AccountBalance
        {
            get { return account_balance; }
        }
        public BankType AccountType
        {
            get { return account_type; }
        }
        public string Holder
        {
            get { return holder; }
            set { holder = value; }
        }
        internal List<BankTransaction> Transactions
        { get { return transactions; } }
        public BankTransaction this[int index]
        {
            get
            {
                return transactions[index];
            }
        }
        private void GenerationNumber()
        {
            generationnumber++;
        }
        public void DepositMoney(double amount)
        {
            if (amount > 0)
            {
                account_balance += amount;
                BankTransaction bankTransaction = new BankTransaction(amount);
                transactions.Add(bankTransaction);
                Console.WriteLine($"Счет пополнен на - {amount} , текущий баланс -{account_balance} ");
            }
            else
            {
                Console.WriteLine("Введите число больше 0");
            }

        }
        public bool WithdrawMoney(double amount)
        {
            if (amount > 0)
            {
                if (amount <= account_balance)
                {
                    account_balance -= amount;
                    BankTransaction bankTransaction = new BankTransaction(amount);
                    transactions.Add(bankTransaction);
                    Console.WriteLine($"Со счета было снято - {amount} , текущий баланс - {account_balance}");
                    return true;
                }
                else
                {
                    Console.WriteLine("На балансе недостаточно средств");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Введите число больше 0");
                return false;
            }

        }
        public void Transfer(Bank1 bank, double amount)
        {
            if (WithdrawMoney(amount))
            {
                bank.DepositMoney(amount);
                BankTransaction bankTransaction = new BankTransaction(amount);
                transactions.Add(bankTransaction);
                Console.WriteLine("Перевод был успешно проведен");
            }
            else { Console.WriteLine("Не удалось провести перевод"); }
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"{account_type} под номером {account_number}: {account_balance} рублей. Владелец {holder}");
        }
        
        public Bank2(double account_balance, string holder)
        {
            this.account_balance = account_balance;
            this.holder = holder;
            account_type = BankType.current;
            account_number = generationnumber;
            GenerationNumber();
        }
        public Bank2(BankType account_type)
        {
            this.account_type = account_type;
            account_balance = 0;
            account_number = generationnumber;
            GenerationNumber();
        }
        public Bank2(double account_balance, BankType account_type)
        {
            this.account_balance = account_balance;
            this.account_type = account_type;
            account_number = generationnumber;
            GenerationNumber();
        }
        public Bank2()
        {
            account_balance = 0;
            account_type = BankType.current;
            account_number = generationnumber;
            GenerationNumber();
        }
    }
}
