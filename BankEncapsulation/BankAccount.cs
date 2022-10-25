using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
	public class BankAccount
	{
		private double balance = 0;

		public void Deposit(double amount)
		{
			Console.WriteLine($"An amount of ${amount} has been deposited.");
			Console.WriteLine($"\nNote: Please allow 2-3 business days for amount to post to your account.");
			balance += amount;
		}

		public double GetBalance()
		{
			
			return balance;
		}
	}
}
