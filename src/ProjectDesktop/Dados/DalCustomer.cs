using dztmDesktop.Dados;
using FirebirdSql.Data.FirebirdClient;
using ProjectDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesktop.Dados
{
    public class DalCustomer
    {
        string query = null;
        public List<ModelCustomer> ListarCliente(string filial)
        {
			try
			{
                List<ModelCustomer> list = new List<ModelCustomer>();
                FbCommand cmd = new FbCommand();
                cmd.Connection = ConexaoMestre.conectar;
                query = "select first 10 * from wms_cliente c";
                cmd.Parameters.AddWithValue("@filial", filial);
                cmd.CommandText = query;
                ConexaoMestre.abrir();
                FbDataReader registro = cmd.ExecuteReader();

                while (registro.Read()) 
                { 
                   ModelCustomer model = new ModelCustomer();
                    if (registro["cli_codigo"] != DBNull.Value)
                        model.CliId = Convert.ToInt32(registro["cli_codigo"]);
                    if (registro["cli_nome"] != DBNull.Value)
                        model.CliNome = Convert.ToString(registro["cli_nome"]);
                    list.Add(model);
                }
                return list;
			}
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                ConexaoMestre.fechar();
            }
        }
    }
}
