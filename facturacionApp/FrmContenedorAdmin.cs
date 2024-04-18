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
    public partial class FrmContenedorAdmin : Form
    {
        public FrmContenedorAdmin()
        {
            InitializeComponent();
        }

        private void PanelFormularios_Paint(object sender, PaintEventArgs e)
        {

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

        private void BtnMinLog_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirForm(Object FormHijo)
        {
            if (this.PanelFormularios.Controls.Count > 0)
                this.PanelFormularios.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            this.PanelFormularios.Controls.Add(fh);
            this.PanelFormularios.Tag = fh;
            fh.Show();
        }

        private void FrmContenedorAdmin_Load(object sender, EventArgs e)
        {
            AbrirForm(new FrmDashboard());
            BtnCuenta.Location = new Point(6, 348);
            panel5.Location = new Point(1, 348);
            BtnConfigProd.Visible = false;
            BtnConfigEmpl.Visible = false;
            BtnConfigUsu.Visible = false;
            BtnInforCuenta.Visible = false;
            BtnCerrarSesion.Visible = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmDashboard());
            BtnCuenta.Location = new Point(6, 348);
            panel5.Location = new Point(1, 348);
            BtnConfigProd.Visible = false;
            BtnConfigEmpl.Visible = false;
            BtnConfigUsu.Visible = false;
            BtnInforCuenta.Visible = false;
            BtnCerrarSesion.Visible = false;
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            if (this.PanelFormularios.Controls.Count > 0)
                this.PanelFormularios.Controls.RemoveAt(0);
            FrmFacturacion FF = new FrmFacturacion();
            FF.label7.Text = Nom_Usuario.Text;
            FF.TopLevel = false;
            this.PanelFormularios.Controls.Add(FF);
            this.PanelFormularios.Tag = FF;
            FF.Show();
            BtnCuenta.Location = new Point(6, 348);
            panel5.Location = new Point(1, 348);
            BtnConfigProd.Visible = false;
            BtnConfigEmpl.Visible = false;
            BtnConfigUsu.Visible = false;
            BtnInforCuenta.Visible = false;
            BtnCerrarSesion.Visible = false;
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmReportes());
            BtnCuenta.Location = new Point(6, 348);
            panel5.Location = new Point(1, 348);
            BtnConfigProd.Visible = false;
            BtnConfigEmpl.Visible = false;
            BtnConfigUsu.Visible = false;
            BtnInforCuenta.Visible = false;
            BtnCerrarSesion.Visible = false;
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            if (BtnConfigProd.Visible == false)
            {
                BtnCuenta.Location = new Point(6, 483);
                panel5.Location = new Point(1, 483);
                BtnConfigProd.Visible = true;
                BtnConfigEmpl.Visible = true;
                BtnConfigUsu.Visible = true;
                BtnInforCuenta.Visible = false;
                BtnCerrarSesion.Visible = false;
            }
            else
            {
                BtnCuenta.Location = new Point(6, 348);
                panel5.Location = new Point(1, 348);
                BtnConfigProd.Visible = false;
                BtnConfigEmpl.Visible = false;
                BtnConfigUsu.Visible = false;
                BtnInforCuenta.Visible = false;
                BtnCerrarSesion.Visible = false;
            }
        }

        private void BtnConfigProd_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmConfigProd());
        }

        private void BtnConfigEmpl_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmConfigEmp());
        }

        private void BtnConfigUsu_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmConfigUsu());
        }

        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            if (BtnCerrarSesion.Visible == false)
            {
                BtnCuenta.Location = new Point(6, 348);
                panel5.Location = new Point(1, 348);
                BtnCerrarSesion.Location = new Point(43, 397);
                BtnConfigProd.Visible = false;
                BtnConfigEmpl.Visible = false;
                BtnConfigUsu.Visible = false;
                BtnCerrarSesion.Visible = true;
            }
            else
            {
                BtnConfigProd.Visible = false;
                BtnConfigEmpl.Visible = false;
                BtnConfigUsu.Visible = false;
                BtnCerrarSesion.Visible = false;

            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesión? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmUsers FU = new FrmUsers();
                this.Hide();
                FU.Show();
            }
            else
            {

            }
        }

        private void BtnMax2_Click(object sender, EventArgs e)
        {
            this.Location = new Point(lx, ly);
            this.Size = new Size(sw, sh);

            BtnMax1.Visible = true;
            BtnMax2.Visible = false;
        }

        private void BtnMax1_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            BtnMax1.Visible = false;
            BtnMax2.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
    }
}
