using ConsultorBiblia.Clases;
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
    public partial class MenuWindow : Form
    {
        static public string emailActual;
        static public string versionSeleccionada;
        bool isDraggable;
        public MenuWindow()
        {
            InitializeComponent();
            isDraggable= false;
            ProfileForm.status = "B";
            CreateForm(new ProfileForm());
        }
        public void CreateForm(Object FormActual)
        {
            if(this.PanelPrincipal.Controls.Count > 0) this.PanelPrincipal.Controls.RemoveAt(0);
            Form auxForm = FormActual as Form;
            auxForm.TopLevel = false;
            auxForm.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(auxForm);
            this.PanelPrincipal.Tag = auxForm;
            auxForm.Show();
        }
        private void BarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggable = true;
        }

        private void BarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggable = false;
        }

        private void BarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggable)
            {
                if (MousePosition.Y > 650) this.SetDesktopLocation(MousePosition.X - 400, 600);
                else this.SetDesktopLocation(MousePosition.X - 400, MousePosition.Y - 20);


            }
        }

        private void MinimizeWindow(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void CloseWin(object sender, EventArgs e)
        {
            
            this.Hide();
            Program.signInWindow.Visible=true;
        }

        private void ConsultaBtnClick(object sender, EventArgs e)
        {
            CreateForm(new ConsultasForm());
        }

        private void FavoritosBtnClick(object sender, EventArgs e)
        {
            CreateForm(new FavoriteForm());
        }

        private void HistorialClickBtn(object sender, EventArgs e)
        {
            CreateForm(new Historial());
        }

        private void PerfilBtnClick(object sender, EventArgs e)
        {
            ProfileForm.status = "B";
            CreateForm(new ProfileForm());
        }

        private void LogOutBtnClick(object sender, EventArgs e)
        {
            this.Hide();
            Program.signInWindow.Visible=true;
        }

        private void BusquedaBtnClick(object sender, EventArgs e)
        {
            CreateForm(new BusquedaForm());
            
        }

        private void selectOption_Click(object sender, EventArgs e)
        {
            Program.selectorForm.ShowDialog(this);
        }
    }
}
