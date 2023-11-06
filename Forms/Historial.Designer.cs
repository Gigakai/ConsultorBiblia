namespace ConsultorBiblia
{
    partial class Historial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteHistorialBtn = new System.Windows.Forms.Button();
            this.deleteHistBtn = new System.Windows.Forms.Button();
            this.historialDataGrid = new System.Windows.Forms.DataGridView();
            this.PalabrasClaveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestamentoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibrosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionarColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ResearchBtnColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1018, 40);
            this.TitleBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            // 
            // deleteHistorialBtn
            // 
            this.deleteHistorialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.deleteHistorialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteHistorialBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.deleteHistorialBtn.FlatAppearance.BorderSize = 3;
            this.deleteHistorialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteHistorialBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteHistorialBtn.Location = new System.Drawing.Point(63, 74);
            this.deleteHistorialBtn.Name = "deleteHistorialBtn";
            this.deleteHistorialBtn.Size = new System.Drawing.Size(176, 58);
            this.deleteHistorialBtn.TabIndex = 30;
            this.deleteHistorialBtn.Text = "Eliminar seleccionados";
            this.deleteHistorialBtn.UseVisualStyleBackColor = false;
            // 
            // deleteHistBtn
            // 
            this.deleteHistBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.deleteHistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteHistBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.deleteHistBtn.FlatAppearance.BorderSize = 3;
            this.deleteHistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteHistBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteHistBtn.Location = new System.Drawing.Point(260, 74);
            this.deleteHistBtn.Name = "deleteHistBtn";
            this.deleteHistBtn.Size = new System.Drawing.Size(176, 58);
            this.deleteHistBtn.TabIndex = 31;
            this.deleteHistBtn.Text = "Borrar Historial";
            this.deleteHistBtn.UseVisualStyleBackColor = false;
            // 
            // historialDataGrid
            // 
            this.historialDataGrid.AllowUserToResizeColumns = false;
            this.historialDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.historialDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historialDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historialDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.historialDataGrid.ColumnHeadersHeight = 42;
            this.historialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historialDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PalabrasClaveColumn,
            this.TestamentoColumn,
            this.idBusqueda,
            this.LibrosColumn,
            this.fechaBusqueda,
            this.SeleccionarColumn,
            this.ResearchBtnColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historialDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.historialDataGrid.EnableHeadersVisualStyles = false;
            this.historialDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.historialDataGrid.Location = new System.Drawing.Point(29, 161);
            this.historialDataGrid.Name = "historialDataGrid";
            this.historialDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(50)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historialDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.historialDataGrid.RowHeadersWidth = 51;
            this.historialDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.historialDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.historialDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.historialDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historialDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.historialDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(239)))));
            this.historialDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.historialDataGrid.RowTemplate.Height = 29;
            this.historialDataGrid.Size = new System.Drawing.Size(956, 541);
            this.historialDataGrid.TabIndex = 32;
            this.historialDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historialDataGrid_CellContentClick);
            // 
            // PalabrasClaveColumn
            // 
            this.PalabrasClaveColumn.HeaderText = "Palabras Clave";
            this.PalabrasClaveColumn.MinimumWidth = 6;
            this.PalabrasClaveColumn.Name = "PalabrasClaveColumn";
            this.PalabrasClaveColumn.ReadOnly = true;
            this.PalabrasClaveColumn.Width = 250;
            // 
            // TestamentoColumn
            // 
            this.TestamentoColumn.HeaderText = "Testamento";
            this.TestamentoColumn.MinimumWidth = 6;
            this.TestamentoColumn.Name = "TestamentoColumn";
            this.TestamentoColumn.Width = 130;
            // 
            // idBusqueda
            // 
            this.idBusqueda.HeaderText = "idBusqueda";
            this.idBusqueda.MinimumWidth = 6;
            this.idBusqueda.Name = "idBusqueda";
            this.idBusqueda.ReadOnly = true;
            this.idBusqueda.Visible = false;
            this.idBusqueda.Width = 125;
            // 
            // LibrosColumn
            // 
            this.LibrosColumn.HeaderText = "Libros";
            this.LibrosColumn.MinimumWidth = 6;
            this.LibrosColumn.Name = "LibrosColumn";
            this.LibrosColumn.ReadOnly = true;
            this.LibrosColumn.Width = 170;
            // 
            // fechaBusqueda
            // 
            this.fechaBusqueda.HeaderText = "Fecha";
            this.fechaBusqueda.MinimumWidth = 6;
            this.fechaBusqueda.Name = "fechaBusqueda";
            this.fechaBusqueda.ReadOnly = true;
            this.fechaBusqueda.Width = 150;
            // 
            // SeleccionarColumn
            // 
            this.SeleccionarColumn.HeaderText = "Seleccionar";
            this.SeleccionarColumn.MinimumWidth = 6;
            this.SeleccionarColumn.Name = "SeleccionarColumn";
            this.SeleccionarColumn.Width = 125;
            // 
            // ResearchBtnColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ResearchBtnColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ResearchBtnColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResearchBtnColumn.HeaderText = "Repetir";
            this.ResearchBtnColumn.MinimumWidth = 6;
            this.ResearchBtnColumn.Name = "ResearchBtnColumn";
            this.ResearchBtnColumn.Text = "Repetir";
            this.ResearchBtnColumn.UseColumnTextForButtonValue = true;
            this.ResearchBtnColumn.Width = 77;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1018, 759);
            this.Controls.Add(this.historialDataGrid);
            this.Controls.Add(this.deleteHistBtn);
            this.Controls.Add(this.deleteHistorialBtn);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TitleBar;
        private Label label1;
        private Button deleteHistorialBtn;
        private Button deleteHistBtn;
        private DataGridView historialDataGrid;
        private DataGridViewTextBoxColumn PalabrasClaveColumn;
        private DataGridViewTextBoxColumn TestamentoColumn;
        private DataGridViewTextBoxColumn idBusqueda;
        private DataGridViewTextBoxColumn LibrosColumn;
        private DataGridViewTextBoxColumn fechaBusqueda;
        private DataGridViewCheckBoxColumn SeleccionarColumn;
        private DataGridViewButtonColumn ResearchBtnColumn;
    }
}