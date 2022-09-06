using System;

namespace PaymentService.Entities {
    public class Installment {
        // Attributes
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        // Constructors
        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
