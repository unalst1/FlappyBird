using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer(object sender, EventArgs e)
        {
            pictureBox_Bird.Top += gravity;
            pictureBox3.Left -= pipeSpeed;
            pictureBox2.Left -= pipeSpeed;
            label1.Text = "Score: " + score;

            if (pictureBox3.Left < -150)
            {
                pictureBox3.Left = 800;
                score++;
            }
            if (pictureBox2.Left < -180)
            {
                pictureBox2.Left = 950;
                score++;
            }
            if (pictureBox_Bird.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(pictureBox5.Bounds) || pictureBox_Bird.Top < -25)
            {
                EndGame();
            }
        }
            public void EndGame()
        {
            timer_GameConrtol.Stop();
            label1.Text = "GAME OVER!";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
    }

}
