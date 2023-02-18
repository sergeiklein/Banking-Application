using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
// Need to create Bank App that will:
// 1. Will hadnle standard interaction with user
// 2. Will need to design and account class that will handle instances or bank accounts
// 3. Will need to create a class that will house checking and savings account
// 4. Main method will have menus with wich user can interact with. 
namespace Banking_Application
{//Will start with creating an account class
    public class Account
    {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        private int accountNumber;// will host account number
        private string accountType;// will check whether its savings or checking
        private double accountBalance;//will store specific account type ballance. 

        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }//in the future it might be better to use a decimal

        //Our constructor will accept input for three variables.  
        public Account(int accountNumber, double accountBalance, string accountType)//How to rephrase this.  "Lets make an account that will take inthe folllowing inputs"
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }
        //Deposit method will not have a return type. We dont need it since we are just depositing money. 
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Deposit(double money)//declaring return type for user input.
        {
            AccountBalance = AccountBalance + money; //make our account ballance equal account ballance plus money deposited. 
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //We will ask them how much they want to withdrawl
        //We will updated the ballance amount
        //make sure account doesnt go into negative
        // no return type again because we dont need anything.
        public void Withdrawl(double moneyOut) // declare variable for money they want to withdraw
        {
            if(AccountBalance >= moneyOut)
            {
                AccountBalance = AccountBalance - moneyOut;//Opposit of deposit
                Console.WriteLine("Money Withdrew " + moneyOut);
            }
            else
            {
                Console.WriteLine("Insufficinet funds");
            }
            
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //Need to crate a check account ballance
        //WE just need to tell them what their ballance is
        public void CheckAccount()
        {
            Console.WriteLine("Your available balance is " + AccountBalance);// not affected by methods
        }

        public void DisplayAccounts()
        {
            Console.WriteLine("Your account summary is \n" + "Account number" + AccountNumber + "\n" + "Account Type" + AccountType + "\n" + "$" + AccountBalance);
            Console.ReadLine(); 
        }

    }
}