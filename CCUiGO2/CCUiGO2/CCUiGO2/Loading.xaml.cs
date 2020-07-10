using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CCUiGO2
{
	/// <summary>
	/// Loading.xaml 的互動邏輯
	/// </summary>
	public partial class Loading : Window
	{
		private int time;
		public Loading()
		{
			InitializeComponent();
		}

		private void Window_ContentRendered(object sender, EventArgs e)
		{
			DispatcherTimer dispatcherTimer = new DispatcherTimer();
			dispatcherTimer.Tick += dispatcherTimer_Tick;
			//dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
			dispatcherTimer.Interval = TimeSpan.FromMilliseconds(200);//equals to 1 sec
			dispatcherTimer.Start();
		}

		private void dispatcherTimer_Tick(object sender, EventArgs e)
		{
			if (loadingLabel.Content.Equals("Loading..."))
			{
				loadingLabel.Content = "Loading";
			}
			else
			{
				loadingLabel.Content += ".";
			}
			time++;
			if(time>=30)
			{
				//this.Close();
			}
		}
	}
}
