﻿using System;
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

namespace SimulacionSistemaTransporteMasivoMIO.Vista
{
    public partial class VentanaMIO : Form
    {
        public VentanaMIO()
        {
            InitializeComponent();
        }

        private void VentanaMIO_Load(object sender, EventArgs e)
        {
            gMapMIO.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gMapMIO.Position = new GMap.NET.PointLatLng( ﻿3.41000, -76.53333);

            GMapOverlay markersOverlay = new GMapOverlay(gMapMIO, "markers");
            GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(﻿3.41000, -76.53333));
            markersOverlay.Markers.Add(marker);
            gMapMIO.Overlays.Add(markersOverlay);

            marker.ToolTipText = "Información estación: \n   Cantidad pasajeros";
        }
    }
}