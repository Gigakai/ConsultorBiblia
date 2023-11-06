namespace ConsultorBiblia
{
    partial class FavoriteForm
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.favoritosDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteFavBtn = new System.Windows.Forms.Button();
            this.VersiculoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFavorito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favoritos";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1018, 40);
            this.TitleBar.TabIndex = 1;
            // 
            // favoritosDataGrid
            // 
            this.favoritosDataGrid.AllowUserToResizeColumns = false;
            this.favoritosDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.favoritosDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.favoritosDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.favoritosDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.favoritosDataGrid.ColumnHeadersHeight = 42;
            this.favoritosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.favoritosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VersiculoColumn,
            this.idFavorito,
            this.SelectedColumn});
            this.favoritosDataGrid.EnableHeadersVisualStyles = false;
            this.favoritosDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.favoritosDataGrid.Location = new System.Drawing.Point(12, 153);
            this.favoritosDataGrid.MultiSelect = false;
            this.favoritosDataGrid.Name = "favoritosDataGrid";
            this.favoritosDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.favoritosDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.favoritosDataGrid.RowHeadersWidth = 51;
            this.favoritosDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.favoritosDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.favoritosDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.favoritosDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favoritosDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.favoritosDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            this.favoritosDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.favoritosDataGrid.RowTemplate.Height = 29;
            this.favoritosDataGrid.Size = new System.Drawing.Size(994, 581);
            this.favoritosDataGrid.TabIndex = 2;
            // 
            // deleteFavBtn
            // 
            this.deleteFavBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.deleteFavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFavBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.deleteFavBtn.FlatAppearance.BorderSize = 3;
            this.deleteFavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFavBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteFavBtn.Location = new System.Drawing.Point(51, 70);
            this.deleteFavBtn.Name = "deleteFavBtn";
            this.deleteFavBtn.Size = new System.Drawing.Size(176, 62);
            this.deleteFavBtn.TabIndex = 29;
            this.deleteFavBtn.Text = "Eliminar seleccionados";
            this.deleteFavBtn.UseVisualStyleBackColor = false;
            // 
            // VersiculoColumn
            // 
            this.VersiculoColumn.HeaderText = "Versiculo";
            this.VersiculoColumn.MinimumWidth = 6;
            this.VersiculoColumn.Name = "VersiculoColumn";
            this.VersiculoColumn.ReadOnly = true;
            this.VersiculoColumn.Width = 805;
            // 
            // idFavorito
            // 
            this.idFavorito.HeaderText = "idFavorito";
            this.idFavorito.MinimumWidth = 6;
            this.idFavorito.Name = "idFavorito";
            this.idFavorito.ReadOnly = true;
            this.idFavorito.Visible = false;
            this.idFavorito.Width = 125;
            // 
            // SelectedColumn
            // 
            this.SelectedColumn.HeaderText = "Seleccionar";
            this.SelectedColumn.MinimumWidth = 6;
            this.SelectedColumn.Name = "SelectedColumn";
            this.SelectedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectedColumn.Width = 140;
            // 
            // FavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1018, 759);
            this.Controls.Add(this.deleteFavBtn);
            this.Controls.Add(this.favoritosDataGrid);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FavoriteForm";
            this.Text = "FavoriteForm";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritosDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel TitleBar;
        private DataGridView favoritosDataGrid;
        private Button deleteFavBtn;
        private DataGridViewTextBoxColumn VersiculoColumn;
        private DataGridViewTextBoxColumn idFavorito;
        private DataGridViewCheckBoxColumn SelectedColumn;
    }
}