namespace Allura
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtTelefoneLimpo = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblFormatado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(110, 45);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(138, 20);
            this.txtTelefone.TabIndex = 0;
            // 
            // txtTelefoneLimpo
            // 
            this.txtTelefoneLimpo.Location = new System.Drawing.Point(110, 78);
            this.txtTelefoneLimpo.Name = "txtTelefoneLimpo";
            this.txtTelefoneLimpo.Size = new System.Drawing.Size(138, 20);
            this.txtTelefoneLimpo.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 135);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 11);
            this.progressBar1.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(7, 45);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblFormatado
            // 
            this.lblFormatado.AutoSize = true;
            this.lblFormatado.Location = new System.Drawing.Point(7, 81);
            this.lblFormatado.Name = "lblFormatado";
            this.lblFormatado.Size = new System.Drawing.Size(89, 13);
            this.lblFormatado.TabIndex = 4;
            this.lblFormatado.Text = "Telefone - Limpo:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(216, 119);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 22);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONVERSÃO TELEFONE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblFormatado);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtTelefoneLimpo);
            this.Controls.Add(this.txtTelefone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtTelefoneLimpo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblFormatado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
    }
}

