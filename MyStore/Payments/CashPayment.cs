using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Payments
{
    public class CashPayment : IPaymentMethod
    {
        public string MethodName => "Cash pay";

        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Counting the cash... {Environment.NewLine} Payed: {amount}");
            return true;
        }
    }
}
