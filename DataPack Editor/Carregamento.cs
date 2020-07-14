using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPack_Editor
{
    public partial class Carregar : Form
    {
        int X = 0;
        int Y = 0;
        public Carregar()
        {
            InitializeComponent();

            #region Controle de movimento da janela
            PainelArasto.MouseDown += new MouseEventHandler(MouseBaixo);
            PainelArasto.MouseMove += new MouseEventHandler(MovimentoMouse);

            lblTitulo.MouseDown += new MouseEventHandler(MouseBaixo);
            lblTitulo.MouseMove += new MouseEventHandler(MovimentoMouse);
            #endregion
        }
        #region Movimentacao da janela
        private void MouseBaixo(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
        private void MovimentoMouse(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        #endregion
        #region Controle da Janela
        private void bntFechar_Click(object sender, EventArgs e) => Environment.Exit(0);
        private void bntFechar_MouseEnter(object sender, EventArgs e)
        { bntFechar.Image = BotoesJanela.Images[3]; }
        private void bntFechar_MouseLeave(object sender, EventArgs e)
        {  bntFechar.Image = BotoesJanela.Images[2]; }

        private void bntMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void bntMinimizar_MouseEnter(object sender, EventArgs e)
        { bntMinimizar.Image = BotoesJanela.Images[5]; }
        private void bntMinimizar_MouseLeave(object sender, EventArgs e)
        { bntMinimizar.Image = BotoesJanela.Images[4]; }
        #endregion
        #region controle botoes
        private void bntNovo_MouseEnter(object sender, EventArgs e)
        {bntNovo.BackColor = Color.FromArgb(120, 120, 120);}
        private void bntNovo_MouseLeave(object sender, EventArgs e)
        {bntNovo.BackColor = Color.FromArgb(100, 100, 100);}
        private void lblNovo_MouseEnter(object sender, EventArgs e)
        {bntNovo.BackColor = Color.FromArgb(120, 120, 120);}
        private void lblNovo_MouseLeave(object sender, EventArgs e)
        {bntNovo.BackColor = Color.FromArgb(120, 120, 120);}

        private void bntAbrirProjeto_MouseEnter(object sender, EventArgs e)
        {bntAbrirProjeto.BackColor = Color.FromArgb(120, 120, 120);}
        private void bntAbrirProjeto_MouseLeave(object sender, EventArgs e)
        {bntAbrirProjeto.BackColor = Color.FromArgb(100, 100, 100);}
        private void lblAbrirProjeto_MouseEnter(object sender, EventArgs e)
        {bntAbrirProjeto.BackColor = Color.FromArgb(120, 120, 120);}
        private void lblAbrirProjeto_MouseLeave(object sender, EventArgs e)
        {bntAbrirProjeto.BackColor = Color.FromArgb(100, 100, 100);}
        #endregion

        private void Iniciar(object sender,EventArgs e)
        {
            Editor E = new Editor();
            E.Show();
            this.Dispose(false);
        }
    }
}
