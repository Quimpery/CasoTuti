using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoTuti.Models
{
    internal class Tratamiento
    {
        public string Tipo;
        public int tiempo;
        public Tratamiento(string tipo, int tiempo)
        {
            this.Tipo = tipo;
            this.tiempo = tiempo;

        }

        
    }
}
