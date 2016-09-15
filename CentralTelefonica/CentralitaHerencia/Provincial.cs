using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto(); ;
            }
        }
        
        #endregion

        #region Constructores

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada):this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
            
        {
 
        }
        
        #endregion

        #region Metodos

        public void Mostrar()
        {
            StringBuilder nuevoSB;
            nuevoSB = new StringBuilder();

            base.Mostrar();
            nuevoSB.AppendLine("Costo llamada: $" + this.CostoLlamada);
            nuevoSB.AppendLine("Franja horaria: " + this._franjaHoraria);
            nuevoSB.AppendLine("Tipo: Provincial");
            nuevoSB.AppendLine("");

            Console.Write(nuevoSB);
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99f;
                    break;

                case Franja.Franja_2:
                    costo = 1.25f;
                    break;

                case Franja.Franja_3:
                    costo = 0.66f;
                    break;
            }
            return (costo * this._duracion) / 60;
        }
        
        #endregion
    }
}
