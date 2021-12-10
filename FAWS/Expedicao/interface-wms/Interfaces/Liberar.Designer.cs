
namespace interface_wms
{
    partial class frmLiberar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiberar));
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.picCabecalho = new System.Windows.Forms.PictureBox();
            this.picRodape = new System.Windows.Forms.PictureBox();
            this.grpPedidosProntos = new System.Windows.Forms.GroupBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.txtCodigoPedido = new System.Windows.Forms.MaskedTextBox();
            this.dgvPedidosProntos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnviarTransporte = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDigiteCodigoPedido = new System.Windows.Forms.Label();
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodape)).BeginInit();
            this.grpPedidosProntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosProntos)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
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
            this.lblMatricula.Size = new System.Drawing.Size(71, 20);
            this.lblMatricula.TabIndex = 40;
            this.lblMatricula.Text = "Usuário: ";
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
            this.lblNomeSistema.TabIndex = 30;
            this.lblNomeSistema.Text = "FATEC Warehouse System";
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
            this.lblNameCompany.TabIndex = 29;
            this.lblNameCompany.Text = "Rapid Express";
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
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
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
            this.lblTimer.Size = new System.Drawing.Size(128, 28);
            this.lblTimer.TabIndex = 26;
            this.lblTimer.Text = "dd/MM/yyyy";
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
            this.picCabecalho.TabIndex = 23;
            this.picCabecalho.TabStop = false;
            // 
            // picRodape
            // 
            this.picRodape.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picRodape.Location = new System.Drawing.Point(0, 755);
            this.picRodape.Margin = new System.Windows.Forms.Padding(4);
            this.picRodape.Name = "picRodape";
            this.picRodape.Size = new System.Drawing.Size(1683, 73);
            this.picRodape.TabIndex = 33;
            this.picRodape.TabStop = false;
            // 
            // grpPedidosProntos
            // 
            this.grpPedidosProntos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPedidosProntos.Controls.Add(this.btnVerTodos);
            this.grpPedidosProntos.Controls.Add(this.txtCodigoPedido);
            this.grpPedidosProntos.Controls.Add(this.dgvPedidosProntos);
            this.grpPedidosProntos.Controls.Add(this.btnEnviarTransporte);
            this.grpPedidosProntos.Controls.Add(this.btnBuscar);
            this.grpPedidosProntos.Controls.Add(this.lblDigiteCodigoPedido);
            this.grpPedidosProntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPedidosProntos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPedidosProntos.Location = new System.Drawing.Point(35, 153);
            this.grpPedidosProntos.Margin = new System.Windows.Forms.Padding(4);
            this.grpPedidosProntos.Name = "grpPedidosProntos";
            this.grpPedidosProntos.Padding = new System.Windows.Forms.Padding(4);
            this.grpPedidosProntos.Size = new System.Drawing.Size(1479, 597);
            this.grpPedidosProntos.TabIndex = 43;
            this.grpPedidosProntos.TabStop = false;
            this.grpPedidosProntos.Text = "Pedidos Prontos";
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTodos.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVerTodos.Image = global::Interface_WMS_Expedicao.Properties.Resources.ver_todos;
            this.btnVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTodos.Location = new System.Drawing.Point(522, 20);
            this.btnVerTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(115, 38);
            this.btnVerTodos.TabIndex = 23;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(213, 28);
            this.txtCodigoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPedido.Mask = "00000";
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(180, 27);
            this.txtCodigoPedido.TabIndex = 1;
            this.txtCodigoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPedidosProntos
            // 
            this.dgvPedidosProntos.AllowUserToAddRows = false;
            this.dgvPedidosProntos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidosProntos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPedidosProntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosProntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.cod_pedido,
            this.Cod_Cliente,
            this.Column1,
            this.data_emissao,
            this.data_entrega,
            this.quantidade,
            this.status_pedido,
            this.descricao_pedido,
            this.lote,
            this.prioridade,
            this.tipo_pedido});
            this.dgvPedidosProntos.Location = new System.Drawing.Point(16, 65);
            this.dgvPedidosProntos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidosProntos.MultiSelect = false;
            this.dgvPedidosProntos.Name = "dgvPedidosProntos";
            this.dgvPedidosProntos.ReadOnly = true;
            this.dgvPedidosProntos.RowHeadersWidth = 51;
            this.dgvPedidosProntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosProntos.Size = new System.Drawing.Size(1444, 512);
            this.dgvPedidosProntos.TabIndex = 22;
            this.dgvPedidosProntos.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "ID";
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
            // Cod_Cliente
            // 
            this.Cod_Cliente.HeaderText = "Código cliente";
            this.Cod_Cliente.MinimumWidth = 6;
            this.Cod_Cliente.Name = "Cod_Cliente";
            this.Cod_Cliente.ReadOnly = true;
            this.Cod_Cliente.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código produto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
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
            // btnEnviarTransporte
            // 
            this.btnEnviarTransporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarTransporte.BackColor = System.Drawing.SystemColors.Window;
            this.btnEnviarTransporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarTransporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnviarTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarTransporte.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarTransporte.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEnviarTransporte.Location = new System.Drawing.Point(1219, 28);
            this.btnEnviarTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarTransporte.Name = "btnEnviarTransporte";
            this.btnEnviarTransporte.Size = new System.Drawing.Size(241, 31);
            this.btnEnviarTransporte.TabIndex = 3;
            this.btnEnviarTransporte.Text = "ENVIAR PARA O TRANSPORTE";
            this.btnEnviarTransporte.UseVisualStyleBackColor = false;
            this.btnEnviarTransporte.Click += new System.EventHandler(this.btnEnviarParaTransporte_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBuscar.Image = global::Interface_WMS_Expedicao.Properties.Resources.pesquisar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(401, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 38);
            this.btnBuscar.TabIndex = 2;
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
            this.menu.Size = new System.Drawing.Size(1683, 30);
            this.menu.TabIndex = 44;
            this.menu.Text = "menuStrip1";
            // 
            // tsmiCadastrarPedido
            // 
            this.tsmiCadastrarPedido.Name = "tsmiCadastrarPedido";
            this.tsmiCadastrarPedido.Size = new System.Drawing.Size(136, 26);
            this.tsmiCadastrarPedido.Text = "Cadastrar Pedido";
            this.tsmiCadastrarPedido.Click += new System.EventHandler(this.tsmiCadastrarPedido_Click);
            // 
            // tsmiPickingList
            // 
            this.tsmiPickingList.Name = "tsmiPickingList";
            this.tsmiPickingList.Size = new System.Drawing.Size(96, 26);
            this.tsmiPickingList.Text = "Picking List";
            this.tsmiPickingList.Click += new System.EventHandler(this.tsmiPickingList_Click);
            // 
            // tsmiEstoque
            // 
            this.tsmiEstoque.Name = "tsmiEstoque";
            this.tsmiEstoque.Size = new System.Drawing.Size(76, 26);
            this.tsmiEstoque.Text = "Estoque";
            this.tsmiEstoque.Click += new System.EventHandler(this.tsmiEstoque_Click);
            // 
            // tsmiLiberarPedido
            // 
            this.tsmiLiberarPedido.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiLiberarPedido.Name = "tsmiLiberarPedido";
            this.tsmiLiberarPedido.Size = new System.Drawing.Size(119, 26);
            this.tsmiLiberarPedido.Text = "Liberar Pedido";
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
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
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
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
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
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.exibirToolStripMenuItem.Text = "Ajuda";
            // 
            // optionToolStripMenuItem2
            // 
            this.optionToolStripMenuItem2.Image = global::Interface_WMS_Expedicao.Properties.Resources.Manual1;
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.lbNomeUsuario.TabIndex = 64;
            this.lbNomeUsuario.Text = "000";
            // 
            // frmLiberar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.grpPedidosProntos);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNomeSistema);
            this.Controls.Add(this.lblNameCompany);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picCabecalho);
            this.Controls.Add(this.picRodape);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "frmLiberar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faws - Liberar Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmLiberar_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodape)).EndInit();
            this.grpPedidosProntos.ResumeLayout(false);
            this.grpPedidosProntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosProntos)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNomeSistema;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picCabecalho;
        private System.Windows.Forms.PictureBox picRodape;
        private System.Windows.Forms.GroupBox grpPedidosProntos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDigiteCodigoPedido;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarPedido;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstoque;
        private System.Windows.Forms.ToolStripMenuItem tsmiPickingList;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiberarPedido;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem2;
        private System.Windows.Forms.Button btnEnviarTransporte;
        private System.Windows.Forms.DataGridView dgvPedidosProntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pedido;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MaskedTextBox txtCodigoPedido;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
    }
}