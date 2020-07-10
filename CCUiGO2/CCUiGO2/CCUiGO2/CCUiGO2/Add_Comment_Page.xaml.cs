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
    /// Add_Comment_Page.xaml 的互動邏輯
    /// </summary>
    public partial class Add_Comment_Page : Page
    {
        private int addTagCount = 0;
        public Add_Comment_Page()
        {
            InitializeComponent();
        }

        private void add_tag_MouseDown(object sender, MouseButtonEventArgs e)
        {
           AddTagCreate();
        }


        private void addTag_Textbox_MouseDown(object sender,MouseEventArgs e)
        {
            (sender as TextBox).IsEnabled = true;
        }
        private void addTagPressDown(object sender, KeyEventArgs e)
        {
            if((sender as TextBox).Text.Length != 0 && e.Key == Key.Enter)
            {
                (sender as TextBox).IsEnabled = false;
            }
        }

        private void addTagPressUp(object sender, KeyEventArgs e)
        {
            addTagCheckEmpty(sender);
        }

        private void addTagCheckEmpty(object sender)
        {
            if((sender as TextBox).Text.Length == 0)
            {
                (sender as TextBox).Text += "#";
            }
            (sender as TextBox).CaretIndex = (sender as TextBox).Text.Length;
        }

        private void AddTagCreate()
        {
            if (this.addTagCount < 3)
            {
                TextBox addTag = new TextBox();
                addTag.Text = "#";
                addTag.Margin = new Thickness { Left = 10 };
                addTag.FontSize = 23;
                addTag.Height = 40;
                addTag.Background = new SolidColorBrush(Color.FromRgb(216, 230, 231));
                addTag.BorderThickness = new Thickness(0, 0, 0, 0);
                //addTag.KeyDown += addTagPressDown;
                //addTag.MouseDown += addTag_Textbox_MouseDown;
                addTag.KeyUp += addTagPressUp;
                secondPanel.Children.Add(addTag);
                addTagCount++;
            }
        }
    }
}
