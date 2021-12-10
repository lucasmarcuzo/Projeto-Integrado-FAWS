
namespace interface_wms
{
    partial class frmProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.mnuSystem = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManualCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpDataProd = new System.Windows.Forms.GroupBox();
            this.txtFornecedores = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtSubCategProd = new System.Windows.Forms.ComboBox();
            this.txtCategProd = new System.Windows.Forms.ComboBox();
            this.txtWeightLiqProd = new System.Windows.Forms.MaskedTextBox();
            this.txtWeightProd = new System.Windows.Forms.MaskedTextBox();
            this.txtExpDateProd = new System.Windows.Forms.MaskedTextBox();
            this.txtEANProd = new System.Windows.Forms.MaskedTextBox();
            this.txtQtdeDispProd = new System.Windows.Forms.MaskedTextBox();
            this.txtPriceProd = new System.Windows.Forms.MaskedTextBox();
            this.txtTipoUnid = new System.Windows.Forms.ComboBox();
            this.txtQtdeProd = new System.Windows.Forms.MaskedTextBox();
            this.lblQtdeProd = new System.Windows.Forms.Label();
            this.lblQtdeDispProd = new System.Windows.Forms.Label();
            this.txtDescripProd = new System.Windows.Forms.TextBox();
            this.lblDescripProd = new System.Windows.Forms.Label();
            this.txtRefProd = new System.Windows.Forms.TextBox();
            this.lblRefProd = new System.Windows.Forms.Label();
            this.lblPriceProd = new System.Windows.Forms.Label();
            this.lblWeightLiqProd = new System.Windows.Forms.Label();
            this.lblWeightProd = new System.Windows.Forms.Label();
            this.lblExpDateProd = new System.Windows.Forms.Label();
            this.lblEANProd = new System.Windows.Forms.Label();
            this.lblProviderProd = new System.Windows.Forms.Label();
            this.lblSubCategProd = new System.Windows.Forms.Label();
            this.lblCategProd = new System.Windows.Forms.Label();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.lblNameProd = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.dgwListProd = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdedisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearchProd = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchProd = new System.Windows.Forms.Label();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tmrDataHora = new System.Windows.Forms.Timer(this.components);
            this.openBrowser = new System.Windows.Forms.OpenFileDialog();
            this.txtImgLocal = new System.Windows.Forms.TextBox();
            this.btnEditImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picIMGProd = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBK01 = new System.Windows.Forms.PictureBox();
            this.picBK02 = new System.Windows.Forms.PictureBox();
            this.mnuSystem.SuspendLayout();
            this.grpDataProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListProd)).BeginInit();
            this.grpSearchProd.SuspendLayout();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBK01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSystem
            // 
            this.mnuSystem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuSystem.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSystem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.mnuSystem.Location = new System.Drawing.Point(0, 0);
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(278, 28);
            this.mnuSystem.TabIndex = 1;
            this.mnuSystem.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferênciasToolStripMenuItem,
            this.toolStripSeparator1,
            this.gerarRelatórioToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.arquivoToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.sistema;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.arquivoToolStripMenuItem.Text = "Sistema";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.sair;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.optionToolStripMenuItem.Text = "Sair";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 6);
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Enabled = false;
            this.preferênciasToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.preferencias;
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.GerarRelatorio;
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar relatório";
            this.gerarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permissõesToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.editarToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.usuario;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.editarToolStripMenuItem.Text = "Usuário";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.permissão;
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            this.permissõesToolStripMenuItem.Click += new System.EventHandler(this.permissõesToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManualCadProd,
            this.toolStripSeparator2,
            this.suporteToolStripMenuItem});
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exibirToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.ajuda1;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.exibirToolStripMenuItem.Text = "Ajuda";
            // 
            // tsmiManualCadProd
            // 
            this.tsmiManualCadProd.Image = global::Interface_WMS_Produtos.Properties.Resources.Manual;
            this.tsmiManualCadProd.Name = "tsmiManualCadProd";
            this.tsmiManualCadProd.ShortcutKeyDisplayString = "F1";
            this.tsmiManualCadProd.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiManualCadProd.Size = new System.Drawing.Size(208, 26);
            this.tsmiManualCadProd.Text = "Manual";
            this.tsmiManualCadProd.Click += new System.EventHandler(this.tsmiSuporteRec_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Image = global::Interface_WMS_Produtos.Properties.Resources.suporte;
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(1459, 87);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(127, 18);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User: 00000000";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(1395, 49);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(195, 31);
            this.lblCompanyName.TabIndex = 6;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(757, 57);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 18);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "FATEC Warehouse System";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.SystemColors.Window;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnMenu.Location = new System.Drawing.Point(1189, 783);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(117, 37);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // grpDataProd
            // 
            this.grpDataProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataProd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDataProd.Controls.Add(this.txtFornecedores);
            this.grpDataProd.Controls.Add(this.lblInstructions);
            this.grpDataProd.Controls.Add(this.txtSubCategProd);
            this.grpDataProd.Controls.Add(this.txtCategProd);
            this.grpDataProd.Controls.Add(this.txtWeightLiqProd);
            this.grpDataProd.Controls.Add(this.txtWeightProd);
            this.grpDataProd.Controls.Add(this.txtExpDateProd);
            this.grpDataProd.Controls.Add(this.txtEANProd);
            this.grpDataProd.Controls.Add(this.txtQtdeDispProd);
            this.grpDataProd.Controls.Add(this.txtPriceProd);
            this.grpDataProd.Controls.Add(this.txtTipoUnid);
            this.grpDataProd.Controls.Add(this.txtQtdeProd);
            this.grpDataProd.Controls.Add(this.lblQtdeProd);
            this.grpDataProd.Controls.Add(this.lblQtdeDispProd);
            this.grpDataProd.Controls.Add(this.txtDescripProd);
            this.grpDataProd.Controls.Add(this.lblDescripProd);
            this.grpDataProd.Controls.Add(this.txtRefProd);
            this.grpDataProd.Controls.Add(this.lblRefProd);
            this.grpDataProd.Controls.Add(this.lblPriceProd);
            this.grpDataProd.Controls.Add(this.lblWeightLiqProd);
            this.grpDataProd.Controls.Add(this.lblWeightProd);
            this.grpDataProd.Controls.Add(this.lblExpDateProd);
            this.grpDataProd.Controls.Add(this.lblEANProd);
            this.grpDataProd.Controls.Add(this.lblProviderProd);
            this.grpDataProd.Controls.Add(this.lblSubCategProd);
            this.grpDataProd.Controls.Add(this.lblCategProd);
            this.grpDataProd.Controls.Add(this.txtNameProd);
            this.grpDataProd.Controls.Add(this.lblNameProd);
            this.grpDataProd.Controls.Add(this.lblCodProd);
            this.grpDataProd.Controls.Add(this.txtCodProd);
            this.grpDataProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDataProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataProd.Location = new System.Drawing.Point(111, 150);
            this.grpDataProd.Margin = new System.Windows.Forms.Padding(4);
            this.grpDataProd.Name = "grpDataProd";
            this.grpDataProd.Padding = new System.Windows.Forms.Padding(4);
            this.grpDataProd.Size = new System.Drawing.Size(1124, 327);
            this.grpDataProd.TabIndex = 15;
            this.grpDataProd.TabStop = false;
            this.grpDataProd.Text = "Informações do Produto";
            // 
            // txtFornecedores
            // 
            this.txtFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFornecedores.Enabled = false;
            this.txtFornecedores.FormattingEnabled = true;
            this.txtFornecedores.Items.AddRange(new object[] {
            "Nova sub categoria"});
            this.txtFornecedores.Location = new System.Drawing.Point(409, 228);
            this.txtFornecedores.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedores.Name = "txtFornecedores";
            this.txtFornecedores.Size = new System.Drawing.Size(240, 28);
            this.txtFornecedores.TabIndex = 32;
            this.txtFornecedores.Click += new System.EventHandler(this.txtFornecedores_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInstructions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInstructions.Location = new System.Drawing.Point(45, 36);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(359, 21);
            this.lblInstructions.TabIndex = 31;
            this.lblInstructions.Text = "Para cadastrar um produto, clique em Novo.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubCategProd
            // 
            this.txtSubCategProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSubCategProd.Enabled = false;
            this.txtSubCategProd.FormattingEnabled = true;
            this.txtSubCategProd.Items.AddRange(new object[] {
            "Nova sub categoria"});
            this.txtSubCategProd.Location = new System.Drawing.Point(231, 228);
            this.txtSubCategProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubCategProd.Name = "txtSubCategProd";
            this.txtSubCategProd.Size = new System.Drawing.Size(169, 28);
            this.txtSubCategProd.TabIndex = 6;
            this.txtSubCategProd.SelectedIndexChanged += new System.EventHandler(this.txtSubCategProd_SelectedIndexChanged);
            this.txtSubCategProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSubCategProd_MouseClick);
            // 
            // txtCategProd
            // 
            this.txtCategProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategProd.Enabled = false;
            this.txtCategProd.FormattingEnabled = true;
            this.txtCategProd.Items.AddRange(new object[] {
            "Nova categoria"});
            this.txtCategProd.Location = new System.Drawing.Point(49, 228);
            this.txtCategProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategProd.Name = "txtCategProd";
            this.txtCategProd.Size = new System.Drawing.Size(172, 28);
            this.txtCategProd.TabIndex = 5;
            this.txtCategProd.SelectedIndexChanged += new System.EventHandler(this.txtCategProd_SelectedIndexChanged);
            this.txtCategProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCategProd_MouseClick);
            // 
            // txtWeightLiqProd
            // 
            this.txtWeightLiqProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeightLiqProd.Enabled = false;
            this.txtWeightLiqProd.Location = new System.Drawing.Point(912, 228);
            this.txtWeightLiqProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeightLiqProd.Name = "txtWeightLiqProd";
            this.txtWeightLiqProd.Size = new System.Drawing.Size(197, 27);
            this.txtWeightLiqProd.TabIndex = 10;
            this.txtWeightLiqProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightLiqProd_KeyPress);
            // 
            // txtWeightProd
            // 
            this.txtWeightProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeightProd.Enabled = false;
            this.txtWeightProd.Location = new System.Drawing.Point(775, 228);
            this.txtWeightProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeightProd.Name = "txtWeightProd";
            this.txtWeightProd.Size = new System.Drawing.Size(128, 27);
            this.txtWeightProd.TabIndex = 9;
            this.txtWeightProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightProd_KeyPress);
            // 
            // txtExpDateProd
            // 
            this.txtExpDateProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpDateProd.Enabled = false;
            this.txtExpDateProd.Location = new System.Drawing.Point(659, 228);
            this.txtExpDateProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpDateProd.Mask = "00/00/0000";
            this.txtExpDateProd.Name = "txtExpDateProd";
            this.txtExpDateProd.Size = new System.Drawing.Size(107, 27);
            this.txtExpDateProd.TabIndex = 8;
            this.txtExpDateProd.ValidatingType = typeof(System.DateTime);
            // 
            // txtEANProd
            // 
            this.txtEANProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEANProd.Enabled = false;
            this.txtEANProd.Location = new System.Drawing.Point(896, 272);
            this.txtEANProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEANProd.Name = "txtEANProd";
            this.txtEANProd.Size = new System.Drawing.Size(213, 27);
            this.txtEANProd.TabIndex = 15;
            this.txtEANProd.Text = "000000000000000";
            this.txtEANProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEANProd_KeyPress);
            // 
            // txtQtdeDispProd
            // 
            this.txtQtdeDispProd.Enabled = false;
            this.txtQtdeDispProd.Location = new System.Drawing.Point(723, 272);
            this.txtQtdeDispProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdeDispProd.Name = "txtQtdeDispProd";
            this.txtQtdeDispProd.Size = new System.Drawing.Size(112, 27);
            this.txtQtdeDispProd.TabIndex = 14;
            this.txtQtdeDispProd.Text = "0000";
            this.txtQtdeDispProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeDispProd_KeyPress);
            // 
            // txtPriceProd
            // 
            this.txtPriceProd.Enabled = false;
            this.txtPriceProd.Location = new System.Drawing.Point(137, 272);
            this.txtPriceProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceProd.Name = "txtPriceProd";
            this.txtPriceProd.Size = new System.Drawing.Size(84, 27);
            this.txtPriceProd.TabIndex = 11;
            this.txtPriceProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceProd_KeyPress);
            // 
            // txtTipoUnid
            // 
            this.txtTipoUnid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoUnid.Enabled = false;
            this.txtTipoUnid.FormattingEnabled = true;
            this.txtTipoUnid.Items.AddRange(new object[] {
            "UN",
            "CX"});
            this.txtTipoUnid.Location = new System.Drawing.Point(231, 272);
            this.txtTipoUnid.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoUnid.Name = "txtTipoUnid";
            this.txtTipoUnid.Size = new System.Drawing.Size(175, 28);
            this.txtTipoUnid.TabIndex = 12;
            // 
            // txtQtdeProd
            // 
            this.txtQtdeProd.Enabled = false;
            this.txtQtdeProd.Location = new System.Drawing.Point(479, 271);
            this.txtQtdeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdeProd.Name = "txtQtdeProd";
            this.txtQtdeProd.Size = new System.Drawing.Size(96, 27);
            this.txtQtdeProd.TabIndex = 13;
            this.txtQtdeProd.Text = "0000";
            this.txtQtdeProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeProd_KeyPress);
            // 
            // lblQtdeProd
            // 
            this.lblQtdeProd.AutoSize = true;
            this.lblQtdeProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeProd.Location = new System.Drawing.Point(415, 277);
            this.lblQtdeProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeProd.Name = "lblQtdeProd";
            this.lblQtdeProd.Size = new System.Drawing.Size(56, 19);
            this.lblQtdeProd.TabIndex = 30;
            this.lblQtdeProd.Text = "Qdte.: *";
            // 
            // lblQtdeDispProd
            // 
            this.lblQtdeDispProd.AutoSize = true;
            this.lblQtdeDispProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeDispProd.Location = new System.Drawing.Point(584, 277);
            this.lblQtdeDispProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeDispProd.Name = "lblQtdeDispProd";
            this.lblQtdeDispProd.Size = new System.Drawing.Size(126, 19);
            this.lblQtdeDispProd.TabIndex = 28;
            this.lblQtdeDispProd.Text = "Qdte. Disponível: *";
            // 
            // txtDescripProd
            // 
            this.txtDescripProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripProd.Enabled = false;
            this.txtDescripProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripProd.Location = new System.Drawing.Point(171, 164);
            this.txtDescripProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripProd.Name = "txtDescripProd";
            this.txtDescripProd.Size = new System.Drawing.Size(939, 27);
            this.txtDescripProd.TabIndex = 4;
            this.txtDescripProd.Text = "descricao-produto";
            // 
            // lblDescripProd
            // 
            this.lblDescripProd.AutoSize = true;
            this.lblDescripProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripProd.Location = new System.Drawing.Point(44, 164);
            this.lblDescripProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripProd.Name = "lblDescripProd";
            this.lblDescripProd.Size = new System.Drawing.Size(118, 28);
            this.lblDescripProd.TabIndex = 26;
            this.lblDescripProd.Text = "Descrição: *";
            // 
            // txtRefProd
            // 
            this.txtRefProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefProd.Enabled = false;
            this.txtRefProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefProd.Location = new System.Drawing.Point(801, 121);
            this.txtRefProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefProd.Name = "txtRefProd";
            this.txtRefProd.Size = new System.Drawing.Size(308, 27);
            this.txtRefProd.TabIndex = 3;
            this.txtRefProd.Text = "ref-produto";
            // 
            // lblRefProd
            // 
            this.lblRefProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRefProd.AutoSize = true;
            this.lblRefProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefProd.Location = new System.Drawing.Point(796, 91);
            this.lblRefProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefProd.Name = "lblRefProd";
            this.lblRefProd.Size = new System.Drawing.Size(74, 28);
            this.lblRefProd.TabIndex = 24;
            this.lblRefProd.Text = "Ref.: **";
            // 
            // lblPriceProd
            // 
            this.lblPriceProd.AutoSize = true;
            this.lblPriceProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProd.Location = new System.Drawing.Point(45, 277);
            this.lblPriceProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceProd.Name = "lblPriceProd";
            this.lblPriceProd.Size = new System.Drawing.Size(88, 19);
            this.lblPriceProd.TabIndex = 19;
            this.lblPriceProd.Text = "Preço (R$): *";
            // 
            // lblWeightLiqProd
            // 
            this.lblWeightLiqProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeightLiqProd.AutoSize = true;
            this.lblWeightLiqProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightLiqProd.Location = new System.Drawing.Point(908, 208);
            this.lblWeightLiqProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeightLiqProd.Name = "lblWeightLiqProd";
            this.lblWeightLiqProd.Size = new System.Drawing.Size(124, 19);
            this.lblWeightLiqProd.TabIndex = 17;
            this.lblWeightLiqProd.Text = "Peso Líquido (g): *";
            // 
            // lblWeightProd
            // 
            this.lblWeightProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeightProd.AutoSize = true;
            this.lblWeightProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightProd.Location = new System.Drawing.Point(771, 208);
            this.lblWeightProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeightProd.Name = "lblWeightProd";
            this.lblWeightProd.Size = new System.Drawing.Size(111, 19);
            this.lblWeightProd.TabIndex = 15;
            this.lblWeightProd.Text = "Peso Bruto (g): *";
            // 
            // lblExpDateProd
            // 
            this.lblExpDateProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpDateProd.AutoSize = true;
            this.lblExpDateProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDateProd.Location = new System.Drawing.Point(657, 208);
            this.lblExpDateProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpDateProd.Name = "lblExpDateProd";
            this.lblExpDateProd.Size = new System.Drawing.Size(75, 19);
            this.lblExpDateProd.TabIndex = 13;
            this.lblExpDateProd.Text = "Validade: *";
            // 
            // lblEANProd
            // 
            this.lblEANProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEANProd.AutoSize = true;
            this.lblEANProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEANProd.Location = new System.Drawing.Point(839, 277);
            this.lblEANProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEANProd.Name = "lblEANProd";
            this.lblEANProd.Size = new System.Drawing.Size(49, 19);
            this.lblEANProd.TabIndex = 11;
            this.lblEANProd.Text = "EAN: *";
            // 
            // lblProviderProd
            // 
            this.lblProviderProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProviderProd.AutoSize = true;
            this.lblProviderProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviderProd.Location = new System.Drawing.Point(407, 208);
            this.lblProviderProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProviderProd.Name = "lblProviderProd";
            this.lblProviderProd.Size = new System.Drawing.Size(93, 19);
            this.lblProviderProd.TabIndex = 9;
            this.lblProviderProd.Text = "Fornecedor: *";
            // 
            // lblSubCategProd
            // 
            this.lblSubCategProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCategProd.AutoSize = true;
            this.lblSubCategProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategProd.Location = new System.Drawing.Point(227, 208);
            this.lblSubCategProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubCategProd.Name = "lblSubCategProd";
            this.lblSubCategProd.Size = new System.Drawing.Size(110, 19);
            this.lblSubCategProd.TabIndex = 7;
            this.lblSubCategProd.Text = "Sub Categoria: *";
            // 
            // lblCategProd
            // 
            this.lblCategProd.AutoSize = true;
            this.lblCategProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategProd.Location = new System.Drawing.Point(47, 208);
            this.lblCategProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategProd.Name = "lblCategProd";
            this.lblCategProd.Size = new System.Drawing.Size(82, 19);
            this.lblCategProd.TabIndex = 5;
            this.lblCategProd.Text = "Categoria: *";
            // 
            // txtNameProd
            // 
            this.txtNameProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameProd.Enabled = false;
            this.txtNameProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProd.Location = new System.Drawing.Point(251, 121);
            this.txtNameProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameProd.Name = "txtNameProd";
            this.txtNameProd.Size = new System.Drawing.Size(541, 27);
            this.txtNameProd.TabIndex = 2;
            this.txtNameProd.Text = "nome-produto";
            // 
            // lblNameProd
            // 
            this.lblNameProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameProd.AutoSize = true;
            this.lblNameProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProd.Location = new System.Drawing.Point(245, 91);
            this.lblNameProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameProd.Name = "lblNameProd";
            this.lblNameProd.Size = new System.Drawing.Size(88, 28);
            this.lblNameProd.TabIndex = 2;
            this.lblNameProd.Text = "Nome: *";
            // 
            // lblCodProd
            // 
            this.lblCodProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(47, 75);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(164, 16);
            this.lblCodProd.TabIndex = 0;
            this.lblCodProd.Text = "Código do produto: **";
            // 
            // txtCodProd
            // 
            this.txtCodProd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodProd.Location = new System.Drawing.Point(49, 96);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(192, 52);
            this.txtCodProd.TabIndex = 1;
            this.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodProd.TextChanged += new System.EventHandler(this.txtCodProd_TextChanged);
            // 
            // dgwListProd
            // 
            this.dgwListProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwListProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwListProd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwListProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nome,
            this.referencia,
            this.categoria,
            this.subcategoria,
            this.fornecedor,
            this.qtde,
            this.qtdedisp});
            this.dgwListProd.Location = new System.Drawing.Point(24, 68);
            this.dgwListProd.Margin = new System.Windows.Forms.Padding(4);
            this.dgwListProd.Name = "dgwListProd";
            this.dgwListProd.ReadOnly = true;
            this.dgwListProd.RowHeadersWidth = 51;
            this.dgwListProd.Size = new System.Drawing.Size(1261, 166);
            this.dgwListProd.TabIndex = 16;
            this.dgwListProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListProd_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID:";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código:";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome:";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // referencia
            // 
            this.referencia.HeaderText = "Ref.:";
            this.referencia.MinimumWidth = 6;
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria:";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // subcategoria
            // 
            this.subcategoria.HeaderText = "Sub Categoria:";
            this.subcategoria.MinimumWidth = 6;
            this.subcategoria.Name = "subcategoria";
            this.subcategoria.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor:";
            this.fornecedor.MinimumWidth = 6;
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Qtde.:";
            this.qtde.MinimumWidth = 6;
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            // 
            // qtdedisp
            // 
            this.qtdedisp.HeaderText = "Qtde. Disp.:";
            this.qtdedisp.MinimumWidth = 6;
            this.qtdedisp.Name = "qtdedisp";
            this.qtdedisp.ReadOnly = true;
            // 
            // grpSearchProd
            // 
            this.grpSearchProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearchProd.Controls.Add(this.btnSearch);
            this.grpSearchProd.Controls.Add(this.lblSearchProd);
            this.grpSearchProd.Controls.Add(this.txtSearchProd);
            this.grpSearchProd.Controls.Add(this.dgwListProd);
            this.grpSearchProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSearchProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchProd.Location = new System.Drawing.Point(111, 490);
            this.grpSearchProd.Margin = new System.Windows.Forms.Padding(4);
            this.grpSearchProd.Name = "grpSearchProd";
            this.grpSearchProd.Padding = new System.Windows.Forms.Padding(4);
            this.grpSearchProd.Size = new System.Drawing.Size(1311, 254);
            this.grpSearchProd.TabIndex = 16;
            this.grpSearchProd.TabStop = false;
            this.grpSearchProd.Text = "Buscar Produtos:";
            this.grpSearchProd.MouseHover += new System.EventHandler(this.grpSearchProd_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Image = global::Interface_WMS_Produtos.Properties.Resources.pesquisar;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(1188, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 31);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // lblSearchProd
            // 
            this.lblSearchProd.AutoSize = true;
            this.lblSearchProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProd.Location = new System.Drawing.Point(20, 34);
            this.lblSearchProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchProd.Name = "lblSearchProd";
            this.lblSearchProd.Size = new System.Drawing.Size(242, 19);
            this.lblSearchProd.TabIndex = 5;
            this.lblSearchProd.Text = "Digite o código ou nome do produto:";
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProd.Location = new System.Drawing.Point(301, 30);
            this.txtSearchProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Size = new System.Drawing.Size(877, 27);
            this.txtSearchProd.TabIndex = 16;
            // 
            // grpControls
            // 
            this.grpControls.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpControls.Controls.Add(this.btnSaveChanges);
            this.grpControls.Controls.Add(this.btnEditProd);
            this.grpControls.Controls.Add(this.btnNew);
            this.grpControls.Controls.Add(this.btnDelete);
            this.grpControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpControls.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpControls.Location = new System.Drawing.Point(1443, 490);
            this.grpControls.Margin = new System.Windows.Forms.Padding(4);
            this.grpControls.Name = "grpControls";
            this.grpControls.Padding = new System.Windows.Forms.Padding(4);
            this.grpControls.Size = new System.Drawing.Size(147, 255);
            this.grpControls.TabIndex = 19;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controles";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSaveChanges.Image = global::Interface_WMS_Produtos.Properties.Resources.salvar_edição;
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSaveChanges.Location = new System.Drawing.Point(13, 185);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(117, 58);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.Text = "Salvar Alterações";
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditProd.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditProd.Enabled = false;
            this.btnEditProd.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProd.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditProd.Image = global::Interface_WMS_Produtos.Properties.Resources.editar;
            this.btnEditProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProd.Location = new System.Drawing.Point(13, 76);
            this.btnEditProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(117, 47);
            this.btnEditProd.TabIndex = 19;
            this.btnEditProd.Text = "Editar";
            this.btnEditProd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditProd.UseVisualStyleBackColor = false;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            this.btnEditProd.MouseHover += new System.EventHandler(this.btnEditProd_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.BackColor = System.Drawing.SystemColors.Window;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnNew.Image = global::Interface_WMS_Produtos.Properties.Resources.novo_cadastro;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(13, 22);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 47);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "Novo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDelete.Image = global::Interface_WMS_Produtos.Properties.Resources.apagar;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(13, 130);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 47);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(760, 78);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(187, 26);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "00/00/0000, 00:00";
            // 
            // tmrDataHora
            // 
            this.tmrDataHora.Enabled = true;
            this.tmrDataHora.Interval = 1;
            this.tmrDataHora.Tick += new System.EventHandler(this.tmrDataHora_Tick_1);
            // 
            // openBrowser
            // 
            this.openBrowser.RestoreDirectory = true;
            this.openBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.openBrowser_FileOk);
            // 
            // txtImgLocal
            // 
            this.txtImgLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImgLocal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtImgLocal.Enabled = false;
            this.txtImgLocal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImgLocal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImgLocal.Location = new System.Drawing.Point(111, 790);
            this.txtImgLocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtImgLocal.Name = "txtImgLocal";
            this.txtImgLocal.Size = new System.Drawing.Size(1069, 25);
            this.txtImgLocal.TabIndex = 31;
            // 
            // btnEditImage
            // 
            this.btnEditImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditImage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEditImage.Enabled = false;
            this.btnEditImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditImage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditImage.Image = ((System.Drawing.Image)(resources.GetObject("btnEditImage.Image")));
            this.btnEditImage.Location = new System.Drawing.Point(1260, 422);
            this.btnEditImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(47, 43);
            this.btnEditImage.TabIndex = 22;
            this.btnEditImage.UseVisualStyleBackColor = false;
            this.btnEditImage.Click += new System.EventHandler(this.btnEditImage_Click);
            this.btnEditImage.MouseHover += new System.EventHandler(this.btnEditImage_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::Interface_WMS_Produtos.Properties.Resources.salvar;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(1343, 783);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 37);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Image = global::Interface_WMS_Produtos.Properties.Resources.cancelar;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(1468, 783);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 37);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picIMGProd
            // 
            this.picIMGProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picIMGProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIMGProd.Enabled = false;
            this.picIMGProd.Image = ((System.Drawing.Image)(resources.GetObject("picIMGProd.Image")));
            this.picIMGProd.Location = new System.Drawing.Point(1243, 160);
            this.picIMGProd.Margin = new System.Windows.Forms.Padding(4);
            this.picIMGProd.Name = "picIMGProd";
            this.picIMGProd.Size = new System.Drawing.Size(347, 320);
            this.picIMGProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIMGProd.TabIndex = 8;
            this.picIMGProd.TabStop = false;
            this.picIMGProd.Click += new System.EventHandler(this.picIMGProd_Click);
            this.picIMGProd.MouseHover += new System.EventHandler(this.picIMGProd_MouseHover);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(125, 42);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(253, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // picBK01
            // 
            this.picBK01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBK01.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBK01.Location = new System.Drawing.Point(0, 30);
            this.picBK01.Margin = new System.Windows.Forms.Padding(4);
            this.picBK01.Name = "picBK01";
            this.picBK01.Size = new System.Drawing.Size(1685, 98);
            this.picBK01.TabIndex = 0;
            this.picBK01.TabStop = false;
            // 
            // picBK02
            // 
            this.picBK02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBK02.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBK02.Location = new System.Drawing.Point(0, 770);
            this.picBK02.Margin = new System.Windows.Forms.Padding(4);
            this.picBK02.Name = "picBK02";
            this.picBK02.Size = new System.Drawing.Size(1685, 73);
            this.picBK02.TabIndex = 12;
            this.picBK02.TabStop = false;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.btnEditImage);
            this.Controls.Add(this.txtImgLocal);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpSearchProd);
            this.Controls.Add(this.grpDataProd);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picIMGProd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.picBK01);
            this.Controls.Add(this.mnuSystem);
            this.Controls.Add(this.picBK02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FAWS WMS - Cadastro de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProdutos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProdutos_FormClosed);
            this.mnuSystem.ResumeLayout(false);
            this.mnuSystem.PerformLayout();
            this.grpDataProd.ResumeLayout(false);
            this.grpDataProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListProd)).EndInit();
            this.grpSearchProd.ResumeLayout(false);
            this.grpSearchProd.PerformLayout();
            this.grpControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIMGProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBK01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManualCadProd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwListProd;
        private System.Windows.Forms.Label lblSearchProd;
        private System.Windows.Forms.TextBox txtSearchProd;
        private System.Windows.Forms.Timer tmrDataHora;
        private System.Windows.Forms.OpenFileDialog openBrowser;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdedisp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        public System.Windows.Forms.PictureBox picBK01;
        public System.Windows.Forms.MenuStrip mnuSystem;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox picIMGProd;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.PictureBox picBK02;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.GroupBox grpDataProd;
        public System.Windows.Forms.GroupBox grpSearchProd;
        public System.Windows.Forms.GroupBox grpControls;
        public System.Windows.Forms.Label lblDateTime;
        public System.Windows.Forms.TextBox txtImgLocal;
        public System.Windows.Forms.Button btnEditImage;
        public System.Windows.Forms.TextBox txtNameProd;
        public System.Windows.Forms.TextBox txtCodProd;
        public System.Windows.Forms.Label lblNameProd;
        public System.Windows.Forms.Label lblPriceProd;
        public System.Windows.Forms.Label lblWeightLiqProd;
        public System.Windows.Forms.Label lblWeightProd;
        public System.Windows.Forms.Label lblExpDateProd;
        public System.Windows.Forms.Label lblEANProd;
        public System.Windows.Forms.Label lblProviderProd;
        public System.Windows.Forms.Label lblSubCategProd;
        public System.Windows.Forms.Label lblCategProd;
        public System.Windows.Forms.Label lblQtdeProd;
        public System.Windows.Forms.Label lblQtdeDispProd;
        public System.Windows.Forms.TextBox txtDescripProd;
        public System.Windows.Forms.Label lblDescripProd;
        public System.Windows.Forms.TextBox txtRefProd;
        public System.Windows.Forms.Label lblRefProd;
        public System.Windows.Forms.Label lblCodProd;
        public System.Windows.Forms.MaskedTextBox txtWeightLiqProd;
        public System.Windows.Forms.MaskedTextBox txtWeightProd;
        public System.Windows.Forms.MaskedTextBox txtExpDateProd;
        public System.Windows.Forms.MaskedTextBox txtEANProd;
        public System.Windows.Forms.MaskedTextBox txtQtdeDispProd;
        public System.Windows.Forms.MaskedTextBox txtPriceProd;
        public System.Windows.Forms.ComboBox txtTipoUnid;
        public System.Windows.Forms.MaskedTextBox txtQtdeProd;
        public System.Windows.Forms.ComboBox txtSubCategProd;
        public System.Windows.Forms.ComboBox txtCategProd;
        public System.Windows.Forms.Label lblInstructions;
        public System.Windows.Forms.ComboBox txtFornecedores;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEditProd;
        public System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

