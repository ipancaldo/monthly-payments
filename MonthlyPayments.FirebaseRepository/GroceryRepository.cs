using Firebase.Database;
using MonthlyPayments.Domain;
using Newtonsoft.Json;

namespace MonthlyPayments.FirebaseRepository
{
    public class GroceryRepository : IGroceryRepository
    {
        private const string FirebaseDatabaseUrl = "https://monthlypayments-576de-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly FirebaseClient _firebaseClient;

        public GroceryRepository()
        {
            _firebaseClient = new FirebaseClient(FirebaseDatabaseUrl);
        }

        public async Task<Grocery> GetGroceryResume()
        {
            return await _firebaseClient.Child("grocery").OnceSingleAsync<Grocery>();
        }

        public async Task UpdatePayment(Grocery groceryResume)
        {
            await _firebaseClient.Child("grocery").PutAsync(JsonConvert.SerializeObject(groceryResume));
        }
    }
}
