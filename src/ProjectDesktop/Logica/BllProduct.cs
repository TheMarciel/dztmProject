using dztmDesktop.Dados;
using dztmDesktop.Models;
using System.Collections.Generic;

namespace dztmDesktop.Logica
{
    public class BllProduct
    {
        //**********************************************************************
        public List<ModelProduct> LocalizarProdutoCodigo(string codigo, int empresa)
        {
            DalProduct DALobj = new DalProduct();
            return DALobj.LocalizarProdutoCodigo(codigo, empresa);
        }
    }
}
