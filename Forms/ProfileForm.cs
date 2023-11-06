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
using ConsultorBiblia.Forms;

namespace ConsultorBiblia
{
    public partial class ProfileForm : Form
    {
        static public string status { get; set; }
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                EnlaceDB dataBase = new EnlaceDB();
                DataTable usuario = dataBase.getUsuario(MenuWindow.emailActual);
                userBox.Text = usuario.Rows[0][0].ToString();
                passwordBox.Text = usuario.Rows[0][1].ToString();
                nameBox.Text = usuario.Rows[0][2].ToString();
                apellidoPatTxtBox.Text = usuario.Rows[0][3].ToString();
                apellidoMatTxtBox.Text = usuario.Rows[0][4].ToString();
                if (string.Compare(usuario.Rows[0][5].ToString(), "H", true) == 0)
                {
                    maleButton.Checked = true;
                    femaleButton.Checked = false;
                }
                else
                {
                    maleButton.Checked = false;
                    femaleButton.Checked = true;
                }
                fechaNacimientoBox.Value = DateTime.Parse(usuario.Rows[0][6].ToString());
                if(ProfileForm.status.CompareTo("A") == 0)
                {
                    nameBox.Enabled = false;
                    apellidoMatTxtBox.Enabled = false;
                    apellidoPatTxtBox.Enabled = false;
                    fechaNacimientoBox.Enabled = false;
                    maleButton.Enabled = false;
                    femaleButton.Enabled = false;
                    deleteAccountBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                fechaNacimientoBox.Value = DateTime.Now;
            }
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
        }

        private void showPassButton_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !passwordBox.UseSystemPasswordChar;
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que quieres eliminar este perfil?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EnlaceDB dataBase = new EnlaceDB();
                dataBase.deleteUsuario(MenuWindow.emailActual);
                Program.menuWindow.Hide();
                Program.signInWindow.Visible = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool validUpdate = true;
            EnlaceDB db = new EnlaceDB();
            if (string.Compare(ProfileForm.status, "A") == 0)
            {
                if (!Regex.IsMatch(passwordBox.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")) { validUpdate = false; errorPassword.Visible = true; }
                if (validUpdate)
                {
                    if (db.updatePassword(userBox.Text, passwordBox.Text))
                    {
                        this.Close();
                    }
                    
                }
               
            }
            if (string.Compare(ProfileForm.status, "B") == 0)
            {
                if (!Regex.IsMatch(userBox.Text, @"^([a-z]+)([a-z0-9\.]*)@([a-z0-9]+)((\.[a-z]{2,3})+)$")) { validUpdate = false; errorEmail.Visible = true; }
                if (!Regex.IsMatch(nameBox.Text, @"^([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+)(\s+([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+))*$")) { validUpdate = false; errorNombre.Visible = true; }
                if (!Regex.IsMatch(apellidoMatTxtBox.Text, @"^[a-zA-ZÑñÁáÉéÍíÓóÚú]{2,15}$")) { validUpdate = false; errorApellidoMat.Visible = true; }
                if (!Regex.IsMatch(apellidoPatTxtBox.Text, @"^[a-zA-ZÑñÁáÉéÍíÓóÚú]{2,15}$")) { validUpdate = false; errorApellidoPat.Visible = true; }
                if (!Regex.IsMatch(passwordBox.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")) { validUpdate = false; errorPassword.Visible = true; }
                if(validUpdate)
                {
                    if(db.updateUser(userBox.Text, passwordBox.Text, nameBox.Text, apellidoMatTxtBox.Text, apellidoPatTxtBox.Text, maleButton.Checked ? 'H' : 'M', fechaNacimientoBox.Value))
                    {
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
