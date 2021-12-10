
namespace FAWS_WMS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.msMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.tsmiSistemaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSairMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPermissoesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimparBD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManualUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrDataHora = new System.Windows.Forms.Timer(this.components);
            this.btnExpedicao = new System.Windows.Forms.Button();
            this.btnArmazem = new System.Windows.Forms.Button();
            this.btnRecebimento = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.picDivisorV = new System.Windows.Forms.PictureBox();
            this.picDivisorH = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsmiSuporteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSystemName.Location = new System.Drawing.Point(111, 272);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(306, 37);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "Fatec Warehouse System";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(825, 258);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(242, 41);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "00/00/0000, 00:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUser.Location = new System.Drawing.Point(1087, 291);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 20);
            this.lblUser.TabIndex = 9;
            // 
            // msMenuSuperior
            // 
            this.msMenuSuperior.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.msMenuSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSistemaMenu,
            this.tsmiUsuarioMenu,
            this.tsmiAjudaMenu});
            this.msMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.msMenuSuperior.Name = "msMenuSuperior";
            this.msMenuSuperior.Size = new System.Drawing.Size(1465, 28);
            this.msMenuSuperior.TabIndex = 17;
            // 
            // tsmiSistemaMenu
            // 
            this.tsmiSistemaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSairMenu,
            this.toolStripMenuItem1});
            this.tsmiSistemaMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiSistemaMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSistemaMenu.Image")));
            this.tsmiSistemaMenu.Name = "tsmiSistemaMenu";
            this.tsmiSistemaMenu.Size = new System.Drawing.Size(95, 24);
            this.tsmiSistemaMenu.Text = "Sistema";
            // 
            // tsmiSairMenu
            // 
            this.tsmiSairMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSairMenu.Image")));
            this.tsmiSairMenu.Name = "tsmiSairMenu";
            this.tsmiSairMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiSairMenu.Size = new System.Drawing.Size(167, 26);
            this.tsmiSairMenu.Text = "Sair";
            this.tsmiSairMenu.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // tsmiUsuarioMenu
            // 
            this.tsmiUsuarioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPermissoesMenu});
            this.tsmiUsuarioMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiUsuarioMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUsuarioMenu.Image")));
            this.tsmiUsuarioMenu.Name = "tsmiUsuarioMenu";
            this.tsmiUsuarioMenu.Size = new System.Drawing.Size(93, 24);
            this.tsmiUsuarioMenu.Text = "Usuário";
            // 
            // tsmiPermissoesMenu
            // 
            this.tsmiPermissoesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLimparBD});
            this.tsmiPermissoesMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPermissoesMenu.Image")));
            this.tsmiPermissoesMenu.Name = "tsmiPermissoesMenu";
            this.tsmiPermissoesMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiPermissoesMenu.Size = new System.Drawing.Size(213, 26);
            this.tsmiPermissoesMenu.Text = "Permissões";
            // 
            // tsmiLimparBD
            // 
            this.tsmiLimparBD.Enabled = false;
            this.tsmiLimparBD.Image = global::FAWS_WMS.Properties.Resources.excluirBD;
            this.tsmiLimparBD.Name = "tsmiLimparBD";
            this.tsmiLimparBD.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmiLimparBD.Size = new System.Drawing.Size(316, 26);
            this.tsmiLimparBD.Text = "Limpar Banco de Dados";
            this.tsmiLimparBD.Click += new System.EventHandler(this.tsmiLimparBD_Click);
            // 
            // tsmiAjudaMenu
            // 
            this.tsmiAjudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManualUsuarioMenu,
            this.toolStripSeparator1,
            this.tsmiSuporteMenu});
            this.tsmiAjudaMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiAjudaMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAjudaMenu.Image")));
            this.tsmiAjudaMenu.Name = "tsmiAjudaMenu";
            this.tsmiAjudaMenu.Size = new System.Drawing.Size(82, 24);
            this.tsmiAjudaMenu.Text = "Ajuda";
            // 
            // tsmiManualUsuarioMenu
            // 
            this.tsmiManualUsuarioMenu.Image = global::FAWS_WMS.Properties.Resources.Manual;
            this.tsmiManualUsuarioMenu.Name = "tsmiManualUsuarioMenu";
            this.tsmiManualUsuarioMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiManualUsuarioMenu.Size = new System.Drawing.Size(241, 26);
            this.tsmiManualUsuarioMenu.Text = "Manual do Usuário";
            this.tsmiManualUsuarioMenu.Click += new System.EventHandler(this.tsmiManualUsuarioMenu_Click);
            // 
            // tmrDataHora
            // 
            this.tmrDataHora.Enabled = true;
            this.tmrDataHora.Interval = 1;
            this.tmrDataHora.Tick += new System.EventHandler(this.tmrDataHora_Tick);
            // 
            // btnExpedicao
            // 
            this.btnExpedicao.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExpedicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpedicao.Enabled = false;
            this.btnExpedicao.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExpedicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpedicao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpedicao.ForeColor = System.Drawing.Color.DarkGray;
            this.btnExpedicao.Image = ((System.Drawing.Image)(resources.GetObject("btnExpedicao.Image")));
            this.btnExpedicao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExpedicao.Location = new System.Drawing.Point(1113, 356);
            this.btnExpedicao.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpedicao.Name = "btnExpedicao";
            this.btnExpedicao.Size = new System.Drawing.Size(241, 151);
            this.btnExpedicao.TabIndex = 5;
            this.btnExpedicao.Text = "Expedição";
            this.btnExpedicao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpedicao.UseVisualStyleBackColor = false;
            this.btnExpedicao.Click += new System.EventHandler(this.btnExpedicao_Click);
            // 
            // btnArmazem
            // 
            this.btnArmazem.BackColor = System.Drawing.SystemColors.Menu;
            this.btnArmazem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArmazem.Enabled = false;
            this.btnArmazem.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnArmazem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmazem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmazem.ForeColor = System.Drawing.Color.DarkGray;
            this.btnArmazem.Image = ((System.Drawing.Image)(resources.GetObject("btnArmazem.Image")));
            this.btnArmazem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArmazem.Location = new System.Drawing.Point(864, 356);
            this.btnArmazem.Margin = new System.Windows.Forms.Padding(4);
            this.btnArmazem.Name = "btnArmazem";
            this.btnArmazem.Size = new System.Drawing.Size(241, 151);
            this.btnArmazem.TabIndex = 4;
            this.btnArmazem.Text = "Armazenagem";
            this.btnArmazem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArmazem.UseVisualStyleBackColor = false;
            this.btnArmazem.Click += new System.EventHandler(this.btnArmazem_Click);
            // 
            // btnRecebimento
            // 
            this.btnRecebimento.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRecebimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecebimento.Enabled = false;
            this.btnRecebimento.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecebimento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecebimento.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRecebimento.Image = ((System.Drawing.Image)(resources.GetObject("btnRecebimento.Image")));
            this.btnRecebimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecebimento.Location = new System.Drawing.Point(615, 356);
            this.btnRecebimento.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecebimento.Name = "btnRecebimento";
            this.btnRecebimento.Size = new System.Drawing.Size(241, 151);
            this.btnRecebimento.TabIndex = 3;
            this.btnRecebimento.Text = "Recebimento";
            this.btnRecebimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecebimento.UseVisualStyleBackColor = false;
            this.btnRecebimento.Click += new System.EventHandler(this.btnRecebimento_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.SystemColors.Menu;
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.Enabled = false;
            this.btnProdutos.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutos.Location = new System.Drawing.Point(365, 356);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(241, 151);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Enabled = false;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(116, 356);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(241, 151);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes e Fornecedores";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // picDivisorV
            // 
            this.picDivisorV.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picDivisorV.Location = new System.Drawing.Point(1075, 249);
            this.picDivisorV.Margin = new System.Windows.Forms.Padding(4);
            this.picDivisorV.Name = "picDivisorV";
            this.picDivisorV.Size = new System.Drawing.Size(1, 62);
            this.picDivisorV.TabIndex = 11;
            this.picDivisorV.TabStop = false;
            // 
            // picDivisorH
            // 
            this.picDivisorH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picDivisorH.Location = new System.Drawing.Point(108, 326);
            this.picDivisorH.Margin = new System.Windows.Forms.Padding(4);
            this.picDivisorH.Name = "picDivisorH";
            this.picDivisorH.Size = new System.Drawing.Size(1253, 2);
            this.picDivisorH.TabIndex = 10;
            this.picDivisorH.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(108, 135);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(423, 133);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.Location = new System.Drawing.Point(1085, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuário:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmiSuporteMenu
            // 
            this.tsmiSuporteMenu.Image = global::FAWS_WMS.Properties.Resources.suporte;
            this.tsmiSuporteMenu.Name = "tsmiSuporteMenu";
            this.tsmiSuporteMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.tsmiSuporteMenu.Size = new System.Drawing.Size(241, 26);
            this.tsmiSuporteMenu.Text = "Suporte";
            this.tsmiSuporteMenu.Click += new System.EventHandler(this.tsmiSuporteMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1465, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpedicao);
            this.Controls.Add(this.btnArmazem);
            this.Controls.Add(this.btnRecebimento);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.picDivisorV);
            this.Controls.Add(this.picDivisorH);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.msMenuSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuSuperior;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAWS WMS - Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.msMenuSuperior.ResumeLayout(false);
            this.msMenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picLogo;
    internal System.Windows.Forms.Label lblSystemName;
    private System.Windows.Forms.Label lblDateTime;
    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.PictureBox picDivisorH;
    private System.Windows.Forms.PictureBox picDivisorV;
    private System.Windows.Forms.Button btnClientes;
    private System.Windows.Forms.Button btnProdutos;
    private System.Windows.Forms.Button btnRecebimento;
    private System.Windows.Forms.Button btnArmazem;
    private System.Windows.Forms.Button btnExpedicao;
    private System.Windows.Forms.MenuStrip msMenuSuperior;
    private System.Windows.Forms.ToolStripMenuItem tsmiSistemaMenu;
    private System.Windows.Forms.ToolStripMenuItem tsmiUsuarioMenu;
    private System.Windows.Forms.ToolStripMenuItem tsmiAjudaMenu;
    private System.Windows.Forms.ToolStripMenuItem tsmiSairMenu;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem tsmiPermissoesMenu;
    private System.Windows.Forms.ToolStripMenuItem tsmiManualUsuarioMenu;
    private System.Windows.Forms.Timer tmrDataHora;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimparBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuporteMenu;
    }
}