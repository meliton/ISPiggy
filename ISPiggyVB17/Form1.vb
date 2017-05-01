Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = sTitle
        chkDebug.Checked = False
        MaximizeBox = False                 ' disable maximize button
        ni.Visible = False

        Dim frmForm As Form                 ' checks the status of chkDebug
        frmForm = Me
        checkDebugMode(frmForm)

        Randomize()
        cleanStart()
    End Sub

    Private Sub RandomName_Click(sender As Object, e As EventArgs) Handles RandomName.Click
        Dim strWeb As String
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
    Private Sub chkDebug_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebug.CheckedChanged
        Dim frmForm As Form
        frmForm = Me
        checkDebugMode(frmForm)
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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        iStopper = 0                ' global stopper set to loop
        btnStart.Enabled = False
        btnStop.Enabled = True
        chkDebug.Enabled = False    ' disable debugging

GetDomain:                          ' get random domain
        Dim strWeb As String
        strWeb = makeDomainName()
        lblName.Text = sLblName & strWeb
        txtDomain.Text = strWeb

CheckDomain:
        ' loop check for unresolvable small domains
        If lblLoopCheck.Text = txtDomain.Text Then GoTo GetDomain
        lblLoopCheck.Text = txtDomain.Text  ' set them equal

        DoGetHostEntry(txtDomain.Text)      ' check name against DNS server

        Dim sToolMsg As String = stat01.Text
        sToolMsg = Microsoft.VisualBasic.Left(sToolMsg, 7)

        If sToolMsg = "Success" Then
            Console.WriteLine("Success! Getting next random name")
            Console.WriteLine(stat01.Text)

            Snooze(5)                       ' wait for 5 seconds
            If iStopper = 1 Then Exit Sub
            GoTo GetDomain
        End If

        stat01.Text = "Invalid domain, checking extension..."
        Console.WriteLine(stat01.Text)

        Dim sDomainCheck = txtDomain.Text
        sDomainCheck = Microsoft.VisualBasic.Right(sDomainCheck, 3)

        If sDomainCheck = "com" Then
            Rnd01_Click(sender, e)  ' fire up random 0 or 1

            stat01.Text = "Checking domain " & txtDomain.Text
            Console.WriteLine(stat01.Text)

            Snooze(3)                       ' wait for 3 seconds
            If iStopper = 1 Then Exit Sub
            GoTo CheckDomain
        End If

        ToCom_Click(sender, e)   'change to dot com
        stat01.Text = "Changing extension, checking " & txtDomain.Text
        Console.WriteLine(stat01.Text)

        Snooze(3)                           ' wait 3 seconds
        If iStopper = 1 Then Exit Sub
        GoTo CheckDomain

        ' Get random domain
        ' check if it's valid 
        ' if valid (sSuccess message in status box), then get exit/get another random domain
        ' if it's not valid, check extension
        ' if ext is not dot com, change to dot com and check again
        ' if it is dot com, then randomly choose to minus one OR minus random and check again
        ' ** note: check if same name is checked a second time... if it is, get new domain... it's in a loop
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        iStopper = 1                    ' change iStopper to stop program
        stat01.Text = "STOPPING ... PLEASE WAIT ..."
        ' ** TODO: We need to check if DNS is finished before givng control back to user ***
        GC.Collect()
        Snooze(5)
        chkDebug.Enabled = True

        cleanStart()
    End Sub

    Private Sub Rnd01_Click(sender As Object, e As EventArgs) Handles Rnd01.Click
        Dim iRnd As Integer
        iRnd = myRandom(0, 1)           ' random choice between 0 and 1

        If iRnd = 0 Then                ' minus rand
            MinusRand_Click(sender, e)
        End If
        MinusOne_Click(sender, e)       ' minus one
    End Sub

End Class
