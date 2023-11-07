using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sw_Banco.Telas
{
    public partial class TelaF : Form
    {
        public TelaF()
        {
            InitializeComponent();
        }

        private void Sair_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void CF_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarF CF = new CadastrarF();
            CF.Show();
        }

        private void CC_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarC CC = new CadastrarC();
            CC.Show();
        }
    }
}
