using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Vehiculo;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected short Tamanio
        {
            get
            {
                return 2;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(this);
            sb.AppendLine("TAMAÑO : {0}");
            sb.AppendLine(this.Tamanio.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
