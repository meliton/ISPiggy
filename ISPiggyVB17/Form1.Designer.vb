<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RandomName = New System.Windows.Forms.Button()
        Me.GetIP = New System.Windows.Forms.Button()
        Me.ToCom = New System.Windows.Forms.Button()
        Me.MinusRand = New System.Windows.Forms.Button()
        Me.MinusOne = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtDomain = New System.Windows.Forms.TextBox()
        Me.btnIndicator = New System.Windows.Forms.Button()
        Me.chkDebug = New System.Windows.Forms.CheckBox()
        Me.ni = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Rnd01 = New System.Windows.Forms.Button()
        Me.stat1 = New System.Windows.Forms.StatusStrip()
        Me.stat01 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblLoopCheck = New System.Windows.Forms.Label()
        Me.stat1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RandomName
        '
        Me.RandomName.Location = New System.Drawing.Point(341, 29)
        Me.RandomName.Name = "RandomName"
        Me.RandomName.Size = New System.Drawing.Size(70, 23)
        Me.RandomName.TabIndex = 0
        Me.RandomName.Text = "RndName"
        Me.RandomName.UseVisualStyleBackColor = True
        '
        'GetIP
        '
        Me.GetIP.Location = New System.Drawing.Point(417, 59)
        Me.GetIP.Name = "GetIP"
        Me.GetIP.Size = New System.Drawing.Size(70, 23)
        Me.GetIP.TabIndex = 1
        Me.GetIP.Text = "Get IP"
        Me.GetIP.UseVisualStyleBackColor = True
        '
        'ToCom
        '
        Me.ToCom.Location = New System.Drawing.Point(417, 29)
        Me.ToCom.Name = "ToCom"
        Me.ToCom.Size = New System.Drawing.Size(70, 23)
        Me.ToCom.TabIndex = 2
        Me.ToCom.Text = "ToCom"
        Me.ToCom.UseVisualStyleBackColor = True
        '
        'MinusRand
        '
        Me.MinusRand.Location = New System.Drawing.Point(487, 31)
        Me.MinusRand.Name = "MinusRand"
        Me.MinusRand.Size = New System.Drawing.Size(70, 23)
        Me.MinusRand.TabIndex = 3
        Me.MinusRand.Text = "Minus Rnd"
        Me.MinusRand.UseVisualStyleBackColor = True
        '
        'MinusOne
        '
        Me.MinusOne.Location = New System.Drawing.Point(487, 5)
        Me.MinusOne.Name = "MinusOne"
        Me.MinusOne.Size = New System.Drawing.Size(70, 23)
        Me.MinusOne.TabIndex = 4
        Me.MinusOne.Text = "Minus One"
        Me.MinusOne.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 29)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 53)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(107, 29)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 53)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(9, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 16)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "lblName"
        '
        'txtDomain
        '
        Me.txtDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomain.Location = New System.Drawing.Point(330, 5)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(151, 21)
        Me.txtDomain.TabIndex = 9
        '
        'btnIndicator
        '
        Me.btnIndicator.Location = New System.Drawing.Point(211, 5)
        Me.btnIndicator.Name = "btnIndicator"
        Me.btnIndicator.Size = New System.Drawing.Size(88, 28)
        Me.btnIndicator.TabIndex = 10
        Me.btnIndicator.UseVisualStyleBackColor = True
        '
        'chkDebug
        '
        Me.chkDebug.AutoSize = True
        Me.chkDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDebug.Location = New System.Drawing.Point(236, 39)
        Me.chkDebug.Name = "chkDebug"
        Me.chkDebug.Size = New System.Drawing.Size(63, 19)
        Me.chkDebug.TabIndex = 12
        Me.chkDebug.Text = "Debug"
        Me.chkDebug.UseVisualStyleBackColor = True
        '
        'ni
        '
        Me.ni.Icon = CType(resources.GetObject("ni.Icon"), System.Drawing.Icon)
        Me.ni.Text = "ISPiggy"
        Me.ni.Visible = True
        '
        'Rnd01
        '
        Me.Rnd01.Location = New System.Drawing.Point(487, 59)
        Me.Rnd01.Name = "Rnd01"
        Me.Rnd01.Size = New System.Drawing.Size(70, 23)
        Me.Rnd01.TabIndex = 13
        Me.Rnd01.Text = "Rnd 0 or 1"
        Me.Rnd01.UseVisualStyleBackColor = True
        '
        'stat1
        '
        Me.stat1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stat01})
        Me.stat1.Location = New System.Drawing.Point(0, 90)
        Me.stat1.Name = "stat1"
        Me.stat1.Size = New System.Drawing.Size(564, 22)
        Me.stat1.TabIndex = 15
        Me.stat1.Text = "Stat1"
        '
        'stat01
        '
        Me.stat01.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stat01.Name = "stat01"
        Me.stat01.Size = New System.Drawing.Size(43, 17)
        Me.stat01.Text = "stat01"
        '
        'lblLoopCheck
        '
        Me.lblLoopCheck.AutoSize = True
        Me.lblLoopCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoopCheck.Location = New System.Drawing.Point(193, 69)
        Me.lblLoopCheck.Name = "lblLoopCheck"
        Me.lblLoopCheck.Size = New System.Drawing.Size(91, 16)
        Me.lblLoopCheck.TabIndex = 16
        Me.lblLoopCheck.Text = "lblLoopCheck"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 112)
        Me.Controls.Add(Me.lblLoopCheck)
        Me.Controls.Add(Me.stat1)
        Me.Controls.Add(Me.Rnd01)
        Me.Controls.Add(Me.chkDebug)
        Me.Controls.Add(Me.btnIndicator)
        Me.Controls.Add(Me.txtDomain)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.MinusOne)
        Me.Controls.Add(Me.MinusRand)
        Me.Controls.Add(Me.ToCom)
        Me.Controls.Add(Me.GetIP)
        Me.Controls.Add(Me.RandomName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.stat1.ResumeLayout(False)
        Me.stat1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RandomName As Button
    Friend WithEvents GetIP As Button
    Friend WithEvents ToCom As Button
    Friend WithEvents MinusRand As Button
    Friend WithEvents MinusOne As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtDomain As TextBox
    Friend WithEvents btnIndicator As Button
    Friend WithEvents chkDebug As CheckBox
    Friend WithEvents ni As NotifyIcon
    Friend WithEvents Rnd01 As Button
    Friend WithEvents stat1 As StatusStrip
    Friend WithEvents stat01 As ToolStripStatusLabel
    Friend WithEvents lblLoopCheck As Label
End Class
