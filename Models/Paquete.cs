class Paquete{
    public string Hotel{get; private set;}  
    public string Aereo{get; private set;}
    public string Excursion {get; private set;}
    public Paquete (string pHotel, string pAereo, string pExcursion){
        Hotel = pHotel;
        Aereo = pAereo;
        Excursion = pExcursion;
    }
}