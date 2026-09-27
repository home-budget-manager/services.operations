namespace HomeBudgetManager.Services.Operations.WebApi.Controllers.V1;

using System.Collections.ObjectModel;
using System.Security.Cryptography;

using HomeBudgetManager.Services.Operations.WebApi.Controllers.V1.AccountBalance;

using Microsoft.AspNetCore.Mvc;

[Route("api/v1/[controller]")]
[ApiController]
public class AccountBalanceController : ControllerBase
{
    private readonly RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();

    [HttpGet("{accountId:guid}")]
    public IActionResult GetBalanceHistory(Guid accountId, [FromQuery] BalanceHistoryParameters parameters)
    {
        var startDate = DateTime.UtcNow;
        if (parameters.FromDate.HasValue)
        {
            startDate = parameters.FromDate.Value;
        }

        var endDate = DateTime.UtcNow;
        if (parameters.ToDate.HasValue)
        {
            endDate = parameters.ToDate.Value;
        }

        var entries = new Collection<BalanceHistoryItem>();
        var currentBalance = 12345.45M;
        for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            entries.Add(new BalanceHistoryItem(currentDate, currentBalance));
            var randomBytes = new byte[4];
            this.randomNumberGenerator.GetBytes(randomBytes);
            var randomValue = BitConverter.ToInt32(randomBytes, 0);
            var dailyChange = (randomValue % 40000 - 20000) / 100M;
            currentBalance += dailyChange;
        }

        var result = new BalanceHistoryResult(
            entries,
            "USD",
            entries.First().Balance,
            entries.Last().Balance);
        return this.Ok(result);
    }
}
