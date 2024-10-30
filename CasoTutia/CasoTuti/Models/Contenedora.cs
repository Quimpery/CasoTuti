using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CasoTuti.Models
{
   
    internal class Contenedora
    {
        int tiempoJornada=0;

        List<Turno>Turnos=new List<Turno>();
        List<Profesional>Profesionales=new List<Profesional>();
        List<Gabinete> gabinetes=new List<Gabinete>();



        public void AgregarTurno(Turno turno)
        {
            Turnos.Add(turno);
            
        }

        public void QuitarTurno(Turno turno)
        {
           Turnos.Remove(turno);
           
        }
       
    }
}
