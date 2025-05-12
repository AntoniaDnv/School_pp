using MyStore;
using MyStore.Payments;
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		var paymentMethods = new List<IPaymentMethod>
		{
			new CreditCardPayment(), new ApplewalletPayment(), new CashPayment()
		};

		Console.WriteLine("=== Welcome to MyOnlineStore ===");
		Console.WriteLine("Please choose a payment method:");

		for (int i = 0; i < paymentMethods.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {paymentMethods[i].MethodName}");
		}

		int choice = GetUserChoice(1, paymentMethods.Count);

		IPaymentMethod selectedMethod = paymentMethods[choice - 1];

		Console.Write("\nEnter total amount to pay (e.g. 123.45): ");
		decimal amount = GetDecimalAmount();

		OnlineStore store = new OnlineStore();
		store.Checkout(selectedMethod, amount);

		Console.WriteLine("\nThank you for shopping! Press any key to exit.");
		Console.ReadKey();
	}

	static int GetUserChoice(int min, int max)
	{
		int choice;
		while (true)
		{
			Console.Write("Your choice: ");
			if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
				break;
			Console.WriteLine("Invalid choice. Try again.");
		}
		return choice;
	}

	static decimal GetDecimalAmount()
	{
		decimal amount;
		while (true)
		{
			if (decimal.TryParse(Console.ReadLine(), out amount) && amount > 0)
				break;
			Console.Write("Invalid amount. Try again: ");
		}
		return amount;
	}
}
