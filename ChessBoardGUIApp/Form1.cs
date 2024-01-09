using ChessBoardModel1;
using System.Security.Cryptography.X509Certificates;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        //reference to the class Board. Contains tyhe values of the board.
        static Board myBoard = new Board(25);

        // 2D array of buttons whose values are determined by myBoard.
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];
        private string _selectedWeapon;

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

                    // add a click event to each button.
                    btnGrid[i, j].Click += Grid_Button_Click;

                    // add the new button to the panel.
                    panel1.Controls.Add(btnGrid[i, j]); ;

                    // set the location of the new button.
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i, j].Text = i + "- " + j;
                    btnGrid[i, j].Tag = new Point(i, j);
                    btnGrid[i, j].Font = new Font(Font.FontFamily, 7);
                }


            }


        }



        // Create another click event to mark where your target is before entering the next click event below.



        public void Grid_Button_Click(object? sender, EventArgs e)
        {

            // get the row and col number of the button clicked
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid[x, y];

            // determine legal next moves
            // change "AIM-120" to a value from the comboBox.
            myBoard.MarkNextLegalMoves(currentCell, _selectedWeapon);

            // update the text on each button - BONUS for my next project- change colour of button too
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    //btnGrid[i, j].Text = ("");
                    if (myBoard.theGrid[i, j].LegalNextMove == true)
                    {
                        //btnGrid[i, j].Text = "Legal";
                        btnGrid[i, j].BackColor = Color.Red;
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
            //string selectedWeapon = comboBox.SelectedItem.ToString();

            _selectedWeapon = comboBox.SelectedItem.ToString();

            /*if (selectedWeapon == "AIM-120")
            {
                object weaponChoice = "AIM-120";
            }
            else  if (selectedWeapon == "AIRS-T")
            {
                object weaponChoice = "AIRS-T";
            }
            else if (selectedWeapon == "GBU-38")
            {
                object weaponChoice = "GBU-38";
            }
            else if (selectedWeapon == "AGM-88")
            {
                object weaponChoice = "AGM-88";
            }
            else if (selectedWeapon == "Vulcan Cannon")
            {
                object weaponChoice = "Vulcan Cannon";
            
            }
            */
        }






        //--------------------------------------------------------------------------------------------------------------------------------------




        // TO DO!
        // button to clear targeting system
        // generate random number for all 3 flare buttons and display in each button's assigned label


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear current onscreen targeting info

        }


        // How do I make this work...
        //Created class, method.. do I even need to or can it all be done here

        private void btnFlare1_Click(object sender, EventArgs e)
        {
        int randomNum;

        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            randomNum = random.Next(1, 7);
        }
        //Parse???

        //why dont either of these work
        //string flareResult = int randomNum;
        //Convert.ToString(randomNum);

        // display random number in label
        //lblFlare1.Text = ;
        }

        private void btnFlare2_Click(object sender, EventArgs e)
        {

        }

        private void btnFlare3_Click(object sender, EventArgs e)
        {

        }


        #region Mouse Enter and Leave Methods for Weapon Selection Buttons
        // does not work properly
        // each button displays btnAim120 properties

        string aim120 = "Air to air - radar guided";
        string airsT = "Air to air - radar guided, can lock missiles";
        string agm88 = "Air to ground - radar guided, locks locking structure";
        string gbu38 = "Air to ground - GPS guided";
        string vulCan = "Free fire cannon";

        private void MyButton_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.WhiteSmoke;

            if (sender is Button btnAim120)
            {
                button.Text = aim120;
            }

            else if (sender is Button btnAirsT) 
                        
            {
                button.Text = airsT;
            }

            else if (sender is Button btnAgm88)

            {
                button.Text = agm88;
            }

            else if (sender is Button btnGbu38)

            {
                button.Text = gbu38;
            }

            else if (sender is Button btnVulcan)

            {
                button.Text = vulCan;
            }

            button.Font = new Font(button.Font.FontFamily, 10, button.Font.Style);
        }

        private void MyButton_MouseLeave(object sender, EventArgs e)
        {
            // Change the button's appearance when the mouse leaves
            Button button = (Button)sender;

            if (sender is Button btnAim120)
            {
                button.BackColor = Color.LightBlue;
                button.Text = "AIM-120";
            }

            else if (sender is Button btnAirsT)

            {
                button.BackColor = Color.LightSalmon;
                button.Text = "AIRS-T";
            }

            else if (sender is Button btnAgm88)

            {
                button.BackColor = Color.GhostWhite;
                button.Text = "AGM-88";
            }

            else if (sender is Button btnGbu38)

            {
                button.BackColor = Color.DarkSeaGreen;
                button.Text = "GBU-38";
            }

            else if (sender is Button btnVulcan)

            {
                button.BackColor = Color.LightGray;
                button.Text = "Vulcan Cannon";
            }

            
            button.Font = new Font(button.Font.FontFamily, 14, button.Font.Style);

            #endregion


        }


    }
}
