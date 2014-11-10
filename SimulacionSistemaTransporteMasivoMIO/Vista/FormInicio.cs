using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;
using SimulacionSistemaTransporteMasivoMIO.Modelo;

namespace SimulacionSistemaTransporteMasivoMIO.Vista
{
    public partial class FormInicio : Form
    {

        public CargadoraInformacion c;
        public Simulacion sim;

        public FormInicio(CargadoraInformacion ci, Simulacion simu)
        {
            c = ci;
            sim = simu;
            InitializeComponent();

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void butIniSimul_Click(object sender, EventArgs e)
        {
            VentanaMIO ventanaMIO = new VentanaMIO(c,sim);
            ventanaMIO.ShowDialog();
        }
    }
}
