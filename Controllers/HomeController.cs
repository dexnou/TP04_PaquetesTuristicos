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
        int[] vectorNum = new int[] { Destino, Hotel, Aereo, Excursión };
        string[] vectorNombres = new string[] { "Destino", "Hotel", "Aereo", "Excursión" };
        Dictionary<string, int> diccionarioFaltantes = new Dictionary<string, int>();
        
        if(Destino > 10 | Destino <= 0 | Hotel > 10 | Hotel <=0 | Aereo > 10 | Aereo <=0 | Excursión > 10 | Aereo<=0){ 
            ViewBag.MensajeDeError = "NO SE RECIBIERON LOS PARÁMETROS CORRECTAMENTE. FALTAN: "; 
            for(int i = 0; i < 4; i++){
                if(vectorNum[i] <=0 | vectorNum[i] > 10){
                    diccionarioFaltantes.Add(vectorNombres[i], vectorNum[i]);
                }
            }
            ViewBag.diccionarioFaltantes = diccionarioFaltantes;
            SelectPaquete();
            return View("SelectPaquete");
        }else{
            Index();
            Paquete paquete = new Paquete(ORTWorld.ListaHoteles[Hotel-1], ORTWorld.ListaAereos[Aereo-1], ORTWorld.ListaExcursiones[Excursión-1]); 
            bool existe = ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], paquete); 
            ViewBag.Existe = existe;
            ViewBag.MensajeYaExiste = "Ese destino ya existe. ";
        } 
        return View("Index");
    }
}