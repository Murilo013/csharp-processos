using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Prova
{
    class DAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDFarinha.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }
        public static void consultaUmCliente()
        {
            String aux = "select nome from TabClientes where cnpj ='" + Cliente.getCNPJ() + "'";

            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                Cliente.setNome(result.GetString(0));
            }
            else
                Erro.setMsg("CPNJ não cadastrado.");
        }

        public static void desconecta()
        {
            conn.Close();
        }
        public static void ConsultaDados()
        {
            String aux = "select * from TabVendasCliente where cnpj ='" + Cliente.getCNPJ() + "'";
            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
        }
        public static void getProximo()
        {
            Erro.setErro(false);
            if (result.Read())
            {
                VendaCliente.setToneladas(result.GetString(3));
                VendaCliente.setvalor(result.GetString(4));

            }
            else
                Erro.setErro(true);
        }

    }
}
