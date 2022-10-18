
namespace gameparkerjames
{
    partial class Survival
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.LblGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.TmrBullet = new System.Windows.Forms.Timer(this.components);
            this.TmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Gray;
            this.PnlGame.Location = new System.Drawing.Point(10, 90);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(580, 500);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.AutoSize = false;
            this.MnuStart.BackColor = System.Drawing.Color.Silver;
            this.MnuStart.ForeColor = System.Drawing.Color.Black;
            this.MnuStart.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MnuStart.MergeIndex = 0;
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.MnuStart.Size = new System.Drawing.Size(60, 30);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.AutoSize = false;
            this.MnuStop.BackColor = System.Drawing.Color.Silver;
            this.MnuStop.ForeColor = System.Drawing.Color.Black;
            this.MnuStop.Margin = new System.Windows.Forms.Padding(10);
            this.MnuStop.MergeIndex = 0;
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.MnuStop.Size = new System.Drawing.Size(60, 30);
            this.MnuStop.Text = "Stop";
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // LblGame
            // 
            this.LblGame.BackColor = System.Drawing.Color.Silver;
            this.LblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LblGame.Location = new System.Drawing.Point(310, 55);
            this.LblGame.Name = "LblGame";
            this.LblGame.Size = new System.Drawing.Size(80, 30);
            this.LblGame.TabIndex = 2;
            this.LblGame.Text = "Bullet Survival";
            this.LblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(605, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.Silver;
            this.TxtName.Location = new System.Drawing.Point(605, 130);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(80, 30);
            this.TxtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(605, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblScore
            // 
            this.LblScore.BackColor = System.Drawing.Color.Silver;
            this.LblScore.Location = new System.Drawing.Point(605, 210);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(80, 30);
            this.LblScore.TabIndex = 6;
            this.LblScore.Text = "0";
            this.LblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(605, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lives";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLives
            // 
            this.LblLives.BackColor = System.Drawing.Color.Silver;
            this.LblLives.Location = new System.Drawing.Point(605, 290);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(80, 30);
            this.LblLives.TabIndex = 8;
            this.LblLives.Text = "10";
            this.LblLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TmrBullet
            // 
            this.TmrBullet.Enabled = true;
            this.TmrBullet.Tick += new System.EventHandler(this.TmrBullet_Tick);
            // 
            // TmrPlayer
            // 
            this.TmrPlayer.Enabled = true;
            this.TmrPlayer.Interval = 50;
            this.TmrPlayer.Tick += new System.EventHandler(this.TmrPlayer_Tick);
            // 
            // Survival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblGame);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Survival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Survival_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Survival_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Survival_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
        private System.Windows.Forms.Label LblGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Timer TmrBullet;
        private System.Windows.Forms.Timer TmrPlayer;
    }
}

