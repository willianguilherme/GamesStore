using Asp.Versioning;
using GamesStore.API.Configurations;
using Microsoft.AspNetCore.Mvc;

namespace GamesStore.API.Controllers;

[ApiVersion(1, Deprecated = ApiVersionActiveConfiguration.ApiV1Deprecated)]
[ApiVersion(2, Deprecated = ApiVersionActiveConfiguration.ApiV2Deprecated)]
[Route("api/v{version:apiVersion}/[Controller]")]
[ApiController]
public class HealthCheckController : ControllerInitial
{
    [HttpGet()]
    [MapToApiVersion(1)]
    public IActionResult HealthCheckV1()
    {
        return Ok(new
        {
            ApiVersion = 1,
            SystemVersion = SystemConfiguration.SystemVersion,
        });
    }

    [HttpGet()]
    [MapToApiVersion(2)]
    public IActionResult HealthCheckV2()
    {
        return Ok(new
        {
            ApiVersion = 2,
            SystemVersion = SystemConfiguration.SystemVersion,
        });
    }
}
