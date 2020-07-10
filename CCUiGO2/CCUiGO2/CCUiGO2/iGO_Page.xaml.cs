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
    /// iGO_Page.xaml 的互動邏輯
    /// </summary>
    public partial class iGO_Page : Page
    {
        public iGO_Page()
        {
            InitializeComponent();
            AddTargetTitle.Visibility = Visibility.Collapsed;
            Complete_Percent.Visibility = Visibility.Hidden;
            Long_Target_Title.Visibility = Visibility.Hidden;
        }

        private void AddTopic(object sender, RoutedEventArgs e)
        {
            AddTargetTitle.Visibility = Visibility.Visible;
            //topicGrid.IsEnabled = false;
        }
        private void Button_Click(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (AddTargetTitleBox.Text.Length != 0)
                {
                    AddTargetTitle.Visibility = Visibility.Collapsed;
                    //topicGrid.IsEnabled = true;
                    Long_Target_Title.Text = AddTargetTitleBox.Text;
                    Complete_Percent.Visibility = Visibility.Visible;
                    Long_Target_Title.Visibility = Visibility.Visible;
                }
                else
                {
                    //
                }
            }
        }
    }
}
