namespace HotelSol.Forms
{
    partial class FormTarifas
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
            bModificarOferta = new Button();
            bNuevaOferta = new Button();
            bModificarTarifa = new Button();
            bNuevaTarifa = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bModificarOferta
            // 
            bModificarOferta.BackColor = SystemColors.ActiveCaption;
            bModificarOferta.Location = new Point(317, 350);
            bModificarOferta.Name = "bModificarOferta";
            bModificarOferta.Size = new Size(175, 45);
            bModificarOferta.TabIndex = 55;
            bModificarOferta.Text = "Modificar Oferta";
            bModificarOferta.UseVisualStyleBackColor = false;
            // 
            // bNuevaOferta
            // 
            bNuevaOferta.BackColor = SystemColors.ActiveCaption;
            bNuevaOferta.Location = new Point(317, 276);
            bNuevaOferta.Name = "bNuevaOferta";
            bNuevaOferta.Size = new Size(175, 45);
            bNuevaOferta.TabIndex = 54;
            bNuevaOferta.Text = "Nueva Oferta";
            bNuevaOferta.UseVisualStyleBackColor = false;
            // 
            // bModificarTarifa
            // 
            bModificarTarifa.BackColor = SystemColors.ActiveCaption;
            bModificarTarifa.Location = new Point(317, 206);
            bModificarTarifa.Name = "bModificarTarifa";
            bModificarTarifa.Size = new Size(175, 45);
            bModificarTarifa.TabIndex = 53;
            bModificarTarifa.Text = "Modificar tarifa";
            bModificarTarifa.UseCompatibleTextRendering = true;
            bModificarTarifa.UseVisualStyleBackColor = false;
            // 
            // bNuevaTarifa
            // 
            bNuevaTarifa.BackColor = SystemColors.ActiveCaption;
            bNuevaTarifa.Location = new Point(317, 137);
            bNuevaTarifa.Name = "bNuevaTarifa";
            bNuevaTarifa.Size = new Size(175, 45);
            bNuevaTarifa.TabIndex = 52;
            bNuevaTarifa.Text = "Nueva Tarifa";
            bNuevaTarifa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(289, 50);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 51;
            label1.Text = "Tarifas y Ofertas";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bModificarOferta);
            Controls.Add(bNuevaOferta);
            Controls.Add(bModificarTarifa);
            Controls.Add(bNuevaTarifa);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bModificarOferta;
        private Button bNuevaOferta;
        private Button bModificarTarifa;
        private Button bNuevaTarifa;
        private Label label1;
    }
}