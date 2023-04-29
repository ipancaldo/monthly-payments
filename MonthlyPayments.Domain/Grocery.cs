using Newtonsoft.Json;

namespace MonthlyPayments.Domain
{
    public class Grocery
    {
        [JsonProperty("totalSpent")]
        public decimal TotalSpent { get; set; }

        [JsonProperty("lastPaymentAdded")]
        public string LastUpdate { get; set; } = DateTime.Now.ToString();
    }
}
