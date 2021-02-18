using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run__button__RUN__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет");
        }
        
        // Проверка события наведения мышки на кнопку 
        //private void button1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    Random rand = new Random();
        //    button1.Left = rand.Next(0, this.Width - button1.Width);
        //} //вава

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int CursorX = e.x;        
            Random rand = new Random();
            if ((CursorX >= (button1.Left - 30)) & (CursorX <= (button1.Left + button1.Width + 30)))
            {
                button1.Left = rand.Next(0, this.Width - button1.Width);
            }
        }
    }
}
