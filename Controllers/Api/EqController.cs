using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
//1
public class EqController : Controller {
    [HttpGet("propiedades-terrenos")]
    public IActionResult ObtenerPropiedadesTerrenos(){
        //Obtener las propiedades que son terrenos 

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }


//2
[HttpGet("listar-propiedades-renta")]
public IActionResult ObtenerPropiedadesRenta(){
    //Obtener las propiedades que son terrenos 

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Renta");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
}

//3
[HttpGet("listar-banios")]
public IActionResult ObtenerBanios(){
    //Encontrar propiedades que tienen un baño

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Banios, 1);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
}

//4
[HttpGet("listar-agencia")]
public IActionResult ObtenerAgencia(){
    //Encuentra todas las propiedades que pertenecen a la agencia "López Bienes Raíces".

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "López Bienes Raíces");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
}

//5
[HttpGet("listar-fecha_publicacion")]
public IActionResult ObtenerFechaPublicacion(){
    //Encuentra todas las propiedades publicadas en una fecha especifica, por ejemplo "2023-01-15"

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.FechaPublicacion, "2023-01-15");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
}

}