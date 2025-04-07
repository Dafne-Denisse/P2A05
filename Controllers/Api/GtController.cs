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

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 500000);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

//2
    [HttpGet("pisos")]
    public IActionResult ObtenerPisos(){
        //Encuentra todas las propiedades con un mínimo de 120 metros de terreno.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //3
    [HttpGet("metros_terreno")]
    public IActionResult ObtenerMetrosTerreno(){
        //Encuentra todas las propiedades con más de 100 metros de terreno
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, 100);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

     //4
    [HttpGet("metros_construccion")]
    public IActionResult ObtenerMetrosConstruccion(){
        //Encuentra todas las propiedades con más de 150 metros de construcción.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 150);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

      //5
    [HttpGet("costo")]
    public IActionResult ObtenerCosto(){
        //Encuentra todas las propiedades cuyo costo sea mayor que 10,000
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 10000);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }



}