
Module Common
    Public Const sTitle As String = "ISPiggy"           ' title of program
    Public Const iMinDomain As Integer = 5              ' minimum word size for domain name
    Public Const iMaxDomain As Integer = 8              ' maximum word size for domain name
    Public Const sSuccess As String = "Success! "       ' message for successful/valid domain
    Public Const sLblName As String = "Random Domain: " ' random domain label set
    Public iStopper As Integer                          ' tracks events within btnStart click

    '---------------------------------------------------------------------------------------
    ' Procedure : Snooze
    ' Purpose   : Controlled pause for specified seconds
    ' How to Use: Snooze(intSeconds)
    '---------------------------------------------------------------------------------------
    Public Sub Snooze(ByVal seconds As Integer)
        Console.WriteLine("In the snooze")
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    '---------------------------------------------------------------------------------------
    ' Procedure : cleanStart
    ' Purpose   : sets all Form1 labels on start / restart
    ' How to Use: cleanStart()
    '---------------------------------------------------------------------------------------
    Public Sub cleanStart()
        Form1.stat01.Text = "READY"
        Form1.lblName.Text = sLblName
        Form1.btnStop.Enabled = False
        Form1.btnStart.Enabled = True
        Form1.btnIndicator.BackColor = Color.Green
        Form1.lblLoopCheck.Text = Nothing
    End Sub

    '---------------------------------------------------------------------------------------
    ' Procedure : myRandom
    ' Purpose   : generate random number between iMinVal and iMaxVal
    ' How to Use: iVar = myRandom (iMinValue, iMaxValue)
    '---------------------------------------------------------------------------------------
    Public Function myRandom(iMinVal As Integer, iMaxVal As Integer)
        myRandom = Int((iMaxVal - iMinVal + 1) * Rnd()) + iMinVal
    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : isOdd
    ' Purpose   : test if intNumber number is odd, returns 1, else returns 0
    ' How to Use: intVar = isOdd (intNumber)
    '---------------------------------------------------------------------------------------
    Public Function isOdd(iNumber As Integer)
        If Int(iNumber) Mod 2 > 0 Then
            isOdd = 0   ' Odd Number, return 0
        Else
            isOdd = 1   ' Even Number, return 1
        End If
    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : checkDebugMode
    ' Purpose   : checks status of debug mode and sets Form1 accordingly
    ' How to Use: checkDebugMode ()
    '---------------------------------------------------------------------------------------
    Public Sub checkDebugMode()
        If Form1.chkDebug.Checked Then          ' we are in debug mode, checked
            Form1.Size = New Size(580, 150)               ' sets debug form size
            Form1.MaximumSize = New Size(580, 150)        ' disables resizing up
            Form1.MinimumSize = New Size(580, 150)        ' disables resizing down
            Form1.stat01.Text = "Entering interactive DEBUG mode"

            Form1.btnStart.Enabled = False                ' disable start button
            Form1.btnStop.Enabled = True

        Else                                    ' we are in production mode, unchecked
            Form1.Size = New Size(320, 150)               ' sets production form size
            Form1.MaximumSize = New Size(320, 150)        ' disables resizing up
            Form1.MinimumSize = New Size(320, 150)        ' disables resizing down
            Form1.stat01.Text = "Press START to Begin"

            Form1.btnStart.Enabled = True               ' enable start button
            Form1.lblName.Text = sLblName               ' resets domain text
        End If
    End Sub

End Module
