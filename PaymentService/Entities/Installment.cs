using System;
using System.Globalization;

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

        // Methods
        public override string ToString() {
            return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
