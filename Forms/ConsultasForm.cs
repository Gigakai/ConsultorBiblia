using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorBiblia.Clases;
using ConsultorBiblia.Forms;
using Microsoft.IdentityModel.Tokens;

namespace ConsultorBiblia
{
    public partial class ConsultasForm : Form
    {
        private string numeroVersiculosIngresado { get; set; }
        public ConsultasForm()
        {
            InitializeComponent();
        }

        private void addFavoriteBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConsultasForm_Load(object sender, EventArgs e)
        {
            EnlaceDB db = new EnlaceDB();
            DataTable libros = db.getLibros(MenuWindow.versionSeleccionada);
            if(libros!= null )
            {
                for (int i = 0; i < libros.Rows.Count; i++)
                {
                    librosCBox.Items.Add(libros.Rows[i][0].ToString());
                }
            }
        }

        private void librosCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(librosCBox.SelectedIndex != -1)
            {
                EnlaceDB db = new EnlaceDB();
                numeroVersiculosIngresado = string.Empty;
                DataTable capitulos = db.getCapitulos(MenuWindow.versionSeleccionada, librosCBox.SelectedItem.ToString());
                capituloCBox.Items.Clear();
                capituloCBox.SelectedItem = -1;
                versiculoCBox.Items.Clear();
                versiculoCBox.SelectedItem = -1;
                if (capitulos != null)
                {
                    for (int i = 0; i < int.Parse(capitulos.Rows[0][0].ToString()); i++)
                    {
                        capituloCBox.Items.Add((i + 1).ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No hay informacion de este libro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void capituloCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnlaceDB db = new EnlaceDB();
            DataTable numVersiculos = db.getnumVersiculos(MenuWindow.versionSeleccionada, librosCBox.SelectedItem.ToString(), capituloCBox.SelectedItem.ToString());
            versiculoCBox.Items.Clear();
            versiculoCBox.SelectedItem = -1;
            numeroVersiculosIngresado = string.Empty;
            if (numVersiculos != null)
            {
                for (int i = 0; i < int.Parse(numVersiculos.Rows[0][0].ToString()); i++)
                {
                    versiculoCBox.Items.Add((i + 1).ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay informacion de este libro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<VersiculoCDTG> versiculos = new List<VersiculoCDTG>();
            if (capituloCBox.SelectedItem != null)
            {
                EnlaceDB db = new EnlaceDB();
                DataTable numVersiculos;
                if (string.IsNullOrEmpty(numeroVersiculosIngresado))
                {
                    numVersiculos = db.getVersiculos(MenuWindow.versionSeleccionada, librosCBox.SelectedItem.ToString(), capituloCBox.SelectedItem.ToString());
                }
                else
                {
                    numVersiculos = db.getVersiculos(MenuWindow.versionSeleccionada, librosCBox.SelectedItem.ToString(), capituloCBox.SelectedItem.ToString(), numeroVersiculosIngresado);
                }

                if (numVersiculos != null)
                {
                    for (int i = 0; i < numVersiculos.Rows.Count; i++)
                    {
                        versiculos.Add(new VersiculoCDTG(numVersiculos.Rows[i][0].ToString(), numVersiculos.Rows[i][1].ToString(), numVersiculos.Rows[i][2].ToString(), numVersiculos.Rows[i][3].ToString()));
                    }
                    consultasDataGrid.DataSource = versiculos;
                } else
                {
                    consultasDataGrid.DataSource= versiculos;
                    MessageBox.Show("No hay informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                capituloCBox.Items.Clear();
                capituloCBox.SelectedItem = -1;
                versiculoCBox.Items.Clear();
                versiculoCBox.SelectedItem = -1;
                librosCBox.SelectedIndex = -1;
                numeroVersiculosIngresado = string.Empty;
            }
            else
            {
                consultasDataGrid.DataSource = versiculos;
                MessageBox.Show("Selecciona un capitulo primero antes de buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void restartBtn_Click(object sender, EventArgs e)
        {
            List<VersiculoCDTG> versiculos = new List<VersiculoCDTG>();
            consultasDataGrid.DataSource = versiculos;
            capituloCBox.Items.Clear();
            capituloCBox.SelectedItem = -1;
            versiculoCBox.Items.Clear();
            versiculoCBox.SelectedItem = -1;
            librosCBox.SelectedIndex = -1;
            numeroVersiculosIngresado = string.Empty; 
        }
        private void addVerBtn_Click_1(object sender, EventArgs e)
        {
            if (versiculoCBox.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(numeroVersiculosIngresado))
                {
                    numeroVersiculosIngresado += versiculoCBox.SelectedItem.ToString();
                }
                else
                {
                    numeroVersiculosIngresado += ",";
                    numeroVersiculosIngresado += versiculoCBox.SelectedItem.ToString();
                    
                }
                MessageBox.Show("Se agrego el versiculo a la consulta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
