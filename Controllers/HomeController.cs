using Microsoft.AspNetCore.Mvc;

namespace TP04_PaquetesTurísticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Diccionario = ORTWorld.DiccionarioPaquetes; 
        return View();
    }
    public IActionResult SelectPaquete(){ 
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        return View();
    }
    
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursión){ 
        List<int> num = new List<int>(4);
        if(Destino == 0 | Hotel == 0 | Aereo == 0 | Excursión == 0){ 
            ViewBag.MensajeDeError = "NO SE RECIBIERON LOS PARAMETROS CORRECTAMENTE. FALTAN: "; //falta hacer esto del viewbag
            return View("SelectPaquete");
        }else{
            Paquete paquete = new Paquete("", "", ""); 
            ViewBag.IngresarPaquete(); //hay que ver si esto esta bien o mal para que se guarde el paquete con el destino deseado y guardarlo en el viewbag. 
            ViewBag.Diccionario = ORTWorld.DiccionarioPaquetes; //
        } 
        return View("SelectPaquete");
    }
}
