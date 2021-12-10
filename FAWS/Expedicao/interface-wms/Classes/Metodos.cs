using System.Threading;
using System.Windows.Forms;

namespace interface_wms.Classes
{
    internal class Metodos : Form
    {
        public Thread inicial
        {
            get; private set;
        }

        internal void tmsiCadastrarPedido()
        {
            inicial = new Thread(abrirjanela1);
            inicial.SetApartmentState(ApartmentState.STA);
            inicial.Start();
        }
        internal void tsmiPickingList()
        {
            inicial = new Thread(abrirjanela2);
            inicial.SetApartmentState(ApartmentState.STA);
            inicial.Start();
        }
        internal void tsmiEstoque()
        {
            inicial = new Thread(abrirjanela3);
            inicial.SetApartmentState(ApartmentState.STA);
            inicial.Start();
        }
        internal void tsmiLiberarPedido()
        {
            inicial = new Thread(abrirjanela4);
            inicial.SetApartmentState(ApartmentState.STA);
            inicial.Start();
        }
        internal void abrirjanela1()
        {
            Application.Run(new frmCadastrar());
        }
        internal void abrirjanela2()
        {
            Application.Run(new frmPickingList());
        }
        internal void abrirjanela3()
        {
            Application.Run(new frmEstoque());
        }
        internal void abrirjanela4()
        {
            Application.Run(new frmLiberar());
        }


    }
}
