// This program makes it so that the perimeter of the cars can't touch. Despite being transparent spaces, the cars are stopped at each other's invisible sqaure shape.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade10FinalProject
{
    public partial class frmRelayRace : Form
    {
        int player1CarTop = 0;
        int player1CarBottom = 0;
        int player1CarLeft = 0;
        int player1CarRight = 0;
        int player1CarWidth = 0;
        int player1CarHeight = 0;
        int player1CarDirection = 0;

        //int player2CarTop = 0;
        //int player2CarBottom = 0;
        //int player2CarLeft = 0;
        //int player2CarRight = 0;
        //int player2CarWidth = 0;
        //int player2CarHeight = 0;
        //int player2CarDirection = 0;

        int coin1Top = 0;
        int coin1Bottom = 0;
        int coin1Left = 0;
        int coin1Right = 0;
        int coin1Width = 0;
        int coin1Height = 0;
        int coin1Direction = 0;

        int wall1Top = 0;
        int wall1Bottom = 0;
        int wall1Left = 0;
        int wall1Right = 0;
        int wall1Width = 0;
        int wall1Height = 0;
        int wall1Direction = 0;

        // Global Constants
        const int KEY_ESCAPE = 27;
        const int KEY_UP = 38;
        const int KEY_DOWN = 40;
        const int KEY_LEFT = 37;
        const int KEY_RIGHT = 39;
        const int MOVE_UP = 3;
        const int MOVE_DOWN = 4;
        const int MOVE_LEFT = 1;
        const int MOVE_RIGHT = 2;

        private int X = 50;
        //private int Y = 50;
        public frmRelayRace()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void frmRelayRace_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            if (picPlayer1Car.Capture == true) MessageBox.Show("That's a car!");

        }
        private void picCar_Click(object sender, EventArgs e)
        {

        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            //X += 10;
            //Y += 10;
            //picCar2.Top = Y;
            //Invalidate();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if (key == KEY_ESCAPE) Application.Exit();
            else if (key == KEY_UP) player1CarDirection = MOVE_UP;
            else if (key == KEY_DOWN) player1CarDirection = MOVE_DOWN;
            else if (key == KEY_LEFT) player1CarDirection = MOVE_LEFT;
            else if (key == KEY_RIGHT) player1CarDirection = MOVE_RIGHT;






            //int x = picPlayer1Car.Location.X;
            //int y = picPlayer1Car.Location.Y;
            //if (e.KeyCode == Keys.Right) x += 5;
            //else if (e.KeyCode == Keys.Left) x -= 5;
            //else if (e.KeyCode == Keys.Up) y -= 5;
            //else if (e.KeyCode == Keys.Down) y += 5;
            //picPlayer1Car.Location = new Point(x, y);
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            getCoordinates();
            moveCoordinates();
            picPlayer1Car.Left = player1CarLeft;
            picPlayer1Car.Top = player1CarTop;

        }

        private void moveCoordinates()
        {
            const int MOVE_AMOUNT = 2;
            if (player1CarDirection == MOVE_LEFT) player1CarLeft -= MOVE_AMOUNT;
            else if (player1CarDirection == MOVE_RIGHT) player1CarLeft += MOVE_AMOUNT;
            else if (player1CarDirection == MOVE_UP) player1CarTop -= MOVE_AMOUNT;
            else if (player1CarDirection == MOVE_DOWN) player1CarTop += MOVE_AMOUNT;
            // These 2 lines of code are the same as the ones in the private void getCoordinates()
            player1CarBottom = picPlayer1Car.Top + picPlayer1Car.Height;
            player1CarRight = picPlayer1Car.Left + picPlayer1Car.Width;


        }

        private void getCoordinates()
        {
            player1CarTop = picPlayer1Car.Top;
            player1CarLeft = picPlayer1Car.Left;
            player1CarWidth = picPlayer1Car.Width;
            player1CarHeight = picPlayer1Car.Height;
            // These two lines of code have to go at the bottom, since they use things that need to be created before they are created.
            player1CarBottom = picPlayer1Car.Top + picPlayer1Car.Height;
            player1CarRight = picPlayer1Car.Left + picPlayer1Car.Width;

            // Finish typing this code.
            coin1Top = picCoin1.Top;
            coin1Bottom = picCoin1.Bottom;
            coin1Left = 0;
            coin1Right = 0;
            coin1Width = 0;
            coin1Height = 0;
            coin1Direction = 0;
        }
    }
}
