﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;//1-1 Relation
        private static int count = 1001;

        public Account()
        {
            accountNumber = count;
            count++; 
        }

        

        public Account( string accountName,double balance,Address address) : this()
        {
            
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public void Withdraw(double amount)
        {
            

        }

        public void Deposit(double amount)
        {

        }

        public void Transfer(double amount)
        {

        }



        public void ShowAccountInformation()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}",this.accountNumber,this.accountName,this.balance);
            this.address.PrintAddress();
        }
    }
}
