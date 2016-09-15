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
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get 
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
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

        #region Constructores

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }
        
        #endregion


        #region Metodos

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

            Console.WriteLine();
            Console.WriteLine("--LAS LLAMADAS SE HAN ORDENADO POR SU DURACION--");
            Console.WriteLine();

        }

        public void Mostrar()
        {
            StringBuilder nuevoSB = new StringBuilder();
            nuevoSB.AppendLine(">>DETALLES DE CENTRALITA<<");
            nuevoSB.AppendLine("Nombre empresa: " + this._razonSocial);
            nuevoSB.AppendLine("Ganancia local: $" + this.GananciaPorLocal);
            nuevoSB.AppendLine("Ganancia provincial: $" + this.GananciaPorProvincial);
            nuevoSB.AppendLine("Ganancia total: $" + this.GananciaTotal);
            nuevoSB.AppendLine("");
            nuevoSB.AppendLine(">>TOTAL DE LLAMADAS<<");
            Console.Write(nuevoSB);


            foreach (var item in _listaDeLlamadas)
            {
                Provincial provincial;
                Local local;

                if (item.GetType() == typeof(Local))
                {
                    local = (Local)item;
                    local.Mostrar();
                }
                if (item.GetType() == typeof(Provincial))
                {
                    provincial = (Provincial)item;
                    provincial.Mostrar();

                }
            }



            
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            
            float retorno = 0;
            float retorno2 = 0;

            switch (tipo)
            {
                case TipoLlamada.Local:

                    Local local;

                    foreach (var item in _listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            local = (Local)item;
                            retorno = retorno + local.CostoLlamada;
                        }
                    }
                     
                    break;

                case TipoLlamada.Provincial:

                    Provincial provincial;

                    foreach (var item in _listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            provincial = (Provincial)item;
                            retorno = retorno + provincial.CostoLlamada;
                        }
                    }
                    
                    break;

                case TipoLlamada.Todas:

                    Local local1;
                    Provincial provincial1;

                    foreach (var item in _listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            local1 = (Local)item;
                            retorno = retorno + local1.CostoLlamada;
                        }
                        if (item.GetType() == typeof(Provincial))
                        {
                            provincial1 = (Provincial)item;
                            retorno2 = retorno2 + provincial1.CostoLlamada;
                        }
                    }
                   

                    return retorno + retorno2;
                    

                    
            }

            return retorno;

        }
        
        
        #endregion
    }
}
