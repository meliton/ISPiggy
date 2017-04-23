Imports System.Net
Module Common
    Public Const sTitle = "ISPiggy" ' title of program
    Public Const iMinDomain = 5     ' minimum word size for domain name
    Public Const iMaxDomain = 8     ' maximum word size for domain name

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
    ' Procedure : toDotCom
    ' Purpose   : replaces .org and .net extensions to .com
    ' How to Use: strVar = toDotCom (strVar)
    '---------------------------------------------------------------------------------------
    Public Function toDotCom(strToCom As String) As String
        Dim iLength As Integer
        Dim iDotLoc As Integer
        Dim iDomOnly As Integer
        Dim sDomOnly As String

        iLength = Len(strToCom)          ' get overall domain length

        iDotLoc = InStr(strToCom, ".")   ' get dot location in domain

        iDomOnly = (iLength - (iLength - iDotLoc + 1)) ' get size of domain

        If iDomOnly >= 2 Then               ' domain has at least two chars
            ' save only domain into variable and add .com
            sDomOnly = Mid(strToCom, 1, iDomOnly) & ".com"

            strToCom = sDomOnly

        End If

        toDotCom = strToCom

    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : makeDomainName
    ' Purpose   : makes a random Domain Name
    ' How to Use: strVar = makeDomainName ()
    '---------------------------------------------------------------------------------------
    Public Function makeDomainName() As String
        Dim sRandWeb As String
        Dim x As Integer

        Dim astrVowels() As String
        Dim astrConsonants() As String
        Dim astrTLDsuffix() As String

        astrVowels = {"a", "e", "i", "o", "u", "y"}
        astrConsonants = {"c", "d", "f", "h", "l", "m", "n", "r", "s", "t"}
        astrTLDsuffix = {".com", ".com", ".net", ".org"}

        sRandWeb = ""
        x = 0

        While (x < myRandom(iMinDomain, iMaxDomain))
            If (isOdd(x) = 1) Then
                sRandWeb = sRandWeb & astrVowels(myRandom(0, UBound(astrVowels)))
            Else
                sRandWeb = sRandWeb & astrConsonants(myRandom(0, UBound(astrConsonants)))
            End If
            x = x + 1
        End While

        Dim intDom As Integer       ' get random domain suffix
        intDom = myRandom(0, UBound(astrTLDsuffix))

        makeDomainName = sRandWeb & astrTLDsuffix(intDom)

    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : domainMinusOne
    ' Purpose   : shortens domain name by one char at the end
    ' How to Use: strVar = domainMinusOne (strVar)
    '---------------------------------------------------------------------------------------
    Public Function domainMinusOne(strDomain As String)
        Dim iLength As Integer
        Dim iDotLoc As Integer
        Dim iDomOnly As Integer
        Dim sDomOnly As String
        Dim sExtOnly As String

        iLength = Len(strDomain)          ' get overall domain length

        iDotLoc = InStr(strDomain, ".")   ' get dot location in domain

        iDomOnly = (iLength - (iLength - iDotLoc + 1)) ' get size of domain

        If iDomOnly >= 3 Then                     ' domain has at least two chars

            sDomOnly = Mid(strDomain, 1, iDomOnly)  ' save only domain into variable

            ' save extension into variable
            sExtOnly = Mid(strDomain, iDotLoc, iLength - iDotLoc + 1)

            ' remove last char in domain name and reassemble domain name
            sDomOnly = Mid(sDomOnly, 1, iDotLoc - 2) & sExtOnly

            strDomain = sDomOnly  ' puts new domain in passed domain variable

        End If

        domainMinusOne = strDomain

    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : domainMinusRand
    ' Purpose   : shortens domain name by one random char
    ' How to Use: strVar = domainMinusRand (strVar)
    '---------------------------------------------------------------------------------------
    Public Function domainMinusRand(strDomain As String)
        Dim iLength As Integer
        Dim iDotLoc As Integer
        Dim iDomOnly As Integer
        Dim iRndChar As Integer
        Dim sDomOnly As String
        Dim sExtOnly As String
        Dim sRndChar As String

        iLength = Len(strDomain)          ' get overall domain length

        iDotLoc = InStr(strDomain, ".")   ' get dot location in domain

        iDomOnly = (iLength - (iLength - iDotLoc + 1)) ' get size of domain

        If iDomOnly >= 3 Then                     ' domain has at least two chars

            sDomOnly = Mid(strDomain, 1, iDomOnly)  ' save only domain into variable

            ' save extension into variable
            sExtOnly = Mid(strDomain, iDotLoc, iLength - iDotLoc + 1)

            iRndChar = myRandom(1, iDomOnly)    ' get random char int location from domain length

            sRndChar = Mid(sDomOnly, iRndChar, 1) ' gets random char from domain

            ' remove char from domain and reassemble domain name
            sDomOnly = Replace(sDomOnly, sRndChar, "", , 1) & sExtOnly

            strDomain = sDomOnly  ' puts new domain in passed domain variable

        End If

        domainMinusRand = strDomain

    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : checkDebugMode
    ' Purpose   : checks status of debug mode and sets Form1 accordingly
    ' How to Use: strVar = checkDebugMode ()
    '---------------------------------------------------------------------------------------
    Public Function checkDebugMode(ByVal frm As Form)
        If Form1.chkDebug.Checked Then          ' we are in debug mode
            frm.Size = New Size(590, 150)               ' sets debug form size
            frm.MaximumSize = New Size(590, 150)        ' disables resizing up
            frm.MinimumSize = New Size(590, 150)        ' disables resizing down
            Form1.ToolStripStatusLabel1.Text = "Entering interactive DEBUG mode"

            Form1.btnStart.Enabled = False                ' disable stop and start buttons
            Form1.btnStop.Enabled = False

        Else                                    ' we are in production mode
            frm.Size = New Size(270, 150)               ' sets production form size
            frm.MaximumSize = New Size(270, 150)        ' disables resizing up
            frm.MinimumSize = New Size(270, 150)        ' disables resizing down
            Form1.ToolStripStatusLabel1.Text = "Press START to Begin"

            Form1.btnStart.Enabled = True                ' enable stop and start buttons
            Form1.btnStop.Enabled = True
            Form1.lblName.Text = "Random domain: "      ' resets domain text

        End If

        checkDebugMode = 0

    End Function

    Public Function DoGetHostEntry(hostName As String)
        Form1.btnIndicator.BackColor = Color.Red  ' visual wait indicator
        Form1.GetIP.Enabled = False       ' disable the button to avoid a double press
        Form1.ToolStripStatusLabel1.Text = "Working ..."
        Form1.Refresh()          'needed to paint the the shapes before next operation

        Try
            Dim host As IPHostEntry = Dns.GetHostEntry(hostName)
            Dim sMyString As String
            sMyString = ""

            ' Console.WriteLine("GetHostEntry(" + hostName + ") returns: ")

            Dim ip As IPAddress() = host.AddressList

            'Console.WriteLine(ip(0))   ' get first IP returned from DNS server
            sMyString = ip(0).ToString()
            Form1.ToolStripStatusLabel1.Text = "Success! " & sMyString & " Found!"

        Catch ex As System.Net.Sockets.SocketException
            Form1.ToolStripStatusLabel1.Text = ex.Message & "... trying next host..."
        Catch ex As System.Exception
            Form1.ToolStripStatusLabel1.Text = ex.Message
        Finally
        End Try

        Form1.btnIndicator.BackColor = Color.Green  ' visual indicator
        Form1.GetIP.Enabled = True

        DoGetHostEntry = ""
    End Function

End Module
