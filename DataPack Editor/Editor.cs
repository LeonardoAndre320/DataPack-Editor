using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPack_Editor
{
    public partial class Editor : Form
    {
        int X = 0;
        int Y = 0;
        public Editor()
        {
            InitializeComponent();

            //Coloca em tela cheia
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            Opçoes.MouseMove += new MouseEventHandler(MovimentoMouse);
            Opçoes.MouseDown += new MouseEventHandler(MouseBaixo);
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
        #region Controle Janela
        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        bool Maximizado = true;
        private void bntMaximizar_Click(object sender, EventArgs e)
        {
            
            if(Maximizado)
            {
                Size = new Size(558,315);
                Maximizado = false;
            }
            else
            {
                Location = new Point(0, 0);
                Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                Maximizado = true;
            }
        }
        private void bntFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuSelecionado(object sender, EventArgs e)
        {
            ToolStripMenuItem Menu = default(ToolStripMenuItem);
            Menu = (ToolStripMenuItem)sender;
            Menu.ForeColor = Color.Black;
        }
        private void MenuDesSelecionado(object sender, EventArgs e)
        {
            ToolStripMenuItem Menu = default(ToolStripMenuItem);
            Menu = (ToolStripMenuItem)sender;
            Menu.ForeColor = Color.Silver;
        }

        private void BotõesJanelaEntrar(object sender, EventArgs e)
        {
            PictureBox Botao = default(PictureBox);
            Botao = (PictureBox)sender;

            switch(Botao.Name)
            {
                case "bntFechar":bntFechar.Image = BotoesJanela.Images[3];
                    break;
                case "bntMinimizar":bntMinimizar.Image = BotoesJanela.Images[5];
                    break;
                case "bntMaximizar":
                    if(Maximizado)
                    {bntMaximizar.Image = BotoesJanela.Images[7];
                    }else{bntMaximizar.Image = BotoesJanela.Images[1];}
                    break;
            }
        }
        private void BotõesJanelaSair(object sender,EventArgs e)
        {
            PictureBox Botao = default(PictureBox);
            Botao = (PictureBox)sender;

            switch(Botao.Name)
            {
                case "bntFechar":bntFechar.Image = BotoesJanela.Images[2];
                    break;
                case "bntMinimizar":bntMinimizar.Image = BotoesJanela.Images[4];
                    break;
                case "bntMaximizar":
                    if(Maximizado)
                    { bntMaximizar.Image = BotoesJanela.Images[6]; 
                    }else{ bntMaximizar.Image = BotoesJanela.Images[0];}
                    break;
            }
        }
        #endregion
    }
}
