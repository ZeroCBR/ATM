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
    public partial class Main : Form
    {
        private XmlDocument xmlDoc;
        private XmlNode node;

        public Main()
        {
            InitializeComponent();
        }

        public Main(XmlDocument xmlDoc,XmlNode node)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(xmlDoc,node);
            deposit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdrawal withdrawal = new Withdrawal(xmlDoc, node);
            withdrawal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckBalance checkBalance = new CheckBalance(xmlDoc,node);
            checkBalance.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(xmlDoc, node);
            transfer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(xmlDoc,node);
            changePassword.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();    
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

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
            this.Update();
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
            SetCursor(a, new Point(50, 25));
            this.Update();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
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

        private void Main_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\ccf.swf";
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
        }
         

    }
}
