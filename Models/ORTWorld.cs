class ORTWorld{
    public static List<string> ListaDestinos {get; private set;} = new List<string> {"OtakuLand", "DragoncinWorld", "PolnareffLand", "PollosHermanos", "MIDWorld", "CPenguinWorld", "MiKasa", "eeeee", "LaTerminal", "PASO 240"  }; // Ahora si, acá se le cargan los 10 destinos. hay que ver el de las fotos de hotel
    public static List<string> ListaHoteles{get; private set;} = new List<string> {"/imagenes/Hotel1.jpg", "~/imagenes/Hotel2.jpg", "Hotel3.jpg", "Hotel4", "Hotel5", "Hotel6", "Hotel7", "Hotel8", "Hotel9", "Hotel10"};
    public static List<string> ListaAereos{get; private set;} = new List<string> {"AEREO 1", "Aéreo2", "Aéreo3", "Aéreo4", "Aéreo5", "Aéreo6", "Aéreo7", "Aéreo8", "Aéreo9", "Aéreo10"};
    public static List<string> ListaExcursiones{get; private set;}= new List<string> {"Excursion1", "Excursion2", "Excursion3", "Excursion4", "Excursion5", "Excursion6", "Excursion7", "Excursion8", "Excursion9", "Excursion10"};
    public static Dictionary<string, Paquete> DiccionarioPaquetes{get; private set;} = new Dictionary<string, Paquete>();
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if(DiccionarioPaquetes.ContainsKey(destinoSeleccionado))
        {
            Console.WriteLine("Ese destino ya existe");
            return false;
        }else{ 
            DiccionarioPaquetes.Add(destinoSeleccionado, paquete);
            return true;
        }                                                        
    }
}