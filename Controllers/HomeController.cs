using Microsoft.AspNetCore.Mvc;

namespace TP04_PaquetesTurísticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        
        return View();
    }
    public IActionResult ListaDestinos()
    {
        //ORTWorld ortworld = new ORTWorld();
        ViewBag.Diccionario = ORTWorld.DiccionarioPaquetes; 
        return View();
    }
    public IActionResult SelectPaquete(){ // 
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        return View();
    }
    
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursión){
        Paquete paquete = new Paquete();
    }
}
