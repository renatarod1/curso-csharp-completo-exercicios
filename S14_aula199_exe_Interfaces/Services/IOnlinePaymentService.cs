using System;
using System.Collections.Generic;
using System.Text;

namespace S14_aula199_exe_Interfaces.Services
{
    interface IOnlinePaymentService
    {
        public double Interest(double amount, int months);
        public double PaymentFee(double amount);
    }
}
