namespace ProjectDesktop
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblSistema = new System.Windows.Forms.Label();
            this.ConfiguracaoConteiner = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pbButtom = new System.Windows.Forms.Panel();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.imgMenuCental = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimiza = new System.Windows.Forms.PictureBox();
            this.Maximized = new System.Windows.Forms.PictureBox();
            this.usuFoto = new System.Windows.Forms.PictureBox();
            this.pictBoxMenu = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.ConfiguracaoConteiner.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pbButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnLeft.Controls.Add(this.pnMenu);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Controls.Add(this.ConfiguracaoConteiner);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnLeft.MaximumSize = new System.Drawing.Size(229, 0);
            this.pnLeft.MinimumSize = new System.Drawing.Size(60, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(229, 837);
            this.pnLeft.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.pictBoxMenu);
            this.pnMenu.Controls.Add(this.lblSistema);
            this.pnMenu.ForeColor = System.Drawing.Color.White;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(229, 55);
            this.pnMenu.TabIndex = 1;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(55, 11);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(86, 28);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "Sistema";
            // 
            // ConfiguracaoConteiner
            // 
            this.ConfiguracaoConteiner.BackColor = System.Drawing.Color.Transparent;
            this.ConfiguracaoConteiner.Controls.Add(this.btnConfiguracao);
            this.ConfiguracaoConteiner.ForeColor = System.Drawing.Color.SteelBlue;
            this.ConfiguracaoConteiner.Location = new System.Drawing.Point(0, 102);
            this.ConfiguracaoConteiner.Margin = new System.Windows.Forms.Padding(0);
            this.ConfiguracaoConteiner.MaximumSize = new System.Drawing.Size(229, 187);
            this.ConfiguracaoConteiner.MinimumSize = new System.Drawing.Size(229, 47);
            this.ConfiguracaoConteiner.Name = "ConfiguracaoConteiner";
            this.ConfiguracaoConteiner.Size = new System.Drawing.Size(229, 47);
            this.ConfiguracaoConteiner.TabIndex = 13;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lblEmpresa);
            this.pnTop.Controls.Add(this.pbButtom);
            this.pnTop.Controls.Add(this.usuFoto);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(229, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1527, 55);
            this.pnTop.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpresa.Location = new System.Drawing.Point(53, 0);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(1345, 55);
            this.lblEmpresa.TabIndex = 50;
            this.lblEmpresa.Text = "Empresa";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpresa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblEmpresa_MouseDown);
            // 
            // pbButtom
            // 
            this.pbButtom.BackColor = System.Drawing.Color.Transparent;
            this.pbButtom.Controls.Add(this.Close);
            this.pbButtom.Controls.Add(this.Restaurar);
            this.pbButtom.Controls.Add(this.Minimiza);
            this.pbButtom.Controls.Add(this.Maximized);
            this.pbButtom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbButtom.Location = new System.Drawing.Point(1398, 0);
            this.pbButtom.Margin = new System.Windows.Forms.Padding(4);
            this.pbButtom.Name = "pbButtom";
            this.pbButtom.Size = new System.Drawing.Size(129, 55);
            this.pbButtom.TabIndex = 49;
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 20;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // imgMenuCental
            // 
            this.imgMenuCental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgMenuCental.Location = new System.Drawing.Point(229, 55);
            this.imgMenuCental.Margin = new System.Windows.Forms.Padding(4);
            this.imgMenuCental.Name = "imgMenuCental";
            this.imgMenuCental.Size = new System.Drawing.Size(1527, 782);
            this.imgMenuCental.TabIndex = 14;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::ProjectDesktop.Properties.Resources.icon_fechar;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(94, 12);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 18);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 37;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.Color.Transparent;
            this.Restaurar.BackgroundImage = global::ProjectDesktop.Properties.Resources.icon_restaurar;
            this.Restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Location = new System.Drawing.Point(62, 12);
            this.Restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(27, 18);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 35;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimiza
            // 
            this.Minimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimiza.BackColor = System.Drawing.Color.Transparent;
            this.Minimiza.BackgroundImage = global::ProjectDesktop.Properties.Resources.icon_minimizar;
            this.Minimiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimiza.Location = new System.Drawing.Point(25, 12);
            this.Minimiza.Margin = new System.Windows.Forms.Padding(4);
            this.Minimiza.Name = "Minimiza";
            this.Minimiza.Size = new System.Drawing.Size(27, 18);
            this.Minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimiza.TabIndex = 34;
            this.Minimiza.TabStop = false;
            this.Minimiza.Click += new System.EventHandler(this.Minimiza_Click);
            // 
            // Maximized
            // 
            this.Maximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximized.BackColor = System.Drawing.Color.Transparent;
            this.Maximized.BackgroundImage = global::ProjectDesktop.Properties.Resources.icon_maximizar;
            this.Maximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Maximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximized.Location = new System.Drawing.Point(60, 12);
            this.Maximized.Margin = new System.Windows.Forms.Padding(4);
            this.Maximized.Name = "Maximized";
            this.Maximized.Size = new System.Drawing.Size(27, 18);
            this.Maximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximized.TabIndex = 36;
            this.Maximized.TabStop = false;
            this.Maximized.Click += new System.EventHandler(this.Maximized_Click);
            // 
            // usuFoto
            // 
            this.usuFoto.BackColor = System.Drawing.Color.Transparent;
            this.usuFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usuFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.usuFoto.Image = global::ProjectDesktop.Properties.Resources.empresa_red_24x;
            this.usuFoto.Location = new System.Drawing.Point(0, 0);
            this.usuFoto.Margin = new System.Windows.Forms.Padding(4);
            this.usuFoto.Name = "usuFoto";
            this.usuFoto.Padding = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.usuFoto.Size = new System.Drawing.Size(53, 55);
            this.usuFoto.TabIndex = 48;
            this.usuFoto.TabStop = false;
            this.usuFoto.Click += new System.EventHandler(this.usuFoto_Click);
            // 
            // pictBoxMenu
            // 
            this.pictBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictBoxMenu.Image = global::ProjectDesktop.Properties.Resources.menu_32x;
            this.pictBoxMenu.Location = new System.Drawing.Point(9, 5);
            this.pictBoxMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxMenu.Name = "pictBoxMenu";
            this.pictBoxMenu.Size = new System.Drawing.Size(40, 39);
            this.pictBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxMenu.TabIndex = 2;
            this.pictBoxMenu.TabStop = false;
            this.pictBoxMenu.Click += new System.EventHandler(this.pictBoxMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::ProjectDesktop.Properties.Resources.casa;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 55);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(8, 7, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(229, 47);
            this.btnHome.TabIndex = 12;
            this.btnHome.Tag = "tgButton";
            this.btnHome.Text = "           Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracao.Image = global::ProjectDesktop.Properties.Resources.configuracao_dentada;
            this.btnConfiguracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Padding = new System.Windows.Forms.Padding(8, 7, 0, 0);
            this.btnConfiguracao.Size = new System.Drawing.Size(229, 47);
            this.btnConfiguracao.TabIndex = 7;
            this.btnConfiguracao.Text = "           Configuraçao";
            this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1756, 837);
            this.ControlBox = false;
            this.Controls.Add(this.imgMenuCental);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ConfiguracaoConteiner.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pbButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.PictureBox pictBoxMenu;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Timer sidebarTimer;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel imgMenuCental;
        public System.Windows.Forms.FlowLayoutPanel pnLeft;
        public System.Windows.Forms.Panel pnTop;
        public System.Windows.Forms.Panel pnMenu;
        public System.Windows.Forms.Button btnConfiguracao;
        public System.Windows.Forms.Panel ConfiguracaoConteiner;
        public System.Windows.Forms.PictureBox usuFoto;
        private System.Windows.Forms.Panel pbButtom;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimiza;
        private System.Windows.Forms.PictureBox Maximized;
        public System.Windows.Forms.Label lblEmpresa;
    }
}

