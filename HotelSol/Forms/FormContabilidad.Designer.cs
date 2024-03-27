namespace HotelSol.Forms
{
    partial class FormContabilidad
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
            bImpuestosTasas = new Button();
            bInformes = new Button();
            bGastos = new Button();
            bIngresos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bImpuestosTasas
            // 
            bImpuestosTasas.BackColor = SystemColors.ActiveCaption;
            bImpuestosTasas.Location = new Point(309, 339);
            bImpuestosTasas.Name = "bImpuestosTasas";
            bImpuestosTasas.Size = new Size(175, 45);
            bImpuestosTasas.TabIndex = 50;
            bImpuestosTasas.Text = "Impuestos y tasas";
            bImpuestosTasas.UseVisualStyleBackColor = false;
            // 
            // bInformes
            // 
            bInformes.BackColor = SystemColors.ActiveCaption;
            bInformes.Location = new Point(309, 265);
            bInformes.Name = "bInformes";
            bInformes.Size = new Size(175, 45);
            bInformes.TabIndex = 49;
            bInformes.Text = "Informes";
            bInformes.UseVisualStyleBackColor = false;
            // 
            // bGastos
            // 
            bGastos.BackColor = SystemColors.ActiveCaption;
            bGastos.Location = new Point(309, 195);
            bGastos.Name = "bGastos";
            bGastos.Size = new Size(175, 45);
            bGastos.TabIndex = 48;
            bGastos.Text = "Gastos";
            bGastos.UseCompatibleTextRendering = true;
            bGastos.UseVisualStyleBackColor = false;
            // 
            // bIngresos
            // 
            bIngresos.BackColor = SystemColors.ActiveCaption;
            bIngresos.Location = new Point(309, 126);
            bIngresos.Name = "bIngresos";
            bIngresos.Size = new Size(175, 45);
            bIngresos.TabIndex = 47;
            bIngresos.Text = "Ingresos";
            bIngresos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(301, 44);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 46;
            label1.Text = "Contabilidad";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bImpuestosTasas);
            Controls.Add(bInformes);
            Controls.Add(bGastos);
            Controls.Add(bIngresos);
            Controls.Add(label1);
            Name = "Form10";
            Text = "Hotel Sol V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bImpuestosTasas;
        private Button bInformes;
        private Button bGastos;
        private Button bIngresos;
        private Label label1;
    }
}