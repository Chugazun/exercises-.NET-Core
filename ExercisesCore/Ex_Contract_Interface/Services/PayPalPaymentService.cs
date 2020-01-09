namespace ExercisesCore.Ex_Contract_Interface.Services
{
    class PayPalPaymentService : IPaymentService
    {
        public double Payment(double price, int monthAmount)
        {
            double monthlyPrice = price + (price * 0.01 * monthAmount);

            return monthlyPrice + (monthlyPrice * 0.02);
        }
    }
}
