using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Bank
    {
        private string name;
        private Account[] accounts;//1-* Relation
        public Bank(string name,int size)
        {
            this.name = name;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }

        public void PrintAllAccounts()
        {
            for(int i=0;i<accounts.Length;i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].ShowAccountInformation();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if(accounts[i]==null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        public void SearchAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNo)
                {
                    accounts[i].ShowAccountInformation();
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                    
                }
            }
            if(flag==1)
                Console.WriteLine("Account Not Found");
        }


        public void DeleteAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNo)
                {
                    //accounts[i].PrintAccount();
                    flag = 0;
                    for (int j =i ; j < accounts.Length; j++)
                    { 
                       if(j<accounts.Length-1)
                        {
                            accounts[j] = null;

                        accounts[j] = accounts[j + 1];
                        
                        }
                       else
                        {
                            accounts[j] = null;
                        }
                    }
                    Console.WriteLine("Account Found and Deleted");
                    break;
                    
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }


        public void Transaction()
        {
            System.Console.WriteLine("Choose your Option:");
            System.Console.WriteLine("1. Withdraw \n2. Deposit \n3. Transfer");
            int x;
            x = System.Convert.ToInt32(System.Console.ReadLine());
            if(x==1)
            {
                
            }
        }
    }
}
