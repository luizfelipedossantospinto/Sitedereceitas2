using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitedereceitas2
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSAIR2_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.ShowDialog();
        }

        private void TXBRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNREGISTER_Click(object sender, EventArgs e)
        {
            string name = TXBNAME.Text;
            string CPF = TXBCPF.Text;
            string RG = TXBRG.Text;
            string ADDESS = TXBADDRESS.Text;
            string N = TXBN.Text;
            string TEL = TXBTEL.Text;
            string CELL = TXBCELL.Text;
            string EMAIL = TXBEMAIL.Text;

        }

        private void TXBTEL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
