using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]

//1
public class LtController : Controller {
    [HttpGet("listar-propiedades-costo")]
    public IActionResult ObtenerCosto(){
        //Seleccione todos los registros donde el costo sea menor que 300000.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 300000);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //2
    [HttpGet("listar-propiedades-metros_construccion")]
    public IActionResult ObtenerMetrosConstruccion(){
        //Seleccione todos los registros donde los metros de construcción sean menores que 80..

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 80);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    
    //3
    [HttpGet("listar-propiedades-pisos")]
    public IActionResult ObtenerPisos(){
        //Seleccione todos los registros donde el número de pisos sea menor que 2.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //4
    [HttpGet("listar-propiedades-baños")]
    public IActionResult ObtenerBaños(){
        //Seleccione todos los registros donde el número de baños sea menor que 1.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Banios, 1);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //5
    [HttpGet("listar-propiedades-metros_terreno")]
    public IActionResult ObtenerMetrosTerreno(){
        //Seleccione todos los registros donde los metros de terreno sean menores que 150.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 150);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

}

