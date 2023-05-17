class ORTWorld{
    public static List<string> ListaDestinos {get; private set;} = new List<string> {"OtakuLand", "DragoncinWorld", "PolnareffLand", "PollosHermanos", "MIDWorld", "CPenguinWorld", "MiKasa", "DIGODIGOWORLD", "LaTerminal", "PASO 240"  }; // Ahora si, acá se le cargan los 10 destinos. hay que ver el de las fotos de hotel
    public static List<string> ListaHoteles{get; private set;} = new List<string> {"Hotel1.jpg", "Hotel2.jpg", "Hotel3.jpg", "Hotel4.jpg", "Hotel5.jpg", "Hotel6.jpg", "Hotel7.jpg", "Hotel8.jpg", "Hotel9.jpg", "Hotel10.jpg"};
    public static List<string> ListaAereos{get; private set;} = new List<string> {"Aéreo1.jpg", "Aéreo2.jpg", "Aéreo3.jpg", "Aéreo4.jpg", "Aéreo5.jpg", "Aéreo6.jpg", "Aéreo7.jpg", "Aéreo8.jpg", "Aéreo9.jpg", "Aéreo10.jpg"};
    public static List<string> ListaExcursiones{get; private set;}= new List<string> {"Excursion1.jpg", "Excursion2.jpg", "Excursion3.jpg", "Excursion4.jpg", "Excursion5.jpg", "Excursion6.jpg", "Excursion7.jpg", "Excursion8.jpg", "Excursion9.jpg", "Excursion10.jpg"};
    public static Dictionary<string, Paquete> DiccionarioPaquetes{get; private set;} = new Dictionary<string, Paquete>();
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if(DiccionarioPaquetes.ContainsKey(destinoSeleccionado))
        {
            Console.WriteLine("Ese destino ya existe"); // Arreglar para que en vez de que aparezca en Consola aparezca en web.
            return true;
        }else{ 
            DiccionarioPaquetes.Add(destinoSeleccionado, paquete);
            return false;
        }                                                        
    }
}