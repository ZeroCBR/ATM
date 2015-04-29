using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;  
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class ATM : Form
    {
        
        public ATM()
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


    private void ATM_Load(object sender, EventArgs e)  
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("handcard.gif");  
        SetCursor(a, new Point(70, 40));
        axShockwaveFlash1.Movie = Application.StartupPath + "\\ccf.swf";
        axShockwaveFlash2.Movie = Application.StartupPath + "\\CBR_Bank.swf";
     }


    private void si_Click(object sender, EventArgs e)
    {    
        SignIn signin = new SignIn();
        signin.ShowDialog();
    }

    private void lo_Click(object sender, EventArgs e)
    {
        LogIn login = new LogIn();
        login.ShowDialog();
    }

    private void exi_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void si_MouseDown(object sender, MouseEventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
        SetCursor(a, new Point(50, 25));
        this.Update();
    }

    private void si_MouseHover(object sender, EventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
        SetCursor(a, new Point(50, 25));
        this.Update();
    }

    private void si_MouseLeave(object sender, EventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
        SetCursor(a, new Point(70, 40));
        this.Update();
    }

    private void lo_MouseDown(object sender, MouseEventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
        SetCursor(a, new Point(50, 25));
        this.Update();
    }

    private void lo_MouseHover(object sender, EventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
        SetCursor(a, new Point(50, 25));
        this.Update();
    }

    private void lo_MouseLeave(object sender, EventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
        SetCursor(a, new Point(70, 40));
        this.Update();
    }

    private void exi_MouseDown(object sender, MouseEventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
        SetCursor(a, new Point(50, 25));
        this.Update();
    }

    private void exi_MouseHover(object sender, EventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("click.gif");
        SetCursor(a, new Point(50, 25));
        this.Update();
    }

    private void exi_MouseLeave(object sender, EventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
        SetCursor(a, new Point(70, 40));
        this.Update();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Bitmap a = (Bitmap)Bitmap.FromFile("cursor.gif");
        SetCursor(a, new Point(70, 40));
        axShockwaveFlash3.Visible = true;
        axShockwaveFlash3.Movie = Application.StartupPath + "\\card.swf";
    }
  }
}
