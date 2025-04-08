using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
//1
public class NinController : Controller {
    [HttpGet("listar-propiedades-tipo")]
    public IActionResult ListarPropiedadesTipo(){
        //Seleccione todos los registros donde el tipo no sea ni "casa" ni "terreno".

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> tipos = new List<string>();
        tipos.Add("Casa");
        tipos.Add("Terreno");
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Tipo, tipos);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //2
    [HttpGet("listar-propiedades-operacion")]
    public IActionResult ListarPropiedadesOperacion(){
        //Muestra todos los registros donde la operación no es "venta" ni "renta" .

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> operaciones = new List<string>();
        operaciones.Add("Venta");
        operaciones.Add("Renta");
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion, operaciones);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //3
    [HttpGet("listar-propiedades-agencia")]
    public IActionResult ListarPropiedadesAgencia(){
        //Seleccione todos los registros donde la agencia no sea "Torres Realty" ni "López Bienes Raíces".

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> agencias = new List<string>();
        agencias.Add("Torres Realty");
        agencias.Add("López Bienes Raíces");
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Agencia, agencias);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //4
    [HttpGet("listar-propiedades-operacion")]
    public IActionResult PropiedadesOperacion(){
        //Seleccione todos los registros donde la operación no sea "venta" ni "renta".

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> operaciones = new List<string>();
        operaciones.Add("Venta");
        operaciones.Add("Renta");
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion, operaciones);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    //5
    [HttpGet("listar-propiedades-costo")]
    public IActionResult ListarPropiedadesCosto(){
        //Seleccione todos los registros donde el costo no sea 250000 ni 300000.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<int> costos = new List<int>();
        costos.Add(250000);
        costos.Add(300000);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, costos);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}