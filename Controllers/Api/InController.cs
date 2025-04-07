using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
//1
public class InController : Controller {
    [HttpGet("listar-propiedades-casa-terreno")]
    public IActionResult ListarPropiedadesCasaTerreno(){
        //Encuentra todas las propiedades cuyo tipo sea casa o terreno.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> tipos = new List<string>();
        tipos.Add("Casa");
        tipos.Add("Terreno");
        var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, tipos);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //2
    [HttpGet("listar-propiedades-agente")]
    public IActionResult ListarPropiedadesAgente(){
        //Encuentra todas las propiedades cuyo agente sea "Ana Torres" o "Juan Pérez"
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> agentes = new List<string>();
        agentes.Add("Ana Torres");
        agentes.Add("Juan Pérez");
        var filtro = Builders<Inmueble>.Filter.In(x => x.NombreAgente, agentes);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

}
