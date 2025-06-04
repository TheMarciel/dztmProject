using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace dztmDesktop.Apresentacao.Settings
{
    public partial class FrmSettings : Form
    {
        public FrmMenu menu;
        public FrmHome home;
        string systerColor = @"SysterColor.dll";
        string frmcor, lblcor;
        public FrmSettings()
        {
            InitializeComponent();
            menu = Application.OpenForms["FrmMenu"] as FrmMenu;
            home = Application.OpenForms["FrmHome"] as FrmHome;
            ttMensagem.SetToolTip(btnSair, "Fechar");
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            VerificarCor();
            
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
                    toggleTema.Checked = true;
                    lblTema.Text = "Tema escuro";
                    this.BackColor = Color.Black;
                    pnButtom.BackColor = Color.Black;
                }
                else
                {
                    toggleTema.Checked = false;
                    lblTema.Text = "Tema branco";
                    this.BackColor = Color.White;
                    pnButtom.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                ler.Close();
                throw;
            }
        }

        
        private void btnSair_Click(object sender, EventArgs e)
        {
            menu.btnHome_Click(null, null);
        }
        private void toggleTema_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleTema.Checked) 
            {
                this.BackColor = Color.Black;
                pnButtom.BackColor = Color.Black;
                menu.pnLeft.BackColor = Color.FromArgb(41,41,41);
                menu.pnMenu.BackColor = Color.FromArgb(41,41,41);
                menu.btnHome.BackColor = Color.FromArgb(41,41,41);
                menu.btnConfiguracao.BackColor = Color.FromArgb(41,41,41);
                menu.pnTop.BackColor = Color.Black;
                menu.usuFoto.Image = global::ProjectDesktop.Properties.Resources.user_branco_24;
                menu.lblEmpresa.ForeColor = Color.White;
                lblTema.Text = "Tema escuro";
                GravarCor("Black");
            }
            else
            {
                this.BackColor = Color.White;
                pnButtom.BackColor = Color.White;
                menu.pnLeft.BackColor = Color.FromArgb(207, 46, 46);
                menu.pnMenu.BackColor = Color.FromArgb(207, 46, 46);
                menu.btnHome.BackColor = Color.FromArgb(207, 46, 46);
                menu.btnConfiguracao.BackColor = Color.FromArgb(207, 46, 46);
                menu.pnTop.BackColor = Color.WhiteSmoke;
                menu.usuFoto.Image = global::ProjectDesktop.Properties.Resources.user_red_24x;
                menu.lblEmpresa.ForeColor = Color.Gray;
                lblTema.Text = "Tema branco";
                GravarCor("White");
            }
        }
        private void toggleMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleMenu.Checked) 
            {
                menu.pnLeft.Visible = false;
            }else 
            {
              menu.pnLeft.Visible=true;
            }
        }
        private void GravarCor(string cor)
        {
            StreamWriter escreve = new StreamWriter($"{systerColor}");
            escreve.WriteLine($"{cor}");
            escreve.WriteLine($"#cf2e2e");
            escreve.Close();
        }
    }
}
