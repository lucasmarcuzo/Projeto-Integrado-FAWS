
namespace FAWS_WMS.Telas
{
    partial class FrmManualAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManualAjuda));
            this.treeSelecionarAjuda = new System.Windows.Forms.TreeView();
            this.lbManualUsuario = new System.Windows.Forms.Label();
            this.lbGuiaManual = new System.Windows.Forms.Label();
            this.grbVisualizarManual = new System.Windows.Forms.GroupBox();
            this.axAcroManual = new AxAcroPDFLib.AxAcroPDF();
            this.btnAbrirManualAjuda = new System.Windows.Forms.Button();
            this.btnVerManuais = new System.Windows.Forms.Button();
            this.picLogoManual = new System.Windows.Forms.PictureBox();
            this.grbVisualizarManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoManual)).BeginInit();
            this.SuspendLayout();
            // 
            // treeSelecionarAjuda
            // 
            resources.ApplyResources(this.treeSelecionarAjuda, "treeSelecionarAjuda");
            this.treeSelecionarAjuda.Name = "treeSelecionarAjuda";
            this.treeSelecionarAjuda.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_SelecionarAjuda_AfterSelect);
            this.treeSelecionarAjuda.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trv_SelecionarAjuda_NodeMouseDoubleClick);
            // 
            // lbManualUsuario
            // 
            resources.ApplyResources(this.lbManualUsuario, "lbManualUsuario");
            this.lbManualUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbManualUsuario.Name = "lbManualUsuario";
            // 
            // lbGuiaManual
            // 
            resources.ApplyResources(this.lbGuiaManual, "lbGuiaManual");
            this.lbGuiaManual.ForeColor = System.Drawing.Color.Black;
            this.lbGuiaManual.Name = "lbGuiaManual";
            // 
            // grbVisualizarManual
            // 
            resources.ApplyResources(this.grbVisualizarManual, "grbVisualizarManual");
            this.grbVisualizarManual.Controls.Add(this.axAcroManual);
            this.grbVisualizarManual.Name = "grbVisualizarManual";
            this.grbVisualizarManual.TabStop = false;
            // 
            // axAcroManual
            // 
            resources.ApplyResources(this.axAcroManual, "axAcroManual");
            this.axAcroManual.Name = "axAcroManual";
            this.axAcroManual.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroManual.OcxState")));
            // 
            // btnAbrirManualAjuda
            // 
            resources.ApplyResources(this.btnAbrirManualAjuda, "btnAbrirManualAjuda");
            this.btnAbrirManualAjuda.BackColor = System.Drawing.SystemColors.Window;
            this.btnAbrirManualAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirManualAjuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAbrirManualAjuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbrirManualAjuda.Image = global::FAWS_WMS.Properties.Resources.Manual;
            this.btnAbrirManualAjuda.Name = "btnAbrirManualAjuda";
            this.btnAbrirManualAjuda.UseVisualStyleBackColor = false;
            this.btnAbrirManualAjuda.Click += new System.EventHandler(this.btnAbrirManualAjuda_Click);
            // 
            // btnVerManuais
            // 
            resources.ApplyResources(this.btnVerManuais, "btnVerManuais");
            this.btnVerManuais.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerManuais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerManuais.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerManuais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerManuais.Image = global::FAWS_WMS.Properties.Resources.ver_todos;
            this.btnVerManuais.Name = "btnVerManuais";
            this.btnVerManuais.UseVisualStyleBackColor = false;
            this.btnVerManuais.Click += new System.EventHandler(this.btnVerManuais_Click);
            // 
            // picLogoManual
            // 
            this.picLogoManual.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.picLogoManual, "picLogoManual");
            this.picLogoManual.Image = global::FAWS_WMS.Properties.Resources.logo;
            this.picLogoManual.Name = "picLogoManual";
            this.picLogoManual.TabStop = false;
            // 
            // FrmManualAjuda
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnAbrirManualAjuda);
            this.Controls.Add(this.btnVerManuais);
            this.Controls.Add(this.grbVisualizarManual);
            this.Controls.Add(this.picLogoManual);
            this.Controls.Add(this.lbGuiaManual);
            this.Controls.Add(this.lbManualUsuario);
            this.Controls.Add(this.treeSelecionarAjuda);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "FrmManualAjuda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManualAjuda_FormClosing);
            this.Load += new System.EventHandler(this.WfAjuda_Load);
            this.grbVisualizarManual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoManual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogoManual;
        public System.Windows.Forms.Button btnAbrirManualAjuda;
        public System.Windows.Forms.TreeView treeSelecionarAjuda;
        public System.Windows.Forms.Button btnVerManuais;
        public System.Windows.Forms.Label lbManualUsuario;
        public System.Windows.Forms.Label lbGuiaManual;
        public System.Windows.Forms.GroupBox grbVisualizarManual;
        public AxAcroPDFLib.AxAcroPDF axAcroManual;
    }
}