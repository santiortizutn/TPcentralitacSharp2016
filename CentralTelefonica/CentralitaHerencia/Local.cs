using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;

        #region Propiedades 

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Constructores

        public Local(string origen, float duracion, string destino, float costo):base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        
        public Local(Llamada unaLlamada, float costo):this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {
            
        }

        #endregion

        #region Metodos

        public void Mostrar()
        {
            StringBuilder nuevoSB;
            nuevoSB = new StringBuilder();

            base.Mostrar();
            nuevoSB.AppendLine("Costo Llamada: $" + this.CostoLlamada);
            nuevoSB.AppendLine("Tipo: Local");
            nuevoSB.AppendLine("");
            Console.Write(nuevoSB);
        }

        private float CalcularCosto()
        {
            return (this._costo * this._duracion) / 60;
        }

        #endregion
    }
}
