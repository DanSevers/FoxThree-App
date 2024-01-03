using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel1
{
    public class Board
    {
        // the size of the board usually 8x8
        public int Size { get; set; }

        // 2d array of type cell.
        public Cell[,] theGrid { get; set; }

        // constructor
        public Board (int s)
        {
            // initial size of the board is defined by s.
            Size = s;

            // create a new 2D array of type cell.
            theGrid = new Cell[Size, Size];

            // fill the 2D array with new Cells, each with unique x and y coordinates.
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }


        }
        // bool isSafe has been created to try to create multiple legal next moves markers for pieces that can travel all over the board.
        
        //bool isSafe = true;

        public bool inBounds(int x, int y)
        {
            if (x < 0 || x >= Size || y < 0 || y >= Size)
            {
                Console.WriteLine("Pos " + x + ", " + y + " is NOT safe.");
                //isSafe = false;
                return false;
            }
            else
            {
                Console.WriteLine("Pos " + x + ", " + y + " is safe.");
                //isSafe = true;
                return true;
            }
        }

        public void MarkNextLegalMoves( Cell currentCell, object chessPiece)
        {
            // step 1 - clear all previous legal moves
            for (int i = 0;i < Size;i++)
            {
                for (int j = 0;j < Size;j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

                // step 2 - find all legal moves and mark the cells as "legal"
                // need to find a way to mark movement for other pieces that are able to move to board limit - while loop??

                switch (chessPiece)
                {

                    case "Knight":
                    if (inBounds(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (inBounds(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (inBounds(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (inBounds(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (inBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (inBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (inBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (inBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;



                case "King": // can move 1 space in any direction ** NEED TO TEST
                        if (inBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber + 0))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                        if (inBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber - 0))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 0].LegalNextMove = true;
                        if (inBounds(currentCell.RowNumber + 0, currentCell.ColumnNumber + 1))
                            theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                        if (inBounds(currentCell.RowNumber - 0, currentCell.ColumnNumber - 1))
                            theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                        if (inBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                        if (inBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                        if (inBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                        if (inBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                        break;

                    case "Rook": //unfinished can move orthogonally as far as board limit
                                 // while loop is to try to keep expanding the LegalNextMove options until it finds the board edge limit
                                 // this code below does not work
                    if (inBounds(currentCell.RowNumber + 1 , currentCell.ColumnNumber - 0))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 0].LegalNextMove = true;
                    break;


                    case "Bishop": // can move diagonally as far as board limit
                        break;


                    case "Queen": // can move othogonally and diagonally as far as board limit
                    
                    break;

                    default:
                        break;


                }
            
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }
    }
}
