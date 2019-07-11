using System.Data;
using System.Data.SqlClient;

namespace appRT
{
    class MyGetData
    {

        public DataTable BuscaDados(string string_connection, string ssql)
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(string_connection);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = ssql ;
            //trazer dados da tab. especif. p/ uma "tab." em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);
            //desligar a conexão:
            C.Close();
            return dt;
        }


    }
}
