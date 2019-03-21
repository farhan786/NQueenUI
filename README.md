# NQueenUI
AI Course Project
Description:
N-Queen Problem is one of the famous problem in Artificial Intelligence. In this problem, Agent has to place all the Queens on N x N chess board in such format that they cannot able to attack each other. Queen is able to attack in the following directions: 
1)	Diagonals 
2)	Rows 
3)	Columns

How this Project works?
This project includes a GUI which has a textbox to get number of Queens and a dropdown to select the method by which you want to solve your N-Queen Problem.
Firstly, the program will place first queen at (0, 0) position on NxN chessboard. Then, it will check the constraints that either there is any other queen in the respective diagonals, row or column. If any constraint is violating then backtracking will occur. And if any constraint would not violate then the next queen will be placed to next row. Then, again it will check the constraints and this method occur recursively, until all the queens are placed on the chessboard without violating the constraints.

Backtracking
Backtracking will use the technique of DFS in advanced way. In backtracking if the constraints are violating then it will backtrack and find other position to place the queen that will not violating the constraints.
