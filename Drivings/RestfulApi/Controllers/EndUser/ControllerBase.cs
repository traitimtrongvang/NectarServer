using Microsoft.AspNetCore.Mvc;

namespace RestfulApi.Controllers.EndUser;

[ApiController]
[Route("api/user/[controller]")]
public abstract class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase 
{
}