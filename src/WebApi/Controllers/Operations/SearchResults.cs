namespace HomeBudgetManager.Services.Operations.WebApi.Controllers.Operations;

using System.Collections.ObjectModel;

public class SearchResults
{
    public SearchResults(
        IEnumerable<SearchResultItem> items,
        int totalCount)
    {
        this.Items = new([.. items]);
        this.TotalCount = totalCount;
    }

    public ReadOnlyCollection<SearchResultItem> Items { get; }

    public int TotalCount { get; }
}
