
namespace FAWS_WMS.Telas
{
    partial class FormContatoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContatoLogin));
            this.picBK = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lklbSuporteEmail = new System.Windows.Forms.LinkLabel();
            this.lbNomeSistemaRec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBK
            // 
            this.picBK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBK.Image = ((System.Drawing.Image)(resources.GetObject("picBK.Image")));
            this.picBK.Location = new System.Drawing.Point(0, 0);
            this.picBK.Margin = new System.Windows.Forms.Padding(4);
            this.picBK.Name = "picBK";
            this.picBK.Size = new System.Drawing.Size(348, 253);
            this.picBK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBK.TabIndex = 1;
            this.picBK.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lklbSuporteEmail
            // 
            this.lklbSuporteEmail.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lklbSuporteEmail.AutoSize = true;
            this.lklbSuporteEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lklbSuporteEmail.Location = new System.Drawing.Point(19, 174);
            this.lklbSuporteEmail.Name = "lklbSuporteEmail";
            this.lklbSuporteEmail.Size = new System.Drawing.Size(282, 20);
            this.lklbSuporteEmail.TabIndex = 0;
            this.lklbSuporteEmail.TabStop = true;
            this.lklbSuporteEmail.Text = "suportewms@fatecguarulhos.edu.br ";
            this.lklbSuporteEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lklbSuporteEmail.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lklbSuporteEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbSuporteEmail_LinkClicked);
            // 
            // lbNomeSistemaRec
            // 
            this.lbNomeSistemaRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNomeSistemaRec.AutoSize = true;
            this.lbNomeSistemaRec.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeSistemaRec.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbNomeSistemaRec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNomeSistemaRec.Location = new System.Drawing.Point(23, 100);
            this.lbNomeSistemaRec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeSistemaRec.Name = "lbNomeSistemaRec";
            this.lbNomeSistemaRec.Size = new System.Drawing.Size(278, 46);
            this.lbNomeSistemaRec.TabIndex = 35;
            this.lbNomeSistemaRec.Text = "               Precisa de Ajuda? \r\nEntre em contato através do Email:";
            // 
            // FormContatoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 253);
            this.Controls.Add(this.lklbSuporteEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNomeSistemaRec);
            this.Controls.Add(this.picBK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormContatoLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suporte";
            ((System.ComponentModel.ISupportInitialize)(this.picBK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lklbSuporteEmail;
        private System.Windows.Forms.Label lbNomeSistemaRec;
    }
}