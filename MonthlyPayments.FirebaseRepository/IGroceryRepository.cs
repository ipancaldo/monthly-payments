using MonthlyPayments.Domain;

namespace MonthlyPayments.FirebaseRepository
{
    public interface IGroceryRepository
    {
        Task<Grocery> GetGroceryResume();

        Task UpdatePayment(decimal quantity);
    }
}
