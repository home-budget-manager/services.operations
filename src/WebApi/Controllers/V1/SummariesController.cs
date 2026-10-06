namespace HomeBudgetManager.Services.Operations.WebApi.Controllers.V1;

using HomeBudgetManager.Services.Operations.WebApi.Controllers.V1.Summaries;

using Microsoft.AspNetCore.Mvc;

[Route("api/v1/[controller]")]
[ApiController]
public class SummariesController : ControllerBase
{
    [HttpGet("{accountId:guid}")]
    public IActionResult GetSummaries(Guid accountId)
    {
        var result = new GetSummariesResult(
            "USD",
            [
                new SummaryItem("incomes", 4, 5050M),
                new SummaryItem("expenses", 3, -1640.91M),
                new SummaryItem("transfersIncoming", 1, 28.5M),
                new SummaryItem("transfersOutgoing", 1, -1028.5M)
            ]);
        return this.Ok(result);
    }
}
