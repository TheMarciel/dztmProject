using dztmDesktop.Logica;
using dztmDesktop.Models;
using ProjectDesktop.Logica;
using ProjectDesktop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace dztmDesktop.Apresentacao
{
    public partial class FrmHome : Form
    {
        BllCustomer bllcliente = new BllCustomer();
        BllProduct bllproduto = new BllProduct();
        BllOrder bllorder = new BllOrder();
        private int totalpedido;
        public FrmHome()
        {
            InitializeComponent();
            uI_CircleProgressBar1._percentage = 90;
            uI_CircleProgress1.Value = 90;
            uI_GradiantGauge1.Value = 90;
        }
        string systerColor = @"SysterColor.dll";
        string frmcor, lblcor;
        private void FrmHome_Load(object sender, EventArgs e)
        {
            VerificarCor();
            TopClientes();
            StatusPedidos();
            TopProdutos();
            uI_CircleProgress1.Text = uI_CircleProgress1.Value.ToString() + "%";
            uI_GradiantGauge1.Text = uI_GradiantGauge1.Value.ToString() + "%";
            lblVersao.Text = "   Versão:" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void VerificarCor()
        {
            StreamReader ler = new StreamReader(systerColor);
            try
            {

                if (ler != null)
                {
                    frmcor = Convert.ToString(ler.ReadLine());
                    lblcor = Convert.ToString(ler.ReadLine());

                    ler.Close();
                }
                
                if (frmcor.Equals("Black"))
                {
                    this.BackColor = Color.Black;
                    pnTop.BackColor = Color.Black;
                    lblVisaoGeral.ForeColor = Color.White;
                    pnPedidos.ForeColor = Color.White;
                    pnPedidos.BackColor = Color.Black;
                    pnTopClintes.BackColor = Color.Black;
                    pnStatusPedido.BackColor = Color.Black;
                    pnTopProdutos.BackColor = Color.Black;
                    pnButtom.BackColor = Color.Black;
                }
                else
                {
                    this.BackColor = Color.White;
                    pnTop.BackColor = Color.White;
                    lblVisaoGeral.ForeColor = Color.Black;
                    pnPedidos.BackColor = Color.White;
                    pnTopClintes.BackColor = Color.White;
                    pnButtom.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                ler.Close();
                throw;
            }
        }
        private void TopClientes()
        {
            try
            {
                List<ModelCustomer> list = new List<ModelCustomer>();
                list = bllcliente.ListarCliente("filial");
                //dataLista.Rows.Clear();

                //*****************
                /*foreach (var item in list)
                {
                    dataLista
                   .Rows.Add
                   (
                   );
                }*/
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void StatusPedidos()
        {
            try
            {
                List<ModelOrder> list = new List<ModelOrder>();
                list = bllorder.StatusPedido("filial");
                dataLista.Rows.Clear();

                //*****************
                foreach (var item in list)
                {
                    dataLista
                   .Rows.Add
                   (
                        item.pedData,
                        item.pedCodigo,
                        item.pedItens,
                        item.cliFantasia
                   );
                }
                
                lblTotalPedido.Text = list.Count > 1 ? $"Total de pedidos: {list.Count}" : $"Total de pedido: {list.Count}";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void TopProdutos()
        {
            try
            {
                //
                Panel topClinteLeft = new Panel();
                //topClinteLeft.BackColor = Color.FromArgb(31, 31, 31);
                //topClinteLeft.Dock = DockStyle.Left;
                pnTopClintes.Controls.Add(topClinteLeft);
                for (global::System.Int32 i = 0; i < 10; i++)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void relogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
