using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DataBaseUsers
{
    public partial class MainForm : Form
    {
        static string pathUsers = "users";
        static int countUsers = Directory.GetFiles(pathUsers).Length - 3;

        Panel[] rows = new Panel[countUsers];
        DateTimePicker[] col3 = new DateTimePicker[countUsers];
        Label[] col2 = new Label[countUsers];
        CheckBox[] col1 = new CheckBox[countUsers];
        string[] arrNameFile;

        public MainForm()
        {
            InitializeComponent();
            StartPath();
            arrNameFile = Directory.GetFiles(pathUsers);
            textBoxSearch.SetWatermark("Начните вводить ID для поиска...");

            if (!File.Exists(pathUsers + "\\users.xml"))
            {
                File.Create(pathUsers + "\\users.xml").Close();
                File.WriteAllText(pathUsers + "\\users.xml", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<users>\n</users>");
            }
            LoadUsers();
        }

        void StartPath()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;

            if (folder.ShowDialog() == DialogResult.OK)
                pathUsers = folder.SelectedPath;
            else Application.Exit();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string str2M3U = File.ReadAllText($"{pathUsers}//2.M3U");
            string str1M3U = File.ReadAllText($"{pathUsers}//1.M3U");

            XDocument xdoc = XDocument.Load(pathUsers + "\\users.xml");
            XElement root = xdoc.Element("users");

            for (int i = 2; i < rows.Length; i++)
            {
                string idName = arrNameFile[i].Replace(".M3U", "").Replace("users\\", "");

                foreach (XElement xe in root.Elements("user").ToList())
                {
                    if (!col1[i].Checked)
                    {
                        File.WriteAllText(arrNameFile[i], "");
                        File.WriteAllText(arrNameFile[i], str2M3U);
                        if (xe.Element("id").Value == idName)
                        {
                            xe.Element("chk").Value = "false";
                            //xe.Element("date").Value = col3[i - 2].Text;
                        }
                    }
                    else
                    {
                        File.WriteAllText(arrNameFile[i], "");
                        File.WriteAllText(arrNameFile[i], str1M3U);
                        if (xe.Element("id").Value == idName)
                        {
                            xe.Element("chk").Value = "true";
                            //xe.Element("date").Value = col3[i - 2].Text;
                        }
                    }
                }
                xdoc.Save(pathUsers + "\\users.xml");
            }
        }

        private void buttonAddID_Click(object sender, EventArgs e)
        {
            AddInXml(textBoxAddID.Text);
            LoadUsers();
        }

        void LoadUsers()
        {
            bool chk = false;
            string date = string.Empty, ID = string.Empty;
            int i = 0;
            
            XDocument xdoc = XDocument.Load(pathUsers + "\\users.xml");
            try
            {
                foreach (XElement user in xdoc.Element("users").Elements("user"))
                {
                    XElement xChk = user.Element("chk");
                    XElement xID = user.Element("id");
                    XElement xDate = user.Element("date");
                        
                    if (xChk.Value == "true")
                        chk = true;
                    else chk = false;
                    ID = xID.Value;
                    date = xDate.Value;

                    rows[i] = new Panel();
                    rows[i].Location = new System.Drawing.Point(0, i * 22);
                    rows[i].Name = "row" + i.ToString();
                    rows[i].Size = new System.Drawing.Size(panelData.Width, 22);
                    rows[i].BorderStyle = BorderStyle.FixedSingle;

                    col3[i] = new DateTimePicker();
                    col3[i].Location = new System.Drawing.Point(panelData.Width - 131, 0);
                    col3[i].Name = "3column" + i.ToString();
                    col3[i].Size = new System.Drawing.Size(130, 28);
                    col3[i].Text = date;

                    col2[i] = new Label();
                    col2[i].Location = new System.Drawing.Point(30, 3);
                    col2[i].Name = "2column" + i.ToString();
                    col2[i].Text = ID;
                    col2[i].Size = new System.Drawing.Size(panelData.Width - 167, 22);

                    col1[i] = new CheckBox();
                    col1[i].Location = new System.Drawing.Point(2, 0);
                    col1[i].Name = "1column" + i.ToString();
                    col1[i].Size = new System.Drawing.Size(35, 20);
                    col1[i].Checked = chk;

                    rows[i].Controls.Add(col3[i]);
                    rows[i].Controls.Add(col2[i]);
                    rows[i].Controls.Add(col1[i]);
                    panelData.Controls.Add(rows[i]);
                    i++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Необходим перезапуск программы для создания файлов!\n" +
                    "Вероятно, записи в файле конфигурации и файлы в папке с пользователями разнятся." +
                    "\nДополнительная информация:\n" + ex,
                                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        void AddInXml(string name)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathUsers + "\\users.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlElement user = xDoc.CreateElement("user");

            XmlElement _chk = xDoc.CreateElement("chk");
            XmlElement _id = xDoc.CreateElement("id");
            XmlElement _date = xDoc.CreateElement("date");

            XmlText chk = xDoc.CreateTextNode("false");
            XmlText id = xDoc.CreateTextNode(name);
            XmlText date = xDoc.CreateTextNode(DateTime.Now.Date.ToString());

            if (name == "ID-")
            {
                MessageBox.Show("Нельзя оставлять поля пустыми!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (XmlNode xnode in xRoot)
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "email")
                        {
                            if (childnode.InnerText == name)
                            {
                                MessageBox.Show("Введеный пользователь уже добавлен!",
                                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                _chk.AppendChild(chk);
                _id.AppendChild(id);
                _date.AppendChild(date);

                user.AppendChild(_chk);
                user.AppendChild(_id);
                user.AppendChild(_date);

                xRoot.AppendChild(user);
                xDoc.Save(pathUsers + "\\users.xml");
            }
            CreateNewFile(textBoxAddID.Text);
        }

        void CreateNewFile(string name)
        {
            if (!File.Exists($"{pathUsers}//{name}.M3U"))
            {
                File.Create($"{pathUsers}//{name}.M3U").Close();
                string str2M3U = File.ReadAllText($"{pathUsers}//2.M3U");
                File.WriteAllText($"{pathUsers}//{name}.M3U", str2M3U);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}