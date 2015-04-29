using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Withdrawal : Form
    {
        private XmlDocument xmlDoc;
        private XmlNode node;
        
        public Withdrawal()
        {
            InitializeComponent();
        }
        
        public Withdrawal(XmlDocument xmlDoc,XmlNode node)
        {
            InitializeComponent();
            this.xmlDoc = xmlDoc;
            this.node = node;
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

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "0";
            }
        }

        private void n00_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "00";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text = "";
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp=Convert.ToInt32(node.ParentNode.ChildNodes[2].InnerText);
            if (temp < 1000)
            {
                MessageBox.Show("Not sufficient funds!", "Error");
            }
            else{
                if (MessageBox.Show("Are you sure to withdrawal $1000 ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    temp -= 1000;
                    node.ParentNode.ChildNodes[2].InnerText = Convert.ToString(temp);
                    xmlDoc.Save("account.xml");
                    MessageBox.Show("Withdrawal successfully!", "Tips");
                    axShockwaveFlash1.Visible = true;
                    axShockwaveFlash1.Movie = Application.StartupPath + "\\RMB.swf";
                    axShockwaveFlash2.Visible = true;
                    axShockwaveFlash2.Movie = Application.StartupPath + "\\receipt.swf";
                    Withdrawal_Load(sender, e);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(node.ParentNode.ChildNodes[2].InnerText);
            if (temp < 500)
            {
                MessageBox.Show("Not sufficient funds!", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure to withdrawal $500 ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    temp -= 500;
                    node.ParentNode.ChildNodes[2].InnerText = Convert.ToString(temp);
                    xmlDoc.Save("account.xml");
                    MessageBox.Show("Deposit successfully!", "Tips");
                    axShockwaveFlash1.Visible = true;
                    axShockwaveFlash1.Movie = Application.StartupPath + "\\RMB.swf";
                    axShockwaveFlash2.Visible = true;
                    axShockwaveFlash2.Movie = Application.StartupPath + "\\receipt.swf";
                    Withdrawal_Load(sender, e);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(node.ParentNode.ChildNodes[2].InnerText);
            if (temp < 200)
            {
                MessageBox.Show("Not sufficient funds!", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure to withdrawal $200 ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    temp -= 200;
                    node.ParentNode.ChildNodes[2].InnerText = Convert.ToString(temp);
                    xmlDoc.Save("account.xml");
                    MessageBox.Show("Deposit successfully!", "Tips");
                    axShockwaveFlash1.Visible = true;
                    axShockwaveFlash1.Movie = Application.StartupPath + "\\RMB.swf";
                    axShockwaveFlash2.Visible = true;
                    axShockwaveFlash2.Movie = Application.StartupPath + "\\receipt.swf";
                    Withdrawal_Load(sender, e);
                }
            }
        }

        private void Withdrawal_Load(object sender, EventArgs e)
        {
            axShockwaveFlash3.Movie = Application.StartupPath + "\\ccf.swf";
            label7.Text = "Your balance is $" + node.ParentNode.ChildNodes[2].InnerText;
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox1.Text.Equals("0"))
            {
                MessageBox.Show("You can't withdrawal nothing!", "Error");
            }
            else if(Convert.ToInt32(textBox1.Text)>Convert.ToInt32(node.ParentNode.ChildNodes[2].InnerText)){
                MessageBox.Show("Not sufficient funds!", "Error");
            }
            else if (Convert.ToInt32(textBox1.Text) >= 20000)
            {
                MessageBox.Show("You can't withdrawal greater than $20000!", "Error");
            }
            else if (Convert.ToInt32(textBox1.Text) % 100 != 0)
            {
                MessageBox.Show("You can only withdrawal the money in unit of 100!", "Error");
            }
            else if (Convert.ToInt32(node.ParentNode.ChildNodes[2].InnerText) >= Convert.ToInt32(textBox1.Text))
            {
                if (MessageBox.Show("Are you sure to withdrawal $" + textBox1.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int temp = Convert.ToInt32(node.ParentNode.ChildNodes[2].InnerText) - Convert.ToInt32(textBox1.Text);
                    node.ParentNode.ChildNodes[2].InnerText = Convert.ToString(temp);
                    xmlDoc.Save("account.xml");
                    MessageBox.Show("Withdrawal successfully!", "Tips");
                    axShockwaveFlash1.Visible = true;
                    axShockwaveFlash1.Movie = Application.StartupPath + "\\RMB.swf";
                    axShockwaveFlash2.Visible = true;
                    axShockwaveFlash2.Movie = Application.StartupPath + "\\receipt.swf";
                    Withdrawal_Load(sender, e);
                }
            }
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

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }           
}
