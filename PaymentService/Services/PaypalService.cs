using System;

namespace PaymentService.Services {
    public class PaypalService : IOnlinePaymentService {
        //Methods
        public double Interest(double amount, int months) {
            return amount * months * 0.01;
        }

        public double PaymentFee(double amount) {
            return amount * 0.02;
        }
    }
}
