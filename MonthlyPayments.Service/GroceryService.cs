using MonthlyPayments.Domain;
using MonthlyPayments.FirebaseRepository;

namespace MonthlyPayments.Service
{
    public class GroceryService : IGroceryService
    {
        private readonly IGroceryRepository _groceryRepository;
        public GroceryService(IGroceryRepository groceryRepository)
        {
            _groceryRepository = groceryRepository;
        }

        public async Task<Grocery> GetGroceryResume()
        {
            return await _groceryRepository.GetGroceryResume();
        }

        public async Task UpdatePayment(string quantity)
        {
            await _groceryRepository.UpdatePayment(decimal.Parse(quantity));
        }
    }
}
