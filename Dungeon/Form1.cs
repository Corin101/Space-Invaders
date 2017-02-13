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
        int enemySpeed = 20;

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;                           // start the timer (game)
            this.FormBorderStyle = FormBorderStyle.None;    // remove boarders
            this.TopMost = true;                            // bring frame to frnt
            this.Bounds = Screen.PrimaryScreen.Bounds;      // game in full screen
            randomGenerator = new Random();
            playerChar.Top = Screen.PrimaryScreen.Bounds.Height - playerChar.Height;
            playerChar.Left = Screen.PrimaryScreen.Bounds.Size.Width / 2 - playerChar.Width;
            EnemyInitalPosition();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (playerChar.Left > gamePanel.Left) { if (moveLeft == true) { playerChar.Left -= speed; } }
            if (playerChar.Right < gamePanel.Right) { if (moveRight == true) { playerChar.Left += speed; } }
            if (playerChar.Top > gamePanel.Top) {  if (moveUp == true) { playerChar.Top -= speed; } }
            if (playerChar.Bottom < gamePanel.Bottom) { if (moveDown == true) { playerChar.Top += speed; } }
            if (enemy01.Top >= 0 && enemy01.Top != Screen.PrimaryScreen.Bounds.Height)
            {
                enemy01.Top += enemySpeed;
                if (enemy01.Top > Screen.PrimaryScreen.Bounds.Height) { EnemyInitalPosition(); }
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


        private void EnemyInitalPosition()
        {
            enemy01.Top = 0;
            int randomNumber = randomGenerator.Next(0, Screen.PrimaryScreen.Bounds.Size.Width);
            enemy01.Left = randomNumber; 
        }
    }
}
