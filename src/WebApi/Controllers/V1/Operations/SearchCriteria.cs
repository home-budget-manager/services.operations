namespace HomeBudgetManager.Services.Operations.WebApi.Controllers.V1.Operations;

public class SearchCriteria
{
    public string? AccountId { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public string? OperationType { get; set; }

    public int? Page { get; set; }

    public int? PageSize { get; set; }
}
