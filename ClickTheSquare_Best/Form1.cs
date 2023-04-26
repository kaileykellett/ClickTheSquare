using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTheSquare_Best
{
    enum cellTypes { blank = 0, redSquare = 1 }
    public partial class Form1 : Form
    {
        //set up a 10x10 grid
        Size gridSize = new Size(10, 10);

        //set the size of each cell (square to 40x40 pixels)
        Size cellSize = new Size(40, 40);

        //set a 2d array of only 1 or 0
        cellTypes[,] gameData;

        int timerTick = 1000;

        //for a point system, we will need labels, and to keep track of the points
        //to keep the points striaght, we'll make a variable for them
        //an int for this (no decimals)
        int points = 0;

        //set the color
        Color c = Color.Beige;

        //make a bool variable to get the game to 'pause'
        bool gamePaused = true;

        public Form1()
        {
            InitializeComponent();
            createGame();
            btnStart.Visible = true;
            btnStart.Enabled = true;
        }

        private void createGame()
        {
            //initialize the gameData 2d array to be 10x10
            gameData = new cellTypes[gridSize.Width, gridSize.Height];

            //draw the size of the client
            ClientSize = new Size(cellSize.Width * gridSize.Width, cellSize.Height * gridSize.Height + menuStrip1.Height + statusStrip1.Height);
        }

        //before anything else, we need to start the game
        private void StartGame()
        {
            //set the timer
            timerTick = 1000;
            timeSquare.Interval = timerTick;

            //game paused should be false, so everything runs
            gamePaused = false;

            //'get rid' of the start button
            btnStart.Visible = false;
            btnStart.Enabled = false;

            btnResume.Enabled = false;
            btnResume.Visible = false;

            //clear all cells
            ClearCells();

            //set the square to a random location
            randomLocation();
        }

        //this function will update the timer immediately, and somehow gtes rid of the 'double jump'
        private void updateTimer()
        {
            timeSquare.Interval = timerTick;
        }

        private void ClearCells()
        {
            if (gamePaused == false)
            {//make all cells clear
             //use a double for loop
                for (int i = 0; i < gridSize.Width; i++)
                {
                    for (int j = 0; j < gridSize.Height; j++)
                    {
                        gameData[i, j] = cellTypes.blank;
                    }
                }
            }
        }

        private void randomLocation()
        {
            if (gamePaused == false)
            {
                Random r = new Random();
                int xPos = r.Next(0, gridSize.Width);
                int yPos = r.Next(0, gridSize.Width);

                gameData[xPos, yPos] = cellTypes.redSquare;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //shifts graphics down by the height of the menu strip
            e.Graphics.TranslateTransform(0, menuStrip1.Height);

            //create a new pen
            Pen p = new Pen(Color.Black, 2);//2 pixel thickness

            //brush for filling in the square
            Brush b = new SolidBrush(c);

            //draw the grid lines
            for (int i = 0; i < gridSize.Width; i++)
            {
                //vertical lines
                e.Graphics.DrawLine(p, cellSize.Width * i, 0, cellSize.Width * i, ClientRectangle.Bottom);

                //horizontal lines
                e.Graphics.DrawLine(p, 0, cellSize.Height * i, ClientRectangle.Right, cellSize.Height * i);
            }

            if (gamePaused == false)
            {
                //find the 'red square' and fill it in (with brown)
                //check across the grid
                for (int i = 0; i < gridSize.Width; i++)
                {
                    //check the grid vertically
                    for (int j = 0; j < gridSize.Height; j++)
                    {
                        //is the current cell red?
                        if (gameData[i, j] == cellTypes.redSquare)
                        {
                            //make the square you want to be filled in now that the square has been found
                            Rectangle r = new Rectangle(i * cellSize.Width, j * cellSize.Height, cellSize.Width, cellSize.Height);

                            //fill the rectangle
                            e.Graphics.FillRectangle(b, r);
                        }

                    }
                }
            }

            //end of paint form
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //quit game
            Application.Exit();
        }

        private void randomLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCells();
            randomLocation();

            Invalidate();
        }

        //happens everytime the timer 'ticks'
        private void timeSquare_Tick(object sender, EventArgs e)
        {
            //do this only IF the game is not paused
            if (gamePaused == false)
            {
                ClearCells();
                randomLocation();
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //do this only IF the game is not paused
            if (gamePaused == false)
            {
                //which cell was clicked in any place?

                //mouse coordinates
                double mouseX = e.X;
                double mouseY = e.Y;

                //show coordinates of the mouse in bottom status strip
                tslMouseCoordinates.Text = "Mouse X : " + mouseX + ", Mouse Y: " + mouseY;

                //identify cells and display which was clicked
                int clickX = e.X / cellSize.Width;
                int clickY = (e.Y - menuStrip1.Height) / cellSize.Height;

                tslSquarePosition.Text = "Cell: " + clickX + ", " + clickY;

                //has the square ACTUALLY been clicked
                if (gameData[clickX, clickY] == cellTypes.redSquare)
                {
                    ClearCells();
                    randomLocation();
                    timerTick -= 50;
                    points++;
                    updateTimer();
                    Invalidate();
                }
                else //the square was NOT clicked, they missed
                {
                    points--;
                    Invalidate();
                }

                //display points
                tslPoints.Text = "Points: " + points * 100;

                Invalidate();
            }
        }

        //if the timer gets to be too fast, player can slow the game down
        private void slowItDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add time to the timer
            timerTick += 50;
            points--;
            tslPoints.Text = "Points: " + points * 100;
            //update the timer
            updateTimer();
            Invalidate();
        }

        //start the game over
        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void changeSquareColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialogSquare.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
                c = colorDialogSquare.Color;
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the square to earn as many points as you can in 1 minute! \n(Pretty self-explanatory, but some people don't get it so the instructions are here anyway...)");
            gamePaused = true;
        }

        private void GamePlaytimer_Tick(object sender, EventArgs e)
        {
            //when this timer ticks, we want the game to end
            //we will make a function for the end of the game
            endGame();
        }

        private void endGame()
        {
            if (gamePaused == false)
            {
                //when this function is called, we want the final score to be displayed, and the timers to pause
                //game paused should put a hold on the timers, but we also want the gameplay timer to be disabled 
                gamePaused = true;
                GamePlaytimer.Enabled = false;
                finalScore();
                //we will reset the color
                Color c = Color.Beige;
                //play again?
                DialogResult d = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    //if they clicked yes, we want to 'reset' the game
                    resetGame();
                }
                else
                {
                    Application.Exit();
                }
                Invalidate();
            }
        }

        //a function for when we want the game to 'reset' (eg. play again, etc.)
        private void resetGame()
        {
            ClearCells();
            gamePaused = true;
            GamePlaytimer.Enabled = false;
            int timerTick = 1000;
            updateTimer();
            points = 0;
            tslPoints.Text = "Points: " + points * 100;
            btnStart.Visible = true;
            btnStart.Enabled = true;
            btnResume.Enabled = false;
            btnResume.Visible = false;
        }

        private void finalScore()
        {
            //in this function, we will check if the player 'won' the game
            //if the points are negative, they obviously lost (more misses than hits, etc)
            if(points <= 0)
            {
                MessageBox.Show("Final Score: " + points * 100 + "\nBoo! You really suck at this game!");
            }
            else if(points > 5 && points < 10)
            {
                MessageBox.Show("Final Score: " + points * 100 + "\nRespectable! You had a pretty good game.");
            }
            else if(points >= 10)
            {
                MessageBox.Show("Final Score: " + points * 100 + "\n*is speechless* Um... wow. I think you're a pro at this. What are you doing here?");
            }
            else
            {
                MessageBox.Show("Final Score: " + points * 100 + "\nYou didn't lose, but you didn't exactly win either. Good try.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            GamePlaytimer.Enabled = true;
            StartGame();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GamePlaytimer.Enabled == true)
            {
                gamePaused = true;
                btnResume.Visible = true;
                btnResume.Enabled = true;
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            btnResume.Visible = false;
            btnResume.Enabled = false;
            gamePaused = false;
        }
    }
}
