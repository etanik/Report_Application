using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Rapor
{
    public partial class Form1 : Form
    {
        string Username = "TAG";
        string Password = "TAG123";



        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (uname.Text == Username && pword.Text == Password)
            {
                
                this.Hide();
                Form2 rapor = new Form2();
                rapor.Show();

            }
            else
            {
                label1.Text = "The username or password is incorrect!";
               
            }
            return;
            
        }
      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,Color.SkyBlue,Color.Black,90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void Uname_MouseClick(object sender, MouseEventArgs e)
        {
            uname.Clear();
        }

        private void Pword_MouseClick(object sender, MouseEventArgs e)
        {
            pword.Clear();
           
        }

        private void Pword_TextChanged(object sender, EventArgs e)
        {
            pword.PasswordChar = '•';
        }
    }
}
