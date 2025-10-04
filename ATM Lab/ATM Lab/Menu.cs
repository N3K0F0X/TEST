//Cody griffith
//CSE-200 Lab 10
using account;

namespace Lab9
{
    internal class Menu
    {
        static void Main()
        {   
            Account[] atmAccounts = new Account[10];
            atmAccounts[0] = new Account("Bob", 2345, 1000, 1);
            atmAccounts[1] = new Account("Bill", 7564, 2000, 2);
            atmAccounts[2] = new Account("Barry", 2453, 3000, 3);
            atmAccounts[3] = new Account("Benson", 9375, 4000, 4);
            atmAccounts[4] = new Account("Bennet", 9638, 5000, 5);
            atmAccounts[5] = new Account("Barret", 5382, 6000, 6);
            atmAccounts[6] = new Account("Braxton", 7353, 7000, 7);
            atmAccounts[7] = new Account("Bently", 1037, 8000, 8);
            atmAccounts[8] = new Account("Braydon", 6492, 9000, 9);
            atmAccounts[9] = new Account("Blake", 0273, 10000, 10);

            bool ATM = true;
            while (ATM == true)
            {
                int menuLoop = 1;
                int loopCheck = 0;
                int pinLoop = 0;
                int Pin = 0;
                int atmidentity = 0;

                while (pinLoop == 0)
                {
                    Console.WriteLine("Hello, Please enter your Pin");
                    Pin = int.Parse(Console.ReadLine());


                    for (int i = 0; i < atmAccounts.Length; i++)
                        if (Pin == atmAccounts[i].pinNumber)
                        {
                            pinLoop++;
                            atmidentity = i;
                        }
                        

                }
                Console.WriteLine("Welcome " + atmAccounts[atmidentity].customerName + "!");
                while (menuLoop >= 1)
                {
                    Console.WriteLine("Please make a selection on what you wish to do next. To check your Balance, please press 1. To make a Withdrawl, please press 2. To Deposit, please press 3.");
                    int menuConsole = int.Parse(Console.ReadLine());

                    switch (menuConsole)
                    {
                        case 1:
                            Console.WriteLine("You have chosen to check your Balance");
                            if (Pin == atmAccounts[atmidentity].pinNumber)
                            {
                                Console.WriteLine("Your balance is " + atmAccounts[atmidentity].accountBalance + "$");
                            }
                            Console.WriteLine("Would you like to input another action? 1 for yes, 2 for no");
                            loopCheck = int.Parse(Console.ReadLine());
                            if (loopCheck == 1)
                            {
                                Console.WriteLine("Understood");
                                break;
                            }
                            else if (loopCheck == 2)
                            {
                                Console.WriteLine("Understood");
                                menuLoop--;

                            }
                            else if (loopCheck > 2)
                            {
                                Console.WriteLine("Please use a proper responce");
                            }
                            break;
                        case 2:
                            Console.WriteLine("You have chosen to Withdraw money");
                            Console.WriteLine("How much would you like to withdraw?");
                            int withdrawAmmount = int.Parse(Console.ReadLine());
                            if (Pin == atmAccounts[atmidentity].pinNumber)
                            {
                                if (atmAccounts[atmidentity].accountBalance < withdrawAmmount)
                                {
                                    Console.WriteLine("The withdraw cannot go through due to insufficent balance");
                                }
                                if (atmAccounts[atmidentity].accountBalance > withdrawAmmount)
                                {
                                    double value = atmAccounts[atmidentity].accountBalance - withdrawAmmount;
                                    atmAccounts[atmidentity].accountBalance = value;
                                    Console.WriteLine("Your remaining balance is " + atmAccounts[atmidentity].accountBalance + "$");
                                }
                            }
                            Console.WriteLine("Would you like to input another action? 1 for yes, 2 for no");
                            loopCheck = int.Parse(Console.ReadLine());
                            if (loopCheck == 1)
                            {
                                Console.WriteLine("Understood");
                                break;
                            }
                            else if (loopCheck == 2)
                            {
                                Console.WriteLine("Understood");
                                menuLoop--;

                            }
                            else if (loopCheck > 2)
                            {
                                Console.WriteLine("Please use a proper responce");
                            }
                            break;
                        case 3:
                            Console.WriteLine("You have chosen to Deposit money, How much would you like to deposit?");
                            int depositvalue = int.Parse(Console.ReadLine());
                            double Value2 = depositvalue + atmAccounts[atmidentity].accountBalance;
                            atmAccounts[atmidentity].accountBalance = Value2;
                            Console.WriteLine("Your Balance is now " + atmAccounts[atmidentity].accountBalance + "$");
                            Console.WriteLine("Would you like to input another action? 1 for yes, 2 for no");
                            loopCheck = int.Parse(Console.ReadLine());
                            if (loopCheck == 1)
                            {
                                Console.WriteLine("Understood");
                                break;
                            }
                            if (loopCheck == 2)
                            {
                                Console.WriteLine("Understood");
                                menuLoop--;

                            }
                            else if (loopCheck > 2)
                            {
                                Console.WriteLine("Please use a proper responce");
                            }
                            break;
                    }


                }
                Console.WriteLine("Would you like to input another Pin? 1 for Yes, 2 for No");
                int reloop = int.Parse(Console.ReadLine());
                if (reloop == 1)
                {
                    ATM = true;
                }
                if (reloop == 2)
                {
                    ATM = false;
                }
                else if (reloop > 2)
                {
                    Console.WriteLine("Please input a proper value");
                }



            }
            Console.WriteLine("Thank you, Have a nice day");
        }


    }
}
