using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]

//1
public class NeController : Controller {
    [HttpGet("listar-propiedades-nombre_agente")]
    public IActionResult ListarPropiedadesNombreAgente(){
        //Seleccionar todos los registros donde el nombre del agente no sea "Carlos García".

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.NombreAgente, "Carlos García");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //2
    [HttpGet("listar-propiedades-tipo")]
    public IActionResult ListarPropiedadesTipo(){
        //Seleccione todos los registros donde el tipo no sea "terreno".

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "Terreno");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //3
    [HttpGet("listar-propiedades-agencia")]
    public IActionResult ListarPropiedadesAgencia(){
        //Seleccione todos los registros donde la agencia no sea "García Propiedades".

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "García Propiedades");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //4
    [HttpGet("listar-propiedades-operacion")]
    public IActionResult ListarPropiedadesOperacion(){
        //Seleccione todos los registros donde la operación no sea "renta".

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion, "Renta");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //5
    [HttpGet("listar-propiedades-costo")]
    public IActionResult ListarPropiedadesCosto(){
        //Seleccione todos los registros donde el costo no sea 400000.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Costo, 400000);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}