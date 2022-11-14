using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Space_Invaders
{

    public partial class Form1 : Form
    {
        private class Enemy
        {
            public PictureBox enemyPic;
            public Enemy(Panel p)
            {
                var Random = new Random();
                int rnd = Random.Next(-2, 2);
                enemyPic = new PictureBox();
                enemyPic.Image = global::Space_Invaders.Properties.Resources.EnemyA1;
                enemyPic.Location = new System.Drawing.Point(224 + rnd * 32, -2); //random starting x
                enemyPic.Name = "enemy";
                enemyPic.Size = new System.Drawing.Size(32, 32);
                enemyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                enemyPic.TabIndex = 1;
                enemyPic.TabStop = false;
                enemyPic.Tag = "";
                p.Controls.Add(enemyPic);
            }

            public void enemyMove(int tmp)
            {
                int x = enemyPic.Location.X;
                int y = enemyPic.Location.Y;


                int newX = x + tmp * 32; // move on the 32 pixel grid
                if (newX >= 0 && newX <= 448)
                    enemyPic.Location = new Point(x + tmp * 32, y);
            }

            public void enemyFire(Form1 f, Panel p)
            {
                PictureBox ebullet = new PictureBox();
                ebullet.Location = new Point(enemyPic.Location.X, enemyPic.Location.Y + 8);
                ebullet.Size = new Size(32, 32);
                ebullet.Image = global::Space_Invaders.Properties.Resources.EBullet;
                ebullet.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(ebullet);
                f.EBullets.Add(ebullet);
            }

            public Boolean enemyHit(Form1 f, PictureBox bullet)
            {
                if (bullet.Location.X.Equals(enemyPic.Location.X) && bullet.Location.Y.Equals(enemyPic.Location.Y))
                {
                    SoundPlayer edeathSound = new SoundPlayer("../../assets/sounds/invaderkilled.wav");
                    edeathSound.Play();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            ~Enemy()
            {

            }
        }

        IFormatter forma = new BinaryFormatter(); //(De)Serialize
        private int points = 0, lives = 3, timeLeft = 180, count = 1; //Count used in highscores for indication
        private List<int> Highscores = new List<int>(10);
        private List<Enemy> Enemies = new List<Enemy>();
        private List<PictureBox> Bullets = new List<PictureBox>();
        private List<PictureBox> EBullets = new List<PictureBox>(); //Enemy Bullets

        public Form1()
        {
            InitializeComponent();
            
            try
            {
                using (Stream stream = File.Open("./HighScores.txt", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Highscores = (List<int>)bin.Deserialize(stream);
                    Highscores.Reverse();
                    foreach(int highscore in Highscores)
                    {
                        richTextBox1.Text += count++ + ") " + highscore.ToString() + "\n";
                    }

                    
                }
            }
            catch (IOException){}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = player.Location.X;
            int y = player.Location.Y;
            PlayerMove(x, y, e); //wasd movement
            PlayerFire(x, y, e);

        }

        private void PlayerMove(int x, int y, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Left):
                    if (x > 0)
                        player.Location = new Point(player.Location.X - 32, player.Location.Y);
                    break;
                case (Keys.Right):
                    if (x < 448)
                        player.Location = new Point(player.Location.X + 32, player.Location.Y);
                    break;
                case (Keys.Up):
                    if (y > -2)
                        player.Location = new Point(player.Location.X, player.Location.Y - 32);
                    break;
                case (Keys.Down):
                    if (y < 414)
                        player.Location = new Point(player.Location.X, player.Location.Y + 32);
                    break;

            }
        }

        private void PlayerFire(int x, int y, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gamePanel.Visible == true && Bullets.Count <= 2) //Create bullet only 3 bullets active at a time
            {

                SoundPlayer fireSound = new SoundPlayer("../../assets/sounds/shoot.wav");
                fireSound.Play();
                PictureBox bullet = new PictureBox();
                bullet.Location = new Point(x, y - 8);
                bullet.Size = new Size(32, 32);
                bullet.Image = global::Space_Invaders.Properties.Resources.Bullet;
                bullet.SizeMode = PictureBoxSizeMode.StretchImage;
                gamePanel.Controls.Add(bullet);
                Bullets.Add(bullet);

            }
        }

        private void Bullet_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < Bullets.Count; i++)//Traditional for so as to be able to remove elements form Bullets list on runtime
            {
                Bullets[i].Location = new Point(Bullets[i].Location.X, Bullets[i].Location.Y - 8);
                OnEnemyHit(Bullets[i]);
                if (Bullets[i].Location.Y < -2)
                {
                    Bullets[i].Dispose();
                    Bullets.Remove(Bullets[i]);
                }
                
            }

            foreach (PictureBox ebullet in EBullets)
            {
                ebullet.Location = new Point(ebullet.Location.X, ebullet.Location.Y + 8);
                if (ebullet.Location.Y > 414) ebullet.Dispose();
                OnPlayerHit(ebullet);
            }
        }

        private void EnemyMovement_Tick(object sender, EventArgs e)
        {
            var random = new Random();
            foreach (Enemy enemy in Enemies)
            {
                int tmp = random.Next(-6, 6);
                enemy.enemyMove(tmp);
            }

        }

        private void EnemyFire_Tick(object sender, EventArgs e)
        {
            var random = new Random();
            foreach (Enemy enemy in Enemies)
            {
                int rnd = random.Next(0, 2); //Flips a coin if 1 then fire
                if (rnd == 1)
                    enemy.enemyFire(this,gamePanel);
            }

        }

        private void EnemySpawn_Tick(object sender, EventArgs e)
        {
            Enemy enemy = new Enemy(gamePanel);
            Enemies.Add(enemy);
            //EnemySpawn.Enabled = false;
        }

        //Sets all existing enemies 32 pixels down
        private void DownALevel_Tick(object sender, EventArgs e)
        {
            foreach (Enemy enemy in Enemies)
            {
                int x = enemy.enemyPic.Location.X;
                int y = enemy.enemyPic.Location.Y + 32;
                if (enemy.enemyPic.Location.Y < 414)
                {
                    enemy.enemyPic.Location = new Point(x, y);
                }
                else //if enemy reaches ground it's gameover
                {
                    GameOver();
                    label1.Text = "g";
                }
            }
        }

        private void OnEnemyHit(PictureBox bullet)
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                if (Enemies[i].enemyHit(this, bullet))
                {
                    points += 10;
                    Enemies[i].enemyPic.Dispose(); //Delete image and then remove (destroy) enemy from the list
                    Enemies.Remove(Enemies[i]);
                    score.Text = points.ToString();
                }
            }      
        }

        private void OnPlayerHit(PictureBox ebullet)
        {
            if (ebullet.Location.X.Equals(player.Location.X) && ebullet.Location.Y.Equals(player.Location.Y))
            {
                SoundPlayer deathSound = new SoundPlayer("../../assets/sounds/explosion.wav");
                deathSound.Play();
                switch (lives) //remove each life picturebox from screen
                {
                    case (3):
                        life3.Dispose();
                        break;
                    case (2):
                        life2.Dispose();
                        break;
                    case (1):
                        life1.Dispose();
                        break;
                }
                lives--;
                ebullet.Dispose(); //Delete the bullet after hit
                if (lives == 0) //label1.Text = "Game Over"
                    GameOver();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null; //Removes focus from richTextbox so no beep sound occurs when a key is pressed
            MainMenu.Enabled = false;
            MainMenu.Visible = false;
            gamePanel.Visible = true;
            gamePanel.Enabled = true;
            List<Timer> Timers = new List<Timer>() { BulletTimer,
                EnemyFire,
                EnemyMovement,
                EnemySpawn,
                DownALevel,
                TimeLimit};
            foreach (Timer timer in Timers)
                timer.Enabled = true;

        }

        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = timeLeft--.ToString();
            if(timeLeft == 0)
            {
                GameOver();
                TimeLimit.Enabled = false;
            }
        }

        private void GameOver()
        {
            List<Timer> Timers = new List<Timer>() { BulletTimer,
                EnemyFire,
                EnemyMovement,
                EnemySpawn,
                DownALevel,
                TimeLimit};
            foreach (Timer timer in Timers)
                timer.Stop();

            gamePanel.Controls.Clear();
            gamePanel.Visible = false;
            gameOverPanel.Enabled = true;
            gameOverPanel.Visible = true;
            int newScore = Int16.Parse(score.Text);
            Highscores.Sort();
            if (Highscores.Count != 10)
            {
                Highscores.Add(newScore);
                label4.Text = "Highscore added " + newScore;
            }
            else
            { 
                if (Highscores[0] < newScore)
                {
                    Highscores[0] = newScore;
                    label4.Text = "New Highscore! " + newScore; //at gameover screen
                }    
            }
            Highscores.Sort();
            Highscores.Reverse();
            count = 1;
            Boolean found = false;
            foreach (int highscore in Highscores)
            {
                
                if(highscore == newScore && !found)
                {
                    richTextBox2.Text += count++ + ") " + highscore.ToString() + "<-" + "\n";
                    found = true;
                }
                else
                {
                    richTextBox2.Text += count++ + ") " + highscore.ToString() + "\n";
                }
            }
            Highscores.Reverse();
            try
            {
                using (Stream stream = File.Open("./HighScores.txt", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Highscores);
                }
            }
            catch (IOException){}
            
        }

    }
}