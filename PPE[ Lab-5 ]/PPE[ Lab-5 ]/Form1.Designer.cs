namespace PPE__Lab_5__
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.ScoreLabel = new System.Windows.Forms.Label();
			this.GameOverlabel = new System.Windows.Forms.Label();
			this.RulesLabel = new System.Windows.Forms.Label();
			this.MenuPanel = new System.Windows.Forms.Panel();
			this.StartBtn = new System.Windows.Forms.Button();
			this.LevelPanel = new System.Windows.Forms.Panel();
			this.HardLvlBtn = new System.Windows.Forms.Button();
			this.MediumLvlBtn = new System.Windows.Forms.Button();
			this.BasicLvlBtn = new System.Windows.Forms.Button();
			this.Canvas = new System.Windows.Forms.PictureBox();
			this.GamePanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
			this.GamePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// GamePanel
			// 
			this.GamePanel.BackColor = System.Drawing.Color.Transparent;
			this.GamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.GamePanel.Controls.Add(this.ScoreLabel);
			this.GamePanel.Controls.Add(this.GameOverlabel);
			this.GamePanel.Controls.Add(this.RulesLabel);
			this.GamePanel.Controls.Add(this.Canvas);
			this.GamePanel.Location = new System.Drawing.Point(0, 0);
			this.GamePanel.Margin = new System.Windows.Forms.Padding(0);
			this.GamePanel.Name = "GamePanel";
			this.GamePanel.Size = new System.Drawing.Size(1015, 506);
			this.GamePanel.TabIndex = 5;
			this.GamePanel.Visible = false;
			// 
			// ScoreLabel
			// 
			this.ScoreLabel.AutoSize = true;
			this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
			this.ScoreLabel.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScoreLabel.Location = new System.Drawing.Point(798, 12);
			this.ScoreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.ScoreLabel.Name = "ScoreLabel";
			this.ScoreLabel.Size = new System.Drawing.Size(107, 29);
			this.ScoreLabel.TabIndex = 1;
			this.ScoreLabel.Text = "Score :";
			// 
			// GameOverlabel
			// 
			this.GameOverlabel.AutoSize = true;
			this.GameOverlabel.BackColor = System.Drawing.Color.Transparent;
			this.GameOverlabel.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GameOverlabel.Location = new System.Drawing.Point(220, 200);
			this.GameOverlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.GameOverlabel.Name = "GameOverlabel";
			this.GameOverlabel.Size = new System.Drawing.Size(45, 33);
			this.GameOverlabel.TabIndex = 2;
			this.GameOverlabel.Text = "...";
			// 
			// RulesLabel
			// 
			this.RulesLabel.AutoSize = true;
			this.RulesLabel.BackColor = System.Drawing.Color.Transparent;
			this.RulesLabel.Location = new System.Drawing.Point(798, 159);
			this.RulesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.RulesLabel.Name = "RulesLabel";
			this.RulesLabel.Size = new System.Drawing.Size(0, 20);
			this.RulesLabel.TabIndex = 3;
			// 
			// Canvas
			// 
			this.Canvas.BackColor = System.Drawing.Color.Transparent;
			this.Canvas.BackgroundImage = global::PPE__Lab_5__.Properties.Resources.grass1;
			this.Canvas.Location = new System.Drawing.Point(8, 5);
			this.Canvas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.Canvas.Name = "Canvas";
			this.Canvas.Size = new System.Drawing.Size(781, 496);
			this.Canvas.TabIndex = 0;
			this.Canvas.TabStop = false;
			this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
			// 
			// MenuPanel
			// 
			this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
			this.MenuPanel.BackgroundImage = global::PPE__Lab_5__.Properties.Resources.Menu;
			this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MenuPanel.Controls.Add(this.GamePanel);
			this.MenuPanel.Controls.Add(this.StartBtn);
			this.MenuPanel.Location = new System.Drawing.Point(0, 0);
			this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
			this.MenuPanel.Name = "MenuPanel";
			this.MenuPanel.Size = new System.Drawing.Size(1015, 506);
			this.MenuPanel.TabIndex = 4;
			// 
			// StartBtn
			// 
			this.StartBtn.BackColor = System.Drawing.Color.DarkGreen;
			this.StartBtn.FlatAppearance.BorderSize = 0;
			this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartBtn.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartBtn.ForeColor = System.Drawing.Color.White;
			this.StartBtn.Location = new System.Drawing.Point(430, 408);
			this.StartBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(151, 80);
			this.StartBtn.TabIndex = 0;
			this.StartBtn.Text = "Start";
			this.StartBtn.UseVisualStyleBackColor = false;
			this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// LevelPanel
			// 
			this.LevelPanel.BackColor = System.Drawing.Color.Black;
			this.LevelPanel.Controls.Add(this.HardLvlBtn);
			this.LevelPanel.Controls.Add(this.MediumLvlBtn);
			this.LevelPanel.Controls.Add(this.BasicLvlBtn);
			this.LevelPanel.Location = new System.Drawing.Point(0, 0);
			this.LevelPanel.Margin = new System.Windows.Forms.Padding(0);
			this.LevelPanel.Name = "LevelPanel";
			this.LevelPanel.Size = new System.Drawing.Size(1015, 506);
			this.LevelPanel.TabIndex = 5;
			this.LevelPanel.Visible = false;
			// 
			// HardLvlBtn
			// 
			this.HardLvlBtn.BackColor = System.Drawing.Color.DarkGreen;
			this.HardLvlBtn.FlatAppearance.BorderSize = 0;
			this.HardLvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.HardLvlBtn.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HardLvlBtn.ForeColor = System.Drawing.Color.White;
			this.HardLvlBtn.Location = new System.Drawing.Point(432, 390);
			this.HardLvlBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.HardLvlBtn.Name = "HardLvlBtn";
			this.HardLvlBtn.Size = new System.Drawing.Size(151, 80);
			this.HardLvlBtn.TabIndex = 5;
			this.HardLvlBtn.Text = "Hard";
			this.HardLvlBtn.UseVisualStyleBackColor = false;
			this.HardLvlBtn.Click += new System.EventHandler(this.HardLvlBtn_Click);
			// 
			// MediumLvlBtn
			// 
			this.MediumLvlBtn.BackColor = System.Drawing.Color.DarkGreen;
			this.MediumLvlBtn.FlatAppearance.BorderSize = 0;
			this.MediumLvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MediumLvlBtn.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MediumLvlBtn.ForeColor = System.Drawing.Color.White;
			this.MediumLvlBtn.Location = new System.Drawing.Point(432, 220);
			this.MediumLvlBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MediumLvlBtn.Name = "MediumLvlBtn";
			this.MediumLvlBtn.Size = new System.Drawing.Size(151, 80);
			this.MediumLvlBtn.TabIndex = 4;
			this.MediumLvlBtn.Text = "Medium";
			this.MediumLvlBtn.UseVisualStyleBackColor = false;
			this.MediumLvlBtn.Click += new System.EventHandler(this.MediumLvlBtn_Click);
			// 
			// BasicLvlBtn
			// 
			this.BasicLvlBtn.BackColor = System.Drawing.Color.DarkGreen;
			this.BasicLvlBtn.FlatAppearance.BorderSize = 0;
			this.BasicLvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BasicLvlBtn.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BasicLvlBtn.ForeColor = System.Drawing.Color.White;
			this.BasicLvlBtn.Location = new System.Drawing.Point(432, 37);
			this.BasicLvlBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BasicLvlBtn.Name = "BasicLvlBtn";
			this.BasicLvlBtn.Size = new System.Drawing.Size(151, 80);
			this.BasicLvlBtn.TabIndex = 3;
			this.BasicLvlBtn.Text = "Basic";
			this.BasicLvlBtn.UseVisualStyleBackColor = false;
			this.BasicLvlBtn.Click += new System.EventHandler(this.BasicLvlBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1006, 496);
			this.Controls.Add(this.MenuPanel);
			this.Controls.Add(this.LevelPanel);
			this.Controls.Add(this.GamePanel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1053, 551);
			this.MinimumSize = new System.Drawing.Size(1024, 543);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snake";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.MenuPanel.ResumeLayout(false);
			this.LevelPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
			this.GamePanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label GameOverlabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label RulesLabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.Panel LevelPanel;
		private System.Windows.Forms.Button HardLvlBtn;
		private System.Windows.Forms.Button MediumLvlBtn;
		private System.Windows.Forms.Button BasicLvlBtn;
		private System.Windows.Forms.Panel GamePanel;
		private System.Windows.Forms.Button button1;
	}
}

