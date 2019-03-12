using System;
using Newtonsoft.Json;

namespace RobinHood.Models
{
    public class MarginBalances
    {
        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "gold_equity_requirement")]
        public double GoldEquityRequirement { get; set; }

        [JsonProperty(PropertyName = "cash_held_for_restrictions")]
        public double CashHeldForRestrictions { get; set; }

        [JsonProperty(PropertyName = "outstanding_interest")]
        public double OutstandingInterest { get; set; }

        [JsonProperty(PropertyName = "cash_pending_from_options_events")]
        public double CashPendingFromOptionsEvents { get; set; }

        [JsonProperty(PropertyName = "cash_held_for_options_collateral")]
        public double CashHeldForOptionsCollateral { get; set; }

        [JsonProperty(PropertyName = "uncleared_nummus_deposits")]
        public double UnclearedNummusDeposits { get; set; }

        [JsonProperty(PropertyName = "overnight_ratio")]
        public double OvernightRatio { get; set; }

        [JsonProperty(PropertyName = "day_trade_buying_power")]
        public double DayTradeBuyingPower { get; set; }

        [JsonProperty(PropertyName = "cash_available_for_withdrawal")]
        public double CashAvailableForWithdrawl { get; set; }

        [JsonProperty(PropertyName = "sma")]
        public double Sma { get; set; }

        [JsonProperty(PropertyName = "cash_held_for_nummus_restrictions")]
        public double CashHeldForNummusRestrictions { get; set; }

        [JsonProperty(PropertyName = "marked_pattern_day_trader_date")]
        public string MarkedPatternDayTraderDate { get; set; }

        [JsonProperty(PropertyName = "unallocated_margin_cash")]
        public double UnallocatedMarginCash { get; set; }

        [JsonProperty(PropertyName = "day_trades_protection")]
        public bool DayTradesProtection { get; set; }

        [JsonProperty(PropertyName = "start_of_day_dtbp")]
        public double StartOfTheDayDtbp { get; set; }

        [JsonProperty(PropertyName = "overnight_buying_power_held_for_orders")]
        public double OvernightBuyingPowerHeld { get; set; }

        [JsonProperty(PropertyName = "day_trade_ratio")]
        public double DayTradeRatio { get; set; }

        [JsonProperty(PropertyName = "cash_held_for_orders")]
        public double CashHeldForOrders { get; set; }

        [JsonProperty(PropertyName = "unsettled_debit")]
        public double UnsettledDebit { get; set; }

        [JsonProperty(PropertyName = "day_trade_buying_power_held_for_orders")]
        public double DayTradeBuyingPowerHeldForOrders { get; set; }

        [JsonProperty(PropertyName = "cash_held_for_dividends")]
        public double CashHeldForDividends { get; set; }

        [JsonProperty(PropertyName = "cash")]
        public double Cash { get; set; }

        [JsonProperty(PropertyName = "start_of_day_overnight_buying_power")]
        public double StartOfTheDayOvernightBuyingPower { get; set; }

        [JsonProperty(PropertyName = "margin_limit")]
        public double MarginLimit { get; set; }

        [JsonProperty(PropertyName = "overnight_buying_power")]
        public double OvernightBuyingPower { get; set; }

        [JsonProperty(PropertyName = "uncleared_deposits")]
        public double UnclearedDeposits { get; set; }

        [JsonProperty(PropertyName = "unsettled_funds")]
        public double UnsettledFunds { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        public MarginBalances()
        {
        }
    }
}
