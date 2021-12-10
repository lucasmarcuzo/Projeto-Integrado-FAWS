using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAWS_WMS.Telas
{
    public partial class FormContatoLogin : Form
    {
        public FormContatoLogin()
        {
            InitializeComponent();
            lklbSuporteEmail.Parent = picBK;
            lklbSuporteEmail.BackColor = Color.Transparent;
        }

        private void lklbSuporteEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lklbSuporteEmail.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:suportewms@fatecguarulhos.edu.br ");
        }
    }
}
