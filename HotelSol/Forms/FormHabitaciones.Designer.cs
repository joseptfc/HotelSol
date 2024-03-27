namespace HotelSol.Forms
{
    partial class FormHabitaciones
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
            bEStadoHabitaciones = new Button();
            bModificarHabitacion = new Button();
            bConsultas = new Button();
            bNuevaHabitacion = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bEStadoHabitaciones
            // 
            bEStadoHabitaciones.BackColor = SystemColors.ActiveCaption;
            bEStadoHabitaciones.Location = new Point(315, 353);
            bEStadoHabitaciones.Name = "bEStadoHabitaciones";
            bEStadoHabitaciones.Size = new Size(175, 63);
            bEStadoHabitaciones.TabIndex = 60;
            bEStadoHabitaciones.Text = "Estado de Habitaciones";
            bEStadoHabitaciones.UseVisualStyleBackColor = false;
            // 
            // bModificarHabitacion
            // 
            bModificarHabitacion.BackColor = SystemColors.ActiveCaption;
            bModificarHabitacion.Location = new Point(315, 279);
            bModificarHabitacion.Name = "bModificarHabitacion";
            bModificarHabitacion.Size = new Size(175, 56);
            bModificarHabitacion.TabIndex = 59;
            bModificarHabitacion.Text = "Modificar Habitación";
            bModificarHabitacion.UseVisualStyleBackColor = false;
            // 
            // bConsultas
            // 
            bConsultas.BackColor = SystemColors.ActiveCaption;
            bConsultas.Location = new Point(315, 209);
            bConsultas.Name = "bConsultas";
            bConsultas.Size = new Size(175, 45);
            bConsultas.TabIndex = 58;
            bConsultas.Text = "Consultas";
            bConsultas.UseCompatibleTextRendering = true;
            bConsultas.UseVisualStyleBackColor = false;
            // 
            // bNuevaHabitacion
            // 
            bNuevaHabitacion.BackColor = SystemColors.ActiveCaption;
            bNuevaHabitacion.Location = new Point(315, 140);
            bNuevaHabitacion.Name = "bNuevaHabitacion";
            bNuevaHabitacion.Size = new Size(175, 45);
            bNuevaHabitacion.TabIndex = 57;
            bNuevaHabitacion.Text = "Nueva Habitación";
            bNuevaHabitacion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(305, 53);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 56;
            label1.Text = "Habitaciones";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bEStadoHabitaciones);
            Controls.Add(bModificarHabitacion);
            Controls.Add(bConsultas);
            Controls.Add(bNuevaHabitacion);
            Controls.Add(label1);
            Name = "Form12";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bEStadoHabitaciones;
        private Button bModificarHabitacion;
        private Button bConsultas;
        private Button bNuevaHabitacion;
        private Label label1;
    }
}