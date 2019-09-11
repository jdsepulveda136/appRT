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

            lbox_clientes.DataSource = tabela_aux;
            lbox_clientes.DisplayMember = "nome_cliente";
            lbox_clientes.ValueMember = "id";

            AtualizaGrid();
        }

        private void Txt_search_func_TextChanged(object sender, EventArgs e)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;

            string filtro = txt_search_func.Text;

            string query = "select * from T_funcionarios where nome_funcionario like '%" + filtro + "%'";

            DataTable tabela_aux = data.BuscaDados(ligabd, query);

            lbox_func.DataSource = tabela_aux;
            lbox_func.DisplayMember = "nome_funcionario";
            lbox_func.ValueMember = "id";

            AtualizaGrid();
        }


        //Função de actualização da gridview com os dados inseidos nas text boxes.
        private void AtualizaGrid()
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;

            string cliente = "";
            string funcionario = "";

            if (lbox_clientes.SelectedIndex >= 0 && lbox_func.SelectedIndex >= 0)
            {
                cliente = lbox_clientes.SelectedValue.ToString();
                funcionario = lbox_func.SelectedValue.ToString();

                string query = "select * from T_registo_de_tempos where cod_cliente = '" + cliente + "' and cod_funcionario = '" + funcionario + "'";

                data_registos.DataSource = data.BuscaDados(ligabd, query);
            }   
        }

        private void Lbox_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void Lbox_func_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        //Botão de remoção de registos selecionados na gridview
        private void Bt_remove_Click(object sender, EventArgs e)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;

            string reg_a_remover = data_registos.CurrentRow.Cells[0].Value.ToString();

            string query = "delete from T_registo_de_tempos where id='" + reg_a_remover + "'";

            data.BuscaDados(ligabd, query);

            AtualizaGrid();
        }

        private void Bt_update_Click(object sender, EventArgs e)
        {
            string id = data_registos.CurrentRow.Cells[0].Value.ToString();
            string cliente = data_registos.CurrentRow.Cells[1].Value.ToString();
            string func = data_registos.CurrentRow.Cells[2].Value.ToString();
            string data_ant = data_registos.CurrentRow.Cells[3].Value.ToString();
            string tempo = data_registos.CurrentRow.Cells[4].Value.ToString();
            string desc = data_registos.CurrentRow.Cells[5].Value.ToString();

            DateTime data_nova = Convert.ToDateTime(data_ant);

            string query = "update T_registo_de_tempos " +
                           $"set cod_cliente= {cliente} , cod_funcionario={func} , data= '{data_nova.ToShortDateString()}', tempo='{Convert.ToInt32(tempo)}', descritivo='{desc}' " +
                           $"where id={id}";

            //string query = "update T_registo_de_tempos " +
            //              $"set cod_cliente= {cliente} , cod_funcionario={func} , tempo={Convert.ToInt32(tempo)} , descritivo='{desc}' " +
            //              $" where id={id}";

            MessageBox.Show(query);

            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            data.BuscaDados(ligabd, query);

            AtualizaGrid();
        }

        private void Bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
