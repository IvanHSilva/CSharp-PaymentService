namespace PaymentService.Services {
    public interface IOnlinePaymentService {
        // Contracts
        double PaymentFee(double Amount);
        double Interest(double Amount, int Months);
    }
}
