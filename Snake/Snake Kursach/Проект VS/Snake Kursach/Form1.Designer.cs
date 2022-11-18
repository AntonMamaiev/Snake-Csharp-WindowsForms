
namespace Snake_Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startbutton = new System.Windows.Forms.Button();
            this.lblHScore2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.opButton = new System.Windows.Forms.Button();
            this.btnAchivements = new System.Windows.Forms.Button();
            this.lblBonus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnYES = new System.Windows.Forms.Button();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblclose = new System.Windows.Forms.Label();
            this.lblClr = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.Mbutt = new System.Windows.Forms.Button();
            this.lbldiff = new System.Windows.Forms.Label();
            this.diffbutton = new System.Windows.Forms.Button();
            this.langbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetach = new System.Windows.Forms.Label();
            this.closeA = new System.Windows.Forms.Label();
            this.lblGPlayed = new System.Windows.Forms.Label();
            this.lblLen = new System.Windows.Forms.Label();
            this.lblTotalA = new System.Windows.Forms.Label();
            this.lblSrareapl = new System.Windows.Forms.Label();
            this.lblRareapl = new System.Windows.Forms.Label();
            this.lblApple = new System.Windows.Forms.Label();
            this.pctboxTotalA = new System.Windows.Forms.PictureBox();
            this.pctboxLen = new System.Windows.Forms.PictureBox();
            this.pctBoxGPlayed = new System.Windows.Forms.PictureBox();
            this.pctboxRareapl = new System.Windows.Forms.PictureBox();
            this.pctboxSrareapl = new System.Windows.Forms.PictureBox();
            this.pctbApple = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTotalA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGPlayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxRareapl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxSrareapl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.startbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.startbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startbutton.Location = new System.Drawing.Point(210, 130);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(186, 45);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "New game";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHScore2
            // 
            this.lblHScore2.BackColor = System.Drawing.Color.LightGreen;
            this.lblHScore2.Font = new System.Drawing.Font("Consolas", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHScore2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHScore2.Location = new System.Drawing.Point(210, 260);
            this.lblHScore2.Name = "lblHScore2";
            this.lblHScore2.Size = new System.Drawing.Size(186, 22);
            this.lblHScore2.TabIndex = 2;
            this.lblHScore2.Text = "High score: 0";
            this.lblHScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHScore2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 185;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // opButton
            // 
            this.opButton.BackColor = System.Drawing.Color.LightYellow;
            this.opButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.opButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.opButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.opButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.opButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.opButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opButton.Location = new System.Drawing.Point(210, 180);
            this.opButton.Name = "opButton";
            this.opButton.Size = new System.Drawing.Size(186, 31);
            this.opButton.TabIndex = 8;
            this.opButton.Text = "Options";
            this.opButton.UseVisualStyleBackColor = false;
            this.opButton.Click += new System.EventHandler(this.opButton_Click);
            // 
            // btnAchivements
            // 
            this.btnAchivements.BackColor = System.Drawing.Color.LightYellow;
            this.btnAchivements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAchivements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAchivements.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAchivements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAchivements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAchivements.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAchivements.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAchivements.Location = new System.Drawing.Point(210, 217);
            this.btnAchivements.Name = "btnAchivements";
            this.btnAchivements.Size = new System.Drawing.Size(186, 31);
            this.btnAchivements.TabIndex = 9;
            this.btnAchivements.Text = "Achivements";
            this.btnAchivements.UseVisualStyleBackColor = false;
            this.btnAchivements.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblBonus
            // 
            this.lblBonus.Font = new System.Drawing.Font("Consolas", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBonus.ForeColor = System.Drawing.Color.Black;
            this.lblBonus.Location = new System.Drawing.Point(281, 315);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(291, 18);
            this.lblBonus.TabIndex = 19;
            this.lblBonus.Text = "Bonus: +10% green apples";
            this.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "ver: final";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Snake_Kursach.Properties.Resources.green4;
            this.panel3.Controls.Add(this.btnNO);
            this.panel3.Controls.Add(this.btnYES);
            this.panel3.Controls.Add(this.lblAgreement);
            this.panel3.Location = new System.Drawing.Point(578, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 118);
            this.panel3.TabIndex = 12;
            this.panel3.Visible = false;
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.LightYellow;
            this.btnNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNO.Location = new System.Drawing.Point(120, 84);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(63, 31);
            this.btnNO.TabIndex = 14;
            this.btnNO.Text = "No";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYES.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYES.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYES.Location = new System.Drawing.Point(3, 84);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(63, 31);
            this.btnYES.TabIndex = 13;
            this.btnYES.Text = "Yes";
            this.btnYES.UseVisualStyleBackColor = false;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // lblAgreement
            // 
            this.lblAgreement.BackColor = System.Drawing.Color.LightYellow;
            this.lblAgreement.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgreement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgreement.Location = new System.Drawing.Point(3, 14);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(180, 42);
            this.lblAgreement.TabIndex = 13;
            this.lblAgreement.Text = "Do you agree? After clicking \"yes\" your process will be lost.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BackgroundImage = global::Snake_Kursach.Properties.Resources.green4;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblclose);
            this.panel1.Controls.Add(this.lblClr);
            this.panel1.Controls.Add(this.colorButton);
            this.panel1.Controls.Add(this.lblM);
            this.panel1.Controls.Add(this.Mbutt);
            this.panel1.Controls.Add(this.lbldiff);
            this.panel1.Controls.Add(this.diffbutton);
            this.panel1.Controls.Add(this.langbutton);
            this.panel1.Location = new System.Drawing.Point(158, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 230);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // lblclose
            // 
            this.lblclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblclose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblclose.Font = new System.Drawing.Font("Consolas", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblclose.Location = new System.Drawing.Point(85, 200);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(81, 23);
            this.lblclose.TabIndex = 10;
            this.lblclose.Text = "close";
            this.lblclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // lblClr
            // 
            this.lblClr.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblClr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClr.Font = new System.Drawing.Font("Consolas", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClr.Location = new System.Drawing.Point(160, 156);
            this.lblClr.Name = "lblClr";
            this.lblClr.Size = new System.Drawing.Size(81, 35);
            this.lblClr.TabIndex = 9;
            this.lblClr.Text = "green";
            this.lblClr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClr.Click += new System.EventHandler(this.label3_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.LightYellow;
            this.colorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorButton.Font = new System.Drawing.Font("Consolas", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorButton.Location = new System.Drawing.Point(3, 156);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(151, 35);
            this.colorButton.TabIndex = 8;
            this.colorButton.Text = "Snake color:";
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // lblM
            // 
            this.lblM.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM.Font = new System.Drawing.Font("Consolas", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblM.Location = new System.Drawing.Point(160, 109);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(81, 35);
            this.lblM.TabIndex = 7;
            this.lblM.Text = "on";
            this.lblM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mbutt
            // 
            this.Mbutt.BackColor = System.Drawing.Color.LightYellow;
            this.Mbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mbutt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mbutt.Font = new System.Drawing.Font("Consolas", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mbutt.Location = new System.Drawing.Point(3, 109);
            this.Mbutt.Name = "Mbutt";
            this.Mbutt.Size = new System.Drawing.Size(151, 35);
            this.Mbutt.TabIndex = 6;
            this.Mbutt.Text = "Music:";
            this.Mbutt.UseVisualStyleBackColor = false;
            this.Mbutt.Click += new System.EventHandler(this.Mbutt_Click);
            // 
            // lbldiff
            // 
            this.lbldiff.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbldiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldiff.Font = new System.Drawing.Font("Consolas", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldiff.Location = new System.Drawing.Point(160, 63);
            this.lbldiff.Name = "lbldiff";
            this.lbldiff.Size = new System.Drawing.Size(81, 35);
            this.lbldiff.TabIndex = 5;
            this.lbldiff.Text = "easy";
            this.lbldiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diffbutton
            // 
            this.diffbutton.BackColor = System.Drawing.Color.LightYellow;
            this.diffbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diffbutton.Font = new System.Drawing.Font("Consolas", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffbutton.Location = new System.Drawing.Point(3, 63);
            this.diffbutton.Name = "diffbutton";
            this.diffbutton.Size = new System.Drawing.Size(151, 35);
            this.diffbutton.TabIndex = 4;
            this.diffbutton.Text = "Change difficulty:";
            this.diffbutton.UseVisualStyleBackColor = false;
            this.diffbutton.Click += new System.EventHandler(this.diffbutton_Click);
            // 
            // langbutton
            // 
            this.langbutton.BackColor = System.Drawing.Color.LightYellow;
            this.langbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.langbutton.Font = new System.Drawing.Font("Consolas", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.langbutton.Location = new System.Drawing.Point(3, 18);
            this.langbutton.Name = "langbutton";
            this.langbutton.Size = new System.Drawing.Size(239, 35);
            this.langbutton.TabIndex = 3;
            this.langbutton.Text = "Change language";
            this.langbutton.UseVisualStyleBackColor = false;
            this.langbutton.Click += new System.EventHandler(this.langbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BackgroundImage = global::Snake_Kursach.Properties.Resources.green4;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resetach);
            this.panel2.Controls.Add(this.closeA);
            this.panel2.Controls.Add(this.lblGPlayed);
            this.panel2.Controls.Add(this.lblLen);
            this.panel2.Controls.Add(this.lblTotalA);
            this.panel2.Controls.Add(this.lblSrareapl);
            this.panel2.Controls.Add(this.lblRareapl);
            this.panel2.Controls.Add(this.lblApple);
            this.panel2.Controls.Add(this.pctboxTotalA);
            this.panel2.Controls.Add(this.pctboxLen);
            this.panel2.Controls.Add(this.pctBoxGPlayed);
            this.panel2.Controls.Add(this.pctboxRareapl);
            this.panel2.Controls.Add(this.pctboxSrareapl);
            this.panel2.Controls.Add(this.pctbApple);
            this.panel2.Location = new System.Drawing.Point(12, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 230);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // resetach
            // 
            this.resetach.BackColor = System.Drawing.Color.LightSalmon;
            this.resetach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resetach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetach.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetach.Location = new System.Drawing.Point(178, 200);
            this.resetach.Name = "resetach";
            this.resetach.Size = new System.Drawing.Size(64, 23);
            this.resetach.TabIndex = 18;
            this.resetach.Text = "reset achivements";
            this.resetach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetach.Click += new System.EventHandler(this.resetach_Click);
            // 
            // closeA
            // 
            this.closeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeA.Location = new System.Drawing.Point(90, 200);
            this.closeA.Name = "closeA";
            this.closeA.Size = new System.Drawing.Size(64, 23);
            this.closeA.TabIndex = 11;
            this.closeA.Text = "close";
            this.closeA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeA.Click += new System.EventHandler(this.closeA_Click);
            // 
            // lblGPlayed
            // 
            this.lblGPlayed.BackColor = System.Drawing.Color.LightGreen;
            this.lblGPlayed.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.lblGPlayed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGPlayed.Location = new System.Drawing.Point(3, 167);
            this.lblGPlayed.Name = "lblGPlayed";
            this.lblGPlayed.Size = new System.Drawing.Size(64, 12);
            this.lblGPlayed.TabIndex = 17;
            this.lblGPlayed.Text = "0/500";
            this.lblGPlayed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLen
            // 
            this.lblLen.BackColor = System.Drawing.Color.LightGreen;
            this.lblLen.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.lblLen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLen.Location = new System.Drawing.Point(90, 167);
            this.lblLen.Name = "lblLen";
            this.lblLen.Size = new System.Drawing.Size(64, 12);
            this.lblLen.TabIndex = 16;
            this.lblLen.Text = "0/500";
            this.lblLen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalA
            // 
            this.lblTotalA.BackColor = System.Drawing.Color.LightGreen;
            this.lblTotalA.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.lblTotalA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalA.Location = new System.Drawing.Point(178, 167);
            this.lblTotalA.Name = "lblTotalA";
            this.lblTotalA.Size = new System.Drawing.Size(64, 12);
            this.lblTotalA.TabIndex = 15;
            this.lblTotalA.Text = "0/6";
            this.lblTotalA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSrareapl
            // 
            this.lblSrareapl.BackColor = System.Drawing.Color.LightGreen;
            this.lblSrareapl.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.lblSrareapl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSrareapl.Location = new System.Drawing.Point(178, 72);
            this.lblSrareapl.Name = "lblSrareapl";
            this.lblSrareapl.Size = new System.Drawing.Size(64, 12);
            this.lblSrareapl.TabIndex = 14;
            this.lblSrareapl.Text = "0/500";
            this.lblSrareapl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRareapl
            // 
            this.lblRareapl.BackColor = System.Drawing.Color.LightGreen;
            this.lblRareapl.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.lblRareapl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRareapl.Location = new System.Drawing.Point(90, 72);
            this.lblRareapl.Name = "lblRareapl";
            this.lblRareapl.Size = new System.Drawing.Size(64, 12);
            this.lblRareapl.TabIndex = 13;
            this.lblRareapl.Text = "0/500";
            this.lblRareapl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblApple
            // 
            this.lblApple.BackColor = System.Drawing.Color.LightGreen;
            this.lblApple.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.lblApple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApple.Location = new System.Drawing.Point(3, 72);
            this.lblApple.Name = "lblApple";
            this.lblApple.Size = new System.Drawing.Size(64, 12);
            this.lblApple.TabIndex = 12;
            this.lblApple.Text = "0/500";
            this.lblApple.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctboxTotalA
            // 
            this.pctboxTotalA.BackgroundImage = global::Snake_Kursach.Properties.Resources.DONE;
            this.pctboxTotalA.Location = new System.Drawing.Point(178, 100);
            this.pctboxTotalA.Name = "pctboxTotalA";
            this.pctboxTotalA.Size = new System.Drawing.Size(64, 64);
            this.pctboxTotalA.TabIndex = 5;
            this.pctboxTotalA.TabStop = false;
            // 
            // pctboxLen
            // 
            this.pctboxLen.BackgroundImage = global::Snake_Kursach.Properties.Resources.Len;
            this.pctboxLen.Location = new System.Drawing.Point(90, 100);
            this.pctboxLen.Name = "pctboxLen";
            this.pctboxLen.Size = new System.Drawing.Size(64, 64);
            this.pctboxLen.TabIndex = 4;
            this.pctboxLen.TabStop = false;
            // 
            // pctBoxGPlayed
            // 
            this.pctBoxGPlayed.BackgroundImage = global::Snake_Kursach.Properties.Resources.gamesP;
            this.pctBoxGPlayed.Location = new System.Drawing.Point(3, 100);
            this.pctBoxGPlayed.Name = "pctBoxGPlayed";
            this.pctBoxGPlayed.Size = new System.Drawing.Size(64, 64);
            this.pctBoxGPlayed.TabIndex = 3;
            this.pctBoxGPlayed.TabStop = false;
            // 
            // pctboxRareapl
            // 
            this.pctboxRareapl.BackgroundImage = global::Snake_Kursach.Properties.Resources.greenapp;
            this.pctboxRareapl.Location = new System.Drawing.Point(90, 5);
            this.pctboxRareapl.Name = "pctboxRareapl";
            this.pctboxRareapl.Size = new System.Drawing.Size(64, 64);
            this.pctboxRareapl.TabIndex = 2;
            this.pctboxRareapl.TabStop = false;
            // 
            // pctboxSrareapl
            // 
            this.pctboxSrareapl.BackgroundImage = global::Snake_Kursach.Properties.Resources.prplapple;
            this.pctboxSrareapl.Location = new System.Drawing.Point(178, 5);
            this.pctboxSrareapl.Name = "pctboxSrareapl";
            this.pctboxSrareapl.Size = new System.Drawing.Size(64, 64);
            this.pctboxSrareapl.TabIndex = 1;
            this.pctboxSrareapl.TabStop = false;
            // 
            // pctbApple
            // 
            this.pctbApple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbApple.BackgroundImage")));
            this.pctbApple.Location = new System.Drawing.Point(3, 5);
            this.pctbApple.Name = "pctbApple";
            this.pctbApple.Size = new System.Drawing.Size(64, 64);
            this.pctbApple.TabIndex = 0;
            this.pctbApple.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Snake_Kursach.Properties.Resources.titlescr2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(205, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 64);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 300);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAchivements);
            this.Controls.Add(this.opButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHScore2);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTotalA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGPlayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxRareapl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxSrareapl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label lblHScore2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button opButton;
        private System.Windows.Forms.Button Mbutt;
        private System.Windows.Forms.Label lbldiff;
        private System.Windows.Forms.Button diffbutton;
        private System.Windows.Forms.Button langbutton;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Label lblClr;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAchivements;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeA;
        private System.Windows.Forms.Label lblGPlayed;
        private System.Windows.Forms.Label lblLen;
        private System.Windows.Forms.Label lblTotalA;
        private System.Windows.Forms.Label lblSrareapl;
        private System.Windows.Forms.Label lblRareapl;
        private System.Windows.Forms.Label lblApple;
        private System.Windows.Forms.PictureBox pctboxTotalA;
        private System.Windows.Forms.PictureBox pctboxLen;
        private System.Windows.Forms.PictureBox pctBoxGPlayed;
        private System.Windows.Forms.PictureBox pctboxRareapl;
        private System.Windows.Forms.PictureBox pctboxSrareapl;
        private System.Windows.Forms.PictureBox pctbApple;
        private System.Windows.Forms.Label resetach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label label2;
    }
}

