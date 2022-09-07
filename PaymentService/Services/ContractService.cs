using PaymentService.Entities;
using System;

namespace PaymentService.Services {
    public class ContractService {
        // Attributes
        private IOnlinePaymentService _payment;

        // Constructors
        public ContractService(IOnlinePaymentService payment) {
            _payment = payment;
        }

        // Methods
        public void ProcessContract(Contract contract, int months) {
            DateTime date;
            double value = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
                date = contract.Date.AddDays(i * 30);
                double interest = value + _payment.Interest(value, i);
                double payFee = interest + _payment.PaymentFee(interest);
                contract.AddInstallment(new Installment(date, payFee));
            }
        }
    }
}
