using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGS {
    public partial class FormPage : Form {
        public FormPage(String form) {
            formRender = form;
            InitializeComponent();
            Render();
            CollapseMenu();

            lbl_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");

            this.Padding = new Padding(borderSize); // Border Size
            this.BackColor = Color.FromArgb(237, 245, 255); // Border Color

            formPart = 1;
        }

        //Classes
        MainController mainController = new MainController();
        AuthenticateController authenticateController = new AuthenticateController();


        // Fields
        private int borderSize = 2;
        private string formRender;
        private int formPart = 1;


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        // Overridden Methods
        protected override void WndProc(ref Message m) {
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
            if (m.Msg == WM_NCHITTEST) { //If the windows m is WM_NCHITTEST
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
                        } else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                          {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        } else {
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

            // Remove the border
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1){
                return;
            }
            base.WndProc(ref m);
        }

        //Resize Form
        // Events Methods
        private void Home_Resize(object sender, EventArgs e) {
            AdjustForm();
        }

        // Private Methods
        private void AdjustForm() {
            switch (this.WindowState) {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize) {
                        this.Padding = new Padding(borderSize);
                    }
                break;
            }
        }


        //Header
        private void pnl_TitleBar_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Close_Click(object sender, EventArgs e) {
            mainController.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e) {
            mainController.Maximize(ActiveForm);
        }

        private void btn_Minimize_Click(object sender, EventArgs e) {
            mainController.Minimize(ActiveForm);
        }

        
        //Menu
        private void CollapseMenu() {
            if (this.pnl_Menu.Width > 200) { // Collapse Menu
                pnl_Menu.Width = 100;
                img_LogoMenu.Visible = false;
                btn_MenuHamburger.Dock = DockStyle.Top;
                foreach (Button menuButton in pnl_Menu.Controls.OfType<Button>()) {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            } else { // Expand Menu
                pnl_Menu.Width = 230;
                img_LogoMenu.Visible = true;
                btn_MenuHamburger.Dock = DockStyle.None;
                foreach (Button menuButton in pnl_Menu.Controls.OfType<Button>()) {
                    menuButton.Text = "  " +  menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btn_MenuHamburger_Click(object sender, EventArgs e) {
            CollapseMenu();
        }

        private void btn_MenuCalendar_Click(object sender, EventArgs e) {
            mainController.AlterPage(ActiveForm, "calendar");
        }

        private void btn_MenuChat_Click(object sender, EventArgs e) {
            mainController.AlterPage(null, "chat");
        }

        private void btn_MenuPacientes_Click(object sender, EventArgs e) {
            mainController.AlterPage(ActiveForm, "patients");
        }

        private void btn_MenuOptions_Click(object sender, EventArgs e) {
            mainController.AlterPage(ActiveForm, "options");
        }

        private void btn_MenuLogout_Click(object sender, EventArgs e) {
            authenticateController.Logout(ActiveForm);
        }


        private void Render() {
            lbl_TitlePart.Visible = false;
            lbl_TitlePart.Visible = false;
            lbl_Title1.Visible = true;
            txt_Input2.Visible = true;
            lbl_Title2.Visible = true;
            txt_Input2.Visible = true;
            lbl_Title3.Visible = true;
            txt_Input3.Visible = true;
            lbl_Title4.Visible = true;
            txt_Input4.Visible = true;
            lbl_Title5.Visible = true;
            txt_Input5.Visible = true;
            lbl_Title6.Visible = true;
            txt_Input6.Visible = true;
            lbl_Title7.Visible = true;
            txt_Input7.Visible = true;
            lbl_Title8.Visible = true;
            txt_Input8.Visible = true;
            lbl_Title9.Visible = true;
            txt_Input9.Visible = true;
            lbl_Part.Visible   = true;
            btn_Back.Visible   = false;
            btn_Forward.Text = "Cadastrar";

            switch (formRender) {
                case "employees":
                    lbl_Title.Text = "Cadastro de Funcionários";
                    lbl_Title1.Text = "Nome";
                    lbl_Title2.Text = "Data de Nascimento";
                    lbl_Title3.Text = "E-mail";
                    lbl_Title4.Text = "Gênero";
                    lbl_Title5.Text = "CRO";
                    lbl_Title6.Text = "RG";
                    lbl_Title7.Text = "CPF";
                    lbl_Title8.Text = "Estado Civil";
                    lbl_Title9.Text = "Especialidade";
                    lbl_Part.Visible = false;
                    break;
                case "consults-category":
                    lbl_Title.Text = "Cadastro de Categoria de Consulta";
                    lbl_Title1.Text = "Título da Categoria";
                    lbl_Title2.Visible = false;
                    txt_Input2.Visible = false;
                    lbl_Title3.Visible = false;
                    txt_Input3.Visible = false;
                    lbl_Title4.Visible = false;
                    txt_Input4.Visible = false;
                    lbl_Title5.Visible = false;
                    txt_Input5.Visible = false;
                    lbl_Title6.Visible = false;
                    txt_Input6.Visible = false;
                    lbl_Title7.Visible = false;
                    txt_Input7.Visible = false;
                    lbl_Title8.Visible = false;
                    txt_Input8.Visible = false;
                    lbl_Title9.Visible = false;
                    txt_Input9.Visible = false;
                    lbl_Part.Visible = false;
                    break;
                case "patients":
                    lbl_Title.Text = "Cadastro de Pacientes";
                    switch (formPart) {
                        case 1:
                            lbl_TitlePart.Visible = true;
                            lbl_TitlePart.Text = "   Dados Básicos";
                            lbl_Part.Text = "Parte 1 de 4   ";
                            lbl_Title1.Text = "Nome";
                            lbl_Title2.Text = "Apelido";
                            lbl_Title3.Text = "Data de Nascimento";
                            lbl_Title4.Text = "Gênero";
                            lbl_Title5.Text = "CPF";
                            lbl_Title6.Text = "RG";
                            lbl_Title7.Text = "Estado Civil";
                            lbl_Title8.Text = "Altura";
                            lbl_Title9.Visible = false;
                            txt_Input9.Visible = false;
                            btn_Forward.Text = "Avançar";
                            break;
                        case 2:
                            lbl_TitlePart.Visible = true;
                            lbl_TitlePart.Text = "   Contato";
                            lbl_Part.Text = "Parte 2 de 4   ";
                            lbl_Title1.Text = "Celular";
                            lbl_Title2.Text = "Telefone";
                            lbl_Title3.Text = "E-mail";
                            lbl_Title4.Visible = false;
                            txt_Input4.Visible = false;
                            lbl_Title5.Visible = false;
                            txt_Input5.Visible = false;
                            lbl_Title6.Visible = false;
                            txt_Input6.Visible = false;
                            lbl_Title7.Visible = false;
                            txt_Input7.Visible = false;
                            lbl_Title8.Visible = false;
                            txt_Input8.Visible = false;
                            lbl_Title9.Visible = false;
                            txt_Input9.Visible = false;
                            btn_Back.Visible = true;
                            btn_Forward.Text = "Avançar";
                            break;
                        case 3:
                            lbl_TitlePart.Visible = true;
                            lbl_TitlePart.Text = "   Observações";
                            lbl_Part.Text = "Parte 3 de 4   ";
                            lbl_Title1.Text = "Como conheceu o consultório?";
                            lbl_Title2.Text = "Observações";
                            lbl_Title3.Visible = false;
                            txt_Input3.Visible = false;
                            lbl_Title4.Visible = false;
                            txt_Input4.Visible = false;
                            lbl_Title5.Visible = false;
                            txt_Input5.Visible = false;
                            lbl_Title6.Visible = false;
                            txt_Input6.Visible = false;
                            lbl_Title7.Visible = false;
                            txt_Input7.Visible = false;
                            lbl_Title8.Visible = false;
                            txt_Input8.Visible = false;
                            lbl_Title9.Visible = false;
                            txt_Input9.Visible = false;
                            btn_Back.Visible = true;
                            btn_Forward.Text = "Avançar";
                            break;
                        case 4:
                            lbl_TitlePart.Visible = true;
                            lbl_TitlePart.Text = "   Localidade";
                            lbl_Part.Text = "Parte 4 de 4   ";
                            lbl_Title1.Text = "Logradouro";
                            lbl_Title2.Text = "Bairro";
                            lbl_Title3.Text = "Número";
                            lbl_Title4.Text = "Complemento";
                            lbl_Title5.Text = "Cidade";
                            lbl_Title6.Text = "CEP";
                            lbl_Title7.Text = "Estado";
                            lbl_Title8.Visible = false;
                            txt_Input8.Visible = false;
                            lbl_Title9.Visible = false;
                            txt_Input9.Visible = false;
                            btn_Back.Visible = true;
                            break;
                        default:
                            mainController.Errors("404", "Pagina não encontrada!");
                            break;
                    }
                    break;
                case "consults":
                    lbl_TitlePart.Visible = false;
                    lbl_Title.Text = "Cadastro de Consultas";
                    lbl_Title1.Text = "Nome do Paciente";
                    lbl_Title2.Text = "Profissional";
                    lbl_Title3.Text = "Dia";
                    lbl_Title4.Text = "Mês";
                    lbl_Title5.Text = "Horário";
                    lbl_Title6.Text = "Categoria da Consulta";
                    lbl_Title7.Visible = false;
                    txt_Input7.Visible = false;
                    lbl_Title8.Visible = false;
                    txt_Input8.Visible = false;
                    lbl_Title9.Visible = false;
                    txt_Input9.Visible = false;
                    lbl_Part.Visible = false;
                    break;
                default:
                    mainController.Errors("404", "Pagina não encontrada!");
                    break;
            }
        }

        private void btn_Forward_Click(object sender, EventArgs e) {
            if(btn_Forward.Text == "Cadastrar") {
            
            } else if(btn_Forward.Text == "Avançar") {
                formPart++;
                Render();
            } else {
                mainController.Errors("Erro", "Erro desconhecido!");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e) {
            formPart--;
            Render();
        }
    }
}
