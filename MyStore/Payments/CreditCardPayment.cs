using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Payments
{
    public class CreditCardPayment : IPaymentMethod
    {
        public string MethodName => "Credit card";

        public bool Pay(decimal amount)
        {
           Console.WriteLine($"Contact the card. {Environment.NewLine} Payed: {amount}"); 
            return true;
           
        }
    }
}
