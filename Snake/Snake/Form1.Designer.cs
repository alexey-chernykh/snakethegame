namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WorldTimer = new System.Windows.Forms.Timer(this.components);
            this.labelDeath = new System.Windows.Forms.Label();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonScoreboard = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelDifficult = new System.Windows.Forms.Label();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.labelTheme = new System.Windows.Forms.Label();
            this.buttonStandard = new System.Windows.Forms.Button();
            this.buttonNeon = new System.Windows.Forms.Button();
            this.buttonDark = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelScorePlace = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.label05 = new System.Windows.Forms.Label();
            this.labelScore4 = new System.Windows.Forms.Label();
            this.labelScore3 = new System.Windows.Forms.Label();
            this.labelScore5 = new System.Windows.Forms.Label();
            this.pictureBoxJapanese = new System.Windows.Forms.PictureBox();
            this.pictureBoxUkrainian = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnglish = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJapanese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUkrainian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldTimer
            // 
            this.WorldTimer.Tick += new System.EventHandler(this.WorldTimer_Tick);
            // 
            // labelDeath
            // 
            this.labelDeath.AutoSize = true;
            this.labelDeath.BackColor = System.Drawing.Color.Transparent;
            this.labelDeath.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeath.ForeColor = System.Drawing.Color.Brown;
            this.labelDeath.Location = new System.Drawing.Point(189, 250);
            this.labelDeath.Name = "labelDeath";
            this.labelDeath.Size = new System.Drawing.Size(219, 49);
            this.labelDeath.TabIndex = 0;
            this.labelDeath.Text = "You failed!";
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.BackColor = System.Drawing.Color.Bisque;
            this.buttonTryAgain.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTryAgain.ForeColor = System.Drawing.Color.Brown;
            this.buttonTryAgain.Location = new System.Drawing.Point(210, 360);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(176, 42);
            this.buttonTryAgain.TabIndex = 1;
            this.buttonTryAgain.Text = "Try Again";
            this.buttonTryAgain.UseVisualStyleBackColor = false;
            this.buttonTryAgain.Click += new System.EventHandler(this.buttonTryAgain_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Brown;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(117, 35);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score: 0";
            this.labelScore.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Brown;
            this.labelTitle.Location = new System.Drawing.Point(149, 135);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(325, 51);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Snake The Game";
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Bisque;
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Brown;
            this.buttonPlay.Location = new System.Drawing.Point(210, 215);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(176, 42);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Bisque;
            this.buttonSettings.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Brown;
            this.buttonSettings.Location = new System.Drawing.Point(210, 263);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(176, 42);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonScoreboard
            // 
            this.buttonScoreboard.BackColor = System.Drawing.Color.Bisque;
            this.buttonScoreboard.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScoreboard.ForeColor = System.Drawing.Color.Brown;
            this.buttonScoreboard.Location = new System.Drawing.Point(210, 312);
            this.buttonScoreboard.Name = "buttonScoreboard";
            this.buttonScoreboard.Size = new System.Drawing.Size(176, 42);
            this.buttonScoreboard.TabIndex = 6;
            this.buttonScoreboard.Text = "Scoreboard";
            this.buttonScoreboard.UseVisualStyleBackColor = false;
            this.buttonScoreboard.Click += new System.EventHandler(this.buttonScoreboard_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Bisque;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Brown;
            this.buttonExit.Location = new System.Drawing.Point(210, 360);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(176, 42);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(15, 555);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(243, 18);
            this.labelCopyright.TabIndex = 8;
            this.labelCopyright.Text = "Copyright © 2022. All Rights Reserved.";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Bisque;
            this.buttonReturn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.Brown;
            this.buttonReturn.Location = new System.Drawing.Point(210, 408);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(176, 42);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Return to Menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Visible = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelDifficult
            // 
            this.labelDifficult.AutoSize = true;
            this.labelDifficult.BackColor = System.Drawing.Color.Transparent;
            this.labelDifficult.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficult.ForeColor = System.Drawing.Color.Brown;
            this.labelDifficult.Location = new System.Drawing.Point(37, 222);
            this.labelDifficult.Name = "labelDifficult";
            this.labelDifficult.Size = new System.Drawing.Size(121, 30);
            this.labelDifficult.TabIndex = 10;
            this.labelDifficult.Text = "Difficulty:";
            this.labelDifficult.Visible = false;
            // 
            // buttonEasy
            // 
            this.buttonEasy.BackColor = System.Drawing.Color.Bisque;
            this.buttonEasy.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEasy.ForeColor = System.Drawing.Color.Brown;
            this.buttonEasy.Location = new System.Drawing.Point(184, 216);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(110, 42);
            this.buttonEasy.TabIndex = 11;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = false;
            this.buttonEasy.Visible = false;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonNormal
            // 
            this.buttonNormal.BackColor = System.Drawing.Color.Lime;
            this.buttonNormal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNormal.ForeColor = System.Drawing.Color.Brown;
            this.buttonNormal.Location = new System.Drawing.Point(300, 216);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(110, 42);
            this.buttonNormal.TabIndex = 12;
            this.buttonNormal.Text = "Normal";
            this.buttonNormal.UseVisualStyleBackColor = false;
            this.buttonNormal.Visible = false;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.BackColor = System.Drawing.Color.Bisque;
            this.buttonHard.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHard.ForeColor = System.Drawing.Color.Brown;
            this.buttonHard.Location = new System.Drawing.Point(416, 216);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(110, 42);
            this.buttonHard.TabIndex = 13;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = false;
            this.buttonHard.Visible = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.BackColor = System.Drawing.Color.Transparent;
            this.labelTheme.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheme.ForeColor = System.Drawing.Color.Brown;
            this.labelTheme.Location = new System.Drawing.Point(68, 277);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(89, 30);
            this.labelTheme.TabIndex = 14;
            this.labelTheme.Text = "Theme:";
            this.labelTheme.Visible = false;
            // 
            // buttonStandard
            // 
            this.buttonStandard.BackColor = System.Drawing.Color.Lime;
            this.buttonStandard.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStandard.ForeColor = System.Drawing.Color.Brown;
            this.buttonStandard.Location = new System.Drawing.Point(184, 270);
            this.buttonStandard.Name = "buttonStandard";
            this.buttonStandard.Size = new System.Drawing.Size(110, 42);
            this.buttonStandard.TabIndex = 15;
            this.buttonStandard.Text = "Standard";
            this.buttonStandard.UseVisualStyleBackColor = false;
            this.buttonStandard.Visible = false;
            this.buttonStandard.Click += new System.EventHandler(this.buttonStandard_Click);
            // 
            // buttonNeon
            // 
            this.buttonNeon.BackColor = System.Drawing.Color.Bisque;
            this.buttonNeon.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeon.ForeColor = System.Drawing.Color.Brown;
            this.buttonNeon.Location = new System.Drawing.Point(300, 270);
            this.buttonNeon.Name = "buttonNeon";
            this.buttonNeon.Size = new System.Drawing.Size(110, 42);
            this.buttonNeon.TabIndex = 16;
            this.buttonNeon.Text = "Neon";
            this.buttonNeon.UseVisualStyleBackColor = false;
            this.buttonNeon.Visible = false;
            this.buttonNeon.Click += new System.EventHandler(this.buttonNeon_Click);
            // 
            // buttonDark
            // 
            this.buttonDark.BackColor = System.Drawing.Color.Bisque;
            this.buttonDark.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDark.ForeColor = System.Drawing.Color.Brown;
            this.buttonDark.Location = new System.Drawing.Point(416, 270);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(110, 42);
            this.buttonDark.TabIndex = 17;
            this.buttonDark.Text = "Classic";
            this.buttonDark.UseVisualStyleBackColor = false;
            this.buttonDark.Visible = false;
            this.buttonDark.Click += new System.EventHandler(this.buttonDark_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.BackColor = System.Drawing.Color.Transparent;
            this.labelPlace.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlace.ForeColor = System.Drawing.Color.Brown;
            this.labelPlace.Location = new System.Drawing.Point(104, 194);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(74, 30);
            this.labelPlace.TabIndex = 18;
            this.labelPlace.Text = "Place:";
            this.labelPlace.Visible = false;
            // 
            // labelScorePlace
            // 
            this.labelScorePlace.AutoSize = true;
            this.labelScorePlace.BackColor = System.Drawing.Color.Transparent;
            this.labelScorePlace.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlace.ForeColor = System.Drawing.Color.Brown;
            this.labelScorePlace.Location = new System.Drawing.Point(260, 194);
            this.labelScorePlace.Name = "labelScorePlace";
            this.labelScorePlace.Size = new System.Drawing.Size(81, 30);
            this.labelScorePlace.TabIndex = 19;
            this.labelScorePlace.Text = "Score:";
            this.labelScorePlace.Visible = false;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.BackColor = System.Drawing.Color.Transparent;
            this.label01.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.ForeColor = System.Drawing.Color.Brown;
            this.label01.Location = new System.Drawing.Point(132, 230);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(46, 28);
            this.label01.TabIndex = 20;
            this.label01.Text = "01:";
            this.label01.Visible = false;
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.BackColor = System.Drawing.Color.Transparent;
            this.labelScore1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore1.ForeColor = System.Drawing.Color.Brown;
            this.labelScore1.Location = new System.Drawing.Point(299, 232);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(39, 28);
            this.labelScore1.TabIndex = 21;
            this.labelScore1.Text = "...";
            this.labelScore1.Visible = false;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.BackColor = System.Drawing.Color.Transparent;
            this.label02.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label02.ForeColor = System.Drawing.Color.Brown;
            this.label02.Location = new System.Drawing.Point(126, 258);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(52, 28);
            this.label02.TabIndex = 22;
            this.label02.Text = "02:";
            this.label02.Visible = false;
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.BackColor = System.Drawing.Color.Transparent;
            this.labelScore2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore2.ForeColor = System.Drawing.Color.Brown;
            this.labelScore2.Location = new System.Drawing.Point(299, 260);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(39, 28);
            this.labelScore2.TabIndex = 23;
            this.labelScore2.Text = "...";
            this.labelScore2.Visible = false;
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.BackColor = System.Drawing.Color.Transparent;
            this.label03.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label03.ForeColor = System.Drawing.Color.Brown;
            this.label03.Location = new System.Drawing.Point(126, 286);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(52, 28);
            this.label03.TabIndex = 24;
            this.label03.Text = "03:";
            this.label03.Visible = false;
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.BackColor = System.Drawing.Color.Transparent;
            this.label04.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label04.ForeColor = System.Drawing.Color.Brown;
            this.label04.Location = new System.Drawing.Point(126, 314);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(52, 28);
            this.label04.TabIndex = 25;
            this.label04.Text = "04:";
            this.label04.Visible = false;
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.BackColor = System.Drawing.Color.Transparent;
            this.label05.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label05.ForeColor = System.Drawing.Color.Brown;
            this.label05.Location = new System.Drawing.Point(126, 342);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(52, 28);
            this.label05.TabIndex = 26;
            this.label05.Text = "05:";
            this.label05.Visible = false;
            // 
            // labelScore4
            // 
            this.labelScore4.AutoSize = true;
            this.labelScore4.BackColor = System.Drawing.Color.Transparent;
            this.labelScore4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore4.ForeColor = System.Drawing.Color.Brown;
            this.labelScore4.Location = new System.Drawing.Point(299, 316);
            this.labelScore4.Name = "labelScore4";
            this.labelScore4.Size = new System.Drawing.Size(39, 28);
            this.labelScore4.TabIndex = 28;
            this.labelScore4.Text = "...";
            this.labelScore4.Visible = false;
            // 
            // labelScore3
            // 
            this.labelScore3.AutoSize = true;
            this.labelScore3.BackColor = System.Drawing.Color.Transparent;
            this.labelScore3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore3.ForeColor = System.Drawing.Color.Brown;
            this.labelScore3.Location = new System.Drawing.Point(299, 288);
            this.labelScore3.Name = "labelScore3";
            this.labelScore3.Size = new System.Drawing.Size(39, 28);
            this.labelScore3.TabIndex = 27;
            this.labelScore3.Text = "...";
            this.labelScore3.Visible = false;
            // 
            // labelScore5
            // 
            this.labelScore5.AutoSize = true;
            this.labelScore5.BackColor = System.Drawing.Color.Transparent;
            this.labelScore5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore5.ForeColor = System.Drawing.Color.Brown;
            this.labelScore5.Location = new System.Drawing.Point(299, 344);
            this.labelScore5.Name = "labelScore5";
            this.labelScore5.Size = new System.Drawing.Size(39, 28);
            this.labelScore5.TabIndex = 29;
            this.labelScore5.Text = "...";
            this.labelScore5.Visible = false;
            // 
            // pictureBoxJapanese
            // 
            this.pictureBoxJapanese.Image = global::Snake.Properties.Resources.japanese_flag;
            this.pictureBoxJapanese.Location = new System.Drawing.Point(406, 526);
            this.pictureBoxJapanese.Name = "pictureBoxJapanese";
            this.pictureBoxJapanese.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxJapanese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJapanese.TabIndex = 33;
            this.pictureBoxJapanese.TabStop = false;
            this.pictureBoxJapanese.Click += new System.EventHandler(this.pictureBoxJapanese_Click);
            // 
            // pictureBoxUkrainian
            // 
            this.pictureBoxUkrainian.Image = global::Snake.Properties.Resources.ukrainian_flag;
            this.pictureBoxUkrainian.Location = new System.Drawing.Point(472, 526);
            this.pictureBoxUkrainian.Name = "pictureBoxUkrainian";
            this.pictureBoxUkrainian.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxUkrainian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUkrainian.TabIndex = 32;
            this.pictureBoxUkrainian.TabStop = false;
            this.pictureBoxUkrainian.Click += new System.EventHandler(this.pictureBoxUkrainian_Click);
            // 
            // pictureBoxEnglish
            // 
            this.pictureBoxEnglish.Image = global::Snake.Properties.Resources.english_flag;
            this.pictureBoxEnglish.InitialImage = null;
            this.pictureBoxEnglish.Location = new System.Drawing.Point(538, 526);
            this.pictureBoxEnglish.Name = "pictureBoxEnglish";
            this.pictureBoxEnglish.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnglish.TabIndex = 31;
            this.pictureBoxEnglish.TabStop = false;
            this.pictureBoxEnglish.Click += new System.EventHandler(this.pictureBoxEnglish_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Snake.Properties.Resources.snake_512;
            this.pictureBoxLogo.Location = new System.Drawing.Point(248, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(126, 131);
            this.pictureBoxLogo.TabIndex = 30;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(604, 581);
            this.Controls.Add(this.pictureBoxJapanese);
            this.Controls.Add(this.pictureBoxUkrainian);
            this.Controls.Add(this.pictureBoxEnglish);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelScore5);
            this.Controls.Add(this.labelScore4);
            this.Controls.Add(this.labelScore3);
            this.Controls.Add(this.label05);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.labelScorePlace);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.buttonDark);
            this.Controls.Add(this.buttonNeon);
            this.Controls.Add(this.buttonStandard);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.labelDifficult);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonScoreboard);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonTryAgain);
            this.Controls.Add(this.labelDeath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake The Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJapanese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUkrainian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer WorldTimer;
        private System.Windows.Forms.Label labelDeath;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonScoreboard;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelDifficult;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.Button buttonStandard;
        private System.Windows.Forms.Button buttonNeon;
        private System.Windows.Forms.Button buttonDark;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelScorePlace;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label labelScore4;
        private System.Windows.Forms.Label labelScore3;
        private System.Windows.Forms.Label labelScore5;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxEnglish;
        private System.Windows.Forms.PictureBox pictureBoxUkrainian;
        private System.Windows.Forms.PictureBox pictureBoxJapanese;
    }
}

