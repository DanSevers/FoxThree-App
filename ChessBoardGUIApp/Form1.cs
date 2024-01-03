using ChessBoardModel1;
using System.Security.Cryptography.X509Certificates;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        //reference to the class Board. Contains tyhe values of the board.
        static Board myBoard = new Board(8);

        // 2D array of buttons whose values are determined by myBoard.
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            int buttonSize = panel1.Width / myBoard.Size;

            // make panel a perfect square
            panel1.Height = panel1.Width;

            // nested loops. create buttons and print them to the screen.
            for (int i = 0; i < myBoard.Size; i++)
            {

                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Width = buttonSize;
                    btnGrid[i, j].Height = buttonSize;

                    // add a click event  to each button.
                    btnGrid[i, j].Click += Grid_Button_Click;

                    // add  the new button to the panel.
                    panel1.Controls.Add(btnGrid[i, j]); ;

                    // set the location of the new button.
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);
                }


            }


        }

        public void Grid_Button_Click(object? sender, EventArgs e)
        {

            // get the row and col number of the button clicked
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid[x, y];

            // determine legal next moves
            // change "Knight" to a variable from comboBox.
            myBoard.MarkNextLegalMoves(currentCell, "Rook");

            // update the text on each button - BONUS for my next project- change colour of button too
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].Text = ("");
                    if (myBoard.theGrid[i, j].LegalNextMove == true)
                    {
                        //btnGrid[i, j].Text = "Legal";
                        btnGrid[i, j].BackColor = Color.Green;
                    }
                    else if (myBoard.theGrid[i, j].CurrentlyOccupied == true)
                    {
                        //btnGrid[i, j].Text = "Knight";
                        btnGrid[i, j].BackColor = Color.LightBlue;
                    }
                    // Chess Board Game Part 13 challenges

                    /*
                     * Error Checking
                     * Double check to make sure all cases work as designed. Check for out of bounds errors.
                     * 
                     * Multiple Pieces
                     * Utilize the ComboBox1 control values to select all five different chess pieces.
                     * Cuttently the word "Knight" is hard coded into 2 places
                     * Create a new event handler for the ComboBox1 control, store the selected chess piece name in a var and pass
                     * this to the function MarkLegalNextMoves.
                     * (string value from the combo box into MarkLegalNextMoves)
                     * 
                     * Centre Button Text
                     * 
                     */
                }
            }

        }

        // event handler for different pieces
        // figure out how to reference chessPiece from Board.cs
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedChessPiece = comboBox.SelectedItem.ToString();
            if (selectedChessPiece == "Knight")
            {
                object chessPiece = "Knight";
            }
            else  if (selectedChessPiece == "King")
            {
                object chessPiece = "King";
            }
            else if (selectedChessPiece == "Rook")
            {
                object chessPiece = "Rook";
            }
            else if (selectedChessPiece == "Bishop")
            {
                object chessPiece = "Bishop";
            }
            else if (selectedChessPiece == "Queen")
            {
                object chessPiece = "Queen";
            }
        }
    }
}
