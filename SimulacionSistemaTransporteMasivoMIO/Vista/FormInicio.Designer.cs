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
            this.textHoraValle = new System.Windows.Forms.TextBox();
            this.labCantBuses = new System.Windows.Forms.Label();
            this.textCantBus = new System.Windows.Forms.TextBox();
            this.labHoraValle = new System.Windows.Forms.Label();
            this.groupRestricciones = new System.Windows.Forms.GroupBox();
            this.textHoraPico = new System.Windows.Forms.TextBox();
            this.labHoraPico = new System.Windows.Forms.Label();
            this.groupRestricciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // butIniSimul
            // 
            this.butIniSimul.Location = new System.Drawing.Point(114, 226);
            this.butIniSimul.Name = "butIniSimul";
            this.butIniSimul.Size = new System.Drawing.Size(127, 23);
            this.butIniSimul.TabIndex = 22;
            this.butIniSimul.Text = "iniciar simulacion";
            this.butIniSimul.UseVisualStyleBackColor = true;
            this.butIniSimul.Click += new System.EventHandler(this.butIniSimul_Click);
            // 
            // textHoraValle
            // 
            this.textHoraValle.Location = new System.Drawing.Point(142, 66);
            this.textHoraValle.Name = "textHoraValle";
            this.textHoraValle.Size = new System.Drawing.Size(136, 20);
            this.textHoraValle.TabIndex = 10;
            // 
            // labCantBuses
            // 
            this.labCantBuses.AutoSize = true;
            this.labCantBuses.Location = new System.Drawing.Point(45, 31);
            this.labCantBuses.Name = "labCantBuses";
            this.labCantBuses.Size = new System.Drawing.Size(79, 13);
            this.labCantBuses.TabIndex = 3;
            this.labCantBuses.Text = "cantidad buses";
            // 
            // textCantBus
            // 
            this.textCantBus.Location = new System.Drawing.Point(142, 25);
            this.textCantBus.Name = "textCantBus";
            this.textCantBus.Size = new System.Drawing.Size(136, 20);
            this.textCantBus.TabIndex = 8;
            // 
            // labHoraValle
            // 
            this.labHoraValle.AutoSize = true;
            this.labHoraValle.Location = new System.Drawing.Point(45, 73);
            this.labHoraValle.Name = "labHoraValle";
            this.labHoraValle.Size = new System.Drawing.Size(73, 13);
            this.labHoraValle.TabIndex = 5;
            this.labHoraValle.Text = "vel. hora valle";
            // 
            // groupRestricciones
            // 
            this.groupRestricciones.Controls.Add(this.textHoraPico);
            this.groupRestricciones.Controls.Add(this.textHoraValle);
            this.groupRestricciones.Controls.Add(this.labCantBuses);
            this.groupRestricciones.Controls.Add(this.textCantBus);
            this.groupRestricciones.Controls.Add(this.labHoraValle);
            this.groupRestricciones.Controls.Add(this.labHoraPico);
            this.groupRestricciones.Location = new System.Drawing.Point(22, 21);
            this.groupRestricciones.Name = "groupRestricciones";
            this.groupRestricciones.Size = new System.Drawing.Size(319, 161);
            this.groupRestricciones.TabIndex = 23;
            this.groupRestricciones.TabStop = false;
            this.groupRestricciones.Text = "cambiar restricciones";
            // 
            // textHoraPico
            // 
            this.textHoraPico.Location = new System.Drawing.Point(142, 117);
            this.textHoraPico.Name = "textHoraPico";
            this.textHoraPico.Size = new System.Drawing.Size(136, 20);
            this.textHoraPico.TabIndex = 11;
            // 
            // labHoraPico
            // 
            this.labHoraPico.AutoSize = true;
            this.labHoraPico.Location = new System.Drawing.Point(45, 124);
            this.labHoraPico.Name = "labHoraPico";
            this.labHoraPico.Size = new System.Drawing.Size(71, 13);
            this.labHoraPico.TabIndex = 6;
            this.labHoraPico.Text = "vel. hora pico";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 307);
            this.Controls.Add(this.butIniSimul);
            this.Controls.Add(this.groupRestricciones);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.groupRestricciones.ResumeLayout(false);
            this.groupRestricciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butIniSimul;
        private System.Windows.Forms.TextBox textHoraValle;
        private System.Windows.Forms.Label labCantBuses;
        private System.Windows.Forms.TextBox textCantBus;
        private System.Windows.Forms.Label labHoraValle;
        private System.Windows.Forms.GroupBox groupRestricciones;
        private System.Windows.Forms.TextBox textHoraPico;
        private System.Windows.Forms.Label labHoraPico;
    }
}