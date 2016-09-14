using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        protected string _razonSocial;
        private List<Llamada> _listaDeLlamadas;

        #region Propiedades
        
        public float GananciaPorLocal
        {
            get
            {
                return 0;
            }
        }

        public float GananciaPorProvincial
        {
            get 
            {
                return 0;
            }
        }

        public float GananciaTotal
        {
            get
            {
                return 0;
            }
        }

        public List<Llamada> Llamadas
        {
            get 
            {
                return _listaDeLlamadas;
            }
        }

        #endregion
    }
}
