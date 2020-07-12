﻿namespace DataPack_Editor
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
            this.PainelArasto = new System.Windows.Forms.Panel();
            this.bntMinimizar = new System.Windows.Forms.Label();
            this.bntFechar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bntNovo = new System.Windows.Forms.Panel();
            this.lblNovo = new System.Windows.Forms.Label();
            this.bntAbrirProjeto = new System.Windows.Forms.Panel();
            this.lblAbrirProjeto = new System.Windows.Forms.Label();
            this.lblRecentes = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PainelArasto.SuspendLayout();
            this.bntNovo.SuspendLayout();
            this.bntAbrirProjeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelArasto
            // 
            this.PainelArasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PainelArasto.Controls.Add(this.bntMinimizar);
            this.PainelArasto.Controls.Add(this.bntFechar);
            this.PainelArasto.Controls.Add(this.lblTitulo);
            this.PainelArasto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelArasto.Location = new System.Drawing.Point(0, 0);
            this.PainelArasto.Name = "PainelArasto";
            this.PainelArasto.Size = new System.Drawing.Size(568, 36);
            this.PainelArasto.TabIndex = 0;
            // 
            // bntMinimizar
            // 
            this.bntMinimizar.AutoSize = true;
            this.bntMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bntMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntMinimizar.Location = new System.Drawing.Point(520, 9);
            this.bntMinimizar.Name = "bntMinimizar";
            this.bntMinimizar.Size = new System.Drawing.Size(13, 17);
            this.bntMinimizar.TabIndex = 2;
            this.bntMinimizar.Text = "-";
            this.bntMinimizar.Click += new System.EventHandler(this.bntMinimizar_Click);
            this.bntMinimizar.MouseEnter += new System.EventHandler(this.bntMinimizar_MouseEnter);
            this.bntMinimizar.MouseLeave += new System.EventHandler(this.bntMinimizar_MouseLeave);
            // 
            // bntFechar
            // 
            this.bntFechar.AutoSize = true;
            this.bntFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bntFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntFechar.Location = new System.Drawing.Point(539, 9);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(17, 17);
            this.bntFechar.TabIndex = 1;
            this.bntFechar.Text = "X";
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            this.bntFechar.MouseEnter += new System.EventHandler(this.bntFechar_MouseEnter);
            this.bntFechar.MouseLeave += new System.EventHandler(this.bntFechar_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DataPack Creator";
            // 
            // bntNovo
            // 
            this.bntNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bntNovo.Controls.Add(this.lblNovo);
            this.bntNovo.Location = new System.Drawing.Point(12, 57);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(149, 38);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Click += new System.EventHandler(this.Iniciar);
            this.bntNovo.MouseEnter += new System.EventHandler(this.bntNovo_MouseEnter);
            this.bntNovo.MouseLeave += new System.EventHandler(this.bntNovo_MouseLeave);
            // 
            // lblNovo
            // 
            this.lblNovo.AutoSize = true;
            this.lblNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNovo.ForeColor = System.Drawing.Color.White;
            this.lblNovo.Location = new System.Drawing.Point(10, 10);
            this.lblNovo.Margin = new System.Windows.Forms.Padding(10);
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(41, 16);
            this.lblNovo.TabIndex = 0;
            this.lblNovo.Text = "Novo";
            this.lblNovo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNovo.Click += new System.EventHandler(this.Iniciar);
            this.lblNovo.MouseEnter += new System.EventHandler(this.lblNovo_MouseEnter);
            this.lblNovo.MouseLeave += new System.EventHandler(this.lblNovo_MouseLeave);
            // 
            // bntAbrirProjeto
            // 
            this.bntAbrirProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bntAbrirProjeto.Controls.Add(this.lblAbrirProjeto);
            this.bntAbrirProjeto.Location = new System.Drawing.Point(12, 121);
            this.bntAbrirProjeto.Name = "bntAbrirProjeto";
            this.bntAbrirProjeto.Size = new System.Drawing.Size(149, 38);
            this.bntAbrirProjeto.TabIndex = 1;
            this.bntAbrirProjeto.MouseEnter += new System.EventHandler(this.bntAbrirProjeto_MouseEnter);
            this.bntAbrirProjeto.MouseLeave += new System.EventHandler(this.bntAbrirProjeto_MouseLeave);
            // 
            // lblAbrirProjeto
            // 
            this.lblAbrirProjeto.AutoSize = true;
            this.lblAbrirProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblAbrirProjeto.ForeColor = System.Drawing.Color.White;
            this.lblAbrirProjeto.Location = new System.Drawing.Point(10, 10);
            this.lblAbrirProjeto.Margin = new System.Windows.Forms.Padding(10);
            this.lblAbrirProjeto.Name = "lblAbrirProjeto";
            this.lblAbrirProjeto.Size = new System.Drawing.Size(82, 16);
            this.lblAbrirProjeto.TabIndex = 0;
            this.lblAbrirProjeto.Text = "Abrir Projeto";
            this.lblAbrirProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbrirProjeto.MouseEnter += new System.EventHandler(this.lblAbrirProjeto_MouseEnter);
            this.lblAbrirProjeto.MouseLeave += new System.EventHandler(this.lblAbrirProjeto_MouseLeave);
            // 
            // lblRecentes
            // 
            this.lblRecentes.AutoSize = true;
            this.lblRecentes.ForeColor = System.Drawing.Color.White;
            this.lblRecentes.Location = new System.Drawing.Point(179, 58);
            this.lblRecentes.Name = "lblRecentes";
            this.lblRecentes.Size = new System.Drawing.Size(56, 13);
            this.lblRecentes.TabIndex = 2;
            this.lblRecentes.Text = "Recentes:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listBox1.Location = new System.Drawing.Point(182, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 160);
            this.listBox1.TabIndex = 3;
            // 
            // Carregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(568, 243);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblRecentes);
            this.Controls.Add(this.bntAbrirProjeto);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.PainelArasto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carregar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPack Creator";
            this.PainelArasto.ResumeLayout(false);
            this.PainelArasto.PerformLayout();
            this.bntNovo.ResumeLayout(false);
            this.bntNovo.PerformLayout();
            this.bntAbrirProjeto.ResumeLayout(false);
            this.bntAbrirProjeto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelArasto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label bntFechar;
        private System.Windows.Forms.Label bntMinimizar;
        private System.Windows.Forms.Panel bntNovo;
        private System.Windows.Forms.Panel bntAbrirProjeto;
        private System.Windows.Forms.Label lblNovo;
        private System.Windows.Forms.Label lblAbrirProjeto;
        private System.Windows.Forms.Label lblRecentes;
        private System.Windows.Forms.ListBox listBox1;
    }
}

