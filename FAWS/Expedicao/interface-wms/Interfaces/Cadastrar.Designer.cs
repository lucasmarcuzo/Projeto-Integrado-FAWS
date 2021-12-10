
namespace interface_wms
{
    partial class frmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrar));
            this.picCabecalho = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPickingList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLiberarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.picRodape = new System.Windows.Forms.PictureBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnLiberarPickingList = new System.Windows.Forms.Button();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblDescricaoPedido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.grpInformacoesPedido = new System.Windows.Forms.GroupBox();
            this.txtLote = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigoPedido = new System.Windows.Forms.MaskedTextBox();
            this.cboPrioridade = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricaoPedido = new System.Windows.Forms.TextBox();
            this.cboTipoPedido = new System.Windows.Forms.ComboBox();
            this.cboStatusPedido = new System.Windows.Forms.ComboBox();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblStatusPedido = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvConsultarPedidos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grpConsultarPedidos = new System.Windows.Forms.GroupBox();
            this.txtCodigoPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDigiteCodigoPedido = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRodape)).BeginInit();
            this.grpInformacoesPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarPedidos)).BeginInit();
            this.grpConsultarPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picCabecalho
            // 
            this.picCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCabecalho.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCabecalho.Location = new System.Drawing.Point(0, 27);
            this.picCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.picCabecalho.Name = "picCabecalho";
            this.picCabecalho.Size = new System.Drawing.Size(1685, 98);
            this.picCabecalho.TabIndex = 0;
            this.picCabecalho.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastrarPedido,
            this.tsmiPickingList,
            this.tsmiEstoque,
            this.tsmiLiberarPedido,
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1683, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // tsmiCadastrarPedido
            // 
            this.tsmiCadastrarPedido.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiCadastrarPedido.Name = "tsmiCadastrarPedido";
            this.tsmiCadastrarPedido.Size = new System.Drawing.Size(136, 24);
            this.tsmiCadastrarPedido.Text = "Cadastrar Pedido";
            // 
            // tsmiPickingList
            // 
            this.tsmiPickingList.Name = "tsmiPickingList";
            this.tsmiPickingList.Size = new System.Drawing.Size(96, 24);
            this.tsmiPickingList.Text = "Picking List";
            this.tsmiPickingList.Click += new System.EventHandler(this.tsmiPickingList_Click);
            // 
            // tsmiEstoque
            // 
            this.tsmiEstoque.Name = "tsmiEstoque";
            this.tsmiEstoque.Size = new System.Drawing.Size(76, 24);
            this.tsmiEstoque.Text = "Estoque";
            this.tsmiEstoque.Click += new System.EventHandler(this.tsmiEstoque_Click);
            // 
            // tsmiLiberarPedido
            // 
            this.tsmiLiberarPedido.Name = "tsmiLiberarPedido";
            this.tsmiLiberarPedido.Size = new System.Drawing.Size(119, 24);
            this.tsmiLiberarPedido.Text = "Liberar Pedido";
            this.tsmiLiberarPedido.Click += new System.EventHandler(this.tsmiLiberarPedido_Click);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferênciasToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.arquivoToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.sistema;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.arquivoToolStripMenuItem.Text = "Sistema";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.sair;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.optionToolStripMenuItem.Text = "Sair";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.preferencias;
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem1,
            this.permissõesToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.editarToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.usuario;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.editarToolStripMenuItem.Text = "Usuário";
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.Image = global::Interface_WMS_Expedicao.Properties.Resources.identificação;
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.optionToolStripMenuItem1.Text = "Ver matrícula";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.permissão;
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem2,
            this.suporteToolStripMenuItem});
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exibirToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.ajuda1;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.exibirToolStripMenuItem.Text = "Ajuda";
            // 
            // optionToolStripMenuItem2
            // 
            this.optionToolStripMenuItem2.Image = global::Interface_WMS_Expedicao.Properties.Resources.Manual;
            this.optionToolStripMenuItem2.Name = "optionToolStripMenuItem2";
            this.optionToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.optionToolStripMenuItem2.Size = new System.Drawing.Size(208, 26);
            this.optionToolStripMenuItem2.Text = "Manual";
            this.optionToolStripMenuItem2.Click += new System.EventHandler(this.optionToolStripMenuItem2_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.suporte;
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(760, 78);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(173, 28);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "19/05/2021, 00:00";
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNameCompany.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.Location = new System.Drawing.Point(1356, 49);
            this.lblNameCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(158, 32);
            this.lblNameCompany.TabIndex = 6;
            this.lblNameCompany.Text = "Rapid Express";
            // 
            // lblNomeSistema
            // 
            this.lblNomeSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNomeSistema.AutoSize = true;
            this.lblNomeSistema.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeSistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSistema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeSistema.Location = new System.Drawing.Point(757, 57);
            this.lblNomeSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new System.Drawing.Size(177, 20);
            this.lblNomeSistema.TabIndex = 7;
            this.lblNomeSistema.Text = "FATEC Warehouse System";
            // 
            // picRodape
            // 
            this.picRodape.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picRodape.Location = new System.Drawing.Point(0, 755);
            this.picRodape.Margin = new System.Windows.Forms.Padding(4);
            this.picRodape.Name = "picRodape";
            this.picRodape.Size = new System.Drawing.Size(1683, 73);
            this.picRodape.TabIndex = 12;
            this.picRodape.TabStop = false;
            // 
            // lblMatricula
            // 
            this.lblMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(1371, 86);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(67, 20);
            this.lblMatricula.TabIndex = 22;
            this.lblMatricula.Text = "Usuário:";
            // 
            // btnLiberarPickingList
            // 
            this.btnLiberarPickingList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiberarPickingList.BackColor = System.Drawing.SystemColors.Window;
            this.btnLiberarPickingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiberarPickingList.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLiberarPickingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberarPickingList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberarPickingList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLiberarPickingList.Location = new System.Drawing.Point(1188, 20);
            this.btnLiberarPickingList.Margin = new System.Windows.Forms.Padding(4);
            this.btnLiberarPickingList.Name = "btnLiberarPickingList";
            this.btnLiberarPickingList.Size = new System.Drawing.Size(236, 38);
            this.btnLiberarPickingList.TabIndex = 17;
            this.btnLiberarPickingList.Text = "LIBERAR PARA O PICKING LIST";
            this.btnLiberarPickingList.UseVisualStyleBackColor = false;
            this.btnLiberarPickingList.Click += new System.EventHandler(this.btnLiberarParaPickingList_Click);
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPedido.Location = new System.Drawing.Point(51, 64);
            this.lblCodigoPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(124, 19);
            this.lblCodigoPedido.TabIndex = 0;
            this.lblCodigoPedido.Text = "Código do pedido:";
            // 
            // lblDescricaoPedido
            // 
            this.lblDescricaoPedido.AutoSize = true;
            this.lblDescricaoPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoPedido.Location = new System.Drawing.Point(716, 42);
            this.lblDescricaoPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoPedido.Name = "lblDescricaoPedido";
            this.lblDescricaoPedido.Size = new System.Drawing.Size(203, 28);
            this.lblDescricaoPedido.TabIndex = 2;
            this.lblDescricaoPedido.Text = "Descrição do pedido:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(896, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Liberar para o faturamento";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(260, 66);
            this.lblCodigoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(123, 19);
            this.lblCodigoCliente.TabIndex = 27;
            this.lblCodigoCliente.Text = "Código do cliente:";
            // 
            // grpInformacoesPedido
            // 
            this.grpInformacoesPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInformacoesPedido.Controls.Add(this.txtLote);
            this.grpInformacoesPedido.Controls.Add(this.dtpDataEmissao);
            this.grpInformacoesPedido.Controls.Add(this.dtpDataEntrega);
            this.grpInformacoesPedido.Controls.Add(this.btnSalvar);
            this.grpInformacoesPedido.Controls.Add(this.txtCodigoPedido);
            this.grpInformacoesPedido.Controls.Add(this.cboPrioridade);
            this.grpInformacoesPedido.Controls.Add(this.txtQuantidade);
            this.grpInformacoesPedido.Controls.Add(this.lblCodigoProduto);
            this.grpInformacoesPedido.Controls.Add(this.txtCodigoProduto);
            this.grpInformacoesPedido.Controls.Add(this.txtCodigoCliente);
            this.grpInformacoesPedido.Controls.Add(this.txtDescricaoPedido);
            this.grpInformacoesPedido.Controls.Add(this.cboTipoPedido);
            this.grpInformacoesPedido.Controls.Add(this.cboStatusPedido);
            this.grpInformacoesPedido.Controls.Add(this.lblTipoPedido);
            this.grpInformacoesPedido.Controls.Add(this.lblDataEntrega);
            this.grpInformacoesPedido.Controls.Add(this.lblPrioridade);
            this.grpInformacoesPedido.Controls.Add(this.lblDataEmissao);
            this.grpInformacoesPedido.Controls.Add(this.lblLote);
            this.grpInformacoesPedido.Controls.Add(this.lblStatusPedido);
            this.grpInformacoesPedido.Controls.Add(this.lblQuantidade);
            this.grpInformacoesPedido.Controls.Add(this.lblCodigoCliente);
            this.grpInformacoesPedido.Controls.Add(this.button1);
            this.grpInformacoesPedido.Controls.Add(this.lblDescricaoPedido);
            this.grpInformacoesPedido.Controls.Add(this.lblCodigoPedido);
            this.grpInformacoesPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInformacoesPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacoesPedido.Location = new System.Drawing.Point(63, 156);
            this.grpInformacoesPedido.Margin = new System.Windows.Forms.Padding(4);
            this.grpInformacoesPedido.Name = "grpInformacoesPedido";
            this.grpInformacoesPedido.Padding = new System.Windows.Forms.Padding(4);
            this.grpInformacoesPedido.Size = new System.Drawing.Size(1452, 234);
            this.grpInformacoesPedido.TabIndex = 27;
            this.grpInformacoesPedido.TabStop = false;
            this.grpInformacoesPedido.Text = "Informações do Pedido";
            // 
            // txtLote
            // 
            this.txtLote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(101, 140);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtLote.Mask = "00000";
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(177, 27);
            this.txtLote.TabIndex = 48;
            this.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDataEmissao.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEmissao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEmissao.Location = new System.Drawing.Point(480, 140);
            this.dtpDataEmissao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(125, 27);
            this.dtpDataEmissao.TabIndex = 47;
            this.dtpDataEmissao.Value = new System.DateTime(2021, 11, 12, 23, 0, 19, 0);
            this.dtpDataEmissao.CloseUp += new System.EventHandler(this.dtpDataEmissao_ValueChanged);
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDataEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntrega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntrega.Location = new System.Drawing.Point(787, 140);
            this.dtpDataEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(125, 27);
            this.dtpDataEntrega.TabIndex = 46;
            this.dtpDataEntrega.Value = new System.DateTime(2021, 11, 12, 23, 0, 11, 0);
            this.dtpDataEntrega.CloseUp += new System.EventHandler(this.dtpDataEntrega_ValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalvar.Image = global::Interface_WMS_Expedicao.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(1328, 190);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 38);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtCodigoPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCodigoPedido.Location = new System.Drawing.Point(55, 85);
            this.txtCodigoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPedido.Mask = "00000";
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(178, 27);
            this.txtCodigoPedido.TabIndex = 1;
            this.txtCodigoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoPedido.ValidatingType = typeof(int);
            // 
            // cboPrioridade
            // 
            this.cboPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrioridade.FormattingEnabled = true;
            this.cboPrioridade.Items.AddRange(new object[] {
            "RÁPIDO",
            "NORMAL",
            "ENTREGA PRIORITÁRIA"});
            this.cboPrioridade.Location = new System.Drawing.Point(877, 188);
            this.cboPrioridade.Margin = new System.Windows.Forms.Padding(4);
            this.cboPrioridade.Name = "cboPrioridade";
            this.cboPrioridade.Size = new System.Drawing.Size(248, 28);
            this.cboPrioridade.TabIndex = 11;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(651, 190);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Mask = "00000";
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(117, 27);
            this.txtQuantidade.TabIndex = 10;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.Location = new System.Drawing.Point(485, 66);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(131, 19);
            this.lblCodigoProduto.TabIndex = 45;
            this.lblCodigoProduto.Text = "Código do produto:";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(489, 86);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProduto.Mask = "00000";
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(177, 27);
            this.txtCodigoProduto.TabIndex = 3;
            this.txtCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(264, 86);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCliente.Mask = "00000";
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(177, 27);
            this.txtCodigoCliente.TabIndex = 2;
            this.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricaoPedido
            // 
            this.txtDescricaoPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoPedido.Location = new System.Drawing.Point(721, 73);
            this.txtDescricaoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoPedido.Multiline = true;
            this.txtDescricaoPedido.Name = "txtDescricaoPedido";
            this.txtDescricaoPedido.Size = new System.Drawing.Size(637, 41);
            this.txtDescricaoPedido.TabIndex = 4;
            // 
            // cboTipoPedido
            // 
            this.cboTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPedido.FormattingEnabled = true;
            this.cboTipoPedido.Items.AddRange(new object[] {
            "COMERCIAL",
            "PESSOA FÍSICA"});
            this.cboTipoPedido.Location = new System.Drawing.Point(1112, 143);
            this.cboTipoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoPedido.Name = "cboTipoPedido";
            this.cboTipoPedido.Size = new System.Drawing.Size(248, 28);
            this.cboTipoPedido.TabIndex = 8;
            // 
            // cboStatusPedido
            // 
            this.cboStatusPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusPedido.FormattingEnabled = true;
            this.cboStatusPedido.Items.AddRange(new object[] {
            "ATIVO",
            "LIBERADO PARA O PICKING",
            "PEDIDO FATURADO",
            "LIBERADO PARA ENVIO",
            "FINALIZADO"});
            this.cboStatusPedido.Location = new System.Drawing.Point(193, 188);
            this.cboStatusPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatusPedido.Name = "cboStatusPedido";
            this.cboStatusPedido.Size = new System.Drawing.Size(321, 28);
            this.cboStatusPedido.TabIndex = 9;
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPedido.Location = new System.Drawing.Point(988, 148);
            this.lblTipoPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(106, 19);
            this.lblTipoPedido.TabIndex = 39;
            this.lblTipoPedido.Text = "Tipo de Pedido:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrega.Location = new System.Drawing.Point(653, 148);
            this.lblDataEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(111, 19);
            this.lblDataEntrega.TabIndex = 37;
            this.lblDataEntrega.Text = "Data de Entrega:";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.Location = new System.Drawing.Point(785, 193);
            this.lblPrioridade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(76, 19);
            this.lblPrioridade.TabIndex = 36;
            this.lblPrioridade.Text = "Prioridade:";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmissao.Location = new System.Drawing.Point(347, 148);
            this.lblDataEmissao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(114, 19);
            this.lblDataEmissao.TabIndex = 34;
            this.lblDataEmissao.Text = "Data de Emissão:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(51, 145);
            this.lblLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(39, 19);
            this.lblLote.TabIndex = 32;
            this.lblLote.Text = "Lote:";
            // 
            // lblStatusPedido
            // 
            this.lblStatusPedido.AutoSize = true;
            this.lblStatusPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPedido.Location = new System.Drawing.Point(51, 193);
            this.lblStatusPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusPedido.Name = "lblStatusPedido";
            this.lblStatusPedido.Size = new System.Drawing.Size(118, 19);
            this.lblStatusPedido.TabIndex = 31;
            this.lblStatusPedido.Text = "Status do Pedido:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(551, 193);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(85, 19);
            this.lblQuantidade.TabIndex = 29;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // dgvConsultarPedidos
            // 
            this.dgvConsultarPedidos.AllowUserToAddRows = false;
            this.dgvConsultarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.cod_pedido,
            this.cod_cliente,
            this.cod_produto,
            this.data_emissao,
            this.data_entrega,
            this.quantidade,
            this.status_pedido,
            this.descricao_pedido,
            this.lote,
            this.prioridade,
            this.tipo_pedido});
            this.dgvConsultarPedidos.Location = new System.Drawing.Point(24, 65);
            this.dgvConsultarPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultarPedidos.MultiSelect = false;
            this.dgvConsultarPedidos.Name = "dgvConsultarPedidos";
            this.dgvConsultarPedidos.ReadOnly = true;
            this.dgvConsultarPedidos.RowHeadersWidth = 51;
            this.dgvConsultarPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarPedidos.Size = new System.Drawing.Size(1400, 246);
            this.dgvConsultarPedidos.TabIndex = 34;
            this.dgvConsultarPedidos.TabStop = false;
            this.dgvConsultarPedidos.DoubleClick += new System.EventHandler(this.btnEditar_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "*";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // cod_pedido
            // 
            this.cod_pedido.HeaderText = "Código do pedido";
            this.cod_pedido.MinimumWidth = 6;
            this.cod_pedido.Name = "cod_pedido";
            this.cod_pedido.ReadOnly = true;
            this.cod_pedido.Width = 125;
            // 
            // cod_cliente
            // 
            this.cod_cliente.HeaderText = "Código do cliente";
            this.cod_cliente.MinimumWidth = 6;
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            this.cod_cliente.Width = 125;
            // 
            // cod_produto
            // 
            this.cod_produto.HeaderText = "Código do produto";
            this.cod_produto.MinimumWidth = 6;
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.ReadOnly = true;
            this.cod_produto.Width = 125;
            // 
            // data_emissao
            // 
            this.data_emissao.HeaderText = "Data de emissão";
            this.data_emissao.MinimumWidth = 6;
            this.data_emissao.Name = "data_emissao";
            this.data_emissao.ReadOnly = true;
            this.data_emissao.Width = 125;
            // 
            // data_entrega
            // 
            this.data_entrega.HeaderText = "Data de entrega";
            this.data_entrega.MinimumWidth = 6;
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.ReadOnly = true;
            this.data_entrega.Width = 125;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MinimumWidth = 6;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 125;
            // 
            // status_pedido
            // 
            this.status_pedido.HeaderText = "Status do pedido";
            this.status_pedido.MinimumWidth = 6;
            this.status_pedido.Name = "status_pedido";
            this.status_pedido.ReadOnly = true;
            this.status_pedido.Width = 125;
            // 
            // descricao_pedido
            // 
            this.descricao_pedido.HeaderText = "Descrição do pedido";
            this.descricao_pedido.MinimumWidth = 6;
            this.descricao_pedido.Name = "descricao_pedido";
            this.descricao_pedido.ReadOnly = true;
            this.descricao_pedido.Width = 125;
            // 
            // lote
            // 
            this.lote.HeaderText = "Lote";
            this.lote.MinimumWidth = 6;
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            this.lote.Width = 125;
            // 
            // prioridade
            // 
            this.prioridade.HeaderText = "Prioridade";
            this.prioridade.MinimumWidth = 6;
            this.prioridade.Name = "prioridade";
            this.prioridade.ReadOnly = true;
            this.prioridade.Width = 125;
            // 
            // tipo_pedido
            // 
            this.tipo_pedido.HeaderText = "Tipo de pedido";
            this.tipo_pedido.MinimumWidth = 6;
            this.tipo_pedido.Name = "tipo_pedido";
            this.tipo_pedido.ReadOnly = true;
            this.tipo_pedido.Width = 125;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTodos.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVerTodos.Image = global::Interface_WMS_Expedicao.Properties.Resources.ver_todos;
            this.btnVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTodos.Location = new System.Drawing.Point(529, 20);
            this.btnVerTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(115, 38);
            this.btnVerTodos.TabIndex = 16;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditar.Image = global::Interface_WMS_Expedicao.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(862, 20);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 38);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grpConsultarPedidos
            // 
            this.grpConsultarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConsultarPedidos.Controls.Add(this.txtCodigoPesquisar);
            this.grpConsultarPedidos.Controls.Add(this.btnBuscar);
            this.grpConsultarPedidos.Controls.Add(this.btnVerTodos);
            this.grpConsultarPedidos.Controls.Add(this.lblDigiteCodigoPedido);
            this.grpConsultarPedidos.Controls.Add(this.dgvConsultarPedidos);
            this.grpConsultarPedidos.Controls.Add(this.btnEditar);
            this.grpConsultarPedidos.Controls.Add(this.btnLiberarPickingList);
            this.grpConsultarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpConsultarPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultarPedidos.Location = new System.Drawing.Point(63, 412);
            this.grpConsultarPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.grpConsultarPedidos.Name = "grpConsultarPedidos";
            this.grpConsultarPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.grpConsultarPedidos.Size = new System.Drawing.Size(1452, 334);
            this.grpConsultarPedidos.TabIndex = 44;
            this.grpConsultarPedidos.TabStop = false;
            this.grpConsultarPedidos.Text = "Consultar Pedidos";
            // 
            // txtCodigoPesquisar
            // 
            this.txtCodigoPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPesquisar.Location = new System.Drawing.Point(213, 27);
            this.txtCodigoPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPesquisar.Mask = "00000";
            this.txtCodigoPesquisar.Name = "txtCodigoPesquisar";
            this.txtCodigoPesquisar.Size = new System.Drawing.Size(177, 27);
            this.txtCodigoPesquisar.TabIndex = 14;
            this.txtCodigoPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBuscar.Image = global::Interface_WMS_Expedicao.Properties.Resources.pesquisar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(398, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 38);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDigiteCodigoPedido
            // 
            this.lblDigiteCodigoPedido.AutoSize = true;
            this.lblDigiteCodigoPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteCodigoPedido.Location = new System.Drawing.Point(20, 34);
            this.lblDigiteCodigoPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigiteCodigoPedido.Name = "lblDigiteCodigoPedido";
            this.lblDigiteCodigoPedido.Size = new System.Drawing.Size(176, 19);
            this.lblDigiteCodigoPedido.TabIndex = 5;
            this.lblDigiteCodigoPedido.Text = "Digite o código do pedido:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.SystemColors.Window;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.Image = global::Interface_WMS_Expedicao.Properties.Resources.menu;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(1511, 778);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(115, 38);
            this.btnMenu.TabIndex = 45;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.picLogo.TabIndex = 48;
            this.picLogo.TabStop = false;
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeUsuario.Location = new System.Drawing.Point(1443, 86);
            this.lbNomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(36, 20);
            this.lbNomeUsuario.TabIndex = 49;
            this.lbNomeUsuario.Text = "000";
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grpConsultarPedidos);
            this.Controls.Add(this.grpInformacoesPedido);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNomeSistema);
            this.Controls.Add(this.lblNameCompany);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picCabecalho);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.picRodape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "frmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faws - Cadastrar Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmCadastrar_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastrar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRodape)).EndInit();
            this.grpInformacoesPedido.ResumeLayout(false);
            this.grpInformacoesPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarPedidos)).EndInit();
            this.grpConsultarPedidos.ResumeLayout(false);
            this.grpConsultarPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCabecalho;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.Label lblNomeSistema;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.PictureBox picRodape;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarPedido;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstoque;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiberarPedido;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnLiberarPickingList;
        private System.Windows.Forms.ToolStripMenuItem tsmiPickingList;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblDescricaoPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.GroupBox grpInformacoesPedido;
        private System.Windows.Forms.ComboBox cboTipoPedido;
        private System.Windows.Forms.ComboBox cboStatusPedido;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblStatusPedido;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvConsultarPedidos;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtDescricaoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pedido;
        private System.Windows.Forms.GroupBox grpConsultarPedidos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDigiteCodigoPedido;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MaskedTextBox txtCodigoPesquisar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.MaskedTextBox txtCodigoProduto;
        private System.Windows.Forms.MaskedTextBox txtCodigoCliente;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cboPrioridade;
        private System.Windows.Forms.MaskedTextBox txtCodigoPedido;
        private System.Windows.Forms.MaskedTextBox txtLote;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
    }
}

