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

namespace CCUiGO2
{
    /// <summary>
    /// SignIn_Page.xaml 的互動邏輯
    /// </summary>
    public partial class SignIn_Page : Page
    {
        public SignIn_Page()
        {
            InitializeComponent();
            Sign_up_line.Visibility = Visibility.Hidden;
        }
    }
}
