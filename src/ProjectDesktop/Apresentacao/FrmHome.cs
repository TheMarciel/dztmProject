using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectDesktop.Apresentacao
{
    public partial class FrmHome : Form
    {
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
