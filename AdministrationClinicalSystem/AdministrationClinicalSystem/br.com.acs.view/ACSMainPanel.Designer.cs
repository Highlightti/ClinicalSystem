﻿namespace AdministrationClinicalSystem
{
    partial class ACSMainPanel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACSMainPanel));
            this.metroStyleManagerMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuariosIcon = new System.Windows.Forms.Button();
            this.btnLogoutIcon = new System.Windows.Forms.Button();
            this.BtnHomeIcon = new System.Windows.Forms.Button();
            this.BtnEquipamentosIcon = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.BtnMeusDados = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nomeUsuario = new MetroFramework.Controls.MetroLabel();
            this.Ola = new MetroFramework.Controls.MetroLabel();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnEquipamentos = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.subMenu = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManagerMain
            // 
            this.metroStyleManagerMain.Owner = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.btnUsuariosIcon);
            this.panel1.Controls.Add(this.btnLogoutIcon);
            this.panel1.Controls.Add(this.BtnHomeIcon);
            this.panel1.Controls.Add(this.BtnEquipamentosIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 520);
            this.panel1.TabIndex = 15;
            // 
            // btnUsuariosIcon
            // 
            this.btnUsuariosIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuariosIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuariosIcon.BackgroundImage")));
            this.btnUsuariosIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuariosIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUsuariosIcon.FlatAppearance.BorderSize = 0;
            this.btnUsuariosIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.btnUsuariosIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.btnUsuariosIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosIcon.Location = new System.Drawing.Point(0, 440);
            this.btnUsuariosIcon.Name = "btnUsuariosIcon";
            this.btnUsuariosIcon.Size = new System.Drawing.Size(40, 40);
            this.btnUsuariosIcon.TabIndex = 23;
            this.btnUsuariosIcon.UseVisualStyleBackColor = false;
            this.btnUsuariosIcon.Click += new System.EventHandler(this.BtnMeusDados_Click);
            // 
            // btnLogoutIcon
            // 
            this.btnLogoutIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoutIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoutIcon.BackgroundImage")));
            this.btnLogoutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoutIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogoutIcon.FlatAppearance.BorderSize = 0;
            this.btnLogoutIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.btnLogoutIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.btnLogoutIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutIcon.Location = new System.Drawing.Point(0, 480);
            this.btnLogoutIcon.Name = "btnLogoutIcon";
            this.btnLogoutIcon.Size = new System.Drawing.Size(40, 40);
            this.btnLogoutIcon.TabIndex = 22;
            this.btnLogoutIcon.UseVisualStyleBackColor = false;
            this.btnLogoutIcon.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnHomeIcon
            // 
            this.BtnHomeIcon.BackColor = System.Drawing.Color.Transparent;
            this.BtnHomeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHomeIcon.BackgroundImage")));
            this.BtnHomeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHomeIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHomeIcon.FlatAppearance.BorderSize = 0;
            this.BtnHomeIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnHomeIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnHomeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHomeIcon.Location = new System.Drawing.Point(0, 0);
            this.BtnHomeIcon.Name = "BtnHomeIcon";
            this.BtnHomeIcon.Size = new System.Drawing.Size(40, 40);
            this.BtnHomeIcon.TabIndex = 21;
            this.BtnHomeIcon.UseVisualStyleBackColor = false;
            this.BtnHomeIcon.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnEquipamentosIcon
            // 
            this.BtnEquipamentosIcon.BackColor = System.Drawing.Color.Transparent;
            this.BtnEquipamentosIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEquipamentosIcon.BackgroundImage")));
            this.BtnEquipamentosIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEquipamentosIcon.FlatAppearance.BorderSize = 0;
            this.BtnEquipamentosIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnEquipamentosIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnEquipamentosIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipamentosIcon.Location = new System.Drawing.Point(0, 40);
            this.BtnEquipamentosIcon.Name = "BtnEquipamentosIcon";
            this.BtnEquipamentosIcon.Size = new System.Drawing.Size(40, 40);
            this.BtnEquipamentosIcon.TabIndex = 18;
            this.BtnEquipamentosIcon.UseVisualStyleBackColor = false;
            this.BtnEquipamentosIcon.Click += new System.EventHandler(this.BtnEquipamentos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(20, 20);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.menu.Controls.Add(this.BtnUsuarios);
            this.menu.Controls.Add(this.btnLogout);
            this.menu.Controls.Add(this.BtnHome);
            this.menu.Controls.Add(this.BtnEquipamentos);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(60, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 520);
            this.menu.TabIndex = 16;
            this.menu.Visible = false;
            // 
            // BtnMeusDados
            // 
            this.BtnMeusDados.BackColor = System.Drawing.Color.Transparent;
            this.BtnMeusDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMeusDados.Location = new System.Drawing.Point(244, 40);
            this.BtnMeusDados.Name = "BtnMeusDados";
            this.BtnMeusDados.Size = new System.Drawing.Size(200, 40);
            this.BtnMeusDados.TabIndex = 0;
            this.BtnMeusDados.Click += new System.EventHandler(this.BtnMeusDados_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(652, 379);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 15);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Exemplo Lembrete";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(483, 379);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 15);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Lembretes para 01/06/2018";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.AutoSize = true;
            this.nomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.nomeUsuario.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomeUsuario.Location = new System.Drawing.Point(83, 31);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(46, 19);
            this.nomeUsuario.TabIndex = 19;
            this.nomeUsuario.Text = "Nome";
            this.nomeUsuario.UseCustomBackColor = true;
            this.nomeUsuario.UseCustomForeColor = true;
            this.nomeUsuario.UseStyleColors = true;
            // 
            // Ola
            // 
            this.Ola.AutoSize = true;
            this.Ola.BackColor = System.Drawing.Color.Transparent;
            this.Ola.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Ola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ola.Location = new System.Drawing.Point(483, 92);
            this.Ola.Name = "Ola";
            this.Ola.Size = new System.Drawing.Size(33, 19);
            this.Ola.TabIndex = 17;
            this.Ola.Text = "Olá,";
            this.Ola.UseCustomBackColor = true;
            this.Ola.UseCustomForeColor = true;
            this.Ola.UseStyleColors = true;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 440);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(200, 40);
            this.BtnUsuarios.TabIndex = 22;
            this.BtnUsuarios.Text = "Usuário";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnMeusDados_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 480);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Sair";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(200, 40);
            this.BtnHome.TabIndex = 20;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnEquipamentos
            // 
            this.BtnEquipamentos.BackColor = System.Drawing.Color.Transparent;
            this.BtnEquipamentos.FlatAppearance.BorderSize = 0;
            this.BtnEquipamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnEquipamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnEquipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipamentos.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquipamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEquipamentos.Location = new System.Drawing.Point(0, 40);
            this.BtnEquipamentos.Name = "BtnEquipamentos";
            this.BtnEquipamentos.Size = new System.Drawing.Size(205, 40);
            this.BtnEquipamentos.TabIndex = 17;
            this.BtnEquipamentos.Text = "Equipamentos";
            this.BtnEquipamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipamentos.UseVisualStyleBackColor = false;
            this.BtnEquipamentos.Click += new System.EventHandler(this.BtnEquipamentos_Click);
            this.BtnEquipamentos.MouseLeave += new System.EventHandler(this.BtnEquipamentos_Hover);
            this.BtnEquipamentos.MouseHover += new System.EventHandler(this.BtnEquipamentos_Hover);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.Ola);
            this.contentPanel.Controls.Add(this.metroLabel2);
            this.contentPanel.Controls.Add(this.BtnMeusDados);
            this.contentPanel.Controls.Add(this.button1);
            this.contentPanel.Controls.Add(this.subMenu);
            this.contentPanel.Controls.Add(this.metroLabel1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(60, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(938, 520);
            this.contentPanel.TabIndex = 17;
            // 
            // subMenu
            // 
            this.subMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(132)))));
            this.subMenu.Location = new System.Drawing.Point(399, 192);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(194, 113);
            this.subMenu.TabIndex = 16;
            this.subMenu.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.LimeGreen;
            this.metroLabel3.Location = new System.Drawing.Point(66, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(21, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "○";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(546, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 40);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(60, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnMeusDados_Click);
            // 
            // ACSMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 600);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenu);
            this.Name = "ACSMainPanel";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ACSMainPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManagerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu;
        private MetroFramework.Controls.MetroLabel Ola;
        private MetroFramework.Controls.MetroLabel nomeUsuario;
        private System.Windows.Forms.Button BtnEquipamentos;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnUsuariosIcon;
        private System.Windows.Forms.Button btnLogoutIcon;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button BtnHomeIcon;
        private System.Windows.Forms.Button BtnEquipamentosIcon;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel BtnMeusDados;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Panel subMenu;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

