using FirebirdSql.Data.FirebirdClient;
using dztmDesktop.Models;
using System;
using System.Collections.Generic;

namespace dztmDesktop.Dados
{
    public class DalProduct
    {
        string query = null;
        public List<ModelProduct> LocalizarProdutoCodigo(string codigo, int empresa)
        {
            try
            {
                List<ModelProduct > lista = new List<ModelProduct>();
                FbCommand cmd = new FbCommand();
                cmd.Connection = ConexaoMestre.conectar;
                query = "select p.prod_id,p.prod_codigo,p.prod_nome,p.prod_foto,p.prod_valorvenda, " +
                         "p.prod_valorpago,u.uni_unidade,p.prod_baixaestoque, e.est_quantidade " +
                         "from wms_produto p " +
                         "left join wms_unidade u " +
                         "on p.uni_codigo_compra = u.uni_codigo " +
                         "left join wms_estoque e " +
                         "on p.prod_id = e.prod_id " +
                         "where p.prod_codigo=@codigo and " +
                         "prod_status=@status and p.emp_codigo=@empresa;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@status", true);
                cmd.Parameters.AddWithValue("@empresa", empresa);
                cmd.CommandText = query;
                ConexaoMestre.abrir();
                FbDataReader registro = cmd.ExecuteReader();
                while (registro.Read())
                {
                    ModelProduct modelo = new ModelProduct();
                    /*
                    if (registro["prod_id"] != DBNull.Value)
                        modelo.ProdId = Convert.ToInt32(registro["prod_id"]);
                    if (registro["prod_codigo"] != DBNull.Value)
                        modelo.ProCodigo = Convert.ToString(registro["prod_codigo"]);
                    if (registro["prod_nome"] != DBNull.Value)
                        modelo.ProNome = Convert.ToString(registro["prod_nome"]);
                    if (registro["prod_foto"] != DBNull.Value)
                        modelo.ProdFoto = (byte[])registro["prod_foto"];
                    if (registro["prod_valorvenda"] != DBNull.Value)
                        modelo.ProValorVenda = Convert.ToDouble(registro["prod_valorvenda"]);
                    if (registro["prod_valorpago"] != DBNull.Value)
                        modelo.ProValorCompra = Convert.ToDouble(registro["prod_valorpago"]);
                    if (registro["uni_unidade"] != DBNull.Value)
                        modelo.undVendaDesc = Convert.ToString(registro["uni_unidade"]);
                    if (registro["prod_baixaestoque"] != DBNull.Value)
                        modelo.ProBaixaEstoque = Convert.ToBoolean(registro["prod_baixaestoque"]);
                    if (registro["est_quantidade"] != DBNull.Value)
                      
                    modelo.ProEstoque = Convert.ToDouble(registro["est_quantidade"]);
                    */

                    lista.Add(modelo);
                }
                return lista;
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
