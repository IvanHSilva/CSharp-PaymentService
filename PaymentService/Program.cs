using PaymentService.Entities;
using PaymentService.Services;
using System;
using System.Globalization;

namespace PaymentService {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dados do Contrato");
            Console.Write("Número: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Parcelas: ");
            int installments = int.Parse(Console.ReadLine());
            
            Contract contract = new Contract(number, date, value);

            ContractService service = new ContractService(new PaypalService());
            service.ProcessContract(contract, installments);

            Console.WriteLine();
            Console.WriteLine("TOTAIS:");
            foreach (Installment inst in contract.Installments) {
                Console.WriteLine(inst);
            }
            Console.WriteLine();
        }
    }
}
