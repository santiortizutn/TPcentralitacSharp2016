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

            nuevoSB.AppendLine("Duracion: " + this._duracion);
            nuevoSB.AppendLine("Destino: " + this._nroDestino);
            nuevoSB.AppendLine("Origen: " + this._nroOrigen);
            nuevoSB.AppendLine("Costo llamada: " + this.CostoLlamada);
            nuevoSB.AppendLine("Franja horaria: " + this._franjaHoraria);
        }

        private float CalcularCosto()
        {
            return 0;
        }
        
        #endregion
    }
}
