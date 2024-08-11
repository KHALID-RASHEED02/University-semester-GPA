<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GPA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxgr01 = New System.Windows.Forms.TextBox()
        Me.boxgr02 = New System.Windows.Forms.TextBox()
        Me.boxgr03 = New System.Windows.Forms.TextBox()
        Me.Combhu01 = New System.Windows.Forms.ComboBox()
        Me.Combhu02 = New System.Windows.Forms.ComboBox()
        Me.Combhu03 = New System.Windows.Forms.ComboBox()
        Me.Laresult = New System.Windows.Forms.Label()
        Me.Butresult = New System.Windows.Forms.Button()
        Me.gradeof5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "المقرر"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "الدرجة المئوية"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ساعات المقرر"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "المقرر الاول" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "المقرر الثاني " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "المقرر الثالث" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'boxgr01
        '
        Me.boxgr01.Location = New System.Drawing.Point(198, 80)
        Me.boxgr01.Name = "boxgr01"
        Me.boxgr01.Size = New System.Drawing.Size(100, 23)
        Me.boxgr01.TabIndex = 6
        '
        'boxgr02
        '
        Me.boxgr02.Location = New System.Drawing.Point(198, 130)
        Me.boxgr02.Name = "boxgr02"
        Me.boxgr02.Size = New System.Drawing.Size(100, 23)
        Me.boxgr02.TabIndex = 7
        '
        'boxgr03
        '
        Me.boxgr03.Location = New System.Drawing.Point(198, 189)
        Me.boxgr03.Name = "boxgr03"
        Me.boxgr03.Size = New System.Drawing.Size(100, 23)
        Me.boxgr03.TabIndex = 8
        '
        'Combhu01
        '
        Me.Combhu01.FormattingEnabled = True
        Me.Combhu01.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.Combhu01.Location = New System.Drawing.Point(39, 80)
        Me.Combhu01.Name = "Combhu01"
        Me.Combhu01.Size = New System.Drawing.Size(121, 23)
        Me.Combhu01.TabIndex = 9
        '
        'Combhu02
        '
        Me.Combhu02.FormattingEnabled = True
        Me.Combhu02.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.Combhu02.Location = New System.Drawing.Point(39, 130)
        Me.Combhu02.Name = "Combhu02"
        Me.Combhu02.Size = New System.Drawing.Size(121, 23)
        Me.Combhu02.TabIndex = 10
        '
        'Combhu03
        '
        Me.Combhu03.FormattingEnabled = True
        Me.Combhu03.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.Combhu03.Location = New System.Drawing.Point(39, 189)
        Me.Combhu03.Name = "Combhu03"
        Me.Combhu03.Size = New System.Drawing.Size(121, 23)
        Me.Combhu03.TabIndex = 11
        '
        'Laresult
        '
        Me.Laresult.AutoSize = True
        Me.Laresult.Location = New System.Drawing.Point(231, 295)
        Me.Laresult.Name = "Laresult"
        Me.Laresult.Size = New System.Drawing.Size(41, 15)
        Me.Laresult.TabIndex = 12
        Me.Laresult.Text = "Label7"
        '
        'Butresult
        '
        Me.Butresult.Location = New System.Drawing.Point(347, 295)
        Me.Butresult.Name = "Butresult"
        Me.Butresult.Size = New System.Drawing.Size(75, 23)
        Me.Butresult.TabIndex = 13
        Me.Butresult.Text = "Button1"
        Me.Butresult.UseVisualStyleBackColor = True
        '
        'gradeof5
        '
        Me.gradeof5.AutoSize = True
        Me.gradeof5.Location = New System.Drawing.Point(73, 295)
        Me.gradeof5.Name = "gradeof5"
        Me.gradeof5.Size = New System.Drawing.Size(41, 15)
        Me.gradeof5.TabIndex = 14
        Me.gradeof5.Text = "Label7"
        '
        'GPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(447, 342)
        Me.Controls.Add(Me.gradeof5)
        Me.Controls.Add(Me.Butresult)
        Me.Controls.Add(Me.Laresult)
        Me.Controls.Add(Me.Combhu03)
        Me.Controls.Add(Me.Combhu02)
        Me.Controls.Add(Me.Combhu01)
        Me.Controls.Add(Me.boxgr03)
        Me.Controls.Add(Me.boxgr02)
        Me.Controls.Add(Me.boxgr01)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GPA"
        Me.Text = "GPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents boxgr01 As TextBox
    Friend WithEvents boxgr02 As TextBox
    Friend WithEvents boxgr03 As TextBox
    Friend WithEvents Combhu01 As ComboBox
    Friend WithEvents Combhu02 As ComboBox
    Friend WithEvents Combhu03 As ComboBox
    Friend WithEvents Laresult As Label
    Friend WithEvents Butresult As Button
    Friend WithEvents gradeof5 As Label
End Class
