using System;
using NQueenUI.Logic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace NQueenUI
{
    public partial class board : Form
    {
        //Dynamic Label or runtime label   
        int LabelWidth = 60;
        int LabelHeight = 60;
        int Distance = 20;
        int x_axis = -15;
        int y_axis = -15;
        
        //These queens are label
        static Label[,] square = new Label[CSP_domain.numOfQueens, CSP_domain.numOfQueens];

        public board() {

            InitializeComponent();
        }

        private void board_Load(object sender, EventArgs e) {
            
            //Size of the Window
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //Intializing the array
            CSP_variable.chessBoard = new int[ CSP_domain.numOfQueens , CSP_domain.numOfQueens ];

            //To Calculate the Time it take to solve
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            //It is a method which is in class "Queens.cs"
            Backtracking.Backtrack(CSP_domain.numOfQueens , 0 );

            stopwatch.Stop();

            //It is a variable which is in class "Queens.cs"
            Backtracking.ElapsedTime = ( stopwatch.Elapsed ).ToString();

            //All of the disigning are done in these loops
            for ( int x = 0 ; x < CSP_domain.numOfQueens ; x++ ) {

                for ( int y = 0 ; y < CSP_domain.numOfQueens ; y++ ) {
                    
                    Label tempLabel = new Label();
                    //Properties of Label
                    tempLabel.Top = x_axis + ( x * LabelHeight + Distance );
                    tempLabel.Left = y_axis + ( y * LabelWidth + Distance );
                    tempLabel.Width = LabelWidth;
                    tempLabel.Height = LabelHeight;
                    tempLabel.Font = new Font( "Arial" , 24 , FontStyle.Bold );
                    
                    //First if is going to color rows 
                    //in pattern of black and white
                    if ( x % 2 == 0 ) {

                        tempLabel.BackColor = Color.White;
                        
                        //This if is coloring the each row's coloumn  
                        if ( y % 2 == 1 ) {

                            tempLabel.BackColor = Color.Black;
                        }
                    }

                    else if ( y % 2 == 0 ) {

                        tempLabel.BackColor = Color.Black;
                    }

                    //If every thing is fine than Queen will going to be display!!!
                    if ( CSP_variable.chessBoard[x, y] == 1 ) {

                        Image img = Image.FromFile( @"C:\Users\Muhammad Farhan\Desktop\NQueenUI\NQueenUI\queen.png" );
                        tempLabel.Image = img;

                    }
                    else {

                        tempLabel.Text = "";
                    }

                    //Adding the Label in Control
                    this.Controls.Add( tempLabel );

                }

                
            }
    
        }
    }
    

}
