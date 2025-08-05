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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que queira sair!",
                "AVISO - Obrigado ",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
            Environment.Exit(0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.ShowDialog();
        }
    }
}
