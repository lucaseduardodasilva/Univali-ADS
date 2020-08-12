namespace ConversorDeMoedasLucas
{
    partial class Form1
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
            this.txtbReal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbDolar = new System.Windows.Forms.TextBox();
            this.txtbRublo = new System.Windows.Forms.TextBox();
            this.txtbEuro = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbReal
            // 
            this.txtbReal.Location = new System.Drawing.Point(290, 103);
            this.txtbReal.Name = "txtbReal";
            this.txtbReal.Size = new System.Drawing.Size(183, 26);
            this.txtbReal.TabIndex = 0;
            this.txtbReal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor a ser convertido R$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Euro EU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rublos";
            // 
            // txtbDolar
            // 
            this.txtbDolar.Enabled = false;
            this.txtbDolar.Location = new System.Drawing.Point(163, 259);
            this.txtbDolar.Name = "txtbDolar";
            this.txtbDolar.Size = new System.Drawing.Size(93, 26);
            this.txtbDolar.TabIndex = 5;
            // 
            // txtbRublo
            // 
            this.txtbRublo.Enabled = false;
            this.txtbRublo.Location = new System.Drawing.Point(482, 259);
            this.txtbRublo.Name = "txtbRublo";
            this.txtbRublo.Size = new System.Drawing.Size(93, 26);
            this.txtbRublo.TabIndex = 6;
            // 
            // txtbEuro
            // 
            this.txtbEuro.Enabled = false;
            this.txtbEuro.Location = new System.Drawing.Point(330, 259);
            this.txtbEuro.Name = "txtbEuro";
            this.txtbEuro.Size = new System.Drawing.Size(93, 26);
            this.txtbEuro.TabIndex = 7;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(290, 157);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(183, 35);
            this.btnConverter.TabIndex = 8;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(701, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Desenvolvido por Lucas Eduardo da Silva. Análise e Desenv. de Sistemas - Univali " +
    "11/Ago/2020 ©.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtbEuro);
            this.Controls.Add(this.txtbRublo);
            this.Controls.Add(this.txtbDolar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbReal);
            this.Name = "Form1";
            this.Text = "Conversor de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbDolar;
        private System.Windows.Forms.TextBox txtbRublo;
        private System.Windows.Forms.TextBox txtbEuro;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label5;
    }
}

