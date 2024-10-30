using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoTuti.Models
{
    internal class Turno:IComparable
    {
        public DateTime dia;
        private int duracion;
        public string estado;
        FichaCliente uncliente;
        public Turno(DateTime dia, int duracion, string estado)
        {
            this.dia = DateTime.Now;
            this.duracion = duracion;
            this.estado = estado;
            

        }
        public void AgregarCliente(FichaCliente unCliente)
        {
            this.uncliente = unCliente;
        }
        
        public int CompareTo(object obj)
        {
            return this.uncliente.Telefono.CompareTo(((FichaCliente)obj).Telefono);
        }

        public override string ToString()
        {
            return "El turno es: " + dia + "Dura un total de: " + duracion.ToString() ;
        }
        
        
    }
}
