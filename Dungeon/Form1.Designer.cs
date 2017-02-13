namespace Dungeon
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.playerChar = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.enemy01 = new System.Windows.Forms.PictureBox();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy01)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.enemy01);
            this.gamePanel.Controls.Add(this.playerChar);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1313, 766);
            this.gamePanel.TabIndex = 0;
            // 
            // playerChar
            // 
            this.playerChar.BackColor = System.Drawing.Color.Maroon;
            this.playerChar.Location = new System.Drawing.Point(369, 472);
            this.playerChar.Name = "playerChar";
            this.playerChar.Size = new System.Drawing.Size(90, 96);
            this.playerChar.TabIndex = 0;
            this.playerChar.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // enemy01
            // 
            this.enemy01.BackColor = System.Drawing.Color.Red;
            this.enemy01.Location = new System.Drawing.Point(690, 238);
            this.enemy01.Name = "enemy01";
            this.enemy01.Size = new System.Drawing.Size(20, 50);
            this.enemy01.TabIndex = 1;
            this.enemy01.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1313, 766);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Dungeon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox playerChar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox enemy01;
    }
}

