using System;
using NQueenUI.Logic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NQueenUI
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void inputButton_Click(object sender, EventArgs e) {

            //Checking the input must be a number
            if ( Regex.IsMatch( inputText.Text , @"^\d+$" ) ) {

                //String to Integer
                CSP_domain.numOfQueens = int.Parse( inputText.Text );

                //If input is 3 or lower value than solution is not possible
                if (CSP_domain.numOfQueens <= 3 ) {

                    MessageBox.Show( "Oops!!! it's solution doesn't exist..." , "No Solution" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                }
                else {

                    //To Show chessboard on click
                    board chessboard = new board();
                    chessboard.ShowDialog();
                    label4.Text = Backtracking.ElapsedTime;

                }
            }
            else {

                MessageBox.Show( "You enter some invalid input." , "Invalid Input" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation );

            }
        }
        
        private void inputText_TextChanged(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }
    }
}
