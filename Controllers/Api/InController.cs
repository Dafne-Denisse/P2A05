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

    //3
    [HttpGet("listar-propiedades-agencia")]
    public IActionResult ListarPropiedadesAgencia(){
        //Encuentra todas las propiedades que pertenecen a las agencias "García Propiedades" o "Torres Realty".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> agencias = new List<string>();
        agencias.Add("García Prpiedades");
        agencias.Add("Torres Realty");
        var filtro = Builders<Inmueble>.Filter.In(x => x.Agencia, agencias);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

     //4
    [HttpGet("listar-propiedades-tienen-patio")]
    public IActionResult ListarPropiedadesTienenPatio(){
        //Encuentra todas las propiedades que tienen patio o no tienen patio
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<bool> patios = new List<bool>();
        patios.Add(true);
        patios.Add(false);
        var filtro = Builders<Inmueble>.Filter.In(x => x.TienePatio, patios);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

     //5
    [HttpGet("listar-propiedades-fecha_publicación")]
    public IActionResult ListarPropiedadesFechaPublicación(){
        //Encuentra todas las propiedades que fueron publicadas en enero de 2023 o febrero de 2023
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List<string> fechaspublicacion = new List<string>();
        fechaspublicacion.Add("2023-01");
        fechaspublicacion.Add("2023-02");
        var filtro = Builders<Inmueble>.Filter.In(x => x.FechaPublicacion, fechaspublicacion);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    }

    

