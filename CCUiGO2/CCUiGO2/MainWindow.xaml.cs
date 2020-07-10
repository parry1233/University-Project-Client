using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;//
using System.Net.Sockets;//

namespace CCUiGO2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private Client clientConnect;
        private UserSettings userSettings;
        private Dictionary<string, string> setting;
        private SignUp_Page signUp_Page;
        private SignIn_Page signIn_Page;
        public MainWindow()
        {
            InitializeComponent();
            this.clientConnect = new Client();
            this.userSettings = new UserSettings();
            this.setting = new Dictionary<string, string>();

            ShowSignIn();
        }

        public MainWindow(Socket pre_socket)
        {
            InitializeComponent();
            this.clientConnect = new Client(pre_socket);
            this.userSettings = new UserSettings();
            this.setting = new Dictionary<string, string>();

            ShowSignIn();
        }

        public MainWindow(Socket pre_socket,string id)
        {
            InitializeComponent();
            this.clientConnect = new Client(pre_socket);
            this.userSettings = new UserSettings();
            this.setting = new Dictionary<string, string>();

            ShowSignUp(id);
        }

        private void ShowSignIn()
        {
            this.signIn_Page = new SignIn_Page();
            this.setting = this.userSettings.MainWindow_LoadXML();
            if (this.setting["remeberID"].Length != 0)
            {
                this.signIn_Page.rememberIDcheck.IsChecked = true;
                this.signIn_Page.id_inputbox.Text = this.setting["remeberID"];
            }
            this.signIn_Page.Sign_up_line.Visibility = Visibility.Hidden;
            this.signIn_Page.loadingBTN.Visibility = Visibility.Collapsed;
            this.signIn_Page.igoBTN.Click += Login_Click;
            this.signIn_Page.forgetpw.MouseDown += forgetpw_MouseDown;
            this.signIn_Page.Sign_up_Box.MouseEnter += SignUpLabel_MouseEnter;
            this.signIn_Page.Sign_up_Box.MouseLeave += SignUpLabel_MouseLeave;
            this.signIn_Page.Sign_up_Box.MouseDown += SignUpLabel_MouseDown;
            this.signIn_Page.pw_inputbox.KeyDown += Password_Enter_Press;
            frame.NavigationService.Navigate(signIn_Page);
        }

        private void ShowSignUp()
        {
            this.signUp_Page = new SignUp_Page();
            this.signIn_Page.Sign_up_line.Visibility = Visibility.Hidden;
            this.signUp_Page.igoBTN.Click += RegisterBTN_Click;
            this.signUp_Page.Sign_in_Box.MouseEnter += SignInLabel_MouseEnter;
            this.signUp_Page.Sign_in_Box.MouseLeave += SignInLabel_MouseLeave;
            this.signUp_Page.Sign_in_Box.MouseDown += SignInLabel_MouseDown;
            frame.NavigationService.Navigate(signUp_Page);
        }

        private void ShowSignUp(string id)
        {
            this.signUp_Page = new SignUp_Page(id);
            this.signIn_Page.Sign_up_line.Visibility = Visibility.Hidden;
            this.signUp_Page.igoBTN.Click += RegisterBTN_Click;
            this.signUp_Page.Sign_in_Box.MouseEnter += SignInLabel_MouseEnter;
            this.signUp_Page.Sign_in_Box.MouseLeave += SignInLabel_MouseLeave;
            this.signUp_Page.Sign_in_Box.MouseDown += SignInLabel_MouseDown;
            frame.NavigationService.Navigate(signUp_Page);
        }

        private void SignUpLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowSignUp();
            SetXML();
        }

        private void SignUpLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.signIn_Page.Sign_up_line.Visibility = Visibility.Visible;
        }

        private void SignUpLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            this.signIn_Page.Sign_up_line.Visibility = Visibility.Hidden;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string send = "LOGINTRY:" + this.signIn_Page.id_inputbox.Text + "/" + this.signIn_Page.pw_inputbox.Password;
            this.clientConnect.AsyncSend(send);
            //Loading loading = new Loading();
            //loading.Show();
            this.signIn_Page.igoBTN.IsEnabled = false;
            this.signIn_Page.loadingBTN.Visibility = Visibility.Visible;
            SetXML();
        }

        private void Password_Enter_Press(object sender,KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Login_Click(this, e);
            }
        }

        private void SignInLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowSignIn();
        }

        private void SignInLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.signUp_Page.Sign_in_line.Visibility = Visibility.Visible;
        }

        private void SignInLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            this.signUp_Page.Sign_in_line.Visibility = Visibility.Hidden;
        }

        private void RegisterBTN_Click(object sender, RoutedEventArgs e)
        {
            if (this.signUp_Page.pw_register.Password.Length != 0 && this.signUp_Page.pw_recheck.Password.Length != 0)
            {
                if (this.signUp_Page.pw_recheck.Password.Equals(this.signUp_Page.pw_register.Password))
                {
                    string[] idpw = new string[2];
                    idpw[0] = this.signUp_Page.id_register.Text;
                    idpw[1] = this.signUp_Page.pw_register.Password;
                    //this.clientConnect.setIDPW(idpw);
                    this.clientConnect.AsyncSend("REGISTER_VERIFY_IDPW:" + signUp_Page.id_register.Text + "/" + signUp_Page.pw_register.Password);
                    Loading loading = new Loading();
                    loading.Show();
                }
                else
                {
                    MessageBox.Show("密碼不一致，請重新輸入!");
                }
            }
            else
            {
                MessageBox.Show("輸入不完整，請重新輸入!");
            }
        }

        private void forgetpw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SetXML();
            ForgetPWD_idpw window = new ForgetPWD_idpw(this.clientConnect.getSocket());
            window.Show();
            this.Close();
        }

        private void WindowDrag(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void TitleClick(object sender, MouseButtonEventArgs e)
        {
            string item = ((ListViewItem)((ListView)sender).SelectedItem).Name;
            if (item != null)
            {
                if (item.Equals("ZoomIn"))
                {
                    this.WindowState = WindowState.Minimized;
                }
                else if (item.Equals("Close"))
                {
                    this.Close();
                    SetXML();
                }
            }
        }

        public void disruptLoad()
        {
            this.signIn_Page.igoBTN.IsEnabled = true;
            this.signIn_Page.loadingBTN.Visibility = Visibility.Collapsed;
        }

        private void SetXML()
        {
            if (this.signIn_Page.rememberIDcheck.IsChecked.Value)
            {
                this.setting["remeberID"] = this.signIn_Page.id_inputbox.Text;
                this.userSettings.MainWindow_SaveXML(this.setting);
            }
            else
            {
                this.setting["remeberID"] = "";
                this.userSettings.MainWindow_SaveXML(this.setting);
            }
        }
    }
}
