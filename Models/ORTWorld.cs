class ORTWorld{

    public static List<string> ListaDestinos {get; private set;} = new List<string> {"OtakuLand", "DragoncinWorld", "PolnareffLand", "PollosHermanos", "MIDWorld", "CPenguinWorld", "MiKasa", "eeeee", "LaTerminal", "PASO 240"  }; // Ahora si, acá se le cargan los 10 destinos. hay que ver el de las fotos de hotel
    public static List<string> ListaHoteles{get; private set;} = new List<string> {"Hotel1", "Hotel2", "Hotel3", "Hotel4", "Hotel5", "Hotel6", "Hotel7", "Hotel8", "Hotel9", "Hotel10"};
    public static List<string> ListaAereos{get; private set;} = new List<string> {"Aéreo1", "Aéreo2", "Aéreo3", "Aéreo4", "Aéreo5", "Aéreo6", "Aéreo7", "Aéreo8", "Aéreo9", "Aéreo10"};
    public static List<string> ListaExcursiones{get; private set;}
    public static Dictionary<string, Paquete> DiccionarioPaquetes{get; private set;} = new Dictionary<string, Paquete>();
    public bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if(ListaDestinos.Contains(destinoSeleccionado))
        {
            Console.WriteLine("Ese destino ya existe");
            return false;
        }else{ 
            DiccionarioPaquetes.Add(destinoSeleccionado, paquete);
            return true;
        }                                                        
    }
}