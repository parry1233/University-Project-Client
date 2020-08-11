using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;//
using System.Net;//
using System.Net.Sockets;//
using System.Windows.Controls;

namespace CCUiGO2
{
	class Client
	{
		//private bool register_done=false;
		private Socket client;
		private string[] info;
		public Client()
		{
			//建立套接字
			this.client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			AsyncConnect();
			this.info = new string[7];
		}

		public Client(Socket s)
		{
			this.client = s;
			//AsyncConnect();
			this.info = new string[7];
		}

		public Socket getSocket()
		{
			return client;
		}

		public void AsyncConnect()
		{
			try
			{
				//埠及IP
				IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.1.106"), int.Parse("13000"));
				//建立套接字
				//this.client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				//開始連線到伺服器
				this.client.BeginConnect(ipe, asyncResult =>
				{
					try
					{
						this.client.EndConnect(asyncResult);
						//向伺服器傳送訊息
						AsyncSend("客戶端已上線");
						//接受訊息
						AsyncReceive(this.client);
					}
					catch (SocketException e)
					{
						MessageBox.Show("客戶端錯誤回報: " + e.Message, "SocketERR");
					}
				}, null);

			}
			catch (SocketException e)
			{
				MessageBox.Show("客戶端錯誤回報: " + e.Message, "SocketERR");
			}
			catch (Exception e)
			{
				MessageBox.Show("客戶端錯誤回報: " + e.Message, "ERR");
			}
		}

		public void AsyncSend(string message)
		{
			if (this.client == null || message == string.Empty) return;
			//編碼
			byte[] data = Encoding.UTF8.GetBytes(message);
			try
			{

				this.client.BeginSend(data, 0, data.Length, SocketFlags.None, asyncResult =>
				{
					//完成傳送訊息
					int length = this.client.EndSend(asyncResult);
				}, null);
				/*App.Current.Dispatcher.Invoke((Action)(() =>
				{
					if(!message.Equals("客戶端已上線"))
					{
						this.window = new Loading();
						this.window.Show();
					}
				}));*/
			}
			catch (Exception e)
			{
				MessageBox.Show("客戶端錯誤回報: " + e.Message, "ERR");
			}
		}

		/// <summary>
		/// 接收訊息
		/// </summary>
		/// <param name="socket"></param>
		public string AsyncReceive(Socket socket)
		{
			byte[] data = new byte[1024000];
			try
			{
				string s = "";
				//開始接收資料
				socket.BeginReceive(data, 0, data.Length, SocketFlags.None,
				asyncResult =>
				{
					try
					{
						char[] delimiterChars = { ':', '/' };//分隔符類型-->當遇到這些符號時切割字串
						string[] instuction = { "" };

						int length = socket.EndReceive(asyncResult);
						s = Encoding.UTF8.GetString(data);
						int i = s.IndexOf('\0');
						if (i >= 0)
						{
							s = s.Substring(0, i);
						}
						//MessageBox.Show(s);
						instuction = s.Split(delimiterChars);//split message to instruction
						App.Current.Dispatcher.Invoke((Action)(() =>
						{
							foreach (Window win in App.Current.Windows)
							{
								/*if (win.GetType().Name.Equals("Loading"))
								{
									win.Close();
								}*/
								if (win.GetType() == typeof(MainWindow))
								{
									(win as MainWindow).disruptLoad();
								}
							}
							if (instuction[0].Equals("LOGIN_PERMIT"))
							{
								//MessageBox.Show("登錄成功，即將跳轉...");
								string[] input = new string[15];
								for(int info=0;info<15;info++)
								{
									input[info] = instuction[info + 1];
								}
								UserMainWindow window = new UserMainWindow(this.client,input);
								window.Show();
								//open login window and close all of the others
								foreach (Window win in App.Current.Windows)
								{
									if (win != window)
									{
										win.Close();
									}
								}
							}
							else if(instuction[0].Equals("END"))
							{
								App.Current.Shutdown();
							}
							else if (instuction[0].Equals("LOGIN FAILED"))
							{
								MessageBox.Show("帳號或密碼錯誤!");
							}
							else if (instuction[0].Equals("REGISTER_ACCEPT"))
							{
								MessageBox.Show("創建帳號成功!即將返回登錄畫面...");
								MainWindow mainWindow = new MainWindow(this.client);
								mainWindow.Show();
								//open main window and close all of the others
								foreach (Window win in App.Current.Windows)
								{
									if (win != mainWindow)
									{
										win.Close();
									}
								}
							}
                            else if(instuction[0].Equals("REGISTER_ERROR"))
                            {
                                MessageBox.Show("創建帳號時發生不可預期的錯誤!請聯繫相關人員");
                                MainWindow mainWindow = new MainWindow(this.client);
                                mainWindow.Show();
                                //open main window and close all of the others
                                foreach (Window win in App.Current.Windows)
                                {
                                    if (win != mainWindow)
                                    {
                                        win.Close();
                                    }
                                }
                            }
							else if (instuction[0].Equals("REGISTER_DENY"))
							{
								MessageBox.Show("驗證碼錯誤!");
							}
							else if (instuction[0].Equals("NEXT_PERMIT"))
							{
								//this.info = new string[7];
								//string[] idpw = new string[2];
								for(int a =0;a<=1;a++)
								{
									this.info[a] = instuction[a + 1];
								}
								sign_up_info sign_up_info = new sign_up_info(this.info,this.client);
								sign_up_info.Show();
								//open main window and close all of the others
								foreach (Window win in App.Current.Windows)
								{
									if (win != sign_up_info)
									{
										win.Close();
									}
								}
							}
							else if(instuction[0].Equals("NEXT_DENY"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType().Name.Equals("Loading"))
									{
										win.Close();
									}
								}
								MessageBox.Show("帳號已被使用，請重新輸入!");
							}
							else if (instuction[0].Equals("FORGET_PW_IDEMAIL_PERMIT"))
							{
								ForgetPWD_Verify forgetPWD_Verify = new ForgetPWD_Verify(this.client, instuction[1],instuction[2]);
								forgetPWD_Verify.Show();
								//open main window and close all of the others
								foreach (Window win in App.Current.Windows)
								{
									if (win != forgetPWD_Verify)
									{
										win.Close();
									}
								}
							}
							else if (instuction[0].Equals("FORGET_PW_IDEMAIL_DENY"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType().Name.Equals("Loading"))
									{
										win.Close();
									}
								}
								MessageBox.Show("帳號或信箱有誤，請重新輸入!");
							}
							else if (instuction[0].Equals("FORGET_PW_VERIFY_PERMIT"))
							{
								ForgetPWD_Modify forgetPWD_Modify = new ForgetPWD_Modify(this.client,instuction[1],instuction[2]);
								forgetPWD_Modify.Show();
								//open main window and close all of the others
								foreach (Window win in App.Current.Windows)
								{
									if (win != forgetPWD_Modify)
									{
										win.Close();
									}
								}
							}
							else if (instuction[0].Equals("FORGET_PW_VERIFY_DENY"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType().Name.Equals("Loading"))
									{
										win.Close();
									}
								}
								MessageBox.Show("驗證碼有誤，請重新輸入!");
							}
							else if (instuction[0].Equals("CHANGE_PW_ACCEPT"))
							{
								MessageBox.Show("更改成功!即將返回登錄畫面...");
								MainWindow mainWindow = new MainWindow(this.client);
								mainWindow.Show();
								//open main window and close all of the others
								foreach (Window win in App.Current.Windows)
								{
									if (win != mainWindow)
									{
										win.Close();
									}
								}
							}
							else if (instuction[0].Equals("GET_COMMENT_PERMIT"))
							{
								string serachKey = instuction[1];
								instuction = instuction.Skip(2).ToArray();
								List<string> class_name = new List<string>();
								List<string> class_depart = new List<string>();
								List<string> class_teacher = new List<string>();
								List<string> class_ratings = new List<string>();
								for (int a=0;a<instuction.Length;a+=4)
								{
									class_name.Add(instuction[a]);
									class_depart.Add(instuction[a + 1]);
									class_teacher.Add(instuction[a + 2]);
									class_ratings.Add(instuction[a + 3]);
								}
								
								OtherPage otherPage = new OtherPage(class_name,class_depart,class_teacher,class_ratings,1,0,getSocket(),serachKey);
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).frame.NavigationService.Navigate(otherPage);
									}
								}
							}
							else if (instuction[0].Equals("GET_COMMENT_DETAIL_PERMIT"))
							{
								string[] class_info = new string[6];
								class_info[0] = instuction[1];
								class_info[1] = instuction[2];
								class_info[2] = instuction[3];
								class_info[3] = instuction[4];
								class_info[4] = instuction[5];
								class_info[5] = instuction[6];
								instuction = instuction.Skip(7).ToArray();
								List<string> comment_user = new List<string>();
								List<string> comment_rating = new List<string>();
								List<string> comment_detail = new List<string>();
								List<string> comment_Like = new List<string>();
								List<string> comment_Date = new List<string>();
								List<string> comment_Tag = new List<string>();

								for (int a = 0; a < instuction.Length; a += 6)
								{
									comment_user.Add(instuction[a]);
									comment_rating.Add(instuction[a + 1]);
									comment_detail.Add(instuction[a + 2]);
									comment_Like.Add(instuction[a + 3]);
									comment_Date.Add(instuction[a + 4]);
									comment_Tag.Add(instuction[a + 5]);
								}

								Course_Detail commentPage = new Course_Detail(class_info[0], class_info[1], class_info[2], class_info[3], class_info[4], class_info[5],
									comment_user, comment_rating, comment_detail,comment_Like,comment_Date,comment_Tag ,1, 0, getSocket());
								commentPage.Add_Comment.Click += AddCommentBTN_Click;
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).set_current_course_details(class_info);
										(win as UserMainWindow).frame.NavigationService.Navigate(commentPage);
									}
								}
							}
							else if (instuction[0].Equals("ADD_COMMENT_ACCEPT"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).toHomePage();
									}
								}
							}
							else if (instuction[0].Equals("PREVIEW_CHATROOM_PERMIT"))
							{
								List<string> chatroomName = new List<string>();
								List<string> chatroomMember = new List<string>();
								for(int a=1;a<instuction.Length;a+=2)
								{
									chatroomName.Add(instuction[a]);
									chatroomMember.Add(instuction[a+1]);
								}
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).ChatPreview(chatroomName,chatroomMember);
									}
								}
							}
							else if(instuction[0].Equals("PREVIEW_CHATROOM_PERMIT_NODATA"))
							{
								List<string> chatroomName = new List<string>();
								List<string> chatroomMember = new List<string>();
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).ChatPreview(chatroomName, chatroomMember);
									}
								}
							}
							else if (instuction[0].Equals("ADD_CHATROOM_PERMIT"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).JoinChatroom(instuction[1]);
									}
								}
							}
							else if (instuction[0].Equals("ADD_CHATROOM_DENY"))
							{
								MessageBox.Show("創建聊天室失敗! 可能已存在相同名稱之聊天室");
								/*foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).MemberLeave(instuction[1]);
									}
								}*/
							}
							else if (instuction[0].Equals("ADD_CHAT"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).AddChat(instuction[1],instuction[2]);
									}
								}
							}
							else if (instuction[0].Equals("ADD_CHAT_TO_OWN"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).AddChatToOwn(instuction[1]);
									}
								}
							}
							else if (instuction[0].Equals("GROUP_MEMBER_LEAVE"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).MemberLeave(instuction[1]);
									}
								}
							}
							else if (instuction[0].Equals("GROUP_MEMBER_JOIN"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).MemberJoin(instuction[1]);
									}
								}
							}
							else if (instuction[0].Equals("BROADCAST_ADD_TOPIC"))
							{
								foreach (Window win in App.Current.Windows)
								{
									if (win.GetType() == typeof(UserMainWindow))
									{
										(win as UserMainWindow).Broadcast(instuction[1],instuction[2]);
									}
								}
							}
							else
							{
								MessageBox.Show(s);
							}
						}));
					}
					catch (Exception)
					{
						AsyncReceive(socket);
					}


					AsyncReceive(socket);
				}, null);

				return s;
			}
			catch (Exception e)
			{
				MessageBox.Show("客戶端錯誤回報: " + e.Message, "SocketERR");
				return null;
			}
		}
		private void AddCommentBTN_Click(object sender, RoutedEventArgs e)
		{
			foreach (Window win in App.Current.Windows)
			{
				if (win.GetType() == typeof(UserMainWindow))
				{
					Add_Comment_Page add_Comment_Page = new Add_Comment_Page((win as UserMainWindow).return_current_course_details(), 
						(win as UserMainWindow).getID(), this.getSocket());
					(win as UserMainWindow).frame.NavigationService.Navigate(add_Comment_Page);
				}
			}
		}
	}
}
