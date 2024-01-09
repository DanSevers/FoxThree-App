using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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






        #region Targeting Direction Methods (too many!) 
        // (Needs simplifying LOL)


        // north targeting range
        private void TargetNorth(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 0;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell ++;
                columnIndexer ++;
            }
        }

        // south targeting range
        private void TargetSouth(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 0;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell ++;
                columnIndexer ++;
            }
        }
        

        // east targeting range
        private void TargetEast(int cellCount, Cell currentCell)
        {
            int columnIndexer = 0;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber - 0].LegalNextMove = true;
                startingCell ++;
                rowIndexer++;
            }
        }

        // west targeting range
        private void TargetWest(int cellCount, Cell currentCell)
        {
            int columnIndexer = 0;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber - 0].LegalNextMove = true;
                startingCell ++;
                rowIndexer++;
            }
        }

        // northeast targeting range
        private void TargetNorthEast(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // northwest targeting range
        private void TargetNorthWest(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // southeast targeting range
        private void TargetSouthEast(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // southeast targeting range
        private void TargetSouthWest(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // northnortheast targeting range
        private void TargetNNEast(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // northnorthwest targeting range
        private void TargetNNWest(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // eastnortheast targeting range
        private void TargetENEast(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // westnorthwest targeting range
        private void TargetWNWest(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // southsoutheast targeting range
        private void TargetSSEast(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // southsouthwest targeting range
        private void TargetSSWest(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // eastsoutheast targeting range
        private void TargetESEast(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // westsouthwest targeting range
        private void TargetWSWest(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        //Experimental

        // upper east targeting range
        private void TargetEastA(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                //columnIndexer++;
                rowIndexer++;
            }
        }

        // upper west targeting range
        private void TargetWestA(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                //columnIndexer++;
                rowIndexer++;
            }
        }

        // upper east targeting range
        private void TargetEastB(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                //columnIndexer++;
                rowIndexer++;
            }
        }

        // upper west targeting range
        private void TargetWestB(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                //columnIndexer++;
                rowIndexer++;
            }
        }

        // upper east targeting range
        private void TargetNorthA(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                //rowIndexer++;
            }
        }

        // upper west targeting range
        private void TargetSouthA(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                //rowIndexer++;
            }
        }

        // upper east targeting range
        private void TargetNorthB(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                //rowIndexer++;
            }
        }

        // upper west targeting range
        private void TargetSouthB(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                //rowIndexer++;
            }
        }

        // Extras -------------------------------

        // northeastextra targeting range
        private void TargetextraNE(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // northwestextra targeting range
        private void TargetextraNW(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        //southeastextra targeting range
        private void TargetextraSE(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // southwestextra targeting range
        private void TargetextraSW(int cellCount, Cell currentCell)
        {
            int columnIndexer = 1;
            int rowIndexer = 2;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + columnIndexer].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // eastnortheastextra targeting range
        private void TargetextraENE(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber - 2].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // westnorthwestextra targeting range
        private void TargetextraWNW(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber - 2].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // eastsoutheastextra targeting range
        private void TargetextraESE(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber + rowIndexer, currentCell.ColumnNumber + 2].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        // westsouthwestextra targeting range
        private void TargetextraWSW(int cellCount, Cell currentCell)
        {
            int columnIndexer = 2;
            int rowIndexer = 1;
            int startingCell = 0;

            while (inBounds(rowIndexer, columnIndexer)
                && startingCell < cellCount)
            {
                theGrid[currentCell.RowNumber - rowIndexer, currentCell.ColumnNumber + 2].LegalNextMove = true;
                startingCell++;
                columnIndexer++;
                rowIndexer++;
            }
        }

        #endregion






        public void MarkNextLegalMoves( Cell currentCell, string targetingChoice)
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
                // need to find a way to mark movement for other pieces that are able to move to board limit - loop??

                switch (targetingChoice)
                {

                    case "AIM-120": // UNFINISHED can move orthogonally and diagonally
                    // Radar A2A Missile

                    // main direction
                    TargetNorth(6, currentCell);
                    TargetSouth(6, currentCell);
                    TargetEast(6, currentCell);
                    TargetWest(6, currentCell);

                    // thicken main direction
                    TargetNorthA(6, currentCell);
                    TargetNorthB(6, currentCell);
                    TargetSouthA(6, currentCell);
                    TargetSouthB(6, currentCell);
                    TargetEastA(6, currentCell);
                    TargetEastB(6, currentCell);
                    TargetWestA(6, currentCell);
                    TargetWestB(6, currentCell);

                    // diagonals
                    TargetNorthEast(6, currentCell);
                    TargetNorthWest(6, currentCell);
                    TargetSouthEast(6, currentCell);
                    TargetSouthWest(6, currentCell);

                    // thicken diagonals
                    TargetNNEast(4, currentCell);
                    TargetSSEast(4, currentCell);
                    TargetENEast(4, currentCell);
                    TargetESEast(4, currentCell);
                    TargetNNWest(4, currentCell);
                    TargetSSWest(4, currentCell);
                    TargetWNWest(4, currentCell);
                    TargetWSWest(4, currentCell);

                    // extras
                    TargetextraNE(4, currentCell);
                    TargetextraNW(4, currentCell);
                    TargetextraSE(4, currentCell);
                    TargetextraSW(4, currentCell);
                    TargetextraENE(4, currentCell);
                    TargetextraWNW(4, currentCell);
                    TargetextraESE(4, currentCell);
                    TargetextraWSW(4, currentCell);

                    break;


                    case "AIRS-T": // UNFINISHED can move orthogonally and diagonally
                               // Heat seeking A2A missile - can lock missiles!
                    TargetNorth(5, currentCell);
                    TargetSouth(5, currentCell);
                    TargetEast(5, currentCell);
                    TargetWest(5, currentCell);

                    //thicken main direction
                    TargetNorthA(5, currentCell);
                    TargetNorthB(5, currentCell);
                    TargetSouthA(5, currentCell);
                    TargetSouthB(5, currentCell);
                    TargetEastA(5, currentCell);
                    TargetEastB(5, currentCell);
                    TargetWestA(5, currentCell);
                    TargetWestB(5, currentCell);

                    //diagonals
                    TargetNorthEast(5, currentCell);
                    TargetNorthWest(5, currentCell);
                    TargetSouthEast(5, currentCell);
                    TargetSouthWest(5, currentCell);
                    break;


                    case "GBU-38": // UNFINISHED can move orthogonally and diagonally
                                   // GPS Guided A2G bomb

                    // main direction
                    TargetNorth(5, currentCell);
                    TargetSouth(5, currentCell);
                    TargetEast(5, currentCell);
                    TargetWest(5, currentCell);

                    // thicken main direction
                    TargetNorthA(4, currentCell);
                    TargetNorthB(4, currentCell);
                    TargetSouthA(4, currentCell);
                    TargetSouthB(4, currentCell);
                    TargetEastA(4, currentCell);
                    TargetEastB(4, currentCell);
                    TargetWestA(4, currentCell);
                    TargetWestB(4, currentCell);

                    // diagonals
                    TargetNorthEast(2, currentCell);
                    TargetNorthWest(2, currentCell);
                    TargetSouthEast(2, currentCell);
                    TargetSouthWest(2, currentCell);

                    break;


                    case "AGM-88": // UNFINISHED can move orthogonally and diagonally
                                   // Anti radiation missile A2A & A2G
                                   // main direction
                    TargetNorth(7, currentCell);
                    TargetSouth(7, currentCell);
                    TargetEast(7, currentCell);
                    TargetWest(7, currentCell);

                    // diagonals
                    TargetNorthEast(7, currentCell);
                    TargetNorthWest(7, currentCell);
                    TargetSouthEast(7, currentCell);
                    TargetSouthWest(7, currentCell);
                    break;


                    case "Vulcan Cannon": // can move orthogonally and diagonally
                                          // Burst rounds A2A & A2G
                    TargetNorth(3, currentCell);
                    TargetSouth(3, currentCell);
                    TargetEast(3, currentCell);
                    TargetWest(3, currentCell);
                    break; 

                    default:
                        break;


                }
            
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }
    }
}
