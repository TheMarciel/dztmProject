using dztmDesktop.Models;
using FirebirdSql.Data.FirebirdClient;
using ProjectDesktop.Models;
using System;
using System.Collections.Generic;

namespace dztmDesktop.Dados
{
    public class DalOrder
    {
        string query = null;
        public List<ModelOrder> StatusPedido(string filial)
        {
            try
            {
                List<ModelOrder> list = new List<ModelOrder>();
                FbCommand cmd = new FbCommand();
                cmd.Connection = ConexaoMestre.conectar;
                query = "select first 25 ped_data, ped_codigo,ped_itens,c.cli_fantasia,p.ped_inicio_flow_rack, "+
                         "p.ped_fim_flow_rack from wms_pedido p " +
                          "left join wms_cliente c on p.cli_id = c.cli_id";
                cmd.Parameters.AddWithValue("@filial", filial);
                cmd.CommandText = query;
                ConexaoMestre.abrir();
                FbDataReader registro = cmd.ExecuteReader();

                while (registro.Read())
                {
                    ModelOrder model = new ModelOrder();
                    if (registro["ped_data"] != DBNull.Value)
                        model.pedData = Convert.ToDateTime(registro["ped_data"]);
                    if (registro["ped_codigo"] != DBNull.Value)
                        model.pedCodigo = Convert.ToString(registro["ped_codigo"]);
                    if (registro["ped_itens"] != DBNull.Value)
                        model.pedItens = Convert.ToInt32(registro["ped_itens"]);
                    if (registro["cli_fantasia"] != DBNull.Value)
                        model.cliFantasia = Convert.ToString(registro["cli_fantasia"]);
                    //*****************
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
