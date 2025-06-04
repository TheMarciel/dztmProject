using ProjectDesktop.Dados;
using ProjectDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesktop.Logica
{
    public class BllCustomer
    {
        public List<ModelCustomer> ListarCliente(string filial)
        {
            DalCustomer obj = new DalCustomer();
            return obj.ListarCliente(filial);
        }
    }
}
