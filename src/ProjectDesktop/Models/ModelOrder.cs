using System;

namespace dztmDesktop.Models
{
    public class ModelOrder //pedido
    {
        public string pedCodigo { get; set; }
        public DateTime pedData { get; set; }
        public int pedItens { get; set; }
        public string cliFantasia { get; set; }
        public string inicioFlow { get; set; }
        public string fimFlow { get; set; }
    }
}
