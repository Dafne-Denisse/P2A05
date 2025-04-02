using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
//1
public class GtController : Controller {
    [HttpGet("listar-propiedades-costo")]
    public IActionResult ObtenerPropiedadesCosto(){
        //Obtener las propiedades que son terrenos1-Encuentra todas las propiedades con un costo mayor a 500,000

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 500,000);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

//2
    [HttpGet("propiedades-terrenos")]
    public IActionResult ObtenerPropiedadesTerrenos(){
        //Obtener las propiedades que son terrenos 

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Tipo, "Terreno");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}