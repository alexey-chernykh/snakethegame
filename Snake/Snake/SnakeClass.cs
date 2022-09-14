using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Snake
{
    public class SnakeClass
    {
        public List<BodyPart> Body { get; set; }
        public PictureBox Head { get; set; }
        public Color MainColor { get; set; }
        public RotationState Rotation { get; set; }
        public SnakeClass(Color clr)
        {
            Body = new List<BodyPart>();
            MainColor = clr;
            Head = new PictureBox() {
                BackColor = MainColor, 
                Size = new Size(20, 20), 
                Location = new Point(300, 300) 
            };
            Rotation = RotationState.Right;
        }
        public void Move()
        {
            Point prevHeadLocation;
            switch (Rotation)
            {
                case RotationState.Left:
                    prevHeadLocation = new Point(Head.Location.X, Head.Location.Y);
                    Head.Location = new Point(Head.Location.X - 20, Head.Location.Y);
                    CheckOutOfBounds(Head);
                    if (Body.Count != 0)
                    {
                        foreach (BodyPart item in Body)
                            CheckOutOfBounds(item.part);
                        MoveBody(prevHeadLocation);
                    }
                    break;
                case RotationState.Right:
                    prevHeadLocation = new Point(Head.Location.X, Head.Location.Y);
                    Head.Location = new Point(Head.Location.X + 20, Head.Location.Y);
                    CheckOutOfBounds(Head);
                    if (Body.Count != 0)
                    {
                        foreach (BodyPart item in Body)
                            CheckOutOfBounds(item.part);
                        MoveBody(prevHeadLocation);
                    }
                    break;
                case RotationState.Top:
                    prevHeadLocation = new Point(Head.Location.X, Head.Location.Y);
                    Head.Location = new Point(Head.Location.X, Head.Location.Y - 20);
                    CheckOutOfBounds(Head);
                    if (Body.Count != 0)
                    {
                        foreach (BodyPart item in Body)
                            CheckOutOfBounds(item.part);
                        MoveBody(prevHeadLocation);
                    }
                    break;
                case RotationState.Bottom:
                    prevHeadLocation = new Point(Head.Location.X, Head.Location.Y);
                    Head.Location = new Point(Head.Location.X, Head.Location.Y + 20);
                    CheckOutOfBounds(Head);
                    if (Body.Count != 0)
                    {
                        foreach (BodyPart item in Body)
                            CheckOutOfBounds(item.part);
                        MoveBody(prevHeadLocation);
                    }
                    break;
                default:
                    break;
            }
        }

        internal bool CheckFail()
        {
            foreach (BodyPart item in Body)
            {
                if (item.part.Location == Head.Location)
                    return true;
            }return false;
        }

        private void MoveBody(Point prevHeadLocation)
        {
            Point prevPartLocation = new Point(0,0);
            Point tmp = new Point(0,0);
            for (int i = 0; i < Body.Count; i++)
            {
                if (i == 0)
                {
                    prevPartLocation = new Point(Body[i].part.Location.X, Body[i].part.Location.Y);
                    Body[i].part.Location = new Point(prevHeadLocation.X, prevHeadLocation.Y);
                }
                else
                {
                    tmp = new Point(Body[i].part.Location.X, Body[i].part.Location.Y);
                    Body[i].part.Location = new Point(prevPartLocation.X, prevPartLocation.Y);
                    prevPartLocation = tmp;
                }
                    
            }
        }

        internal void DestroySnake(Form1 form)
        {
            form.Controls.Remove(Head);
            foreach (BodyPart item in Body)
            {
                form.Controls.Remove(item.part);
            }
            Body.Clear();
        }

        private void CheckOutOfBounds(PictureBox obj)
        {
            if (obj.Location.X > 600)
            {
                obj.Location = new Point(0, obj.Location.Y);
            }
            else if (obj.Location.X < 0)
            {
                obj.Location = new Point(600, obj.Location.Y);
            }
            if (obj.Location.Y > 600)
            {
                obj.Location = new Point(obj.Location.X, 0);
            }
            else if (obj.Location.Y < 0)
            {
                obj.Location = new Point(obj.Location.X, 600);
            }
        }

        public void CreateSnake(Form form)
        {
            form.Controls.Add(Head);
        }
        public void AddBody(Form form)
        {
            PictureBox newBodyPart = new PictureBox()
            {
                BackColor = MainColor,
                Size = new Size(20,20)
            };
            Body.Add(new BodyPart(MainColor) { part = newBodyPart});
            switch (Rotation)
            {
                case RotationState.Left:
                    if(Body.Count == 1)
                        Body[Body.Count - 1].part.Location = new Point(Head.Location.X + 20, Head.Location.Y);
                    else
                        Body[Body.Count - 1].part.Location = new Point(Body[Body.Count - 2].part.Location.X + 20, Body[Body.Count - 2].part.Location.Y);
                    break;
                case RotationState.Right:
                    if(Body.Count == 1)
                        Body[Body.Count - 1].part.Location = new Point(Head.Location.X - 20, Head.Location.Y);
                    else
                        Body[Body.Count - 1].part.Location = new Point(Body[Body.Count - 2].part.Location.X - 20, Body[Body.Count - 2].part.Location.Y);
                    break;
                case RotationState.Top:
                    if (Body.Count == 1)
                        Body[Body.Count - 1].part.Location = new Point(Head.Location.X, Head.Location.Y - 20);
                    else
                        Body[Body.Count - 1].part.Location = new Point(Body[Body.Count - 2].part.Location.X, Body[Body.Count - 2].part.Location.Y - 20);
                    break;
                case RotationState.Bottom:
                    if (Body.Count == 1)
                        Body[Body.Count - 1].part.Location = new Point(Head.Location.X, Head.Location.Y + 20);
                    else
                        Body[Body.Count - 1].part.Location = new Point(Body[Body.Count - 2].part.Location.X, Body[Body.Count - 2].part.Location.Y + 20);
                    break;
                default:
                    break;
            }
            form.Controls.Add(Body[Body.Count - 1].part);
        }

        internal void ChangeColor(Color clr)
        {
            MainColor = clr;
            Head.BackColor = MainColor;
            if(Body.Count != 0)
            {
                foreach (BodyPart item in Body)
                {
                    item.part.BackColor = MainColor;
                }
            }
        }
    }
}
