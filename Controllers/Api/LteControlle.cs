using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]

//1
public class LteController : Controller {
    [HttpGet("listar-propiedades-costo")]
    public IActionResult ListarPropiedadesCosto(){
        //Seleccione todos los registros donde el costo sea menor o igual a 500000.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 500000);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

//2
    [HttpGet("listar-propiedades-metros_construccion")]
    public IActionResult ListarPropiedadesMetrosConstruccion(){
        //Seleccione todos los registros donde los metros de construcción sean menores o igual a 100.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 100);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //3
    [HttpGet("listar-propiedades-pisos")]
    public IActionResult ListarPropiedadesPisos(){
        //Seleccione todos los registros donde el número de pisos sea menor o igual a 1.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 1);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //4
    [HttpGet("listar-propiedades-baños")]
    public IActionResult ListarPropiedadesBaños(){
        //Seleccione todos los registros donde el número de baños sea menor o igual a 2.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Banios, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //5
    [HttpGet("listar-propiedades-metros_terreno")]
    public IActionResult ListarPropiedadesMetrosTerreno(){
        //Seleccione todos los registros donde los metros de terreno sean menores o igual a 200.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, 200);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

}