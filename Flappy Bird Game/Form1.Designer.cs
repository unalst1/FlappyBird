namespace flappy_bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox_Bird = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            timer_GameConrtol = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Bird
            // 
            pictureBox_Bird.BackColor = Color.Transparent;
            pictureBox_Bird.Image = Properties.Resources.bird;
            pictureBox_Bird.Location = new Point(56, 213);
            pictureBox_Bird.Name = "pictureBox_Bird";
            pictureBox_Bird.Size = new Size(95, 76);
            pictureBox_Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Bird.TabIndex = 0;
            pictureBox_Bird.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.pipedown;
            pictureBox2.Location = new Point(687, -22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 311);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.pipe;
            pictureBox3.Location = new Point(518, 627);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(132, 257);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(152, 60);
            label1.TabIndex = 4;
            label1.Text = "Score:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.ground;
            pictureBox5.Location = new Point(-1, 870);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1022, 191);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // timer_GameConrtol
            // 
            timer_GameConrtol.Enabled = true;
            timer_GameConrtol.Interval = 20;
            timer_GameConrtol.Tick += gameTimer;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            BackgroundImage = Properties.Resources.dasdsad;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 1002);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox_Bird);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += game_Down;
            KeyUp += game_Up;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Bird;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer_GameConrtol;
    }
}
