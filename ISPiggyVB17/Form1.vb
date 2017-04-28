Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = sTitle
        chkDebug.Checked = False
        MaximizeBox = False                 ' disable maximize button
        ni.Visible = False

        Dim frmForm As Form
        frmForm = Me
        checkDebugMode(frmForm)

        Randomize()

        lblName.Text = sLblName
        btnIndicator.BackColor = Color.Green
        btnStart.Enabled = True
        btnStop.Enabled = False
        lblLoopCheck.Text = ""
    End Sub

    Private Sub RandomName_Click(sender As Object, e As EventArgs) Handles RandomName.Click
        Dim intTestOdd As Integer
        Dim strWeb As String

        intTestOdd = myRandom(iMinDomain, iMaxDomain)
        isOdd(intTestOdd)

        strWeb = makeDomainName()

        lblName.Text = sLblName & strWeb
        txtDomain.Text = strWeb
    End Sub

    Private Sub MinusOne_Click(sender As Object, e As EventArgs) Handles MinusOne.Click
        Dim strDomain As String

        strDomain = txtDomain.Text
        strDomain = domainMinusOne(strDomain)
        txtDomain.Text = strDomain
    End Sub

    Private Sub MinusRand_Click(sender As Object, e As EventArgs) Handles MinusRand.Click
        Dim strDomain As String

        strDomain = txtDomain.Text
        strDomain = domainMinusRand(strDomain)
        txtDomain.Text = strDomain
    End Sub

    Private Sub ToCom_Click(sender As Object, e As EventArgs) Handles ToCom.Click
        Dim strDomainName As String

        strDomainName = txtDomain.Text
        strDomainName = toDotCom(strDomainName)
        txtDomain.Text = strDomainName
    End Sub

    Private Sub GetIP_Click(sender As Object, e As EventArgs) Handles GetIP.Click
        DoGetHostEntry(txtDomain.Text)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        iStopper = 0                ' global stopper set to loop
        btnStart.Enabled = False
        btnStop.Enabled = True
        chkDebug.Enabled = False    ' disable debugging

GetDomain:
        RandomName_Click(sender, e)         ' get random domain

CheckDomain:
        ' loop check for unresolvable small domains
        If lblLoopCheck.Text = txtDomain.Text Then GoTo GetDomain
        lblLoopCheck.Text = txtDomain.Text  ' set them equal

        DoGetHostEntry(txtDomain.Text)      ' check name against DNS server

        Dim sToolMsg As String = stat01.Text
        sToolMsg = Microsoft.VisualBasic.Left(sToolMsg, 7)

        If sToolMsg = "Success" Then
            Console.WriteLine("Success! Getting next random name")
            stat01.Text = "Success! Getting next random name..."

            Snooze(2)
            If iStopper = 1 Then Exit Sub
            GoTo GetDomain
        End If

        Console.WriteLine("Invalid domain, checking extension...")
        stat01.Text = "Invalid domain, checking extension..."

        Dim sDomainCheck = txtDomain.Text
        sDomainCheck = Microsoft.VisualBasic.Right(sDomainCheck, 3)

        If sDomainCheck = "com" Then
            Rnd01_Click(sender, e)  ' fire up random 0 or 1

            Console.WriteLine("Checking domain " & txtDomain.Text)
            stat01.Text = "Checking domain " & txtDomain.Text

            Snooze(2)
            If iStopper = 1 Then Exit Sub
            GoTo CheckDomain
        End If

        ToCom_Click(sender, e)   'change to dot com
        Console.WriteLine("Changing extension, checking " & txtDomain.Text)
        stat01.Text = "Changing extension, checking " & txtDomain.Text

        Snooze(2)
        If iStopper = 1 Then Exit Sub
        GoTo CheckDomain

        ' first get random domain   [done]
        ' check if it's valid       [done]
        ' if valid (sSuccess message in status box) [done], then get exit[done]/get another random domain [not done]
        ' if not valid, check extension [done]
        ' if ext is not dot com, change to dot com and check again [done]
        ' if it is dot com, then randomly choose to minus one OR minus random and check again [done]

        ' ** note: check if same name is checked a second time... if it is, get new domain... it might be a loop

    End Sub

    Private Sub chkDebug_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebug.CheckedChanged
        Dim frmForm As Form
        frmForm = Me
        checkDebugMode(frmForm)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        iStopper = 1                    ' change iStopper to stop program
        stat01.Text = "STOPPING ... PLEASE WAIT ..."
        Snooze(5)
        stat01.Text = "READY"
        lblName.Text = sLblName
        btnStop.Enabled = False
        btnStart.Enabled = True
        chkDebug.Enabled = True
        lblLoopCheck.Text = ""
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            Me.ni.Visible = True
        End If
    End Sub

    Private Sub ni_Click(sender As Object, e As MouseEventArgs) Handles ni.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.ni.Visible = False
    End Sub

    Private Sub Rnd01_Click(sender As Object, e As EventArgs) Handles Rnd01.Click
        Dim iRnd As Integer
        iRnd = myRandom(0, 1)           ' random choice between 0 and 1

        If iRnd = 0 Then                ' minus rand
            MinusRand_Click(sender, e)
        End If
        MinusOne_Click(sender, e)       ' minus one
    End Sub

    Private Sub Snooze(ByVal seconds As Integer)
        Console.WriteLine("In the snooze")
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

End Class
