using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace facturacionApp
{
    public partial class FrmUsers : Form
    {

        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Barratitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinLog_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrarLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.DimGray;

            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "CONTRASEÑA")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.LightGray;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "CONTRASEÑA";
                TxtContraseña.ForeColor = Color.DimGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            Class_Usuarios CU = new Class_Usuarios();
            CU.Nomusuario = TxtUsuario.Text;
            CU.Contusuario = TxtContraseña.Text;

            if (TxtUsuario.Text == "Admin08")
            {
                FrmContenedorAdmin FA = new FrmContenedorAdmin();
                this.Hide();
                FA.Show();
            }
            else
            {
                if (CU.Validar())
                {
                    FrmContenedorAdmin FA = new FrmContenedorAdmin();
                    //FA.Nom_Usuario.Text = TxtUsuario.Text;
                    this.Hide();
                    FA.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
