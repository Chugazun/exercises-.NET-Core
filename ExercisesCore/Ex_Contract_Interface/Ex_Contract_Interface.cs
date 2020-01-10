using ExercisesCore.Ex_Contract_Interface.Entities;
using ExercisesCore.Ex_Contract_Interface.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercisesCore.Ex_Contract_Interface
{
    class Ex_Contract_Interface
    {
        //    static void Main(string[] args)
        //    {
        //        Console.Write("Enter contract data\nNumber: ");
        //        int number = int.Parse(Console.ReadLine());

        //        Console.Write("Date (dd/MM/yyyy): ");
        //        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        //        Console.Write("Contract value: $");
        //        double totalValue = double.Parse(Console.ReadLine());

        //        Console.Write("Enter number of installments: ");
        //        int installmentNum = int.Parse(Console.ReadLine());

        //        Contract contract = new Contract(number, date, totalValue);

        //        for (int i = 0; i < installmentNum; i++)
        //        {
        //            Installment aux = new Installment();
        //            InstallmentService installmentService = new InstallmentService(totalValue / installmentNum, i + 1, new PayPalPaymentService());
        //            installmentService.CalculateInstallment(aux, contract.Date);
        //            contract.Installments.Add(aux);
        //        }
        //        Console.WriteLine("\nInstallments:");
        //        foreach (Installment item in contract.Installments)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
    }
}
