namespace HomeBudgetManager.Services.Operations.WebApi.Controllers.V1.AccountBalance;

using System.Collections.ObjectModel;

public class BalanceHistoryResult
{
    public BalanceHistoryResult(
        IEnumerable<BalanceHistoryItem> items,
        string currency,
        decimal startBalance,
        decimal endBalance)
    {
        this.Items = new ReadOnlyCollection<BalanceHistoryItem>([.. items]);
        this.Currency = currency;
        this.StartBalance = startBalance;
        this.EndBalance = endBalance;
    }

    public ReadOnlyCollection<BalanceHistoryItem> Items { get; }

    public string Currency { get; }

    public decimal StartBalance { get; }

    public decimal EndBalance { get; }
}
