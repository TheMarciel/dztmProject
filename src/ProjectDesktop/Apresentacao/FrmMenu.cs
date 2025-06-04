using dztmDesktop.Apresentacao;
using dztmDesktop.Apresentacao.Settings;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dztmDesktop
{
    public partial class FrmMenu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
         );
        bool sidebarExpand;
        string systerColor = @"SysterColor.dll";
        string frmcor, lblcor;
        public FrmMenu()
        {
            InitializeComponent();
            ttMensagem.SetToolTip(Minimiza, "Minimize");
            ttMensagem.SetToolTip(Maximized, "Maximize");
            ttMensagem.SetToolTip(Restaurar, "Restaurar");
            ttMensagem.SetToolTip(Close, "Fechar");
        }

        public void FrmMenu_Load(object sender, EventArgs e)
        {
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            if (!File.Exists(systerColor))
            {
                File.Create(systerColor);
                systerColor.Clone();
            }
            
            systerColor.Clone();
            VerificarCor();
            Home();
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
                    pnTop.BackColor = Color.Black;
                    usuFoto.Image = global::ProjectDesktop.Properties.Resources.empresa_branco_24x;
                    lblEmpresa.ForeColor = Color.White;
                    pnLeft.BackColor = Color.FromArgb(41, 41, 41);
                    btnHome.BackColor = Color.FromArgb(41, 41, 41);
                    btnConfiguracao.BackColor = Color.FromArgb(41, 41, 41);
                    
                    //imgMenuCental.BackColor = Color.FromArgb(61, 61, 61);
                }
                else
                {
                    //pnMenu.BackColor = Color.FromArgb(207, 46, 46);
                    usuFoto.Image = global::ProjectDesktop.Properties.Resources.empresa_red_24x;
                    pnLeft.BackColor = Color.FromArgb(207, 46, 46);
                    lblEmpresa.ForeColor = Color.Gray;
                    btnHome.BackColor = Color.FromArgb(207, 46, 46);
                    btnConfiguracao.BackColor = Color.FromArgb(207, 46, 46);
                }
            }
            catch (Exception)
            {
                ler.Close();
                throw;
            }
        }
        public void Home()
        {
            imgMenuCental.Controls.Clear();
             try
             {
                 if (imgMenuCental.Controls.Count > 0)
                    imgMenuCental.Controls.RemoveAt(0);
                 FrmHome frm = new FrmHome();
                 frm.TopLevel = false;
                 frm.FormBorderStyle = FormBorderStyle.None;
                 frm.Dock = DockStyle.Fill;
                imgMenuCental.Controls.Add(frm);
                imgMenuCental.Tag = frm;
                 //frm.idUsuario = modeloUsuario.UsuCodigo;
                 frm.Show();
             }
             catch { }
         }
         private void Minimiza_Click(object sender, EventArgs e)
         {
             this.WindowState = FormWindowState.Minimized;
         }

         private void Restaurar_Click(object sender, EventArgs e)
         {
             this.WindowState = FormWindowState.Normal;
             Maximized.Visible = true;
             Restaurar.Visible = false;
         }

         private void Maximized_Click(object sender, EventArgs e)
         {
             WindowState = FormWindowState.Maximized;
             Maximized.Visible = false;
             Restaurar.Visible = true;
            StartPosition = FormStartPosition.Manual;
             
             //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 1, 1));
         }

         private void Close_Click(object sender, EventArgs e)
         {
             try
             {
                 string mensagem = "Gostaria de fazer logoff?";
                 if (MessageBox.Show(mensagem, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 {
                     this.Hide();
                     //Login login = new Login();
                     //login.ShowDialog();
                 }
                 else
                 {
                     Application.Exit();
                 }

             }
             catch (Exception)
             {
                 MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
             }
         }

         private void lblUsario_MouseDown(object sender, MouseEventArgs e)
         {
             
         }

         private void sidebarTimer_Tick(object sender, EventArgs e)
         {
             if (sidebarExpand)
             {
                 pnLeft.Width += 10;
                 if (pnLeft.Width == pnLeft.MaximumSize.Width)
                 {
                     sidebarExpand = false;
                     sidebarTimer.Stop();
                 }
             }
             else
             {
                 pnLeft.Width -= 10;
                 if (pnLeft.Width == pnLeft.MinimumSize.Width)
                 {
                     sidebarExpand = true;
                     sidebarTimer.Stop();
                 }
             }
         }

         private void pictBoxMenu_Click(object sender, EventArgs e)
         {
             sidebarTimer.Start();
         }

         public void btnHome_Click(object sender, EventArgs e)
         {
             Home();
         }

        private void usuFoto_Click(object sender, EventArgs e)
        {
            if(pnLeft.Visible)
                pnLeft.Visible = false;
            else
                pnLeft.Visible = true;

        }

        private void lblEmpresa_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {

            imgMenuCental.Controls.Clear();
            imgMenuCental.Dock = DockStyle.Fill;
            try
            {
                if (imgMenuCental.Controls.Count > 0)
                    imgMenuCental.Controls.RemoveAt(0);
                FrmSettings frm = new FrmSettings();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                imgMenuCental.Controls.Add(frm);
                imgMenuCental.Tag = frm;
                //frm.idUsuario = modeloUsuario.UsuCodigo;
                frm.Show();
            }
            catch { }
            
        }
    }
}
