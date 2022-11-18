using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Media;

namespace Snake_Kursach
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;

        public static int k= Properties.Settings.Default.k, k2 = Properties.Settings.Default.k2, clr = Properties.Settings.Default.color, clr2 = Properties.Settings.Default.clr2, fst = 1, m = Properties.Settings.Default.music, m2 = Properties.Settings.Default.m2;
        public static int diffv = Properties.Settings.Default.difficulty, cr1 = 12, cg1 = 180, cb1 = 0, cr2 = 255, cg2 = 205, cb2 = 0;
        public static int lan = Properties.Settings.Default.lang1, lan2 = Properties.Settings.Default.lang2, lan3 = Properties.Settings.Default.lang3;
        public static int sumred = Properties.Settings.Default.sumred, sumgreen = Properties.Settings.Default.sumgreen, sumprpl = Properties.Settings.Default.sumprpl; 
        public static int gpl = Properties.Settings.Default.gplayed, sumlen = Properties.Settings.Default.sumLen, totAchiv = Properties.Settings.Default.totAch;
        int dvij = 0;

        

        int width, height;
        Point[] snake;
        Point apple;
        Random r;
        int len = 1;
        SolidBrush b;
        SolidBrush red;
        SolidBrush green_brush;
        SolidBrush yellow_brush;
        public Form1()
        {
            InitializeComponent();
            
            r = new Random();

            sp = new SoundPlayer();
            sp.Stream = Properties.Resources.
                ost;
            snake = new Point[10000];
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            width = pictureBox1.Width / 10;
            height = pictureBox1.Height / 10;
            snake[0].X = width / 2;
            snake[0].Y = 30;
            b = new SolidBrush(Color.LightGreen);
            red = new SolidBrush(Color.Red);

            apple.X = r.Next(0, width - 1);
            apple.Y = r.Next(0, height - 1);

            

            if (fst == 1 && m2 == 1)
            {
                 sp.PlayLooping(); 
            }
            fst = 2;

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resetach_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(210, 130);
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Location = new Point(175, 318);
            panel2.Visible = false;
            panel2.Location = new Point(175, 318);
            panel3.Visible = false;
            panel3.Location = new Point(175, 318);
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel3.Location = new Point(175, 318);
            gpl = 0;
            sumred = 0;
            sumgreen = 0;
            sumprpl = 0;
            sumlen = 0;
            totAchiv = 0;
            Properties.Settings.Default.gplayed = gpl;
            Properties.Settings.Default.sumgreen = sumgreen;
            Properties.Settings.Default.sumred = sumred;
            Properties.Settings.Default.sumprpl = sumprpl;
            Properties.Settings.Default.sumLen = sumlen;
            Properties.Settings.Default.totAch = totAchiv;
            Properties.Settings.Default.Save();

            lblApple.Text = sumred + "/500";
            lblRareapl.Text = sumgreen + "/500";
            lblSrareapl.Text = sumprpl + "/500";
            lblGPlayed.Text = gpl + "/500";
            lblLen.Text = sumlen + "/500";
            lblTotalA.Text = totAchiv + "/5";

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel3.Location = new Point(175, 318);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ввостн настроек
            Game.highs =  Properties.Settings.Default.highscore;
            clr = Properties.Settings.Default.color;
            diffv = Properties.Settings.Default.difficulty;
            lan = Properties.Settings.Default.lang1 ;
            lan2 = Properties.Settings.Default.lang2 ;
            lan3 = Properties.Settings.Default.lang3 ;
            m = Properties.Settings.Default.music;
            m2 = Properties.Settings.Default.m2;
            clr2 = Properties.Settings.Default.clr2;
            k = Properties.Settings.Default.k;
            k2 = Properties.Settings.Default.k2;
            gpl = Properties.Settings.Default.gplayed;
            sumgreen = Properties.Settings.Default.sumgreen;
            sumred = Properties.Settings.Default.sumred;
            sumprpl = Properties.Settings.Default.sumprpl;
            sumlen = Properties.Settings.Default.sumLen;
            totAchiv = Properties.Settings.Default.totAch;
            //Цвет
            if (clr2 == 1)
            {
                cr1 = 12; cg1 = 180; cb1 = 0; cr2 = 255; cg2 = 205; cb2 = 0;
                label1.BackColor = Color.LightGreen;
                lblHScore2.BackColor = Color.LightGreen;
                label2.BackColor = Color.ForestGreen;
                lblBonus.BackColor = Color.ForestGreen;
                this.BackColor = Color.ForestGreen;
                panel1.BackgroundImage = Properties.Resources.green4;
                panel2.BackgroundImage = Properties.Resources.green4;
                panel3.BackgroundImage = Properties.Resources.green4;
                lblApple.BackColor = Color.LightGreen;
                lblSrareapl.BackColor = Color.LightGreen;
                lblRareapl.BackColor = Color.LightGreen;
                lblGPlayed.BackColor = Color.LightGreen;
                lblLen.BackColor = Color.LightGreen;
                lblTotalA.BackColor = Color.LightGreen;
                b = new SolidBrush(Color.LightGreen);
            }
            if (clr2 == 2)
            {
                cr1 = 200; cg1 = 0; cb1 = 0; cr2 = 125; cg2 = 0; cb2 = 0;
                label1.BackColor = Color.LightCoral;
                lblHScore2.BackColor = Color.LightCoral;
                label2.BackColor = Color.Firebrick;
                lblBonus.BackColor = Color.Firebrick;
                this.BackColor = Color.Firebrick;
                panel1.BackgroundImage = Properties.Resources.red4;
                panel2.BackgroundImage = Properties.Resources.red4;
                panel3.BackgroundImage = Properties.Resources.red4;
                lblApple.BackColor = Color.LightCoral;
                lblSrareapl.BackColor = Color.LightCoral;
                lblRareapl.BackColor = Color.LightCoral;
                lblGPlayed.BackColor = Color.LightCoral;
                lblLen.BackColor = Color.LightCoral;
                lblTotalA.BackColor = Color.LightCoral;
                b = new SolidBrush(Color.LightCoral);
            }
            if (clr2 == 3)
            {
                cr1 = 0; cg1 = 75; cb1 = 220; cr2 = 0; cg2 = 50; cb2 = 150;
                label1.BackColor = Color.LightBlue;
                lblHScore2.BackColor = Color.LightBlue;
                label2.BackColor = Color.DodgerBlue;
                lblBonus.BackColor = Color.DodgerBlue;
                this.BackColor = Color.DodgerBlue;
                panel1.BackgroundImage = Properties.Resources.blue4;
                panel2.BackgroundImage = Properties.Resources.blue4;
                panel3.BackgroundImage = Properties.Resources.blue4;
                lblApple.BackColor = Color.LightBlue;
                lblSrareapl.BackColor = Color.LightBlue;
                lblRareapl.BackColor = Color.LightBlue;
                lblGPlayed.BackColor = Color.LightBlue;
                lblLen.BackColor = Color.LightBlue;
                lblTotalA.BackColor = Color.LightBlue;
                b = new SolidBrush(Color.LightBlue);
            }
            if (clr2 == 4)
            {
                cr1 = 150; cg1 = 0; cb1 = 230; cr2 = 80; cg2 = 0; cb2 = 125;
                label1.BackColor = Color.MediumSlateBlue;
                lblHScore2.BackColor = Color.MediumSlateBlue;
                label2.BackColor = Color.Purple;
                lblBonus.BackColor = Color.Purple;
                this.BackColor = Color.Purple;
                panel1.BackgroundImage = Properties.Resources.prpl4;
                panel2.BackgroundImage = Properties.Resources.prpl4;
                panel3.BackgroundImage = Properties.Resources.prpl4;
                lblApple.BackColor = Color.MediumSlateBlue;
                lblSrareapl.BackColor = Color.MediumSlateBlue;
                lblRareapl.BackColor = Color.MediumSlateBlue;
                lblGPlayed.BackColor = Color.MediumSlateBlue;
                lblLen.BackColor = Color.MediumSlateBlue;
                lblTotalA.BackColor = Color.MediumSlateBlue;
                b = new SolidBrush(Color.MediumSlateBlue);
            }
            if (clr2 == 5)
            {
                cr1 = 85; cg1 = 85; cb1 = 85; cr2 = 0; cg2 = 0; cb2 = 0;
                label1.BackColor = Color.Silver;
                lblHScore2.BackColor = Color.Silver;
                label2.BackColor = Color.Gray;
                lblBonus.BackColor = Color.Gray;
                this.BackColor = Color.Gray;
                panel1.BackgroundImage = Properties.Resources.gray4;
                panel2.BackgroundImage = Properties.Resources.gray4;
                panel3.BackgroundImage = Properties.Resources.gray4;
                lblApple.BackColor = Color.Silver;
                lblSrareapl.BackColor = Color.Silver;
                lblRareapl.BackColor = Color.Silver;
                lblGPlayed.BackColor = Color.Silver;
                lblLen.BackColor = Color.Silver;
                lblTotalA.BackColor = Color.Silver;
                b = new SolidBrush(Color.Silver);
            }


            switch (lan3)
            {
                case 1:
                    if (k2 == 1)
                    {
                        lbldiff.Text = "easy";
                    }
                    if (k2 == 2)
                    {
                        lbldiff.Text = "medium";
                    }
                    if (k2 == 3)
                    {
                        lbldiff.Text = "hard";
                    }
                    lblHScore2.Text = "High score: " + Game.highs;
                    startbutton.Text = "New game";
                    diffbutton.Text = "Change difficulty:";
                    langbutton.Text = "Change language";
                    opButton.Text = "Options";
                    Mbutt.Text = "Music:";
                    if (m2 == 1)
                        lblM.Text = "on";
                    else
                        lblM.Text = "off";                    
                    colorButton.Text = "Snake color:";
                    if (clr2 == 1)
                        lblClr.Text = "green";
                    if (clr2 == 2)
                        lblClr.Text = "red";
                    if (clr2 == 3)
                        lblClr.Text = "blue";
                    if (clr2 == 4)
                        lblClr.Text = "purple";
                    if (clr2 == 5)
                        lblClr.Text = "black";
                    lblclose.Text = "close";
                    btnAchivements.Text = "Achievements";
                    closeA.Text = "close";
                    resetach.Text = "reset achivements";
                    lblAgreement.Text = "Do you agree? After clicking 'yes' your process will be lost.";
                    btnYES.Text = "Yes";
                    btnNO.Text = "No";
                    switch (clr2)
                    {
                        case 1:
                            lblBonus.Text = "Bonus: +10% green apples";
                            break;
                        case 2:
                            lblBonus.Text = "Bonus: +10% red apples";
                            break;
                        case 3:
                            lblBonus.Text = "Bonus: one game for five";
                            break;
                        case 4:
                            lblBonus.Text = "Bonus: +10% purple apples";
                            break;
                        case 5:
                            lblBonus.Text = "Bonus: apples give more length";
                            break;
                    }                    
                    break;
                case 2:
                    if (k2 == 1)
                        lbldiff.Text = "важка";
                    if (k2 == 2)
                        lbldiff.Text = "легка";
                    if (k2 == 3)
                        lbldiff.Text = "середня";
                    lblHScore2.Text = "Ваш рекорд: " + Game.highs;
                    startbutton.Text = "Почати гру";
                    diffbutton.Text = "Змiнити складнiсть:";
                    langbutton.Text = "Змiнити мову";
                    opButton.Text = "Налаштування";
                    Mbutt.Text = "Музика:"; 
                    if (m2 == 1)
                        lblM.Text = "увімк";
                    else
                        lblM.Text = "вимк";
                    colorButton.Text = "Колiр змiйки:";
                    if (clr2 == 1)
                        lblClr.Text = "зелений";
                    if (clr2 == 2)
                            lblClr.Text = "червоний";
                    if (clr2 == 3)
                        lblClr.Text = "синій";
                    if (clr2 == 4)
                        lblClr.Text = "фіалковий";
                    if (clr2 == 5)
                        lblClr.Text = "чорний";
                    lblclose.Text = "закрити";
                    btnAchivements.Text = "Досягнення";
                    closeA.Text = "закрити";
                    resetach.Text = "скинути досягнення";
                    lblAgreement.Text = "Ви згодні? Після натискання на 'так' ваш процес буде втрачено.";
                    btnYES.Text = "Так";
                    btnNO.Text = "Ні";
                    switch (clr2)
                    {
                        case 1:
                            lblBonus.Text = "Бонус: +10% зелених яблук";
                            break;
                        case 2:
                            lblBonus.Text = "Бонус: +10% червоних яблук";
                            break;
                        case 3:
                            lblBonus.Text = "Бонус: одна гра за п'ять";
                            break;
                        case 4:
                            lblBonus.Text = "Бонус: +10% фіалкових яблук";
                            break;
                        case 5:
                            lblBonus.Text = "Бонус: яблука дають більше довжини";
                            break;
                    }
                    break;
                case 3:
                    if (k2 == 3)
                        lbldiff.Text = "сложная";
                    if (k2 == 1)
                        lbldiff.Text = "легкая";
                    if (k2 == 2)
                        lbldiff.Text = "средняя";
                    lblHScore2.Text = "Ваш рекорд: " + Game.highs;
                    startbutton.Text = "Новая игра";
                    diffbutton.Text = "Изменить сложность:";
                    langbutton.Text = "Изменить язык";
                    opButton.Text = "Настройки";
                    Mbutt.Text = "Музыка:";
                    if (m2 == 1)
                        lblM.Text = "вкл";
                    else
                        lblM.Text = "выкл";
                    colorButton.Text = "Цвет змейки:";
                    lblClr.Text = "зелёный";
                    if (clr2 == 1)
                        lblClr.Text = "зелёный";                    
                    if (clr2 == 2)
                        lblClr.Text = "красный";
                    if (clr2 == 3)
                        lblClr.Text = "синий";
                    if (clr2 == 4)
                        lblClr.Text = "фиолетовый";
                    if (clr2 == 5)
                        lblClr.Text = "чёрный";
                    lblclose.Text = "закрыть";
                    btnAchivements.Text = "Достижения";
                    closeA.Text = "закрыть";
                    resetach.Text = "сбросить достижения";
                    lblAgreement.Text = "Вы согласны? После нажатия на 'да' ваш процесс будет утерян.";
                    btnYES.Text = "Да";
                    btnNO.Text = "Нет";
                    switch (clr2)
                    {
                        case 1:
                            lblBonus.Text = "Бонус: +10% зелёных яблок";
                            break;
                        case 2:
                            lblBonus.Text = "Бонус: +10% красных яблок";
                            break;
                        case 3:
                            lblBonus.Text = "Бонус: одна игра за пять";
                            break;
                        case 4:
                            lblBonus.Text = "Бонус: +10% фиолетовых яблок";
                            break;
                        case 5:
                            lblBonus.Text = "Бонус: яблоки дают больше длины";
                            break;
                    }
                    break;
                }
            
            

        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.color = clr;
            Properties.Settings.Default.difficulty = diffv;
            Properties.Settings.Default.lang1 = lan;
            Properties.Settings.Default.lang2 = lan2;
            Properties.Settings.Default.lang3 = lan3;
            Properties.Settings.Default.music = m;
            Properties.Settings.Default.m2 = m2;
            Properties.Settings.Default.clr2 = clr2;
            Properties.Settings.Default.highscore = Game.highs;
            Properties.Settings.Default.k = k;
            Properties.Settings.Default.k2 = k2;
            Properties.Settings.Default.gplayed = gpl;
            Properties.Settings.Default.sumgreen = sumgreen;
            Properties.Settings.Default.sumred = sumred;
            Properties.Settings.Default.sumprpl = sumprpl;
            Properties.Settings.Default.sumLen = sumlen;
            Properties.Settings.Default.totAch = totAchiv;
            Properties.Settings.Default.Save();
            //
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            totAchiv = 0;
            if(sumred >= 500)
            {
                pctbApple.Image = Properties.Resources.apple1;
                lblApple.Text = sumred + "/500";
                totAchiv++;
            }
            else
            {
                pctbApple.Image = Properties.Resources.redapp1;
                lblApple.Text = sumred + "/500";
            }
            if (sumgreen >= 500)
            {
                pctboxRareapl.Image = Properties.Resources.greenapp;
                lblRareapl.Text = sumgreen + "/500";
                totAchiv++;
            }
            else
            {
                pctboxRareapl.Image = Properties.Resources.greenapp1;
                lblRareapl.Text = sumgreen + "/500";
            }
            if (sumprpl >= 500)
            {
                pctboxSrareapl.Image = Properties.Resources.prplapple;
                lblSrareapl.Text = sumprpl + "/500";
                totAchiv++;
            }
            else
            {
                pctboxSrareapl.Image = Properties.Resources.prplapple1;
                lblSrareapl.Text = sumprpl + "/500";
            }
            if (gpl >= 500)
            {
                pctBoxGPlayed.Image = Properties.Resources.gamesP;
                lblGPlayed.Text = gpl + "/500";
                totAchiv++;
            }
            else
            {
                pctBoxGPlayed.Image = Properties.Resources.gamesP1;
                lblGPlayed.Text = gpl + "/500";
            }
            if (sumlen >= 500)
            {
                pctboxLen.Image = Properties.Resources.Len;
                lblLen.Text = sumlen + "/500";
                totAchiv++;
            }
            else
            {
                pctboxLen.Image = Properties.Resources.Len1;
                lblLen.Text = sumlen + "/500";
            }
            if (totAchiv == 5)
            {
                pctboxTotalA.Image = Properties.Resources.DONE;
                lblTotalA.Text = totAchiv + "/5";
            }
            else
            {
                pctboxTotalA.Image = Properties.Resources.DONE1;
                lblTotalA.Text = totAchiv + "/5";
            }
            panel2.Location = new Point(175, 77);
            panel2.Visible = true;

        }

        private void closeA_Click(object sender, EventArgs e)
        {

            panel2.Visible = false;
            panel2.Location = new Point(175, 318);
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }
        string direction = "right";
        Random rnd = new Random();

        private void colorButton_Click(object sender, EventArgs e)
        {

            switch (lan2)
            {
                case 3:
                    switch (clr)
                    {
                        case 1:
                            lblBonus.Text = "Бонус: +10% зелёных яблок";
                            lblClr.Text = "зелёний";
                            cr1 = 12; cg1 = 180; cb1 = 0; cr2 = 255; cg2 = 205; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.LightGreen;
                            lblHScore2.BackColor = Color.LightGreen;
                            label2.BackColor = Color.ForestGreen;
                            lblBonus.BackColor = Color.ForestGreen;
                            this.BackColor = Color.ForestGreen;
                            panel1.BackgroundImage = Properties.Resources.green4;
                            panel2.BackgroundImage = Properties.Resources.green4;
                            panel3.BackgroundImage = Properties.Resources.green4;
                            lblApple.BackColor = Color.LightGreen;
                            lblSrareapl.BackColor = Color.LightGreen;
                            lblRareapl.BackColor = Color.LightGreen;
                            lblGPlayed.BackColor = Color.LightGreen;
                            lblLen.BackColor = Color.LightGreen;
                            lblTotalA.BackColor = Color.LightGreen;
                            b = new SolidBrush(Color.LightGreen);
                            clr++;
                            break;
                        case 2:
                            lblBonus.Text = "Бонус: +10% красных яблок";
                            lblClr.Text = "красный";
                            cr1 = 200; cg1 = 0; cb1 = 0; cr2 = 125; cg2 = 0; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.LightCoral;
                            lblHScore2.BackColor = Color.LightCoral;
                            label2.BackColor = Color.Firebrick;
                            lblBonus.BackColor = Color.Firebrick;
                            this.BackColor = Color.Firebrick;
                            panel1.BackgroundImage = Properties.Resources.red4;
                            panel2.BackgroundImage = Properties.Resources.red4;
                            panel3.BackgroundImage = Properties.Resources.red4;
                            lblApple.BackColor = Color.LightCoral;
                            lblSrareapl.BackColor = Color.LightCoral;
                            lblRareapl.BackColor = Color.LightCoral;
                            lblGPlayed.BackColor = Color.LightCoral;
                            lblLen.BackColor = Color.LightCoral;
                            lblTotalA.BackColor = Color.LightCoral;
                            b = new SolidBrush(Color.LightCoral);
                            clr++;
                            break;
                        case 3:
                            lblBonus.Text = "Бонус: одна игра за пять";
                            lblClr.Text = "синий";
                            cr1 = 0; cg1 = 75; cb1 = 220; cr2 = 0; cg2 = 50; cb2 = 150;
                            clr2 = clr;
                            label1.BackColor = Color.LightBlue;
                            lblHScore2.BackColor = Color.LightBlue;
                            label2.BackColor = Color.DodgerBlue;
                            lblBonus.BackColor = Color.DodgerBlue;
                            this.BackColor = Color.DodgerBlue;
                            panel1.BackgroundImage = Properties.Resources.blue4;
                            panel2.BackgroundImage = Properties.Resources.blue4;
                            panel3.BackgroundImage = Properties.Resources.blue4;
                            lblApple.BackColor = Color.LightBlue;
                            lblSrareapl.BackColor = Color.LightBlue;
                            lblRareapl.BackColor = Color.LightBlue;
                            lblGPlayed.BackColor = Color.LightBlue;
                            lblLen.BackColor = Color.LightBlue;
                            lblTotalA.BackColor = Color.LightBlue;
                            b = new SolidBrush(Color.LightBlue);
                            clr++;
                            break;
                        case 4:
                            lblBonus.Text = "Бонус: +10% фиолетовых яблок";
                            lblClr.Text = "фиолетовый";
                            cr1 = 150; cg1 = 0; cb1 = 230; cr2 = 80; cg2 = 0; cb2 = 125;
                            clr2 = clr;
                            label1.BackColor = Color.MediumSlateBlue;
                            lblHScore2.BackColor = Color.MediumSlateBlue;
                            label2.BackColor = Color.Purple;
                            lblBonus.BackColor = Color.Purple;
                            this.BackColor = Color.Purple;
                            panel1.BackgroundImage = Properties.Resources.prpl4;
                            panel2.BackgroundImage = Properties.Resources.prpl4;
                            panel3.BackgroundImage = Properties.Resources.prpl4;
                            lblApple.BackColor = Color.MediumSlateBlue;
                            lblSrareapl.BackColor = Color.MediumSlateBlue;
                            lblRareapl.BackColor = Color.MediumSlateBlue;
                            lblGPlayed.BackColor = Color.MediumSlateBlue;
                            lblLen.BackColor = Color.MediumSlateBlue;
                            lblTotalA.BackColor = Color.MediumSlateBlue;
                            b = new SolidBrush(Color.MediumSlateBlue);
                            clr++;
                            break;
                        case 5:
                            lblBonus.Text = "Бонус: яблоки дают больше длины";
                            lblClr.Text = "чёрный";
                            cr1 = 85; cg1 = 85; cb1 = 85; cr2 = 0; cg2 = 0; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.Silver;
                            lblHScore2.BackColor = Color.Silver;
                            label2.BackColor = Color.Gray;
                            lblBonus.BackColor = Color.Gray;
                            this.BackColor = Color.Gray;
                            panel1.BackgroundImage = Properties.Resources.gray4;
                            panel2.BackgroundImage = Properties.Resources.gray4;
                            panel3.BackgroundImage = Properties.Resources.gray4;
                            lblApple.BackColor = Color.Silver;
                            lblSrareapl.BackColor = Color.Silver;
                            lblRareapl.BackColor = Color.Silver;
                            lblGPlayed.BackColor = Color.Silver;
                            lblLen.BackColor = Color.Silver;
                            lblTotalA.BackColor = Color.Silver;
                            b = new SolidBrush(Color.Silver);
                            clr = 1;
                            break;
                    }
                    break;
                case 1:
                    switch (clr)
                    {
                        case 1:
                            lblBonus.Text = "Bonus: +10% green apples";
                            lblClr.Text = "green";
                            cr1 = 12; cg1 = 180; cb1 = 0; cr2 = 255; cg2 = 205; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.LightGreen;
                            lblHScore2.BackColor = Color.LightGreen;
                            label2.BackColor = Color.ForestGreen;
                            lblBonus.BackColor = Color.ForestGreen;
                            this.BackColor = Color.ForestGreen;
                            panel1.BackgroundImage = Properties.Resources.green4;
                            panel2.BackgroundImage = Properties.Resources.green4;
                            panel3.BackgroundImage = Properties.Resources.green4;
                            lblApple.BackColor = Color.LightGreen;
                            lblSrareapl.BackColor = Color.LightGreen;
                            lblRareapl.BackColor = Color.LightGreen;
                            lblGPlayed.BackColor = Color.LightGreen;
                            lblLen.BackColor = Color.LightGreen;
                            lblTotalA.BackColor = Color.LightGreen;
                            b = new SolidBrush(Color.LightGreen);
                            clr++;
                            break;
                        case 2:
                            lblClr.Text = "red";
                            lblBonus.Text = "Bonus: +10% red apples";
                            cr1 = 200; cg1 = 0; cb1 = 0; cr2 = 125; cg2 = 0; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.LightCoral;
                            lblHScore2.BackColor = Color.LightCoral;
                            label2.BackColor = Color.Firebrick;
                            lblBonus.BackColor = Color.Firebrick;
                            this.BackColor = Color.Firebrick;
                            panel1.BackgroundImage = Properties.Resources.red4;
                            panel2.BackgroundImage = Properties.Resources.red4;
                            panel3.BackgroundImage = Properties.Resources.red4;
                            lblApple.BackColor = Color.LightCoral;
                            lblSrareapl.BackColor = Color.LightCoral;
                            lblRareapl.BackColor = Color.LightCoral;
                            lblGPlayed.BackColor = Color.LightCoral;
                            lblLen.BackColor = Color.LightCoral;
                            lblTotalA.BackColor = Color.LightCoral;
                            b = new SolidBrush(Color.LightCoral);
                            clr++;
                            break;
                        case 3:
                            lblBonus.Text = "Bonus: one game for five";
                            lblClr.Text = "blue";
                            cr1 = 0; cg1 = 75; cb1 = 220; cr2 = 0; cg2 = 50; cb2 = 150;
                            clr2 = clr;
                            label1.BackColor = Color.LightBlue;
                            lblHScore2.BackColor = Color.LightBlue;
                            label2.BackColor = Color.DodgerBlue;
                            lblBonus.BackColor = Color.DodgerBlue;
                            this.BackColor = Color.DodgerBlue;
                            panel1.BackgroundImage = Properties.Resources.blue4;
                            panel2.BackgroundImage = Properties.Resources.blue4;
                            panel3.BackgroundImage = Properties.Resources.blue4;
                            lblApple.BackColor = Color.LightBlue;
                            lblSrareapl.BackColor = Color.LightBlue;
                            lblRareapl.BackColor = Color.LightBlue;
                            lblGPlayed.BackColor = Color.LightBlue;
                            lblLen.BackColor = Color.LightBlue;
                            lblTotalA.BackColor = Color.LightBlue;
                            b = new SolidBrush(Color.LightBlue);
                            clr++;
                            break;
                        case 4:
                            lblBonus.Text = "Bonus: +10% purple apples";
                            lblClr.Text = "purple";
                            cr1 = 150; cg1 = 0; cb1 = 230; cr2 = 80; cg2 = 0; cb2 = 125;
                            clr2 = clr;
                            label1.BackColor = Color.MediumSlateBlue;
                            lblHScore2.BackColor = Color.MediumSlateBlue;
                            label2.BackColor = Color.Purple;
                            lblBonus.BackColor = Color.Purple;
                            this.BackColor = Color.Purple;
                            panel1.BackgroundImage = Properties.Resources.prpl4;
                            panel2.BackgroundImage = Properties.Resources.prpl4;
                            panel3.BackgroundImage = Properties.Resources.prpl4;
                            lblApple.BackColor = Color.MediumSlateBlue;
                            lblSrareapl.BackColor = Color.MediumSlateBlue;
                            lblRareapl.BackColor = Color.MediumSlateBlue;
                            lblGPlayed.BackColor = Color.MediumSlateBlue;
                            lblLen.BackColor = Color.MediumSlateBlue;
                            lblTotalA.BackColor = Color.MediumSlateBlue;
                            b = new SolidBrush(Color.MediumSlateBlue);
                            clr++;
                            break;
                        case 5:
                            lblBonus.Text = "Bonus: apples give more length";
                            lblClr.Text = "black";
                            cr1 = 85; cg1 = 85; cb1 = 85; cr2 = 0; cg2 = 0; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.Silver;
                            lblHScore2.BackColor = Color.Silver;
                            label2.BackColor = Color.Gray;
                            lblBonus.BackColor = Color.Gray;
                            this.BackColor = Color.Gray;
                            panel1.BackgroundImage = Properties.Resources.gray4;
                            panel2.BackgroundImage = Properties.Resources.gray4;
                            panel3.BackgroundImage = Properties.Resources.gray4;
                            lblApple.BackColor = Color.Silver;
                            lblSrareapl.BackColor = Color.Silver;
                            lblRareapl.BackColor = Color.Silver;
                            lblGPlayed.BackColor = Color.Silver;
                            lblLen.BackColor = Color.Silver;
                            lblTotalA.BackColor = Color.Silver;
                            b = new SolidBrush(Color.Silver);
                            clr = 1;
                            break;
                    }
                    break;
                case 2:
                    switch (clr)
                    {
                        case 1:
                            lblBonus.Text = "Бонус: +10% зелених яблук";
                            lblClr.Text = "зелений";
                            cr1 = 12; cg1 = 180; cb1 = 0; cr2 = 255; cg2 = 205; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.LightGreen;
                            lblHScore2.BackColor = Color.LightGreen;
                            label2.BackColor = Color.ForestGreen;
                            lblBonus.BackColor = Color.ForestGreen;
                            this.BackColor = Color.ForestGreen;
                            panel1.BackgroundImage = Properties.Resources.green4;
                            panel2.BackgroundImage = Properties.Resources.green4;
                            panel3.BackgroundImage = Properties.Resources.green4;
                            lblApple.BackColor = Color.LightGreen;
                            lblSrareapl.BackColor = Color.LightGreen;
                            lblRareapl.BackColor = Color.LightGreen;
                            lblGPlayed.BackColor = Color.LightGreen;
                            lblLen.BackColor = Color.LightGreen;
                            lblTotalA.BackColor = Color.LightGreen;
                            b = new SolidBrush(Color.LightGreen);
                            clr++;
                            break;
                        case 2:
                            lblBonus.Text = "Бонус: +10% червоних яблук";
                            lblClr.Text = "червоний";
                            cr1 = 200; cg1 = 0; cb1 = 0; cr2 = 125; cg2 = 0; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.LightCoral;
                            lblHScore2.BackColor = Color.LightCoral;
                            label2.BackColor = Color.Firebrick;
                            lblBonus.BackColor = Color.Firebrick;
                            this.BackColor = Color.Firebrick;
                            panel1.BackgroundImage = Properties.Resources.red4;
                            panel2.BackgroundImage = Properties.Resources.red4;
                            panel3.BackgroundImage = Properties.Resources.red4;
                            lblApple.BackColor = Color.LightCoral;
                            lblSrareapl.BackColor = Color.LightCoral;
                            lblRareapl.BackColor = Color.LightCoral;
                            lblGPlayed.BackColor = Color.LightCoral;
                            lblLen.BackColor = Color.LightCoral;
                            lblTotalA.BackColor = Color.LightCoral;
                            b = new SolidBrush(Color.LightCoral);
                            clr++;
                            break;
                        case 3:
                            lblBonus.Text = "Бонус: одна гра за п'ять";
                            lblClr.Text = "синій";
                            cr1 = 0; cg1 = 75; cb1 = 220; cr2 = 0; cg2 = 50; cb2 = 150;
                            clr2 = clr;
                            label1.BackColor = Color.LightBlue;
                            lblHScore2.BackColor = Color.LightBlue;
                            label2.BackColor = Color.DodgerBlue;
                            lblBonus.BackColor = Color.DodgerBlue;
                            this.BackColor = Color.DodgerBlue;
                            panel1.BackgroundImage = Properties.Resources.blue4;
                            panel2.BackgroundImage = Properties.Resources.blue4;
                            panel3.BackgroundImage = Properties.Resources.blue4;
                            lblApple.BackColor = Color.LightBlue;
                            lblSrareapl.BackColor = Color.LightBlue;
                            lblRareapl.BackColor = Color.LightBlue;
                            lblGPlayed.BackColor = Color.LightBlue;
                            lblLen.BackColor = Color.LightBlue;
                            lblTotalA.BackColor = Color.LightBlue;
                            b = new SolidBrush(Color.LightBlue);
                            clr++;
                            break;
                        case 4:
                            lblBonus.Text = "Бонус: +10% фіалкових яблук";
                            lblClr.Text = "фіалковий";
                            cr1 = 150; cg1 = 0; cb1 = 230; cr2 = 80; cg2 = 0; cb2 = 125;
                            clr2 = clr;
                            label1.BackColor = Color.MediumSlateBlue;
                            lblHScore2.BackColor = Color.MediumSlateBlue;
                            label2.BackColor = Color.Purple;
                            lblBonus.BackColor = Color.Purple;
                            this.BackColor = Color.Purple;
                            panel1.BackgroundImage = Properties.Resources.prpl4;
                            panel2.BackgroundImage = Properties.Resources.prpl4;
                            panel3.BackgroundImage = Properties.Resources.prpl4;
                            lblApple.BackColor = Color.MediumSlateBlue;
                            lblSrareapl.BackColor = Color.MediumSlateBlue;
                            lblRareapl.BackColor = Color.MediumSlateBlue;
                            lblGPlayed.BackColor = Color.MediumSlateBlue;
                            lblLen.BackColor = Color.MediumSlateBlue;
                            lblTotalA.BackColor = Color.MediumSlateBlue;
                            b = new SolidBrush(Color.MediumSlateBlue);
                            clr++;
                            break;
                        case 5:
                            lblBonus.Text = "Бонус: яблука дають більше довжини";
                            lblClr.Text = "чорний";
                            cr1 = 85; cg1 = 85; cb1 = 85; cr2 = 0; cg2 = 0; cb2 = 0;
                            clr2 = clr;
                            label1.BackColor = Color.Silver;
                            lblHScore2.BackColor = Color.Silver;
                            label2.BackColor = Color.Gray;
                            lblBonus.BackColor = Color.Gray;
                            this.BackColor = Color.Gray;
                            panel1.BackgroundImage = Properties.Resources.gray4;
                            panel2.BackgroundImage = Properties.Resources.gray4;
                            panel3.BackgroundImage = Properties.Resources.gray4;
                            lblApple.BackColor = Color.Silver;
                            lblSrareapl.BackColor = Color.Silver;
                            lblRareapl.BackColor = Color.Silver;
                            lblGPlayed.BackColor = Color.Silver;
                            lblLen.BackColor = Color.Silver;
                            lblTotalA.BackColor = Color.Silver;
                            b = new SolidBrush(Color.Silver);
                            clr = 1;
                            break;
                    }
                    break;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void opButton_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(175, 77);
            panel1.Visible = true;
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Location = new Point(175, 318);
            Properties.Settings.Default.color = clr;
            Properties.Settings.Default.difficulty = diffv;
            Properties.Settings.Default.lang1 = lan;
            Properties.Settings.Default.lang2 = lan2;
            Properties.Settings.Default.lang3 = lan3;
            Properties.Settings.Default.music = m;
            Properties.Settings.Default.m2 = m2;
            Properties.Settings.Default.clr2 = clr2;
            Properties.Settings.Default.highscore = Game.highs;
            Properties.Settings.Default.k = k;
            Properties.Settings.Default.k2 = k2;
            Properties.Settings.Default.Save();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Mbutt_Click(object sender, EventArgs e)
        {
            switch (lan2)
            {
                case 3:
                    switch (m)
                    {
                        case 1:
                            lblM.Text = "вкл";
                            sp.PlayLooping();
                            m2 = m;
                            m++;
                            break;
                        case 2:
                            lblM.Text = "выкл";
                            m2 = m;
                            sp.Stop();
                            m = 1;
                            break;
                    }                    
                    break;
                case 1:
                    switch (m)
                    {
                        case 1:
                            lblM.Text = "on";
                            sp.PlayLooping();
                            m2 = m;
                            m++;
                            break;
                        case 2:
                            lblM.Text = "off";
                            sp.Stop();
                            m2 = m;
                            m = 1;
                            break;
                    }                    
                    break;
                case 2:
                    switch (m)
                    {
                        case 1:
                            lblM.Text = "увм";
                            sp.PlayLooping();
                            m2 = m;
                            m++;
                            break;
                        case 2:
                            lblM.Text = "вимк";
                            sp.Stop();
                            m2 = m;
                            m = 1;
                            break;
                    }
                    break;
            }
        }

        int dir;
        private void timer1_Tick(object sender, EventArgs e)
        {
            green_brush = new SolidBrush(Color.FromArgb(cr1, cg1, cb1));
            yellow_brush = new SolidBrush(Color.FromArgb(cr2, cg2, cb2));
            Graphics g = Graphics.FromImage(pictureBox1.Image);


            if (dir <= 25 && !(direction == "down"))
            {
                direction = "up";
            }
            if (dir >= 25 && dir <=50 && !(direction == "up"))
            {
                direction = "down";
            }
            if (dir >= 50 && dir <= 75 && !(direction == "right"))
            {
                direction = "left";
            }
            if (dir >= 75  && !(direction == "left"))
            {
                direction = "right";
            }

            g.FillRectangle(b, 0, 0, pictureBox1.Width, pictureBox1.Height); // Закрасить игровое поле

            // Если змейка съела себя
           
            for (int i = 0; i < len; i++)
            {
                dvij++;
                if (i == 0 || i % 2 == 0)
                    g.FillRectangle(yellow_brush, snake[i].X * 10, snake[i].Y * 10, 10, 10); // Создаем змейку в 10 пикс
                else
                    g.FillRectangle(green_brush, snake[i].X * 10, snake[i].Y * 10, 10, 10); // Создаем змейку в 10 пикс

                if (dvij == 15)
                {
                    dvij = 0;
                    dir = rnd.Next(1, 101);
                }

                // Уход змейки за карту
                if (snake[i].X <= 0) snake[i].X += width;
                if (snake[i].X >= width) snake[i].X -= width;
                if (snake[i].Y <= 0) snake[i].Y += height;
                if (snake[i].Y >= height) snake[i].Y -= height;

                if (apple.X == snake[i].X && apple.Y == snake[i].Y) // Змея ест яблоко
                {
                    apple.X = r.Next(0, width - 1);
                    apple.Y = r.Next(0, height - 1);
                    len++;
                }



            }
            
            g.FillEllipse(red, apple.X * 10, apple.Y * 10, 10, 10); // Рисуем яблоко

            if (direction == "up") snake[0].Y -= 1;
            if (direction == "down") snake[0].Y += 1;
            if (direction == "left") snake[0].X -= 1;
            if (direction == "right") snake[0].X += 1;

            if (len > 10000 - 3)
            {
                len = 10000 - 3;
            }
            for (int i = len; i >= 0; i--)
            {
                snake[i + 1].X = snake[i].X;
                snake[i + 1].Y = snake[i].Y;
            }
            if (len < 4) len++;
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbldiff.Text == "легка" || lbldiff.Text == "easy" || lbldiff.Text == "легкая") diffv = 120;
            if (lbldiff.Text == "важка" || lbldiff.Text == "hard" || lbldiff.Text == "сложная") diffv = 20;
            if (lbldiff.Text == "середня" || lbldiff.Text == "medium" || lbldiff.Text == "средняя") diffv = 70;
            if (clr2 == 3)
                gpl += 5;
            else gpl++;
            Properties.Settings.Default.color = clr;
            Properties.Settings.Default.difficulty = diffv;
            Properties.Settings.Default.lang1 = lan;
            Properties.Settings.Default.lang2 = lan2;
            Properties.Settings.Default.lang3 = lan3;
            Properties.Settings.Default.music = m;
            Properties.Settings.Default.m2 = m2;
            Properties.Settings.Default.clr2 = clr2;
            Properties.Settings.Default.highscore = Game.highs;
            Properties.Settings.Default.k = k;
            Properties.Settings.Default.k2 = k2;
            Properties.Settings.Default.gplayed = gpl;
            Properties.Settings.Default.sumgreen = sumgreen;
            Properties.Settings.Default.sumred = sumred;
            Properties.Settings.Default.sumprpl = sumprpl;
            Properties.Settings.Default.sumLen = sumlen;
            Properties.Settings.Default.totAch = totAchiv;
            Properties.Settings.Default.Save();
            Game f2 = new Game();

            this.Hide();
            f2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            sp.Stop();
            Application.Exit();
        }

        private void diffbutton_Click(object sender, EventArgs e)
        {
            switch (lan2) {
                case 3:
                    switch (k)
                    {
                        case 1:
                            lbldiff.Text = "легкая";
                            k2 = k;
                            k++;
                            break;
                        case 2:
                            lbldiff.Text = "средняя";
                            k2 = k;
                            k++;
                            break;
                        case 3:
                            lbldiff.Text = "сложная";
                            k2 = k;
                            k = 1;
                            break;
                    }
                    break;
                case 1:
                    switch (k)
                    {
                        case 1:
                            lbldiff.Text = "easy";
                            k2 = k;
                            k++;
                            break;
                        case 2:
                            lbldiff.Text = "medium";
                            k2 = k;
                            k++;
                            break;
                        case 3:
                            lbldiff.Text = "hard";
                            k2 = k;
                            k = 1;
                            break;
                    }
                    break;
                case 2:
                    switch (k)
                    {
                        case 1:
                            lbldiff.Text = "легка";
                            k2 = k;
                            k++;
                            break;
                        case 2:
                            lbldiff.Text = "середня";
                            k2 = k;
                            k++;
                            break;
                        case 3:
                            lbldiff.Text = "важка";
                            k2 = k;
                            k = 1;
                            break;
                    }
                    break;
            }

        }

        private void langbutton_Click(object sender, EventArgs e)
        {
            
            switch (lan)
            {
                case 1:
                    if (k == 1)
                        lbldiff.Text = "hard";
                    if (k == 2)
                        lbldiff.Text = "easy";
                    if (k == 3)
                        lbldiff.Text = "medium";
                    lblHScore2.Text = "High score: " + Game.highs;
                    startbutton.Text = "New game";
                    diffbutton.Text = "Change difficulty:";
                    langbutton.Text = "Change language";
                    opButton.Text = "Options";
                    Mbutt.Text = "Music:";
                    if (m2 == 1)
                        lblM.Text = "on";
                    else
                        lblM.Text = "off";
                    colorButton.Text = "Snake color:"; 
                    if (clr == 1)
                        lblClr.Text = "black";
                    if (clr == 2)
                        lblClr.Text = "green";
                    if (clr == 3)
                        lblClr.Text = "red";
                    if (clr == 4)
                        lblClr.Text = "blue";
                    if (clr == 5)
                        lblClr.Text = "purple";
                    lblclose.Text = "close";
                    btnAchivements.Text = "Achievements";
                    closeA.Text = "close";
                    resetach.Text = "reset achivements"; 
                    lblAgreement.Text = "Do you agree? After clicking 'yes' your process will be lost.";
                    btnYES.Text = "Yes";
                    btnNO.Text = "No"; 
                    switch (clr)
                    {
                        case 1:
                            lblBonus.Text = "Bonus: apples give more length";
                            break;
                        case 2:
                            lblBonus.Text = "Bonus: +10% green apples";
                            break;
                        case 3:
                            lblBonus.Text = "Bonus: +10% red apples";
                            break;
                        case 4:
                            lblBonus.Text = "Bonus: one game for five";
                            break;
                        case 5:
                            lblBonus.Text = "Bonus: +10% purple apples";
                            break;
                    }                    
                    lan2 = lan;
                    lan++;
                    break;
                case 2:
                    if (k == 1)
                        lbldiff.Text = "важка";
                    if (k == 2)
                        lbldiff.Text = "легка";
                    if (k == 3)
                        lbldiff.Text = "середня";
                    lblHScore2.Text = "Ваш рекорд: " + Game.highs;
                    startbutton.Text = "Почати гру";
                    diffbutton.Text = "Змiнити складнiсть:";
                    langbutton.Text = "Змiнити мову";
                    opButton.Text = "Налаштування";
                    Mbutt.Text = "Музика:";
                    if (m2 == 1)
                        lblM.Text ="увімк";
                    else
                        lblM.Text = "вимк";
                    colorButton.Text = "Колiр змiйки:";
                    if (clr == 1)
                        lblClr.Text = "чорний";
                    if (clr == 2)
                        lblClr.Text = "зелений";
                    if (clr == 3)
                        lblClr.Text = "червоний";
                    if (clr == 4)
                        lblClr.Text = "синій";
                    if (clr == 5)
                        lblClr.Text = "фіалковий";
                    lblclose.Text = "закрити";
                    btnAchivements.Text = "Досягнення";
                    closeA.Text = "закрити";
                    resetach.Text = "скинути досягнення";
                    lblAgreement.Text = "Ви згодні? Після натискання на 'так' ваш процес буде втрачено.";
                    btnYES.Text = "Так";
                    btnNO.Text = "Ні"; 
                    switch (clr)
                    {
                        case 1:
                            lblBonus.Text = "Бонус: яблука дають більше довжини";
                            break;
                        case 2:
                            lblBonus.Text = "Бонус: +10% зелених яблук";
                            break;
                        case 3:
                            lblBonus.Text = "Бонус: +10% червоних яблук";
                            break;
                        case 4:
                            lblBonus.Text = "Бонус: одна гра за п'ять";
                            break;
                        case 5:
                            lblBonus.Text = "Бонус: +10% фіалкових яблук";
                            break;
                    }
                    lan2 = lan;
                    lan++;
                    break;
                case 3:
                    if (k == 1)
                        lbldiff.Text = "сложная";
                    if (k == 2)
                        lbldiff.Text = "легкая";
                    if (k == 3)
                        lbldiff.Text = "средняя";
                    lblHScore2.Text = "Ваш рекорд: " + Game.highs;
                    startbutton.Text = "Новая игра";
                    diffbutton.Text = "Изменить сложность:";
                    langbutton.Text = "Изменить язык";
                    opButton.Text = "Настройки";
                    Mbutt.Text = "Музыка:";
                    if (m2 == 1)
                        lblM.Text = "вкл";
                    else
                        lblM.Text = "выкл";
                    colorButton.Text = "Цвет змейки:";
                    if (clr == 1)
                        lblClr.Text = "чёрный";
                    if (clr == 2)
                        lblClr.Text = "зелёный";
                    if (clr == 3)
                        lblClr.Text = "красный";
                    if (clr == 4)
                        lblClr.Text = "синий";
                    if (clr == 5)
                        lblClr.Text = "фиолетовый";
                    lblclose.Text = "закрыть";
                    btnAchivements.Text = "Достижения";
                    closeA.Text = "закрыть";
                    resetach.Text = "сбросить достижения";
                    lblAgreement.Text = "Вы согласны? После нажатия на 'да' ваш процесс будет утерян.";
                    btnYES.Text = "Да";
                    btnNO.Text = "Нет"; 
                    switch (clr)
                    {
                        case 1:
                            lblBonus.Text = "Бонус: яблоки дают больше длины";
                            break;
                        case 2:
                            lblBonus.Text = "Бонус: +10% зелёных яблок";
                            break;
                        case 3:
                            lblBonus.Text = "Бонус: +10% красных яблок";
                            break;
                        case 4:
                            lblBonus.Text = "Бонус: одна игра за пять";
                            break;
                        case 5:
                            lblBonus.Text = "Бонус: +10% фиолетовых яблок";
                            break;
                    }
                    lan2 = lan;
                    lan = 1;
                    break;
            }
            if (startbutton.Text == "Новая игра") lan3 = 3; 
            if (startbutton.Text == "Почати гру") lan3 = 2;
            if (startbutton.Text == "New game") lan3 = 1;
        }

        }
    }

