using Microsoft.AspNetCore.Mvc;
using OfQuala.Data;
using OfQuala.Model;

namespace OfQuala.Controllers
{
    [ApiController]
    [Route("api/sites")]
    public class SitesController:ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Site>>> Get()
        {
            var funcion = new Sites();
            var list = await funcion.ViewSite();
            return list;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<Site>>> GetId(int id)
        {
            var funcion = new Sites();
            var list = await funcion.ViewSiteId(id);
            return list;
        }
               

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Site parametros)
        {
            var funcion = new Sites();
            var list = await funcion.ViewSiteId(parametros.codigo);
            if (list.Count() > 0) {
                return new JsonResult( new { success = true, message = "El codigo ya esta registrado en la base de datos.", StatusCode = 404 });
            } else
            {
                await funcion.InsertSite(parametros);
                return new JsonResult(new { success = true, message = "Sucursal creada con exito.", StatusCode = 200 });
            }

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Site parametros)
        {
            var funcion = new Sites();
            parametros.codigo = id;
            await funcion.EditSite(parametros);
            return new JsonResult(new { success = true, message = "Sucursal modificada con exito.", StatusCode = 200 });
            //return Ok();

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var funcion = new Sites();
            await funcion.DeleteSite(id);
            return new JsonResult(new { success = true, message = "Sucursal eliminada con exito.", StatusCode = 200 });

        }
    }
}
