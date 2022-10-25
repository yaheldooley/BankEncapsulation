using System.Security.AccessControl;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            //account.Deposit(500.48);

            bool active = true;
            do
            {
                Console.WriteLine("Welcome to TrueCoders Bank!\n");

                Console.WriteLine("Enter the number of the action you would like to do and press RETURN key.");
                Console.WriteLine($"---- 1. See ACCOUNT BALANCE");
				Console.WriteLine($"---- 2. Make DEPOSIT");
                int value;
				if (int.TryParse(Console.ReadLine(), out value))
                {
                    switch(value)
                    {
                        case 1:
							Console.WriteLine($"--------------------------------------");
							Console.WriteLine($"Your pending balance is: ${account.GetBalance()}");
							Console.WriteLine($"--------------------------------------\n");
							Console.WriteLine("Press RETURN key to continue...");
                            Console.ReadLine();
							break;

                        case 2:
                            bool depositing = true;
                            do
                            {
								Console.WriteLine($"--------------------------------------");
								Console.WriteLine($"How much would you like to deposit?");
								Console.WriteLine($"--------------------------------------\n");
								Console.WriteLine("Press RETURN key to submit amount...Entering 0 will Exit");
                                double deposit;
                                if (double.TryParse(Console.ReadLine(), out deposit))
                                {
                                    if (deposit == 0) break;
                                    else account.Deposit(deposit);
									Console.WriteLine("Press RETURN key to continue...");
                                    Console.ReadLine();
                                    depositing = false;
								}
                                else
                                {
                                    Console.WriteLine("Invalid number. Press RETURN key to try again.");
									Console.ReadLine();
								}

							} while (depositing);
                            break;

                        default:
                            Console.WriteLine("Invalid input. Try again");
                            break;
                    }
                    Console.Clear();
                }
            } while (active);

        }
    }
}
