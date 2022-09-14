using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    public class BodyPart
    {
        public PictureBox part { get; set; }
        public BodyPart(Color color)
        {
            part = new PictureBox()
            {
                BackColor = color,
                Size = new Size(20, 20)
            }; 
        }
    }
}
