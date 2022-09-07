namespace PaymentService.Services {
    public interface IOnlinePaymentService {
        // Contracts
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
