using API_ABS.Business.GetAccountStatement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ABS.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AccountStatementController : ControllerBase
  {
    [HttpGet(Name = "GetAccountStatement")]
    public string Get()
    {
      AccStatement accStatement = new AccStatement();
      accStatement.Get();



      return "";
    }
  }
}
