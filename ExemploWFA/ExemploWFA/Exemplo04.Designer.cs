namespace ExemploWFA
{
    partial class Exemplo04
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
            this.RBSIM = new System.Windows.Forms.RadioButton();
            this.RBNAO = new System.Windows.Forms.RadioButton();
            this.RBLOF = new System.Windows.Forms.RadioButton();
            this.RBFRANCISNITE = new System.Windows.Forms.RadioButton();
            this.LABELGOSTAJOGO = new System.Windows.Forms.Label();
            this.LABELNOMEJOGO = new System.Windows.Forms.Label();
            this.GBGOSTAJOGO = new System.Windows.Forms.GroupBox();
            this.GBNOMEJOGO = new System.Windows.Forms.GroupBox();
            this.GBGOSTAJOGO.SuspendLayout();
            this.GBNOMEJOGO.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBSIM
            // 
            this.RBSIM.AutoSize = true;
            this.RBSIM.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSIM.Location = new System.Drawing.Point(32, 19);
            this.RBSIM.Name = "RBSIM";
            this.RBSIM.Size = new System.Drawing.Size(55, 23);
            this.RBSIM.TabIndex = 0;
            this.RBSIM.TabStop = true;
            this.RBSIM.Text = "Sim";
            this.RBSIM.UseVisualStyleBackColor = true;
            this.RBSIM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBNAO
            // 
            this.RBNAO.AutoSize = true;
            this.RBNAO.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNAO.Location = new System.Drawing.Point(32, 48);
            this.RBNAO.Name = "RBNAO";
            this.RBNAO.Size = new System.Drawing.Size(58, 23);
            this.RBNAO.TabIndex = 1;
            this.RBNAO.TabStop = true;
            this.RBNAO.Text = "Não";
            this.RBNAO.UseVisualStyleBackColor = true;
            // 
            // RBLOF
            // 
            this.RBLOF.AutoSize = true;
            this.RBLOF.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBLOF.Location = new System.Drawing.Point(6, 19);
            this.RBLOF.Name = "RBLOF";
            this.RBLOF.Size = new System.Drawing.Size(179, 23);
            this.RBLOF.TabIndex = 2;
            this.RBLOF.TabStop = true;
            this.RBLOF.Text = "League of Francisco";
            this.RBLOF.UseVisualStyleBackColor = true;
            // 
            // RBFRANCISNITE
            // 
            this.RBFRANCISNITE.AutoSize = true;
            this.RBFRANCISNITE.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFRANCISNITE.Location = new System.Drawing.Point(37, 48);
            this.RBFRANCISNITE.Name = "RBFRANCISNITE";
            this.RBFRANCISNITE.Size = new System.Drawing.Size(115, 23);
            this.RBFRANCISNITE.TabIndex = 3;
            this.RBFRANCISNITE.TabStop = true;
            this.RBFRANCISNITE.Text = "Francisnite";
            this.RBFRANCISNITE.UseVisualStyleBackColor = true;
            // 
            // LABELGOSTAJOGO
            // 
            this.LABELGOSTAJOGO.AutoSize = true;
            this.LABELGOSTAJOGO.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELGOSTAJOGO.Location = new System.Drawing.Point(12, 23);
            this.LABELGOSTAJOGO.Name = "LABELGOSTAJOGO";
            this.LABELGOSTAJOGO.Size = new System.Drawing.Size(153, 22);
            this.LABELGOSTAJOGO.TabIndex = 4;
            this.LABELGOSTAJOGO.Text = "Gosta de jogo?";
            // 
            // LABELNOMEJOGO
            // 
            this.LABELNOMEJOGO.AutoSize = true;
            this.LABELNOMEJOGO.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELNOMEJOGO.Location = new System.Drawing.Point(245, 23);
            this.LABELNOMEJOGO.Name = "LABELNOMEJOGO";
            this.LABELNOMEJOGO.Size = new System.Drawing.Size(146, 22);
            this.LABELNOMEJOGO.TabIndex = 5;
            this.LABELNOMEJOGO.Text = "Nome do jogo:";
            // 
            // GBGOSTAJOGO
            // 
            this.GBGOSTAJOGO.Controls.Add(this.RBSIM);
            this.GBGOSTAJOGO.Controls.Add(this.RBNAO);
            this.GBGOSTAJOGO.Location = new System.Drawing.Point(16, 48);
            this.GBGOSTAJOGO.Name = "GBGOSTAJOGO";
            this.GBGOSTAJOGO.Size = new System.Drawing.Size(126, 87);
            this.GBGOSTAJOGO.TabIndex = 6;
            this.GBGOSTAJOGO.TabStop = false;
            // 
            // GBNOMEJOGO
            // 
            this.GBNOMEJOGO.Controls.Add(this.RBFRANCISNITE);
            this.GBNOMEJOGO.Controls.Add(this.RBLOF);
            this.GBNOMEJOGO.Location = new System.Drawing.Point(220, 48);
            this.GBNOMEJOGO.Name = "GBNOMEJOGO";
            this.GBNOMEJOGO.Size = new System.Drawing.Size(196, 87);
            this.GBNOMEJOGO.TabIndex = 7;
            this.GBNOMEJOGO.TabStop = false;
            // 
            // Exemplo04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 471);
            this.Controls.Add(this.GBNOMEJOGO);
            this.Controls.Add(this.GBGOSTAJOGO);
            this.Controls.Add(this.LABELNOMEJOGO);
            this.Controls.Add(this.LABELGOSTAJOGO);
            this.Name = "Exemplo04";
            this.Text = "Exemplo04";
            this.GBGOSTAJOGO.ResumeLayout(false);
            this.GBGOSTAJOGO.PerformLayout();
            this.GBNOMEJOGO.ResumeLayout(false);
            this.GBNOMEJOGO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBSIM;
        private System.Windows.Forms.RadioButton RBNAO;
        private System.Windows.Forms.RadioButton RBLOF;
        private System.Windows.Forms.RadioButton RBFRANCISNITE;
        private System.Windows.Forms.Label LABELGOSTAJOGO;
        private System.Windows.Forms.Label LABELNOMEJOGO;
        private System.Windows.Forms.GroupBox GBGOSTAJOGO;
        private System.Windows.Forms.GroupBox GBNOMEJOGO;
    }
}