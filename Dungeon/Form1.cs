using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon
{
    public partial class Form1 : Form
    {
        private bool moveRight;
        private bool moveLeft;
        private bool moveUp;
        private bool moveDown;
        private Random randomGenerator;
        int speed = 5;
        int[] enemySpeed = {0,10,20,13,15,7,25};
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;                           // start the timer (game)
            this.FormBorderStyle = FormBorderStyle.None;    // remove boarders
            this.TopMost = true;                            // bring frame to frnt
            this.Bounds = Screen.PrimaryScreen.Bounds;      // game in full screen
            Cursor.Hide();
            randomGenerator = new Random();
            playerChar.Top = Screen.PrimaryScreen.Bounds.Height - playerChar.Height;
            playerChar.Left = Screen.PrimaryScreen.Bounds.Size.Width / 2 - playerChar.Width;
            scoreLabel.Top = Screen.PrimaryScreen.Bounds.Height / 30;
            scoreLabel.Left = Screen.PrimaryScreen.Bounds.Width / 30;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (playerChar.Left > gamePanel.Left) { if (moveLeft == true) { playerChar.Left -= speed; } }
            if (playerChar.Right < gamePanel.Right) { if (moveRight == true) { playerChar.Left += speed; } }
            if (playerChar.Top > gamePanel.Top) {  if (moveUp == true) { playerChar.Top -= speed; } }
            if (playerChar.Bottom < gamePanel.Bottom) { if (moveDown == true) { playerChar.Top += speed; } }

            EnemyMove(enemy01, 1);
            EnemyMove(enemy02, 2);
            EnemyMove(enemy03, 3);
            scoreLabel.Text = "Score:: " + score;
        }

        private void EnemyMove(PictureBox enemy, int position)
        {
            if (enemy.Top >= 0 && enemy.Top <= Screen.PrimaryScreen.Bounds.Height)
            {
                enemy.Top += enemySpeed[position];
                if (enemy.Top > Screen.PrimaryScreen.Bounds.Height) { EnemyInitalTopPosition(enemy, position); score++; }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MovePlayer(sender, e, 15, true);
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MovePlayer(sender, e, 5, false);
        }

        private void MovePlayer(object sender, KeyEventArgs e, int currentSpeed, bool choice)
        {
            if (e.KeyCode == Keys.ShiftKey) { speed = currentSpeed; }
            if (e.KeyCode == Keys.Right) { moveRight = choice; }
            if (e.KeyCode == Keys.Left) { moveLeft = choice; }
            if (e.KeyCode == Keys.Up) { moveUp = choice; }
            if (e.KeyCode == Keys.Down) { moveDown = choice; }
        }


        private void EnemyInitalTopPosition(PictureBox enemy, int position)
        {
            enemy.Top = 0;
            enemySpeed[position] = randomGenerator.Next(5, 25);
            enemy.Left = randomGenerator.Next(1, Screen.PrimaryScreen.Bounds.Size.Width);
        }
    }
}
