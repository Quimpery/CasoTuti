using CasoTuti.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoTuti
{
    public partial class Form1 : Form
    {
        CentroEstetica centroestetica=new CentroEstetica();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream("CentroEstetica.dat", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                centroestetica=bf.Deserialize(fs) as CentroEstetica;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en la creacion del archivo");

            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("CentroEstetica.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, centroestetica);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en la serializacion");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTurno vTurno = new FormTurno();
            vTurno.cbTratamiento.Items.Add("Masajes");
            vTurno.cbTratamiento.Items.Add("Depilacion");
            vTurno.cbTratamiento.Items.Add("Peluqueria");
            vTurno.cbTratamiento.Items.Add("Maquillaje");

            if (vTurno.ShowDialog() == DialogResult.OK)
            {    
                int tiempo=Convert.ToInt32(vTurno.tbTiempo.Text);
                string tipo = Convert.ToString(vTurno.cbTratamiento.Text);
                Tratamiento tratamiento = new Tratamiento(tipo, tiempo);
            }
        }
    }
}
