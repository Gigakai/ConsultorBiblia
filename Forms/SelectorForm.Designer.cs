namespace ConsultorBiblia
{
    partial class SelectorForm
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
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.versionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idiomaLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.titleBarPanel.Controls.Add(this.titleLabel);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(337, 37);
            this.titleBarPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(132, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Configuración";
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.idiomaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idiomaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idiomaComboBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Location = new System.Drawing.Point(53, 145);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(228, 28);
            this.idiomaComboBox.TabIndex = 1;
            this.idiomaComboBox.SelectedIndexChanged += new System.EventHandler(this.idiomaComboBox_SelectedIndexChanged);
            // 
            // versionComboBox
            // 
            this.versionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.versionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionComboBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionComboBox.FormattingEnabled = true;
            this.versionComboBox.Location = new System.Drawing.Point(53, 211);
            this.versionComboBox.Name = "versionComboBox";
            this.versionComboBox.Size = new System.Drawing.Size(228, 28);
            this.versionComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elige tu idioma y versión";
            // 
            // idiomaLabel
            // 
            this.idiomaLabel.AutoSize = true;
            this.idiomaLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idiomaLabel.Location = new System.Drawing.Point(53, 122);
            this.idiomaLabel.Name = "idiomaLabel";
            this.idiomaLabel.Size = new System.Drawing.Size(76, 20);
            this.idiomaLabel.TabIndex = 4;
            this.idiomaLabel.Text = "Idioma:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.Location = new System.Drawing.Point(53, 188);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(81, 20);
            this.versionLabel.TabIndex = 5;
            this.versionLabel.Text = "Versión:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.button1.Location = new System.Drawing.Point(53, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(337, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.idiomaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionComboBox);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.titleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectorForm";
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel titleBarPanel;
        private Label titleLabel;
        private ComboBox idiomaComboBox;
        private ComboBox versionComboBox;
        private Label label1;
        private Label idiomaLabel;
        private Label versionLabel;
        private Button button1;
    }
}