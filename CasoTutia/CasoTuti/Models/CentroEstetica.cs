using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoTuti.Models
{
    [Serializable]
    internal class CentroEstetica
    {
        int tiempoJornada=0;

        List<Turno>Turnos=new List<Turno>();
        List<Profesional>Profesionales=new List<Profesional>();
        List<Gabinete> gabinetes=new List<Gabinete>();

        public void AgregarProfesional(Profesional profesional)
        {
            if (profesional != null)
            {
                Profesionales.Add(profesional);
            }
            else
            {
                throw new Exception("Ocurrio un error inesperado");
            }
        }

        public void AgregarTurno(Turno turno)
        {
            if (turno != null)
            {
                Turnos.Add(turno);
            }
            else
            {
                throw new Exception("Ocurrio un error inesperado");
            }
           
        }

        public void QuitarTurno(Turno turno)
        {
           Turnos.Remove(turno);
        }

        public Turno BuscarTurno(string tipo)
        {
            Turno turno=null;
            foreach(Turno t in Turnos)
            {
                if(t.VerTipo().Equals(tipo))
                    turno=t;
            }
            return turno;
        }
       
    }
}
