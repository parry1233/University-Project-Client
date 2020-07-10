using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Settings_Page.xaml 的互動邏輯
    /// </summary>
    public partial class Settings_Page : Page
    {
		private Client clientConnect;
		public Settings_Page(
			string ID, string PW, string User_Name, string Depart, string Grade, string Gender, string Email, 
			string Level, string Points, string Detail, Socket socket)
        {
            InitializeComponent();

			this.clientConnect = new Client(socket);
			Report_Grid.Visibility = Visibility.Collapsed;
			ID_Text.Text = ID;
			PW_Text.Text = PW;
			Name_Text.Text = User_Name;
			Depart_Text.Text = Depart + " " + Grade;
			if(Convert.ToInt32(Gender) == 0)
			{
				Gender_Text.Text = "女";
			}
			else if(Convert.ToInt32(Gender) == 1)
			{
				Gender_Text.Text = "男";
			}
			else if (Convert.ToInt32(Gender) == 2)
			{
				Gender_Text.Text = "管理員";
			}
			else
			{
				Gender_Text.Text = "Default";
			}
			Email_Text.Text = Email;
			Level_Text.Text = Level;
			Points_Text.Text = Points;
			char[] delimiterChars = { ',' };
			string detail_temp = Detail;
			string[] split = detail_temp.Split(delimiterChars);
			int counter = 0;

			foreach (string s in split)
			{
				counter++;
				if (counter == 1)
				{
					if (s.Equals("vip"))
					{
						userIcon.Source = new BitmapImage(new Uri(@"Icon/vip.png", UriKind.Relative));
					}
					else if (s.Equals("targetMaster"))
					{
						userIcon.Source = new BitmapImage(new Uri(@"Achievement/高度期待.png", UriKind.Relative));
					}
					else if (s.Equals("goalKiller"))
					{
						userIcon.Source = new BitmapImage(new Uri(@"Achievement/goalKiller.png", UriKind.Relative));
					}
					else if (s.Equals("starter"))
					{
						userIcon.Source = new BitmapImage(new Uri(@"Achievement/實踐者.png", UriKind.Relative));
					}
					else if (s.Equals("submarine"))
					{
						userIcon.Source = new BitmapImage(new Uri(@"Achievement/submarine.png", UriKind.Relative));
					}
					else
					{
						if (Convert.ToInt32(Gender) == 0)
						{
							userIcon.Source = new BitmapImage(new Uri(@"Icon/user_female.png", UriKind.Relative));
						}
						else if (Convert.ToInt32(Gender) == 1)
						{
							userIcon.Source = new BitmapImage(new Uri(@"Icon/user_male.png", UriKind.Relative));
						}
						else if (Convert.ToInt32(Gender) == 2)
						{
							userIcon.Source = new BitmapImage(new Uri(@"Icon/admin.png", UriKind.Relative));
						}
						else
						{
							userIcon.Source = new BitmapImage(new Uri(@"Icon/info.png", UriKind.Relative));
						}
					}
				}
			}
		}

		private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			/*bool flag = (sender as ToggleButton).Toggled1 == true ? true : false;

			string day = (sender as ToggleButton).Name.ToString().Split('_')[0];
			day = day + "Time";

			object wantedNode = Time_Interval_All.FindName(day);

			foreach (object item in (wantedNode as WrapPanel).Children)
			{
				//var item = MonTime.Children[i];
				if (item is StackPanel)
				{
					//CheckBox checkBoxItem = (CheckBox)item;
					//checkBoxItem.IsChecked = flag;
					foreach (object stackPanel_inStackPanel in (item as StackPanel).Children)
					{
						foreach (object checkbox in (stackPanel_inStackPanel as StackPanel).Children)
						{
							(checkbox as CheckBox).IsChecked = flag;
						}
					}
				}
			}*/
		}

		private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Shop_Page shop_Page = new Shop_Page(Points_Text.Text);
			this.NavigationService.Navigate(shop_Page);
		}

		private void Report_Confirm_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("REPORT:" + Report_Title.Text + "/" + Report_Content.Text);
			Report_Grid.Visibility = Visibility.Collapsed;
		}

		private void Report_Cancel_Click(object sender, RoutedEventArgs e)
		{
			Report_Grid.Visibility = Visibility.Collapsed;
		}

		private void Report_Click(object sender, RoutedEventArgs e)
		{
			Report_Grid.Visibility = Visibility.Visible;
		}
	}
}
