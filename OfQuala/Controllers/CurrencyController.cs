using Microsoft.AspNetCore.Mvc;
using OfQuala.Data;
using OfQuala.Model;

namespace OfQuala.Controllers
{
    [ApiController]
    [Route("api/currency")]
    public class CurrencyController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Currency>>> Get()
        {
            var funcion = new Currencys();
            var list = await funcion.ViewCurrency();
            return list;
        }
    }
}
