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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            MyGetData data = new MyGetData();

            string query_clientes = "Select * from T_clientes";
            string query_funcionarios = "Select * from T_funcionarios";
            string ligabd = MyStringConnection.SC1;

            cmb_clientes.DataSource = data.BuscaDados(ligabd, query_clientes);
            cmb_clientes.DisplayMember = "nome_cliente";
            cmb_clientes.ValueMember = "id";
            cmb_clientes.SelectedValue = 1122;

            cmb_funcionarios.DataSource = data.BuscaDados(ligabd, query_funcionarios);
            cmb_funcionarios.DisplayMember = "nome_funcionario";
            cmb_funcionarios.ValueMember = "Id";
            cmb_funcionarios.SelectedValue = 10;

        }

        private void Form1_Load(object sender, EventArgs e){}

        private void Chamar_clientes_Click(object sender, EventArgs e)
        {
            Form3Clientes f3 = new Form3Clientes();

            f3.BackColor = Color.Azure;
            f3.ShowDialog();
        }

        private void Chamar_funcionarios_Click(object sender, EventArgs e)
        {
            Form2Funcionarios f2 = new Form2Funcionarios();

            f2.BackColor = Color.LightSeaGreen;
            f2.ShowDialog();
        }

        private void Bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3Clientes f3 = new Form3Clientes();

            f3.BackColor = Color.Azure;
            f3.ShowDialog();
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Funcionarios f2 = new Form2Funcionarios();

            f2.BackColor = Color.LightSeaGreen;
            f2.ShowDialog();
        }

        private void Cmb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_lista();
            //MyGetData data = new MyGetData();

            //string cliente = cmb_clientes.SelectedValue.ToString();

            //string query = "Select * from T_registo_de_tempos where cod_cliente='" + cliente + "'";

            ////MessageBox.Show(Convert.ToString(query));

            //string ligabd = MyStringConnection.SC1;

            //data_tempos.DataSource = data.BuscaDados(ligabd, query);

        }

        private void Txt_filtrar_clientes_TextChanged(object sender, EventArgs e)
        {
            
            if (cmb_clientes.Text != "")
            {
                MyGetData data = new MyGetData();
                string ligabd = MyStringConnection.SC1;

                string filtro = txt_filtrar_clientes.Text;

                string query = "select * from T_clientes where nome_cliente like '%" + filtro + "%'";

                DataTable tabela_aux = data.BuscaDados(ligabd, query);

                cmb_clientes.DataSource = tabela_aux;
                cmb_clientes.DisplayMember = "nome_cliente";
                cmb_clientes.ValueMember = "id";
            }


        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        private void Cmb_funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_lista();
            //MyGetData data = new MyGetData();

            //string funcionario = cmb_funcionarios.SelectedValue.ToString();

            //string query = "Select * from T_registo_de_tempos where cod_funcionario='" + funcionario + "'";

            ////MessageBox.Show(Convert.ToString(query));

            //string ligabd = MyStringConnection.SC1;

            //data_tempos.DataSource = data.BuscaDados(ligabd, query);
        }

        private void Txt_funcionarios_TextChanged_1(object sender, EventArgs e)
        {

            if (cmb_funcionarios.Text != "")
            {
                MyGetData data = new MyGetData();
                string ligabd = MyStringConnection.SC1;

                string filtro = txt_funcionarios.Text;

                string query = "select * from T_funcionarios where nome_funcionario like '%" + filtro + "%'";

                DataTable tabela_aux = data.BuscaDados(ligabd, query);

                cmb_funcionarios.DataSource = tabela_aux;
                cmb_funcionarios.DisplayMember = "nome_funcionario";
                cmb_funcionarios.ValueMember = "id";
            }
        }


        //função filtras lista
        public void Filtrar_lista()
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string cmb_func = "";
            
            try
            {
                cmb_func = cmb_funcionarios.SelectedValue.ToString();
            }
            catch (Exception)
            {

                cmb_func = "0";
            }

            string cmb_cli = cmb_clientes.SelectedValue.ToString();

            string query = "Select Id as Código, cod_cliente as Cliente, cod_funcionario as Funcionário, data as Data, tempo as Duração, descritivo as Descrição from T_registo_de_tempos where cod_cliente= '" + cmb_cli + "' and cod_funcionario= '" + cmb_func + "'";

            data_tempos.DataSource = data.BuscaDados(ligabd, query);

        }

        private void Txt_total_minutos_TextChanged(object sender, EventArgs e){}

        private void Button1_Click(object sender, EventArgs e)
        {
            float soma = 0;

            for (int i = 0; i < data_tempos.Rows.Count; i++)
            {
                soma = soma + Convert.ToInt16(data_tempos.Rows[i].Cells[4].Value);
            }

            txt_total_minutos.Text = Convert.ToString(soma);
        }

        private void Bt_tot_min_mensal_Click(object sender, EventArgs e)
        {
            DateTime mes_grid;
            DateTime mes_hoje = DateTime.Now;
            float soma = 0;

            for (int i = 0; i < data_tempos.Rows.Count; i++)
            {
                //d = Convert.ToDateTime(grid.Rows[i].Cells[3].Value);
                mes_grid = Convert.ToDateTime(data_tempos.Rows[i].Cells[3].Value);
                if (mes_hoje.Month==mes_grid.Month)
                {
                    soma = soma + Convert.ToInt16(data_tempos.Rows[i].Cells[4].Value);
                }
            }

            txt_min_mensal.Text = Convert.ToString(soma);
        }

        private void Bt_stats_Click(object sender, EventArgs e)
        {
            MyStatistics stats = new MyStatistics();

            int cod_func = Convert.ToInt32(cmb_funcionarios.SelectedValue);
            string nome_func = Convert.ToString(cmb_funcionarios.Text);
            int cod_cli = Convert.ToInt32(cmb_clientes.SelectedValue);
            string nome_cli = Convert.ToString(cmb_clientes.Text);



            data_stats.Rows.Add();
            stats.ContaRegistos(data_stats);
            data_stats.Rows.Add();
            stats.ContaRegistoAno(data_stats);
            data_stats.Rows.Add();
            stats.ContaRegistoMes(data_stats);
            data_stats.Rows.Add();
            stats.ContaRegistoFunc(data_stats, cod_func, nome_func);
            data_stats.Rows.Add();
            stats.SomaTempoFunc(data_stats, cod_func, nome_func);
            data_stats.Rows.Add();
            stats.ContaRegistoCliente(data_stats, cod_cli, nome_cli);

        }
    }
}
