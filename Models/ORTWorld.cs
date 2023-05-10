class ORTWorld{

    public static List<string> ListaDestinos {get; private set;} = new List<string> {"OtakuLand", "DragoncinWorld", "PolnareffLand", "PollosHermanos", "MIDWorld", "CPenguinWorld", "MiKasa", "eeeee", "LaTerminal", "PASO 240"  }; // Ahora si, acá se le cargan los 10 destinos. hay que ver el de las fotos de hotel
    public static List<string> ListaHoteles{get; private set;} = new List<string> {"hotel1", "hotel2", "hotel3", "hotel4", "hotel5", "hotel6", "hotel7", "hotel8", "hotel9", "hotel10"};
    public static List<string> ListaAereos{get; private set;}
    public static List<string> ListaExcursiones{get; private set;}
    public static Dictionary<string, Paquete> DiccionarioPaquetes{get; private set;}
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