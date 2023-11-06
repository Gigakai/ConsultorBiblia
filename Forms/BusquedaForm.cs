using ConsultorBiblia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorBiblia
{
    public partial class BusquedaForm : Form
    {
        private string librosIngresados { get; set; }
        public BusquedaForm()
        {
            InitializeComponent();
        }

        private void BusquedaForm_Load(object sender, EventArgs e)
        {
            EnlaceDB db = new EnlaceDB();
            DataTable tabla = db.getLibros(MenuWindow.versionSeleccionada);
            if (tabla != null)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    libroCBox.Items.Add(tabla.Rows[i][0].ToString());
                }
            }
            tabla = db.getTestamento(MenuWindow.versionSeleccionada);
            if (tabla != null)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    testamentoCBox.Items.Add(tabla.Rows[i][0].ToString());
                }
            }
        }

        private void testamentoCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(testamentoCBox.SelectedIndex!= -1)
            {
                EnlaceDB db = new EnlaceDB();
                DataTable tabla = db.getTestamentoLibros(MenuWindow.versionSeleccionada, testamentoCBox.SelectedItem.ToString());
                libroCBox.Items.Clear();
                libroCBox.SelectedItem = -1;
                if (tabla != null)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        libroCBox.Items.Add(tabla.Rows[i][0].ToString());
                    }
                }
            }
            librosIngresados = string.Empty;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool validSearch = true;
            if (!Regex.IsMatch(searchBox.Text, @"^[a-zA-Z]{2,}(?:,[a-zA-Z]{2,})*$")) { validSearch = false; }
            if (validSearch && string.Compare(searchBox.Text , "Search") != 0)
            {
                EnlaceDB db= new EnlaceDB();
                DataTable versiculos;
                List<VersiculosBDTG> vers = new List<VersiculosBDTG>();

                if(testamentoCBox.SelectedIndex != -1)
                {
                    versiculos = db.getVersiculosW(MenuWindow.versionSeleccionada, searchBox.Text, testamentoCBox.SelectedItem.ToString(), librosIngresados);
                    db.AddBusquedas(MenuWindow.emailActual ,MenuWindow.versionSeleccionada, searchBox.Text, testamentoCBox.SelectedItem.ToString(), librosIngresados);
                }
                else
                {
                    versiculos = db.getVersiculosW(MenuWindow.versionSeleccionada, searchBox.Text, "", librosIngresados);
                    db.AddBusquedas(MenuWindow.emailActual, MenuWindow.versionSeleccionada, searchBox.Text, "", librosIngresados);
                }
                if (versiculos != null)
                {
                    for (int i = 0; i < versiculos.Rows.Count; i++)
                    {
                        vers.Add(new VersiculosBDTG(versiculos.Rows[i][0].ToString(), versiculos.Rows[i][1].ToString(), versiculos.Rows[i][2].ToString()));
                    }
                    
                } else
                {
                    MessageBox.Show("No hay informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                restartFunct();
                busquedaDataGrid.DataSource = vers;
            } else
            {
                MessageBox.Show("Palabras invalidas para la busqueda", "Error en busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            restartFunct();
            busquedaDataGrid.DataSource = new List<VersiculosBDTG>();
        }
        private void restartFunct()
        {
            searchBox.Text = "Search";
            searchBox.ForeColor = Color.Gray;
            testamentoCBox.SelectedIndex = -1;
            libroCBox.Items.Clear();
            libroCBox.SelectedItem = -1;
            EnlaceDB db = new EnlaceDB();
            DataTable tabla = db.getLibros(MenuWindow.versionSeleccionada);
            if (tabla != null)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    libroCBox.Items.Add(tabla.Rows[i][0].ToString());
                }
            }
            librosIngresados = string.Empty;
        }
        private void addLibroBtn_Click(object sender, EventArgs e)
        {
            if(libroCBox.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(librosIngresados))
                {
                    librosIngresados += libroCBox.SelectedItem.ToString();
                }
                else
                {
                    librosIngresados += ",";
                    librosIngresados += libroCBox.SelectedItem.ToString();
                }
                MessageBox.Show("Se agrego el libro a la busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
