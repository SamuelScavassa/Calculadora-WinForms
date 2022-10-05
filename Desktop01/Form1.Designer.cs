namespace Desktop01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.botaoSoma = new System.Windows.Forms.Button();
            this.numeroDois = new System.Windows.Forms.TextBox();
            this.numeroUm = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bMenos = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoSoma
            // 
            this.botaoSoma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botaoSoma.Location = new System.Drawing.Point(350, 103);
            this.botaoSoma.Name = "botaoSoma";
            this.botaoSoma.Size = new System.Drawing.Size(75, 23);
            this.botaoSoma.TabIndex = 0;
            this.botaoSoma.Text = "+";
            this.botaoSoma.UseVisualStyleBackColor = false;
            this.botaoSoma.Click += new System.EventHandler(this.botaoSoma_Click);
            // 
            // numeroDois
            // 
            this.numeroDois.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numeroDois.Location = new System.Drawing.Point(455, 143);
            this.numeroDois.Name = "numeroDois";
            this.numeroDois.Size = new System.Drawing.Size(102, 23);
            this.numeroDois.TabIndex = 1;
            // 
            // numeroUm
            // 
            this.numeroUm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numeroUm.Location = new System.Drawing.Point(217, 144);
            this.numeroUm.Name = "numeroUm";
            this.numeroUm.Size = new System.Drawing.Size(102, 23);
            this.numeroUm.TabIndex = 2;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(263, 295);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(238, 23);
            this.resultado.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(254, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Calculadora do Samuel";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bMenos
            // 
            this.bMenos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bMenos.Location = new System.Drawing.Point(350, 132);
            this.bMenos.Name = "bMenos";
            this.bMenos.Size = new System.Drawing.Size(75, 23);
            this.bMenos.TabIndex = 9;
            this.bMenos.Text = "-";
            this.bMenos.UseVisualStyleBackColor = false;
            this.bMenos.Click += new System.EventHandler(this.botaoMenos_Click);
            // 
            // bMulti
            // 
            this.bMulti.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bMulti.Location = new System.Drawing.Point(350, 161);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(75, 23);
            this.bMulti.TabIndex = 10;
            this.bMulti.Text = "*";
            this.bMulti.UseVisualStyleBackColor = false;
            this.bMulti.Click += new System.EventHandler(this.botaoMult_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bDiv.Location = new System.Drawing.Point(350, 190);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(75, 23);
            this.bDiv.TabIndex = 11;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.botaoDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 442);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.bMenos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numeroUm);
            this.Controls.Add(this.numeroDois);
            this.Controls.Add(this.botaoSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button botaoSoma;
        private TextBox numeroDois;
        private TextBox numeroUm;
        private TextBox resultado;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private Button bMenos;
        private Button bMulti;
        private Button bDiv;
    }
}