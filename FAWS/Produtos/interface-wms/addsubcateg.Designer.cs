
namespace interface_wms
{
    partial class frmAddSubCateg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSubCateg));
            this.txtDescriptSubCateg = new System.Windows.Forms.TextBox();
            this.lblDescriptCateg = new System.Windows.Forms.Label();
            this.txtNameSubCateg = new System.Windows.Forms.TextBox();
            this.lblNameCateg = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBK02 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCateg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescriptSubCateg
            // 
            this.txtDescriptSubCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptSubCateg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtDescriptSubCateg.Location = new System.Drawing.Point(60, 140);
            this.txtDescriptSubCateg.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptSubCateg.Multiline = true;
            this.txtDescriptSubCateg.Name = "txtDescriptSubCateg";
            this.txtDescriptSubCateg.Size = new System.Drawing.Size(667, 88);
            this.txtDescriptSubCateg.TabIndex = 3;
            this.txtDescriptSubCateg.Text = "Escreva uma breve descrição desta sub categoria";
            this.txtDescriptSubCateg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtDescriptSubCateg_MouseUp);
            // 
            // lblDescriptCateg
            // 
            this.lblDescriptCateg.AutoSize = true;
            this.lblDescriptCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptCateg.Location = new System.Drawing.Point(57, 116);
            this.lblDescriptCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptCateg.Name = "lblDescriptCateg";
            this.lblDescriptCateg.Size = new System.Drawing.Size(73, 19);
            this.lblDescriptCateg.TabIndex = 37;
            this.lblDescriptCateg.Text = "Descrição:";
            // 
            // txtNameSubCateg
            // 
            this.txtNameSubCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSubCateg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNameSubCateg.Location = new System.Drawing.Point(60, 63);
            this.txtNameSubCateg.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSubCateg.Name = "txtNameSubCateg";
            this.txtNameSubCateg.Size = new System.Drawing.Size(339, 27);
            this.txtNameSubCateg.TabIndex = 2;
            this.txtNameSubCateg.Text = "Insira o nome da nova sub categoria";
            this.txtNameSubCateg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNameSubCateg_MouseUp);
            // 
            // lblNameCateg
            // 
            this.lblNameCateg.AutoSize = true;
            this.lblNameCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCateg.Location = new System.Drawing.Point(57, 33);
            this.lblNameCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameCateg.Name = "lblNameCateg";
            this.lblNameCateg.Size = new System.Drawing.Size(73, 28);
            this.lblNameCateg.TabIndex = 36;
            this.lblNameCateg.Text = "Nome:";
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
            this.btnSave.Location = new System.Drawing.Point(512, 268);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 35;
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
            this.btnCancel.Location = new System.Drawing.Point(637, 268);
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
            this.picBK02.Location = new System.Drawing.Point(-5, 252);
            this.picBK02.Margin = new System.Windows.Forms.Padding(4);
            this.picBK02.Name = "picBK02";
            this.picBK02.Size = new System.Drawing.Size(791, 73);
            this.picBK02.TabIndex = 34;
            this.picBK02.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Categoria pertencente:";
            // 
            // txtCateg
            // 
            this.txtCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCateg.FormattingEnabled = true;
            this.txtCateg.Location = new System.Drawing.Point(428, 64);
            this.txtCateg.Margin = new System.Windows.Forms.Padding(4);
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(299, 28);
            this.txtCateg.TabIndex = 39;
            this.txtCateg.Text = "Categoria";
            this.txtCateg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCateg_MouseClick);
            // 
            // frmAddSubCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(776, 311);
            this.Controls.Add(this.txtCateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescriptSubCateg);
            this.Controls.Add(this.lblDescriptCateg);
            this.Controls.Add(this.txtNameSubCateg);
            this.Controls.Add(this.lblNameCateg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picBK02);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(794, 358);
            this.MinimumSize = new System.Drawing.Size(794, 358);
            this.Name = "frmAddSubCateg";
            this.Text = "faws - Adicionar Sub Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescriptSubCateg;
        private System.Windows.Forms.Label lblDescriptCateg;
        private System.Windows.Forms.TextBox txtNameSubCateg;
        private System.Windows.Forms.Label lblNameCateg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBK02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCateg;
    }
}