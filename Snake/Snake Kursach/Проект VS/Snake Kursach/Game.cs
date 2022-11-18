using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Kursach
{

    public partial class Game : Form
    {

        int width, height;
        int k = 1, clr = 1, ch1, ch11, ch2, ch22, ch3, ch33, black = 0, blue = 0;
        public static int highs, score, lang, dif, sumred, sumgreen, sumprpl, gpl, sumlen;
        Point[] snake;
        Point apple;
        Random r, rclr;
        int len = 1;
        SolidBrush b;
        SolidBrush red, green, purple;
        SolidBrush fstcol_brush;
        SolidBrush seccol_brush;
        public Game()
        {
            InitializeComponent();

            r = new Random();
            rclr = new Random();
            sumred = Form1.sumred; sumgreen = Form1.sumgreen; sumprpl = Form1.sumprpl; gpl = Form1.gpl; sumlen = Form1.sumlen;
            snake = new Point[10000];
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            width = pictureBox1.Width / 10;
            height = pictureBox1.Height / 10;
            snake[0].X = width / 2;
            snake[0].Y = height / 2;
            b = new SolidBrush(Color.LemonChiffon);
            green = new SolidBrush(Color.Green);
            purple = new SolidBrush(Color.Purple);
            red = new SolidBrush(Color.Red);

            //цвет змейки
            if (Form1.clr2 == 1) //зеленая
            {
                ch1 = 1; ch11 = 74; ch2 = 75; ch22 = 89; ch3 = 90; ch33 = 100;
                no2.BackColor = Color.LightGreen;
                no.BackColor = Color.LightGreen;
                this.BackColor = Color.LightGreen;
                panel2.BackColor = Color.ForestGreen;
                panel1.BackColor = Color.ForestGreen;
                menuStrip1.BackColor = Color.LimeGreen;
                pauselbl.BackColor = Color.LemonChiffon;
                b = new SolidBrush(Color.LemonChiffon);
            }
            if (Form1.clr2 == 2) //красная
            {
                ch1 = 1; ch11 = 89; ch2 = 90; ch22 = 94; ch3 = 95; ch33 = 100;
                no2.BackColor = Color.LightCoral;
                no.BackColor = Color.LightCoral;
                this.BackColor = Color.LightCoral;
                panel2.BackColor = Color.Firebrick;
                panel1.BackColor = Color.Firebrick;
                menuStrip1.BackColor = Color.Firebrick;
                pauselbl.BackColor = Color.FromArgb(230, 191, 191);
                b = new SolidBrush(Color.FromArgb(230,191,191));
            }
            if (Form1.clr2 == 3) //синяя
            {
                ch1 = 1; ch11 = 84; ch2 = 85; ch22 = 90; ch3 = 91; ch33 = 100; blue = 1;
                no2.BackColor = Color.LightBlue;
                no.BackColor = Color.LightBlue;
                this.BackColor = Color.LightBlue;
                panel2.BackColor = Color.DodgerBlue;
                panel1.BackColor = Color.DodgerBlue;
                menuStrip1.BackColor = Color.DodgerBlue;
                pauselbl.BackColor = Color.LightCyan;
                b = new SolidBrush(Color.LightCyan);
            }
            if (Form1.clr2 == 4) //фиол
            {
                ch1 = 1; ch11 = 59; ch2 = 60; ch22 = 79; ch3 = 80; ch33 = 100;
                no2.BackColor = Color.MediumSlateBlue;
                no.BackColor = Color.MediumSlateBlue;
                this.BackColor = Color.MediumSlateBlue;
                panel2.BackColor = Color.Purple;
                panel1.BackColor = Color.Purple;
                menuStrip1.BackColor = Color.MediumPurple;
                pauselbl.BackColor = Color.Thistle;
                b = new SolidBrush(Color.Thistle);
            }
            if (Form1.clr2 == 5) //черная
            {
                ch1 = 1; ch11 = 84; ch2 = 85; ch22 = 90; ch3 = 91; ch33 = 100; black = 1;
                no2.BackColor = Color.Silver;
                no.BackColor = Color.Silver;
                this.BackColor = Color.Silver;
                panel2.BackColor = Color.Gray;
                panel1.BackColor = Color.Gray;
                menuStrip1.BackColor = Color.Gray;
                pauselbl.BackColor = Color.Gainsboro;
                b = new SolidBrush(Color.Gainsboro);
            }

            fstcol_brush = new SolidBrush(Color.FromArgb(Form1.cr1,Form1.cg1,Form1.cb1));
            seccol_brush = new SolidBrush(Color.FromArgb(Form1.cr2, Form1.cg2, Form1.cb2));

            apple.X = r.Next(0, width-1);
            apple.Y = r.Next(0, height-1);
        }

        string direction="up"; // Направление змейки поумл.
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            dif = Form1.diffv;
            timer1.Interval = dif;


            Graphics g = Graphics.FromImage(pictureBox1.Image);

            g.FillRectangle(b,0,0,pictureBox1.Width, pictureBox1.Height); // Закрасить игровое поле

            // Если змейка съела себя
            if(len > 4) {
                for (int i = 1; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            if (score >= highs)
                            {
                                highs = score;
                                Properties.Settings.Default.highscore = highs;
                                Properties.Settings.Default.Save();
                            }
                            if (blue == 1)
                                gpl += 5;//
                            else gpl++;
                            Properties.Settings.Default.gplayed = gpl;
                            Properties.Settings.Default.Save();
                            score = 0;
                            len = 3;
                            if (lang == 1)
                                lblScore.Text = "Score: " + score;
                            if (lang == 2)
                                lblScore.Text = "Рахунок: " + score;
                            if (lang == 3)
                                lblScore.Text = "Счёт: " + score;
                        }
                    }
                }
            }    

            for (int i = 0; i < len; i++)
            {
                if (i == 0 || i%2 == 0)              
                    g.FillRectangle(seccol_brush, snake[i].X * 10, snake[i].Y * 10, 10, 10); // Создаем змейку в 10 пикс
                else
                    g.FillRectangle(fstcol_brush, snake[i].X * 10, snake[i].Y * 10, 10, 10); // Создаем змейку в 10 пикс
                    
                // Уход змейки за карту
                if (snake[i].X <= 0) snake[i].X += width;
                if (snake[i].X >= width) snake[i].X -= width;
                if (snake[i].Y <= 0) snake[i].Y += height;
                if (snake[i].Y >= height) snake[i].Y -= height;

                if (apple.X == snake[i].X && apple.Y == snake[i].Y) // Змея ест яблоко
                {
                    apple.X = r.Next(0, width - 1);
                    apple.Y = r.Next(0, height - 1);
                    if (clr >= ch1 && clr <= ch11)
                    {
                        sumred++;//
                        score++;
                        if (black == 1)
                        { len += 2; sumlen += 2; }
                        else len++;
                        Properties.Settings.Default.sumred = sumred;
                        Properties.Settings.Default.Save();
                    }
                    if (clr >= ch2 && clr <= ch22)
                    {
                        sumgreen++;//
                        score += 5;
                        if (black == 1)
                        { len += 2; sumlen += 2; }
                        else len++;
                        Properties.Settings.Default.sumgreen = sumgreen;
                        Properties.Settings.Default.Save();
                    }
                    if (clr >= ch3 && clr <= ch33)
                    {
                        if (black == 1)
                        { len += 2; sumlen += 2; }
                        else len++;
                        sumprpl++;//
                        score += 15;
                        Properties.Settings.Default.sumprpl = sumprpl;
                        Properties.Settings.Default.Save();
                    }
                    sumlen++;//
                    Properties.Settings.Default.sumLen = sumlen;
                    Properties.Settings.Default.Save();
                    clr = rclr.Next(1, 101);
                    if (lang == 1)
                        lblScore.Text = "Score: " + score;
                    if (lang == 2)
                        lblScore.Text = "Рахунок: " + score;
                    if (lang == 3)
                        lblScore.Text = "Счёт: " + score;
                }


                
            }

            if (score >= highs)
            {
                highs = score;
                if(lang == 1)
                    lblHScore.Text = "High score: " + highs;
                if (lang == 2)
                    lblHScore.Text = "Ваш рекорд: " + highs;
                if (lang == 3)
                    lblHScore.Text = "Ваш рекорд: " + highs;
            }

            
            if(clr >= ch1 && clr <= ch11) {
                g.FillEllipse(red, apple.X*10, apple.Y*10, 10, 10); // Рисуем яблоко
            }
            if (clr >= ch2 && clr <= ch22)
            {
                g.FillEllipse(green, apple.X * 10, apple.Y * 10, 10, 10); // Рисуем яблоко
            }
            if (clr >= ch3 && clr <= ch33)
            {
                g.FillEllipse(purple, apple.X * 10, apple.Y * 10, 10, 10); // Рисуем яблоко
            }

            if (direction == "up") snake[0].Y -= 1;
            if (direction == "down") snake[0].Y += 1;
            if (direction == "left") snake[0].X -= 1;
            if (direction == "right") snake[0].X += 1;

            if (len > 10000 - 3)
            {
                len = 10000 - 3;
            }
            for (int i = len ; i >= 0 ; i--)
            {
                snake[i + 1].X = snake[i].X;
                snake[i + 1].Y = snake[i].Y;
            }
            if (len < 4) len++;
            pictureBox1.Invalidate();
        }

        private void lblAgreement_Click(object sender, EventArgs e)
        {

        }

        

        private void lblYES_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            pauseResumeToolStripMenuItem.Enabled = true;
            backToMenuToolStripMenuItem.Enabled = true;
            Lblreset.Enabled = true;
            switch (k)
            {
                case 1:
                    timer1.Stop();
                    k++;
                    pauselbl.Visible = true;
                    break;
                case 2:
                    timer1.Start();
                    timer1.Interval = dif;
                    pauselbl.Visible = false;
                    k = 1;
                    break;
            }
            panel1.Visible = false;
            highs = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pauseResumeToolStripMenuItem.Enabled = true;
            backToMenuToolStripMenuItem.Enabled = true;
            Lblreset.Enabled = true;
            switch (k)
            {
                case 1:
                    timer1.Stop();
                k++;
                pauselbl.Visible = true;
                break;
                case 2:
                    timer1.Start();
                timer1.Interval = dif;
                pauselbl.Visible = false;
                k = 1;
                break;
            }
            panel1.Visible = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            pauseResumeToolStripMenuItem.Enabled = true;
            backToMenuToolStripMenuItem.Enabled = true;
            Lblreset.Enabled = true;
            switch (k)
            {
                case 1:
                    timer1.Stop();
                    k++;
                    pauselbl.Visible = true;
                    break;
                case 2:
                    timer1.Start();
                    timer1.Interval = dif;
                    pauselbl.Visible = false;
                    k = 1;
                    break;
            }

            if (score >= highs)
            {
                highs = score;
                Properties.Settings.Default.highscore = highs;
                Properties.Settings.Default.Save();
            }
            panel2.Visible = false;
            panel2.Location = new Point(217, 281);
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            pauseResumeToolStripMenuItem.Enabled = true;
            backToMenuToolStripMenuItem.Enabled = true;
            Lblreset.Enabled = true;
            switch (k)
            {
                case 1:
                    timer1.Stop();
                    k++;
                    pauselbl.Visible = true;
                    break;
                case 2:
                    timer1.Start();
                    timer1.Interval = dif;
                    pauselbl.Visible = false;
                    k = 1;
                    break;
            }
            panel2.Visible = false;
            panel2.Location = new Point(217, 281);
        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
        }

        private void pauseResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (score >= highs)
            {
                highs = score;
                Properties.Settings.Default.highscore = highs;
                Properties.Settings.Default.Save();
            }
            switch (k)
            {
                case 1:
                    backToMenuToolStripMenuItem.Enabled = false;
                    Lblreset.Enabled = false;
                    timer1.Stop();
                    k++;
                    pauselbl.Visible = true;
                    break;
                case 2:
                    backToMenuToolStripMenuItem.Enabled = true;
                    Lblreset.Enabled = true;
                    timer1.Start();
                    timer1.Interval = dif;
                    pauselbl.Visible = false;
                    k = 1;
                    break;
            }     
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblHScore_Click(object sender, EventArgs e)
        {

        }

        private void Lblreset_Click(object sender, EventArgs e)
        {
            pauseResumeToolStripMenuItem.Enabled = false;
            backToMenuToolStripMenuItem.Enabled = false;
            Lblreset.Enabled = false;
            switch (k)
            {
                case 1:
                    timer1.Stop();
                    k++;
                    pauselbl.Visible = true;
                    break;
                case 2:
                    timer1.Start();
                    timer1.Interval = dif;
                    pauselbl.Visible = false;
                    k = 1;
                    break;
            }
            panel1.Visible = true;
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void Game_Load(object sender, EventArgs e)
        {
            score = 0;

            dif = Form1.diffv;
            timer1.Interval = dif;

            lang = Form1.lan3;

            switch (lang)
            {
                case 1:
                    lblScore.Text = "Score: " + score;
                    lblHScore.Text = "High score: " + highs;
                    pauseResumeToolStripMenuItem.Text = "Pause/Resume";
                    backToMenuToolStripMenuItem.Text = "Back to menu";
                    Lblreset.Text = "Reset score";
                    lblAgreement.Text = "Do you agree? After clicking 'yes' your process will be lost.";
                    yes.Text = "Yes";
                    no.Text = "No";
                    agrem.Text = "Do you agree? After clicking 'yes' your process will be lost.";
                    yes2.Text = "Yes";
                    no2.Text = "No";
                    switch (Form1.clr2)
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
                    lblScore.Text = "Рахунок: " + score;
                    lblHScore.Text = "Ваш рекорд: " + highs;
                    pauseResumeToolStripMenuItem.Text = "Пауза/Почати";
                    backToMenuToolStripMenuItem.Text = "Повернутися у меню";
                    Lblreset.Text = "Скинути рекорд";
                    lblAgreement.Text = "Ви згодні? Після натискання на 'так' ваш процес буде втрачено.";
                    yes.Text = "Так";
                    no.Text = "Ні"; 
                    agrem.Text = "Ви згодні? Після натискання на 'так' ваш процес буде втрачено.";
                    yes2.Text = "Так";
                    no2.Text = "Ні"; 
                    switch (Form1.clr2)
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
                    lblScore.Text = "Счёт: " + score;
                    lblHScore.Text = "Ваш рекорд: " + highs;
                    pauseResumeToolStripMenuItem.Text = "Пауза/Начать";
                    backToMenuToolStripMenuItem.Text = "Вернуться в меню";
                    Lblreset.Text = "Сбросить рекорд";
                    lblAgreement.Text = "Вы согласны? После нажатия на 'да' ваш процесс будет утерян.";
                    yes.Text = "Да";
                    no.Text = "Нет";
                    agrem.Text = "Вы согласны? После нажатия на 'да' ваш процесс будет утерян.";
                    yes2.Text = "Да";
                    no2.Text = "Нет";
                    
                    switch (Form1.clr2)
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

        ///
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pauseResumeToolStripMenuItem.Enabled = false;
            backToMenuToolStripMenuItem.Enabled = false;
            Lblreset.Enabled = false;
            switch (k)
            {
                case 1:
                    timer1.Stop();
                    k++;
                    pauselbl.Visible = true;
                    break;
                case 2:
                    timer1.Start();
                    timer1.Interval = dif;
                    pauselbl.Visible = false;
                    k = 1;
                    break;
            }
            panel2.Visible = true;
            panel2.Location = new Point(217, 165);
        }

        private void pausebutton_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (k)
                {
                    case 1:
                        timer1.Stop();
                        pauselbl.Visible = true;
                        k++;
                        break;
                    case 2:
                        timer1.Start();
                        pauselbl.Visible = false;
                        timer1.Interval = dif;
                        k = 1;
                        break;
                }
            }

            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && !(direction == "down"))
            {
                direction = "up";
            }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S)&& !(direction == "up"))
            {
                direction = "down";
            }
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && !(direction == "right"))
            {
                direction = "left";
            }
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && !(direction == "left"))
            {
                direction = "right";
            }
        }

        }

        
    }

