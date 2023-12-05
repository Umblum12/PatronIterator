using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    internal class CatalagoVehiculo : Catalogo<Vehiculo, IteradorVehiculo>
    {
        public CatalagoVehiculo()
        {
            contenido.Add(new Vehiculo("Vehiculo economico"));
            contenido.Add(new Vehiculo("Vehiculo prqueño economico"));
            contenido.Add(new Vehiculo("Vehiculo premium"));
            contenido.Add(new Vehiculo("Vehiculo normal"));
        }
    }
}
