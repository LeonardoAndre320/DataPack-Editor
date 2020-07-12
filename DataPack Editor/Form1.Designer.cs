namespace DataPack_Editor
{
    partial class Carregar
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
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntAbrirProjeto = new System.Windows.Forms.Button();
            this.bntAbrirDataPack = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.grbRecentes = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grbRecentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(13, 13);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(108, 23);
            this.bntNovo.TabIndex = 0;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            // 
            // bntAbrirProjeto
            // 
            this.bntAbrirProjeto.Location = new System.Drawing.Point(13, 43);
            this.bntAbrirProjeto.Name = "bntAbrirProjeto";
            this.bntAbrirProjeto.Size = new System.Drawing.Size(108, 23);
            this.bntAbrirProjeto.TabIndex = 1;
            this.bntAbrirProjeto.Text = "Abrir Projeto";
            this.bntAbrirProjeto.UseVisualStyleBackColor = true;
            // 
            // bntAbrirDataPack
            // 
            this.bntAbrirDataPack.Location = new System.Drawing.Point(13, 73);
            this.bntAbrirDataPack.Name = "bntAbrirDataPack";
            this.bntAbrirDataPack.Size = new System.Drawing.Size(108, 23);
            this.bntAbrirDataPack.TabIndex = 2;
            this.bntAbrirDataPack.Text = "Abrir Data-Pack";
            this.bntAbrirDataPack.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(13, 103);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(108, 23);
            this.bntSair.TabIndex = 3;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            // 
            // grbRecentes
            // 
            this.grbRecentes.Controls.Add(this.listBox1);
            this.grbRecentes.ForeColor = System.Drawing.Color.Black;
            this.grbRecentes.Location = new System.Drawing.Point(128, 13);
            this.grbRecentes.Name = "grbRecentes";
            this.grbRecentes.Size = new System.Drawing.Size(200, 113);
            this.grbRecentes.TabIndex = 4;
            this.grbRecentes.TabStop = false;
            this.grbRecentes.Text = "Recentes";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Recente1",
            "Recente2",
            "Recente3"});
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 94);
            this.listBox1.TabIndex = 0;
            // 
            // Carregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(336, 131);
            this.Controls.Add(this.grbRecentes);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntAbrirDataPack);
            this.Controls.Add(this.bntAbrirProjeto);
            this.Controls.Add(this.bntNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Carregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPack Editor";
            this.grbRecentes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntAbrirProjeto;
        private System.Windows.Forms.Button bntAbrirDataPack;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.GroupBox grbRecentes;
        private System.Windows.Forms.ListBox listBox1;
    }
}

