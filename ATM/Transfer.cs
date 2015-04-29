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
    public partial class Transfer : Form
    {
        private XmlDocument xmlDoc;
        private XmlNode node;

        public Transfer()
        {
            InitializeComponent();
        }

        public Transfer(XmlDocument xmlDoc,XmlNode node)
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
            if (accountNum.Focused)
            {
                accountNum.Text += "1";
            }
            else if (amount.Focused)
            {
                amount.Text += "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "2";
            }
            else if (amount.Focused)
            {
                amount.Text += "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "3";
            }
            else if (amount.Focused)
            {
                amount.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "4";
            }
            else if (amount.Focused)
            {
                amount.Text += "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "5";
            }
            else if (amount.Focused)
            {
                amount.Text += "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "6";
            }
            else if (amount.Focused)
            {
                amount.Text += "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "7";
            }
            else if (amount.Focused)
            {
                amount.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "8";
            }
            else if (amount.Focused)
            {
                amount.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "9";
            }
            else if (amount.Focused)
            {
                amount.Text += "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "0";
            }
            else if (amount.Focused)
            {
                amount.Text += "0";
            }
        }

        private void n00_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text += "00";
            }
            else if (amount.Focused)
            {
                amount.Text += "00";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (accountNum.Focused)
            {
                accountNum.Text = "";
            }
            else if (amount.Focused)
            {
                amount.Text = "";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            int balance=Convert.ToInt32(node.ParentNode.ChildNodes[2].InnerText);//account balance
            int transferAmount=Convert.ToInt32(amount.Text);//transfer amount
            int temp;
            if(balance<transferAmount){
                MessageBox.Show("Your balance is not enough!","Error");
            }
            else if(!hasAccountNum()){
                MessageBox.Show("The objective account number doesn't exist!","Error");
            }
            else{
                balance=balance-transferAmount;
                node.ParentNode.ChildNodes[2].InnerText=Convert.ToString(balance);
                
                XmlNodeList a_nList = xmlDoc.SelectNodes("//Account_Number");
                foreach (XmlNode node1 in a_nList)
                {
                    //MessageBox.Show(node.InnerText);        
                    if (node1.InnerText == accountNum.Text)
                    {
                        if (MessageBox.Show("Are you sure to transfer $" + amount.Text + " to Accont Number "+accountNum.Text+" ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            temp = Convert.ToInt32(node1.ParentNode.ChildNodes[2].InnerText);
                            temp = temp + transferAmount;
                            node1.ParentNode.ChildNodes[2].InnerText = Convert.ToString(temp);
                            xmlDoc.Save("account.xml");
                            MessageBox.Show("Transfer successfully!", "Tips");
                            axShockwaveFlash2.Visible = true;
                            axShockwaveFlash2.Movie = Application.StartupPath + "\\receipt.swf";
                            Transfer_Load(sender, e);
                            break;
                        }
                    }
                }
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\ccf.swf";
            label7.Text = "Your balance is $" + node.ParentNode.ChildNodes[2].InnerText;
            Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
            SetCursor(a, new Point(70, 40));
        }

        private Boolean hasAccountNum()
        {
            XmlNodeList accountNumList = xmlDoc.SelectNodes("//Account_Number");
            foreach (XmlNode node1 in accountNumList){
                if(node1.InnerText.Equals(accountNum.Text)){
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
