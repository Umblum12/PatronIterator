using PatronIterator;

CatalagoVehiculo catalago = new CatalagoVehiculo();
IteradorVehiculo iterador = catalago.busqueda("Vehiculo");
Vehiculo vehiculo;
iterador.inicio();
vehiculo = iterador.item();
while(vehiculo != null)
{
    vehiculo.visualiza();
    iterador.siguiente();
    vehiculo = iterador.item();
}