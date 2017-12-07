namespace Apresentação
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.BarraStatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanharDispesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarDistesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraStatusPrincipal.SuspendLayout();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraStatusPrincipal
            // 
            this.BarraStatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.BarraStatusPrincipal.Location = new System.Drawing.Point(0, 438);
            this.BarraStatusPrincipal.Name = "BarraStatusPrincipal";
            this.BarraStatusPrincipal.Size = new System.Drawing.Size(591, 22);
            this.BarraStatusPrincipal.TabIndex = 1;
            this.BarraStatusPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "Versão 1.0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.movimentaçãoToolStripMenuItem,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(591, 24);
            this.MenuPrincipal.TabIndex = 2;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPessoa,
            this.MenuBanco,
            this.entradasToolStripMenuItem,
            this.origemToolStripMenuItem,
            this.tipoToolStripMenuItem});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.MenuCadastro.Text = "&Cadastro";
            this.MenuCadastro.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // MenuPessoa
            // 
            this.MenuPessoa.Name = "MenuPessoa";
            this.MenuPessoa.Size = new System.Drawing.Size(152, 22);
            this.MenuPessoa.Text = "&Pessoa";
            this.MenuPessoa.Click += new System.EventHandler(this.MenuPessoa_Click);
            // 
            // MenuBanco
            // 
            this.MenuBanco.Name = "MenuBanco";
            this.MenuBanco.Size = new System.Drawing.Size(152, 22);
            this.MenuBanco.Text = "&Bancos";
            this.MenuBanco.Click += new System.EventHandler(this.MenuBanco_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem.Text = "&Receitas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // origemToolStripMenuItem
            // 
            this.origemToolStripMenuItem.Name = "origemToolStripMenuItem";
            this.origemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.origemToolStripMenuItem.Text = "&Origem";
            this.origemToolStripMenuItem.Click += new System.EventHandler(this.origemToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipoToolStripMenuItem.Text = "&Tipo";
            this.tipoToolStripMenuItem.Click += new System.EventHandler(this.tipoToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acompanharDispesasToolStripMenuItem,
            this.adicionarDistesasToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "&Movimentação";
            // 
            // acompanharDispesasToolStripMenuItem
            // 
            this.acompanharDispesasToolStripMenuItem.Name = "acompanharDispesasToolStripMenuItem";
            this.acompanharDispesasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.acompanharDispesasToolStripMenuItem.Text = "Acompanhar Dispesas";
            this.acompanharDispesasToolStripMenuItem.Click += new System.EventHandler(this.acompanharDispesasToolStripMenuItem_Click);
            // 
            // adicionarDistesasToolStripMenuItem
            // 
            this.adicionarDistesasToolStripMenuItem.Name = "adicionarDistesasToolStripMenuItem";
            this.adicionarDistesasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.adicionarDistesasToolStripMenuItem.Text = "Adicionar Distesas";
            this.adicionarDistesasToolStripMenuItem.Click += new System.EventHandler(this.adicionarDistesasToolStripMenuItem_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 460);
            this.Controls.Add(this.BarraStatusPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISFINANCEIRO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.BarraStatusPrincipal.ResumeLayout(false);
            this.BarraStatusPrincipal.PerformLayout();
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BarraStatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuPessoa;
        private System.Windows.Forms.ToolStripMenuItem MenuBanco;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem origemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acompanharDispesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarDistesasToolStripMenuItem;
    }
}