using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    public class Fruit
    {
        public PictureBox Box { get; set; }
        public Fruit(Color color, Size size, Point location)
        {
            Box = new PictureBox()
            {
                BackColor = color,
                Size = size,
                Location = new Point(location.X, location.Y)
            };
        }
        public void CreateFruit(Form form)
        {
            form.Controls.Add(Box);
        }

        internal void ChangeLocation(Point point)
        {
            Box.Location = point;
        }

        internal void DestroyFruit(Form1 form)
        {
            form.Controls.Remove(Box);
        }
    }
}
