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

        private void BTNREGISTER_Click(object sender, EventArgs e)
        {
            string NAME = TXBNAME.Text;
            string CPF = TXBCPF.Text;
            string RG = TXBRG.Text;
            string ADDESS = TXBADDRESS.Text;
            string N = TXBN.Text;
            string TEL = TXBTEL.Text;
            string CELL = TXBCELL.Text;
            string EMAIL = TXBEMAIL.Text;
        }

        private void BTNSAIR2_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.ShowDialog();
        }
    }
}
