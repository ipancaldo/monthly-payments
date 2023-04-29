using MonthlyPayments.Domain;

namespace MonthlyPayments.Service
{
    public interface IGroceryService
    {
        Task<Grocery> GetGroceryResume();

        Task UpdatePayment(string quantity, bool isCreditCard);
    }
}
