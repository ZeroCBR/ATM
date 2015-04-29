using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public void SetCursor(Bitmap cursor, Point hotPoint)
        {
            int hotX = hotPoint.X;
            int hotY = hotPoint.Y;
            try
            {
                Bitmap myNewCursor = new Bitmap(cursor.Width * 2 - hotX, cursor.Height * 2 - hotY);
                Graphics g = Graphics.FromImage(myNewCursor);
                //g.Clear(Color.FromArgb(0, 0, 0, 0));  
                g.DrawImage(cursor, cursor.Width - hotX, cursor.Height - hotY, cursor.Width, cursor.Height);
                this.Cursor = new Cursor(myNewCursor.GetHicon());
                g.Dispose();
                myNewCursor.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\ccf.swf";
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "1";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "1";
            }
            else if (password.Focused)
            {
                password.Text += "1";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "2";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "2";
            }
            else if (password.Focused)
            {
                password.Text += "2";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "3";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "3";
            }
            else if (password.Focused)
            {
                password.Text += "3";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "4";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "4";
            }
            else if (password.Focused)
            {
                password.Text += "4";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "5";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "5";
            }
            else if (password.Focused)
            {
                password.Text += "5";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "6";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "6";
            }
            else if (password.Focused)
            {
                password.Text += "6";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "7";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "7";
            }
            else if (password.Focused)
            {
                password.Text += "7";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "8";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "8";
            }
            else if (password.Focused)
            {
                password.Text += "8";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "9";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "9";
            }
            else if (password.Focused)
            {
                password.Text += "9";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "0";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "0";
            }
            else if (password.Focused)
            {
                password.Text += "0";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "0";
            }
        }

        private void n00_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text += "00";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text += "00";
            }
            else if (password.Focused)
            {
                password.Text += "00";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text += "00";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (accountID.Focused)
            {
                accountID.Text = "";
            }
            else if (accountNum.Focused)
            {
                accountNum.Text = "";
            }
            else if (password.Focused)
            {
                password.Text = "";
            }
            else if (conPassword.Focused)
            {
                conPassword.Text = "";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (accountID.Text == "" || password.Text == "" || conPassword.Text == "")
            {
                MessageBox.Show("Lack of information!", "Error");
            }
            else if (password.Text != conPassword.Text)
            {
                MessageBox.Show("Password don't match!", "Error");
            }
            else if (password.Text.Length < 6)
            {
                MessageBox.Show("The length of password can't be less than 6", "Error");
            }
            else
            {
                if (File.Exists("account.xml"))
                {
                    //MessageBox.Show("File has already existed!\nWe will add the data!", "Warning");
                    //complete the code here to insert new produce info
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("account.xml");
                    if (sameNum(xmlDoc))
                    {
                        MessageBox.Show("The Account Number has been registered!", "Error");
                    }
                    else if (sameID(xmlDoc))
                    {
                        XmlNode root = xmlDoc.SelectSingleNode("Information");
                        XmlNodeList idList = xmlDoc.SelectNodes("//Account_ID");
                        foreach (XmlNode node in idList)
                        {
                            XmlElement xe = (XmlElement)node;
                            if (xe.GetAttribute("id") == accountID.Text)
                            {                                
                                XmlElement xe2 = xmlDoc.CreateElement("Account");
                                XmlElement xesub1 = xmlDoc.CreateElement("Account_Number");                             
                                xesub1.InnerText = accountNum.Text;
                                xe2.AppendChild(xesub1);
                                XmlElement xesub2 = xmlDoc.CreateElement("Password");
                                xesub2.InnerText = password.Text;
                                xe2.AppendChild(xesub2);
                                XmlElement xesub3 = xmlDoc.CreateElement("Balance");
                                xesub3.InnerText = "0";
                                xe2.AppendChild(xesub3);
                                xe.AppendChild(xe2);
                                //root.AppendChild(xe);
                                xmlDoc.Save("account.xml");
                                MessageBox.Show("Register successfully!SAMEID", "Tips");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        XmlNode root = xmlDoc.SelectSingleNode("Information");
                        XmlElement xe1 = xmlDoc.CreateElement("Account_ID");
                        xe1.SetAttribute("id", accountID.Text);
                        XmlElement xe2 = xmlDoc.CreateElement("Account");
                        XmlElement xesub1 = xmlDoc.CreateElement("Account_Number");
                        xesub1.InnerText = accountNum.Text;
                        xe2.AppendChild(xesub1);
                        XmlElement xesub2 = xmlDoc.CreateElement("Password");
                        xesub2.InnerText = password.Text;
                        xe2.AppendChild(xesub2);
                        XmlElement xesub3 = xmlDoc.CreateElement("Balance");
                        xesub3.InnerText = "0";
                        xe2.AppendChild(xesub3);
                        xe1.AppendChild(xe2);
                        root.AppendChild(xe1);
                        xmlDoc.Save("account.xml");
                        MessageBox.Show("Register successfully!NOTSAMEID", "Tips"); 
                        this.Close();
                    }
                }
                else //The file does not exist, we'll create it
                {
                    XmlTextWriter writer = new XmlTextWriter("account.xml", System.Text.Encoding.UTF8);
                    writer.WriteStartDocument(true);
                    writer.Formatting = Formatting.Indented;
                    writer.Indentation = 2;
                    writer.WriteStartElement("Information");
                    createNode(accountID.Text, accountNum.Text, password.Text, 0, writer);
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                    //MessageBox.Show("XML File created!", "Tips");
                    MessageBox.Show("Register successfully!", "Tips"); 
                    this.Close();

                }
            }
        }

        private void createNode(string accountID,string accountNum, string password, int balance, XmlTextWriter writer)
        {
            writer.WriteStartElement("Account_ID");
            writer.WriteAttributeString("id",accountID);
            writer.WriteStartElement("Account");
            writer.WriteStartElement("Account_Number");
            writer.WriteString(accountNum);
            writer.WriteEndElement();
            writer.WriteStartElement("Password");
            writer.WriteString(password);
            writer.WriteEndElement();
            writer.WriteStartElement("Balance");
            writer.WriteValue(balance);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       private Boolean sameID(XmlDocument xmlDoc)
        {
            XmlNodeList idList = xmlDoc.SelectNodes("//Account_ID");
            foreach (XmlNode node in idList)
            {
                XmlElement xe = (XmlElement)node;
                if (xe.GetAttribute("id") == accountID.Text)
                {
                    return true;
                }
            }
            return false;
        }
        
        private Boolean sameNum(XmlDocument xmlDoc)
        {
            XmlNodeList numList = xmlDoc.SelectNodes("//Account_Number");
            foreach (XmlNode node in numList)
            {
                if (node.InnerText == accountNum.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void n1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n1_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n1_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n2_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n2_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n2_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n3_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n3_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n3_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n4_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n4_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n4_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n5_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n5_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n5_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n6_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n6_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n6_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n7_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n7_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n7_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n8_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n8_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n8_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n9_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n9_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n9_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n0_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n0_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n0_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void n00_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n00_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void n00_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void clear_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void clear_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void clear_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void exit_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void enter_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void enter_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void enter_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }
    }            
}
