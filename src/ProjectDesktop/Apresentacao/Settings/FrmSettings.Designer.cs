namespace dztmDesktop.Apresentacao.Settings
{
    partial class FrmSettings
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
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.toggleTema = new UIDC.UI_MaterialToggle();
            this.lblTema = new UIDC.UI_LabelMaterial();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnButtom = new System.Windows.Forms.Panel();
            this.uI_LabelMaterial1 = new UIDC.UI_LabelMaterial();
            this.toggleMenu = new UIDC.UI_MaterialToggle();
            this.pnButtom.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // toggleTema
            // 
            this.toggleTema.AutoSize = true;
            this.toggleTema.BackColor = System.Drawing.Color.Black;
            this.toggleTema.EllipseBorderColor = "#3b73d1";
            this.toggleTema.EllipseColor = "#508ef5";
            this.toggleTema.Location = new System.Drawing.Point(132, 33);
            this.toggleTema.Margin = new System.Windows.Forms.Padding(4);
            this.toggleTema.Name = "toggleTema";
            this.toggleTema.Size = new System.Drawing.Size(47, 19);
            this.toggleTema.TabIndex = 5;
            this.toggleTema.Text = "Tema escuro";
            this.toggleTema.UseVisualStyleBackColor = false;
            this.toggleTema.CheckedChanged += new System.EventHandler(this.toggleTema_CheckedChanged);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.Transparent;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTema.Location = new System.Drawing.Point(16, 32);
            this.lblTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(107, 20);
            this.lblTema.TabIndex = 29;
            this.lblTema.Text = "Tema escuro";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSair.ForeColor = System.Drawing.Color.Gray;
            this.btnSair.Image = global::ProjectDesktop.Properties.Resources.logout;
            this.btnSair.Location = new System.Drawing.Point(1401, 6);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 48);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnButtom
            // 
            this.pnButtom.BackColor = System.Drawing.Color.White;
            this.pnButtom.Controls.Add(this.btnSair);
            this.pnButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtom.Location = new System.Drawing.Point(13, 642);
            this.pnButtom.Margin = new System.Windows.Forms.Padding(4);
            this.pnButtom.Name = "pnButtom";
            this.pnButtom.Size = new System.Drawing.Size(1479, 58);
            this.pnButtom.TabIndex = 3;
            // 
            // uI_LabelMaterial1
            // 
            this.uI_LabelMaterial1.AutoSize = true;
            this.uI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent;
            this.uI_LabelMaterial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uI_LabelMaterial1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uI_LabelMaterial1.Location = new System.Drawing.Point(16, 77);
            this.uI_LabelMaterial1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uI_LabelMaterial1.Name = "uI_LabelMaterial1";
            this.uI_LabelMaterial1.Size = new System.Drawing.Size(104, 20);
            this.uI_LabelMaterial1.TabIndex = 31;
            this.uI_LabelMaterial1.Text = "Oculta menu";
            // 
            // toggleMenu
            // 
            this.toggleMenu.AutoSize = true;
            this.toggleMenu.BackColor = System.Drawing.Color.Black;
            this.toggleMenu.EllipseBorderColor = "#3b73d1";
            this.toggleMenu.EllipseColor = "#508ef5";
            this.toggleMenu.Location = new System.Drawing.Point(132, 79);
            this.toggleMenu.Margin = new System.Windows.Forms.Padding(4);
            this.toggleMenu.Name = "toggleMenu";
            this.toggleMenu.Size = new System.Drawing.Size(47, 19);
            this.toggleMenu.TabIndex = 30;
            this.toggleMenu.Text = "Tema escuro";
            this.toggleMenu.UseVisualStyleBackColor = false;
            this.toggleMenu.CheckedChanged += new System.EventHandler(this.toggleMenu_CheckedChanged);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1505, 704);
            this.Controls.Add(this.toggleMenu);
            this.Controls.Add(this.uI_LabelMaterial1);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.toggleTema);
            this.Controls.Add(this.pnButtom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSettings";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 4);
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.pnButtom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttMensagem;
        private UIDC.UI_MaterialToggle toggleTema;
        private UIDC.UI_LabelMaterial lblTema;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnButtom;
        private UIDC.UI_LabelMaterial uI_LabelMaterial1;
        private UIDC.UI_MaterialToggle toggleMenu;
    }
}