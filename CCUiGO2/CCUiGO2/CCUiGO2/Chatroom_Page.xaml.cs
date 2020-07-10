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
    /// Chatroom_Page.xaml 的互動邏輯
    /// </summary>
    public partial class Chatroom_Page : Page
    {
		private Client clieConnect;
        public Chatroom_Page(string roomName, Socket sIn)
        {
            InitializeComponent();
			this.clieConnect = new Client(sIn);
			Chatroom_inName.Text = roomName;
        }

		public void AddText(string user_name,string chat)
		{
			StackPanel sp = new StackPanel();
			sp.Orientation = Orientation.Horizontal;

			//user icon
			MaterialDesignThemes.Wpf.PackIcon icon = new MaterialDesignThemes.Wpf.PackIcon() { Kind = MaterialDesignThemes.Wpf.PackIconKind.User };
			icon.VerticalAlignment = VerticalAlignment.Center;
			icon.Height = 30;
			icon.Width = 30;

			//user name textblock
			TextBlock tb_name = new TextBlock();
			tb_name.Text = user_name;
			tb_name.VerticalAlignment = VerticalAlignment.Center;

			/*TextBlock tb = new TextBlock();
			tb.Text = chat;
			tb.VerticalAlignment = VerticalAlignment.Center;
			tb.HorizontalAlignment = HorizontalAlignment.Center;*/

			//user chat chip
			MaterialDesignThemes.Wpf.Chip chip = new MaterialDesignThemes.Wpf.Chip();
			chip.Margin = new Thickness { Left = 5 };
			chip.Content = chat;
			chip.Background = new SolidColorBrush(Color.FromRgb(255, 218, 142));

			sp.Children.Add(icon);
			sp.Children.Add(tb_name);
			sp.Children.Add(chip);

			/*Border border = new Border();
			border.CornerRadius = new CornerRadius(10.0);
			border.Background = Brushes.LightBlue;
			border.Height = 38;
			border.Margin = new System.Windows.Thickness { Left = 10 };

			border.BorderBrush = Brushes.LightBlue;
			border.BorderThickness = new Thickness(10, 10, 10, 10);
			border.Child = tb;
			sp.Children.Add(border);*/
			sp.Margin = new Thickness { Top = 10 };

			ChatBox.Children.Add(sp);
		}

		public void AddTextOwn(string chat)
		{
			StackPanel sp = new StackPanel();
			sp.Orientation = Orientation.Horizontal;

			MaterialDesignThemes.Wpf.Chip chip = new MaterialDesignThemes.Wpf.Chip();
			chip.Margin = new Thickness { Right = 10 };
			chip.Content = chat;
			chip.Background = new SolidColorBrush(Color.FromRgb(128, 212, 246));

			/*TextBlock tb = new TextBlock();
			tb.Background = Brushes.LightBlue;
			tb.Text = chat;
			tb.VerticalAlignment = VerticalAlignment.Center;
			tb.HorizontalAlignment = HorizontalAlignment.Center;

			Border border = new Border();
			border.CornerRadius = new CornerRadius(10.0);
			border.Background = Brushes.LightBlue;
			border.Height = 38;

			border.BorderBrush = Brushes.LightBlue;
			border.BorderThickness = new Thickness(10, 10, 10, 10);
			border.Child = tb;
			sp.Children.Add(border);*/

			sp.Children.Add(chip);
			sp.Margin = new Thickness { Top = 10 };
			sp.HorizontalAlignment = HorizontalAlignment.Right;

			ChatBox.Children.Add(sp);
		}

		private void Send(object sender,RoutedEventArgs e)
		{
			SendMessage();
		}

		public void JoinMessage(string name)
		{
			StackPanel sp = new StackPanel();
			TextBlock tb = new TextBlock();
			tb.Background = Brushes.LightGreen;
			tb.Text = name + " 加入聊天";
			tb.VerticalAlignment = VerticalAlignment.Center;
			tb.HorizontalAlignment = HorizontalAlignment.Center;
			tb.Foreground = Brushes.Gray;

			sp.Children.Add(tb);
			sp.Margin = new Thickness { Top = 10 };
			sp.HorizontalAlignment = HorizontalAlignment.Center;
			ChatBox.Children.Add(sp);
		}

		public void LeaveMessage(string name)
		{
			StackPanel sp = new StackPanel();
			TextBlock tb = new TextBlock();
			tb.Background = Brushes.LightGreen;
			tb.Text = name + " 離開聊天";
			tb.VerticalAlignment = VerticalAlignment.Center;
			tb.HorizontalAlignment = HorizontalAlignment.Center;
			tb.Foreground = Brushes.Gray;

			sp.Children.Add(tb);
			sp.Margin = new Thickness { Top = 10 };
			sp.HorizontalAlignment = HorizontalAlignment.Center;
			ChatBox.Children.Add(sp);
		}

		private void SendBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				SendMessage();
			}
		}

		private void SendMessage()
		{
			if (SendBox.Text.Length > 0)
			{
				this.clieConnect.AsyncSend("SEND:" + Chatroom_inName.Text + "/" + SendBox.Text);
			}
			SendBox.Text = "";
		}

	}
}
