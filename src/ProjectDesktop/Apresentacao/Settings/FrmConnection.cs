using dztmDesktop.Models;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dztmDesktop.Apresentacao.Settings
{
    public partial class FrmConnection : Form
    {
        private Encryptacion aes = new Encryptacion();
        int Idusuario;
        private String connectionString = @"ConnectionString.xml";
        private String configuracaoBanco = @"ConfiguracaoBanco.txt";
        public FrmConnection()
        {
            InitializeComponent();
        }
        private void FrmConnection_Load(object sender, EventArgs e)
        {
          
            if (CriarConnectionString())
            {
                LerAquivo();
            }
        }
        private bool CriarConnectionString()
        {
            try
            {
                if (!File.Exists(connectionString))
                {
                    StreamWriter escreve = new StreamWriter($"{connectionString}");
                    escreve.WriteLine("<?xml version = \"1.0\" ?>");
                    escreve.WriteLine("<database DBcnString ='olá mundo'>");
                    escreve.WriteLine("</database>");
                    escreve.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Ocorreu um erro. \n Detalhes:" + ex.Message);
            }
        }

        //Ler arquivo text
        private void LerAquivo()
        {
            try
            {


                if (!File.Exists(configuracaoBanco))
                {
                    StreamWriter criar = new StreamWriter($"{configuracaoBanco}");
                    txtServidor.Text = "";
                    txtBanco.Text = "";
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    criar.Close();
                }
                else
                {
                    StreamReader ler = new StreamReader($"{configuracaoBanco}");
                    txtServidor.Text = ler.ReadLine();
                    txtBanco.Text = ler.ReadLine();
                    txtUsuario.Text = ler.ReadLine();
                    txtSenha.Text = ler.ReadLine();
                    ler.Close();
                }
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
                throw new Exception("Ocorreu um erro. \n Detalhes:" + ex.Message);
            }
        }
        //Gravar arquivo text
        private bool GravarArquivo()
        {
            try
            {
                //gravando em aquivo em txt
                StreamWriter escreve = new StreamWriter($"{configuracaoBanco}");
                escreve.WriteLine(txtServidor.Text);
                escreve.WriteLine(txtBanco.Text);
                escreve.WriteLine(txtUsuario.Text);
                escreve.WriteLine(txtSenha.Text);
                escreve.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Ocorreu um erro. \n Detalhes:" + ex.Message);
            }
        }
        private void btnListadeServidor_Click(object sender, EventArgs e)
        {
            PanelServidor.Visible = true;
           
            PanelServidor.Location = new Point(Convert.ToInt32((Width - PanelServidor.Width) / 2.0), Convert.ToInt32((Height - PanelServidor.Height) / 2.0));
        }

        

        private void btnconectar_Click(object sender, EventArgs e)
        {
            GravarArquivo();
            if (panelUsuario.Visible == false)
            {
                txtCadena.Text = @"Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBanco.Text + ";Integrated Security=True";
                probarconexion();
            }
            else
            {
                //private string strcon = @"User=SYSDBA;Password=dztm#1989@fo;Pooling=False;Database=D:\PRODUCAO\WMSDONIZETE.FDB;Datasource=192.168.1.7;Port=3050;dialect=3;";
                //txtCadena.Text = @"Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBanco.Text + ";Integrated Security=False; " + "User Id=" + txtUsuario.Text + ";Password=" + txtSenha.Text;
                txtCadena.Text = $"User={txtUsuario.Text};Password={txtSenha.Text};Pooling=False;Database={txtBanco.Text};Datasource='{txtServidor.Text}';Port=3050;dialect=3;";
                probarconexion();
            }
        }
        //Gravar arquivo text
        

        private void probarconexion()
        {
            try
            {
                FbConnection conexionManual = new FbConnection(txtCadena.Text);
                conexionManual.Open();
                FbCommand cmd = new FbCommand("Select first 1 usu_codigo from wms_usuario", conexionManual);
                Idusuario = Convert.ToInt32(cmd.ExecuteScalar());
                conexionManual.Close();
                SavetoXML(aes.Encrypt(txtCadena.Text, Desencryptacion.appPwdUnique, int.Parse("256")));
                MessageBox.Show("!Sucesso! - Volte para abrir o sistema", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception ex)
            {
                Idusuario = 0;
                MessageBox.Show($"Erro:{ex.Message}", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            PanelServidor.Visible = false;
            
        }

        private void checkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUsuario.Checked == true)
            {
                panelUsuario.Visible = true;
            }
            else
            {
                panelUsuario.Visible = false;

            }
        }
    }
}
