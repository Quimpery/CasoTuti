using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CasoTuti.Models
{
    [Serializable]
    internal class Persona
    {
        protected string nombre;
        protected string apellido;
        protected double telefono;



        public Persona(string nombre,string apellido,double telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }
    }
}
