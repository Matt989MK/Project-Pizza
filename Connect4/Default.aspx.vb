
Partial Class _Default
    Inherits System.Web.UI.Page
    'declare a constant to store the board size
    Const BOARD_SIZE As Integer = 7
    Const CELL_COUNT As Integer = BOARD_SIZE * BOARD_SIZE
    'declare an array list to store the board
    Dim TheBoard As New ArrayList
    'const for the cell size
    Dim CELL_SIZE As Integer = 32
    'cosnt for left indent
    Const LEFT_INDENT As Integer = 100
    'const for top indent
    Const TOP_INDENT As Integer = 25

    'these are the events that are triggered from the interface
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'if this is posted back page
        If IsPostBack = True Then
            'get the board from the session object
            TheBoard = Session("TheBoard")
        Else
            'otherwise initialise the board array list
            Call InitialiseArray()
        End If
        'generate the on screen version of the board
        Call MakeBoard()
        'populate the board on the screen with the board in the array list
        Call DisplayArray()
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        'save the board array in the session object
        Session("TheBoard") = TheBoard
    End Sub

    Protected Sub btnRed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRed.Click
        'this event runs when the red player makes their move
        'declare a variable to store the column number
        Dim ColumnNo As Integer
        'validate the input
        If ValidColumn(txtRed) Then
            'read the data from the page
            ColumnNo = txtRed.Text
            'make the move for this player
            Call MakeMove(ColumnNo, "red.gif", "Red")
            'clear the text box
            txtRed.Text = ""
        End If
    End Sub

    Protected Sub btnYellow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYellow.Click
        'this event runs when the yellow player makes their move
        'declare a variable to store the column number
        Dim ColumnNo As Integer
        'validate the input
        If ValidColumn(txtYellow) Then
            'read the data from the page
            ColumnNo = txtYellow.Text
            'make the move for this player
            Call MakeMove(ColumnNo, "yellow.gif", "Yellow")
            'clear the text box
            txtYellow.Text = ""
        End If
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'this event clears the board for a new game
        'clear the board array 
        Call InitialiseArray()
        'update the board on the page
        Call DisplayArray()
    End Sub

    'these are the subs and functions that make the game work

    Function ValidColumn(ByVal txtColumn As TextBox) As Boolean
        'test to see if a column entered by the user is valid
        'will display an error if not valid
        'returns true if the column is valid
        'false if it is not
        'clear the error label
        lblMessage.Text = ""
        'test to make sure that the value is a number
        If IsNumeric(txtColumn.Text) Then
            'if it is then test that it is between 1 and board size
            If txtColumn.Text >= 1 And txtColumn.Text <= BOARD_SIZE Then
                'return true
                Return True
            Else
                'display an error
                lblMessage.Text = "The column number must be between 1 and 7."
                'return false
                Return False
            End If
        Else
            'display an error
            lblMessage.Text = "You must enter a valid number for the column."
            Return False
        End If
    End Function

    Sub MakeMove(ByVal ColumnNo As Integer, ByVal CounterGraphic As String, ByVal PlayerColour As String)
        'this sub handles making a move for a player
        'variable used to store y position in the array
        Dim BoardIndex As Integer
        'subtract 1 from the column number so it is zero bound
        ColumnNo = ColumnNo - 1
        'work out the BoardIndex by calling the PlaceCounterInArray function
        BoardIndex = PlaceCounterInArray(ColumnNo, CounterGraphic)
        'display the array
        Call DisplayArray()
        'test to see if the game is over
        If GameOver(BoardIndex) = True Then
            'if it is then display a message
            lblMessage.Text = PlayerColour & " is the winner"
        End If
    End Sub

    Function PlaceCounterInArray(ByVal Col As Integer, ByVal CounterIcon As String) As Integer
        'used to place a counter in the array
        'requires an x position 0 - 6 and the name of the icon graphic
        'returns the y position of the placed counter
        Dim BoardIndex As Integer
        'declare a variable to store the y position
        Dim Row As Integer
        'declare a variable to store the current cell contents
        Dim CellGraphic As String
        'start at the top most row
        Row = 0
        BoardIndex = Col
        'get the counter at that position
        CellGraphic = TheBoard.Item(BoardIndex)
        'while the counter is blank and we have not reached the bottom row
        Do While CellGraphic = "blank.gif" And (BoardIndex + BOARD_SIZE) <= CELL_COUNT - 1
            'move down a row
            BoardIndex = BoardIndex + BOARD_SIZE
            'get the counter at the new position
            CellGraphic = TheBoard.Item(BoardIndex)
            'if it isn't blank then 
            If CellGraphic <> "blank.gif" Then
                'step back one
                BoardIndex = BoardIndex - BOARD_SIZE
            End If
        Loop
        'place the counter in the blank cell
        TheBoard.Item(BoardIndex) = CounterIcon
        'return the y postion of teh new counter
        Return BoardIndex
    End Function

    Sub InitialiseArray()
        'this sub is used to fill the array with blank cells 
        'clear the array
        TheBoard = New ArrayList
        'counter for the loop
        Dim Counter As Integer
        'loop from zero to board size less 1
        For Counter = 0 To (BOARD_SIZE * BOARD_SIZE) - 1
            'add a new blank cell to the array list
            TheBoard.Add("blank.gif")
        Next
    End Sub

    Sub DisplayArray()
        'used to display the array on the screen
        'var to store x position
        Dim ArrayIndex As Integer
        'loop from zero to board size less 1
        For ArrayIndex = 0 To CELL_COUNT - 1
            Call UpdateCell(ArrayIndex)
        Next
    End Sub

    Sub UpdateCell(ByVal ImageIndex As Integer)
        'create a new image control
        Dim ImgCell As New Image
        'find image control the page and use it to initialise this new image control
        ImgCell = form1.FindControl("imgCell" & ImageIndex)
        'set the picture for our new image control with the array contents
        ImgCell.ImageUrl = TheBoard.Item(ImageIndex)
        'remove the old image control on the page
        form1.Controls.Remove(ImgCell)
        'append our new image control
        form1.Controls.Add(ImgCell)
    End Sub

    Public Function GameOver(ByVal BoardIndex As Integer) As Boolean
        'this function tests to see if the game has been won
        'it accepts one parameter which is the index of the last piece placed
        'it returns true or false depending on if the game is won
        '
        'var to store the number of tiles found in a row
        Dim NumberFound As Integer
        'array list to store the directions we want to search in
        Dim SearchList As New ArrayList
        'index for the above array list
        Dim Index As Integer
        'var to store a single search direction
        Dim SearchDirection As Integer
        'search left right
        SearchList.Add(1)
        'search up down
        SearchList.Add(BOARD_SIZE)
        'search diagonal /
        SearchList.Add(BOARD_SIZE - 1)
        'search diagonal \
        SearchList.Add(BOARD_SIZE + 1)
        'do each search
        Do
            'get the direction to search
            SearchDirection = SearchList.Item(Index)
            'find out how many tiles are together at this board index for specified direction
            NumberFound = FindFour(BoardIndex, SearchDirection)
            'increase index for searches
            Index = Index + 1
            'loop until all searches are done or a row of four is found
        Loop Until Index = 4 Or NumberFound = 4
        'if a row of four is found
        If NumberFound = 4 Then
            'return true
            Return True
        Else
            'return false
            Return False
        End If
    End Function

    Function FindFour(ByRef StartIndex As Integer, ByVal Direction As Integer, Optional ByVal FindFirst As Boolean = False) As Integer
        'this function counts how many pieces are ina row at the location specified by StartIndex
        'it accepts a direction to search 1 (left right),7 (up down),6 (diagonal /) & 8 (diagonal \)
        'it returns the number of tiles found together in the specified direction
        '
        'var to store the StartIndex when the program starts
        Dim TempIndex As Integer
        'var to store the old colour of the tile found
        Dim OldCell As String
        'var to flag a colour change
        Dim ColourChange As Boolean = False
        'var to store the new index
        Dim NewIndex As Integer
        'counter to count the number of tiles found
        Dim TilesInARow As Integer
        'ver to store the row number
        Dim Row As Integer
        'ver to store the column number
        Dim Col As Integer
        'var to store the old column number initialise this based on start index
        Dim OldCol As Integer = StartIndex - (Int(StartIndex / BOARD_SIZE) * BOARD_SIZE)
        'flag to identify if the edge of the board is found
        Dim EdgeFound As Boolean = False
        'var to store the next cell
        Dim NextCell As String
        'if this is the first time the function has been run
        If FindFirst = False Then
            'store the startindex
            TempIndex = StartIndex
            'search in the oposite direction to the one specified
            TilesInARow = FindFour(StartIndex, Direction, True)
        Else 'if this is the function calling itself
            'set direction to the oposite
            Direction = -Direction
        End If
        'if four tiles were not found
        If TilesInARow <> 4 Then
            'set the counter to one
            TilesInARow = 1
            'get the tile at the start position
            OldCell = TheBoard.Item(StartIndex)
            'calculate the new index
            NewIndex = StartIndex + Direction
            'find out what row this is
            Row = Int(NewIndex / 7)
            'see if an edge has been hit
            EdgeFound = IsEdge(NewIndex, Col, OldCol)
            'while the current row is in the board, there is no colour change, four tiles have not been found, the index is less than the number of cells in the board and no edge has been hit
            Do While Row < BOARD_SIZE And ColourChange = False And TilesInARow < 4 And NewIndex >= 0 And NewIndex <= CELL_COUNT - 1 And EdgeFound = False
                'get the tile at the next position
                NextCell = TheBoard.Item(NewIndex)
                'If TheBoard old cell is different to the next cell
                If OldCell <> NextCell Then
                    'flag that we have reached a different colour
                    ColourChange = True
                Else
                    'increase the tile count
                    TilesInARow = TilesInARow + 1
                    'calculate the new index
                    NewIndex = NewIndex + Direction
                    'calc the row for this index
                    Row = Int(NewIndex / BOARD_SIZE)
                    'see if we have hit an edge
                    EdgeFound = IsEdge(NewIndex, Col, OldCol)
                End If
            Loop
            If FindFirst Then 'if this is a recursive call
                'return the index of the first tile in the row
                StartIndex = NewIndex - Direction
            Else
                'return the original index
                StartIndex = TempIndex
            End If
        End If
        'return the number of tiles found
        Return TilesInARow
    End Function

    Function IsEdge(ByVal BoardIndex As Integer, ByRef NewCol As Integer, ByRef OldCol As Integer) As Boolean
        'this function checks to see if an edge has been reached on the board
        'calculate the column we are currently at
        NewCol = BoardIndex - (Int(BoardIndex / BOARD_SIZE) * BOARD_SIZE)
        'if there is a switch from 6 - 0 or 0 - 6 then we have crossed a board edge
        If (OldCol = BOARD_SIZE - 1 And NewCol = 0) Or (OldCol = 0 And NewCol = BOARD_SIZE - 1) Then
            'return true
            Return True
        Else
            'store the column position
            OldCol = NewCol
            'return false
            Return False
        End If
    End Function

    Sub MakeColumnHeads()
        'var for the left position
        Dim LeftPosn As Integer
        'variable for the loop
        Dim Count As Integer
        'loop for generating the column headings for the board
        For Count = 0 To BOARD_SIZE - 1
            'declare a new label control
            Dim ACell As New Label
            'set the positioning to absolute
            ACell.Style("Position") = "Absolute"
            'set the text of the label
            ACell.Text = Count + 1
            'set the top position for the label
            ACell.Style("Top") = "0px"
            'calculate the left position
            LeftPosn = LEFT_INDENT + (CELL_SIZE * Count) + (CELL_SIZE / 2)
            'set the left position of the label
            ACell.Style("Left") = LeftPosn & "px"
            'add the control to the page
            form1.Controls.Add(ACell)
        Next
    End Sub

    Sub MakeBoard()
        'sub that generates the board that is displayed on the screen
        'variable for the loop
        Dim Count As Integer
        'var for x position of control
        Dim LeftPosn As Integer
        'var for y position of control
        Dim TopPosn As Integer
        'create controls based on board size
        For Count = 0 To CELL_COUNT - 1
            'declare a new image control
            Dim ImgCell As New Image
            'set the name of the image control
            ImgCell.ID = "imgCell" & Count
            'set the positioning to absolute
            ImgCell.Style("Position") = "Absolute"
            'work out the left position of the control
            LeftPosn = LEFT_INDENT + (CELL_SIZE * (Count - (Int(Count / BOARD_SIZE) * BOARD_SIZE)))
            'work out the top position of the control
            TopPosn = TOP_INDENT + (CELL_SIZE * Int(Count / BOARD_SIZE))
            'set the top position of the control
            ImgCell.Style("Top") = TopPosn & "px"
            'set the left postion of the control
            ImgCell.Style("Left") = LeftPosn & "px"
            'add the control to the page
            form1.Controls.Add(ImgCell)
        Next
        'generate the column headings
        Call MakeColumnHeads()
    End Sub
End Class
