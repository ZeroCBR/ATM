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
    public partial class ChangePassword : Form
    {
        private XmlDocument xmlDoc;
        private XmlNode node;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(XmlDocument xmlDoc,XmlNode node)
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\ccf.swf";
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
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

        private void n1_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "1";
            }
            else if (np.Focused)
            {
                np.Text += "1";
            }
            else if (cp.Focused)
            {
                cp.Text += "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "2";
            }
            else if (np.Focused)
            {
                np.Text += "2";
            }
            else if (cp.Focused)
            {
                cp.Text += "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "3";
            }
            else if (np.Focused)
            {
                np.Text += "3";
            }
            else if (cp.Focused)
            {
                cp.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "4";
            }
            else if (np.Focused)
            {
                np.Text += "4";
            }
            else if (cp.Focused)
            {
                cp.Text += "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "5";
            }
            else if (np.Focused)
            {
                np.Text += "5";
            }
            else if (cp.Focused)
            {
                cp.Text += "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "6";
            }
            else if (np.Focused)
            {
                np.Text += "6";
            }
            else if (cp.Focused)
            {
                cp.Text += "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "7";
            }
            else if (np.Focused)
            {
                np.Text += "7";
            }
            else if (cp.Focused)
            {
                cp.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "8";
            }
            else if (np.Focused)
            {
                np.Text += "8";
            }
            else if (cp.Focused)
            {
                cp.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "9";
            }
            else if (np.Focused)
            {
                np.Text += "9";
            }
            else if (cp.Focused)
            {
                cp.Text += "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "0";
            }
            else if (np.Focused)
            {
                np.Text += "0";
            }
            else if (cp.Focused)
            {
                cp.Text += "0";
            }
        }

        private void n00_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text += "00";
            }
            else if (np.Focused)
            {
                np.Text += "00";
            }
            else if (cp.Focused)
            {
                cp.Text += "00";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (op.Focused)
            {
                op.Text = "";
            }
            else if (np.Focused)
            {
                np.Text = "";
            }
            else if (cp.Focused)
            {
                cp.Text = "";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (op.Text == "" || np.Text == "" || cp.Text == "")
            {
                MessageBox.Show("Lack of information!", "Error");
            }
            else if (op.Text != node.ParentNode.ChildNodes[1].InnerText)
            {
                MessageBox.Show("Old Password is incorrect!", "Error");
            }
            else if (np.Text != cp.Text)
            {
                MessageBox.Show("Password don't match!", "Error");
            }
            else if (np.Text.Length < 6)
            {
                MessageBox.Show("The length of password can't be less than 6", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure to change your password ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    node.ParentNode.ChildNodes[1].InnerText = np.Text;
                    xmlDoc.Save("account.xml");
                    this.Close();
                }
            }
        }


    }
}
