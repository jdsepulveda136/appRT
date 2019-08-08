using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRT
{
    public partial class Form4AlteracaoDeRegistos : Form
    {
        public Form4AlteracaoDeRegistos()
        {
            InitializeComponent();
        }

        private void Form4AlteracaoDeRegistos_Load(object sender, EventArgs e)
        {

        }

        private void Txt_search_cli_TextChanged(object sender, EventArgs e)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;

            string filtro = txt_search_cli.Text;

            string query = "select * from T_clientes where nome_cliente like '%" + filtro + "%'";

            DataTable tabela_aux = data.BuscaDados(ligabd, query);

            lbl_clientes.Text += tabela_aux.Columns[1].ToString();
            //cmb_funcionarios.DataSource = tabela_aux;
            //cmb_funcionarios.DisplayMember = "nome_funcionario";
            //cmb_funcionarios.ValueMember = "id";

            //list_funcionarios.DataSource = tabela_aux;
            //list_funcionarios.DisplayMember = "nome_funcionario";
        }
    }
}
