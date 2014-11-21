using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET.WindowsForms;
using GMap.NET.ObjectModel;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;
using SimulacionSistemaTransporteMasivoMIO.GMaps.NET_Library;
using SimulacionSistemaTransporteMasivoMIO.Modelo;

namespace SimulacionSistemaTransporteMasivoMIO.Vista
{
    public partial class VentanaMIO : Form
    {

        public CargadoraInformacion c;
        public Simulacion sim;
       
        public VentanaMIO(CargadoraInformacion ci, Simulacion simu)
        {
            c = ci;
            sim = simu;
            InitializeComponent();
            
        }

        private void VentanaMIO_Load(object sender, EventArgs e)
        {
            gMapMIO.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gMapMIO.Position = new GMap.NET.PointLatLng( ﻿3.41000, -76.53333);

            
           //GMapOverlay markersOverlay = new GMapOverlay(gMapMIO, "markers");

          
           
           // GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(﻿3.41000, -76.53333));
           // GMapMarkerGoogleGreen marker2 = new GMapMarkerGoogleGreen(new PointLatLng(﻿3.42000, -76.53333));
           // markersOverlay.Markers.Add(marker);
           // markersOverlay.Markers.Add(marker2);
           // gMapMIO.Overlays.Add(markersOverlay);

         
            cargarInfo();

            Console.WriteLine("estoy en ventana");
        }

        private void gMapMIO_Load(object sender, EventArgs e)
        {

        }

        private void cargarInfo()
        {
            //List<Estacion> a = Utilidades.AgruparParadas(c.STOPS);
            Estacion[] a = sim.Estaciones.DarVertices();
            for (int i = 0; i < a.Length; i++)
            {

                GMapOverlay markersOverlay = new GMapOverlay(gMapMIO, "markers");

                GMapMarkerEstacion marker = new GMapMarkerEstacion(new PointLatLng(﻿a[i].GetLatitud(), a[i].GetLongitud()), new Bitmap(@"..\\..\\Almacenamiento\Imagenes\estacion.png"));
                markersOverlay.Markers.Add(marker);
                gMapMIO.Overlays.Add(markersOverlay);
                marker.ToolTipText = "Nombre Estación: " + a[i].GetNombre() +" \n   Cantidad pasajeros: ";
            }
           

        }
        private void refrescar()
        {
            labCantColaps.Text = 0+"";
            labNumPasMov.Text = sim.totalPasajeros()+"";
            labTiempTransInfo.Text = sim.UnidadReloj+"";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butReporte_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labNumPasMov_Click(object sender, EventArgs e)
        {

        }

        private void butSim_Click(object sender, EventArgs e)
        {
            
            //System.Threading.Thread hilo1 = new System.Threading.Thread(new System.Threading.ThreadStart(sim.StartSim));
            //hilo1.Start();

            //System.Threading.Thread hilo2 = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
            //hilo2.Start();

            sim.StartSim();
        }

        private void Run()
        {
            while (true)
            {
                refrescar();
            }
        }
    }
}
