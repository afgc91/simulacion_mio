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
            sim.setCantidadBuses(Int32.Parse(textCantBus.Text));
            sim.setHoraPicoYValle(Int32.Parse(textHoraValle.Text), Int32.Parse(textHoraPico.Text));
            Console.WriteLine("inicio hilo");
            //System.Threading.Thread hilo1 = new System.Threading.Thread(new System.Threading.ThreadStart(sim.Run));
            //hilo1.Start();
            Console.WriteLine("inicia ventana");
            VentanaMIO ventanaMIO = new VentanaMIO(c,sim);
            ventanaMIO.ShowDialog();
        }
    }
}
