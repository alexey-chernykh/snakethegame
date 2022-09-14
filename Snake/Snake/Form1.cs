using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;

namespace Snake
{
    public partial class Form1 : Form
    {
        Localization localization = new Localization();
        int score = 0;
        SnakeClass snake;
        Fruit fruit;
        bool havingFruit = false;
        int[] coords = { 
            40, 60, 80, 100,
            120, 140, 160, 180, 200,
            220, 240, 260, 280, 300,
            320, 340, 360, 380, 400,
            420, 440, 460, 480, 500,
            520, 540, 560, 580 
        };
        int[] scoreArr = new int[5];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            labelDeath.Visible = false;
            buttonTryAgain.Visible = false;
            snake = new SnakeClass(Color.Green);
            fruit = new Fruit(
                Color.Red, 
                new Size(20,20), 
                new Point(
                    coords[rnd.Next(0, 27)],
                    coords[rnd.Next(0, 27)]
                    )
                );
            for (int i = 0; i < scoreArr.Length; i++)
            {
                scoreArr[i] = 0;
            }
            if (!File.Exists("score.txt"))
            {
                using (StreamWriter w = new StreamWriter("score.txt"))
                {
                    for (int i = 0; i < scoreArr.Length; i++)
                    {
                        w.WriteLine($"{i + 1}:{scoreArr[i]}");
                    }
                }
            }
            else
            {
                using (StreamReader r = new StreamReader("score.txt", Encoding.UTF8))
                {
                    for (int i = 0; i < scoreArr.Length; i++)
                    {
                        scoreArr[i] = Int32.Parse(r.ReadLine().Split(':')[1]);
                    }
                }
            }
            File.SetAttributes("score.txt", System.IO.FileAttributes.Hidden);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void WorldTimer_Tick(object sender, EventArgs e)
        {
            snake.Move();
            if(!snake.CheckFail()){

            
                if (!havingFruit)
                {
                    fruit.CreateFruit(this);
                    havingFruit = true;
                }
                else
                {
                    if (snake.Head.Location == fruit.Box.Location)
                    {
                        fruit.ChangeLocation(new Point(
                        coords[rnd.Next(0, 27)],
                        coords[rnd.Next(0, 27)]
                        ));
                        snake.AddBody(this);
                        score += 10;
                        if (localization.language == Language.English)
                            labelScore.Text = $"Score: {score}";
                        else if (localization.language == Language.Ukrainian)
                            labelScore.Text = $"Рахунок: {score}";
                        else if (localization.language == Language.Japanese)
                            labelScore.Text = $"スコア: {score}";

                    }
                }
            }
            else
            {
                labelDeath.Visible = true;
                buttonTryAgain.Visible = true;
                buttonReturn.Visible = true;
                int tmp1 = 0;
                for (int i = 0; i < scoreArr.Length; i++)
                {
                    if(score > scoreArr[i])
                    {
                        tmp1 = scoreArr[i];
                        scoreArr[i] = score;
                        score = tmp1;
                    }
                        
                }
                File.SetAttributes("score.txt", System.IO.FileAttributes.Normal);
                using (StreamWriter w = new StreamWriter("score.txt"))
                {
                    for (int i = 0; i < scoreArr.Length; i++)
                    {
                        w.WriteLine($"{i+1}:{scoreArr[i]}");
                    }
                }
                File.SetAttributes("score.txt", System.IO.FileAttributes.Hidden);
                WorldTimer.Stop();
            }
        }
        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            labelDeath.Visible = false;
            buttonTryAgain.Visible = false;
            buttonReturn.Visible = false;

            score = 0;
            if (localization.language == Language.English)
                labelScore.Text = "Score: 0";
            else if(localization.language == Language.Ukrainian)
                labelScore.Text = "Рахунок: 0";
            else if(localization.language == Language.Japanese)
                labelScore.Text = "スコア: 0";

            snake.DestroySnake(this);
            fruit.DestroyFruit(this);
            snake.CreateSnake(this);
            havingFruit = false;
            WorldTimer.Start();
            this.Focus();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            labelScore.Visible = true;

            labelTitle.Visible = false;
            labelCopyright.Visible = false;
            buttonPlay.Visible = false;
            buttonSettings.Visible = false;
            buttonScoreboard.Visible = false;
            buttonExit.Visible = false;
            pictureBoxLogo.Visible = false;
            pictureBoxEnglish.Visible = false;
            pictureBoxUkrainian.Visible = false;
            pictureBoxJapanese.Visible = false;

            snake.CreateSnake(this);
            fruit.DestroyFruit(this);
            havingFruit = false;
            WorldTimer.Start();
            this.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            snake.DestroySnake(this);
            fruit.DestroyFruit(this);
            score = 0;
            if (localization.language == Language.English)
                labelScore.Text = "Score: 0";
            else if (localization.language == Language.Ukrainian)
                labelScore.Text = "Рахунок: 0";
            else if (localization.language == Language.Japanese)
                labelScore.Text = "スコア: 0";

            labelTitle.Visible = true;
            labelCopyright.Visible = true;
            buttonPlay.Visible = true;
            buttonSettings.Visible = true;
            buttonScoreboard.Visible = true;
            buttonExit.Visible = true;
            pictureBoxLogo.Visible = true;
            pictureBoxEnglish.Visible = true;
            pictureBoxUkrainian.Visible = true;
            pictureBoxJapanese.Visible = true;

            labelScore.Visible = false;
            labelDeath.Visible = false;
            buttonTryAgain.Visible = false;
            buttonReturn.Visible = false;
            labelDifficult.Visible = false;
            buttonEasy.Visible = false;
            buttonNormal.Visible = false;
            buttonHard.Visible = false;
            labelTheme.Visible = false;
            buttonStandard.Visible = false;
            buttonNeon.Visible = false;
            buttonDark.Visible = false;
            labelScorePlace.Visible = false;
            labelPlace.Visible = false;
            label01.Visible = false;
            label02.Visible = false;
            label03.Visible = false;
            label04.Visible = false;
            label05.Visible = false;
            labelScore1.Visible = false;
            labelScore2.Visible = false;
            labelScore3.Visible = false;
            labelScore4.Visible = false;
            labelScore5.Visible = false;

            this.Focus();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            labelTitle.Visible = true;
            labelCopyright.Visible = true;
            labelDifficult.Visible = true;
            buttonEasy.Visible = true;
            buttonNormal.Visible = true;
            buttonHard.Visible = true;
            labelTheme.Visible = true;
            buttonStandard.Visible = true;
            buttonNeon.Visible = true;
            buttonDark.Visible = true;
            buttonReturn.Visible = true;

            buttonPlay.Visible = false;
            buttonSettings.Visible = false;
            buttonScoreboard.Visible = false;
            buttonExit.Visible = false;
            labelScore.Visible = false;
            labelDeath.Visible = false;
            buttonTryAgain.Visible = false;
            
            this.Focus();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            buttonEasy.BackColor = Color.Lime;
            buttonNormal.BackColor = Color.Bisque;
            buttonHard.BackColor = Color.Bisque;
            WorldTimer.Interval = 250;
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            buttonEasy.BackColor = Color.Bisque;
            buttonNormal.BackColor = Color.Lime;
            buttonHard.BackColor = Color.Bisque;
            WorldTimer.Interval = 100;
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            buttonEasy.BackColor = Color.Bisque;
            buttonNormal.BackColor = Color.Bisque;
            buttonHard.BackColor = Color.Lime;
            WorldTimer.Interval = 50;
        }

        private void buttonStandard_Click(object sender, EventArgs e)
        {
            buttonStandard.BackColor = Color.Lime;
            buttonNeon.BackColor = Color.Bisque;
            buttonDark.BackColor = Color.Bisque;
            this.BackColor = Color.BurlyWood;
            snake.ChangeColor(Color.Green);
            fruit.Box.BackColor = Color.Red;
        }

        private void buttonNeon_Click(object sender, EventArgs e)
        {
            buttonStandard.BackColor = Color.Bisque;
            buttonNeon.BackColor = Color.Lime;
            buttonDark.BackColor = Color.Bisque;
            this.BackColor = Color.MidnightBlue;
            snake.ChangeColor(Color.Aqua);
            fruit.Box.BackColor = Color.DeepPink;
        }

        private void buttonDark_Click(object sender, EventArgs e)
        {
            buttonStandard.BackColor = Color.Bisque;
            buttonNeon.BackColor = Color.Bisque;
            buttonDark.BackColor = Color.Lime;
            this.BackColor = Color.Black;
            snake.ChangeColor(Color.Lime);
            fruit.Box.BackColor = Color.Red;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(620, 620);
            this.WindowState = FormWindowState.Normal;
        }

        private void buttonScoreboard_Click(object sender, EventArgs e)
        {
            UpdateScoreboard();
            labelTitle.Visible = true;
            labelCopyright.Visible = true;
            labelScorePlace.Visible = true;
            labelPlace.Visible = true;
            label01.Visible = true;
            label02.Visible = true;
            label03.Visible = true;
            label04.Visible = true;
            label05.Visible = true;
            labelScore1.Visible = true;
            labelScore2.Visible = true;
            labelScore3.Visible = true;
            labelScore4.Visible = true;
            labelScore5.Visible = true;
            buttonReturn.Visible = true;

            buttonPlay.Visible = false;
            buttonSettings.Visible = false;
            buttonScoreboard.Visible = false;
            buttonExit.Visible = false;
            labelScore.Visible = false;
            labelDeath.Visible = false;
            buttonTryAgain.Visible = false;

            this.Focus();
        }

        private void UpdateScoreboard()
        {
            labelScore1.Text = scoreArr[0].ToString();
            labelScore2.Text = scoreArr[1].ToString();
            labelScore3.Text = scoreArr[2].ToString();
            labelScore4.Text = scoreArr[3].ToString();
            labelScore5.Text = scoreArr[4].ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (snake.Rotation != RotationState.Bottom)
                        snake.Rotation = RotationState.Top;
                    break;
                case Keys.S:
                    if (snake.Rotation != RotationState.Top)
                        snake.Rotation = RotationState.Bottom;
                    break;
                case Keys.A:
                    if (snake.Rotation != RotationState.Right)
                        snake.Rotation = RotationState.Left;
                    break;
                case Keys.D:
                    if (snake.Rotation != RotationState.Left)
                        snake.Rotation = RotationState.Right;
                    break;
                default:
                    break;
            }
        }

        private void pictureBoxEnglish_Click(object sender, EventArgs e)
        {
            localization.ChangeLanguage(this, Language.English);
        }

        private void pictureBoxUkrainian_Click(object sender, EventArgs e)
        {
            localization.ChangeLanguage(this, Language.Ukrainian);
        }

        private void pictureBoxJapanese_Click(object sender, EventArgs e)
        {
            localization.ChangeLanguage(this, Language.Japanese);
        }
    }
}
