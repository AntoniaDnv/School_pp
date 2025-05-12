using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyStore.Payments
{
    public class ApplewalletPayment : IPaymentMethod
    {
        public string MethodName => "Apple pay";

        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Verifying face ID... Recognized! {Environment.NewLine} Payed: {amount}");
            return true;
        }
    }
}
