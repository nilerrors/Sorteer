<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lstSelection = New System.Windows.Forms.ListBox()
        Me.btnSorteer = New System.Windows.Forms.Button()
        Me.lblTijdSelection = New System.Windows.Forms.Label()
        Me.lblTijdBubble = New System.Windows.Forms.Label()
        Me.lstBubble = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTijdRipple = New System.Windows.Forms.Label()
        Me.lstRipple = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTijdInsertion = New System.Windows.Forms.Label()
        Me.lstInsertion = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTijdMerge = New System.Windows.Forms.Label()
        Me.lstMerge = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selection"
        '
        'lstSelection
        '
        Me.lstSelection.FormattingEnabled = True
        Me.lstSelection.Location = New System.Drawing.Point(15, 25)
        Me.lstSelection.Name = "lstSelection"
        Me.lstSelection.Size = New System.Drawing.Size(48, 264)
        Me.lstSelection.TabIndex = 1
        '
        'btnSorteer
        '
        Me.btnSorteer.Location = New System.Drawing.Point(207, 320)
        Me.btnSorteer.Name = "btnSorteer"
        Me.btnSorteer.Size = New System.Drawing.Size(75, 23)
        Me.btnSorteer.TabIndex = 2
        Me.btnSorteer.Text = "Sorteer"
        Me.btnSorteer.UseVisualStyleBackColor = True
        '
        'lblTijdSelection
        '
        Me.lblTijdSelection.AutoSize = True
        Me.lblTijdSelection.Location = New System.Drawing.Point(12, 292)
        Me.lblTijdSelection.Name = "lblTijdSelection"
        Me.lblTijdSelection.Size = New System.Drawing.Size(0, 13)
        Me.lblTijdSelection.TabIndex = 3
        '
        'lblTijdBubble
        '
        Me.lblTijdBubble.AutoSize = True
        Me.lblTijdBubble.Location = New System.Drawing.Point(116, 292)
        Me.lblTijdBubble.Name = "lblTijdBubble"
        Me.lblTijdBubble.Size = New System.Drawing.Size(0, 13)
        Me.lblTijdBubble.TabIndex = 6
        '
        'lstBubble
        '
        Me.lstBubble.FormattingEnabled = True
        Me.lstBubble.Location = New System.Drawing.Point(119, 25)
        Me.lstBubble.Name = "lstBubble"
        Me.lstBubble.Size = New System.Drawing.Size(48, 264)
        Me.lstBubble.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bubble"
        '
        'lblTijdRipple
        '
        Me.lblTijdRipple.AutoSize = True
        Me.lblTijdRipple.Location = New System.Drawing.Point(221, 292)
        Me.lblTijdRipple.Name = "lblTijdRipple"
        Me.lblTijdRipple.Size = New System.Drawing.Size(0, 13)
        Me.lblTijdRipple.TabIndex = 9
        '
        'lstRipple
        '
        Me.lstRipple.FormattingEnabled = True
        Me.lstRipple.Location = New System.Drawing.Point(224, 25)
        Me.lstRipple.Name = "lstRipple"
        Me.lstRipple.Size = New System.Drawing.Size(48, 264)
        Me.lstRipple.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ripple"
        '
        'lblTijdInsertion
        '
        Me.lblTijdInsertion.AutoSize = True
        Me.lblTijdInsertion.Location = New System.Drawing.Point(329, 292)
        Me.lblTijdInsertion.Name = "lblTijdInsertion"
        Me.lblTijdInsertion.Size = New System.Drawing.Size(0, 13)
        Me.lblTijdInsertion.TabIndex = 12
        '
        'lstInsertion
        '
        Me.lstInsertion.FormattingEnabled = True
        Me.lstInsertion.Location = New System.Drawing.Point(332, 25)
        Me.lstInsertion.Name = "lstInsertion"
        Me.lstInsertion.Size = New System.Drawing.Size(48, 264)
        Me.lstInsertion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(329, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Insertion"
        '
        'lblTijdMerge
        '
        Me.lblTijdMerge.AutoSize = True
        Me.lblTijdMerge.Location = New System.Drawing.Point(434, 292)
        Me.lblTijdMerge.Name = "lblTijdMerge"
        Me.lblTijdMerge.Size = New System.Drawing.Size(0, 13)
        Me.lblTijdMerge.TabIndex = 15
        '
        'lstMerge
        '
        Me.lstMerge.FormattingEnabled = True
        Me.lstMerge.Location = New System.Drawing.Point(437, 25)
        Me.lstMerge.Name = "lstMerge"
        Me.lstMerge.Size = New System.Drawing.Size(48, 264)
        Me.lstMerge.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(434, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Merge"
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnSorteer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 351)
        Me.Controls.Add(Me.lblTijdMerge)
        Me.Controls.Add(Me.lstMerge)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTijdInsertion)
        Me.Controls.Add(Me.lstInsertion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTijdRipple)
        Me.Controls.Add(Me.lstRipple)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTijdBubble)
        Me.Controls.Add(Me.lstBubble)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTijdSelection)
        Me.Controls.Add(Me.btnSorteer)
        Me.Controls.Add(Me.lstSelection)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Sorteer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstSelection As ListBox
    Friend WithEvents btnSorteer As Button
    Friend WithEvents lblTijdSelection As Label
    Friend WithEvents lblTijdBubble As Label
    Friend WithEvents lstBubble As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTijdRipple As Label
    Friend WithEvents lstRipple As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTijdInsertion As Label
    Friend WithEvents lstInsertion As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTijdMerge As Label
    Friend WithEvents lstMerge As ListBox
    Friend WithEvents Label9 As Label
End Class
