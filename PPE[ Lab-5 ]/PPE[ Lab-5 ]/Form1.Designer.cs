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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(870, 12);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(106, 26);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score :";
            // 
            // GameOverlabel
            // 
            this.GameOverlabel.AutoSize = true;
            this.GameOverlabel.BackColor = System.Drawing.Color.Teal;
            this.GameOverlabel.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverlabel.Location = new System.Drawing.Point(178, 162);
            this.GameOverlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameOverlabel.Name = "GameOverlabel";
            this.GameOverlabel.Size = new System.Drawing.Size(43, 30);
            this.GameOverlabel.TabIndex = 2;
            this.GameOverlabel.Text = "...";
            this.GameOverlabel.Visible = false;
            // 
            // RulesLabel
            // 
            this.RulesLabel.AutoSize = true;
            this.RulesLabel.Location = new System.Drawing.Point(872, 151);
            this.RulesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RulesLabel.Name = "RulesLabel";
            this.RulesLabel.Size = new System.Drawing.Size(0, 17);
            this.RulesLabel.TabIndex = 3;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackgroundImage = global::PPE__Lab_5__.Properties.Resources.Menu;
            this.MenuPanel.Controls.Add(this.StartBtn);
            this.MenuPanel.Location = new System.Drawing.Point(-2, -3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1108, 490);
            this.MenuPanel.TabIndex = 4;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Ravie", 14.25F);
            this.StartBtn.Location = new System.Drawing.Point(394, 366);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(129, 52);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BackgroundImage = global::PPE__Lab_5__.Properties.Resources.grass1;
            this.Canvas.Location = new System.Drawing.Point(9, 5);
            this.Canvas.Margin = new System.Windows.Forms.Padding(4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(852, 473);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1101, 481);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.RulesLabel);
            this.Controls.Add(this.GameOverlabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Canvas);
            this.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1147, 524);
            this.MinimumSize = new System.Drawing.Size(1117, 520);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
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
    }
}

