using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ABS.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CreatingTransactionController : ControllerBase
  {

    [HttpGet(Name = "GetCreatingTransaction")]
    public string Get()
    {
      return "";
    }
  }
}
