namespace HotelSol.Forms
{
    partial class FormFacturas
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
            bGestionPagos = new Button();
            bAnularFactura = new Button();
            bModificarFactura = new Button();
            bConsultarFactura = new Button();
            bCrearFactura = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bGestionPagos
            // 
            bGestionPagos.BackColor = SystemColors.ActiveCaption;
            bGestionPagos.Location = new Point(93, 360);
            bGestionPagos.Name = "bGestionPagos";
            bGestionPagos.Size = new Size(175, 45);
            bGestionPagos.TabIndex = 51;
            bGestionPagos.Text = "Gestión de pagos";
            bGestionPagos.UseVisualStyleBackColor = false;
            // 
            // bAnularFactura
            // 
            bAnularFactura.BackColor = SystemColors.ActiveCaption;
            bAnularFactura.Location = new Point(339, 320);
            bAnularFactura.Name = "bAnularFactura";
            bAnularFactura.Size = new Size(175, 45);
            bAnularFactura.TabIndex = 50;
            bAnularFactura.Text = "Anular Factura";
            bAnularFactura.UseVisualStyleBackColor = false;
            // 
            // bModificarFactura
            // 
            bModificarFactura.BackColor = SystemColors.ActiveCaption;
            bModificarFactura.Location = new Point(339, 246);
            bModificarFactura.Name = "bModificarFactura";
            bModificarFactura.Size = new Size(175, 45);
            bModificarFactura.TabIndex = 49;
            bModificarFactura.Text = "Modificar Factura";
            bModificarFactura.UseVisualStyleBackColor = false;
            // 
            // bConsultarFactura
            // 
            bConsultarFactura.BackColor = SystemColors.ActiveCaption;
            bConsultarFactura.BackgroundImageLayout = ImageLayout.None;
            bConsultarFactura.Location = new Point(339, 176);
            bConsultarFactura.Name = "bConsultarFactura";
            bConsultarFactura.Size = new Size(175, 45);
            bConsultarFactura.TabIndex = 48;
            bConsultarFactura.Text = "Consultar Factura";
            bConsultarFactura.UseVisualStyleBackColor = false;
            // 
            // bCrearFactura
            // 
            bCrearFactura.BackColor = SystemColors.ActiveCaption;
            bCrearFactura.Location = new Point(339, 107);
            bCrearFactura.Name = "bCrearFactura";
            bCrearFactura.Size = new Size(175, 45);
            bCrearFactura.TabIndex = 47;
            bCrearFactura.Text = "Crear Factura";
            bCrearFactura.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(357, 30);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 46;
            label1.Text = "Facturas";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bGestionPagos);
            Controls.Add(bAnularFactura);
            Controls.Add(bModificarFactura);
            Controls.Add(bConsultarFactura);
            Controls.Add(bCrearFactura);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bGestionPagos;
        private Button bAnularFactura;
        private Button bModificarFactura;
        private Button bConsultarFactura;
        private Button bCrearFactura;
        private Label label1;
    }
}