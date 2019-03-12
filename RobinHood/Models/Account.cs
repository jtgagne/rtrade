using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RobinHood.Models
{
    public class Account
    {
        [JsonProperty(PropertyName = "rhs_account_number")]
        public string RhsAccountNumber { get; set; }

        [JsonProperty(PropertyName = "deactivated")]
        public bool Deactivated { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "margin_balances")]
        public MarginBalances Balances { get; set; }

        [JsonProperty(PropertyName = "portfolio")]
        public string PortfolioUrl { get; set; }

        [JsonProperty(PropertyName = "cash_balances")]
        public double? CashBalances { get; set; }

        [JsonProperty(PropertyName = "can_downgrade_to_cash")]
        public string CanDowngradeToCashUrl { get; set; }

        [JsonProperty(PropertyName = "withdrawal_halted")]
        public bool WithdrawlHalted { get; set; }

        [JsonProperty(PropertyName = "cash_available_for_withdrawal")]
        public double CashAvailableForWithdrawl { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "sma")]
        public int Sma { get; set; }

        [JsonProperty(PropertyName = "sweep_enabled")]
        public bool SweepEnabled { get; set; }

        [JsonProperty(PropertyName = "deposit_halted")]
        public bool DepositHalted { get; set; }

        [JsonProperty(PropertyName = "buying_power")]
        public double BuyingPower { get; set; }

        [JsonProperty(PropertyName = "user")]
        public string UserUrl { get; set; }

        [JsonProperty(PropertyName = "max_ach_early_access_amount")]
        public double EarlyAccessCashAmount { get; set; }

        [JsonProperty(PropertyName = "option_level")]
        public string OptionLevel { get; set; }

        [JsonProperty(PropertyName = "instant_eligibility")]
        public InstantEligibility Eligibility { get; set; }

        [JsonProperty(PropertyName = "cash_held_for_orders")]
        public double CashHeldForOrders { get; set; }

        [JsonProperty(PropertyName = "only_position_closing_trades")]
        public bool OnlyPositionClosingTrades { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "positions")]
        public string PositionsUrl { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "cash")]
        public double Cash { get; set; }

        [JsonProperty(PropertyName = "sma_held_for_orders")]
        public double SmaHeldForOrders { get; set; }

        [JsonProperty(PropertyName = "unsettled_debit")]
        public double UnsettledDebit { get; set; }

        [JsonProperty(PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "is_pinnacle_account")]
        public bool IsPinnacleAccount { get; set; }

        [JsonProperty(PropertyName = "uncleared_deposits")]
        public double UnclearedDeposits { get; set; }

        [JsonProperty(PropertyName = "unsettled_funds")]
        public string UnsettledFunds { get; set; }

        public Account()
        {
        }
    }
}
