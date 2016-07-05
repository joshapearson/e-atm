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
			Account johnDoe = new Account();
			johnDoe.accountName = "John Doe";
			johnDoe.accountPin = "3456";
			johnDoe.amount = 5000;
			johnDoe.withdrawalNumber = 10;

			Account marySmith = new Account();
			marySmith.accountName = "Mary Smith";
			marySmith.accountPin = "6789";
			marySmith.amount = 10000;
			marySmith.withdrawalNumber = 10;

			Account johnSmith = new Account();
			johnSmith.accountName = " john Smith";
			johnSmith.accountPin = "1011";
			johnSmith.amount = 6500;
			johnSmith.withdrawalNumber = 10;

			List<Account> accounts = new List<Account>();
			accounts.Add(johnDoe);
			accounts.Add(marySmith);
			accounts.Add(johnSmith);
			while (true)
			{
				Console.WriteLine("please input a pin number");
				string pinHolder = Console.ReadLine();
				Account account = accounts.SingleOrDefault(a => a.accountPin == pinHolder);
				if (account != null)
				{
					double amount = account.amount, deposit, withdraw;
					int menuChoice = 0;					
					Console.WriteLine("Welcome to your account");
					Console.ReadLine();

					while (menuChoice != 4)
					{
						Console.WriteLine("Please Select an option from the list");
						Console.WriteLine("1. Check your Balance\n");
						Console.WriteLine("2. Withdraw Cash\n");
						Console.WriteLine("3. Make a Deposit\n");
						Console.WriteLine("4. Exit\n");
						bool validInput = int.TryParse(Console.ReadLine(), out menuChoice);
						if (!validInput)
						{
							Console.WriteLine("Invalid input.");
							continue;
						}

						switch (menuChoice)
						{
							case 1:
								Console.WriteLine("\n Your current Balance in $s : {0} ", amount);
								break;
							case 2:
								Console.WriteLine("\n please enter withdrawl amount: ");
								withdraw = int.Parse(Console.ReadLine());								

								if (withdraw > 1000)
								{
									Console.WriteLine("\n amount exceeds withdrawl limit");
								}
								else if(account.amount < withdraw)
								{
									Console.WriteLine("Available amount exceeded");
								}
								else
								{
									
									if(account.UsedAllWithdrawals())
									{
										Console.WriteLine("total withdrawals reached");
										break;
									}
									else
									{
										account.withdrawalNumber--;
										Console.WriteLine("You have {0} withdrawals left", account.withdrawalNumber );									
									}
									
									amount = amount - withdraw;
									Console.WriteLine("\n\n Please take your cash");
									Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
									account.amount = amount;																		
								}
								break;
							case 3:
								Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
								deposit = int.Parse(Console.ReadLine());
								amount = amount + deposit;
								Console.WriteLine("YOUR BALANCE IS {0}", amount);
								account.amount = amount;
								break;
							case 4:
								Console.WriteLine("\n Thank you for using the new E-ATM!");
								break;
							default:
								Console.WriteLine("\nPlease enter a valid option.");
								break;
						}
					}
				}

				else
				{
					
					Console.WriteLine("Pin not found");
				}
			}
		}

	}
}

