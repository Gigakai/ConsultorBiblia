using ConsultorBiblia.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace ConsultorBiblia
{
    public partial class Form1 : Form
    {
        bool isDraggable = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(label3.Visible) label3.Visible= false;
                emailBox.ForeColor = Color.Black;
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try {
                if (label4.Visible) label4.Visible = false;
                passwordBox.ForeColor = Color.Black;
                passwordBox.UseSystemPasswordChar = true;
            }
            catch{ 
            
            }
        }

        private void userClickPanel(object sender, EventArgs e)
        {
            if(emailBox.Text == "Ingresa tu email") emailBox.SelectAll();
        }

        private void UserClickPanel2(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Contraseña") passwordBox.SelectAll();
            
        }

        private void LogIn(object sender, EventArgs e)
        {
            EnlaceDB dataBase= new EnlaceDB();
            if (dataBase.IniciarSesion(emailBox.Text, passwordBox.Text))
            {
                MenuWindow.emailActual = emailBox.Text;
                dataBase.updateTryLogIn(emailBox.Text);
                resetText();
                this.Visible = false;
                if (string.Compare(dataBase.getNumPasswords(emailBox.Text, passwordBox.Text).Rows[0][0].ToString(), "1") == 0)
                {
                    ProfileForm.status = "A";
                    new ProfileForm().ShowDialog(this);
                }
                Program.selectorForm.Show();
            } else
            {
                label3.Visible = true;
                label4.Visible = true;
                dataBase.errorPassword(emailBox.Text);
            }
            
            
        }

        private void CambiarCve(object sender, EventArgs e)
        {
            MessageBox.Show("Se cambio la contraseña");
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggable= true;
        }

        private void BarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggable = false;
        }

        private void BarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggable)
            {
                if(MousePosition.Y > 650) this.SetDesktopLocation(MousePosition.X - 400, 600);
                else this.SetDesktopLocation(MousePosition.X - 400, MousePosition.Y - 20);


            }
        }
        private void resetText()
        {
            this.emailBox.Text = "Ingresa tu email";
            this.emailBox.ForeColor = Color.Gray;
            this.passwordBox.Text = "Contraseña";
            this.passwordBox.ForeColor = Color.Gray;
            this.passwordBox.UseSystemPasswordChar= false;
        }

        private void registrateLabelClick(object sender, EventArgs e)
        {
            new SingOutForm().ShowDialog();
        }

        private void LogInPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}