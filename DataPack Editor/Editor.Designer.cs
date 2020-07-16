namespace DataPack_Editor
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.PainelProjeto = new System.Windows.Forms.Panel();
            this.Opçoes = new System.Windows.Forms.MenuStrip();
            this.MenuEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMontar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMontarAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditarProjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbrirPasta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCraft = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEfeito = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuComando = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.bntFechar = new System.Windows.Forms.PictureBox();
            this.bntMaximizar = new System.Windows.Forms.PictureBox();
            this.bntMinimizar = new System.Windows.Forms.PictureBox();
            this.BotoesJanela = new System.Windows.Forms.ImageList(this.components);
            this.Opçoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelProjeto
            // 
            this.PainelProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PainelProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelProjeto.Location = new System.Drawing.Point(0, 24);
            this.PainelProjeto.Name = "PainelProjeto";
            this.PainelProjeto.Size = new System.Drawing.Size(558, 36);
            this.PainelProjeto.TabIndex = 0;
            // 
            // Opçoes
            // 
            this.Opçoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Opçoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditor,
            this.MenuProjeto,
            this.MenuAdicionar,
            this.MenuOpcoes});
            this.Opçoes.Location = new System.Drawing.Point(0, 0);
            this.Opçoes.Name = "Opçoes";
            this.Opçoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Opçoes.Size = new System.Drawing.Size(558, 24);
            this.Opçoes.TabIndex = 1;
            this.Opçoes.Text = "menuStrip1";
            // 
            // MenuEditor
            // 
            this.MenuEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovo,
            this.MenuAbrir,
            this.MenuImportar,
            this.MenuSalvar,
            this.MenuExportar,
            this.MenuSair});
            this.MenuEditor.ForeColor = System.Drawing.Color.Silver;
            this.MenuEditor.Name = "MenuEditor";
            this.MenuEditor.Size = new System.Drawing.Size(50, 20);
            this.MenuEditor.Tag = "Menu";
            this.MenuEditor.Text = "Editor";
            this.MenuEditor.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuEditor.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuNovo
            // 
            this.MenuNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuNovo.ForeColor = System.Drawing.Color.Silver;
            this.MenuNovo.Name = "MenuNovo";
            this.MenuNovo.Size = new System.Drawing.Size(120, 22);
            this.MenuNovo.Tag = "Menu";
            this.MenuNovo.Text = "Novo";
            this.MenuNovo.ToolTipText = "Cria um novo projeto.";
            this.MenuNovo.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuNovo.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuAbrir
            // 
            this.MenuAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuAbrir.ForeColor = System.Drawing.Color.Silver;
            this.MenuAbrir.Name = "MenuAbrir";
            this.MenuAbrir.Size = new System.Drawing.Size(120, 22);
            this.MenuAbrir.Text = "Abrir";
            this.MenuAbrir.ToolTipText = "Abre um projeto.";
            this.MenuAbrir.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuAbrir.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuImportar
            // 
            this.MenuImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuImportar.ForeColor = System.Drawing.Color.Silver;
            this.MenuImportar.Name = "MenuImportar";
            this.MenuImportar.Size = new System.Drawing.Size(120, 22);
            this.MenuImportar.Text = "Importar";
            this.MenuImportar.ToolTipText = "Importa um pacote vindo de outro computador.";
            this.MenuImportar.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuImportar.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuSalvar
            // 
            this.MenuSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuSalvar.ForeColor = System.Drawing.Color.Silver;
            this.MenuSalvar.Name = "MenuSalvar";
            this.MenuSalvar.Size = new System.Drawing.Size(120, 22);
            this.MenuSalvar.Text = "Salvar";
            this.MenuSalvar.ToolTipText = "Salva o projeto.";
            this.MenuSalvar.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuSalvar.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuExportar
            // 
            this.MenuExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuExportar.ForeColor = System.Drawing.Color.Silver;
            this.MenuExportar.Name = "MenuExportar";
            this.MenuExportar.Size = new System.Drawing.Size(120, 22);
            this.MenuExportar.Text = "Exportar";
            this.MenuExportar.ToolTipText = "Exporta o projeto para outro computador.";
            this.MenuExportar.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuExportar.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuSair
            // 
            this.MenuSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuSair.ForeColor = System.Drawing.Color.Silver;
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(120, 22);
            this.MenuSair.Text = "Sair";
            this.MenuSair.ToolTipText = "Sair do Programa.";
            this.MenuSair.Click += new System.EventHandler(this.bntFechar_Click);
            this.MenuSair.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuSair.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuProjeto
            // 
            this.MenuProjeto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMontar,
            this.MenuMontarAtualizar,
            this.MenuEditarProjeto,
            this.MenuAbrirPasta});
            this.MenuProjeto.ForeColor = System.Drawing.Color.Silver;
            this.MenuProjeto.Name = "MenuProjeto";
            this.MenuProjeto.Size = new System.Drawing.Size(57, 20);
            this.MenuProjeto.Text = "Projeto";
            this.MenuProjeto.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuProjeto.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuMontar
            // 
            this.MenuMontar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuMontar.ForeColor = System.Drawing.Color.Silver;
            this.MenuMontar.Name = "MenuMontar";
            this.MenuMontar.Size = new System.Drawing.Size(171, 22);
            this.MenuMontar.Text = "Montar";
            this.MenuMontar.ToolTipText = "Monta o projeto para um DataPack";
            this.MenuMontar.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuMontar.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuMontarAtualizar
            // 
            this.MenuMontarAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuMontarAtualizar.ForeColor = System.Drawing.Color.Silver;
            this.MenuMontarAtualizar.Name = "MenuMontarAtualizar";
            this.MenuMontarAtualizar.Size = new System.Drawing.Size(171, 22);
            this.MenuMontarAtualizar.Text = "Montar e Atualizar";
            this.MenuMontarAtualizar.ToolTipText = "Monta o projeto para um DataPack e atualiza para testar no mundo do jogo.";
            this.MenuMontarAtualizar.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuMontarAtualizar.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuEditarProjeto
            // 
            this.MenuEditarProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuEditarProjeto.ForeColor = System.Drawing.Color.Silver;
            this.MenuEditarProjeto.Name = "MenuEditarProjeto";
            this.MenuEditarProjeto.Size = new System.Drawing.Size(171, 22);
            this.MenuEditarProjeto.Text = "Editar Projeto";
            this.MenuEditarProjeto.ToolTipText = "Edita o projeto.";
            this.MenuEditarProjeto.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuEditarProjeto.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuAbrirPasta
            // 
            this.MenuAbrirPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuAbrirPasta.ForeColor = System.Drawing.Color.Silver;
            this.MenuAbrirPasta.Name = "MenuAbrirPasta";
            this.MenuAbrirPasta.Size = new System.Drawing.Size(171, 22);
            this.MenuAbrirPasta.Text = "Abrir Pasta";
            this.MenuAbrirPasta.ToolTipText = "Abre a pasta do projeto.";
            this.MenuAbrirPasta.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuAbrirPasta.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuAdicionar
            // 
            this.MenuAdicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem,
            this.MenuCraft,
            this.MenuEfeito,
            this.MenuComando});
            this.MenuAdicionar.ForeColor = System.Drawing.Color.Silver;
            this.MenuAdicionar.Name = "MenuAdicionar";
            this.MenuAdicionar.Size = new System.Drawing.Size(70, 20);
            this.MenuAdicionar.Text = "Adicionar";
            this.MenuAdicionar.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuAdicionar.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuItem
            // 
            this.MenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItem.ForeColor = System.Drawing.Color.Silver;
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(127, 22);
            this.MenuItem.Text = "Item";
            this.MenuItem.ToolTipText = "Permite modificar um item.";
            this.MenuItem.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuItem.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuCraft
            // 
            this.MenuCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuCraft.ForeColor = System.Drawing.Color.Silver;
            this.MenuCraft.Name = "MenuCraft";
            this.MenuCraft.Size = new System.Drawing.Size(127, 22);
            this.MenuCraft.Text = "Craft";
            this.MenuCraft.ToolTipText = "Permite adicionar um Craft.";
            this.MenuCraft.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuCraft.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuEfeito
            // 
            this.MenuEfeito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuEfeito.ForeColor = System.Drawing.Color.Silver;
            this.MenuEfeito.Name = "MenuEfeito";
            this.MenuEfeito.Size = new System.Drawing.Size(127, 22);
            this.MenuEfeito.Text = "Efeito";
            this.MenuEfeito.ToolTipText = "Comandos para criar um efeito.";
            this.MenuEfeito.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuEfeito.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuComando
            // 
            this.MenuComando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuComando.ForeColor = System.Drawing.Color.Silver;
            this.MenuComando.Name = "MenuComando";
            this.MenuComando.Size = new System.Drawing.Size(127, 22);
            this.MenuComando.Text = "Comando";
            this.MenuComando.ToolTipText = "Permite adicionar um comando.";
            this.MenuComando.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuComando.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // MenuOpcoes
            // 
            this.MenuOpcoes.ForeColor = System.Drawing.Color.Silver;
            this.MenuOpcoes.Name = "MenuOpcoes";
            this.MenuOpcoes.Size = new System.Drawing.Size(59, 20);
            this.MenuOpcoes.Text = "Opções";
            this.MenuOpcoes.ToolTipText = "Opções do programa.";
            this.MenuOpcoes.MouseEnter += new System.EventHandler(this.MenuSelecionado);
            this.MenuOpcoes.MouseLeave += new System.EventHandler(this.MenuDesSelecionado);
            // 
            // bntFechar
            // 
            this.bntFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFechar.Image = ((System.Drawing.Image)(resources.GetObject("bntFechar.Image")));
            this.bntFechar.Location = new System.Drawing.Point(534, 0);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(24, 24);
            this.bntFechar.TabIndex = 2;
            this.bntFechar.TabStop = false;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            this.bntFechar.MouseEnter += new System.EventHandler(this.BotõesJanelaEntrar);
            this.bntFechar.MouseLeave += new System.EventHandler(this.BotõesJanelaSair);
            // 
            // bntMaximizar
            // 
            this.bntMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("bntMaximizar.Image")));
            this.bntMaximizar.Location = new System.Drawing.Point(512, 0);
            this.bntMaximizar.Name = "bntMaximizar";
            this.bntMaximizar.Size = new System.Drawing.Size(24, 24);
            this.bntMaximizar.TabIndex = 2;
            this.bntMaximizar.TabStop = false;
            this.bntMaximizar.Click += new System.EventHandler(this.bntMaximizar_Click);
            this.bntMaximizar.MouseEnter += new System.EventHandler(this.BotõesJanelaEntrar);
            this.bntMaximizar.MouseLeave += new System.EventHandler(this.BotõesJanelaSair);
            // 
            // bntMinimizar
            // 
            this.bntMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("bntMinimizar.Image")));
            this.bntMinimizar.Location = new System.Drawing.Point(488, 0);
            this.bntMinimizar.Name = "bntMinimizar";
            this.bntMinimizar.Size = new System.Drawing.Size(24, 24);
            this.bntMinimizar.TabIndex = 2;
            this.bntMinimizar.TabStop = false;
            this.bntMinimizar.Click += new System.EventHandler(this.bntMinimizar_Click);
            this.bntMinimizar.MouseEnter += new System.EventHandler(this.BotõesJanelaEntrar);
            this.bntMinimizar.MouseLeave += new System.EventHandler(this.BotõesJanelaSair);
            // 
            // BotoesJanela
            // 
            this.BotoesJanela.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BotoesJanela.ImageStream")));
            this.BotoesJanela.TransparentColor = System.Drawing.Color.Transparent;
            this.BotoesJanela.Images.SetKeyName(0, "ATamanho0.png");
            this.BotoesJanela.Images.SetKeyName(1, "ATamanho1.png");
            this.BotoesJanela.Images.SetKeyName(2, "Fechar0.png");
            this.BotoesJanela.Images.SetKeyName(3, "Fechar1.png");
            this.BotoesJanela.Images.SetKeyName(4, "MInimizar0.png");
            this.BotoesJanela.Images.SetKeyName(5, "MInimizar1.png");
            this.BotoesJanela.Images.SetKeyName(6, "RTamanho0.png");
            this.BotoesJanela.Images.SetKeyName(7, "RTamanho1.png");
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(558, 315);
            this.ControlBox = false;
            this.Controls.Add(this.bntMinimizar);
            this.Controls.Add(this.bntMaximizar);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.PainelProjeto);
            this.Controls.Add(this.Opçoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Opçoes.ResumeLayout(false);
            this.Opçoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelProjeto;
        private System.Windows.Forms.MenuStrip Opçoes;
        private System.Windows.Forms.ToolStripMenuItem MenuEditor;
        private System.Windows.Forms.ToolStripMenuItem MenuNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuAbrir;
        private System.Windows.Forms.ToolStripMenuItem MenuSalvar;
        private System.Windows.Forms.ToolStripMenuItem MenuExportar;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem MenuProjeto;
        private System.Windows.Forms.ToolStripMenuItem MenuMontar;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarProjeto;
        private System.Windows.Forms.ToolStripMenuItem MenuAbrirPasta;
        private System.Windows.Forms.ToolStripMenuItem MenuAdicionar;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCraft;
        private System.Windows.Forms.ToolStripMenuItem MenuEfeito;
        private System.Windows.Forms.ToolStripMenuItem MenuComando;
        private System.Windows.Forms.ToolStripMenuItem MenuOpcoes;
        private System.Windows.Forms.PictureBox bntFechar;
        private System.Windows.Forms.PictureBox bntMaximizar;
        private System.Windows.Forms.PictureBox bntMinimizar;
        private System.Windows.Forms.ToolStripMenuItem MenuImportar;
        private System.Windows.Forms.ToolStripMenuItem MenuMontarAtualizar;
        public System.Windows.Forms.ImageList BotoesJanela;
    }
}