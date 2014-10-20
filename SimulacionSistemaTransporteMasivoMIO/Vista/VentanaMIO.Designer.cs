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
            this.comboMomSemana = new System.Windows.Forms.ComboBox();
            this.labMomSemana = new System.Windows.Forms.Label();
            this.textTiemSimul = new System.Windows.Forms.TextBox();
            this.textCapacidadBus = new System.Windows.Forms.TextBox();
            this.labTiemSimul = new System.Windows.Forms.Label();
            this.labCapacidadBus = new System.Windows.Forms.Label();
            this.butReporte = new System.Windows.Forms.Button();
            this.butIniSimul = new System.Windows.Forms.Button();
            this.groupRestricciones = new System.Windows.Forms.GroupBox();
            this.labRuta = new System.Windows.Forms.Label();
            this.labCantBuses = new System.Windows.Forms.Label();
            this.labFrecuencia = new System.Windows.Forms.Label();
            this.labHoraValle = new System.Windows.Forms.Label();
            this.labHoraPico = new System.Windows.Forms.Label();
            this.comboRuta = new System.Windows.Forms.ComboBox();
            this.textCantBus = new System.Windows.Forms.TextBox();
            this.textFrecuencia = new System.Windows.Forms.TextBox();
            this.textHoraValle = new System.Windows.Forms.TextBox();
            this.textHoraPico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupRestricciones.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupRestricciones);
            this.splitContainer1.Panel2.Controls.Add(this.butIniSimul);
            this.splitContainer1.Panel2.Controls.Add(this.butReporte);
            this.splitContainer1.Panel2.Controls.Add(this.labCapacidadBus);
            this.splitContainer1.Panel2.Controls.Add(this.labTiemSimul);
            this.splitContainer1.Panel2.Controls.Add(this.textCapacidadBus);
            this.splitContainer1.Panel2.Controls.Add(this.textTiemSimul);
            this.splitContainer1.Panel2.Controls.Add(this.labMomSemana);
            this.splitContainer1.Panel2.Controls.Add(this.comboMomSemana);
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
            // comboMomSemana
            // 
            this.comboMomSemana.FormattingEnabled = true;
            this.comboMomSemana.Location = new System.Drawing.Point(238, 46);
            this.comboMomSemana.Name = "comboMomSemana";
            this.comboMomSemana.Size = new System.Drawing.Size(121, 21);
            this.comboMomSemana.TabIndex = 0;
            // 
            // labMomSemana
            // 
            this.labMomSemana.AutoSize = true;
            this.labMomSemana.Location = new System.Drawing.Point(37, 52);
            this.labMomSemana.Name = "labMomSemana";
            this.labMomSemana.Size = new System.Drawing.Size(116, 13);
            this.labMomSemana.TabIndex = 1;
            this.labMomSemana.Text = "momento de la semana";
            // 
            // textTiemSimul
            // 
            this.textTiemSimul.Location = new System.Drawing.Point(259, 489);
            this.textTiemSimul.Name = "textTiemSimul";
            this.textTiemSimul.Size = new System.Drawing.Size(100, 20);
            this.textTiemSimul.TabIndex = 9;
            // 
            // textCapacidadBus
            // 
            this.textCapacidadBus.Location = new System.Drawing.Point(259, 421);
            this.textCapacidadBus.Name = "textCapacidadBus";
            this.textCapacidadBus.Size = new System.Drawing.Size(100, 20);
            this.textCapacidadBus.TabIndex = 10;
            // 
            // labTiemSimul
            // 
            this.labTiemSimul.AutoSize = true;
            this.labTiemSimul.Location = new System.Drawing.Point(37, 492);
            this.labTiemSimul.Name = "labTiemSimul";
            this.labTiemSimul.Size = new System.Drawing.Size(90, 13);
            this.labTiemSimul.TabIndex = 11;
            this.labTiemSimul.Text = "tiempo simulacion";
            // 
            // labCapacidadBus
            // 
            this.labCapacidadBus.AutoSize = true;
            this.labCapacidadBus.Location = new System.Drawing.Point(37, 424);
            this.labCapacidadBus.Name = "labCapacidadBus";
            this.labCapacidadBus.Size = new System.Drawing.Size(88, 13);
            this.labCapacidadBus.TabIndex = 12;
            this.labCapacidadBus.Text = "capacidad buses";
            // 
            // butReporte
            // 
            this.butReporte.Location = new System.Drawing.Point(40, 569);
            this.butReporte.Name = "butReporte";
            this.butReporte.Size = new System.Drawing.Size(137, 23);
            this.butReporte.TabIndex = 13;
            this.butReporte.Text = "mostrar reporte";
            this.butReporte.UseVisualStyleBackColor = true;
            // 
            // butIniSimul
            // 
            this.butIniSimul.Location = new System.Drawing.Point(233, 569);
            this.butIniSimul.Name = "butIniSimul";
            this.butIniSimul.Size = new System.Drawing.Size(127, 23);
            this.butIniSimul.TabIndex = 14;
            this.butIniSimul.Text = "iniciar simulacion";
            this.butIniSimul.UseVisualStyleBackColor = true;
            // 
            // groupRestricciones
            // 
            this.groupRestricciones.Controls.Add(this.textHoraPico);
            this.groupRestricciones.Controls.Add(this.labRuta);
            this.groupRestricciones.Controls.Add(this.textHoraValle);
            this.groupRestricciones.Controls.Add(this.labCantBuses);
            this.groupRestricciones.Controls.Add(this.textFrecuencia);
            this.groupRestricciones.Controls.Add(this.labFrecuencia);
            this.groupRestricciones.Controls.Add(this.textCantBus);
            this.groupRestricciones.Controls.Add(this.labHoraValle);
            this.groupRestricciones.Controls.Add(this.comboRuta);
            this.groupRestricciones.Controls.Add(this.labHoraPico);
            this.groupRestricciones.Location = new System.Drawing.Point(40, 100);
            this.groupRestricciones.Name = "groupRestricciones";
            this.groupRestricciones.Size = new System.Drawing.Size(319, 292);
            this.groupRestricciones.TabIndex = 15;
            this.groupRestricciones.TabStop = false;
            this.groupRestricciones.Text = "cambiar restricciones";
            // 
            // labRuta
            // 
            this.labRuta.AutoSize = true;
            this.labRuta.Location = new System.Drawing.Point(24, 34);
            this.labRuta.Name = "labRuta";
            this.labRuta.Size = new System.Drawing.Size(25, 13);
            this.labRuta.TabIndex = 2;
            this.labRuta.Text = "ruta";
            // 
            // labCantBuses
            // 
            this.labCantBuses.AutoSize = true;
            this.labCantBuses.Location = new System.Drawing.Point(58, 87);
            this.labCantBuses.Name = "labCantBuses";
            this.labCantBuses.Size = new System.Drawing.Size(79, 13);
            this.labCantBuses.TabIndex = 3;
            this.labCantBuses.Text = "cantidad buses";
            // 
            // labFrecuencia
            // 
            this.labFrecuencia.AutoSize = true;
            this.labFrecuencia.Location = new System.Drawing.Point(58, 138);
            this.labFrecuencia.Name = "labFrecuencia";
            this.labFrecuencia.Size = new System.Drawing.Size(57, 13);
            this.labFrecuencia.TabIndex = 4;
            this.labFrecuencia.Text = "frecuencia";
            // 
            // labHoraValle
            // 
            this.labHoraValle.AutoSize = true;
            this.labHoraValle.Location = new System.Drawing.Point(58, 184);
            this.labHoraValle.Name = "labHoraValle";
            this.labHoraValle.Size = new System.Drawing.Size(73, 13);
            this.labHoraValle.TabIndex = 5;
            this.labHoraValle.Text = "vel. hora valle";
            // 
            // labHoraPico
            // 
            this.labHoraPico.AutoSize = true;
            this.labHoraPico.Location = new System.Drawing.Point(58, 235);
            this.labHoraPico.Name = "labHoraPico";
            this.labHoraPico.Size = new System.Drawing.Size(71, 13);
            this.labHoraPico.TabIndex = 6;
            this.labHoraPico.Text = "vel. hora pico";
            // 
            // comboRuta
            // 
            this.comboRuta.FormattingEnabled = true;
            this.comboRuta.Location = new System.Drawing.Point(155, 29);
            this.comboRuta.Name = "comboRuta";
            this.comboRuta.Size = new System.Drawing.Size(136, 21);
            this.comboRuta.TabIndex = 7;
            // 
            // textCantBus
            // 
            this.textCantBus.Location = new System.Drawing.Point(155, 81);
            this.textCantBus.Name = "textCantBus";
            this.textCantBus.Size = new System.Drawing.Size(136, 20);
            this.textCantBus.TabIndex = 8;
            // 
            // textFrecuencia
            // 
            this.textFrecuencia.Location = new System.Drawing.Point(155, 131);
            this.textFrecuencia.Name = "textFrecuencia";
            this.textFrecuencia.Size = new System.Drawing.Size(136, 20);
            this.textFrecuencia.TabIndex = 9;
            // 
            // textHoraValle
            // 
            this.textHoraValle.Location = new System.Drawing.Point(155, 177);
            this.textHoraValle.Name = "textHoraValle";
            this.textHoraValle.Size = new System.Drawing.Size(136, 20);
            this.textHoraValle.TabIndex = 10;
            // 
            // textHoraPico
            // 
            this.textHoraPico.Location = new System.Drawing.Point(155, 228);
            this.textHoraPico.Name = "textHoraPico";
            this.textHoraPico.Size = new System.Drawing.Size(136, 20);
            this.textHoraPico.TabIndex = 11;
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
            this.groupRestricciones.ResumeLayout(false);
            this.groupRestricciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gMapMIO;
        private System.Windows.Forms.Button butIniSimul;
        private System.Windows.Forms.Button butReporte;
        private System.Windows.Forms.Label labCapacidadBus;
        private System.Windows.Forms.Label labTiemSimul;
        private System.Windows.Forms.TextBox textCapacidadBus;
        private System.Windows.Forms.TextBox textTiemSimul;
        private System.Windows.Forms.Label labMomSemana;
        private System.Windows.Forms.ComboBox comboMomSemana;
        private System.Windows.Forms.GroupBox groupRestricciones;
        private System.Windows.Forms.TextBox textHoraPico;
        private System.Windows.Forms.Label labRuta;
        private System.Windows.Forms.TextBox textHoraValle;
        private System.Windows.Forms.Label labCantBuses;
        private System.Windows.Forms.TextBox textFrecuencia;
        private System.Windows.Forms.Label labFrecuencia;
        private System.Windows.Forms.TextBox textCantBus;
        private System.Windows.Forms.Label labHoraValle;
        private System.Windows.Forms.ComboBox comboRuta;
        private System.Windows.Forms.Label labHoraPico;
    }
}