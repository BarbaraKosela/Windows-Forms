namespace ExemploWFA
{
    partial class Exemplo05
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
            this.CBCONFIRMA = new System.Windows.Forms.CheckBox();
            this.CBWINRAR = new System.Windows.Forms.CheckBox();
            this.BTNSALVAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBCONFIRMA
            // 
            this.CBCONFIRMA.AutoSize = true;
            this.CBCONFIRMA.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCONFIRMA.Location = new System.Drawing.Point(12, 12);
            this.CBCONFIRMA.Name = "CBCONFIRMA";
            this.CBCONFIRMA.Size = new System.Drawing.Size(250, 26);
            this.CBCONFIRMA.TabIndex = 1;
            this.CBCONFIRMA.Text = "Confirma que leu tudo?";
            this.CBCONFIRMA.UseVisualStyleBackColor = true;
            // 
            // CBWINRAR
            // 
            this.CBWINRAR.AutoSize = true;
            this.CBWINRAR.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWINRAR.Location = new System.Drawing.Point(12, 44);
            this.CBWINRAR.Name = "CBWINRAR";
            this.CBWINRAR.Size = new System.Drawing.Size(272, 26);
            this.CBWINRAR.TabIndex = 2;
            this.CBWINRAR.Text = "Você comprou o WinRar?";
            this.CBWINRAR.UseVisualStyleBackColor = true;
            // 
            // BTNSALVAR
            // 
            this.BTNSALVAR.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALVAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNSALVAR.Location = new System.Drawing.Point(159, 85);
            this.BTNSALVAR.Name = "BTNSALVAR";
            this.BTNSALVAR.Size = new System.Drawing.Size(115, 34);
            this.BTNSALVAR.TabIndex = 3;
            this.BTNSALVAR.Text = "SALVAR";
            this.BTNSALVAR.UseVisualStyleBackColor = true;
            this.BTNSALVAR.Click += new System.EventHandler(this.BTNSALVAR_Click);
            // 
            // Exemplo05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 465);
            this.Controls.Add(this.BTNSALVAR);
            this.Controls.Add(this.CBWINRAR);
            this.Controls.Add(this.CBCONFIRMA);
            this.Name = "Exemplo05";
            this.Text = "Exemplo05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBCONFIRMA;
        private System.Windows.Forms.CheckBox CBWINRAR;
        private System.Windows.Forms.Button BTNSALVAR;
    }
}