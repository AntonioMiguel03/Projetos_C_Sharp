namespace prjConversorNumRom
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorDigitado = new System.Windows.Forms.TextBox();
            this.txtValorConvertido = new System.Windows.Forms.TextBox();
            this.cbxUnidadeA = new System.Windows.Forms.ComboBox();
            this.cbxUnidadeB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnConveter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorDigitado
            // 
            this.txtValorDigitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDigitado.Location = new System.Drawing.Point(257, 73);
            this.txtValorDigitado.Name = "txtValorDigitado";
            this.txtValorDigitado.Size = new System.Drawing.Size(239, 26);
            this.txtValorDigitado.TabIndex = 0;
            this.txtValorDigitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorConvertido
            // 
            this.txtValorConvertido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtValorConvertido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConvertido.Location = new System.Drawing.Point(257, 143);
            this.txtValorConvertido.Name = "txtValorConvertido";
            this.txtValorConvertido.ReadOnly = true;
            this.txtValorConvertido.Size = new System.Drawing.Size(239, 26);
            this.txtValorConvertido.TabIndex = 1;
            this.txtValorConvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxUnidadeA
            // 
            this.cbxUnidadeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidadeA.FormattingEnabled = true;
            this.cbxUnidadeA.Items.AddRange(new object[] {
            "Arábico",
            "Romano"});
            this.cbxUnidadeA.Location = new System.Drawing.Point(64, 73);
            this.cbxUnidadeA.Name = "cbxUnidadeA";
            this.cbxUnidadeA.Size = new System.Drawing.Size(148, 28);
            this.cbxUnidadeA.TabIndex = 2;
            // 
            // cbxUnidadeB
            // 
            this.cbxUnidadeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidadeB.FormattingEnabled = true;
            this.cbxUnidadeB.Items.AddRange(new object[] {
            "Arábico",
            "Romano"});
            this.cbxUnidadeB.Location = new System.Drawing.Point(64, 141);
            this.cbxUnidadeB.Name = "cbxUnidadeB";
            this.cbxUnidadeB.Size = new System.Drawing.Size(148, 28);
            this.cbxUnidadeB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conversor Algarismos Arábicos e Romanos";
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(123, 187);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 37);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // btnConveter
            // 
            this.btnConveter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConveter.Location = new System.Drawing.Point(246, 187);
            this.btnConveter.Name = "btnConveter";
            this.btnConveter.Size = new System.Drawing.Size(105, 37);
            this.btnConveter.TabIndex = 6;
            this.btnConveter.Text = "Converter";
            this.btnConveter.UseVisualStyleBackColor = true;
            this.btnConveter.Click += new System.EventHandler(this.BtnConveter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unidades de medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Digitado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Convertido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 241);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConveter);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxUnidadeB);
            this.Controls.Add(this.cbxUnidadeA);
            this.Controls.Add(this.txtValorConvertido);
            this.Controls.Add(this.txtValorDigitado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorDigitado;
        private System.Windows.Forms.TextBox txtValorConvertido;
        private System.Windows.Forms.ComboBox cbxUnidadeA;
        private System.Windows.Forms.ComboBox cbxUnidadeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnConveter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

