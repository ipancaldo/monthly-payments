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

        public async Task UpdatePayment(string quantity, bool isCreditCard)
        {
            var groceryResume = await GetGroceryResume();
            groceryResume.UpdateGrocery(new Grocery(decimal.Parse(quantity), isCreditCard));            
            await _groceryRepository.UpdatePayment(groceryResume);
        }
    }
}
