using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoTuti.Models
{
    [Serializable]
    internal class FichaCliente:Persona
    {
        public string observaciones;
        public string resultado;
        private string direccion;
       public double Telefono { get { return telefono; } }


        public FichaCliente(string observaciones,string resultado,string dirrecion,string nombre,string apellido,double telefono) : base(nombre, apellido, telefono)
        {
            this.observaciones = observaciones;
            this.resultado = resultado;
            this.direccion = dirrecion;
            base.nombre = nombre;
            base.telefono = telefono;
            base.apellido = apellido;
        }
    }
}
