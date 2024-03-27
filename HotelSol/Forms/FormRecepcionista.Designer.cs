
using HotelSol.Forms;

namespace HotelSol
{
    partial class FormRecepcionista
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(374, 102);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 0;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += this.button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 1;
            label1.Text = "Recepcionista";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(374, 153);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 2;
            button2.Text = "Reservas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(374, 204);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 3;
            button3.Text = "Facturas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(374, 255);
            button4.Name = "button4";
            button4.Size = new Size(150, 45);
            button4.TabIndex = 4;
            button4.Text = "Calendario";
            button4.UseVisualStyleBackColor = false;
            button4.Click += this.button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(374, 306);
            button5.Name = "button5";
            button5.Size = new Size(150, 45);
            button5.TabIndex = 5;
            button5.Text = "Habitaciones";
            button5.UseVisualStyleBackColor = false;
            button5.Click += this.button5_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 458);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormConsultaHabitaciones formHabitaciones = new FormConsultaHabitaciones();
            formHabitaciones.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFacturas formFacturas = new FormFacturas();
            formFacturas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGestionReservas formReservas = new FormGestionReservas();
            formReservas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            formGestionClientes.Show();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}