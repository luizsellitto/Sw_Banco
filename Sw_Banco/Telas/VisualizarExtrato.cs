using Sw_Banco.Classes;
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
    public partial class VisualizarExtrato : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        List<Extrato> extrato = new List<Extrato>();

        public VisualizarExtrato(List<Conta> nconta, List<Funcionario> nfuncionarios, int id)
        {
            InitializeComponent();
            idv = id;
            contas = nconta;
            foreach (var a in contas)
            {
                if (a.Id_con == idv)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = a.Extras;
                }
                
            }
            
        }

        private void VisualizarExtrato_Load(object sender, EventArgs e)
        {
            
        }

        private void sair_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menup menu = new Menup(contas, funcionarios, idv);
            menu.Show();
        }
    }
}
