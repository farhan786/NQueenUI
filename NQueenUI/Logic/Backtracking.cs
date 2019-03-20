using NQueenUI.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NQueenUI.Logic
{
    class Backtracking
    {
        public static string ElapsedTime;
        
        

        public static bool Backtrack(int noOfQueen, int inc)
        {

            //Is All queen are placed?
            if ( noOfQueen == inc )
            {

                return true;
            }


            for ( int j = 0 ; j < noOfQueen ; j++ )
            {

                //Checking each index of chess board
                if (!( CSP_constraint.checkConstraint( inc , j ) ))
                {

                    //Placing Queen in non-voilate index
                    CSP_variable.chessBoard[ inc, j ] = 1;

                    
                    //Print the tree
                    Print(noOfQueen);
                    Console.WriteLine();
                    
                    
                    
                    //Recursion
                    if ( Backtrack ( noOfQueen , ( inc + 1 )) == true)
                    {
                        return true;
                    }

                    //Backtracking
                    CSP_variable.chessBoard[ inc , j ] = 0;         /*if solution is not found than remove whatever changes
                                                      were made i.e. remove current queen from (inc,j)*/

                }
            }

            //Remain IN the method
            return false;
        }

        //Printing the result
        public static void Print(int noOfQueen)
        {

            for (int i = 0; i < noOfQueen; i++)
            {

                for (int j = 0; j < noOfQueen; j++)
                {
                    if (CSP_variable.chessBoard[i, j] == 1)
                        Console.Write(" Q ");

                    else
                        Console.Write(" . ");
                }
                Console.Write("\n");

            }
        }
    }
       

}
