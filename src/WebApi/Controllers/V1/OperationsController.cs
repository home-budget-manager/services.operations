namespace HomeBudgetManager.Services.Operations.WebApi.Controllers.V1;

using HomeBudgetManager.Services.Operations.WebApi.Controllers.V1.Operations;

using Microsoft.AspNetCore.Mvc;

[Route("api/v1/[controller]")]
[ApiController]

public class OperationsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> SearchOperations(
        [FromQuery] SearchCriteria criteria)
    {
        await Task.Yield();
        var result = new SearchResults(
            new[]
            {
                new SearchResultItem(
                    Guid.NewGuid(),
                    DateTime.Now,
                    "Expense",
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    "Grocery Shopping",
                    -50.33M,
                    "USD",
                    "1",
                    "1"
                ),
                new SearchResultItem(
                    Guid.NewGuid(),
                    DateTime.Now.AddHours(-5).AddMinutes(-43),
                    "Transfer",
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    "Transfer to savings account",
                    -520.12M,
                    "USD",
                    "2",
                    "2"
                ),
                new SearchResultItem(
                    Guid.NewGuid(),
                    DateTime.Now.AddHours(-8).AddMinutes(-84),
                    "Income",
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    "Salary",
                    12520.42M,
                    "USD",
                    "3",
                    "3"
                )
            },
            3
        );
        return this.Ok(result);
    }
}
