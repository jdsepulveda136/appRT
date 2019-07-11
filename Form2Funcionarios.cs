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
    public partial class Form2Funcionarios : Form
    {


        public Form2Funcionarios()
        {
            InitializeComponent();
        }

        private void Form2Funcionarios_Load(object sender, EventArgs e)
        {
            MyGetData data = new MyGetData();

            string query = "Select * from T_funcionarios";

            string SC = MyStringConnection.SC1;

            grid_funcionarios.DataSource = data.BuscaDados(SC , query);
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
