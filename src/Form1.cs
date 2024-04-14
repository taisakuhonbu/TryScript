using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryScript
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private bool IsValidString(object s)
		{
			String str = s as String;
			if(str == null)
			{
				return false;
			}
			return str.Length != 0;
		}

		private void SetFile0()
		{
			if(comboBoxFiles.Items.Count > 0)
			{
				comboBoxFiles.SelectedIndex = 0;
			}
		}
		private void SetFileMax()
		{
			if (comboBoxFiles.Items.Count > 0)
			{
				comboBoxFiles.SelectedIndex = comboBoxFiles.Items.Count - 1;
			}
		}

		private void ReadFileList(String filelist)
		{
			System.IO.TextReader r = new System.IO.StreamReader(filelist);
			if (r == null)
			{
				return;
			}
			comboBoxFiles.Items.Clear();
			if (filelist.IndexOf('\\') < 0 && filelist.IndexOf('/') < 0)
			{
				pathFilelist = System.Environment.CurrentDirectory;
			}
			else
			{
				pathFilelist = System.IO.Path.GetDirectoryName(filelist);
			}
			String f0;
			while ((f0 = r.ReadLine()) != null)
			{
				String f = System.IO.Path.Combine(pathFilelist, f0);
				if (System.IO.File.Exists(f))
				{
					comboBoxFiles.Items.Add(f0);
				}
			}
			SetFile0();
			r.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			splitterLeftWidth = splitContainer1.SplitterDistance;

			String filelist = Properties.Settings.Default.FileList;
			if(IsValidString(filelist) == false)
			{
				return;
			}
			ReadFileList(filelist);
		}
		private void buttonFileList_Click(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Filter = "FileList.txt|FileList.txt";
			if(d.ShowDialog() == DialogResult.OK)
			{
				ReadFileList(d.FileName);
			}
		}

		private void comboBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			String f0 = comboBoxFiles.Items[comboBoxFiles.SelectedIndex].ToString();
			String f = System.IO.Path.Combine(pathFilelist, f0);
			System.IO.StreamReader r = new System.IO.StreamReader(f);
			String s = r.ReadToEnd();
			textScript.Text = s;
			r.Close();

			f += ".xml";
			doc = new System.Xml.XmlDocument();
			doc.Load(f);
			topics = doc.GetElementsByTagName("topic");
			current = 0;
			SetDescription();
			textCurrent.Text = (current + 1).ToString();
			textTotal.Text = topics.Count.ToString();
		}

		private int splitterWholeWidth;
		private int splitterLeftWidth;

		private String pathFilelist;
		private System.Xml.XmlDocument doc;
		private System.Xml.XmlNodeList topics;
		private int current;
		private void SetDescription()
		{
			System.Xml.XmlElement e = topics[current] as System.Xml.XmlElement;
			System.Xml.XmlNodeList position = e.GetElementsByTagName("position");
			System.Xml.XmlNodeList desc = e.GetElementsByTagName("desc");
			// ハイライトする位置
			if (position.Count == 0)
			{
				textScript.Select(0, 0);
			}
			else
			{
				if (splitContainer1.SplitterDistance != splitterLeftWidth)
				{
					if (splitterWholeWidth == splitContainer1.Width)
					{
						splitContainer1.SplitterDistance = splitterLeftWidth;
					}
					else
					{
						splitContainer1.SplitterDistance = (int)(splitContainer1.Width * ((decimal)splitterLeftWidth + splitContainer1.SplitterWidth / 2m) / splitterWholeWidth);
					}
				}

				System.Xml.XmlElement p = position[0] as System.Xml.XmlElement;

				String find = p.GetAttribute("find");
				String type = p.GetAttribute("type");
				String skip = p.GetAttribute("skip");

				int n = 0;
				if (IsValidString(skip))
				{
					int.TryParse(skip, out n);
				}
				SelectPhrase(type, find, n, false);
			}
			if (desc.Count == 0)
			{
				webBrowser1.DocumentText = "";
				textEditDesc.Text = "";
			}
			else
			{
				String front0 = "<html><head>{0}</head><body>";
				String front;
				String src = Properties.Settings.Default.CSS;
				String exe = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
				String css = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(exe), src);
				String back = "</body></html>";
				String p0 = "<p>";
				String p1 = "</p>";
				if (System.IO.File.Exists(src))
				{
					front = String.Format(front0, "<link rel=\"stylesheet\" type=\"text/css\" href=\"" + css + "\"/>");
				}
				else
				{
					front = String.Format(front0, "<style>p { line-height: 144%; }</style>");
				}
				String description = desc[0].InnerXml.TrimStart(new char[] { ' ', '\t', '\r', '\n' });
				if (description[0] == '<')
				{
					webBrowser1.DocumentText = front + description + back;
				}
				else
				{
					webBrowser1.DocumentText = front + p0 + description + p1 + back;
				}
				textEditDesc.Text = description;
			}

			textCurrent.Text = (current + 1).ToString();
			textTotal.Text = topics.Count.ToString();

			buttonPrevDesc.Enabled = (current != 0);
			buttonNextDesc.Enabled = (current < topics.Count - 1);
		}

		private int SelectPhrase(String type, String find, int skip, bool findonly)
		{
			int n = skip;
			int i = 0;
			do
			{
				if (type.ToLower() == "word")
				{
					radioNormalFind.Checked = true;
					i = textScript.Text.IndexOf(find, i);
					if (i < 0)
					{
						textScript.Select(0, 0);
						return -1;
					}
					if (findonly == false && n == 0)
					{
						textScript.SelectionStart = i;
						textScript.SelectionLength = find.Length;
						break;
					}
				}
				else if (type.ToLower() == "regex")
				{
					radioRegexFind.Checked = true;
					System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(find);
					System.Text.RegularExpressions.Match m = regex.Match(textScript.Text, i);
					if (m.Success == false)
					{
						textScript.Select(0, 0);
						return -1;
					}
					i = m.Index;
					if (findonly == false && n == 0)
					{
						textScript.SelectionStart = i;
						textScript.SelectionLength = m.Length;
						break;
					}
				}
				else if (type.ToLower() == "line")
				{
					radioLineFind.Checked = true;
					textFind.Text = "";
					int m;
					try
					{
						i = find.IndexOf(',');
						if (i >= 0)
						{   // 指定行から指定の行数
							String[] a = find.Split(new char[] { ',' });
							m = int.Parse(a[0]);
							n = int.Parse(a[1]);
						}
						else
						{
							i = find.IndexOf('-');
							if (i >= 0)
							{   // 指定行から指定行
								String[] a = find.Split(new char[] { '-' });
								m = int.Parse(a[0]);
								n = int.Parse(a[1]);
								n = n - m + 1;
							}
							else
							{
								m = int.Parse(find);
								n = 1;
							}
						}
					}
					catch(Exception)
					{
						break;
					}
					numericUDLineFrom.Value = m;
					numericUDLines.Value = n;

					i = 0;
					int j;
					if (m == 1)
					{
						j = 0;
					}
					else
					{
						j = -1;
					}
					m--;
					while (m > 0)
					{
						j = textScript.Text.IndexOf('\n', i);
						if(j < 0)
						{
							if (findonly == false)
							{
								textScript.Select(0, 0);
							}
							return -1;
						}
						i = j + 1;
						m--;
					}
					int k = textScript.Text.Length;
					while (n > 0)
					{
						k = textScript.Text.IndexOf('\n', i);
						if (k < 0)
						{
							if(n == 1)
							{
								k = textScript.Text.Length;
								break;
							}
							if (findonly == false)
							{
								textScript.Select(0, 0);
							}
							return -1;
						}
						i = k + 1;
						n--;
					}

					if (findonly == false)
					{
						textScript.SelectionStart = j;
						textScript.SelectionLength = k - j;
					}
					return j;
				}
				else
				{
					if (findonly == false)
					{
						splitterWholeWidth = splitContainer1.Width;
						splitterLeftWidth = splitContainer1.SplitterDistance;
						splitContainer1.SplitterDistance = 0;
						textScript.Select(0, 0);
					}
				}
				i += 1;
				n--;
			} while (n >= 0);

			numericUDSkips.Value = skip;
			textFind.Text = find;

			return i - 1;
		}


		private void buttonNextDesc_Click(object sender, EventArgs e)
		{
			if(topics.Count > current + 1)
			{
				current += 1;
				SetDescription();
			}
		}

		private void buttonPrevDesc_Click(object sender, EventArgs e)
		{
			if(0 <= current - 1)
			{
				current -= 1;
				SetDescription();
			}
		}

		private void buttonNextFile_Click(object sender, EventArgs e)
		{
			if(comboBoxFiles.Items.Count > comboBoxFiles.SelectedIndex + 1)
			{
				comboBoxFiles.SelectedIndex = comboBoxFiles.SelectedIndex + 1;
			}
		}

		private void buttonPrevFile_Click(object sender, EventArgs e)
		{
			if(0 <= comboBoxFiles.SelectedIndex - 1)
			{
				comboBoxFiles.SelectedIndex = comboBoxFiles.SelectedIndex - 1;
			}
		}

		private void radioScriptSize0_CheckedChanged(object sender, EventArgs e)
		{
			textScript.Font = new System.Drawing.Font("ＭＳ ゴシック", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
		}

		private void radioScriptSize1_CheckedChanged(object sender, EventArgs e)
		{
			textScript.Font = new System.Drawing.Font("ＭＳ ゴシック", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
		}

		private void radioScriptSize2_CheckedChanged(object sender, EventArgs e)
		{
			textScript.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
		}

		private void radioScriptSize3_CheckedChanged(object sender, EventArgs e)
		{
			textScript.Font = new System.Drawing.Font("ＭＳ ゴシック", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
		}

		private void radioScriptSize4_CheckedChanged(object sender, EventArgs e)
		{
			textScript.Font = new System.Drawing.Font("ＭＳ ゴシック", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
		}

		private void buttonSaveNext_Click(object sender, EventArgs e)
		{
			System.Xml.XmlElement eCurrent = topics[current] as System.Xml.XmlElement;
			System.Xml.XmlElement eTopic = doc.CreateElement("topic");
			eCurrent.ParentNode.InsertAfter(eTopic, eCurrent);
			current++;
			topics = doc.GetElementsByTagName("topic");
			buttonUpdate_Click(sender, e);
		}

		private void buttonSavePrev_Click(object sender, EventArgs e)
		{
			System.Xml.XmlElement eCurrent = topics[current] as System.Xml.XmlElement;
			System.Xml.XmlElement eTopic = doc.CreateElement("topic");
			eCurrent.ParentNode.InsertBefore(eTopic, eCurrent);
			topics = doc.GetElementsByTagName("topic");
			buttonUpdate_Click(sender, e);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			System.Xml.XmlElement eTopic = topics[current] as System.Xml.XmlElement;
			eTopic.RemoveAll();

			System.Xml.XmlElement ePosition = doc.CreateElement("position");
			System.Xml.XmlAttribute aType = doc.CreateAttribute("type");
			if (radioNormalFind.Checked)
			{
				aType.Value = "word";
				System.Xml.XmlAttribute aFind = doc.CreateAttribute("find");
				aFind.Value = textFind.Text;
				System.Xml.XmlAttribute aSkip = doc.CreateAttribute("skip");
				aSkip.Value = numericUDSkips.Value.ToString();
				ePosition.Attributes.Append(aType);
				ePosition.Attributes.Append(aFind);
				ePosition.Attributes.Append(aSkip);
			}
			else if (radioRegexFind.Checked)
			{
				aType.Value = "regex";
				System.Xml.XmlAttribute aFind = doc.CreateAttribute("find");
				aFind.Value = textFind.Text;
				System.Xml.XmlAttribute aSkip = doc.CreateAttribute("skip");
				aSkip.Value = numericUDSkips.Value.ToString();
				ePosition.Attributes.Append(aType);
				ePosition.Attributes.Append(aFind);
				ePosition.Attributes.Append(aSkip);
			}
			else if (radioLineFind.Checked)
			{
				aType.Value = "line";
				System.Xml.XmlAttribute aFind = doc.CreateAttribute("find");
				aFind.Value = numericUDLineFrom.Value.ToString() + "," + numericUDLines.Value.ToString();
				ePosition.Attributes.Append(aType);
				ePosition.Attributes.Append(aFind);
			}
			else
			{
				aType.Value = "none";
				ePosition.Attributes.Append(aType);
			}
			eTopic.AppendChild(ePosition);

			System.Xml.XmlElement eDesc = doc.CreateElement("desc");
			eDesc.InnerXml = textEditDesc.Text;
			eTopic.AppendChild(eDesc);

			doc.Save(System.IO.Path.Combine(pathFilelist, comboBoxFiles.SelectedItem.ToString()) + ".xml");

			textCurrent.Text = (current + 1).ToString();
			textTotal.Text = topics.Count.ToString();

			buttonPrevDesc.Enabled = (current > 0);
			buttonNextDesc.Enabled = (current < topics.Count - 1);
		}

		private void buttonCheckSelection_Click(object sender, EventArgs e)
		{
			String type = "none";
			if (radioNormalFind.Checked)
			{
				type = "word";
			}
			else if (radioRegexFind.Checked)
			{
				type = "regex";
			}
			else if (radioLineFind.Checked)
			{
				type = "line";
				String find = numericUDLineFrom.Value.ToString() + "," + numericUDLines.Value.ToString();
				if (SelectPhrase(type, find, 0, true) >= 0)
				{
					SelectPhrase(type, find, 0, false);
				}
				return;
			}
			if (SelectPhrase(type, textFind.Text, (int)numericUDSkips.Value, true) >= 0)
			{
				SelectPhrase(type, textFind.Text, (int)numericUDSkips.Value, false);
			}
		}

		private void panel2_DoubleClick(object sender, EventArgs e)
		{
			panel1.Visible = !panel1.Visible;
			if(panel1.Visible == false)
            {
				SetDescription();
			}
			panel2.BackColor = Color.DarkBlue;
		}

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
			panel2.BackColor = Color.DarkBlue;
			if (e.Button == MouseButtons.Right)
			{
				OpenFileDialog d = new OpenFileDialog();
				d.Multiselect = true;
				if (d.ShowDialog() == DialogResult.OK)
				{
					String dir = System.IO.Path.GetDirectoryName(d.FileNames[0]);
					String filelist = System.IO.Path.Combine(dir, "FileList.txt");
					System.IO.StreamWriter w0 = new System.IO.StreamWriter(filelist);
					foreach (String f in d.FileNames)
					{
						w0.WriteLine(System.IO.Path.GetFileName(f));
						System.IO.StreamWriter w = new System.IO.StreamWriter(f + ".xml");
						w.WriteLine("<root>");
						w.WriteLine("  <topic>");
						w.WriteLine("    <position type=\"none\"/>");
						w.WriteLine("    <desc>");
						w.WriteLine("	   <h1>" + System.IO.Path.GetFileName(f) + " を解説します</h1>");
						w.WriteLine("    </desc>");
						w.WriteLine("  </topic>");
						w.WriteLine("</root>");
						w.Close();
					}
					w0.Close();
					ReadFileList(filelist);
				}
			}
        }
    }
}
