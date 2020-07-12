using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            Opçoes.MouseDown += new MouseEventHandler(MouseBaixo);
            Opçoes.MouseMove += new MouseEventHandler(MovimentoMouse);
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
            Application.Exit();
        }
        #endregion
    }
}
