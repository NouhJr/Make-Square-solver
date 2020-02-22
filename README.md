Input:
The first line contains number of pieces. Each piece is then specified by
listing a single line with two integers, the number of rows and columns in
the piece, followed by one or more lines which specify the shape of the
piece. The shape specification consists of 0 or 1 characters, with the 1
character indicating the solid shape of the puzzle (the 0 characters are
merely placeholders). For example, piece A above would be specified as
follows:
2 3
111
101

Output:
Your program should report all solution, in the format shown by the
examples below. A 4-row by 4-column square should be created, with
each piece occupying its location in the solution. The solid portions of
piece #1 should be replaced with `1' characters, of piece #2 with `2'
characters.
Sample output that represents the figure above could be:
1112
1412
3422
3442

For cases which have no possible solution simply report "No solution
possible".
