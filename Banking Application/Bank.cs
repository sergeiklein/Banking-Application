using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    //This class is ging to use dictionary to store checking and savings accounts
    public class Bank
    {
        //We chose dictionary because its like a list that will hold options for us but those options will have unique identifyers (account numbers) aka keys.
        private Dictionary<string, Account> bankAccounts = new Dictionary<string, Account>(); //key "string" will be the either checking or savings account 
        public Dictionary<string, Account> BankAccounts { get; set;}//---------------------------------property

        public Bank(Dictionary<string, Account> accounts)// ------------------------------------------constructor
        {
            BankAccounts = bankAccounts;
        }
        public Dictionary<string, Account> GetAllAccounts()//-----------------------------create a method that returns our dictionary
        {
            return BankAccounts;//returning dictionary variable
        }

        public void OpenNewAccount(Account account)//need to open an account aka add an account to our dictionary
        {
            bankAccounts. Add(account.AccountType, account);
        }

        public Account getAccount(string accountType)
        {
            return BankAccounts[accountType];//How we access dictionary
        }
        public void closeAccount(Account account)
        {
            bankAccounts.Remove(account.AccountType);
        }

    }
}
