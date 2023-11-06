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
    public partial class SingOutForm : Form
    {
        public SingOutForm()
        {
            InitializeComponent();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            userBox.ForeColor = Color.Black;
            errorEmail.Visible = false;
        }

        private void CloseBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genreCheck(object sender, EventArgs e)
        {
            if (maleButton.Checked == true) MessageBox.Show("Hombre");
            if (femaleButton.Checked == true) MessageBox.Show("Mujer");
        }

        
        private void emailClickPanel(object sender, EventArgs e)
        {
            if (userBox.Text == "Ingresa tu email") userBox.SelectAll();
        }

        private void passwordBtnPanel(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Crea una contraseña") passwordBox.SelectAll();
        }

        private void showBtnClick(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !passwordBox.UseSystemPasswordChar;
        }

        private void passwordTextChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.ForeColor = Color.Black;
            errorPassword.Visible = false;
        }

        private void nameBox_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "Ingresa tu nombre") nameBox.SelectAll();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            nameBox.ForeColor = Color.Black;
            errorNombre.Visible = false;
        }

        private void apellidPatTxtBox_Click(object sender, EventArgs e)
        {
            if(apellidPatTxtBox.Text == "Apellido Paterno") apellidPatTxtBox.SelectAll();
        }

        private void apellidPatTxtBox_TextChanged(object sender, EventArgs e)
        {
            apellidPatTxtBox.ForeColor = Color.Black;
            errorApellidoPat.Visible = false;
        }

        private void apellidoMatTxtBox_TextChanged(object sender, EventArgs e)
        {
            apellidoMatTxtBox.ForeColor = Color.Black;
            errorApellidoMat.Visible = false;
        }

        private void apellidoMatTxtBox_Click(object sender, EventArgs e)
        {
            if (apellidoMatTxtBox.Text == "Apellido Materno") apellidoMatTxtBox.SelectAll();
        }

        private void singUpBtn_Click(object sender, EventArgs e)
        {
            bool validUser = true;
            if (!Regex.IsMatch(userBox.Text, @"^([a-z]+)([a-z0-9\.]*)@([a-z0-9]+)((\.[a-z]{2,3})+)$")) { validUser = false; errorEmail.Visible = true; }
            if (!Regex.IsMatch(nameBox.Text, @"^([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+)(\s+([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+))*$")) { validUser = false; errorNombre.Visible = true; }
            if (!Regex.IsMatch(apellidoMatTxtBox.Text, @"^[a-zA-ZÑñÁáÉéÍíÓóÚú]{2,15}$")) { validUser = false; errorApellidoMat.Visible = true; }
            if (!Regex.IsMatch(apellidPatTxtBox.Text, @"^[a-zA-ZÑñÁáÉéÍíÓóÚú]{2,15}$")) { validUser = false; errorApellidoPat.Visible = true; }
            if (!Regex.IsMatch(passwordBox.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")) { validUser = false; errorPassword.Visible = true; }

            if (!validUser)
                return;

            EnlaceDB dataBase = new EnlaceDB();
            if(dataBase.Add_Usuario(userBox.Text, passwordBox.Text, nameBox.Text, apellidPatTxtBox.Text, apellidoMatTxtBox.Text, maleButton.Checked ? 'H' : 'M', fechaNacimientoBox.Value))
            {
                MessageBox.Show("Se registro correctamente", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBox();
            }
            
        }
        private void ClearBox()
        {
            passwordBox.Text = "Crea una contraseña";
            passwordBox.ForeColor = Color.Gray;
            passwordBox.UseSystemPasswordChar= false;
            userBox.Text = "Ingresa tu email";
            userBox.ForeColor = Color.Gray;
            apellidoMatTxtBox.Text = "Apellido Materno";
            apellidoMatTxtBox.ForeColor = Color.Gray;
            apellidPatTxtBox.Text = "Apellido Paterno";
            apellidPatTxtBox.ForeColor = Color.Gray;
            nameBox.Text = "Ingresa tu nombre";
            nameBox.ForeColor = Color.Gray;
            fechaNacimientoBox.Value = DateTime.Now;
        }
    }
}
