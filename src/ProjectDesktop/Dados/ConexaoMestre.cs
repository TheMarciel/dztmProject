using FirebirdSql.Data.FirebirdClient;
using dztmDesktop.Models;
using System;
using System.Data;

namespace dztmDesktop.Dados
{
    internal class ConexaoMestre
    {
        public static string conexao = Convert.ToString(Desencryptacion.checkServer());
        public static FbConnection conectar = new FbConnection(conexao);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void fechar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
