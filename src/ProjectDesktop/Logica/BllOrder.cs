using dztmDesktop.Dados;
using dztmDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dztmDesktop.Logica
{
    public class BllOrder
    {
        public List<ModelOrder> StatusPedido(string filial)
        {
            DalOrder obj = new DalOrder();
            return obj.StatusPedido(filial);
        }
    }
}
