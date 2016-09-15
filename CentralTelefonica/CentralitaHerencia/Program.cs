using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Centralita miCentralita;
            Local primera;
            Provincial segunda;
            Local tercera;
            Provincial cuarta;

            miCentralita = new Centralita("Telefonica");
            primera = new Local("Numero x", 30, "Numero y", 2.65f);
            segunda = new Provincial("Buenos Aires", Franja.Franja_1, 21, "Salta");
            tercera = new Local("Numero w", 45, "Numero z", 1.99f);
            cuarta = new Provincial(Franja.Franja_3, segunda);

        // Para no mostrar las ganancias cada vez que se crea una llamada utilizo el metodo mostrar de c/u.
        
        
            miCentralita.Llamadas.Add(primera);
            primera.Mostrar();
           // miCentralita.Mostrar();
            

            miCentralita.Llamadas.Add(segunda);
            segunda.Mostrar();
          //  miCentralita.Mostrar();
            

            miCentralita.Llamadas.Add(tercera);
            tercera.Mostrar();
          //  miCentralita.Mostrar();
            

            miCentralita.Llamadas.Add(cuarta);
            cuarta.Mostrar();
          // miCentralita.Mostrar();
             
            
            miCentralita.OrdenarLlamadas();
            miCentralita.Mostrar();

            Console.ReadKey();

            
        }
    }
}
