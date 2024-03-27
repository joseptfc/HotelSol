namespace HotelSol.Forms
{
    partial class FormConsultaHabitaciones
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
            bEstadoHabitaciones = new Button();
            bConsulta = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bEstadoHabitaciones
            // 
            bEstadoHabitaciones.BackColor = SystemColors.ActiveCaption;
            bEstadoHabitaciones.BackgroundImageLayout = ImageLayout.None;
            bEstadoHabitaciones.Location = new Point(321, 254);
            bEstadoHabitaciones.Name = "bEstadoHabitaciones";
            bEstadoHabitaciones.Size = new Size(175, 76);
            bEstadoHabitaciones.TabIndex = 51;
            bEstadoHabitaciones.Text = "Estado de Habitaciones";
            bEstadoHabitaciones.UseVisualStyleBackColor = false;
            // 
            // bConsulta
            // 
            bConsulta.BackColor = SystemColors.ActiveCaption;
            bConsulta.Location = new Point(321, 171);
            bConsulta.Name = "bConsulta";
            bConsulta.Size = new Size(175, 45);
            bConsulta.TabIndex = 50;
            bConsulta.Text = "Consulta";
            bConsulta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(311, 51);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 49;
            label1.Text = "Habitaciones";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bEstadoHabitaciones);
            Controls.Add(bConsulta);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bEstadoHabitaciones;
        private Button bConsulta;
        private Label label1;
    }
}