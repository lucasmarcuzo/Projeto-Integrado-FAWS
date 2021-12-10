
namespace interface_wms
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.lblMatricula = new System.Windows.Forms.Label();
            this.grpBuscarProdutos = new System.Windows.Forms.GroupBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.txtCodigoProduto = new System.Windows.Forms.MaskedTextBox();
            this.dgvBuscarProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoEAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoLiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoBrut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Embalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDigiteCodigoProduto = new System.Windows.Forms.Label();
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picCabecalho = new System.Windows.Forms.PictureBox();
            this.picRodape = new System.Windows.Forms.PictureBox();
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
            this.tsmiSuporteEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.grpBuscarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodape)).BeginInit();
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
            // grpBuscarProdutos
            // 
            this.grpBuscarProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuscarProdutos.Controls.Add(this.btnVerTodos);
            this.grpBuscarProdutos.Controls.Add(this.txtCodigoProduto);
            this.grpBuscarProdutos.Controls.Add(this.dgvBuscarProdutos);
            this.grpBuscarProdutos.Controls.Add(this.btnBuscar);
            this.grpBuscarProdutos.Controls.Add(this.lblDigiteCodigoProduto);
            this.grpBuscarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBuscarProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscarProdutos.Location = new System.Drawing.Point(67, 164);
            this.grpBuscarProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.grpBuscarProdutos.Name = "grpBuscarProdutos";
            this.grpBuscarProdutos.Padding = new System.Windows.Forms.Padding(4);
            this.grpBuscarProdutos.Size = new System.Drawing.Size(1434, 585);
            this.grpBuscarProdutos.TabIndex = 36;
            this.grpBuscarProdutos.TabStop = false;
            this.grpBuscarProdutos.Text = "Buscar Produtos";
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
            this.btnVerTodos.Location = new System.Drawing.Point(531, 22);
            this.btnVerTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(115, 38);
            this.btnVerTodos.TabIndex = 20;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodigoProduto.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCodigoProduto.Location = new System.Drawing.Point(220, 28);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProduto.Mask = "00000000";
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(180, 27);
            this.txtCodigoProduto.TabIndex = 1;
            this.txtCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvBuscarProdutos
            // 
            this.dgvBuscarProdutos.AllowUserToAddRows = false;
            this.dgvBuscarProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBuscarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CodigoProduto,
            this.categoria,
            this.SubCategoria,
            this.Fornecedor,
            this.Referencia,
            this.Nome,
            this.CodigoEAN,
            this.Descricao,
            this.Validade,
            this.PesoLiq,
            this.PesoBrut,
            this.Qtde,
            this.QtdeDisponivel,
            this.PrecoProduto,
            this.Imagem,
            this.Embalagem});
            this.dgvBuscarProdutos.Location = new System.Drawing.Point(24, 65);
            this.dgvBuscarProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBuscarProdutos.MultiSelect = false;
            this.dgvBuscarProdutos.Name = "dgvBuscarProdutos";
            this.dgvBuscarProdutos.ReadOnly = true;
            this.dgvBuscarProdutos.RowHeadersWidth = 51;
            this.dgvBuscarProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarProdutos.Size = new System.Drawing.Size(1388, 498);
            this.dgvBuscarProdutos.TabIndex = 19;
            this.dgvBuscarProdutos.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.HeaderText = "Código do Produto";
            this.CodigoProduto.MinimumWidth = 6;
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            this.CodigoProduto.Width = 125;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 125;
            // 
            // SubCategoria
            // 
            this.SubCategoria.HeaderText = "Subcategoria";
            this.SubCategoria.MinimumWidth = 6;
            this.SubCategoria.Name = "SubCategoria";
            this.SubCategoria.ReadOnly = true;
            this.SubCategoria.Width = 125;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.MinimumWidth = 6;
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 125;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referência";
            this.Referencia.MinimumWidth = 6;
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // CodigoEAN
            // 
            this.CodigoEAN.HeaderText = "Codigo EAN";
            this.CodigoEAN.MinimumWidth = 6;
            this.CodigoEAN.Name = "CodigoEAN";
            this.CodigoEAN.ReadOnly = true;
            this.CodigoEAN.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 125;
            // 
            // Validade
            // 
            this.Validade.HeaderText = "Validade";
            this.Validade.MinimumWidth = 6;
            this.Validade.Name = "Validade";
            this.Validade.ReadOnly = true;
            this.Validade.Width = 125;
            // 
            // PesoLiq
            // 
            this.PesoLiq.HeaderText = "Peso Líquido";
            this.PesoLiq.MinimumWidth = 6;
            this.PesoLiq.Name = "PesoLiq";
            this.PesoLiq.ReadOnly = true;
            this.PesoLiq.Width = 125;
            // 
            // PesoBrut
            // 
            this.PesoBrut.HeaderText = "Peso Bruto";
            this.PesoBrut.MinimumWidth = 6;
            this.PesoBrut.Name = "PesoBrut";
            this.PesoBrut.ReadOnly = true;
            this.PesoBrut.Width = 125;
            // 
            // Qtde
            // 
            this.Qtde.HeaderText = "Quantidade";
            this.Qtde.MinimumWidth = 6;
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            this.Qtde.Width = 125;
            // 
            // QtdeDisponivel
            // 
            this.QtdeDisponivel.HeaderText = "Quantidade Disponível";
            this.QtdeDisponivel.MinimumWidth = 6;
            this.QtdeDisponivel.Name = "QtdeDisponivel";
            this.QtdeDisponivel.ReadOnly = true;
            this.QtdeDisponivel.Width = 125;
            // 
            // PrecoProduto
            // 
            this.PrecoProduto.HeaderText = "Preço do Produto";
            this.PrecoProduto.MinimumWidth = 6;
            this.PrecoProduto.Name = "PrecoProduto";
            this.PrecoProduto.ReadOnly = true;
            this.PrecoProduto.Width = 125;
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.MinimumWidth = 6;
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Width = 125;
            // 
            // Embalagem
            // 
            this.Embalagem.HeaderText = "Embalagem";
            this.Embalagem.MinimumWidth = 6;
            this.Embalagem.Name = "Embalagem";
            this.Embalagem.ReadOnly = true;
            this.Embalagem.Width = 125;
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
            this.btnBuscar.Location = new System.Drawing.Point(408, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDigiteCodigoProduto
            // 
            this.lblDigiteCodigoProduto.AutoSize = true;
            this.lblDigiteCodigoProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteCodigoProduto.Location = new System.Drawing.Point(20, 34);
            this.lblDigiteCodigoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigiteCodigoProduto.Name = "lblDigiteCodigoProduto";
            this.lblDigiteCodigoProduto.Size = new System.Drawing.Size(183, 19);
            this.lblDigiteCodigoProduto.TabIndex = 5;
            this.lblDigiteCodigoProduto.Text = "Digite o código do produto:";
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
            this.menu.TabIndex = 42;
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
            this.tsmiEstoque.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmiEstoque.Name = "tsmiEstoque";
            this.tsmiEstoque.Size = new System.Drawing.Size(76, 26);
            this.tsmiEstoque.Text = "Estoque";
            // 
            // tsmiLiberarPedido
            // 
            this.tsmiLiberarPedido.Name = "tsmiLiberarPedido";
            this.tsmiLiberarPedido.Size = new System.Drawing.Size(119, 26);
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
            this.tsmiSuporteEstoque});
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exibirToolStripMenuItem.Image = global::Interface_WMS_Expedicao.Properties.Resources.ajuda1;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
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
            // tsmiSuporteEstoque
            // 
            this.tsmiSuporteEstoque.Image = global::Interface_WMS_Expedicao.Properties.Resources.suporte;
            this.tsmiSuporteEstoque.Name = "tsmiSuporteEstoque";
            this.tsmiSuporteEstoque.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.tsmiSuporteEstoque.Size = new System.Drawing.Size(208, 26);
            this.tsmiSuporteEstoque.Text = "Suporte";
            this.tsmiSuporteEstoque.Click += new System.EventHandler(this.tsmiSuporteEstoque_Click);
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
            this.lblTimer.TabIndex = 38;
            this.lblTimer.Text = "dd/MM/yyyy";
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
            this.lbNomeUsuario.TabIndex = 50;
            this.lbNomeUsuario.Text = "000";
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.grpBuscarProdutos);
            this.Controls.Add(this.lblNomeSistema);
            this.Controls.Add(this.lblNameCompany);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picCabecalho);
            this.Controls.Add(this.picRodape);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faws - Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmEstoque_Activated);
            this.grpBuscarProdutos.ResumeLayout(false);
            this.grpBuscarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodape)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox grpBuscarProdutos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDigiteCodigoProduto;
        private System.Windows.Forms.Label lblNomeSistema;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picCabecalho;
        private System.Windows.Forms.PictureBox picRodape;
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
        private System.Windows.Forms.DataGridView dgvBuscarProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoLiq;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoBrut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Embalagem;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MaskedTextBox txtCodigoProduto;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuporteEstoque;
    }
}