using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace CCUiGO2
{
	class IgoSettings
	{
		private List<string[]> shortTarget = new List<string[]>();
		private List<string> LongTarget = new List<string>();

		public IgoSettings()
		{

		}

		public void LoadTarget()
		{
			this.shortTarget.Clear();
			this.LongTarget.Clear();

			try
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("iGO.xml");//load string initFile into xml document
				XmlNodeList shortTargetNodeList = xmlDoc.SelectNodes("iGO/ShortTarget/Target");

				foreach(XmlNode target in shortTargetNodeList)
				{
					string[] single_Target = new string[4];
					single_Target[0] = target["Date"].InnerText;
					single_Target[1] = target["Name"].InnerText;
					single_Target[2] = target["Tag"].InnerText;
					single_Target[3] = target["Status"].InnerText;

					this.shortTarget.Add(single_Target);
				}

				XmlNodeList longTargetNodeList = xmlDoc.SelectNodes("iGO/LongTarget");
				foreach (XmlNode target in longTargetNodeList)
				{
					if(longTargetNodeList.Count==1)
					{
						try
						{
							this.LongTarget.Add(target["Name"].InnerText);
							this.LongTarget.Add(target["Days"].InnerText);
							this.LongTarget.Add(target["Progress"].InnerText);
						}
						catch(System.NullReferenceException)
						{

						}
					}
				}
				//string date = DateTime.Now.ToString("yyyy-MM-dd");
			}
			catch(FileNotFoundException e)
			{
				string initFile = "<iGO>" +
					"<ShortTraget></ShortTraget>"+
					"<LongTarget></LongTarget>" +
					"</iGO>";
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(initFile);//load string initFile into xml document
				xmlDoc.Save("iGO.xml");//save xml document
				LoadTarget();
			}
		}

		public List<string[]> getDateTarget(string date)
		{
			List<string[]> tmp = new List<string[]>();

			foreach(string[] target in this.shortTarget)
			{
				if(target[0].Equals(date))
				{
					tmp.Add(target);
				}
			}

			return tmp;
		}

		public List<string> getLongTarget()
		{
			return this.LongTarget;
		}

		public void setStatus(string date, string name, string tag, string newStatus)
		{
			int index = -1;
			foreach(string[] target in this.shortTarget)
			{
				if(target[0].Equals(date)&&target[1].Equals(name)&&target[2].Equals(tag))
				{
					index = this.shortTarget.IndexOf(target);
					break;
				}
			}

			if(index!=-1)
			{
				this.shortTarget[index][3] = newStatus;
			}

			Save();
		}

		public void ShortTargetEdit(string date,List<string> names,List<string> tags)
		{
			List<string[]> shortTarget_afterEdit = new List<string[]>();
			foreach (string[] s in this.shortTarget)
			{
				shortTarget_afterEdit.Add(s);
			}
			foreach(string[] target in this.shortTarget)
			{
				if (target[0].Equals(date))
				{
					shortTarget_afterEdit.Remove(target);
				}
			}

			for(int index = 0; index<names.Count;index++)
			{
				string[] tomorrow_target = new string[4];
				tomorrow_target[0] = date;
				tomorrow_target[1] = names[index];
				tomorrow_target[2] = tags[index];
				tomorrow_target[3] = "undone";

				shortTarget_afterEdit.Add(tomorrow_target);
			}

			this.shortTarget = shortTarget_afterEdit;
		}

		public void LongTargetAdd(string name,string days)
		{
			if(this.LongTarget.Count<1)
			{
				int zero = 0;
				this.LongTarget.Add(name);
				this.LongTarget.Add(days);
				this.LongTarget.Add(zero.ToString());
			}
		}

		public void ClearLongTarget()
		{
			this.LongTarget.Clear();
		}

		public void LongTargetAddDay()
		{
			if(this.LongTarget.Count>0)
			{
				int allDay = Convert.ToInt32(this.LongTarget[1]);
				int newProgress = Convert.ToInt32(this.LongTarget[2]) + 1;
				this.LongTarget[2] = newProgress.ToString();
			}
		}

		public void Save()
		{
			try
			{
				string s = "<iGO>";

				s += "<ShortTarget>";
				foreach (string[] target in this.shortTarget)
				{
					s += "<Target>";
					s += "<Date>" + target[0] + "</Date>";
					s += "<Name>" + target[1] + "</Name>";
					s += "<Tag>" + target[2] + "</Tag>";
					s += "<Status>" + target[3] + "</Status>";
					s += "</Target>";
				}
				s += "</ShortTarget>";

				s += "<LongTarget>";
				if(this.LongTarget.Count==3)
				{
					s += "<Name>" + this.LongTarget[0] + "</Name>";
					s += "<Days>" + this.LongTarget[1] + "</Days>";
					s += "<Progress>" + this.LongTarget[2] + "</Progress>";
				}
				s += "</LongTarget>";

				s += "</iGO>";
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(s);//load string initFile into xml document
				xmlDoc.Save("iGO.xml");//save xml document
			}
			catch (Exception e)
			{
				MessageBox.Show("ERR: iGO.xml save error\r\n"+e.Message);
			}
		}
	}
}
