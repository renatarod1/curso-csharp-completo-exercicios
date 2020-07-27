using System;
using System.Collections.Generic;
using System.Text;

namespace S14_aula199_exe_Interfaces.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months) {
            return amount += amount * 0.01 * months; 
        }

        public double PaymentFee(double amount) {
            return amount += amount * 0.02;
        }
    }
}
