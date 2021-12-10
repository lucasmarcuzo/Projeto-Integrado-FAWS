
namespace interface_wms
{
    partial class frmAddCateg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCateg));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBK02 = new System.Windows.Forms.PictureBox();
            this.txtNameCateg = new System.Windows.Forms.TextBox();
            this.lblNameCateg = new System.Windows.Forms.Label();
            this.txtDescriptCateg = new System.Windows.Forms.TextBox();
            this.lblDescriptCateg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.Image = global::Interface_WMS_Produtos.Properties.Resources.salvar;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(511, 268);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Image = global::Interface_WMS_Produtos.Properties.Resources.cancelar;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(636, 268);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picBK02
            // 
            this.picBK02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBK02.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBK02.Location = new System.Drawing.Point(-7, 252);
            this.picBK02.Margin = new System.Windows.Forms.Padding(4);
            this.picBK02.Name = "picBK02";
            this.picBK02.Size = new System.Drawing.Size(791, 73);
            this.picBK02.TabIndex = 15;
            this.picBK02.TabStop = false;
            // 
            // txtNameCateg
            // 
            this.txtNameCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCateg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNameCateg.Location = new System.Drawing.Point(59, 63);
            this.txtNameCateg.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCateg.Name = "txtNameCateg";
            this.txtNameCateg.Size = new System.Drawing.Size(667, 27);
            this.txtNameCateg.TabIndex = 2;
            this.txtNameCateg.Text = "Insira o nome da nova categoria";
            this.txtNameCateg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNameCateg_MouseUp);
            // 
            // lblNameCateg
            // 
            this.lblNameCateg.AutoSize = true;
            this.lblNameCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCateg.Location = new System.Drawing.Point(56, 33);
            this.lblNameCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameCateg.Name = "lblNameCateg";
            this.lblNameCateg.Size = new System.Drawing.Size(73, 28);
            this.lblNameCateg.TabIndex = 28;
            this.lblNameCateg.Text = "Nome:";
            // 
            // txtDescriptCateg
            // 
            this.txtDescriptCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptCateg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtDescriptCateg.Location = new System.Drawing.Point(59, 140);
            this.txtDescriptCateg.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptCateg.Multiline = true;
            this.txtDescriptCateg.Name = "txtDescriptCateg";
            this.txtDescriptCateg.Size = new System.Drawing.Size(667, 88);
            this.txtDescriptCateg.TabIndex = 3;
            this.txtDescriptCateg.Text = "Escreva uma breve descrição desta categoria";
            this.txtDescriptCateg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtDescriptCateg_MouseUp);
            // 
            // lblDescriptCateg
            // 
            this.lblDescriptCateg.AutoSize = true;
            this.lblDescriptCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptCateg.Location = new System.Drawing.Point(56, 116);
            this.lblDescriptCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptCateg.Name = "lblDescriptCateg";
            this.lblDescriptCateg.Size = new System.Drawing.Size(73, 19);
            this.lblDescriptCateg.TabIndex = 30;
            this.lblDescriptCateg.Text = "Descrição:";
            // 
            // frmAddCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(776, 311);
            this.Controls.Add(this.txtDescriptCateg);
            this.Controls.Add(this.lblDescriptCateg);
            this.Controls.Add(this.txtNameCateg);
            this.Controls.Add(this.lblNameCateg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picBK02);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(794, 358);
            this.MinimumSize = new System.Drawing.Size(794, 358);
            this.Name = "frmAddCateg";
            this.Text = "faws - Adicionar Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBK02;
        private System.Windows.Forms.TextBox txtNameCateg;
        private System.Windows.Forms.Label lblNameCateg;
        private System.Windows.Forms.TextBox txtDescriptCateg;
        private System.Windows.Forms.Label lblDescriptCateg;
    }
}