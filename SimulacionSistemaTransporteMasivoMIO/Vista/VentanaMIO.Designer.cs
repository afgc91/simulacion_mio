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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gMapMIO;
    }
}