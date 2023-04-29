using Newtonsoft.Json;

namespace MonthlyPayments.Domain
{
    public class Grocery
    {
        public Grocery(decimal totalSpent,
                       bool isCreditCard)
        {
            TotalSpent = totalSpent;
            if (isCreditCard)
                CreditCard = totalSpent;
            else
                CashDebit = totalSpent;
        }

        [JsonProperty("totalSpent")]
        public decimal TotalSpent { get; set; }

        [JsonProperty("creditCard")]
        public decimal CreditCard { get; set; }
        
        [JsonProperty("cashDebit")]
        public decimal CashDebit { get; set; }

        [JsonProperty("lastPaymentAdded")]
        public string LastUpdate { get; set; } = DateTime.Now.ToString();

        public void UpdateGrocery(Grocery groceryResume)
        {
            TotalSpent += groceryResume.TotalSpent;
            if(groceryResume.CreditCard != 0)
                CreditCard += groceryResume.CreditCard;
            else
                CashDebit += groceryResume.CashDebit;
        }
    }
}
