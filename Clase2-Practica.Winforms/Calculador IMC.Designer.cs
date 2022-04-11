namespace Clase2_Practica.Winforms
{
    partial class CalculadorIMCForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.buttonCalcularIMC = new System.Windows.Forms.Button();
            this.labelIMC = new System.Windows.Forms.Label();
            this.labelCompCorp = new System.Windows.Forms.Label();
            this.labelIMCValue = new System.Windows.Forms.Label();
            this.labelCompCorpValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(241, 11);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 23);
            this.textBoxAltura.TabIndex = 7;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(168, 15);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(67, 15);
            this.labelAltura.TabIndex = 6;
            this.labelAltura.Text = "Altura (cm)";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(49, 12);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 23);
            this.textBoxPeso.TabIndex = 5;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(11, 15);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(32, 15);
            this.labelPeso.TabIndex = 4;
            this.labelPeso.Text = "Peso";
            // 
            // buttonCalcularIMC
            // 
            this.buttonCalcularIMC.Location = new System.Drawing.Point(376, 11);
            this.buttonCalcularIMC.Name = "buttonCalcularIMC";
            this.buttonCalcularIMC.Size = new System.Drawing.Size(96, 23);
            this.buttonCalcularIMC.TabIndex = 8;
            this.buttonCalcularIMC.Text = "Calcular IMC";
            this.buttonCalcularIMC.UseVisualStyleBackColor = true;
            this.buttonCalcularIMC.Click += new System.EventHandler(this.buttonCalcularIMC_Click);
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Location = new System.Drawing.Point(518, 15);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(32, 15);
            this.labelIMC.TabIndex = 9;
            this.labelIMC.Text = "IMC:";
            // 
            // labelCompCorp
            // 
            this.labelCompCorp.AutoSize = true;
            this.labelCompCorp.Location = new System.Drawing.Point(518, 51);
            this.labelCompCorp.Name = "labelCompCorp";
            this.labelCompCorp.Size = new System.Drawing.Size(133, 15);
            this.labelCompCorp.TabIndex = 9;
            this.labelCompCorp.Text = "Composición Corporal: ";
            // 
            // labelIMCValue
            // 
            this.labelIMCValue.AutoSize = true;
            this.labelIMCValue.Location = new System.Drawing.Point(556, 15);
            this.labelIMCValue.Name = "labelIMCValue";
            this.labelIMCValue.Size = new System.Drawing.Size(17, 15);
            this.labelIMCValue.TabIndex = 9;
            this.labelIMCValue.Text = "--";
            // 
            // labelCompCorpValue
            // 
            this.labelCompCorpValue.AutoSize = true;
            this.labelCompCorpValue.Location = new System.Drawing.Point(657, 51);
            this.labelCompCorpValue.Name = "labelCompCorpValue";
            this.labelCompCorpValue.Size = new System.Drawing.Size(17, 15);
            this.labelCompCorpValue.TabIndex = 9;
            this.labelCompCorpValue.Text = "--";
            // 
            // CalculadorIMCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.labelCompCorp);
            this.Controls.Add(this.labelCompCorpValue);
            this.Controls.Add(this.labelIMCValue);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.buttonCalcularIMC);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.labelPeso);
            this.Name = "CalculadorIMCForm";
            this.Text = "Calculador IMC";
            this.Load += new System.EventHandler(this.CalculadorIMCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Button buttonCalcularIMC;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label labelCompCorp;
        private System.Windows.Forms.Label labelIMCValue;
        private System.Windows.Forms.Label labelCompCorpValue;
    }
}
