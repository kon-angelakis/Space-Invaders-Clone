namespace Space_Invaders
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
            this.BulletTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.EnemyMovement = new System.Windows.Forms.Timer(this.components);
            this.livesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.EnemyFire = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.EnemySpawn = new System.Windows.Forms.Timer(this.components);
            this.DownALevel = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.TimeLimit = new System.Windows.Forms.Timer(this.components);
            this.gamePanel = new System.Windows.Forms.Panel();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.restartButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BulletTimer
            // 
            this.BulletTimer.Interval = 8;
            this.BulletTimer.Tick += new System.EventHandler(this.Bullet_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(421, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time:";
            // 
            // EnemyMovement
            // 
            this.EnemyMovement.Interval = 2000;
            this.EnemyMovement.Tick += new System.EventHandler(this.EnemyMovement_Tick);
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.livesLabel.Location = new System.Drawing.Point(4, 445);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(32, 13);
            this.livesLabel.TabIndex = 3;
            this.livesLabel.Text = "Lives";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel.Location = new System.Drawing.Point(408, 445);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(38, 13);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score:";
            // 
            // EnemyFire
            // 
            this.EnemyFire.Interval = 1500;
            this.EnemyFire.Tick += new System.EventHandler(this.EnemyFire_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.ForeColor = System.Drawing.Color.Aqua;
            this.score.Location = new System.Drawing.Point(445, 445);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(13, 13);
            this.score.TabIndex = 8;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemySpawn
            // 
            this.EnemySpawn.Interval = 1000;
            this.EnemySpawn.Tick += new System.EventHandler(this.EnemySpawn_Tick);
            // 
            // DownALevel
            // 
            this.DownALevel.Interval = 3000;
            this.DownALevel.Tick += new System.EventHandler(this.DownALevel_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.Snow;
            this.timeLabel.Location = new System.Drawing.Point(454, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(25, 13);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "180";
            // 
            // TimeLimit
            // 
            this.TimeLimit.Interval = 1000;
            this.TimeLimit.Tick += new System.EventHandler(this.TimeLimit_Tick);
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.timeLabel);
            this.gamePanel.Controls.Add(this.score);
            this.gamePanel.Controls.Add(this.life3);
            this.gamePanel.Controls.Add(this.life2);
            this.gamePanel.Controls.Add(this.life1);
            this.gamePanel.Controls.Add(this.scoreLabel);
            this.gamePanel.Controls.Add(this.livesLabel);
            this.gamePanel.Controls.Add(this.label1);
            this.gamePanel.Controls.Add(this.player);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Enabled = false;
            this.gamePanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(484, 461);
            this.gamePanel.TabIndex = 10;
            this.gamePanel.Visible = false;
            // 
            // life3
            // 
            this.life3.Image = global::Space_Invaders.Properties.Resources.Player;
            this.life3.Location = new System.Drawing.Point(98, 441);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(35, 20);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life3.TabIndex = 7;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = global::Space_Invaders.Properties.Resources.Player;
            this.life2.Location = new System.Drawing.Point(66, 441);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(35, 20);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life2.TabIndex = 6;
            this.life2.TabStop = false;
            // 
            // life1
            // 
            this.life1.Image = global::Space_Invaders.Properties.Resources.Player;
            this.life1.Location = new System.Drawing.Point(34, 441);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(35, 20);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life1.TabIndex = 5;
            this.life1.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Space_Invaders.Properties.Resources.Player;
            this.player.Location = new System.Drawing.Point(224, 414);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 32);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.label5);
            this.MainMenu.Controls.Add(this.label2);
            this.MainMenu.Controls.Add(this.richTextBox1);
            this.MainMenu.Controls.Add(this.playButton);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(484, 461);
            this.MainMenu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(211, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Play";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(142, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Highscores";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGreen;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(185, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(89, 196);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // playButton
            // 
            this.playButton.Image = global::Space_Invaders.Properties.Resources.EnemyA2;
            this.playButton.Location = new System.Drawing.Point(185, 310);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(89, 80);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 0;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.Controls.Add(this.restartButton);
            this.gameOverPanel.Controls.Add(this.richTextBox2);
            this.gameOverPanel.Controls.Add(this.ExitButton);
            this.gameOverPanel.Controls.Add(this.label3);
            this.gameOverPanel.Controls.Add(this.label4);
            this.gameOverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverPanel.Enabled = false;
            this.gameOverPanel.Location = new System.Drawing.Point(0, 0);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(484, 461);
            this.gameOverPanel.TabIndex = 3;
            this.gameOverPanel.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(195, 348);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.LightGreen;
            this.richTextBox2.HideSelection = false;
            this.richTextBox2.Location = new System.Drawing.Point(185, 135);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(89, 196);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            this.richTextBox2.WordWrap = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(195, 388);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(152, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "GAME OVER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(153, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 1;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.gameOverPanel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Crusade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer BulletTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer EnemyMovement;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.Timer EnemyFire;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer EnemySpawn;
        private System.Windows.Forms.Timer DownALevel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer TimeLimit;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

