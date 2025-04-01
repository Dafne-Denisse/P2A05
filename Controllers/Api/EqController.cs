using Microsft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("propiedades-terrenos")]
    public IActionResult ObtenerPropiedadesTerrenos(){
        //Obtener las propiedades que son terrenos 
        //{}
    }
}