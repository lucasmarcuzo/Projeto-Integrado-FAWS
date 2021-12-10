using FAWS_WMS.Telas;

namespace Interface_WMS_Produtos
{
    class FrmManual : FrmManualAjuda
    {
        private void InitializeComponent()
        {
            this.grbVisualizarManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroManual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirManualAjuda
            // 
            this.btnAbrirManualAjuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // treeSelecionarAjuda
            // 
            this.treeSelecionarAjuda.LineColor = System.Drawing.Color.Black;
            // 
            // btnVerManuais
            // 
            this.btnVerManuais.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // FrmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1049, 729);
            this.Name = "FrmManual";
            this.grbVisualizarManual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroManual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
