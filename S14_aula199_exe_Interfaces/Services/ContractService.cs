using System;
using System.Collections.Generic;
using System.Text;
using S14_aula199_exe_Interfaces.Entities;

namespace S14_aula199_exe_Interfaces.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {            
            for (int i = 1; i <= months; i++) {
                DateTime dueDate = contract.Date.AddMonths(i);
                double amount = contract.TotalValue / months;
                amount = _onlinePaymentService.Interest(amount, i);
                amount = _onlinePaymentService.PaymentFee(amount);
                Installment installment = new Installment(dueDate, amount);
                contract.Installments.Add(installment);
            }
        }
    }
}
