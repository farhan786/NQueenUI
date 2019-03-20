using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NQueenUI.Logic
{
    class CSP_constraint
    {
        public static bool checkConstraint(int row, int column)
        {

            int k, l;

            //Checking any other queen in row or in column
            for (k = 0; k < CSP_domain.numOfQueens; k++)
            {

                if ((CSP_variable.chessBoard[row, k] == 1) || (CSP_variable.chessBoard[k, column] == 1))
                    return true;
            }

            //Checking any other queen in left and right Diagonal
            for (k = 0; k < CSP_domain.numOfQueens; k++)
            {

                for (l = 0; l < CSP_domain.numOfQueens; l++)
                {

                    //Right and Left Diagonal Condtion
                    if ((k + l) == (row + column) || (k - l) == (row - column))
                    // add for left, minus for right
                    {

                        //Is there any other queen placed?
                        if ((CSP_variable.chessBoard[k, l] == 1))
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
