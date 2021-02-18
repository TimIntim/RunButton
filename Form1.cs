using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Form : MaterialForm
    {
        // Дезигн
        public Form() 
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE);

            // Чтобы форму не закрыли
            this.ControlBox = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            // Получение координат мыши
            int CursorX = e.X;
            int CursorY = e.Y;

            // Инициализация краев кнопки
            int LeftBorder = ButtonNo.Left;
            int RightBorder = ButtonNo.Left + ButtonNo.Size.Width;
            int UpBorder = ButtonNo.Top;
            int DownBorder = ButtonNo.Top + ButtonNo.Size.Height;

            // Инициализация областей вокруг мыши
            int AreaLeftButton = LeftBorder - 50;
            int AreaRightButton = RightBorder + 50;
            int AreaUpButton = UpBorder - 30;
            int AreaDownButton = DownBorder + 30;

            // Код для "убегания мыши"
            if ((CursorX > AreaLeftButton) & (CursorX < AreaRightButton) & 
                (CursorY > AreaUpButton) & (CursorY < AreaDownButton))
            {
                if (CursorX < LeftBorder)
                    ButtonNo.Left += 2;
                else if (CursorX > RightBorder)
                    ButtonNo.Left -= 2;

                if (CursorY < UpBorder)
                    ButtonNo.Top += 2;
                else if (CursorY > DownBorder)
                    ButtonNo.Top -= 2;
                }

            // Чтобы кнопка не вылазила за края формы
            Random rand = new Random();
            if ((RightBorder >= this.Width) | (LeftBorder <= 0) | (UpBorder <= 62) | (DownBorder >= this.Height))
            {
                ButtonNo.Left = rand.Next(this.Width);
                ButtonNo.Top = rand.Next(this.Height);
            }
        }

        // При наведении курсора на кнопку
        private void materialRaisedButton2_MouseMove(object sender, MouseEventArgs e) 
        {
            Random rand = new Random();

            ButtonNo.Left = rand.Next(this.Width);
            ButtonNo.Top = rand.Next(this.Height);
        }

        // При нажатии кнопки "Да"
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я так и знал)");
            Close();
        }
    }
}
