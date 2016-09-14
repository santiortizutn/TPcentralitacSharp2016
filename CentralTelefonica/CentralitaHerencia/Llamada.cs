using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region Propiedades

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        #endregion

        #region Constructores

        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }
        
        #endregion

        #region Metodos

        public void Mostrar()
        {
            StringBuilder nuevoSB;
            nuevoSB = new StringBuilder();
        }


        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return string.Compare(llamada1._duracion.ToString(), llamada2._duracion.ToString());
        }

        #endregion
    }
}
