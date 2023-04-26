namespace ClickTheSquare_Best
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMeanImALittleOffendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alrightIGetItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodbyeMyLoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowItDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSquareColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslMouseCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSquarePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeSquare = new System.Windows.Forms.Timer(this.components);
            this.colorDialogSquare = new System.Windows.Forms.ColorDialog();
            this.GamePlaytimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.randomLocationToolStripMenuItem,
            this.slowItDownToolStripMenuItem,
            this.resetGameToolStripMenuItem,
            this.changeSquareColorToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reallyToolStripMenuItem,
            this.iMeanImALittleOffendedToolStripMenuItem,
            this.alrightIGetItToolStripMenuItem,
            this.goodbyeMyLoveToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // reallyToolStripMenuItem
            // 
            this.reallyToolStripMenuItem.Name = "reallyToolStripMenuItem";
            this.reallyToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.reallyToolStripMenuItem.Text = "Really?";
            // 
            // iMeanImALittleOffendedToolStripMenuItem
            // 
            this.iMeanImALittleOffendedToolStripMenuItem.Name = "iMeanImALittleOffendedToolStripMenuItem";
            this.iMeanImALittleOffendedToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.iMeanImALittleOffendedToolStripMenuItem.Text = "I mean, I\'m a little offended";
            // 
            // alrightIGetItToolStripMenuItem
            // 
            this.alrightIGetItToolStripMenuItem.Name = "alrightIGetItToolStripMenuItem";
            this.alrightIGetItToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.alrightIGetItToolStripMenuItem.Text = "Alright, I get it";
            // 
            // goodbyeMyLoveToolStripMenuItem
            // 
            this.goodbyeMyLoveToolStripMenuItem.Name = "goodbyeMyLoveToolStripMenuItem";
            this.goodbyeMyLoveToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.goodbyeMyLoveToolStripMenuItem.Text = "Goodbye my love";
            // 
            // randomLocationToolStripMenuItem
            // 
            this.randomLocationToolStripMenuItem.Name = "randomLocationToolStripMenuItem";
            this.randomLocationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.randomLocationToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.randomLocationToolStripMenuItem.Text = "&Random Location";
            this.randomLocationToolStripMenuItem.Click += new System.EventHandler(this.randomLocationToolStripMenuItem_Click);
            // 
            // slowItDownToolStripMenuItem
            // 
            this.slowItDownToolStripMenuItem.Name = "slowItDownToolStripMenuItem";
            this.slowItDownToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.slowItDownToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.slowItDownToolStripMenuItem.Text = "&Slow It Down!";
            this.slowItDownToolStripMenuItem.Click += new System.EventHandler(this.slowItDownToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.resetGameToolStripMenuItem.Text = "&Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // changeSquareColorToolStripMenuItem
            // 
            this.changeSquareColorToolStripMenuItem.Name = "changeSquareColorToolStripMenuItem";
            this.changeSquareColorToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.changeSquareColorToolStripMenuItem.Text = "Change Square Color";
            this.changeSquareColorToolStripMenuItem.Click += new System.EventHandler(this.changeSquareColorToolStripMenuItem_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.NumPad8)));
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMouseCoordinates,
            this.tslSquarePosition,
            this.tslPoints});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslMouseCoordinates
            // 
            this.tslMouseCoordinates.BackColor = System.Drawing.Color.White;
            this.tslMouseCoordinates.Name = "tslMouseCoordinates";
            this.tslMouseCoordinates.Size = new System.Drawing.Size(110, 17);
            this.tslMouseCoordinates.Text = "Mouse Coordinates";
            // 
            // tslSquarePosition
            // 
            this.tslSquarePosition.BackColor = System.Drawing.Color.White;
            this.tslSquarePosition.Name = "tslSquarePosition";
            this.tslSquarePosition.Size = new System.Drawing.Size(110, 17);
            this.tslSquarePosition.Text = "Square Coordinates";
            // 
            // tslPoints
            // 
            this.tslPoints.BackColor = System.Drawing.Color.White;
            this.tslPoints.Name = "tslPoints";
            this.tslPoints.Size = new System.Drawing.Size(46, 17);
            this.tslPoints.Text = "Points: ";
            // 
            // timeSquare
            // 
            this.timeSquare.Enabled = true;
            this.timeSquare.Interval = 500;
            this.timeSquare.Tick += new System.EventHandler(this.timeSquare_Tick);
            // 
            // GamePlaytimer
            // 
            this.GamePlaytimer.Interval = 60000;
            this.GamePlaytimer.Tick += new System.EventHandler(this.GamePlaytimer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(154, 192);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 51);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Black;
            this.btnResume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResume.Location = new System.Drawing.Point(154, 192);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(86, 51);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(400, 449);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whack the Square";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel tslMouseCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel tslSquarePosition;
        private System.Windows.Forms.ToolStripMenuItem randomLocationToolStripMenuItem;
        private System.Windows.Forms.Timer timeSquare;
        private System.Windows.Forms.ToolStripMenuItem slowItDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tslPoints;
        private System.Windows.Forms.ToolStripMenuItem reallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMeanImALittleOffendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alrightIGetItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodbyeMyLoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSquareColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogSquare;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Timer GamePlaytimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResume;
    }
}

