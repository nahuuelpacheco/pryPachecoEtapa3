using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPachecoEtapa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        clsVehiculo objAvion; //Creamos objeto
        clsVehiculo objBarco;

        bool Auto = false;
        bool Avion = false; //Para saber el estado de los vehiculos
        bool Barco = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo(); //Instanciamos objeto
            objBarco = new clsVehiculo();

            objAuto.CrearAuto();
            objAvion.CrearAvion(); //Creamos vehiculos
            objBarco.CrearBarco();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            objAuto.CrearAuto(); //Creamos de nuevo en caso de que se haya borrado con los otros botones
            objAuto.pctAuto.Location = new Point(250, 50); //Lugar donde aparece
            Controls.Add(objAuto.pctAuto); //añadimos imagen
            lblVehiculo.Text = objAuto.tipoVehiculo;//dictamos que vehiculo es en el label
            Auto = true;//decimos que ahora existe
            if (Avion == true)//Borramos los otros vehiculos y los ponemos en falso
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
            }
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objAvion.CrearBarco();
            objBarco.pctBarco.Location = new Point(250, 50);
            Controls.Add(objBarco.pctBarco);
            lblVehiculo.Text = objBarco.tipoVehiculo;
            Barco = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
            }
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            objAvion.CrearAvion();
            objAvion.pctAvion.Location = new Point(250, 50);
            Controls.Add(objAvion.pctAvion);
            lblVehiculo.Text = objAvion.tipoVehiculo;
            Avion = true;
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = true;
            }
        }
    }
}
