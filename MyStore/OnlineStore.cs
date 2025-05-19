using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
	public class OnlineStore
	{
		public void Checkout(IPaymentMethod paymentMethod, decimal amount)
		{
			Console.WriteLine($"Checking out using {paymentMethod.MethodName}...");

			decimal discount = CalculateDiscount(amount);
			decimal finalAmount = amount - discount;

			Console.WriteLine($"You got a discount of {discount:C}! Final amount: {finalAmount:C}");

			bool success = paymentMethod.Pay(finalAmount);

			if (success)
			{
				Console.WriteLine("Payment successful!");
			}
			else
			{
				Console.WriteLine("Payment failed! Please cry quietly.");
			}
		}

		private decimal CalculateDiscount(decimal amount)
		{
			if (amount > 200) return 30;
			if (amount > 100) return 15;
			return 5;
		}

		
	}
}
