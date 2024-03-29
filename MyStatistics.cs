﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace appRT
{
    class MyStatistics
    {
        public void ContaRegistos(DataGridView data_stats)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string query = "select count (*) from T_registo_de_tempos";

            data_stats.Rows[0].Cells[0].Value = "Total de registos";
            //MessageBox.Show(Convert.ToString(data.BuscaDados(ligabd, query)));
            DataTable valor = data.BuscaDados(ligabd, query);
            data_stats.Rows[0].Cells[1].Value = valor.Rows[0][0];
        }

        public void ContaRegistoAno(DataGridView data_stats)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string ano = Convert.ToString(DateTime.Now.Year);
            string query = "select count (*) as ano from T_registo_de_tempos where YEAR(data) = YEAR(getdate())";

            
            //data_stats.Rows[1].Cells[0].Value = "Registos este ano";
            DataTable valor = data.BuscaDados(ligabd, query);
           // data_stats.Rows[1].Cells[1].Value = valor.Rows[0][0];
            data_stats.Rows.Add("Registos este ano", valor.Rows[0][0]);

        }

        public void ContaRegistoMes(DataGridView data_stats)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string ano = Convert.ToString(DateTime.Now.Year);
            string query = "select count (*) as ano from T_registo_de_tempos where YEAR(data) = YEAR(getdate()) and MONTH(data)=MONTH(getdate())";


            data_stats.Rows[2].Cells[0].Value = "Registos este mês";
            DataTable valor = data.BuscaDados(ligabd, query);
            data_stats.Rows[2].Cells[1].Value = valor.Rows[0][0];
        }

        public void ContaRegistoFunc(DataGridView data_stats, int cod_func, string nome_func)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string ano = Convert.ToString(DateTime.Now.Year);
            string query = "select count (*) as ano from T_registo_de_tempos where YEAR(data) = YEAR(getdate()) and MONTH(data)=MONTH(getdate()) and cod_funcionario=" + cod_func;


            data_stats.Rows[3].Cells[0].Value = nome_func + " / mês";
            DataTable valor = data.BuscaDados(ligabd, query);
            data_stats.Rows[3].Cells[1].Value = valor.Rows[0][0] + " registos";
            //MessageBox.Show(query);
        }

        public void SomaTempoFunc(DataGridView data_stats, int cod_func, string nome_func)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string query = "select sum (tempo) as ano from T_registo_de_tempos where YEAR(data) = YEAR(getdate()) and MONTH(data)=MONTH(getdate()) and cod_funcionario=" + cod_func;

            data_stats.Rows[4].Cells[0].Value = nome_func + " / mês";
            DataTable valor = data.BuscaDados(ligabd, query);
            TimeSpan horas = TimeSpan.FromMinutes(Convert.ToInt32(valor.Rows[0][0]));
            string tempo = horas.ToString(@"hh\:mm");
            data_stats.Rows[4].Cells[1].Value = valor.Rows[0][0] + " min. (" + tempo + ")";
        }

        public void ContaRegistoCliente(DataGridView data_stats, int cod_cli, string nome_cli)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string query = "select count (*) as ano from T_registo_de_tempos where YEAR(data) = YEAR(getdate()) and MONTH(data)=MONTH(getdate()) and cod_cliente=" + cod_cli;


            data_stats.Rows[5].Cells[0].Value = nome_cli + " / mês";
            DataTable valor = data.BuscaDados(ligabd, query);
            data_stats.Rows[5].Cells[1].Value = valor.Rows[0][0] + " registos";
        }

        public void SomaTempoCliente(DataGridView data_stats, int cod_cli, string nome_cli)
        {
            MyGetData data = new MyGetData();
            string ligabd = MyStringConnection.SC1;
            string query = "select sum (tempo) as ano from T_registo_de_tempos where YEAR(data) = YEAR(getdate()) and MONTH(data)=MONTH(getdate()) and cod_cliente=" + cod_cli;

            data_stats.Rows[6].Cells[0].Value = nome_cli + " / mês";
            DataTable valor = data.BuscaDados(ligabd, query);
            TimeSpan horas = TimeSpan.FromMinutes(Convert.ToInt32(valor.Rows[0][0]));
            string tempo = horas.ToString(@"hh\:mm");
            data_stats.Rows[6].Cells[1].Value = valor.Rows[0][0] + " min. (" + tempo + ")";

        }
    }
}
