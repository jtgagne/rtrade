using System;
using Newtonsoft.Json;

namespace RobinHood.Models
{
    public class InstantEligibility
    {
        [JsonProperty(PropertyName = "reinstatement_date")]
        public string ReinstatementDate { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        [JsonProperty(PropertyName = "additional_deposit_needed")]
        public double AdditionalDepositNeeded { get; set; }

        [JsonProperty(PropertyName = "reversal")]
        public string Reversal { get; set; }

        public InstantEligibility()
        {
        }
    }
}
