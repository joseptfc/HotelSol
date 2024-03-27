namespace HotelSol
{
    partial class FormAdmin
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 0;
            label1.Text = "Administrador";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(247, 111);
            button1.Name = "button1";
            button1.Size = new Size(132, 45);
            button1.TabIndex = 1;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(247, 162);
            button3.Name = "button3";
            button3.Size = new Size(132, 45);
            button3.TabIndex = 3;
            button3.Text = "Reservas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(247, 214);
            button4.Name = "button4";
            button4.Size = new Size(132, 45);
            button4.TabIndex = 4;
            button4.Text = "Facturas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(247, 265);
            button5.Name = "button5";
            button5.Size = new Size(132, 45);
            button5.TabIndex = 5;
            button5.Text = "Calendario";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Location = new Point(564, 111);
            button6.Name = "button6";
            button6.Size = new Size(132, 45);
            button6.TabIndex = 6;
            button6.Text = "Contabilidad";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Location = new Point(564, 162);
            button7.Name = "button7";
            button7.Size = new Size(132, 45);
            button7.TabIndex = 7;
            button7.Text = "Tarifas";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Location = new Point(564, 214);
            button8.Name = "button8";
            button8.Size = new Size(132, 45);
            button8.TabIndex = 8;
            button8.Text = "Habitaciones";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaption;
            button9.Location = new Point(564, 265);
            button9.Name = "button9";
            button9.Size = new Size(132, 45);
            button9.TabIndex = 9;
            button9.Text = "Informes";
            button9.UseVisualStyleBackColor = false;
            button9.Click += this.button9_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 458);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}