using Microsoft.AspNetCore.Mvc;

namespace TP04_PaquetesTurísticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        
        return View();
    }
    public IActionResult ListaDestinos(ORTWorld Ortworld) // 
    {
        //ORTWorld ortworld = new ORTWorld();
        ViewBag.DiccionarioPaquetes = ORTWorld.DiccionarioPaquetes;
        ViewBag.DiccionarioPaquetes.Add("sosdfkos", 1);
        ViewBag.ListaDestinos.Add("Otakuland"); //cual sera la correcta para mi esta pero no se
        return View();
    }
    public IActionResult SelectPaquete(){ //
        return View();
    }
}
