
namespace ProjetoIntegradoArmazem
{
    partial class frminterfaceWMS_Armazem
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

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminterfaceWMS_Armazem));
            this.msOpcoes = new System.Windows.Forms.MenuStrip();
            this.tmsiSistemaPRINC = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiOptionSairPRINC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsioptionPreferenciasPRNC = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiUsuarioPRINC = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsioptionVerMatriculaPRINC = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsioptionPermissoesPRINC = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAjudaPRINC = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsioptionManualPRINC = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.lblDataeHora = new System.Windows.Forms.Label();
            this.gpbControles = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionarNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.btnMostrarDados = new System.Windows.Forms.Button();
            this.DtGrdArmazem = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtConsulta_Prod = new System.Windows.Forms.TextBox();
            this.lblConsultaProdutos = new System.Windows.Forms.Label();
            this.gpbEnderecamento = new System.Windows.Forms.GroupBox();
            this.txtEndereco_Prod = new System.Windows.Forms.TextBox();
            this.lblEnderecoProduto = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtArea_Prod = new System.Windows.Forms.TextBox();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.txtVao = new System.Windows.Forms.TextBox();
            this.lblVao = new System.Windows.Forms.Label();
            this.txtCorredor = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCorredor = new System.Windows.Forms.Label();
            this.gpbDimensoes = new System.Windows.Forms.GroupBox();
            this.txtVolume_Prod = new System.Windows.Forms.TextBox();
            this.txtPeso_Prod = new System.Windows.Forms.TextBox();
            this.txtComprimento_Prod = new System.Windows.Forms.TextBox();
            this.txtLargura_Prod = new System.Windows.Forms.TextBox();
            this.txtAltura_Prod = new System.Windows.Forms.TextBox();
            this.lblPesoBruto = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblComprimento = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtID_Endereco = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblID_fornecedor = new System.Windows.Forms.Label();
            this.lblEan = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigo_Ean = new System.Windows.Forms.TextBox();
            this.txtCodigo_Prod = new System.Windows.Forms.TextBox();
            this.txtNome_Prod = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.tipDicas = new System.Windows.Forms.ToolTip(this.components);
            this.btnRelatorioMensal = new System.Windows.Forms.Button();
            this.btnBalancoInventario = new System.Windows.Forms.Button();
            this.btnVisualizarMapa = new System.Windows.Forms.Button();
            this.lblFatecWMS = new System.Windows.Forms.Label();
            this.lbNomeUsuarioPrincipal = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picCabecalho = new System.Windows.Forms.PictureBox();
            this.msOpcoes.SuspendLayout();
            this.gpbControles.SuspendLayout();
            this.gpbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdArmazem)).BeginInit();
            this.gpbEnderecamento.SuspendLayout();
            this.gpbDimensoes.SuspendLayout();
            this.gpbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).BeginInit();
            this.SuspendLayout();
            // 
            // msOpcoes
            // 
            this.msOpcoes.BackColor = System.Drawing.SystemColors.Window;
            this.msOpcoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOpcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiSistemaPRINC,
            this.tmsiUsuarioPRINC,
            this.tmsiAjudaPRINC});
            this.msOpcoes.Location = new System.Drawing.Point(0, 0);
            this.msOpcoes.Name = "msOpcoes";
            this.msOpcoes.Size = new System.Drawing.Size(1683, 28);
            this.msOpcoes.TabIndex = 2;
            this.msOpcoes.Text = "menuStrip1";
            // 
            // tmsiSistemaPRINC
            // 
            this.tmsiSistemaPRINC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiOptionSairPRINC,
            this.toolStripMenuItem1,
            this.tmsioptionPreferenciasPRNC});
            this.tmsiSistemaPRINC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tmsiSistemaPRINC.Image = ((System.Drawing.Image)(resources.GetObject("tmsiSistemaPRINC.Image")));
            this.tmsiSistemaPRINC.Name = "tmsiSistemaPRINC";
            this.tmsiSistemaPRINC.Size = new System.Drawing.Size(99, 24);
            this.tmsiSistemaPRINC.Text = " Sistema";
            // 
            // tmsiOptionSairPRINC
            // 
            this.tmsiOptionSairPRINC.Image = ((System.Drawing.Image)(resources.GetObject("tmsiOptionSairPRINC.Image")));
            this.tmsiOptionSairPRINC.Name = "tmsiOptionSairPRINC";
            this.tmsiOptionSairPRINC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tmsiOptionSairPRINC.Size = new System.Drawing.Size(222, 26);
            this.tmsiOptionSairPRINC.Text = "Sair";
            this.tmsiOptionSairPRINC.Click += new System.EventHandler(this.optionSair_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // tmsioptionPreferenciasPRNC
            // 
            this.tmsioptionPreferenciasPRNC.Image = ((System.Drawing.Image)(resources.GetObject("tmsioptionPreferenciasPRNC.Image")));
            this.tmsioptionPreferenciasPRNC.Name = "tmsioptionPreferenciasPRNC";
            this.tmsioptionPreferenciasPRNC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tmsioptionPreferenciasPRNC.Size = new System.Drawing.Size(222, 26);
            this.tmsioptionPreferenciasPRNC.Text = "Preferências";
            this.tmsioptionPreferenciasPRNC.Click += new System.EventHandler(this.optionPreferencias_Click);
            // 
            // tmsiUsuarioPRINC
            // 
            this.tmsiUsuarioPRINC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsioptionVerMatriculaPRINC,
            this.tmsioptionPermissoesPRINC});
            this.tmsiUsuarioPRINC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tmsiUsuarioPRINC.Image = ((System.Drawing.Image)(resources.GetObject("tmsiUsuarioPRINC.Image")));
            this.tmsiUsuarioPRINC.Name = "tmsiUsuarioPRINC";
            this.tmsiUsuarioPRINC.Size = new System.Drawing.Size(93, 24);
            this.tmsiUsuarioPRINC.Text = "Usuário";
            // 
            // tmsioptionVerMatriculaPRINC
            // 
            this.tmsioptionVerMatriculaPRINC.Image = ((System.Drawing.Image)(resources.GetObject("tmsioptionVerMatriculaPRINC.Image")));
            this.tmsioptionVerMatriculaPRINC.Name = "tmsioptionVerMatriculaPRINC";
            this.tmsioptionVerMatriculaPRINC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tmsioptionVerMatriculaPRINC.Size = new System.Drawing.Size(230, 26);
            this.tmsioptionVerMatriculaPRINC.Text = "Ver matrícula";
            this.tmsioptionVerMatriculaPRINC.Click += new System.EventHandler(this.optionVerMatricula_Click);
            // 
            // tmsioptionPermissoesPRINC
            // 
            this.tmsioptionPermissoesPRINC.Image = ((System.Drawing.Image)(resources.GetObject("tmsioptionPermissoesPRINC.Image")));
            this.tmsioptionPermissoesPRINC.Name = "tmsioptionPermissoesPRINC";
            this.tmsioptionPermissoesPRINC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tmsioptionPermissoesPRINC.Size = new System.Drawing.Size(230, 26);
            this.tmsioptionPermissoesPRINC.Text = "Permissões";
            this.tmsioptionPermissoesPRINC.Click += new System.EventHandler(this.optionPermissoes_Click);
            // 
            // tmsiAjudaPRINC
            // 
            this.tmsiAjudaPRINC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsioptionManualPRINC,
            this.suporteToolStripMenuItem});
            this.tmsiAjudaPRINC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tmsiAjudaPRINC.Image = ((System.Drawing.Image)(resources.GetObject("tmsiAjudaPRINC.Image")));
            this.tmsiAjudaPRINC.Name = "tmsiAjudaPRINC";
            this.tmsiAjudaPRINC.Size = new System.Drawing.Size(82, 24);
            this.tmsiAjudaPRINC.Text = "Ajuda";
            // 
            // tmsioptionManualPRINC
            // 
            this.tmsioptionManualPRINC.Image = global::Interface_WMS_Armazem.Properties.Resources.Manual;
            this.tmsioptionManualPRINC.Name = "tmsioptionManualPRINC";
            this.tmsioptionManualPRINC.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tmsioptionManualPRINC.Size = new System.Drawing.Size(208, 26);
            this.tmsioptionManualPRINC.Text = "Manual";
            this.tmsioptionManualPRINC.Click += new System.EventHandler(this.optionSuporte_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Image = global::Interface_WMS_Armazem.Properties.Resources.suporte;
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(1370, 48);
            this.lblNomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(158, 32);
            this.lblNomeEmpresa.TabIndex = 18;
            this.lblNomeEmpresa.Text = "Rapid Express";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1389, 85);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 20);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuário: ";
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Interval = 1;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // lblDataeHora
            // 
            this.lblDataeHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDataeHora.AutoSize = true;
            this.lblDataeHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataeHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataeHora.Location = new System.Drawing.Point(760, 78);
            this.lblDataeHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataeHora.Name = "lblDataeHora";
            this.lblDataeHora.Size = new System.Drawing.Size(183, 28);
            this.lblDataeHora.TabIndex = 22;
            this.lblDataeHora.Text = "dd/mm/yyyy, 00:00";
            // 
            // gpbControles
            // 
            this.gpbControles.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gpbControles.Controls.Add(this.btnEditar);
            this.gpbControles.Controls.Add(this.btnAdicionarNovo);
            this.gpbControles.Controls.Add(this.btnSalvar);
            this.gpbControles.Controls.Add(this.btnLimpar);
            this.gpbControles.Controls.Add(this.btnMenu);
            this.gpbControles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbControles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbControles.Location = new System.Drawing.Point(1439, 442);
            this.gpbControles.Margin = new System.Windows.Forms.Padding(4);
            this.gpbControles.Name = "gpbControles";
            this.gpbControles.Padding = new System.Windows.Forms.Padding(4);
            this.gpbControles.Size = new System.Drawing.Size(147, 330);
            this.gpbControles.TabIndex = 23;
            this.gpbControles.TabStop = false;
            this.gpbControles.Text = "Controles";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(17, 145);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 47);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "     Editar";
            this.tipDicas.SetToolTip(this.btnEditar, "Clique para editar informações de um produto.");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionarNovo
            // 
            this.btnAdicionarNovo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdicionarNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdicionarNovo.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdicionarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarNovo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionarNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarNovo.Image")));
            this.btnAdicionarNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarNovo.Location = new System.Drawing.Point(17, 31);
            this.btnAdicionarNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarNovo.Name = "btnAdicionarNovo";
            this.btnAdicionarNovo.Size = new System.Drawing.Size(117, 47);
            this.btnAdicionarNovo.TabIndex = 45;
            this.btnAdicionarNovo.Text = "       Novo";
            this.tipDicas.SetToolTip(this.btnAdicionarNovo, "Clique para adicionar um novo produto.");
            this.btnAdicionarNovo.UseVisualStyleBackColor = false;
            this.btnAdicionarNovo.Click += new System.EventHandler(this.btnAdicionarNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(17, 88);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 47);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "     Salvar";
            this.tipDicas.SetToolTip(this.btnSalvar, "Clique para salvar um novo produto.");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(17, 202);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 47);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "      Limpar";
            this.tipDicas.SetToolTip(this.btnLimpar, "Clique para limpar os campos.");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(17, 259);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(117, 47);
            this.btnMenu.TabIndex = 26;
            this.btnMenu.Text = "      Menu";
            this.tipDicas.SetToolTip(this.btnMenu, "Clique para visualizar a integração entre os módulos.");
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbConsulta.Controls.Add(this.btnMostrarDados);
            this.gpbConsulta.Controls.Add(this.DtGrdArmazem);
            this.gpbConsulta.Controls.Add(this.btnBuscar);
            this.gpbConsulta.Controls.Add(this.txtConsulta_Prod);
            this.gpbConsulta.Controls.Add(this.lblConsultaProdutos);
            this.gpbConsulta.Location = new System.Drawing.Point(37, 441);
            this.gpbConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Padding = new System.Windows.Forms.Padding(4);
            this.gpbConsulta.Size = new System.Drawing.Size(1378, 330);
            this.gpbConsulta.TabIndex = 3;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Buscar produtos";
            // 
            // btnMostrarDados
            // 
            this.btnMostrarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarDados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrarDados.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMostrarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDados.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarDados.Image")));
            this.btnMostrarDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarDados.Location = new System.Drawing.Point(1239, 23);
            this.btnMostrarDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarDados.Name = "btnMostrarDados";
            this.btnMostrarDados.Size = new System.Drawing.Size(131, 38);
            this.btnMostrarDados.TabIndex = 91;
            this.btnMostrarDados.Text = "       Ver dados";
            this.tipDicas.SetToolTip(this.btnMostrarDados, "Clique para visualizar todos os produtos do banco de dados.");
            this.btnMostrarDados.UseVisualStyleBackColor = false;
            this.btnMostrarDados.Click += new System.EventHandler(this.btnMostrarDados_Click);
            // 
            // DtGrdArmazem
            // 
            this.DtGrdArmazem.AllowUserToAddRows = false;
            this.DtGrdArmazem.AllowUserToDeleteRows = false;
            this.DtGrdArmazem.AllowUserToResizeColumns = false;
            this.DtGrdArmazem.AllowUserToResizeRows = false;
            this.DtGrdArmazem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtGrdArmazem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtGrdArmazem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdArmazem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DtGrdArmazem.Location = new System.Drawing.Point(24, 69);
            this.DtGrdArmazem.Margin = new System.Windows.Forms.Padding(4);
            this.DtGrdArmazem.Name = "DtGrdArmazem";
            this.DtGrdArmazem.ReadOnly = true;
            this.DtGrdArmazem.RowHeadersWidth = 51;
            this.DtGrdArmazem.Size = new System.Drawing.Size(1346, 244);
            this.DtGrdArmazem.StandardTab = true;
            this.DtGrdArmazem.TabIndex = 90;
            this.DtGrdArmazem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArmazem_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1095, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 38);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "    Buscar";
            this.tipDicas.SetToolTip(this.btnBuscar, "Clique para buscar algum produto.");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtConsulta_Prod
            // 
            this.txtConsulta_Prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta_Prod.Location = new System.Drawing.Point(401, 32);
            this.txtConsulta_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsulta_Prod.Name = "txtConsulta_Prod";
            this.txtConsulta_Prod.Size = new System.Drawing.Size(658, 22);
            this.txtConsulta_Prod.TabIndex = 28;
            // 
            // lblConsultaProdutos
            // 
            this.lblConsultaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsultaProdutos.AutoSize = true;
            this.lblConsultaProdutos.Location = new System.Drawing.Point(20, 36);
            this.lblConsultaProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultaProdutos.Name = "lblConsultaProdutos";
            this.lblConsultaProdutos.Size = new System.Drawing.Size(374, 17);
            this.lblConsultaProdutos.TabIndex = 0;
            this.lblConsultaProdutos.Text = "Digite o endereço (código de busca) ou nome do produto:";
            // 
            // gpbEnderecamento
            // 
            this.gpbEnderecamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEnderecamento.Controls.Add(this.txtEndereco_Prod);
            this.gpbEnderecamento.Controls.Add(this.lblEnderecoProduto);
            this.gpbEnderecamento.Controls.Add(this.lblNivel);
            this.gpbEnderecamento.Controls.Add(this.lblModulo);
            this.gpbEnderecamento.Controls.Add(this.txtNivel);
            this.gpbEnderecamento.Controls.Add(this.txtArea_Prod);
            this.gpbEnderecamento.Controls.Add(this.txtModulo);
            this.gpbEnderecamento.Controls.Add(this.txtVao);
            this.gpbEnderecamento.Controls.Add(this.lblVao);
            this.gpbEnderecamento.Controls.Add(this.txtCorredor);
            this.gpbEnderecamento.Controls.Add(this.lblArea);
            this.gpbEnderecamento.Controls.Add(this.lblCorredor);
            this.gpbEnderecamento.Location = new System.Drawing.Point(585, 249);
            this.gpbEnderecamento.Margin = new System.Windows.Forms.Padding(4);
            this.gpbEnderecamento.Name = "gpbEnderecamento";
            this.gpbEnderecamento.Padding = new System.Windows.Forms.Padding(4);
            this.gpbEnderecamento.Size = new System.Drawing.Size(1001, 185);
            this.gpbEnderecamento.TabIndex = 2;
            this.gpbEnderecamento.TabStop = false;
            this.gpbEnderecamento.Text = "Endereçamento";
            // 
            // txtEndereco_Prod
            // 
            this.txtEndereco_Prod.Location = new System.Drawing.Point(792, 70);
            this.txtEndereco_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco_Prod.Name = "txtEndereco_Prod";
            this.txtEndereco_Prod.Size = new System.Drawing.Size(141, 22);
            this.txtEndereco_Prod.TabIndex = 19;
            this.txtEndereco_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_Prod_KeyPress);
            // 
            // lblEnderecoProduto
            // 
            this.lblEnderecoProduto.AutoSize = true;
            this.lblEnderecoProduto.Location = new System.Drawing.Point(788, 38);
            this.lblEnderecoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoProduto.Name = "lblEnderecoProduto";
            this.lblEnderecoProduto.Size = new System.Drawing.Size(146, 17);
            this.lblEnderecoProduto.TabIndex = 18;
            this.lblEnderecoProduto.Text = "Endereço do produto:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(623, 38);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(43, 17);
            this.lblNivel.TabIndex = 17;
            this.lblNivel.Text = "Nível:";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(468, 38);
            this.lblModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(58, 17);
            this.lblModulo.TabIndex = 16;
            this.lblModulo.Text = "Módulo:";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(627, 70);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(135, 22);
            this.txtNivel.TabIndex = 18;
            this.txtNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivel_KeyPress);
            // 
            // txtArea_Prod
            // 
            this.txtArea_Prod.Location = new System.Drawing.Point(8, 70);
            this.txtArea_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea_Prod.Name = "txtArea_Prod";
            this.txtArea_Prod.Size = new System.Drawing.Size(128, 22);
            this.txtArea_Prod.TabIndex = 14;
            this.txtArea_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_Prod_KeyPress);
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(472, 70);
            this.txtModulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(128, 22);
            this.txtModulo.TabIndex = 17;
            this.txtModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModulo_KeyPress);
            // 
            // txtVao
            // 
            this.txtVao.Location = new System.Drawing.Point(304, 70);
            this.txtVao.Margin = new System.Windows.Forms.Padding(4);
            this.txtVao.Name = "txtVao";
            this.txtVao.Size = new System.Drawing.Size(128, 22);
            this.txtVao.TabIndex = 16;
            this.txtVao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVao_KeyPress);
            // 
            // lblVao
            // 
            this.lblVao.AutoSize = true;
            this.lblVao.Location = new System.Drawing.Point(300, 36);
            this.lblVao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVao.Name = "lblVao";
            this.lblVao.Size = new System.Drawing.Size(37, 17);
            this.lblVao.TabIndex = 12;
            this.lblVao.Text = "Vão:";
            // 
            // txtCorredor
            // 
            this.txtCorredor.Location = new System.Drawing.Point(153, 70);
            this.txtCorredor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorredor.Name = "txtCorredor";
            this.txtCorredor.Size = new System.Drawing.Size(121, 22);
            this.txtCorredor.TabIndex = 15;
            this.txtCorredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorredor_KeyPress);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(11, 36);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Área:";
            // 
            // lblCorredor
            // 
            this.lblCorredor.AutoSize = true;
            this.lblCorredor.Location = new System.Drawing.Point(149, 37);
            this.lblCorredor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorredor.Name = "lblCorredor";
            this.lblCorredor.Size = new System.Drawing.Size(72, 17);
            this.lblCorredor.TabIndex = 10;
            this.lblCorredor.Text = "Corredor: ";
            // 
            // gpbDimensoes
            // 
            this.gpbDimensoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDimensoes.Controls.Add(this.txtVolume_Prod);
            this.gpbDimensoes.Controls.Add(this.txtPeso_Prod);
            this.gpbDimensoes.Controls.Add(this.txtComprimento_Prod);
            this.gpbDimensoes.Controls.Add(this.txtLargura_Prod);
            this.gpbDimensoes.Controls.Add(this.txtAltura_Prod);
            this.gpbDimensoes.Controls.Add(this.lblPesoBruto);
            this.gpbDimensoes.Controls.Add(this.lblVolume);
            this.gpbDimensoes.Controls.Add(this.lblComprimento);
            this.gpbDimensoes.Controls.Add(this.lblLargura);
            this.gpbDimensoes.Controls.Add(this.lblAltura);
            this.gpbDimensoes.Location = new System.Drawing.Point(37, 249);
            this.gpbDimensoes.Margin = new System.Windows.Forms.Padding(4);
            this.gpbDimensoes.Name = "gpbDimensoes";
            this.gpbDimensoes.Padding = new System.Windows.Forms.Padding(4);
            this.gpbDimensoes.Size = new System.Drawing.Size(536, 185);
            this.gpbDimensoes.TabIndex = 1;
            this.gpbDimensoes.TabStop = false;
            this.gpbDimensoes.Text = "Dimensões do produto";
            // 
            // txtVolume_Prod
            // 
            this.txtVolume_Prod.Location = new System.Drawing.Point(360, 58);
            this.txtVolume_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolume_Prod.Name = "txtVolume_Prod";
            this.txtVolume_Prod.Size = new System.Drawing.Size(97, 22);
            this.txtVolume_Prod.TabIndex = 12;
            this.txtVolume_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_Prod_KeyPress);
            // 
            // txtPeso_Prod
            // 
            this.txtPeso_Prod.Location = new System.Drawing.Point(11, 123);
            this.txtPeso_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso_Prod.Name = "txtPeso_Prod";
            this.txtPeso_Prod.Size = new System.Drawing.Size(99, 22);
            this.txtPeso_Prod.TabIndex = 13;
            this.txtPeso_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_Prod_KeyPress);
            // 
            // txtComprimento_Prod
            // 
            this.txtComprimento_Prod.Location = new System.Drawing.Point(243, 58);
            this.txtComprimento_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtComprimento_Prod.Name = "txtComprimento_Prod";
            this.txtComprimento_Prod.Size = new System.Drawing.Size(97, 22);
            this.txtComprimento_Prod.TabIndex = 11;
            this.txtComprimento_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComprimento_Prod_KeyPress);
            // 
            // txtLargura_Prod
            // 
            this.txtLargura_Prod.Location = new System.Drawing.Point(129, 58);
            this.txtLargura_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtLargura_Prod.Name = "txtLargura_Prod";
            this.txtLargura_Prod.Size = new System.Drawing.Size(97, 22);
            this.txtLargura_Prod.TabIndex = 10;
            this.txtLargura_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargura_Prod_KeyPress);
            // 
            // txtAltura_Prod
            // 
            this.txtAltura_Prod.Location = new System.Drawing.Point(12, 58);
            this.txtAltura_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura_Prod.Name = "txtAltura_Prod";
            this.txtAltura_Prod.Size = new System.Drawing.Size(97, 22);
            this.txtAltura_Prod.TabIndex = 9;
            this.txtAltura_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_Prod_KeyPress);
            // 
            // lblPesoBruto
            // 
            this.lblPesoBruto.AutoSize = true;
            this.lblPesoBruto.Location = new System.Drawing.Point(8, 90);
            this.lblPesoBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesoBruto.Name = "lblPesoBruto";
            this.lblPesoBruto.Size = new System.Drawing.Size(107, 17);
            this.lblPesoBruto.TabIndex = 14;
            this.lblPesoBruto.Text = "Peso Bruto(kg):";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(368, 25);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(92, 17);
            this.lblVolume.TabIndex = 13;
            this.lblVolume.Text = "Volume(cm³):";
            // 
            // lblComprimento
            // 
            this.lblComprimento.AutoSize = true;
            this.lblComprimento.Location = new System.Drawing.Point(239, 25);
            this.lblComprimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComprimento.Name = "lblComprimento";
            this.lblComprimento.Size = new System.Drawing.Size(123, 17);
            this.lblComprimento.TabIndex = 12;
            this.lblComprimento.Text = "Comprimento(cm):";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(125, 25);
            this.lblLargura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(90, 17);
            this.lblLargura.TabIndex = 11;
            this.lblLargura.Text = "Largura(cm):";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(8, 25);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(77, 17);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Altura(cm):";
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbInformacoes.Controls.Add(this.txtID_Endereco);
            this.gpbInformacoes.Controls.Add(this.lblCodigo);
            this.gpbInformacoes.Controls.Add(this.txtStatus);
            this.gpbInformacoes.Controls.Add(this.lblStatus);
            this.gpbInformacoes.Controls.Add(this.txtLote);
            this.gpbInformacoes.Controls.Add(this.txtQuantidade);
            this.gpbInformacoes.Controls.Add(this.txtFornecedor);
            this.gpbInformacoes.Controls.Add(this.lblLote);
            this.gpbInformacoes.Controls.Add(this.lblQuantidade);
            this.gpbInformacoes.Controls.Add(this.lblID_fornecedor);
            this.gpbInformacoes.Controls.Add(this.lblEan);
            this.gpbInformacoes.Controls.Add(this.lblCodigoProduto);
            this.gpbInformacoes.Controls.Add(this.txtCodigo_Ean);
            this.gpbInformacoes.Controls.Add(this.txtCodigo_Prod);
            this.gpbInformacoes.Controls.Add(this.txtNome_Prod);
            this.gpbInformacoes.Controls.Add(this.lblNomeProduto);
            this.gpbInformacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gpbInformacoes.Location = new System.Drawing.Point(37, 135);
            this.gpbInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Padding = new System.Windows.Forms.Padding(4);
            this.gpbInformacoes.Size = new System.Drawing.Size(1549, 103);
            this.gpbInformacoes.TabIndex = 0;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações do produto";
            // 
            // txtID_Endereco
            // 
            this.txtID_Endereco.Location = new System.Drawing.Point(8, 57);
            this.txtID_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtID_Endereco.Name = "txtID_Endereco";
            this.txtID_Endereco.Size = new System.Drawing.Size(148, 27);
            this.txtID_Endereco.TabIndex = 1;
            this.txtID_Endereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Endereco_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 23);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(126, 20);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código de busca:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1280, 57);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(148, 27);
            this.txtStatus.TabIndex = 8;
            this.txtStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStatus_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1276, 23);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 20);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(1097, 57);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(148, 27);
            this.txtLote.TabIndex = 7;
            this.txtLote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLote_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(911, 57);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(148, 27);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(724, 57);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(148, 27);
            this.txtFornecedor.TabIndex = 5;
            this.txtFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFornecedor_KeyPress);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(1093, 23);
            this.lblLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(42, 20);
            this.lblLote.TabIndex = 8;
            this.lblLote.Text = "Lote:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(907, 23);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(93, 20);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblID_fornecedor
            // 
            this.lblID_fornecedor.AutoSize = true;
            this.lblID_fornecedor.Location = new System.Drawing.Point(720, 23);
            this.lblID_fornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID_fornecedor.Name = "lblID_fornecedor";
            this.lblID_fornecedor.Size = new System.Drawing.Size(131, 20);
            this.lblID_fornecedor.TabIndex = 6;
            this.lblID_fornecedor.Text = "ID do fornecedor:";
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Location = new System.Drawing.Point(544, 23);
            this.lblEan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(43, 20);
            this.lblEan.TabIndex = 5;
            this.lblEan.Text = "EAN:";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(368, 23);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(144, 20);
            this.lblCodigoProduto.TabIndex = 4;
            this.lblCodigoProduto.Text = "Código do produto:";
            // 
            // txtCodigo_Ean
            // 
            this.txtCodigo_Ean.Location = new System.Drawing.Point(548, 57);
            this.txtCodigo_Ean.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo_Ean.Name = "txtCodigo_Ean";
            this.txtCodigo_Ean.Size = new System.Drawing.Size(148, 27);
            this.txtCodigo_Ean.TabIndex = 4;
            this.txtCodigo_Ean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_Ean_KeyPress);
            // 
            // txtCodigo_Prod
            // 
            this.txtCodigo_Prod.Location = new System.Drawing.Point(372, 57);
            this.txtCodigo_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo_Prod.Name = "txtCodigo_Prod";
            this.txtCodigo_Prod.Size = new System.Drawing.Size(148, 27);
            this.txtCodigo_Prod.TabIndex = 3;
            this.txtCodigo_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_Prod_KeyPress);
            // 
            // txtNome_Prod
            // 
            this.txtNome_Prod.Location = new System.Drawing.Point(192, 57);
            this.txtNome_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome_Prod.Name = "txtNome_Prod";
            this.txtNome_Prod.Size = new System.Drawing.Size(148, 27);
            this.txtNome_Prod.TabIndex = 2;
            this.txtNome_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_Prod_KeyPress);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(188, 23);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(137, 20);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome do produto:";
            // 
            // tipDicas
            // 
            this.tipDicas.IsBalloon = true;
            // 
            // btnRelatorioMensal
            // 
            this.btnRelatorioMensal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRelatorioMensal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRelatorioMensal.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRelatorioMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioMensal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioMensal.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorioMensal.Image")));
            this.btnRelatorioMensal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioMensal.Location = new System.Drawing.Point(789, 778);
            this.btnRelatorioMensal.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorioMensal.Name = "btnRelatorioMensal";
            this.btnRelatorioMensal.Size = new System.Drawing.Size(360, 39);
            this.btnRelatorioMensal.TabIndex = 22;
            this.btnRelatorioMensal.Text = "  Gerar relatório mensal";
            this.tipDicas.SetToolTip(this.btnRelatorioMensal, "Clique para gerar o relatório mensal.");
            this.btnRelatorioMensal.UseVisualStyleBackColor = false;
            this.btnRelatorioMensal.Click += new System.EventHandler(this.btnRelatorioMensal_Click);
            // 
            // btnBalancoInventario
            // 
            this.btnBalancoInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBalancoInventario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBalancoInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBalancoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalancoInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalancoInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnBalancoInventario.Image")));
            this.btnBalancoInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalancoInventario.Location = new System.Drawing.Point(37, 778);
            this.btnBalancoInventario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBalancoInventario.Name = "btnBalancoInventario";
            this.btnBalancoInventario.Size = new System.Drawing.Size(360, 39);
            this.btnBalancoInventario.TabIndex = 21;
            this.btnBalancoInventario.Text = "     Realizar Balanço de Inventário";
            this.tipDicas.SetToolTip(this.btnBalancoInventario, "Clique para realizar o balanço de inventário.");
            this.btnBalancoInventario.UseVisualStyleBackColor = false;
            this.btnBalancoInventario.Click += new System.EventHandler(this.btnBalancoInventario_Click);
            // 
            // btnVisualizarMapa
            // 
            this.btnVisualizarMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisualizarMapa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVisualizarMapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVisualizarMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarMapa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarMapa.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarMapa.Image")));
            this.btnVisualizarMapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarMapa.Location = new System.Drawing.Point(413, 778);
            this.btnVisualizarMapa.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizarMapa.Name = "btnVisualizarMapa";
            this.btnVisualizarMapa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVisualizarMapa.Size = new System.Drawing.Size(360, 39);
            this.btnVisualizarMapa.TabIndex = 290;
            this.btnVisualizarMapa.Text = "   Visualizar mapa do armazém";
            this.tipDicas.SetToolTip(this.btnVisualizarMapa, "Clique para visualizar o mapa do armazém.");
            this.btnVisualizarMapa.UseVisualStyleBackColor = false;
            this.btnVisualizarMapa.Click += new System.EventHandler(this.btnVisualizarMapa_Click);
            // 
            // lblFatecWMS
            // 
            this.lblFatecWMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFatecWMS.AutoSize = true;
            this.lblFatecWMS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFatecWMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatecWMS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFatecWMS.Location = new System.Drawing.Point(757, 57);
            this.lblFatecWMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFatecWMS.Name = "lblFatecWMS";
            this.lblFatecWMS.Size = new System.Drawing.Size(177, 20);
            this.lblFatecWMS.TabIndex = 46;
            this.lblFatecWMS.Text = "FATEC Warehouse System";
            // 
            // lbNomeUsuarioPrincipal
            // 
            this.lbNomeUsuarioPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeUsuarioPrincipal.AutoSize = true;
            this.lbNomeUsuarioPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNomeUsuarioPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbNomeUsuarioPrincipal.Location = new System.Drawing.Point(1453, 86);
            this.lbNomeUsuarioPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeUsuarioPrincipal.Name = "lbNomeUsuarioPrincipal";
            this.lbNomeUsuarioPrincipal.Size = new System.Drawing.Size(36, 20);
            this.lbNomeUsuarioPrincipal.TabIndex = 292;
            this.lbNomeUsuarioPrincipal.Text = "000";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(125, 39);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(253, 74);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 47;
            this.picLogo.TabStop = false;
            // 
            // picCabecalho
            // 
            this.picCabecalho.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.picCabecalho.Location = new System.Drawing.Point(0, 28);
            this.picCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.picCabecalho.Name = "picCabecalho";
            this.picCabecalho.Size = new System.Drawing.Size(1683, 98);
            this.picCabecalho.TabIndex = 3;
            this.picCabecalho.TabStop = false;
            // 
            // frminterfaceWMS_Armazem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.lbNomeUsuarioPrincipal);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblFatecWMS);
            this.Controls.Add(this.gpbControles);
            this.Controls.Add(this.btnRelatorioMensal);
            this.Controls.Add(this.btnBalancoInventario);
            this.Controls.Add(this.btnVisualizarMapa);
            this.Controls.Add(this.lblDataeHora);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.gpbEnderecamento);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.gpbConsulta);
            this.Controls.Add(this.gpbDimensoes);
            this.Controls.Add(this.picCabecalho);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.msOpcoes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "frminterfaceWMS_Armazem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faws - Armazenagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frminterfaceWMS_Armazem_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frminterfaceWMS_Armazem_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frminterfaceWMS_Armazem_FormClosed);
            this.Load += new System.EventHandler(this.frminterfaceWMS_Armazem_Load);
            this.msOpcoes.ResumeLayout(false);
            this.msOpcoes.PerformLayout();
            this.gpbControles.ResumeLayout(false);
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdArmazem)).EndInit();
            this.gpbEnderecamento.ResumeLayout(false);
            this.gpbEnderecamento.PerformLayout();
            this.gpbDimensoes.ResumeLayout(false);
            this.gpbDimensoes.PerformLayout();
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.MenuStrip msOpcoes;
        private System.Windows.Forms.ToolStripMenuItem tmsiSistemaPRINC;
        private System.Windows.Forms.ToolStripMenuItem tmsiOptionSairPRINC;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tmsioptionPreferenciasPRNC;
        private System.Windows.Forms.ToolStripMenuItem tmsiUsuarioPRINC;
        private System.Windows.Forms.ToolStripMenuItem tmsioptionVerMatriculaPRINC;
        private System.Windows.Forms.ToolStripMenuItem tmsioptionPermissoesPRINC;
        private System.Windows.Forms.ToolStripMenuItem tmsiAjudaPRINC;
        private System.Windows.Forms.ToolStripMenuItem tmsioptionManualPRINC;
        private System.Windows.Forms.PictureBox picCabecalho;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Label lblDataeHora;
        private System.Windows.Forms.GroupBox gpbControles;
        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.Label lblConsultaProdutos;
        private System.Windows.Forms.GroupBox gpbEnderecamento;
        private System.Windows.Forms.Label lblEnderecoProduto;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblVao;
        private System.Windows.Forms.Label lblCorredor;
        private System.Windows.Forms.GroupBox gpbDimensoes;
        private System.Windows.Forms.Label lblPesoBruto;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblComprimento;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblID_fornecedor;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.DataGridView DtGrdArmazem;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolTip tipDicas;
        private System.Windows.Forms.Label lblFatecWMS;
        private System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.TextBox txtID_Endereco;
        public System.Windows.Forms.Button btnVisualizarMapa;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnAdicionarNovo;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtConsulta_Prod;
        public System.Windows.Forms.TextBox txtNivel;
        public System.Windows.Forms.TextBox txtModulo;
        public System.Windows.Forms.TextBox txtVao;
        public System.Windows.Forms.TextBox txtCorredor;
        public System.Windows.Forms.TextBox txtPeso_Prod;
        public System.Windows.Forms.TextBox txtComprimento_Prod;
        public System.Windows.Forms.TextBox txtLargura_Prod;
        public System.Windows.Forms.TextBox txtAltura_Prod;
        public System.Windows.Forms.TextBox txtArea_Prod;
        public System.Windows.Forms.TextBox txtStatus;
        public System.Windows.Forms.TextBox txtLote;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtFornecedor;
        public System.Windows.Forms.TextBox txtCodigo_Ean;
        public System.Windows.Forms.TextBox txtCodigo_Prod;
        public System.Windows.Forms.TextBox txtNome_Prod;
        public System.Windows.Forms.TextBox txtVolume_Prod;
        public System.Windows.Forms.TextBox txtEndereco_Prod;
        public System.Windows.Forms.Button btnRelatorioMensal;
        public System.Windows.Forms.Button btnBalancoInventario;
        public System.Windows.Forms.Button btnMostrarDados;
        private System.Windows.Forms.Label lbNomeUsuarioPrincipal;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
    }
}

