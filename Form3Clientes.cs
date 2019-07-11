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
    public partial class Form3Clientes : Form
    {

        public Form3Clientes()
        {
            InitializeComponent();
        }

        private void Form3Clientes_Load(object sender, EventArgs e)
        {
            MyGetData data = new MyGetData();

            string query = "Select * from T_clientes";
            string SC = MyStringConnection.SC1;

            grid_clientes.DataSource = data.BuscaDados(SC, query);
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
