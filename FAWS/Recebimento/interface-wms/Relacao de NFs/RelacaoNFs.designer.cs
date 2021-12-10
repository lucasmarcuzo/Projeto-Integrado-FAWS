
namespace interface_wms
{
    partial class FrmRelacaoNF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelacaoNF));
            this.msMenuRelNF = new System.Windows.Forms.MenuStrip();
            this.tsmiRecebimentoRelNF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedidosRelNF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSistemaRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSairRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPreferenciasRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarioRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerMatriculaRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPermissoesRec = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjudaRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManualRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSuporteRelNFs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelarNF = new System.Windows.Forms.Button();
            this.dgvRelacaoNFs = new System.Windows.Forms.DataGridView();
            this.Numero_NotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_InclusaoRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRecebimento_Fisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal_NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao_NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento_NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd_Itens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo_Mercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalidade_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalidade_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_Bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Emissor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRelacaoNF = new System.Windows.Forms.GroupBox();
            this.picIDFornecedorRelNFs = new System.Windows.Forms.PictureBox();
            this.picNumPedidoRelNFs = new System.Windows.Forms.PictureBox();
            this.picNumNF = new System.Windows.Forms.PictureBox();
            this.btnBuscarRelNFs = new System.Windows.Forms.Button();
            this.btnVertodosRel = new System.Windows.Forms.Button();
            this.txtIDFornRelNF = new System.Windows.Forms.TextBox();
            this.lbIDFornecedorRelNF = new System.Windows.Forms.Label();
            this.txtBuscarNumPedRel = new System.Windows.Forms.TextBox();
            this.lbBucaNumPedRelNF = new System.Windows.Forms.Label();
            this.lbBuscaNumNFRelNF = new System.Windows.Forms.Label();
            this.txtBuscaNumNFRel = new System.Windows.Forms.TextBox();
            this.TipDicas = new System.Windows.Forms.ToolTip(this.components);
            this.tmrHoras = new System.Windows.Forms.Timer(this.components);
            this.lbDataHoraRelNF = new System.Windows.Forms.Label();
            this.lbUsuarioRelNF = new System.Windows.Forms.Label();
            this.lbNomeSistemaRelNF = new System.Windows.Forms.Label();
            this.epBusca = new System.Windows.Forms.ErrorProvider(this.components);
            this.picLogoRelNF = new System.Windows.Forms.PictureBox();
            this.picCabecalhoRelNF = new System.Windows.Forms.PictureBox();
            this.picRodapeRelNF = new System.Windows.Forms.PictureBox();
            this.lbNomeMatriculaRelNF = new System.Windows.Forms.Label();
            this.grbControlesRelNF = new System.Windows.Forms.GroupBox();
            this.msMenuRelNF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacaoNFs)).BeginInit();
            this.grpRelacaoNF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIDFornecedorRelNFs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumPedidoRelNFs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumNF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoRelNF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalhoRelNF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodapeRelNF)).BeginInit();
            this.grbControlesRelNF.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuRelNF
            // 
            this.msMenuRelNF.BackColor = System.Drawing.SystemColors.Window;
            this.msMenuRelNF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuRelNF.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuRelNF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecebimentoRelNF,
            this.tsmiSistemaRelNFs,
            this.tsmiUsuarioRelNFs,
            this.tsmiAjudaRelNFs});
            this.msMenuRelNF.Location = new System.Drawing.Point(0, 0);
            this.msMenuRelNF.Name = "msMenuRelNF";
            this.msMenuRelNF.Size = new System.Drawing.Size(1683, 28);
            this.msMenuRelNF.TabIndex = 1;
            // 
            // tsmiRecebimentoRelNF
            // 
            this.tsmiRecebimentoRelNF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConsultarNFs});
            this.tsmiRecebimentoRelNF.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiRecebimentoRelNF.Image = global::Interface_WMS_Recebimento.Properties.Resources.navegação;
            this.tsmiRecebimentoRelNF.Name = "tsmiRecebimentoRelNF";
            this.tsmiRecebimentoRelNF.Size = new System.Drawing.Size(118, 24);
            this.tsmiRecebimentoRelNF.Text = "Navegação";
            this.tsmiRecebimentoRelNF.ToolTipText = "Navegar entre as abas do sistema";
            // 
            // tsmiConsultarNFs
            // 
            this.tsmiConsultarNFs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPedidosRelNF});
            this.tsmiConsultarNFs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiConsultarNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.consultar;
            this.tsmiConsultarNFs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiConsultarNFs.Name = "tsmiConsultarNFs";
            this.tsmiConsultarNFs.Size = new System.Drawing.Size(159, 32);
            this.tsmiConsultarNFs.Text = "Consultar";
            this.tsmiConsultarNFs.ToolTipText = "Clique para Consultar Tabelas";
            // 
            // tsmiPedidosRelNF
            // 
            this.tsmiPedidosRelNF.Image = global::Interface_WMS_Recebimento.Properties.Resources.pedidos;
            this.tsmiPedidosRelNF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPedidosRelNF.Name = "tsmiPedidosRelNF";
            this.tsmiPedidosRelNF.ShortcutKeyDisplayString = "Ctrl+O";
            this.tsmiPedidosRelNF.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiPedidosRelNF.Size = new System.Drawing.Size(202, 32);
            this.tsmiPedidosRelNF.Text = "Pedidos";
            this.tsmiPedidosRelNF.ToolTipText = "Clique para Consultar Pedidos";
            this.tsmiPedidosRelNF.Click += new System.EventHandler(this.tsmiPedidosNFs_Click);
            // 
            // tsmiSistemaRelNFs
            // 
            this.tsmiSistemaRelNFs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSairRelNFs,
            this.toolStripMenuItem1,
            this.tsmiPreferenciasRelNFs});
            this.tsmiSistemaRelNFs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiSistemaRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.sistema;
            this.tsmiSistemaRelNFs.Name = "tsmiSistemaRelNFs";
            this.tsmiSistemaRelNFs.Size = new System.Drawing.Size(95, 24);
            this.tsmiSistemaRelNFs.Text = "Sistema";
            this.tsmiSistemaRelNFs.ToolTipText = "Opções do Sistema";
            // 
            // tsmiSairRelNFs
            // 
            this.tsmiSairRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.sair;
            this.tsmiSairRelNFs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSairRelNFs.Name = "tsmiSairRelNFs";
            this.tsmiSairRelNFs.ShortcutKeyDisplayString = "Ctrl+E";
            this.tsmiSairRelNFs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiSairRelNFs.Size = new System.Drawing.Size(227, 32);
            this.tsmiSairRelNFs.Text = "Sair";
            this.tsmiSairRelNFs.ToolTipText = "Clique para Sair do Sistema";
            this.tsmiSairRelNFs.Click += new System.EventHandler(this.tsmiSairNFs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 6);
            // 
            // tsmiPreferenciasRelNFs
            // 
            this.tsmiPreferenciasRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.preferencias;
            this.tsmiPreferenciasRelNFs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPreferenciasRelNFs.Name = "tsmiPreferenciasRelNFs";
            this.tsmiPreferenciasRelNFs.ShortcutKeyDisplayString = "Ctrl+P";
            this.tsmiPreferenciasRelNFs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiPreferenciasRelNFs.Size = new System.Drawing.Size(227, 32);
            this.tsmiPreferenciasRelNFs.Text = "Preferências";
            this.tsmiPreferenciasRelNFs.ToolTipText = "Clique para ver as Preferências de Visualização";
            this.tsmiPreferenciasRelNFs.Click += new System.EventHandler(this.tsmiPreferenciasNFs_Click);
            // 
            // tsmiUsuarioRelNFs
            // 
            this.tsmiUsuarioRelNFs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerMatriculaRelNFs,
            this.toolStripSeparator1,
            this.tsmiPermissoesRec});
            this.tsmiUsuarioRelNFs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiUsuarioRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.usuario;
            this.tsmiUsuarioRelNFs.Name = "tsmiUsuarioRelNFs";
            this.tsmiUsuarioRelNFs.Size = new System.Drawing.Size(93, 24);
            this.tsmiUsuarioRelNFs.Text = "Usuário";
            this.tsmiUsuarioRelNFs.ToolTipText = "Opções de Usuário";
            // 
            // tsmiVerMatriculaRelNFs
            // 
            this.tsmiVerMatriculaRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.identificação;
            this.tsmiVerMatriculaRelNFs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiVerMatriculaRelNFs.Name = "tsmiVerMatriculaRelNFs";
            this.tsmiVerMatriculaRelNFs.ShortcutKeyDisplayString = "Ctrl+R";
            this.tsmiVerMatriculaRelNFs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmiVerMatriculaRelNFs.Size = new System.Drawing.Size(235, 32);
            this.tsmiVerMatriculaRelNFs.Text = "Ver Matrícula";
            this.tsmiVerMatriculaRelNFs.ToolTipText = "Clique para ver a Matrícula";
            this.tsmiVerMatriculaRelNFs.Click += new System.EventHandler(this.tsmiVerMatriculaNFs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // tsmiPermissoesRec
            // 
            this.tsmiPermissoesRec.Image = global::Interface_WMS_Recebimento.Properties.Resources.permissão;
            this.tsmiPermissoesRec.Name = "tsmiPermissoesRec";
            this.tsmiPermissoesRec.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiPermissoesRec.Size = new System.Drawing.Size(235, 32);
            this.tsmiPermissoesRec.Text = "Permissões";
            this.tsmiPermissoesRec.ToolTipText = "Clique para ver as Permissões do Sistema";
            this.tsmiPermissoesRec.Click += new System.EventHandler(this.tsmiPermissoesRec_Click);
            // 
            // tsmiAjudaRelNFs
            // 
            this.tsmiAjudaRelNFs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManualRelNFs,
            this.toolStripSeparator2,
            this.tsmiSuporteRelNFs});
            this.tsmiAjudaRelNFs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiAjudaRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.ajuda;
            this.tsmiAjudaRelNFs.Name = "tsmiAjudaRelNFs";
            this.tsmiAjudaRelNFs.Size = new System.Drawing.Size(82, 24);
            this.tsmiAjudaRelNFs.Text = "Ajuda";
            this.tsmiAjudaRelNFs.ToolTipText = "Menu de Ajuda";
            // 
            // tsmiManualRelNFs
            // 
            this.tsmiManualRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.Manual;
            this.tsmiManualRelNFs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiManualRelNFs.Name = "tsmiManualRelNFs";
            this.tsmiManualRelNFs.ShortcutKeyDisplayString = "F1";
            this.tsmiManualRelNFs.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiManualRelNFs.Size = new System.Drawing.Size(213, 32);
            this.tsmiManualRelNFs.Text = "Manual";
            this.tsmiManualRelNFs.ToolTipText = "Clique para ver o Manual de Instruções";
            this.tsmiManualRelNFs.Click += new System.EventHandler(this.tsmiSuporteNFs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // tsmiSuporteRelNFs
            // 
            this.tsmiSuporteRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.suporte;
            this.tsmiSuporteRelNFs.Name = "tsmiSuporteRelNFs";
            this.tsmiSuporteRelNFs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.tsmiSuporteRelNFs.Size = new System.Drawing.Size(213, 32);
            this.tsmiSuporteRelNFs.Text = "Suporte";
            this.tsmiSuporteRelNFs.ToolTipText = "Clique para solicitar Suporte";
            this.tsmiSuporteRelNFs.Click += new System.EventHandler(this.tsmiSuporteRelNFs_Click);
            // 
            // btnCancelarNF
            // 
            this.btnCancelarNF.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarNF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarNF.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelarNF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarNF.Image = global::Interface_WMS_Recebimento.Properties.Resources.sair;
            this.btnCancelarNF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarNF.Location = new System.Drawing.Point(11, 23);
            this.btnCancelarNF.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarNF.Name = "btnCancelarNF";
            this.btnCancelarNF.Size = new System.Drawing.Size(127, 52);
            this.btnCancelarNF.TabIndex = 5;
            this.btnCancelarNF.Text = "Sair";
            this.btnCancelarNF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipDicas.SetToolTip(this.btnCancelarNF, "Clique para Sair");
            this.btnCancelarNF.UseVisualStyleBackColor = false;
            this.btnCancelarNF.Click += new System.EventHandler(this.btnCancelarNF_Click);
            // 
            // dgvRelacaoNFs
            // 
            this.dgvRelacaoNFs.AllowUserToAddRows = false;
            this.dgvRelacaoNFs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelacaoNFs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelacaoNFs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelacaoNFs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacaoNFs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_NotaFiscal,
            this.Endereço_Entrega,
            this.Data_InclusaoRegistro,
            this.DataRecebimento_Fisico,
            this.Nome_Fornecedor,
            this.ID_Fornecedor,
            this.ValorTotal_NF,
            this.DataEmissao_NF,
            this.Vencimento_NF,
            this.Numero_pedido,
            this.Qtd_Itens,
            this.Montante,
            this.Grupo_Mercadoria,
            this.Penalidade_Dias,
            this.Penalidade_Pagamento,
            this.Peso_Bruto,
            this.Usuario_Emissor,
            this.Cod_Produto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelacaoNFs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelacaoNFs.Location = new System.Drawing.Point(12, 95);
            this.dgvRelacaoNFs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRelacaoNFs.MultiSelect = false;
            this.dgvRelacaoNFs.Name = "dgvRelacaoNFs";
            this.dgvRelacaoNFs.ReadOnly = true;
            this.dgvRelacaoNFs.RowHeadersWidth = 51;
            this.dgvRelacaoNFs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelacaoNFs.Size = new System.Drawing.Size(1436, 535);
            this.dgvRelacaoNFs.TabIndex = 16;
            this.dgvRelacaoNFs.TabStop = false;
            // 
            // Numero_NotaFiscal
            // 
            this.Numero_NotaFiscal.HeaderText = "Num. da NF:";
            this.Numero_NotaFiscal.MinimumWidth = 6;
            this.Numero_NotaFiscal.Name = "Numero_NotaFiscal";
            this.Numero_NotaFiscal.ReadOnly = true;
            this.Numero_NotaFiscal.Width = 130;
            // 
            // Endereço_Entrega
            // 
            this.Endereço_Entrega.HeaderText = "Endereço de Entrega:";
            this.Endereço_Entrega.MaxInputLength = 50;
            this.Endereço_Entrega.MinimumWidth = 6;
            this.Endereço_Entrega.Name = "Endereço_Entrega";
            this.Endereço_Entrega.ReadOnly = true;
            this.Endereço_Entrega.Width = 125;
            // 
            // Data_InclusaoRegistro
            // 
            this.Data_InclusaoRegistro.HeaderText = "Data da Inclusão do Registro:";
            this.Data_InclusaoRegistro.MinimumWidth = 6;
            this.Data_InclusaoRegistro.Name = "Data_InclusaoRegistro";
            this.Data_InclusaoRegistro.ReadOnly = true;
            this.Data_InclusaoRegistro.Width = 125;
            // 
            // DataRecebimento_Fisico
            // 
            this.DataRecebimento_Fisico.HeaderText = "Data do Recebimento Físico:";
            this.DataRecebimento_Fisico.MinimumWidth = 6;
            this.DataRecebimento_Fisico.Name = "DataRecebimento_Fisico";
            this.DataRecebimento_Fisico.ReadOnly = true;
            this.DataRecebimento_Fisico.Width = 125;
            // 
            // Nome_Fornecedor
            // 
            this.Nome_Fornecedor.HeaderText = "Fornecedor:";
            this.Nome_Fornecedor.MinimumWidth = 6;
            this.Nome_Fornecedor.Name = "Nome_Fornecedor";
            this.Nome_Fornecedor.ReadOnly = true;
            this.Nome_Fornecedor.Width = 125;
            // 
            // ID_Fornecedor
            // 
            this.ID_Fornecedor.HeaderText = "ID. do Fornecedor:";
            this.ID_Fornecedor.MinimumWidth = 6;
            this.ID_Fornecedor.Name = "ID_Fornecedor";
            this.ID_Fornecedor.ReadOnly = true;
            this.ID_Fornecedor.Width = 125;
            // 
            // ValorTotal_NF
            // 
            this.ValorTotal_NF.HeaderText = "Valor Total  da NF:";
            this.ValorTotal_NF.MinimumWidth = 6;
            this.ValorTotal_NF.Name = "ValorTotal_NF";
            this.ValorTotal_NF.ReadOnly = true;
            this.ValorTotal_NF.Width = 125;
            // 
            // DataEmissao_NF
            // 
            this.DataEmissao_NF.HeaderText = "Data da Emissão da NF:";
            this.DataEmissao_NF.MinimumWidth = 6;
            this.DataEmissao_NF.Name = "DataEmissao_NF";
            this.DataEmissao_NF.ReadOnly = true;
            this.DataEmissao_NF.Width = 125;
            // 
            // Vencimento_NF
            // 
            this.Vencimento_NF.HeaderText = "Vencimento da NF:";
            this.Vencimento_NF.MinimumWidth = 6;
            this.Vencimento_NF.Name = "Vencimento_NF";
            this.Vencimento_NF.ReadOnly = true;
            this.Vencimento_NF.Width = 125;
            // 
            // Numero_pedido
            // 
            this.Numero_pedido.HeaderText = "Num. do Pedido:";
            this.Numero_pedido.MinimumWidth = 6;
            this.Numero_pedido.Name = "Numero_pedido";
            this.Numero_pedido.ReadOnly = true;
            this.Numero_pedido.Width = 125;
            // 
            // Qtd_Itens
            // 
            this.Qtd_Itens.HeaderText = "Qtd. de Itens:";
            this.Qtd_Itens.MinimumWidth = 6;
            this.Qtd_Itens.Name = "Qtd_Itens";
            this.Qtd_Itens.ReadOnly = true;
            this.Qtd_Itens.Width = 125;
            // 
            // Montante
            // 
            this.Montante.HeaderText = "Montante:";
            this.Montante.MinimumWidth = 6;
            this.Montante.Name = "Montante";
            this.Montante.ReadOnly = true;
            this.Montante.Width = 125;
            // 
            // Grupo_Mercadoria
            // 
            this.Grupo_Mercadoria.HeaderText = "Grupo da Mercadoria:";
            this.Grupo_Mercadoria.MinimumWidth = 6;
            this.Grupo_Mercadoria.Name = "Grupo_Mercadoria";
            this.Grupo_Mercadoria.ReadOnly = true;
            this.Grupo_Mercadoria.Width = 125;
            // 
            // Penalidade_Dias
            // 
            this.Penalidade_Dias.HeaderText = "Penalidade em Dias:";
            this.Penalidade_Dias.MinimumWidth = 6;
            this.Penalidade_Dias.Name = "Penalidade_Dias";
            this.Penalidade_Dias.ReadOnly = true;
            this.Penalidade_Dias.Width = 125;
            // 
            // Penalidade_Pagamento
            // 
            this.Penalidade_Pagamento.HeaderText = "Penalidade (Pagamento):";
            this.Penalidade_Pagamento.MinimumWidth = 6;
            this.Penalidade_Pagamento.Name = "Penalidade_Pagamento";
            this.Penalidade_Pagamento.ReadOnly = true;
            this.Penalidade_Pagamento.Width = 125;
            // 
            // Peso_Bruto
            // 
            this.Peso_Bruto.HeaderText = "Peso Bruto (Kg):";
            this.Peso_Bruto.MinimumWidth = 6;
            this.Peso_Bruto.Name = "Peso_Bruto";
            this.Peso_Bruto.ReadOnly = true;
            this.Peso_Bruto.Width = 125;
            // 
            // Usuario_Emissor
            // 
            this.Usuario_Emissor.HeaderText = "Usuário Emissor:";
            this.Usuario_Emissor.MinimumWidth = 6;
            this.Usuario_Emissor.Name = "Usuario_Emissor";
            this.Usuario_Emissor.ReadOnly = true;
            this.Usuario_Emissor.Width = 125;
            // 
            // Cod_Produto
            // 
            this.Cod_Produto.HeaderText = "Cod. do Produto:";
            this.Cod_Produto.MinimumWidth = 6;
            this.Cod_Produto.Name = "Cod_Produto";
            this.Cod_Produto.ReadOnly = true;
            this.Cod_Produto.Width = 125;
            // 
            // grpRelacaoNF
            // 
            this.grpRelacaoNF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRelacaoNF.Controls.Add(this.picIDFornecedorRelNFs);
            this.grpRelacaoNF.Controls.Add(this.picNumPedidoRelNFs);
            this.grpRelacaoNF.Controls.Add(this.picNumNF);
            this.grpRelacaoNF.Controls.Add(this.btnBuscarRelNFs);
            this.grpRelacaoNF.Controls.Add(this.btnVertodosRel);
            this.grpRelacaoNF.Controls.Add(this.txtIDFornRelNF);
            this.grpRelacaoNF.Controls.Add(this.lbIDFornecedorRelNF);
            this.grpRelacaoNF.Controls.Add(this.txtBuscarNumPedRel);
            this.grpRelacaoNF.Controls.Add(this.lbBucaNumPedRelNF);
            this.grpRelacaoNF.Controls.Add(this.lbBuscaNumNFRelNF);
            this.grpRelacaoNF.Controls.Add(this.txtBuscaNumNFRel);
            this.grpRelacaoNF.Controls.Add(this.dgvRelacaoNFs);
            this.grpRelacaoNF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRelacaoNF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpRelacaoNF.Location = new System.Drawing.Point(16, 135);
            this.grpRelacaoNF.Margin = new System.Windows.Forms.Padding(4);
            this.grpRelacaoNF.Name = "grpRelacaoNF";
            this.grpRelacaoNF.Padding = new System.Windows.Forms.Padding(4);
            this.grpRelacaoNF.Size = new System.Drawing.Size(1461, 649);
            this.grpRelacaoNF.TabIndex = 16;
            this.grpRelacaoNF.TabStop = false;
            this.grpRelacaoNF.Text = "Localizar Notas Fiscais:";
            // 
            // picIDFornecedorRelNFs
            // 
            this.picIDFornecedorRelNFs.BackColor = System.Drawing.Color.Transparent;
            this.picIDFornecedorRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.senha;
            this.picIDFornecedorRelNFs.Location = new System.Drawing.Point(935, 31);
            this.picIDFornecedorRelNFs.Margin = new System.Windows.Forms.Padding(4);
            this.picIDFornecedorRelNFs.Name = "picIDFornecedorRelNFs";
            this.picIDFornecedorRelNFs.Size = new System.Drawing.Size(29, 25);
            this.picIDFornecedorRelNFs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIDFornecedorRelNFs.TabIndex = 94;
            this.picIDFornecedorRelNFs.TabStop = false;
            // 
            // picNumPedidoRelNFs
            // 
            this.picNumPedidoRelNFs.BackColor = System.Drawing.Color.Transparent;
            this.picNumPedidoRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.senha;
            this.picNumPedidoRelNFs.Location = new System.Drawing.Point(584, 31);
            this.picNumPedidoRelNFs.Margin = new System.Windows.Forms.Padding(4);
            this.picNumPedidoRelNFs.Name = "picNumPedidoRelNFs";
            this.picNumPedidoRelNFs.Size = new System.Drawing.Size(29, 25);
            this.picNumPedidoRelNFs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNumPedidoRelNFs.TabIndex = 93;
            this.picNumPedidoRelNFs.TabStop = false;
            // 
            // picNumNF
            // 
            this.picNumNF.BackColor = System.Drawing.Color.Transparent;
            this.picNumNF.Image = global::Interface_WMS_Recebimento.Properties.Resources.senha;
            this.picNumNF.Location = new System.Drawing.Point(233, 31);
            this.picNumNF.Margin = new System.Windows.Forms.Padding(4);
            this.picNumNF.Name = "picNumNF";
            this.picNumNF.Size = new System.Drawing.Size(29, 25);
            this.picNumNF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNumNF.TabIndex = 92;
            this.picNumNF.TabStop = false;
            // 
            // btnBuscarRelNFs
            // 
            this.btnBuscarRelNFs.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarRelNFs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarRelNFs.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarRelNFs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRelNFs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBuscarRelNFs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarRelNFs.Image = global::Interface_WMS_Recebimento.Properties.Resources.pesquisar;
            this.btnBuscarRelNFs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarRelNFs.Location = new System.Drawing.Point(1024, 37);
            this.btnBuscarRelNFs.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarRelNFs.Name = "btnBuscarRelNFs";
            this.btnBuscarRelNFs.Size = new System.Drawing.Size(127, 52);
            this.btnBuscarRelNFs.TabIndex = 4;
            this.btnBuscarRelNFs.Text = "Procurar";
            this.btnBuscarRelNFs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipDicas.SetToolTip(this.btnBuscarRelNFs, "Procurar dados das NFs");
            this.btnBuscarRelNFs.UseVisualStyleBackColor = false;
            this.btnBuscarRelNFs.Click += new System.EventHandler(this.btnBuscarRelNFs_Click);
            // 
            // btnVertodosRel
            // 
            this.btnVertodosRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVertodosRel.BackColor = System.Drawing.SystemColors.Window;
            this.btnVertodosRel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVertodosRel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVertodosRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVertodosRel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnVertodosRel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVertodosRel.Image = global::Interface_WMS_Recebimento.Properties.Resources.ver_todos;
            this.btnVertodosRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVertodosRel.Location = new System.Drawing.Point(1321, 37);
            this.btnVertodosRel.Margin = new System.Windows.Forms.Padding(4);
            this.btnVertodosRel.Name = "btnVertodosRel";
            this.btnVertodosRel.Size = new System.Drawing.Size(127, 52);
            this.btnVertodosRel.TabIndex = 0;
            this.btnVertodosRel.Text = "Ver todos";
            this.btnVertodosRel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipDicas.SetToolTip(this.btnVertodosRel, "Ver todos os dados das NFs");
            this.btnVertodosRel.UseVisualStyleBackColor = false;
            this.btnVertodosRel.Click += new System.EventHandler(this.btnVertodosRel_Click);
            // 
            // txtIDFornRelNF
            // 
            this.txtIDFornRelNF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDFornRelNF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFornRelNF.Location = new System.Drawing.Point(719, 57);
            this.txtIDFornRelNF.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDFornRelNF.MaxLength = 20;
            this.txtIDFornRelNF.Name = "txtIDFornRelNF";
            this.txtIDFornRelNF.Size = new System.Drawing.Size(245, 27);
            this.txtIDFornRelNF.TabIndex = 3;
            this.TipDicas.SetToolTip(this.txtIDFornRelNF, "Digite a ID. do fornecedor para realizar a busca");
            this.txtIDFornRelNF.TextChanged += new System.EventHandler(this.txtIDFornRel_TextChanged);
            this.txtIDFornRelNF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDFornRel_KeyPress);
            this.txtIDFornRelNF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIDFornRel_KeyUp);
            // 
            // lbIDFornecedorRelNF
            // 
            this.lbIDFornecedorRelNF.AutoSize = true;
            this.lbIDFornecedorRelNF.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDFornecedorRelNF.Location = new System.Drawing.Point(715, 37);
            this.lbIDFornecedorRelNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDFornecedorRelNF.Name = "lbIDFornecedorRelNF";
            this.lbIDFornecedorRelNF.Size = new System.Drawing.Size(123, 19);
            this.lbIDFornecedorRelNF.TabIndex = 53;
            this.lbIDFornecedorRelNF.Text = "ID. do Fornecedor:";
            // 
            // txtBuscarNumPedRel
            // 
            this.txtBuscarNumPedRel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscarNumPedRel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNumPedRel.Location = new System.Drawing.Point(368, 60);
            this.txtBuscarNumPedRel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarNumPedRel.MaxLength = 7;
            this.txtBuscarNumPedRel.Name = "txtBuscarNumPedRel";
            this.txtBuscarNumPedRel.Size = new System.Drawing.Size(245, 27);
            this.txtBuscarNumPedRel.TabIndex = 2;
            this.TipDicas.SetToolTip(this.txtBuscarNumPedRel, "Digite o número do pedido para realizar a busca");
            this.txtBuscarNumPedRel.TextChanged += new System.EventHandler(this.txtBuscarNumPedRel_TextChanged);
            this.txtBuscarNumPedRel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarNumPedRel_KeyPress);
            this.txtBuscarNumPedRel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarNumPedRel_KeyUp);
            // 
            // lbBucaNumPedRelNF
            // 
            this.lbBucaNumPedRelNF.AutoSize = true;
            this.lbBucaNumPedRelNF.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBucaNumPedRelNF.Location = new System.Drawing.Point(364, 37);
            this.lbBucaNumPedRelNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBucaNumPedRelNF.Name = "lbBucaNumPedRelNF";
            this.lbBucaNumPedRelNF.Size = new System.Drawing.Size(130, 19);
            this.lbBucaNumPedRelNF.TabIndex = 18;
            this.lbBucaNumPedRelNF.Text = "Número do Pedido:";
            // 
            // lbBuscaNumNFRelNF
            // 
            this.lbBuscaNumNFRelNF.AutoSize = true;
            this.lbBuscaNumNFRelNF.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscaNumNFRelNF.Location = new System.Drawing.Point(13, 37);
            this.lbBuscaNumNFRelNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuscaNumNFRelNF.Name = "lbBuscaNumNFRelNF";
            this.lbBuscaNumNFRelNF.Size = new System.Drawing.Size(104, 19);
            this.lbBuscaNumNFRelNF.TabIndex = 5;
            this.lbBuscaNumNFRelNF.Text = "Número da NF:";
            // 
            // txtBuscaNumNFRel
            // 
            this.txtBuscaNumNFRel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscaNumNFRel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNumNFRel.Location = new System.Drawing.Point(17, 60);
            this.txtBuscaNumNFRel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaNumNFRel.MaxLength = 20;
            this.txtBuscaNumNFRel.Name = "txtBuscaNumNFRel";
            this.txtBuscaNumNFRel.Size = new System.Drawing.Size(245, 27);
            this.txtBuscaNumNFRel.TabIndex = 1;
            this.TipDicas.SetToolTip(this.txtBuscaNumNFRel, "Digite o número da nota para realizar a busca");
            this.txtBuscaNumNFRel.TextChanged += new System.EventHandler(this.txtBuscaNumNFRel_TextChanged);
            this.txtBuscaNumNFRel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaNumNFRel_KeyPress);
            this.txtBuscaNumNFRel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaNumNFRel_KeyUp);
            // 
            // TipDicas
            // 
            this.TipDicas.AutomaticDelay = 200;
            this.TipDicas.IsBalloon = true;
            // 
            // tmrHoras
            // 
            this.tmrHoras.Enabled = true;
            this.tmrHoras.Interval = 1000;
            this.tmrHoras.Tick += new System.EventHandler(this.tmrHoras_Tick);
            // 
            // lbDataHoraRelNF
            // 
            this.lbDataHoraRelNF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbDataHoraRelNF.AutoSize = true;
            this.lbDataHoraRelNF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDataHoraRelNF.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDataHoraRelNF.Location = new System.Drawing.Point(784, 82);
            this.lbDataHoraRelNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataHoraRelNF.Name = "lbDataHoraRelNF";
            this.lbDataHoraRelNF.Size = new System.Drawing.Size(125, 19);
            this.lbDataHoraRelNF.TabIndex = 36;
            this.lbDataHoraRelNF.Text = "19/05/2021, 00:00";
            // 
            // lbUsuarioRelNF
            // 
            this.lbUsuarioRelNF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuarioRelNF.AutoSize = true;
            this.lbUsuarioRelNF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsuarioRelNF.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbUsuarioRelNF.Location = new System.Drawing.Point(1379, 62);
            this.lbUsuarioRelNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuarioRelNF.Name = "lbUsuarioRelNF";
            this.lbUsuarioRelNF.Size = new System.Drawing.Size(64, 19);
            this.lbUsuarioRelNF.TabIndex = 35;
            this.lbUsuarioRelNF.Text = "Usuário:";
            // 
            // lbNomeSistemaRelNF
            // 
            this.lbNomeSistemaRelNF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNomeSistemaRelNF.AutoSize = true;
            this.lbNomeSistemaRelNF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNomeSistemaRelNF.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbNomeSistemaRelNF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNomeSistemaRelNF.Location = new System.Drawing.Point(757, 62);
            this.lbNomeSistemaRelNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeSistemaRelNF.Name = "lbNomeSistemaRelNF";
            this.lbNomeSistemaRelNF.Size = new System.Drawing.Size(169, 19);
            this.lbNomeSistemaRelNF.TabIndex = 68;
            this.lbNomeSistemaRelNF.Text = "FATEC Warehouse System";
            // 
            // epBusca
            // 
            this.epBusca.ContainerControl = this;
            // 
            // picLogoRelNF
            // 
            this.picLogoRelNF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picLogoRelNF.Image = global::Interface_WMS_Recebimento.Properties.Resources.logo;
            this.picLogoRelNF.Location = new System.Drawing.Point(125, 37);
            this.picLogoRelNF.Margin = new System.Windows.Forms.Padding(4);
            this.picLogoRelNF.Name = "picLogoRelNF";
            this.picLogoRelNF.Size = new System.Drawing.Size(253, 80);
            this.picLogoRelNF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoRelNF.TabIndex = 38;
            this.picLogoRelNF.TabStop = false;
            // 
            // picCabecalhoRelNF
            // 
            this.picCabecalhoRelNF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCabecalhoRelNF.Dock = System.Windows.Forms.DockStyle.Top;
            this.picCabecalhoRelNF.Location = new System.Drawing.Point(0, 28);
            this.picCabecalhoRelNF.Margin = new System.Windows.Forms.Padding(4);
            this.picCabecalhoRelNF.Name = "picCabecalhoRelNF";
            this.picCabecalhoRelNF.Size = new System.Drawing.Size(1683, 98);
            this.picCabecalhoRelNF.TabIndex = 34;
            this.picCabecalhoRelNF.TabStop = false;
            // 
            // picRodapeRelNF
            // 
            this.picRodapeRelNF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picRodapeRelNF.Location = new System.Drawing.Point(0, 792);
            this.picRodapeRelNF.Margin = new System.Windows.Forms.Padding(4);
            this.picRodapeRelNF.Name = "picRodapeRelNF";
            this.picRodapeRelNF.Size = new System.Drawing.Size(1685, 37);
            this.picRodapeRelNF.TabIndex = 12;
            this.picRodapeRelNF.TabStop = false;
            // 
            // lbNomeMatriculaRelNF
            // 
            this.lbNomeMatriculaRelNF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeMatriculaRelNF.AutoSize = true;
            this.lbNomeMatriculaRelNF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNomeMatriculaRelNF.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbNomeMatriculaRelNF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNomeMatriculaRelNF.Location = new System.Drawing.Point(1393, 81);
            this.lbNomeMatriculaRelNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeMatriculaRelNF.Name = "lbNomeMatriculaRelNF";
            this.lbNomeMatriculaRelNF.Size = new System.Drawing.Size(33, 19);
            this.lbNomeMatriculaRelNF.TabIndex = 71;
            this.lbNomeMatriculaRelNF.Text = "000";
            // 
            // grbControlesRelNF
            // 
            this.grbControlesRelNF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grbControlesRelNF.Controls.Add(this.btnCancelarNF);
            this.grbControlesRelNF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbControlesRelNF.Location = new System.Drawing.Point(1508, 704);
            this.grbControlesRelNF.Margin = new System.Windows.Forms.Padding(4);
            this.grbControlesRelNF.Name = "grbControlesRelNF";
            this.grbControlesRelNF.Padding = new System.Windows.Forms.Padding(4);
            this.grbControlesRelNF.Size = new System.Drawing.Size(147, 80);
            this.grbControlesRelNF.TabIndex = 75;
            this.grbControlesRelNF.TabStop = false;
            this.grbControlesRelNF.Text = "Controles:";
            // 
            // FrmRelacaoNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.grbControlesRelNF);
            this.Controls.Add(this.lbNomeMatriculaRelNF);
            this.Controls.Add(this.lbNomeSistemaRelNF);
            this.Controls.Add(this.picLogoRelNF);
            this.Controls.Add(this.lbDataHoraRelNF);
            this.Controls.Add(this.lbUsuarioRelNF);
            this.Controls.Add(this.picCabecalhoRelNF);
            this.Controls.Add(this.grpRelacaoNF);
            this.Controls.Add(this.picRodapeRelNF);
            this.Controls.Add(this.msMenuRelNF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "FrmRelacaoNF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faws - Relação de NFs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmRelacaoNF_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRelacaoNF_FormClosing);
            this.msMenuRelNF.ResumeLayout(false);
            this.msMenuRelNF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacaoNFs)).EndInit();
            this.grpRelacaoNF.ResumeLayout(false);
            this.grpRelacaoNF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIDFornecedorRelNFs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumPedidoRelNFs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumNF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoRelNF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalhoRelNF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodapeRelNF)).EndInit();
            this.grbControlesRelNF.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenuRelNF;
        private System.Windows.Forms.ToolStripMenuItem tsmiSistemaRelNFs;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarioRelNFs;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjudaRelNFs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSairRelNFs;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerMatriculaRelNFs;
        private System.Windows.Forms.ToolStripMenuItem tsmiManualRelNFs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreferenciasRelNFs;
        private System.Windows.Forms.Button btnCancelarNF;
        private System.Windows.Forms.PictureBox picRodapeRelNF;
        private System.Windows.Forms.DataGridView dgvRelacaoNFs;
        private System.Windows.Forms.GroupBox grpRelacaoNF;
        private System.Windows.Forms.Label lbBuscaNumNFRelNF;
        private System.Windows.Forms.TextBox txtBuscarNumPedRel;
        private System.Windows.Forms.Label lbBucaNumPedRelNF;
        private System.Windows.Forms.TextBox txtIDFornRelNF;
        private System.Windows.Forms.Label lbIDFornecedorRelNF;
        private System.Windows.Forms.ToolTip TipDicas;
        private System.Windows.Forms.Timer tmrHoras;
        private System.Windows.Forms.PictureBox picLogoRelNF;
        private System.Windows.Forms.Label lbDataHoraRelNF;
        private System.Windows.Forms.Label lbUsuarioRelNF;
        private System.Windows.Forms.PictureBox picCabecalhoRelNF;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecebimentoRelNF;
        private System.Windows.Forms.Label lbNomeSistemaRelNF;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarNFs;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedidosRelNF;
        private System.Windows.Forms.ErrorProvider epBusca;
        private System.Windows.Forms.Button btnBuscarRelNFs;
        private System.Windows.Forms.Button btnVertodosRel;
        protected internal System.Windows.Forms.TextBox txtBuscaNumNFRel;
        private System.Windows.Forms.Label lbNomeMatriculaRelNF;
        private System.Windows.Forms.GroupBox grbControlesRelNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_NotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_InclusaoRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRecebimento_Fisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal_NF;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao_NF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento_NF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd_Itens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo_Mercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalidade_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalidade_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_Bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Emissor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Produto;
        private System.Windows.Forms.PictureBox picIDFornecedorRelNFs;
        private System.Windows.Forms.PictureBox picNumPedidoRelNFs;
        private System.Windows.Forms.PictureBox picNumNF;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuporteRelNFs;
        private System.Windows.Forms.ToolStripMenuItem tsmiPermissoesRec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

