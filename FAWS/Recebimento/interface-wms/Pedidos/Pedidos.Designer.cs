
namespace interface_wms
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.msMenuPedidos = new System.Windows.Forms.MenuStrip();
            this.tsmiRecebimentoPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelacaoNFsPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSistemaPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSairPed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPreferenciasPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarioPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerMatriculaPed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPermissoesPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjudaPed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManualPed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSuportePed = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelarPed = new System.Windows.Forms.Button();
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.picIDFornecedorPed = new System.Windows.Forms.PictureBox();
            this.picProtocAgendamentoPed = new System.Windows.Forms.PictureBox();
            this.picNumeroPedidos = new System.Windows.Forms.PictureBox();
            this.btnBuscarPed = new System.Windows.Forms.Button();
            this.btnVertodosPed = new System.Windows.Forms.Button();
            this.txtIDFornPed = new System.Windows.Forms.TextBox();
            this.lbIDFornecedorPedidos = new System.Windows.Forms.Label();
            this.txtBuscaProtocAgenPed = new System.Windows.Forms.TextBox();
            this.lbProtocAgendamentoPed = new System.Windows.Forms.Label();
            this.lbNumPedidos = new System.Windows.Forms.Label();
            this.txtBuscaNumPed = new System.Windows.Forms.TextBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.Numero_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocolo_Agendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Agendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_Agendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd_Pecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrHoras = new System.Windows.Forms.Timer(this.components);
            this.TipDicas = new System.Windows.Forms.ToolTip(this.components);
            this.lbDataHoraPedidos = new System.Windows.Forms.Label();
            this.lbUsuarioPedidos = new System.Windows.Forms.Label();
            this.lbNomeSistemaPedidos = new System.Windows.Forms.Label();
            this.epBusca = new System.Windows.Forms.ErrorProvider(this.components);
            this.picLogoPedidos = new System.Windows.Forms.PictureBox();
            this.picCabecalhoPedidos = new System.Windows.Forms.PictureBox();
            this.picRodapePed = new System.Windows.Forms.PictureBox();
            this.lbNomeMatriculaPedidos = new System.Windows.Forms.Label();
            this.grbControlesPed = new System.Windows.Forms.GroupBox();
            this.msMenuPedidos.SuspendLayout();
            this.grbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIDFornecedorPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProtocAgendamentoPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumeroPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalhoPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodapePed)).BeginInit();
            this.grbControlesPed.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuPedidos
            // 
            this.msMenuPedidos.BackColor = System.Drawing.SystemColors.Window;
            this.msMenuPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuPedidos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecebimentoPed,
            this.tsmiSistemaPed,
            this.tsmiUsuarioPed,
            this.tsmiAjudaPed});
            this.msMenuPedidos.Location = new System.Drawing.Point(0, 0);
            this.msMenuPedidos.Name = "msMenuPedidos";
            this.msMenuPedidos.Size = new System.Drawing.Size(1683, 28);
            this.msMenuPedidos.TabIndex = 1;
            // 
            // tsmiRecebimentoPed
            // 
            this.tsmiRecebimentoPed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConsultarPed});
            this.tsmiRecebimentoPed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiRecebimentoPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.navegação;
            this.tsmiRecebimentoPed.Name = "tsmiRecebimentoPed";
            this.tsmiRecebimentoPed.Size = new System.Drawing.Size(118, 24);
            this.tsmiRecebimentoPed.Text = "Navegação";
            this.tsmiRecebimentoPed.ToolTipText = "Navegar entre as abas do sistema";
            // 
            // tsmiConsultarPed
            // 
            this.tsmiConsultarPed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRelacaoNFsPed});
            this.tsmiConsultarPed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiConsultarPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.consultar;
            this.tsmiConsultarPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiConsultarPed.Name = "tsmiConsultarPed";
            this.tsmiConsultarPed.Size = new System.Drawing.Size(159, 32);
            this.tsmiConsultarPed.Text = "Consultar";
            this.tsmiConsultarPed.ToolTipText = "Clique para Consultar Tabelas";
            // 
            // tsmiRelacaoNFsPed
            // 
            this.tsmiRelacaoNFsPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.NFs;
            this.tsmiRelacaoNFsPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRelacaoNFsPed.Name = "tsmiRelacaoNFsPed";
            this.tsmiRelacaoNFsPed.ShortcutKeyDisplayString = "Ctrl+N";
            this.tsmiRelacaoNFsPed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiRelacaoNFsPed.Size = new System.Drawing.Size(252, 32);
            this.tsmiRelacaoNFsPed.Text = "Relação de NFs";
            this.tsmiRelacaoNFsPed.ToolTipText = "Clique para Consultar Notas Fiscais";
            this.tsmiRelacaoNFsPed.Click += new System.EventHandler(this.tsmiRelacaoNFsPed_Click);
            // 
            // tsmiSistemaPed
            // 
            this.tsmiSistemaPed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSairPed,
            this.toolStripMenuItem1,
            this.tsmiPreferenciasPed});
            this.tsmiSistemaPed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiSistemaPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.sistema;
            this.tsmiSistemaPed.Name = "tsmiSistemaPed";
            this.tsmiSistemaPed.Size = new System.Drawing.Size(95, 24);
            this.tsmiSistemaPed.Text = "Sistema";
            this.tsmiSistemaPed.ToolTipText = "Opções do Sistema";
            // 
            // tsmiSairPed
            // 
            this.tsmiSairPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.sair;
            this.tsmiSairPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSairPed.Name = "tsmiSairPed";
            this.tsmiSairPed.ShortcutKeyDisplayString = "Ctrl+E";
            this.tsmiSairPed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiSairPed.Size = new System.Drawing.Size(227, 32);
            this.tsmiSairPed.Text = "Sair";
            this.tsmiSairPed.ToolTipText = "Clique para Sair do Sistema";
            this.tsmiSairPed.Click += new System.EventHandler(this.tsmiSairPed_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 6);
            // 
            // tsmiPreferenciasPed
            // 
            this.tsmiPreferenciasPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.preferencias;
            this.tsmiPreferenciasPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPreferenciasPed.Name = "tsmiPreferenciasPed";
            this.tsmiPreferenciasPed.ShortcutKeyDisplayString = "Ctrl+P";
            this.tsmiPreferenciasPed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiPreferenciasPed.Size = new System.Drawing.Size(227, 32);
            this.tsmiPreferenciasPed.Text = "Preferências";
            this.tsmiPreferenciasPed.ToolTipText = "Clique para Sair do Sistema";
            this.tsmiPreferenciasPed.Click += new System.EventHandler(this.tsmiPreferenciasPed_Click);
            // 
            // tsmiUsuarioPed
            // 
            this.tsmiUsuarioPed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerMatriculaPed,
            this.toolStripSeparator1,
            this.tsmiPermissoesPedidos});
            this.tsmiUsuarioPed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiUsuarioPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.usuario;
            this.tsmiUsuarioPed.Name = "tsmiUsuarioPed";
            this.tsmiUsuarioPed.Size = new System.Drawing.Size(93, 24);
            this.tsmiUsuarioPed.Text = "Usuário";
            this.tsmiUsuarioPed.ToolTipText = "Opções de Usuário";
            // 
            // tsmiVerMatriculaPed
            // 
            this.tsmiVerMatriculaPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.identificação;
            this.tsmiVerMatriculaPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiVerMatriculaPed.Name = "tsmiVerMatriculaPed";
            this.tsmiVerMatriculaPed.ShortcutKeyDisplayString = "Ctrl+R";
            this.tsmiVerMatriculaPed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmiVerMatriculaPed.Size = new System.Drawing.Size(235, 32);
            this.tsmiVerMatriculaPed.Text = "Ver Matrícula";
            this.tsmiVerMatriculaPed.ToolTipText = "Clique para ver a Matrícula";
            this.tsmiVerMatriculaPed.Click += new System.EventHandler(this.tsmiVerMatriculaPed_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // tsmiPermissoesPedidos
            // 
            this.tsmiPermissoesPedidos.Image = global::Interface_WMS_Recebimento.Properties.Resources.permissão;
            this.tsmiPermissoesPedidos.Name = "tsmiPermissoesPedidos";
            this.tsmiPermissoesPedidos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiPermissoesPedidos.Size = new System.Drawing.Size(235, 32);
            this.tsmiPermissoesPedidos.Text = "Permissões";
            this.tsmiPermissoesPedidos.ToolTipText = "Clique para ver as Permissões do Sistema";
            this.tsmiPermissoesPedidos.Click += new System.EventHandler(this.tsmiPermissoesPedidos_Click);
            // 
            // tsmiAjudaPed
            // 
            this.tsmiAjudaPed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManualPed,
            this.toolStripSeparator2,
            this.tsmiSuportePed});
            this.tsmiAjudaPed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tsmiAjudaPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.ajuda;
            this.tsmiAjudaPed.Name = "tsmiAjudaPed";
            this.tsmiAjudaPed.Size = new System.Drawing.Size(82, 24);
            this.tsmiAjudaPed.Text = "Ajuda";
            this.tsmiAjudaPed.ToolTipText = "Menu de Ajuda";
            // 
            // tsmiManualPed
            // 
            this.tsmiManualPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.Manual;
            this.tsmiManualPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiManualPed.Name = "tsmiManualPed";
            this.tsmiManualPed.ShortcutKeyDisplayString = "F1";
            this.tsmiManualPed.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiManualPed.Size = new System.Drawing.Size(213, 32);
            this.tsmiManualPed.Text = "Manual";
            this.tsmiManualPed.ToolTipText = "Clique para ver o Manual de Instruções";
            this.tsmiManualPed.Click += new System.EventHandler(this.tsmiSuportePed_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // tsmiSuportePed
            // 
            this.tsmiSuportePed.Image = global::Interface_WMS_Recebimento.Properties.Resources.suporte;
            this.tsmiSuportePed.Name = "tsmiSuportePed";
            this.tsmiSuportePed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.tsmiSuportePed.Size = new System.Drawing.Size(213, 32);
            this.tsmiSuportePed.Text = "Suporte";
            this.tsmiSuportePed.ToolTipText = "Clique para solicitar Suporte";
            this.tsmiSuportePed.Click += new System.EventHandler(this.tsmiSuportePed_Click_1);
            // 
            // btnCancelarPed
            // 
            this.btnCancelarPed.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPed.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelarPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.sair;
            this.btnCancelarPed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPed.Location = new System.Drawing.Point(11, 22);
            this.btnCancelarPed.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarPed.Name = "btnCancelarPed";
            this.btnCancelarPed.Size = new System.Drawing.Size(127, 52);
            this.btnCancelarPed.TabIndex = 5;
            this.btnCancelarPed.Text = "Sair";
            this.btnCancelarPed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipDicas.SetToolTip(this.btnCancelarPed, "Clique para Sair");
            this.btnCancelarPed.UseVisualStyleBackColor = false;
            this.btnCancelarPed.Click += new System.EventHandler(this.btnCancelarPed_Click);
            // 
            // grbPedidos
            // 
            this.grbPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPedidos.Controls.Add(this.picIDFornecedorPed);
            this.grbPedidos.Controls.Add(this.picProtocAgendamentoPed);
            this.grbPedidos.Controls.Add(this.picNumeroPedidos);
            this.grbPedidos.Controls.Add(this.btnBuscarPed);
            this.grbPedidos.Controls.Add(this.btnVertodosPed);
            this.grbPedidos.Controls.Add(this.txtIDFornPed);
            this.grbPedidos.Controls.Add(this.lbIDFornecedorPedidos);
            this.grbPedidos.Controls.Add(this.txtBuscaProtocAgenPed);
            this.grbPedidos.Controls.Add(this.lbProtocAgendamentoPed);
            this.grbPedidos.Controls.Add(this.lbNumPedidos);
            this.grbPedidos.Controls.Add(this.txtBuscaNumPed);
            this.grbPedidos.Controls.Add(this.dgvPedidos);
            this.grbPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbPedidos.Location = new System.Drawing.Point(16, 135);
            this.grbPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.grbPedidos.Size = new System.Drawing.Size(1461, 649);
            this.grbPedidos.TabIndex = 16;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "Localizar Pedidos:";
            // 
            // picIDFornecedorPed
            // 
            this.picIDFornecedorPed.BackColor = System.Drawing.Color.Transparent;
            this.picIDFornecedorPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.senha;
            this.picIDFornecedorPed.Location = new System.Drawing.Point(854, 29);
            this.picIDFornecedorPed.Margin = new System.Windows.Forms.Padding(4);
            this.picIDFornecedorPed.Name = "picIDFornecedorPed";
            this.picIDFornecedorPed.Size = new System.Drawing.Size(29, 25);
            this.picIDFornecedorPed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIDFornecedorPed.TabIndex = 97;
            this.picIDFornecedorPed.TabStop = false;
            // 
            // picProtocAgendamentoPed
            // 
            this.picProtocAgendamentoPed.BackColor = System.Drawing.Color.Transparent;
            this.picProtocAgendamentoPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.senha;
            this.picProtocAgendamentoPed.Location = new System.Drawing.Point(539, 29);
            this.picProtocAgendamentoPed.Margin = new System.Windows.Forms.Padding(4);
            this.picProtocAgendamentoPed.Name = "picProtocAgendamentoPed";
            this.picProtocAgendamentoPed.Size = new System.Drawing.Size(29, 25);
            this.picProtocAgendamentoPed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProtocAgendamentoPed.TabIndex = 96;
            this.picProtocAgendamentoPed.TabStop = false;
            // 
            // picNumeroPedidos
            // 
            this.picNumeroPedidos.BackColor = System.Drawing.Color.Transparent;
            this.picNumeroPedidos.Image = global::Interface_WMS_Recebimento.Properties.Resources.senha;
            this.picNumeroPedidos.Location = new System.Drawing.Point(224, 29);
            this.picNumeroPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.picNumeroPedidos.Name = "picNumeroPedidos";
            this.picNumeroPedidos.Size = new System.Drawing.Size(29, 25);
            this.picNumeroPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNumeroPedidos.TabIndex = 95;
            this.picNumeroPedidos.TabStop = false;
            // 
            // btnBuscarPed
            // 
            this.btnBuscarPed.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPed.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPed.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBuscarPed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.pesquisar;
            this.btnBuscarPed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPed.Location = new System.Drawing.Point(943, 34);
            this.btnBuscarPed.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPed.Name = "btnBuscarPed";
            this.btnBuscarPed.Size = new System.Drawing.Size(127, 52);
            this.btnBuscarPed.TabIndex = 4;
            this.btnBuscarPed.Text = "Procurar";
            this.btnBuscarPed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipDicas.SetToolTip(this.btnBuscarPed, "Procurar dados dos pedidos");
            this.btnBuscarPed.UseVisualStyleBackColor = false;
            this.btnBuscarPed.Click += new System.EventHandler(this.btnBuscarPed_Click);
            // 
            // btnVertodosPed
            // 
            this.btnVertodosPed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVertodosPed.BackColor = System.Drawing.SystemColors.Window;
            this.btnVertodosPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVertodosPed.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVertodosPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVertodosPed.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnVertodosPed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVertodosPed.Image = global::Interface_WMS_Recebimento.Properties.Resources.ver_todos;
            this.btnVertodosPed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVertodosPed.Location = new System.Drawing.Point(1317, 34);
            this.btnVertodosPed.Margin = new System.Windows.Forms.Padding(4);
            this.btnVertodosPed.Name = "btnVertodosPed";
            this.btnVertodosPed.Size = new System.Drawing.Size(127, 52);
            this.btnVertodosPed.TabIndex = 0;
            this.btnVertodosPed.Text = "Ver todos";
            this.btnVertodosPed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipDicas.SetToolTip(this.btnVertodosPed, "Ver todos dados dos pedidos");
            this.btnVertodosPed.UseVisualStyleBackColor = false;
            this.btnVertodosPed.Click += new System.EventHandler(this.btnVertodosPed_Click);
            // 
            // txtIDFornPed
            // 
            this.txtIDFornPed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDFornPed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFornPed.Location = new System.Drawing.Point(636, 57);
            this.txtIDFornPed.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDFornPed.MaxLength = 20;
            this.txtIDFornPed.Name = "txtIDFornPed";
            this.txtIDFornPed.Size = new System.Drawing.Size(247, 27);
            this.txtIDFornPed.TabIndex = 3;
            this.TipDicas.SetToolTip(this.txtIDFornPed, "Digite a ID. do fornecedor para realizar a busca");
            this.txtIDFornPed.TextChanged += new System.EventHandler(this.txtIDFornPed_TextChanged);
            this.txtIDFornPed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDFornPed_KeyPress);
            this.txtIDFornPed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIDFornPed_KeyUp);
            // 
            // lbIDFornecedorPedidos
            // 
            this.lbIDFornecedorPedidos.AutoSize = true;
            this.lbIDFornecedorPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDFornecedorPedidos.Location = new System.Drawing.Point(632, 35);
            this.lbIDFornecedorPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDFornecedorPedidos.Name = "lbIDFornecedorPedidos";
            this.lbIDFornecedorPedidos.Size = new System.Drawing.Size(123, 19);
            this.lbIDFornecedorPedidos.TabIndex = 21;
            this.lbIDFornecedorPedidos.Text = "ID. do Fornecedor:";
            // 
            // txtBuscaProtocAgenPed
            // 
            this.txtBuscaProtocAgenPed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscaProtocAgenPed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaProtocAgenPed.Location = new System.Drawing.Point(323, 57);
            this.txtBuscaProtocAgenPed.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaProtocAgenPed.MaxLength = 7;
            this.txtBuscaProtocAgenPed.Name = "txtBuscaProtocAgenPed";
            this.txtBuscaProtocAgenPed.Size = new System.Drawing.Size(245, 27);
            this.txtBuscaProtocAgenPed.TabIndex = 2;
            this.TipDicas.SetToolTip(this.txtBuscaProtocAgenPed, "Digite o protocolo de agendamento para realizar a busca");
            this.txtBuscaProtocAgenPed.TextChanged += new System.EventHandler(this.txtBuscaProtocAgenPed_TextChanged);
            this.txtBuscaProtocAgenPed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaProtocAgenPed_KeyPress);
            this.txtBuscaProtocAgenPed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaProtocAgenPed_KeyUp);
            // 
            // lbProtocAgendamentoPed
            // 
            this.lbProtocAgendamentoPed.AutoSize = true;
            this.lbProtocAgendamentoPed.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProtocAgendamentoPed.Location = new System.Drawing.Point(319, 34);
            this.lbProtocAgendamentoPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProtocAgendamentoPed.Name = "lbProtocAgendamentoPed";
            this.lbProtocAgendamentoPed.Size = new System.Drawing.Size(183, 19);
            this.lbProtocAgendamentoPed.TabIndex = 18;
            this.lbProtocAgendamentoPed.Text = "Protocolo de Agendamento:";
            // 
            // lbNumPedidos
            // 
            this.lbNumPedidos.AutoSize = true;
            this.lbNumPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumPedidos.Location = new System.Drawing.Point(4, 35);
            this.lbNumPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumPedidos.Name = "lbNumPedidos";
            this.lbNumPedidos.Size = new System.Drawing.Size(130, 19);
            this.lbNumPedidos.TabIndex = 5;
            this.lbNumPedidos.Text = "Número do Pedido:";
            // 
            // txtBuscaNumPed
            // 
            this.txtBuscaNumPed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscaNumPed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNumPed.Location = new System.Drawing.Point(8, 57);
            this.txtBuscaNumPed.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaNumPed.MaxLength = 7;
            this.txtBuscaNumPed.Name = "txtBuscaNumPed";
            this.txtBuscaNumPed.Size = new System.Drawing.Size(245, 27);
            this.txtBuscaNumPed.TabIndex = 1;
            this.TipDicas.SetToolTip(this.txtBuscaNumPed, "Digite o número do pedido para realizar a busca");
            this.txtBuscaNumPed.TextChanged += new System.EventHandler(this.txtBuscaNumPed_TextChanged);
            this.txtBuscaNumPed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaNumPed_KeyPress);
            this.txtBuscaNumPed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaNumPed_KeyUp);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Pedido,
            this.Protocolo_Agendamento,
            this.ID_Fornecedor,
            this.Cod_Produto,
            this.Data_Agendamento,
            this.Horario_Agendamento,
            this.Qtd_Pecas,
            this.Valor_Pedido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(8, 92);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1436, 540);
            this.dgvPedidos.TabIndex = 16;
            this.dgvPedidos.TabStop = false;
            // 
            // Numero_Pedido
            // 
            this.Numero_Pedido.HeaderText = "Num. do Pedido:";
            this.Numero_Pedido.MinimumWidth = 6;
            this.Numero_Pedido.Name = "Numero_Pedido";
            this.Numero_Pedido.ReadOnly = true;
            this.Numero_Pedido.Width = 125;
            // 
            // Protocolo_Agendamento
            // 
            this.Protocolo_Agendamento.HeaderText = "Protocolo do Agendamento:";
            this.Protocolo_Agendamento.MinimumWidth = 6;
            this.Protocolo_Agendamento.Name = "Protocolo_Agendamento";
            this.Protocolo_Agendamento.ReadOnly = true;
            this.Protocolo_Agendamento.Width = 150;
            // 
            // ID_Fornecedor
            // 
            this.ID_Fornecedor.HeaderText = "ID. do Fornecedor:";
            this.ID_Fornecedor.MinimumWidth = 6;
            this.ID_Fornecedor.Name = "ID_Fornecedor";
            this.ID_Fornecedor.ReadOnly = true;
            this.ID_Fornecedor.Width = 150;
            // 
            // Cod_Produto
            // 
            this.Cod_Produto.HeaderText = "Cod. do Produto:";
            this.Cod_Produto.MinimumWidth = 6;
            this.Cod_Produto.Name = "Cod_Produto";
            this.Cod_Produto.ReadOnly = true;
            this.Cod_Produto.Width = 150;
            // 
            // Data_Agendamento
            // 
            this.Data_Agendamento.HeaderText = "Data do Agendamento:";
            this.Data_Agendamento.MinimumWidth = 6;
            this.Data_Agendamento.Name = "Data_Agendamento";
            this.Data_Agendamento.ReadOnly = true;
            this.Data_Agendamento.Width = 150;
            // 
            // Horario_Agendamento
            // 
            this.Horario_Agendamento.HeaderText = "Horário do Agendamento:";
            this.Horario_Agendamento.MinimumWidth = 6;
            this.Horario_Agendamento.Name = "Horario_Agendamento";
            this.Horario_Agendamento.ReadOnly = true;
            this.Horario_Agendamento.Width = 150;
            // 
            // Qtd_Pecas
            // 
            this.Qtd_Pecas.HeaderText = "Qtd. de Peças:";
            this.Qtd_Pecas.MinimumWidth = 6;
            this.Qtd_Pecas.Name = "Qtd_Pecas";
            this.Qtd_Pecas.ReadOnly = true;
            this.Qtd_Pecas.Width = 150;
            // 
            // Valor_Pedido
            // 
            this.Valor_Pedido.HeaderText = "Valor do Pedido:";
            this.Valor_Pedido.MinimumWidth = 6;
            this.Valor_Pedido.Name = "Valor_Pedido";
            this.Valor_Pedido.ReadOnly = true;
            this.Valor_Pedido.Width = 150;
            // 
            // tmrHoras
            // 
            this.tmrHoras.Enabled = true;
            this.tmrHoras.Interval = 1000;
            this.tmrHoras.Tick += new System.EventHandler(this.tmrHoras_Tick);
            // 
            // TipDicas
            // 
            this.TipDicas.AutomaticDelay = 200;
            this.TipDicas.IsBalloon = true;
            // 
            // lbDataHoraPedidos
            // 
            this.lbDataHoraPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbDataHoraPedidos.AutoSize = true;
            this.lbDataHoraPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDataHoraPedidos.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDataHoraPedidos.Location = new System.Drawing.Point(784, 82);
            this.lbDataHoraPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataHoraPedidos.Name = "lbDataHoraPedidos";
            this.lbDataHoraPedidos.Size = new System.Drawing.Size(125, 19);
            this.lbDataHoraPedidos.TabIndex = 36;
            this.lbDataHoraPedidos.Text = "19/05/2021, 00:00";
            // 
            // lbUsuarioPedidos
            // 
            this.lbUsuarioPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuarioPedidos.AutoSize = true;
            this.lbUsuarioPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsuarioPedidos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbUsuarioPedidos.Location = new System.Drawing.Point(1379, 62);
            this.lbUsuarioPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuarioPedidos.Name = "lbUsuarioPedidos";
            this.lbUsuarioPedidos.Size = new System.Drawing.Size(64, 19);
            this.lbUsuarioPedidos.TabIndex = 35;
            this.lbUsuarioPedidos.Text = "Usuário:";
            // 
            // lbNomeSistemaPedidos
            // 
            this.lbNomeSistemaPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNomeSistemaPedidos.AutoSize = true;
            this.lbNomeSistemaPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNomeSistemaPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbNomeSistemaPedidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNomeSistemaPedidos.Location = new System.Drawing.Point(757, 62);
            this.lbNomeSistemaPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeSistemaPedidos.Name = "lbNomeSistemaPedidos";
            this.lbNomeSistemaPedidos.Size = new System.Drawing.Size(169, 19);
            this.lbNomeSistemaPedidos.TabIndex = 68;
            this.lbNomeSistemaPedidos.Text = "FATEC Warehouse System";
            // 
            // epBusca
            // 
            this.epBusca.ContainerControl = this;
            // 
            // picLogoPedidos
            // 
            this.picLogoPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picLogoPedidos.Image = global::Interface_WMS_Recebimento.Properties.Resources.logo;
            this.picLogoPedidos.Location = new System.Drawing.Point(125, 37);
            this.picLogoPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.picLogoPedidos.Name = "picLogoPedidos";
            this.picLogoPedidos.Size = new System.Drawing.Size(253, 80);
            this.picLogoPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoPedidos.TabIndex = 38;
            this.picLogoPedidos.TabStop = false;
            // 
            // picCabecalhoPedidos
            // 
            this.picCabecalhoPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCabecalhoPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.picCabecalhoPedidos.Location = new System.Drawing.Point(0, 28);
            this.picCabecalhoPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.picCabecalhoPedidos.Name = "picCabecalhoPedidos";
            this.picCabecalhoPedidos.Size = new System.Drawing.Size(1683, 98);
            this.picCabecalhoPedidos.TabIndex = 34;
            this.picCabecalhoPedidos.TabStop = false;
            // 
            // picRodapePed
            // 
            this.picRodapePed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picRodapePed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picRodapePed.Location = new System.Drawing.Point(0, 791);
            this.picRodapePed.Margin = new System.Windows.Forms.Padding(4);
            this.picRodapePed.Name = "picRodapePed";
            this.picRodapePed.Size = new System.Drawing.Size(1683, 37);
            this.picRodapePed.TabIndex = 12;
            this.picRodapePed.TabStop = false;
            // 
            // lbNomeMatriculaPedidos
            // 
            this.lbNomeMatriculaPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeMatriculaPedidos.AutoSize = true;
            this.lbNomeMatriculaPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNomeMatriculaPedidos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbNomeMatriculaPedidos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNomeMatriculaPedidos.Location = new System.Drawing.Point(1393, 81);
            this.lbNomeMatriculaPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeMatriculaPedidos.Name = "lbNomeMatriculaPedidos";
            this.lbNomeMatriculaPedidos.Size = new System.Drawing.Size(33, 19);
            this.lbNomeMatriculaPedidos.TabIndex = 72;
            this.lbNomeMatriculaPedidos.Text = "000";
            // 
            // grbControlesPed
            // 
            this.grbControlesPed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grbControlesPed.Controls.Add(this.btnCancelarPed);
            this.grbControlesPed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbControlesPed.Location = new System.Drawing.Point(1508, 704);
            this.grbControlesPed.Margin = new System.Windows.Forms.Padding(4);
            this.grbControlesPed.Name = "grbControlesPed";
            this.grbControlesPed.Padding = new System.Windows.Forms.Padding(4);
            this.grbControlesPed.Size = new System.Drawing.Size(147, 80);
            this.grbControlesPed.TabIndex = 73;
            this.grbControlesPed.TabStop = false;
            this.grbControlesPed.Text = "Controles:";
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.grbControlesPed);
            this.Controls.Add(this.lbNomeMatriculaPedidos);
            this.Controls.Add(this.lbNomeSistemaPedidos);
            this.Controls.Add(this.picLogoPedidos);
            this.Controls.Add(this.lbDataHoraPedidos);
            this.Controls.Add(this.lbUsuarioPedidos);
            this.Controls.Add(this.picCabecalhoPedidos);
            this.Controls.Add(this.grbPedidos);
            this.Controls.Add(this.picRodapePed);
            this.Controls.Add(this.msMenuPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faws - Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmPedidos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedidos_FormClosing);
            this.msMenuPedidos.ResumeLayout(false);
            this.msMenuPedidos.PerformLayout();
            this.grbPedidos.ResumeLayout(false);
            this.grbPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIDFornecedorPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProtocAgendamentoPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumeroPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabecalhoPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodapePed)).EndInit();
            this.grbControlesPed.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenuPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiSistemaPed;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarioPed;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjudaPed;
        private System.Windows.Forms.ToolStripMenuItem tsmiSairPed;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerMatriculaPed;
        private System.Windows.Forms.ToolStripMenuItem tsmiManualPed;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreferenciasPed;
        private System.Windows.Forms.Button btnCancelarPed;
        private System.Windows.Forms.PictureBox picRodapePed;
        private System.Windows.Forms.GroupBox grbPedidos;
        private System.Windows.Forms.Label lbNumPedidos;
        private System.Windows.Forms.Label lbIDFornecedorPedidos;
        private System.Windows.Forms.TextBox txtBuscaProtocAgenPed;
        private System.Windows.Forms.Label lbProtocAgendamentoPed;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox txtIDFornPed;
        private System.Windows.Forms.Timer tmrHoras;
        private System.Windows.Forms.ToolTip TipDicas;
        private System.Windows.Forms.PictureBox picLogoPedidos;
        private System.Windows.Forms.Label lbDataHoraPedidos;
        private System.Windows.Forms.Label lbUsuarioPedidos;
        private System.Windows.Forms.PictureBox picCabecalhoPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecebimentoPed;
        private System.Windows.Forms.Label lbNomeSistemaPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarPed;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelacaoNFsPed;
        private System.Windows.Forms.ErrorProvider epBusca;
        private System.Windows.Forms.Button btnBuscarPed;
        private System.Windows.Forms.Button btnVertodosPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocolo_Agendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Agendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_Agendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd_Pecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Pedido;
        protected internal System.Windows.Forms.TextBox txtBuscaNumPed;
        private System.Windows.Forms.Label lbNomeMatriculaPedidos;
        private System.Windows.Forms.GroupBox grbControlesPed;
        private System.Windows.Forms.PictureBox picIDFornecedorPed;
        private System.Windows.Forms.PictureBox picProtocAgendamentoPed;
        private System.Windows.Forms.PictureBox picNumeroPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuportePed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPermissoesPedidos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

