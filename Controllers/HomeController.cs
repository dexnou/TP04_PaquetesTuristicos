using Microsoft.AspNetCore.Mvc;

namespace TP04_PaquetesTurísticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
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
        return View(SelectPaquete);
    }
    
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursión){ 
        if(Destino == 0 | Hotel == 0 | Aereo == 0 | Excursión == 0){ 
            ViewBag.MensajeDeError = "NO SE RECIBIERON LOS PARAMETROS CORRECTAMENTE.";
            return View("SelectPaquete");
        }// 
        Paquete paquete = new Paquete(); 
        
    }
}
