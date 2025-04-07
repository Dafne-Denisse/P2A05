using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
//1
public class GteController : Controller {
    [HttpGet("costo")]
    public IActionResult ObtenerCosto(){
        //Encuentra todas las propiedades con un costo o igual a 750000.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 750000);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

  //2
    [HttpGet("metros_terreno")]
    public IActionResult ObtenerMetrosTerreno(){
        //Encuentra todas las propiedades con un mínimo de 120 metros de terreno.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 120);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

     //3
    [HttpGet("baños")]
    public IActionResult ObtenerBanios(){
        //Encuentra todas las propiedades con al menos 3 baños.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Banios, 3);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

     //4
    [HttpGet("metros_terreno")]
    public IActionResult ObtenerMetrtosTerreno(){
        //Encuentra todas las propiedades con un mínimo de 120 metros de terreno.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 120);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

     //5
    [HttpGet("fecha_publicacion")]
    public IActionResult ObtenerFechaPublicacion(){
        //Encuentra todas las propiedades en venta cuya fecha de publicación sea el 1 de enero de 2023 o posterior.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.FechaPublicacion, "2023-01-01");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    
    }

