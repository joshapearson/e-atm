using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_atm
{

    class program
        {
        static void Main(string[] args)
        {

           
        bool incorrectPin = true;
            
            while(incorrectPin)
            {
                Console.WriteLine("please input a pin number");
                string pinHolder = Console.ReadLine();
                if (pinHolder == "1234")
                {

                    int amount = 10000, deposit, withdraw;
                    int menuChoice = 0;                   
                    incorrectPin = false;
                    Console.WriteLine("Welcome to your account");
                    Console.ReadLine();

                    while (menuChoice != 4)
                    { 
                    Console.WriteLine("Please Select an option from the list");
                    Console.WriteLine("1. Check your Balance\n");
                    Console.WriteLine("2. Withdraw Cash\n");
                    Console.WriteLine("3. Make a Deposit\n");
                    Console.WriteLine("4. Exit\n");
                    menuChoice = int.Parse(Console.ReadLine());

                        switch (menuChoice)
                        {
                            case 1:
                                Console.WriteLine("\n Your current Balance in Rs : {0} ", amount);
                                break;
                            case 2:
                                Console.WriteLine("\n please enter withdrawl amount: ");
                                withdraw = int.Parse(Console.ReadLine());

                                if (withdraw % 1000 != 0)
                                {
                                    Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 10");
                                    Console.WriteLine("transaction maximum is $1000");
                                }

                                else if (withdraw > (amount - 1000))
                                {
                                    Console.WriteLine("\n amount exceeds withdrawl limit");
                                }
                                else
                                {
                                    amount = amount - withdraw;
                                    Console.WriteLine("\n\n Please take your cash");
                                    Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
                                    for (int i = 0; i < 10; i++)
                                    {
                                        if (i <= 10)
                                            continue;
                                        if (1 > 10)
                                            break;

                                    

                                
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                                deposit = int.Parse(Console.ReadLine());
                                amount = amount + deposit;
                                Console.WriteLine("YOUR BALANCE IS {0}", amount);
                                break;
                            case 4:
                                Console.WriteLine("\n Thank you for using the new E-ATM!");
                                break;
                            }
                        }
                }
   
                else
                {
                    incorrectPin = true;
                }
                
                
                    
             }
  
           }

        }

    }

