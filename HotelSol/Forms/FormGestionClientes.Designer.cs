
using HotelSol.Forms;
using System.Data.SqlClient;

namespace HotelSol
{
    partial class FormGestionClientes
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
            button1 = new Button();
            button2 = new Button();
            bModificaCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(329, 36);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 0;
            label1.Text = "Gestión de clientes";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(388, 130);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 1;
            button1.Text = "Nuevo Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(388, 221);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 2;
            button2.Text = "Consultar Cliente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bModificaCliente
            // 
            bModificaCliente.BackColor = SystemColors.ActiveCaption;
            bModificaCliente.Location = new Point(388, 312);
            bModificaCliente.Name = "bModificaCliente";
            bModificaCliente.Size = new Size(150, 45);
            bModificaCliente.TabIndex = 3;
            bModificaCliente.Text = "Modificar Cliente";
            bModificaCliente.UseVisualStyleBackColor = false;
            bModificaCliente.Click += this.bModificaCliente_Click;
            // 
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 458);
            Controls.Add(bModificaCliente);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormGestionClientes";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        private void bModificaCliente_Click(object sender, EventArgs e)
        {
           FormModificaCliente modificaCliente = new FormModificaCliente();
            modificaCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultarCliente formConsultaCliente = new FormConsultarCliente();
            formConsultaCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
           formNuevoCliente.Show();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button bModificaCliente;
    }
}