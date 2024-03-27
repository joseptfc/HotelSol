namespace HotelSol.Forms
{
    partial class FormGestionReservas
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
            label1 = new Label();
            bNuevaReserva = new Button();
            bConsultarReserva = new Button();
            bModificarReserva = new Button();
            bAnularReserva = new Button();
            bIncidencias = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(264, 33);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 40;
            label1.Text = "Gestión de reservas";
            // 
            // bNuevaReserva
            // 
            bNuevaReserva.BackColor = SystemColors.ActiveCaption;
            bNuevaReserva.Location = new Point(325, 104);
            bNuevaReserva.Name = "bNuevaReserva";
            bNuevaReserva.Size = new Size(175, 45);
            bNuevaReserva.TabIndex = 41;
            bNuevaReserva.Text = "Nueva Reserva";
            bNuevaReserva.UseVisualStyleBackColor = false;
            // 
            // bConsultarReserva
            // 
            bConsultarReserva.BackColor = SystemColors.ActiveCaption;
            bConsultarReserva.Location = new Point(325, 173);
            bConsultarReserva.Name = "bConsultarReserva";
            bConsultarReserva.Size = new Size(175, 45);
            bConsultarReserva.TabIndex = 42;
            bConsultarReserva.Text = "Consultar Reserva";
            bConsultarReserva.UseVisualStyleBackColor = false;
            // 
            // bModificarReserva
            // 
            bModificarReserva.BackColor = SystemColors.ActiveCaption;
            bModificarReserva.Location = new Point(325, 243);
            bModificarReserva.Name = "bModificarReserva";
            bModificarReserva.Size = new Size(175, 45);
            bModificarReserva.TabIndex = 43;
            bModificarReserva.Text = "Modificar Reserva";
            bModificarReserva.UseVisualStyleBackColor = false;
            // 
            // bAnularReserva
            // 
            bAnularReserva.BackColor = SystemColors.ActiveCaption;
            bAnularReserva.Location = new Point(325, 317);
            bAnularReserva.Name = "bAnularReserva";
            bAnularReserva.Size = new Size(175, 45);
            bAnularReserva.TabIndex = 44;
            bAnularReserva.Text = "Anular Reserva";
            bAnularReserva.UseVisualStyleBackColor = false;
            // 
            // bIncidencias
            // 
            bIncidencias.BackColor = SystemColors.ActiveCaption;
            bIncidencias.Location = new Point(79, 357);
            bIncidencias.Name = "bIncidencias";
            bIncidencias.Size = new Size(175, 45);
            bIncidencias.TabIndex = 45;
            bIncidencias.Text = "Incidencias";
            bIncidencias.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bIncidencias);
            Controls.Add(bAnularReserva);
            Controls.Add(bModificarReserva);
            Controls.Add(bConsultarReserva);
            Controls.Add(bNuevaReserva);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button bNuevaReserva;
        private Button bConsultarReserva;
        private Button bModificarReserva;
        private Button bAnularReserva;
        private Button bIncidencias;
    }
}