using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoTuti.Models
{
    [Serializable]
    internal class Profesional:Persona
    {
        private string especializacion;
        private int jornada;
        int turno = 0;
        
       
        public Profesional(string especializacion,int jornada,string nombre,string apellido,double telefono,int tiempo) : base(nombre, apellido, telefono)
        {
            base.nombre = nombre;
            base.apellido = apellido;
            base.telefono = telefono;
            this.especializacion = especializacion;
            this.jornada = jornada;
        }

        public void AgregarTurno(int tiempo)
        {
            if (turno <= jornada && tiempo>0)
            {
                turno += tiempo;
            }   

        }
        public void FinalizacionTurno(int tiempo)
        {
            if(turno <= jornada && turno>0)
            {
                turno -= tiempo;
            }
        }
        
            
        
    }
}
