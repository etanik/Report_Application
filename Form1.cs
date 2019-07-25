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
        string username = "TAG";
        string password = "TAG123";


        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text==username && textBox2.Text == password)
            {
                
                this.Hide();
                Form2 rapor = new Form2();
                rapor.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
               
            }
            return;


        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
            
        }
    }
}
