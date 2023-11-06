namespace ConsultorBiblia
{
    partial class BusquedaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.testamentoCBox = new System.Windows.Forms.ComboBox();
            this.libroCBox = new System.Windows.Forms.ComboBox();
            this.addLibroBtn = new System.Windows.Forms.Button();
            this.busquedaDataGrid = new System.Windows.Forms.DataGridView();
            this.VersiculoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(463, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(295, 91);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(562, 1);
            this.panel8.TabIndex = 6;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(295, 61);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(562, 28);
            this.searchBox.TabIndex = 5;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(74, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ingresa palabras clave:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "(Separadas por coma, sin espacios)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Testamento:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(473, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Libro:";
            // 
            // testamentoCBox
            // 
            this.testamentoCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.testamentoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testamentoCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testamentoCBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testamentoCBox.FormattingEnabled = true;
            this.testamentoCBox.Location = new System.Drawing.Point(201, 142);
            this.testamentoCBox.Name = "testamentoCBox";
            this.testamentoCBox.Size = new System.Drawing.Size(244, 28);
            this.testamentoCBox.TabIndex = 21;
            this.testamentoCBox.SelectedIndexChanged += new System.EventHandler(this.testamentoCBox_SelectedIndexChanged);
            // 
            // libroCBox
            // 
            this.libroCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.libroCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.libroCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libroCBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.libroCBox.FormattingEnabled = true;
            this.libroCBox.Location = new System.Drawing.Point(541, 142);
            this.libroCBox.Name = "libroCBox";
            this.libroCBox.Size = new System.Drawing.Size(228, 28);
            this.libroCBox.TabIndex = 22;
            // 
            // addLibroBtn
            // 
            this.addLibroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.addLibroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLibroBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.addLibroBtn.FlatAppearance.BorderSize = 3;
            this.addLibroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLibroBtn.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addLibroBtn.Location = new System.Drawing.Point(796, 137);
            this.addLibroBtn.Name = "addLibroBtn";
            this.addLibroBtn.Size = new System.Drawing.Size(144, 37);
            this.addLibroBtn.TabIndex = 23;
            this.addLibroBtn.Text = "Agregar Libro";
            this.addLibroBtn.UseVisualStyleBackColor = false;
            this.addLibroBtn.Click += new System.EventHandler(this.addLibroBtn_Click);
            // 
            // busquedaDataGrid
            // 
            this.busquedaDataGrid.AllowUserToAddRows = false;
            this.busquedaDataGrid.AllowUserToDeleteRows = false;
            this.busquedaDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.busquedaDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busquedaDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.busquedaDataGrid.ColumnHeadersHeight = 29;
            this.busquedaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.busquedaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VersiculoColumn,
            this.Testamento,
            this.Libro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.busquedaDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.busquedaDataGrid.EnableHeadersVisualStyles = false;
            this.busquedaDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.busquedaDataGrid.Location = new System.Drawing.Point(58, 231);
            this.busquedaDataGrid.MultiSelect = false;
            this.busquedaDataGrid.Name = "busquedaDataGrid";
            this.busquedaDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busquedaDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.busquedaDataGrid.RowHeadersWidth = 51;
            this.busquedaDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.busquedaDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.busquedaDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.busquedaDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.busquedaDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.busquedaDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            this.busquedaDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.busquedaDataGrid.RowTemplate.Height = 29;
            this.busquedaDataGrid.Size = new System.Drawing.Size(902, 502);
            this.busquedaDataGrid.TabIndex = 24;
            // 
            // VersiculoColumn
            // 
            this.VersiculoColumn.DataPropertyName = "texto";
            this.VersiculoColumn.HeaderText = "Versiculo";
            this.VersiculoColumn.MinimumWidth = 480;
            this.VersiculoColumn.Name = "VersiculoColumn";
            this.VersiculoColumn.ReadOnly = true;
            this.VersiculoColumn.Width = 600;
            // 
            // Testamento
            // 
            this.Testamento.DataPropertyName = "testamento";
            this.Testamento.HeaderText = "Testamento";
            this.Testamento.MinimumWidth = 6;
            this.Testamento.Name = "Testamento";
            this.Testamento.ReadOnly = true;
            this.Testamento.Width = 125;
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
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.searchBtn.FlatAppearance.BorderSize = 3;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Location = new System.Drawing.Point(863, 66);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(77, 37);
            this.searchBtn.TabIndex = 25;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.restartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.restartBtn.FlatAppearance.BorderSize = 3;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBtn.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartBtn.Location = new System.Drawing.Point(74, 188);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(161, 37);
            this.restartBtn.TabIndex = 26;
            this.restartBtn.Text = "Reiniciar Busqueda";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // BusquedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1018, 759);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.busquedaDataGrid);
            this.Controls.Add(this.addLibroBtn);
            this.Controls.Add(this.libroCBox);
            this.Controls.Add(this.testamentoCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusquedaForm";
            this.Text = "BusquedaForm";
            this.Load += new System.EventHandler(this.BusquedaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel8;
        private TextBox searchBox;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox testamentoCBox;
        private ComboBox libroCBox;
        private Button addLibroBtn;
        private DataGridView busquedaDataGrid;
        private Button searchBtn;
        private Button restartBtn;
        private DataGridViewTextBoxColumn VersiculoColumn;
        private DataGridViewTextBoxColumn Testamento;
        private DataGridViewTextBoxColumn Libro;
    }
}