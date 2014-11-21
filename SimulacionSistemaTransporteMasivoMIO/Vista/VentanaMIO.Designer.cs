namespace SimulacionSistemaTransporteMasivoMIO.Vista
{
    partial class VentanaMIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gMapMIO = new GMap.NET.WindowsForms.GMapControl();
            this.butReporte = new System.Windows.Forms.Button();
            this.labPasMovil = new System.Windows.Forms.Label();
            this.labNumPasMov = new System.Windows.Forms.Label();
            this.labTTrans = new System.Windows.Forms.Label();
            this.labTiempTransInfo = new System.Windows.Forms.Label();
            this.labCantColaps = new System.Windows.Forms.Label();
            this.labNoCantColaps = new System.Windows.Forms.Label();
            this.labOcProm = new System.Windows.Forms.Label();
            this.labNomOcProm = new System.Windows.Forms.Label();
            this.butSim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gMapMIO);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.butSim);
            this.splitContainer1.Panel2.Controls.Add(this.labOcProm);
            this.splitContainer1.Panel2.Controls.Add(this.labNomOcProm);
            this.splitContainer1.Panel2.Controls.Add(this.labCantColaps);
            this.splitContainer1.Panel2.Controls.Add(this.labNoCantColaps);
            this.splitContainer1.Panel2.Controls.Add(this.labTTrans);
            this.splitContainer1.Panel2.Controls.Add(this.labTiempTransInfo);
            this.splitContainer1.Panel2.Controls.Add(this.labNumPasMov);
            this.splitContainer1.Panel2.Controls.Add(this.labPasMovil);
            this.splitContainer1.Panel2.Controls.Add(this.butReporte);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 630);
            this.splitContainer1.SplitterDistance = 798;
            this.splitContainer1.TabIndex = 0;
            // 
            // gMapMIO
            // 
            this.gMapMIO.Bearing = 0F;
            this.gMapMIO.CanDragMap = true;
            this.gMapMIO.GrayScaleMode = false;
            this.gMapMIO.LevelsKeepInMemmory = 5;
            this.gMapMIO.Location = new System.Drawing.Point(12, 12);
            this.gMapMIO.MarkersEnabled = true;
            this.gMapMIO.MaxZoom = 20;
            this.gMapMIO.MinZoom = 12;
            this.gMapMIO.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMIO.Name = "gMapMIO";
            this.gMapMIO.NegativeMode = false;
            this.gMapMIO.PolygonsEnabled = true;
            this.gMapMIO.RetryLoadTile = 0;
            this.gMapMIO.RoutesEnabled = true;
            this.gMapMIO.ShowTileGridLines = false;
            this.gMapMIO.Size = new System.Drawing.Size(775, 606);
            this.gMapMIO.TabIndex = 0;
            this.gMapMIO.Zoom = 12D;
            this.gMapMIO.Load += new System.EventHandler(this.gMapMIO_Load);
            // 
            // butReporte
            // 
            this.butReporte.Location = new System.Drawing.Point(133, 569);
            this.butReporte.Name = "butReporte";
            this.butReporte.Size = new System.Drawing.Size(137, 23);
            this.butReporte.TabIndex = 13;
            this.butReporte.Text = "mostrar reporte";
            this.butReporte.UseVisualStyleBackColor = true;
            this.butReporte.Click += new System.EventHandler(this.butReporte_Click);
            // 
            // labPasMovil
            // 
            this.labPasMovil.AutoSize = true;
            this.labPasMovil.Location = new System.Drawing.Point(64, 39);
            this.labPasMovil.Name = "labPasMovil";
            this.labPasMovil.Size = new System.Drawing.Size(110, 13);
            this.labPasMovil.TabIndex = 15;
            this.labPasMovil.Text = "Pasajeros movilizados";
            // 
            // labNumPasMov
            // 
            this.labNumPasMov.AutoSize = true;
            this.labNumPasMov.Location = new System.Drawing.Point(291, 39);
            this.labNumPasMov.Name = "labNumPasMov";
            this.labNumPasMov.Size = new System.Drawing.Size(0, 13);
            this.labNumPasMov.TabIndex = 16;
            this.labNumPasMov.Click += new System.EventHandler(this.labNumPasMov_Click);
            // 
            // labTTrans
            // 
            this.labTTrans.AutoSize = true;
            this.labTTrans.Location = new System.Drawing.Point(291, 95);
            this.labTTrans.Name = "labTTrans";
            this.labTTrans.Size = new System.Drawing.Size(0, 13);
            this.labTTrans.TabIndex = 18;
            // 
            // labTiempTransInfo
            // 
            this.labTiempTransInfo.AutoSize = true;
            this.labTiempTransInfo.Location = new System.Drawing.Point(64, 95);
            this.labTiempTransInfo.Name = "labTiempTransInfo";
            this.labTiempTransInfo.Size = new System.Drawing.Size(100, 13);
            this.labTiempTransInfo.TabIndex = 17;
            this.labTiempTransInfo.Text = "Tiempo transcurrido";
            this.labTiempTransInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // labCantColaps
            // 
            this.labCantColaps.AutoSize = true;
            this.labCantColaps.Location = new System.Drawing.Point(291, 151);
            this.labCantColaps.Name = "labCantColaps";
            this.labCantColaps.Size = new System.Drawing.Size(0, 13);
            this.labCantColaps.TabIndex = 20;
            // 
            // labNoCantColaps
            // 
            this.labNoCantColaps.AutoSize = true;
            this.labNoCantColaps.Location = new System.Drawing.Point(64, 151);
            this.labNoCantColaps.Name = "labNoCantColaps";
            this.labNoCantColaps.Size = new System.Drawing.Size(89, 13);
            this.labNoCantColaps.TabIndex = 19;
            this.labNoCantColaps.Text = "Numero colapsos";
            // 
            // labOcProm
            // 
            this.labOcProm.AutoSize = true;
            this.labOcProm.Location = new System.Drawing.Point(291, 201);
            this.labOcProm.Name = "labOcProm";
            this.labOcProm.Size = new System.Drawing.Size(0, 13);
            this.labOcProm.TabIndex = 22;
            // 
            // labNomOcProm
            // 
            this.labNomOcProm.AutoSize = true;
            this.labNomOcProm.Location = new System.Drawing.Point(64, 201);
            this.labNomOcProm.Name = "labNomOcProm";
            this.labNomOcProm.Size = new System.Drawing.Size(167, 13);
            this.labNomOcProm.TabIndex = 21;
            this.labNomOcProm.Text = "%Ocupacion promedio estaciones";
            // 
            // butSim
            // 
            this.butSim.Location = new System.Drawing.Point(131, 514);
            this.butSim.Name = "butSim";
            this.butSim.Size = new System.Drawing.Size(137, 23);
            this.butSim.TabIndex = 23;
            this.butSim.Text = "Iniciar simulacion";
            this.butSim.UseVisualStyleBackColor = true;
            this.butSim.Click += new System.EventHandler(this.butSim_Click);
            // 
            // VentanaMIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VentanaMIO";
            this.Text = "VentanaMIO";
            this.Load += new System.EventHandler(this.VentanaMIO_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gMapMIO;
        private System.Windows.Forms.Button butReporte;
        private System.Windows.Forms.Label labTTrans;
        private System.Windows.Forms.Label labTiempTransInfo;
        private System.Windows.Forms.Label labNumPasMov;
        private System.Windows.Forms.Label labPasMovil;
        private System.Windows.Forms.Label labOcProm;
        private System.Windows.Forms.Label labNomOcProm;
        private System.Windows.Forms.Label labCantColaps;
        private System.Windows.Forms.Label labNoCantColaps;
        private System.Windows.Forms.Button butSim;
    }
}