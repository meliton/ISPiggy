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

        lblName.Text = "Random domain: "
        btnIndicator.BackColor = Color.Green

    End Sub

    Private Sub RandomName_Click(sender As Object, e As EventArgs) Handles RandomName.Click
        Dim intTestOdd As Integer
        Dim strWeb As String

        intTestOdd = myRandom(iMinDomain, iMaxDomain)
        isOdd(intTestOdd)

        strWeb = makeDomainName()

        lblName.Text = "Random domain: " & strWeb
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
        btnStart.Enabled = False
        ToolStripStatusLabel1.Text = "Starting ..."     ' call timed algorithm HERE!

        RandomName_Click(sender, e)         ' first get random domain

        If txtDomain.Text = "" Then
            RandomName_Click(sender, e)     ' resend RandomName
        Else
            DoGetHostEntry(txtDomain.Text)  ' check name against DNS server
        End If

        ' first get random domain   [done]
        ' check if it's valid       [done]
        ' if valid, then get exit/get another random domain
        ' if not valid, check extension
        ' if ext is not dot com, change to dot com and check again
        ' if it is dot com, then randomly choose to minus one OR minus random and check again

        ' !!!! NEED TO FLOWCHART THIS SHIZNAZ!!!!!

    End Sub

    Private Sub chkDebug_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebug.CheckedChanged
        Dim frmForm As Form
        frmForm = Me
        checkDebugMode(frmForm)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        ToolStripStatusLabel1.Text = "Stopping ..."
        ' call cleanup algorithm HERE!
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
End Class
