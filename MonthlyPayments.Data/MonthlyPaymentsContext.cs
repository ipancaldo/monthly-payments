using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace MonthlyPayments.Data
{
    public class MonthlyPaymentsContext
    {
        string AuthSecret = "u2CCPJeUVfdLN0IMJNOkbfAIMBQawB2Hb6UgRfZJ";
        string BasePath = "https://monthlypayments-576de-default-rtdb.europe-west1.firebasedatabase.app/";

        public MonthlyPaymentsContext()
        {
            var credentials = GoogleCredential.FromFile(AuthSecret);

            var app = FirebaseApp.Create(new AppOptions
            {
                Credential = credentials
            });
        }
    }
}
