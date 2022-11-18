
namespace Snake_Kursach
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pauseResumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lblreset = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pauselbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.no = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.no2 = new System.Windows.Forms.Label();
            this.yes2 = new System.Windows.Forms.Label();
            this.agrem = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(12, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(115, 19);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 1000";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblHScore
            // 
            this.lblHScore.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHScore.Location = new System.Drawing.Point(142, 33);
            this.lblHScore.Name = "lblHScore";
            this.lblHScore.Size = new System.Drawing.Size(152, 18);
            this.lblHScore.TabIndex = 2;
            this.lblHScore.Text = "High score: 1000";
            this.lblHScore.Click += new System.EventHandler(this.lblHScore_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LimeGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseResumeToolStripMenuItem,
            this.backToMenuToolStripMenuItem,
            this.Lblreset});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pauseResumeToolStripMenuItem
            // 
            this.pauseResumeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.pauseResumeToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseResumeToolStripMenuItem.Name = "pauseResumeToolStripMenuItem";
            this.pauseResumeToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.pauseResumeToolStripMenuItem.Text = "Pause/Resume";
            this.pauseResumeToolStripMenuItem.Click += new System.EventHandler(this.pauseResumeToolStripMenuItem_Click);
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.backToMenuToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.backToMenuToolStripMenuItem.Text = "Back to menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // Lblreset
            // 
            this.Lblreset.BackColor = System.Drawing.Color.Transparent;
            this.Lblreset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.Lblreset.Name = "Lblreset";
            this.Lblreset.Size = new System.Drawing.Size(120, 23);
            this.Lblreset.Text = "Reset score";
            this.Lblreset.Click += new System.EventHandler(this.Lblreset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 520);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pauselbl
            // 
            this.pauselbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.pauselbl.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauselbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pauselbl.Location = new System.Drawing.Point(236, 112);
            this.pauselbl.Name = "pauselbl";
            this.pauselbl.Size = new System.Drawing.Size(154, 50);
            this.pauselbl.TabIndex = 10;
            this.pauselbl.Text = "PAUSE";
            this.pauselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pauselbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.no);
            this.panel1.Controls.Add(this.yes);
            this.panel1.Controls.Add(this.lblAgreement);
            this.panel1.Location = new System.Drawing.Point(217, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 110);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.LightGreen;
            this.no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.no.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.no.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.no.Location = new System.Drawing.Point(124, 72);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(63, 31);
            this.no.TabIndex = 16;
            this.no.Text = "No";
            this.no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no.Click += new System.EventHandler(this.label2_Click);
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.yes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yes.Location = new System.Drawing.Point(3, 72);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(63, 31);
            this.yes.TabIndex = 15;
            this.yes.Text = "Yes";
            this.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAgreement
            // 
            this.lblAgreement.BackColor = System.Drawing.Color.LightYellow;
            this.lblAgreement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgreement.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblAgreement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgreement.Location = new System.Drawing.Point(3, 11);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(184, 49);
            this.lblAgreement.TabIndex = 14;
            this.lblAgreement.Text = "Do you agree? After clicking \"yes\" your process will be lost.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.no2);
            this.panel2.Controls.Add(this.yes2);
            this.panel2.Controls.Add(this.agrem);
            this.panel2.Location = new System.Drawing.Point(217, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 110);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // no2
            // 
            this.no2.BackColor = System.Drawing.Color.LightGreen;
            this.no2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.no2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.no2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.no2.Location = new System.Drawing.Point(124, 72);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(63, 31);
            this.no2.TabIndex = 16;
            this.no2.Text = "No";
            this.no2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // yes2
            // 
            this.yes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yes2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yes2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.yes2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yes2.Location = new System.Drawing.Point(3, 72);
            this.yes2.Name = "yes2";
            this.yes2.Size = new System.Drawing.Size(63, 31);
            this.yes2.TabIndex = 15;
            this.yes2.Text = "Yes";
            this.yes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // agrem
            // 
            this.agrem.BackColor = System.Drawing.Color.LightYellow;
            this.agrem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agrem.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold);
            this.agrem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agrem.Location = new System.Drawing.Point(3, 11);
            this.agrem.Name = "agrem";
            this.agrem.Size = new System.Drawing.Size(184, 49);
            this.agrem.TabIndex = 14;
            this.agrem.Text = "Do you agree? After clicking \"yes\" your process will be lost.";
            // 
            // lblBonus
            // 
            this.lblBonus.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBonus.Location = new System.Drawing.Point(330, 34);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(282, 18);
            this.lblBonus.TabIndex = 18;
            this.lblBonus.Text = "Bonus: +10% green apples";
            this.lblBonus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(624, 585);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pauselbl);
            this.Controls.Add(this.lblHScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pauseResumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.Label pauselbl;
        private System.Windows.Forms.ToolStripMenuItem Lblreset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.Label yes;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label no2;
        private System.Windows.Forms.Label yes2;
        private System.Windows.Forms.Label agrem;
        private System.Windows.Forms.Label lblBonus;
    }
}