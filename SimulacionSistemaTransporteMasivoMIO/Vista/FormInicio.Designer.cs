namespace SimulacionSistemaTransporteMasivoMIO.Vista
{
    partial class FormInicio
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
            this.butIniSimul = new System.Windows.Forms.Button();
            this.labTiemSimul = new System.Windows.Forms.Label();
            this.textCapacidadBus = new System.Windows.Forms.TextBox();
            this.labRuta = new System.Windows.Forms.Label();
            this.labCapacidadBus = new System.Windows.Forms.Label();
            this.textHoraPico = new System.Windows.Forms.TextBox();
            this.textHoraValle = new System.Windows.Forms.TextBox();
            this.labCantBuses = new System.Windows.Forms.Label();
            this.textFrecuencia = new System.Windows.Forms.TextBox();
            this.labFrecuencia = new System.Windows.Forms.Label();
            this.textCantBus = new System.Windows.Forms.TextBox();
            this.labHoraValle = new System.Windows.Forms.Label();
            this.comboRuta = new System.Windows.Forms.ComboBox();
            this.labHoraPico = new System.Windows.Forms.Label();
            this.groupRestricciones = new System.Windows.Forms.GroupBox();
            this.textTiemSimul = new System.Windows.Forms.TextBox();
            this.labMomSemana = new System.Windows.Forms.Label();
            this.comboMomSemana = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupRestricciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // butIniSimul
            // 
            this.butIniSimul.Location = new System.Drawing.Point(117, 635);
            this.butIniSimul.Name = "butIniSimul";
            this.butIniSimul.Size = new System.Drawing.Size(127, 23);
            this.butIniSimul.TabIndex = 22;
            this.butIniSimul.Text = "iniciar simulacion";
            this.butIniSimul.UseVisualStyleBackColor = true;
            this.butIniSimul.Click += new System.EventHandler(this.butIniSimul_Click);
            // 
            // labTiemSimul
            // 
            this.labTiemSimul.AutoSize = true;
            this.labTiemSimul.Location = new System.Drawing.Point(19, 499);
            this.labTiemSimul.Name = "labTiemSimul";
            this.labTiemSimul.Size = new System.Drawing.Size(82, 13);
            this.labTiemSimul.TabIndex = 20;
            this.labTiemSimul.Text = "tiempo a simular";
            // 
            // textCapacidadBus
            // 
            this.textCapacidadBus.Location = new System.Drawing.Point(241, 428);
            this.textCapacidadBus.Name = "textCapacidadBus";
            this.textCapacidadBus.Size = new System.Drawing.Size(100, 20);
            this.textCapacidadBus.TabIndex = 19;
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
            // labCapacidadBus
            // 
            this.labCapacidadBus.AutoSize = true;
            this.labCapacidadBus.Location = new System.Drawing.Point(19, 431);
            this.labCapacidadBus.Name = "labCapacidadBus";
            this.labCapacidadBus.Size = new System.Drawing.Size(88, 13);
            this.labCapacidadBus.TabIndex = 21;
            this.labCapacidadBus.Text = "capacidad buses";
            // 
            // textHoraPico
            // 
            this.textHoraPico.Location = new System.Drawing.Point(155, 228);
            this.textHoraPico.Name = "textHoraPico";
            this.textHoraPico.Size = new System.Drawing.Size(136, 20);
            this.textHoraPico.TabIndex = 11;
            // 
            // textHoraValle
            // 
            this.textHoraValle.Location = new System.Drawing.Point(155, 177);
            this.textHoraValle.Name = "textHoraValle";
            this.textHoraValle.Size = new System.Drawing.Size(136, 20);
            this.textHoraValle.TabIndex = 10;
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
            // textFrecuencia
            // 
            this.textFrecuencia.Location = new System.Drawing.Point(155, 131);
            this.textFrecuencia.Name = "textFrecuencia";
            this.textFrecuencia.Size = new System.Drawing.Size(136, 20);
            this.textFrecuencia.TabIndex = 9;
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
            // textCantBus
            // 
            this.textCantBus.Location = new System.Drawing.Point(155, 81);
            this.textCantBus.Name = "textCantBus";
            this.textCantBus.Size = new System.Drawing.Size(136, 20);
            this.textCantBus.TabIndex = 8;
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
            // comboRuta
            // 
            this.comboRuta.FormattingEnabled = true;
            this.comboRuta.Location = new System.Drawing.Point(155, 29);
            this.comboRuta.Name = "comboRuta";
            this.comboRuta.Size = new System.Drawing.Size(136, 21);
            this.comboRuta.TabIndex = 7;
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
            this.groupRestricciones.Location = new System.Drawing.Point(22, 73);
            this.groupRestricciones.Name = "groupRestricciones";
            this.groupRestricciones.Size = new System.Drawing.Size(319, 333);
            this.groupRestricciones.TabIndex = 23;
            this.groupRestricciones.TabStop = false;
            this.groupRestricciones.Text = "cambiar restricciones";
            // 
            // textTiemSimul
            // 
            this.textTiemSimul.Location = new System.Drawing.Point(241, 496);
            this.textTiemSimul.Name = "textTiemSimul";
            this.textTiemSimul.Size = new System.Drawing.Size(100, 20);
            this.textTiemSimul.TabIndex = 18;
            // 
            // labMomSemana
            // 
            this.labMomSemana.AutoSize = true;
            this.labMomSemana.Location = new System.Drawing.Point(19, 25);
            this.labMomSemana.Name = "labMomSemana";
            this.labMomSemana.Size = new System.Drawing.Size(116, 13);
            this.labMomSemana.TabIndex = 17;
            this.labMomSemana.Text = "momento de la semana";
            // 
            // comboMomSemana
            // 
            this.comboMomSemana.FormattingEnabled = true;
            this.comboMomSemana.Location = new System.Drawing.Point(220, 19);
            this.comboMomSemana.Name = "comboMomSemana";
            this.comboMomSemana.Size = new System.Drawing.Size(121, 21);
            this.comboMomSemana.TabIndex = 16;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 575);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(339, 45);
            this.trackBar1.TabIndex = 24;
            this.trackBar1.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "tiempo real simulacion(min)";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.butIniSimul);
            this.Controls.Add(this.labTiemSimul);
            this.Controls.Add(this.textCapacidadBus);
            this.Controls.Add(this.labCapacidadBus);
            this.Controls.Add(this.groupRestricciones);
            this.Controls.Add(this.textTiemSimul);
            this.Controls.Add(this.labMomSemana);
            this.Controls.Add(this.comboMomSemana);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.groupRestricciones.ResumeLayout(false);
            this.groupRestricciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butIniSimul;
        private System.Windows.Forms.Label labTiemSimul;
        private System.Windows.Forms.TextBox textCapacidadBus;
        private System.Windows.Forms.Label labRuta;
        private System.Windows.Forms.Label labCapacidadBus;
        private System.Windows.Forms.TextBox textHoraPico;
        private System.Windows.Forms.TextBox textHoraValle;
        private System.Windows.Forms.Label labCantBuses;
        private System.Windows.Forms.TextBox textFrecuencia;
        private System.Windows.Forms.Label labFrecuencia;
        private System.Windows.Forms.TextBox textCantBus;
        private System.Windows.Forms.Label labHoraValle;
        private System.Windows.Forms.ComboBox comboRuta;
        private System.Windows.Forms.Label labHoraPico;
        private System.Windows.Forms.GroupBox groupRestricciones;
        private System.Windows.Forms.TextBox textTiemSimul;
        private System.Windows.Forms.Label labMomSemana;
        private System.Windows.Forms.ComboBox comboMomSemana;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}