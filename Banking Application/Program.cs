// See https://aka.ms/new-console-template for more information
using Banking_Application;

Console.WriteLine("Hello, World!");


//Account myAccount = new Account(1111, 0, "Checking");
//Account myAccount2 = new Account(2222, 0, "Savings");
//Dictionary<string, Account> myMonies = new Dictionary<string, Account>();

//myMonies.Add(myAccount.AccountType, myAccount);
//myMonies.Add(myAccount2.AccountType, myAccount2);
//Bank myBank = new Bank(myMonies);
Account account3 = new Account(0, 0, " ");
Dictionary<string, Account> myDictionary = new Dictionary<string, Account>();
Bank myBank2 = new Bank(myDictionary);

int accNum = 3333;
bool isRunning = true;
while(isRunning)
{
    Console.Clear();
    Console.WriteLine("WElcome to C# Bank!! Choose and option below\n");
    Console.WriteLine("1.  Open a new account");
    Console.WriteLine("2.  Check your account balance");
    Console.WriteLine("3.  Make a withdrawl");
    Console.WriteLine("4.  Make a deposit");
    Console.WriteLine("5.  Close your account");
    Console.WriteLine("6.  Display account information");
    Console.WriteLine("E.  Exit");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("What kind of account would you like to open?");
            string choice = Console.ReadLine();
            if(choice == "checking")
            {
                account3.AccountType = "Checking";
                account3.AccountNumber = accNum;
                accNum++;
            }
            else if (choice == "savings")
            {
                account3.AccountType = "savings";
                account3.AccountNumber = accNum;
                accNum++;
            }
            //adding account3 to our empty dictionary
            myDictionary.Add(account3.AccountType, account3);
            myBank2 = new Bank(myDictionary);
            break;
        case "2":
            account3.CheckAccount();
            //myAccount.CheckAccount();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("How much money would you like to withdreawl?");
            double moneyOut = Convert.ToDouble(Console.ReadLine());
            account3.Withdrawl(moneyOut);
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            account3.Withdrawl(moneyOut);
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("How much would you like to deposit?");
            double moneyToDeposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You deposited $" + moneyToDeposit + "dollars");
            Console.ReadKey();
            account3.Deposit(moneyToDeposit);

            break;
        case "5":
            myBank2.closeAccount(account3);
            break;
        case "6":
            account3.DisplayAccounts();
            break;
        case "E":
            isRunning = false;
            break;
        default:
            break;
       
    }

}