using Microsoft.AspNetCore.Mvc;
using RuleEngin.Interface;

namespace RuleEngin.Controllers;

[ApiController]
[Route("[controller]")]
public class RuleEnginController : ControllerBase
{
    private readonly IClassService _classService;
    public RuleEnginController(IClassService classService)
    {
        _classService = classService;
    }

    [HttpGet]
    public async Task GetUserSqliteFile()
    {
       await _classService.GetPmSqliteFileService();
    }
}