using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private int maxWidth;
        private int maxHeight;
        private int snakeSizeTarget;
        bool goLeft, goRight, goDown, goUp;

        public Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Snap_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game SnapShot MOO ICT";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }

        }

        private void InitializeGameSettings(int fieldSize, int snakeSize)
        {
            picCanvas.Size = new Size(fieldSize, fieldSize-100);
            snakeSizeTarget = snakeSize;
        }

        private void smallField_btn_Click(object sender, EventArgs e)
        {
            InitializeGameSettings(200, snakeSizeTarget);
        }

        private void middleField_btn_Click(object sender, EventArgs e)
        {
            InitializeGameSettings(350, snakeSizeTarget);
        }

        private void bigField_btn_Click(object sender, EventArgs e)
        {
            InitializeGameSettings(450, snakeSizeTarget);
        }

        private void smallSnake_btn_Click(object sender, EventArgs e)
        {
            snakeSizeTarget = 20;
        }

        private void middleSnake_btn_Click(object sender, EventArgs e)
        {
            snakeSizeTarget = 40;
        }

        private void bigSnake_btn_Click(object sender, EventArgs e)
        {
            snakeSizeTarget = 50;
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }

            CheckForCollision();

            if (gameTimer.Enabled)
            {
                MoveSnake();
            }
            picCanvas.Invalidate();

        }

        private void MoveSnake()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }

        }

        private void GrowTimerEvent(object sender, EventArgs e)
        {
            IncreaseSize();
            UpdateProgressBar();
        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width-1;
            maxHeight = picCanvas.Height / Settings.Height-1;

            progressBar1.Maximum = snakeSizeTarget;

            Snake.Clear();

            Play_btn.Enabled = false;
            Snap_btn.Enabled = false;
            smallField_btn.Enabled = false;
            middleField_btn.Enabled = false;
            bigField_btn.Enabled = false;
            smallSnake_btn.Enabled = false;
            middleSnake_btn.Enabled = false;
            bigSnake_btn.Enabled = false;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            gameTimer.Start();
            growTimer.Start();

        }

        private void IncreaseSize()
        {
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

        }

        private void UpdateProgressBar()
        {
            progressBar1.Value = Math.Min(progressBar1.Maximum, Snake.Count - 10);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                YouWin();
            }
        }

        private void StopGame()
        {
            gameTimer.Stop();
            growTimer.Stop();
            Play_btn.Enabled = true;
            Snap_btn.Enabled = true;
            smallField_btn.Enabled = true;
            middleField_btn.Enabled = true;
            bigField_btn.Enabled = true;
            smallSnake_btn.Enabled = true;
            middleSnake_btn.Enabled = true;
            bigSnake_btn.Enabled = true;
        }

        private void YouWin()
        {
            StopGame();
            MessageBox.Show("You Win!");
        }

        private void GameOver()
        {
            StopGame();
            MessageBox.Show("Game Over!");
        }

        private void CheckForCollision()
        {
            // Check if snake hits the borders
            if (Snake[0].X <= 0 || Snake[0].X >= maxWidth || Snake[0].Y <= 0 || Snake[0].Y >= maxHeight)
            {
                GameOver();
            }


            // Check if snake hits itself
            for (int i = 1; i < Snake.Count; i++)
            {
                if (Snake[0].X == Snake[i].X && Snake[0].Y == Snake[i].Y)
                {
                    GameOver();
                }
            }
        }
    }
}
