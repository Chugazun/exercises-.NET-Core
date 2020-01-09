using ExercisesCore.Ex_Contract_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Contract_Interface.Services
{
    class InstallmentService
    {
        public double InstallmentPrice { get; set; }
        public int MonthAmount { get; set; }        
        IPaymentService PaymentService;

        public InstallmentService(double installmentPrice, int monthAmount, IPaymentService paymentService)
        {
            InstallmentPrice = installmentPrice;
            MonthAmount = monthAmount;
            PaymentService = paymentService;
        }

        public void CalculateInstallment(Installment installment, DateTime contractDate)
        {
            installment.Amount = PaymentService.Payment(InstallmentPrice, MonthAmount);
            installment.DueDate = contractDate.AddMonths(MonthAmount);
        }
    }
}
