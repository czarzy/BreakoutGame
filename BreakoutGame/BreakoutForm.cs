using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BreakoutGame
{
    public partial class BreakoutForm : Form
    {
        //game default variables
        SoundPlayer startSound = new SoundPlayer(BreakoutGame.Properties.Resources.start);
        SoundPlayer quitSound = new SoundPlayer(Properties.Resources.quit);
        SoundPlayer paddleTouchSound = new SoundPlayer(Properties.Resources.paddle_touch);
        SoundPlayer countdownSound = new SoundPlayer(Properties.Resources.countdown);
        SoundPlayer hit1Sound = new SoundPlayer(Properties.Resources.Hit1);
        SoundPlayer speedSound = new SoundPlayer(Properties.Resources.speed);
        Timer gameTimer = new Timer();
        Random rand = new Random();
        int paddleSpeed = 30;
        bool gamePaused = true;
        int score = 0;

        //Ball variables
        int ballSpeed = 5;
        int ballDX = 1;
        int ballDY = 1;

        //Block variables
        Image[,] Blocks;
        int blocksRows;
        int blocksCol;
        int blocksCount= 0;

        private bool IsPaused()
        {
            return gamePaused;
        }

        private void PauseGame(bool Pause = true)
        {
            ShowMenu(Pause);
            gameTimer.Enabled = !Pause;
            gamePaused = Pause;
            btnResme.Enabled = Pause;
        }
        private void ShowMenu(bool Show = true)
        {
            pnlMenu.Visible = Show;
            Invalidate();
        }

        public BreakoutForm()
        {
            InitializeComponent();
        }

        //Blocks with images
        private int BuildBlocks(int rows, int cols)
        {
            blocksRows = rows;
            blocksCol = cols;

            Blocks = new Image[rows, cols];

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    int index = rand.Next(0, imageList1.Images.Count);
                    Blocks[i, j] = imageList1.Images[index];
                    Blocks[i, j].Tag = index;
                }
            return rows * cols;
        }

        private void MovePaddle(int newXPos)
        {
            if (newXPos < 0)
                newXPos = 0;
            else if (newXPos > ClientRectangle.Width - picPaddle.Width)
                newXPos = ClientRectangle.Width - picPaddle.Width;
            picPaddle.Left = newXPos;
        }

        private void BreakoutForm_Load(object sender, EventArgs e)
        {
            //center game paddle
            MovePaddle((ClientRectangle.Width - picPaddle.Width) / 2);
            //center ball
            picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
            picBall.Top = 250;
            //game timer
            gameTimer.Interval = 1;
            gameTimer.Tick += GameTimer_Tick;
            //blocks
            blocksCount = BuildBlocks(rand.Next(3, 5), imageList1.Images.Count);

            //game will start paused
            PauseGame(true);
            //return disabled when starting game
            btnResme.Enabled = false;
            //play sound
            startSound.Play();
        }
        private void ShowGameOver(string text = "Game Over")
        {
            lblGameOver.Text = text;
            lblGameOver.Left = (ClientRectangle.Width - lblGameOver.Width) / 2;
            lblGameOver.Top = 60;
            lblGameOver.Visible = true;
            gameTimer.Enabled = false;
            quitSound.Play();
            for (int i = 0; i < 10; ++i)
            {
                lblGameOver.Top += 20;
                Application.DoEvents();
                System.Threading.Thread.Sleep(30);
            }
            System.Threading.Thread.Sleep(3000);
            lblGameOver.Visible = false;
            PauseGame(true);
            btnResme.Enabled = false;

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //ball movement
            Point pt = picBall.Location;

            pt.X += ballSpeed * ballDX;
            pt.Y += ballSpeed * ballDY;
            picBall.Location = pt;
            if (pt.X < 0 || pt.X > ClientRectangle.Width - picBall.Width)
                ballDX = -ballDX;
            if (pt.Y < 0)
                ballDY = -ballDY;
            //game over
            if (pt.Y > ClientRectangle.Height)
            {
                ShowGameOver();
            }

            //collision detect with paddle
            if(picBall.Bounds.IntersectsWith(picPaddle.Bounds))
            {
                paddleTouchSound.Play();
                ballDY = -ballDY;
            }
            //collision detect between ball/blocks
            //first select all ball corners
            Point[] pts = new Point[]
            {
                new Point (pt.X, pt.Y),
                new Point (pt.X + picBall.Width, pt.Y),
                new Point (pt.X, pt.Y + picBall.Height),
                new Point (pt.X + picBall.Width, pt.Y + picBall.Height)
            };
            //then interact with blocks
            int ballHitCount = 0;
            foreach (Point ptBall in pts)
            {
                int imgWidth = imageList1.ImageSize.Width;
                int imgHeight = imageList1.ImageSize.Height;
                int xpos = xpos = (ClientRectangle.Width - imgWidth * blocksCol) / 2;
                int ypos = 70;
                int row = pt.Y - ypos;
                int col = pt.X - xpos;
                col /= imgWidth;
                row /= imgHeight;

                if (col >= 0 && col < blocksCol && row >= 0 && row < blocksRows)
                {
                    if (Blocks[row, col] != null)
                    {
                        if ((int)Blocks[row, col].Tag == 0)
                        {
                            //stone block incrase ball speed
                            ballSpeed += 1;
                            score += 5;
                            if (ballHitCount == 0)
                                speedSound.Play();
                        }
                        else if (ballHitCount == 0)
                            hit1Sound.Play();
                        Blocks[row, col] = null;
                        Rectangle rc = new Rectangle(xpos + col * imgWidth, ypos + row * imgHeight, imgWidth, imgHeight);
                        Invalidate(rc);
                        ++ballHitCount;
                    }
                }
            }
            //if we have hit then ball will return
            if (ballHitCount > 0)
            {
                ballDY = -ballDY;

                score += ballHitCount;
                lblScore.Text = score.ToString("D5");

                blocksCount -= ballHitCount;
                if (blocksCount <= 0)
                {
                    //level completed
                    ShowGameOver("Level Completed!");
                }
            }

        }

        private void BreakoutForm_MouseMove(object sender, MouseEventArgs e)
        {
            //if game is paused paddle movement is blocked
            if (IsPaused())
                return;
            //paddle will move with mouse
            MovePaddle(e.X);
        }

        private void BreakoutForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //if game menu is on the screen don't show blocks
            if (pnlMenu.Visible)
                return;

            int xpos;
            int ypos = 70;
            int imgWidth = imageList1.ImageSize.Width;
            int imgHeighth = imageList1.ImageSize.Height;
            for (int i = 0; i < blocksRows; ++i)
            {
                xpos = (ClientRectangle.Width - imgWidth * blocksCol) / 2;
                for (int j = 0; j < blocksCol; ++j)
                {
                    if (Blocks[i, j] != null)
                        g.DrawImage(Blocks[i, j], xpos, ypos);
                    xpos += imgWidth;
                }
                ypos += imgHeighth;
            }    
        }

        private void BreakoutForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    //pause
                    ShowMenu(!pnlMenu.Visible);
                    if(!IsPaused())
                        PauseGame();
                    break;
                case Keys.Q:
                    //quit
                    Close();
                    break;
                case Keys.Left:
                    //move paddle left
                    if (!IsPaused())
                        MovePaddle(picPaddle.Left - paddleSpeed);
                    break;
                case Keys.Right:
                    if (!IsPaused())
                        MovePaddle(picPaddle.Left + paddleSpeed);
                    break;
                    
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //reset ball speed in new game
            ballSpeed = 5;
            //score = 0
            score = 0;
            lblScore.Text = score.ToString("D5");
            //center game paddle
            MovePaddle((ClientRectangle.Width - picPaddle.Width) / 2);
            //center ball
            picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
            picBall.Top = 250;
            //blocks
            blocksCount = BuildBlocks(rand.Next(3, 8), imageList1.Images.Count);
            //countdown
            lblCountdown.Text = "3";
            lblCountdown.Visible = true;
            ShowMenu(false);
            for (int i = 3; i > 0; --i)
            {
                lblCountdown.Text = i.ToString();
                Application.DoEvents();
                countdownSound.Play();
                System.Threading.Thread.Sleep(1000);
            }
            lblCountdown.Visible = false;
            //game will start paused
            PauseGame(false);
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            quitSound.Play();
            this.Close();
        }

        private void btnResme_Click(object sender, EventArgs e)
        {
            PauseGame(false);
        }

    }
}
