
// 1. Разработать программу, динамически порождающую на окне
// кнопки.Левый верхний угол кнопки определяется местоположением
// курсора при щелчке. Вывести надпись на кнопке с координатами ее левого верхнего угла. 

using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(e.X, e.Y);
                foreach (Control c in this.Controls)
                    if (b is Button) 
                    (b as Button).Text = string.Format("{0}, {1}", e.X, e.Y);
               // b.Text = string.Format("{0}, {1}", e.X, e.Y);

            }
        }

    }
    
}
