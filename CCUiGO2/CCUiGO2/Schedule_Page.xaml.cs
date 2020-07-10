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
    /// Schedule_Page.xaml 的互動邏輯
    /// </summary>
    public partial class Schedule_Page : Page
    {
        private Client clientConnect;
        private ScheduleSettings scheduleSettings = new ScheduleSettings();
        private List<Dictionary<string, List<string[]>>> AllSchedule = new List<Dictionary<string, List<string[]>>>();
        public Schedule_Page(Socket socket)
        {
            InitializeComponent();
            this.clientConnect = new Client(socket);
            this.AllSchedule = this.scheduleSettings.Schedule_LoadXML();
            ClassDisplay(0);
            ScheduleSelect.SelectedIndex = 0;

            for (int i = 0; i< this.scheduleSettings.TableCount();i++)
            {
                ScheduleSelect.Items.Add("Table" + (i + 1));
            }
        }

        public Schedule_Page(Socket socket,int index)
        {
            InitializeComponent();
            this.clientConnect = new Client(socket);
            this.AllSchedule = this.scheduleSettings.Schedule_LoadXML();
            ClassDisplay(index);
            ScheduleSelect.SelectedIndex = index;

            for (int i = 0; i < this.scheduleSettings.TableCount(); i++)
            {
                ScheduleSelect.Items.Add("Table" + (i + 1));
            }
        }

        private void ClassDisplay(int index)
        {
            EditCheckBox.IsChecked = false;

            foreach(KeyValuePair<string,List<string[]>> allClasses in this.AllSchedule[index])
            {
                //Mon
                if(allClasses.Key.Equals("Mon123AB"))
                {
                    foreach(string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0]+"\r\n"+single_class[1]+"\r\n"+single_class[2]+"\r\n"+single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Mon123ABStack.Children.Add(Outsider);
                    }
                    
                }
                else if(allClasses.Key.Equals("Mon456CD"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Mon456CDStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Mon789EF"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Mon789EFStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Mon012GH"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Mon012GHStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Mon345IJ"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Mon345IJStack.Children.Add(Outsider);
                    }
                }
                //Tue
                if (allClasses.Key.Equals("Tue123AB"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Tue123ABStack.Children.Add(Outsider);
                    }

                }
                else if (allClasses.Key.Equals("Tue456CD"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Tue456CDStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Tue789EF"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Tue789EFStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Tue012GH"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Tue012GHStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Tue345IJ"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Tue345IJStack.Children.Add(Outsider);
                    }
                }
                //Wed
                if (allClasses.Key.Equals("Wed123AB"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Wed123ABStack.Children.Add(Outsider);
                    }

                }
                else if (allClasses.Key.Equals("Wed456CD"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Wed456CDStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Wed789EF"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Wed789EFStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Wed012GH"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Wed012GHStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Wed345IJ"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Wed345IJStack.Children.Add(Outsider);
                    }
                }
                //Thu
                if (allClasses.Key.Equals("Thu123AB"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Thu123ABStack.Children.Add(Outsider);
                    }

                }
                else if (allClasses.Key.Equals("Thu456CD"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Thu456CDStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Thu789EF"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Thu789EFStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Thu012GH"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Thu012GHStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Thu345IJ"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Thu345IJStack.Children.Add(Outsider);
                    }
                }
                //Fri
                if (allClasses.Key.Equals("Fri123AB"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Fri123ABStack.Children.Add(Outsider);
                    }

                }
                else if (allClasses.Key.Equals("Fri456CD"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Fri456CDStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Fri789EF"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Fri789EFStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Fri012GH"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Fri012GHStack.Children.Add(Outsider);
                    }
                }
                else if (allClasses.Key.Equals("Fri345IJ"))
                {
                    foreach (string[] single_class in allClasses.Value)
                    {
                        StackPanel Outsider = new StackPanel();
                        Outsider.Margin = new Thickness(10, 5, 10, 0);
                        Button button = new Button();
                        button.Background = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.BorderBrush = new SolidColorBrush(Color.FromRgb(109, 129, 156));
                        button.Content = single_class[0];
                        button.ToolTip = single_class[0] + "\r\n" + single_class[1] + "\r\n" + single_class[2] + "\r\n" + single_class[3];
                        button.Click += ClassLink;
                        Outsider.Children.Add(button);

                        Fri345IJStack.Children.Add(Outsider);
                    }
                }
            }
        }

        private void ClassLink(object sender, RoutedEventArgs e)
        {
            string[] stringSeparators = new string[] { "\r\n" };
            string[] data = (sender as Button).ToolTip.ToString().Split(stringSeparators, StringSplitOptions.None);
            //MessageBox.Show("名稱: "+data[0]+"\r\n系所: "+data[1]+"\r\n教授: "+data[2]);
            this.clientConnect.AsyncSend("GET_COMMENT:" + data[0] + "/" + data[1] + "/" + data[2]);
        }

        private void DoDelete(object sender, RoutedEventArgs e)
        {
            string[] stringSeparators = new string[] { "\r\n" };
            string[] data = (sender as Button).ToolTip.ToString().Split(stringSeparators, StringSplitOptions.None);
            string[] classInfo = new string[3];
            classInfo[0] = data[0];
            classInfo[1] = data[1];
            classInfo[2] = data[2];
            this.scheduleSettings.Delete(classInfo, ScheduleSelect.SelectedIndex);

            Schedule_Page refresh_page = new Schedule_Page(this.clientConnect.getSocket(),ScheduleSelect.SelectedIndex);
            this.NavigationService.Navigate(refresh_page);
        }

        private void AddTable(object sender, RoutedEventArgs e)
        {
            this.scheduleSettings.SaveAdd();
            Schedule_Page refresh_page = new Schedule_Page(this.clientConnect.getSocket(), ScheduleSelect.SelectedIndex);
            this.NavigationService.Navigate(refresh_page);
        }

        private void DeleteTable(object sender, RoutedEventArgs e)
        {
            if(this.scheduleSettings.TableCount()<=1)
            {
                MessageBox.Show("最少需要保留一張課表!");
            }
            else
            {
                this.scheduleSettings.ClearTable(ScheduleSelect.SelectedIndex);
                Schedule_Page refresh_page = new Schedule_Page(this.clientConnect.getSocket());
                this.NavigationService.Navigate(refresh_page);
            }
        }

        private void ScheduleSelect_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (ScheduleSelect.SelectedItem!=null)
            {
                Mon123ABStack.Children.Clear();
                Mon456CDStack.Children.Clear();
                Mon789EFStack.Children.Clear();
                Mon012GHStack.Children.Clear();
                Mon345IJStack.Children.Clear();

                Tue123ABStack.Children.Clear();
                Tue456CDStack.Children.Clear();
                Tue789EFStack.Children.Clear();
                Tue012GHStack.Children.Clear();
                Tue345IJStack.Children.Clear();

                Wed123ABStack.Children.Clear();
                Wed456CDStack.Children.Clear();
                Wed789EFStack.Children.Clear();
                Wed012GHStack.Children.Clear();
                Wed345IJStack.Children.Clear();

                Thu123ABStack.Children.Clear();
                Thu456CDStack.Children.Clear();
                Thu789EFStack.Children.Clear();
                Thu012GHStack.Children.Clear();
                Thu345IJStack.Children.Clear();

                Fri123ABStack.Children.Clear();
                Fri456CDStack.Children.Clear();
                Fri789EFStack.Children.Clear();
                Fri012GHStack.Children.Clear();
                Fri345IJStack.Children.Clear();

                ClassDisplay(ScheduleSelect.SelectedIndex);
            }
        }

        private void EditCancel(object sender, RoutedEventArgs e)
        {
            if (EditCheckBox.IsChecked.Value)
            {
                //Mon
                foreach (Object outsider_stack in Mon123ABStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Mon456CDStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Mon789EFStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Mon012GHStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Mon345IJStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                //Tue
                foreach (Object outsider_stack in Tue123ABStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Tue456CDStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Tue789EFStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Tue012GHStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Tue345IJStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                //Wed
                foreach (Object outsider_stack in Wed123ABStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Wed456CDStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Wed789EFStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Wed012GHStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Wed345IJStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                //Thu
                foreach (Object outsider_stack in Thu123ABStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Thu456CDStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Thu789EFStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Thu012GHStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Thu345IJStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                //Fri
                foreach (Object outsider_stack in Fri123ABStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Fri456CDStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Fri789EFStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Fri012GHStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
                foreach (Object outsider_stack in Fri345IJStack.Children)
                {
                    foreach (Object btn in (outsider_stack as StackPanel).Children)
                    {
                        (btn as Button).Click -= ClassLink;
                        (btn as Button).Click += DoDelete;
                        (btn as Button).Background = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                        (btn as Button).BorderBrush = new SolidColorBrush(Color.FromRgb(254, 67, 101));
                    }
                }
            }
            else
            {
                Schedule_Page refresh_page = new Schedule_Page(this.clientConnect.getSocket(),ScheduleSelect.SelectedIndex);
                this.NavigationService.Navigate(refresh_page);
            }
        }
    }
}
