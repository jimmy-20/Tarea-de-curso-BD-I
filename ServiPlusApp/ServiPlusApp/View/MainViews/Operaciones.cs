using ServiPlusApp.View.SubViews;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View
{
    public partial class Operaciones : Form
    {
        string username = "Leonardo Duarte";
        string fullname;
        string rol;

        //Thread th;
        //Point frmPosition;
        //Boolean mouseAction;

        private int borderSize = 2;
        private Size formSize;

        Boolean MnCaEstado = false;
        Boolean MnOpEstado = false;
        Boolean MnReEstado = false;
        Boolean MnSeEstado = false;

        MainDesk mainDesk;
        Form activeForm = null;

        public Operaciones(string fullname, string username, string rol)
        {
            InitializeComponent();

            this.username = username;
            this.fullname = fullname;
            this.rol = rol;

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);

            lblUsername.Text = username;
            lblRol.Text = rol;
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
            lblFullname.Text = fullname;

            MnCatalogos.Height = 0;
            MnOperaciones.Height = 0;
            MnReportes.Height = 0;
            Mnseguridad.Height = 0;

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Stop();
            timer2.Stop();

            toolTip1.SetToolTip(btnCatalogos, "CATALOGOS");
            toolTip1.SetToolTip(btnOperaciones, "OPERACIONES");
            toolTip1.SetToolTip(btnReportes, "REPORTES");
            toolTip1.SetToolTip(btnSeguridad, "SEGURIDAD");
            toolTip1.Active = false;

            openChildFormInPanel(new MainDesk());
        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
         
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        //private void Welcome_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (mouseAction == true)
        //    {
        //        Location = new Point(Cursor.Position.X - frmPosition.X, Cursor.Position.Y - frmPosition.Y);
        //    }
        //}
        //private void Welcome_MouseDown(object sender, MouseEventArgs e)
        //{
        //    frmPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
        //    mouseAction = true;
        //}

        //private void Welcome_MouseUp(object sender, MouseEventArgs e)
        //{
        //    mouseAction = false;
        //}

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 270)
            {
                timer1.Start();

                MnCaEstado = false;
                MnOpEstado = false;
                MnReEstado = false;
                MnSeEstado = false;
            }
            else
            {
                timer2.Start();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LY, LX;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Se puede hacer asi
            //this.WindowState = FormWindowState.Maximized;

            //otra forma de maximizar
            //LX = this.Location.X;
            //LY = this.Location.Y;

            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            //btnMaximizar.Visible = false;
            //btnRestaurar.Visible = true;

            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //Una forma de hacerlo
            //this.WindowState = FormWindowState.Normal;

            //Una forma de hacerlo
            //this.Size = new Size(1320, 800);
            //this.Location = new Point(LX, LY);
            //btnMaximizar.Visible = true;
            //btnRestaurar.Visible = false;


            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }

            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            ColapsarMenu(btnCatalogos);
        }


        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            ColapsarMenu(btnOperaciones);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ColapsarMenu(btnReportes);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ColapsarMenu(btnSeguridad);

        }

        private void ColapsarMenu(Button btn)
        {
            switch (btn.Tag)
            {
                case "Catalogos":
                    {
                        if (MnCaEstado == false)
                        {
                            MnCaEstado = true;
                        }
                        else
                        {
                            MnCaEstado = false;
                        }

                        if (pnlMenuVertical.Width == 270)
                        {
                            if (MnCatalogos.Height == 180)
                            {
                                MnCatalogos.Height = 0;
                            }
                            else
                            {
                                MnCatalogos.Height = 180;
                            }
                        }
                        else
                        {
                            timer4.Enabled = true;
                            timer2.Start();

                        }
                        break;
                    }
                case "Operaciones":
                    {
                        if (MnOpEstado == false)
                        {
                            MnOpEstado = true;
                        }
                        else
                        {
                            MnOpEstado = false;
                        }

                        if (pnlMenuVertical.Width == 270)
                        {
                            if (MnOperaciones.Height == 90)
                            {
                                MnOperaciones.Height = 0;
                            }
                            else
                            {
                                MnOperaciones.Height = 90;
                            }
                        }
                        else
                        {
                            timer4.Enabled = true;
                            timer2.Start();

                        }
                        break;
                    }
                case "Reportes":
                    {
                        if (MnReEstado == false)
                        {
                            MnReEstado = true;
                        }
                        else
                        {
                            MnReEstado = false;
                        }

                        if (pnlMenuVertical.Width == 270)
                        {
                            if (MnReportes.Height == 90)
                            {
                                MnReportes.Height = 0;
                            }
                            else
                            {
                                MnReportes.Height = 90;
                            }
                        }
                        else
                        {
                            timer4.Enabled = true;
                            timer2.Start();

                        }
                        break;
                    }
                case "Seguridad":
                    {
                        if (MnSeEstado == false)
                        {
                            MnSeEstado = true;
                        }
                        else
                        {
                            MnSeEstado = false;
                        }

                        if (pnlMenuVertical.Width == 270)
                        {
                            if (Mnseguridad.Height == 45)
                            {
                                Mnseguridad.Height = 0;
                            }
                            else
                            {
                                Mnseguridad.Height = 45;
                            }
                        }
                        else
                        {
                            timer4.Enabled = true;
                            timer2.Start();

                        }
                        break;
                    }

                default:
                    break;
            }
        }

        #region Eventos Timer_Tick
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pnlMenuVertical.Width == 70)
            {
                timer1.Stop();
            }
            else
            {
                pnlMenuVertical.Width -= 10;
                MnCatalogos.Height -= 10;
                MnOperaciones.Height -= 10;
                MnReportes.Height -= 10;
                Mnseguridad.Height -= 10;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 270)
            {
                timer2.Stop();
            }
            else
            {
                pnlMenuVertical.Width += 5;
            }
        }



        private void timer4_Tick(object sender, EventArgs e)
        {
            if (MnCaEstado == true)
            {
                if (MnCatalogos.Height == 180)
                {
                    timer4.Stop();
                }
                else
                {
                    MnCatalogos.Height += 10;
                }
            }
            else if (MnOpEstado == true)
            {
                if (MnOperaciones.Height == 90)
                {
                    timer4.Stop();
                }
                else
                {
                    MnOperaciones.Height += 5;
                }
            }
            else if (MnReEstado == true)
            {
                if (MnReportes.Height == 90)
                {
                    timer4.Stop();
                }
                else
                {
                    MnReportes.Height += 5;
                }
            }
            else if (MnSeEstado == true)
            {
                if (Mnseguridad.Height >= 45)
                {
                    timer4.Stop();
                }
                else
                {
                    Mnseguridad.Height += 3;
                }
            }
        }

        #endregion

        private void pnlMenuVertical_SizeChanged(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 270)
            {
                toolTip1.Active = false;
            }
            else
            {
                toolTip1.Active = true;
            }
        }

        private void pnlUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            pnlUsuario.BackColor = Color.FromArgb(67, 85, 96);


        }

        private void pnlUsuario_MouseLeave(object sender, EventArgs e)
        {
            pnlUsuario.BackColor = Color.FromArgb(0, 90, 141);
        }

        private void pnlUsuario_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 270)
            {
                SubMenuUsuario.Show(pnlUsuario, new System.Drawing.Point(272, 55));
            }
            else
            {
                SubMenuUsuario.Show(pnlUsuario, new System.Drawing.Point(72, 55));
            }

        }

        private void pnlContenedor_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnlContenedor.Controls.Count == 0)
            {
                openChildFormInPanel(new MainDesk());
            }
        }

        private void Operaciones_Resize(object sender, EventArgs e)
        {
            AjustarForm();
        }

        private void AjustarForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    btnMaximizar.Visible = true;
                    btnRestaurar.Visible = false;
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
                case FormWindowState.Minimized:
                    break;
                case FormWindowState.Maximized:
                    this.Padding = new Padding(10, 10, 10, 0);
                    btnMaximizar.Visible = false;
                    btnRestaurar.Visible = true;
                    break;
                default:
                    break;
            }
        }

        #region Eventos de MnBotones

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MostrarTabla(btnVehiculos.Tag.ToString()));
        }

        private void btnMecanicos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MostrarTabla(btnMecanicos.Tag.ToString()));
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MostrarTabla(btnServicios.Tag.ToString()));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MostrarTabla(btnClientes.Tag.ToString()));
        }

        private void btnOpMantenimientos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MostrarTabla(btnOpMantenimientos.Tag.ToString()));
        }

        private void btnOpRepuestos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MostrarTabla(btnOpRepuestos.Tag.ToString()));
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MostrarTabla(btnUsuarios.Tag.ToString()));
        }
        #endregion

        #region Overridden methods  
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion

    }
}
