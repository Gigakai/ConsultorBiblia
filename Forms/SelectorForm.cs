using ConsultorBiblia.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorBiblia
{
    public partial class SelectorForm : Form
    {
        public SelectorForm()
        {
            InitializeComponent();
            EnlaceDB dataBase = new EnlaceDB();
            DataTable idiomas = dataBase.getLanguages();
            for (int i = 0; i < idiomas.Rows.Count; i++) {
                idiomaComboBox.Items.Add(idiomas.Rows[i][0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(versionComboBox.SelectedIndex != -1)
            {
                MenuWindow.versionSeleccionada = versionComboBox.SelectedItem.ToString();
                versionComboBox.SelectedIndex = -1;
                idiomaComboBox.SelectedIndex = -1;
                versionComboBox.Items.Clear();
                Program.selectorForm.Hide();
                Program.menuWindow.CreateForm(new ProfileForm());
                Program.menuWindow.Show();
            }
            else
            {
                MessageBox.Show("No has seleccionado una versión de la biblia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void idiomaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idiomaComboBox.SelectedIndex != -1)
            {
                EnlaceDB dataBase = new EnlaceDB();
                DataTable versiones = dataBase.getVersiones(idiomaComboBox.SelectedItem.ToString());
                versionComboBox.Items.Clear();
                versionComboBox.SelectedItem = -1;
                if (versiones != null)
                {
                    for (int i = 0; i < versiones.Rows.Count; i++)
                    {
                        versionComboBox.Items.Add(versiones.Rows[i][0].ToString());
                    }
                }
                
            }
        }
    }
}
