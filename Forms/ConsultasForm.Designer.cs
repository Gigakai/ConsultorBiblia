namespace ConsultorBiblia
{
    partial class ConsultasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.librosCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capituloCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.versiculoCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addVerBtn = new System.Windows.Forms.Button();
            this.consultasDataGrid = new System.Windows.Forms.DataGridView();
            this.versiculosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVersiculoBible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addFavoriteBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 40);
            this.panel1.TabIndex = 1;
            // 
            // librosCBox
            // 
            this.librosCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.librosCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.librosCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.librosCBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.librosCBox.FormattingEnabled = true;
            this.librosCBox.Location = new System.Drawing.Point(91, 92);
            this.librosCBox.Name = "librosCBox";
            this.librosCBox.Size = new System.Drawing.Size(244, 28);
            this.librosCBox.TabIndex = 23;
            this.librosCBox.SelectedIndexChanged += new System.EventHandler(this.librosCBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Libro:";
            // 
            // capituloCBox
            // 
            this.capituloCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.capituloCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.capituloCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capituloCBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.capituloCBox.FormattingEnabled = true;
            this.capituloCBox.Location = new System.Drawing.Point(441, 92);
            this.capituloCBox.Name = "capituloCBox";
            this.capituloCBox.Size = new System.Drawing.Size(148, 28);
            this.capituloCBox.TabIndex = 25;
            this.capituloCBox.SelectedIndexChanged += new System.EventHandler(this.capituloCBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(341, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Capitulo:";
            // 
            // versiculoCBox
            // 
            this.versiculoCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.versiculoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versiculoCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versiculoCBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versiculoCBox.FormattingEnabled = true;
            this.versiculoCBox.Location = new System.Drawing.Point(699, 92);
            this.versiculoCBox.Name = "versiculoCBox";
            this.versiculoCBox.Size = new System.Drawing.Size(148, 28);
            this.versiculoCBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(595, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Versiculo:";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.searchBtn.FlatAppearance.BorderSize = 3;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Location = new System.Drawing.Point(205, 147);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(176, 44);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addVerBtn
            // 
            this.addVerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.addVerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addVerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.addVerBtn.FlatAppearance.BorderSize = 3;
            this.addVerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVerBtn.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVerBtn.Location = new System.Drawing.Point(856, 80);
            this.addVerBtn.Name = "addVerBtn";
            this.addVerBtn.Size = new System.Drawing.Size(108, 52);
            this.addVerBtn.TabIndex = 29;
            this.addVerBtn.Text = "Agregar Versiculo";
            this.addVerBtn.UseVisualStyleBackColor = false;
            this.addVerBtn.Click += new System.EventHandler(this.addVerBtn_Click_1);
            // 
            // consultasDataGrid
            // 
            this.consultasDataGrid.AllowUserToAddRows = false;
            this.consultasDataGrid.AllowUserToDeleteRows = false;
            this.consultasDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.consultasDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultasDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultasDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultasDataGrid.ColumnHeadersHeight = 42;
            this.consultasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.consultasDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.versiculosColumn,
            this.Capitulo,
            this.Libro,
            this.idVersiculoBible,
            this.SelectColumn});
            this.consultasDataGrid.EnableHeadersVisualStyles = false;
            this.consultasDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.consultasDataGrid.Location = new System.Drawing.Point(37, 209);
            this.consultasDataGrid.MultiSelect = false;
            this.consultasDataGrid.Name = "consultasDataGrid";
            this.consultasDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultasDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.consultasDataGrid.RowHeadersWidth = 51;
            this.consultasDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.consultasDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.consultasDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.consultasDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultasDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.consultasDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            this.consultasDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.consultasDataGrid.RowTemplate.Height = 29;
            this.consultasDataGrid.Size = new System.Drawing.Size(941, 516);
            this.consultasDataGrid.TabIndex = 30;
            // 
            // versiculosColumn
            // 
            this.versiculosColumn.DataPropertyName = "texto";
            this.versiculosColumn.HeaderText = "Versiculo";
            this.versiculosColumn.MinimumWidth = 6;
            this.versiculosColumn.Name = "versiculosColumn";
            this.versiculosColumn.ReadOnly = true;
            this.versiculosColumn.Width = 513;
            // 
            // Capitulo
            // 
            this.Capitulo.DataPropertyName = "numCap";
            this.Capitulo.HeaderText = "Capitulo";
            this.Capitulo.MinimumWidth = 6;
            this.Capitulo.Name = "Capitulo";
            this.Capitulo.ReadOnly = true;
            this.Capitulo.Width = 125;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "libro";
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 6;
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Width = 125;
            // 
            // idVersiculoBible
            // 
            this.idVersiculoBible.DataPropertyName = "idVers";
            this.idVersiculoBible.HeaderText = "idVersiculoBible";
            this.idVersiculoBible.MinimumWidth = 6;
            this.idVersiculoBible.Name = "idVersiculoBible";
            this.idVersiculoBible.ReadOnly = true;
            this.idVersiculoBible.Visible = false;
            this.idVersiculoBible.Width = 125;
            // 
            // SelectColumn
            // 
            this.SelectColumn.HeaderText = "Seleccionar";
            this.SelectColumn.MinimumWidth = 6;
            this.SelectColumn.Name = "SelectColumn";
            this.SelectColumn.Width = 125;
            // 
            // addFavoriteBtn
            // 
            this.addFavoriteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.addFavoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFavoriteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.addFavoriteBtn.FlatAppearance.BorderSize = 3;
            this.addFavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFavoriteBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addFavoriteBtn.Location = new System.Drawing.Point(416, 147);
            this.addFavoriteBtn.Name = "addFavoriteBtn";
            this.addFavoriteBtn.Size = new System.Drawing.Size(176, 44);
            this.addFavoriteBtn.TabIndex = 31;
            this.addFavoriteBtn.Text = "Añadir Favoritos";
            this.addFavoriteBtn.UseVisualStyleBackColor = false;
            this.addFavoriteBtn.Click += new System.EventHandler(this.addFavoriteBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.restartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.restartBtn.FlatAppearance.BorderSize = 3;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartBtn.Location = new System.Drawing.Point(619, 147);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(188, 44);
            this.restartBtn.TabIndex = 32;
            this.restartBtn.Text = "Reiniciar Consulta";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1018, 759);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.addFavoriteBtn);
            this.Controls.Add(this.consultasDataGrid);
            this.Controls.Add(this.addVerBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.versiculoCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.capituloCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.librosCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConsultasForm";
            this.Text = "ConsultasForm";
            this.Load += new System.EventHandler(this.ConsultasForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox librosCBox;
        private Label label3;
        private ComboBox capituloCBox;
        private Label label2;
        private ComboBox versiculoCBox;
        private Label label4;
        private Button searchBtn;
        private Button addVerBtn;
        private DataGridView consultasDataGrid;
        private Button addFavoriteBtn;
        private Button restartBtn;
        private DataGridViewTextBoxColumn versiculosColumn;
        private DataGridViewTextBoxColumn Capitulo;
        private DataGridViewTextBoxColumn Libro;
        private DataGridViewTextBoxColumn idVersiculoBible;
        private DataGridViewCheckBoxColumn SelectColumn;
    }
}