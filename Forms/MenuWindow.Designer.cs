using ConsultorBiblia.Clases;

namespace ConsultorBiblia
{
    partial class MenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.BarPanel = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MainMenuText = new System.Windows.Forms.Label();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.ButtonWindows = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FavoriteBtn = new System.Windows.Forms.Button();
            this.ConsultaPanel = new System.Windows.Forms.Panel();
            this.ConsultaBtn = new System.Windows.Forms.Button();
            this.HistorialPanel = new System.Windows.Forms.Panel();
            this.HistorialBtn = new System.Windows.Forms.Button();
            this.MenuBtnPanel = new System.Windows.Forms.Panel();
            this.MiPerfilPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectOption = new System.Windows.Forms.Button();
            this.BarPanel.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.ButtonWindows.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ConsultaPanel.SuspendLayout();
            this.HistorialPanel.SuspendLayout();
            this.MenuBtnPanel.SuspendLayout();
            this.MiPerfilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarPanel
            // 
            this.BarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.BarPanel.Controls.Add(this.MinBtn);
            this.BarPanel.Controls.Add(this.CloseBtn);
            this.BarPanel.Controls.Add(this.MainMenuText);
            this.BarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarPanel.Location = new System.Drawing.Point(0, 0);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Size = new System.Drawing.Size(1200, 41);
            this.BarPanel.TabIndex = 0;
            this.BarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseDown);
            this.BarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseMove);
            this.BarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseUp);
            // 
            // MinBtn
            // 
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.MinBtn.Location = new System.Drawing.Point(1118, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(41, 41);
            this.MinBtn.TabIndex = 0;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinimizeWindow);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.BackgroundImage")));
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.CloseBtn.Location = new System.Drawing.Point(1159, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(41, 41);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseWin);
            // 
            // MainMenuText
            // 
            this.MainMenuText.AutoSize = true;
            this.MainMenuText.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.MainMenuText.Location = new System.Drawing.Point(12, 9);
            this.MainMenuText.Name = "MainMenuText";
            this.MainMenuText.Size = new System.Drawing.Size(142, 20);
            this.MainMenuText.TabIndex = 0;
            this.MainMenuText.Text = "Menu Principal";
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.MenuContainer.Controls.Add(this.panel4);
            this.MenuContainer.Controls.Add(this.ButtonWindows);
            this.MenuContainer.Controls.Add(this.panel2);
            this.MenuContainer.Controls.Add(this.MenuBtnPanel);
            this.MenuContainer.Controls.Add(this.Logo);
            this.MenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuContainer.Location = new System.Drawing.Point(0, 41);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(182, 759);
            this.MenuContainer.TabIndex = 1;
            // 
            // ButtonWindows
            // 
            this.ButtonWindows.Controls.Add(this.panel3);
            this.ButtonWindows.Controls.Add(this.panel1);
            this.ButtonWindows.Controls.Add(this.ConsultaPanel);
            this.ButtonWindows.Controls.Add(this.HistorialPanel);
            this.ButtonWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonWindows.Location = new System.Drawing.Point(0, 247);
            this.ButtonWindows.Name = "ButtonWindows";
            this.ButtonWindows.Size = new System.Drawing.Size(182, 227);
            this.ButtonWindows.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 45);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-30, -11);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(284, 66);
            this.button3.TabIndex = 1;
            this.button3.Text = "          Busqueda";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BusquedaBtnClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.FavoriteBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 45);
            this.panel1.TabIndex = 4;
            // 
            // FavoriteBtn
            // 
            this.FavoriteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.FavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoriteBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FavoriteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.FavoriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("FavoriteBtn.Image")));
            this.FavoriteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteBtn.Location = new System.Drawing.Point(-30, -11);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.FavoriteBtn.Size = new System.Drawing.Size(284, 66);
            this.FavoriteBtn.TabIndex = 1;
            this.FavoriteBtn.Text = "          Favoritos";
            this.FavoriteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteBtn.UseVisualStyleBackColor = false;
            this.FavoriteBtn.Click += new System.EventHandler(this.FavoritosBtnClick);
            // 
            // ConsultaPanel
            // 
            this.ConsultaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ConsultaPanel.Controls.Add(this.ConsultaBtn);
            this.ConsultaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultaPanel.Location = new System.Drawing.Point(0, 45);
            this.ConsultaPanel.Name = "ConsultaPanel";
            this.ConsultaPanel.Size = new System.Drawing.Size(182, 45);
            this.ConsultaPanel.TabIndex = 0;
            // 
            // ConsultaBtn
            // 
            this.ConsultaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.ConsultaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultaBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConsultaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.ConsultaBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConsultaBtn.Image")));
            this.ConsultaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultaBtn.Location = new System.Drawing.Point(-30, -11);
            this.ConsultaBtn.Name = "ConsultaBtn";
            this.ConsultaBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ConsultaBtn.Size = new System.Drawing.Size(284, 66);
            this.ConsultaBtn.TabIndex = 1;
            this.ConsultaBtn.Text = "          Consultas";
            this.ConsultaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultaBtn.UseVisualStyleBackColor = false;
            this.ConsultaBtn.Click += new System.EventHandler(this.ConsultaBtnClick);
            // 
            // HistorialPanel
            // 
            this.HistorialPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HistorialPanel.Controls.Add(this.HistorialBtn);
            this.HistorialPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistorialPanel.Location = new System.Drawing.Point(0, 0);
            this.HistorialPanel.Name = "HistorialPanel";
            this.HistorialPanel.Size = new System.Drawing.Size(182, 45);
            this.HistorialPanel.TabIndex = 1;
            // 
            // HistorialBtn
            // 
            this.HistorialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.HistorialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistorialBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HistorialBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.HistorialBtn.Image = ((System.Drawing.Image)(resources.GetObject("HistorialBtn.Image")));
            this.HistorialBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistorialBtn.Location = new System.Drawing.Point(-30, -11);
            this.HistorialBtn.Name = "HistorialBtn";
            this.HistorialBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.HistorialBtn.Size = new System.Drawing.Size(284, 66);
            this.HistorialBtn.TabIndex = 1;
            this.HistorialBtn.Text = "          Historial";
            this.HistorialBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistorialBtn.UseVisualStyleBackColor = false;
            this.HistorialBtn.Click += new System.EventHandler(this.HistorialClickBtn);
            // 
            // MenuBtnPanel
            // 
            this.MenuBtnPanel.Controls.Add(this.MiPerfilPanel);
            this.MenuBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBtnPanel.Location = new System.Drawing.Point(0, 174);
            this.MenuBtnPanel.Name = "MenuBtnPanel";
            this.MenuBtnPanel.Size = new System.Drawing.Size(182, 73);
            this.MenuBtnPanel.TabIndex = 0;
            // 
            // MiPerfilPanel
            // 
            this.MiPerfilPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MiPerfilPanel.Controls.Add(this.button1);
            this.MiPerfilPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiPerfilPanel.Location = new System.Drawing.Point(0, 0);
            this.MiPerfilPanel.Name = "MiPerfilPanel";
            this.MiPerfilPanel.Size = new System.Drawing.Size(182, 73);
            this.MiPerfilPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-33, -9);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(284, 98);
            this.button1.TabIndex = 1;
            this.button1.Text = "              Mi Perfil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PerfilBtnClick);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(182, 174);
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 714);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 45);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-30, -11);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(284, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "          Cerrar Sesion";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.LogOutBtnClick);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(182, 41);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1018, 759);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.selectOption);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 669);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 45);
            this.panel4.TabIndex = 3;
            // 
            // selectOption
            // 
            this.selectOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.selectOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectOption.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.selectOption.Image = ((System.Drawing.Image)(resources.GetObject("selectOption.Image")));
            this.selectOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectOption.Location = new System.Drawing.Point(-30, -11);
            this.selectOption.Name = "selectOption";
            this.selectOption.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.selectOption.Size = new System.Drawing.Size(284, 66);
            this.selectOption.TabIndex = 1;
            this.selectOption.Text = "          Configuración";
            this.selectOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectOption.UseVisualStyleBackColor = false;
            this.selectOption.Click += new System.EventHandler(this.selectOption_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.MenuContainer);
            this.Controls.Add(this.BarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuWindow";
            this.BarPanel.ResumeLayout(false);
            this.BarPanel.PerformLayout();
            this.MenuContainer.ResumeLayout(false);
            this.ButtonWindows.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ConsultaPanel.ResumeLayout(false);
            this.HistorialPanel.ResumeLayout(false);
            this.MenuBtnPanel.ResumeLayout(false);
            this.MiPerfilPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BarPanel;
        private Panel MenuContainer;
        private Panel PanelPrincipal;
        private Label MainMenuText;
        private Button CloseBtn;
        private Panel MenuBtnPanel;
        private Panel ConsultaPanel;
        private Button ConsultaBtn;
        private Panel HistorialPanel;
        private Button HistorialBtn;
        private Panel MiPerfilPanel;
        private Button button1;
        private Panel ButtonWindows;
        private Panel panel3;
        private Button button3;
        private Panel panel2;
        private Button button2;
        private PictureBox Logo;
        private Button MinBtn;
        private Panel panel1;
        private Button FavoriteBtn;
        private Panel panel4;
        private Button selectOption;
    }
}