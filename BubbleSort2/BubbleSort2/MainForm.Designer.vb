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
        Me.lstGetallen = New System.Windows.Forms.ListBox()
        Me.btnSorteer = New System.Windows.Forms.Button()
        Me.txtBerg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstGetallen
        '
        Me.lstGetallen.FormattingEnabled = True
        Me.lstGetallen.Location = New System.Drawing.Point(12, 12)
        Me.lstGetallen.Name = "lstGetallen"
        Me.lstGetallen.Size = New System.Drawing.Size(626, 381)
        Me.lstGetallen.TabIndex = 0
        '
        'btnSorteer
        '
        Me.btnSorteer.Location = New System.Drawing.Point(12, 415)
        Me.btnSorteer.Name = "btnSorteer"
        Me.btnSorteer.Size = New System.Drawing.Size(1094, 23)
        Me.btnSorteer.TabIndex = 1
        Me.btnSorteer.Text = "Sorteer"
        Me.btnSorteer.UseVisualStyleBackColor = True
        '
        'txtBerg
        '
        Me.txtBerg.Font = New System.Drawing.Font("Courier New", 6.0!)
        Me.txtBerg.Location = New System.Drawing.Point(656, 12)
        Me.txtBerg.Multiline = True
        Me.txtBerg.Name = "txtBerg"
        Me.txtBerg.ReadOnly = True
        Me.txtBerg.Size = New System.Drawing.Size(450, 381)
        Me.txtBerg.TabIndex = 2
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnSorteer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 456)
        Me.Controls.Add(Me.txtBerg)
        Me.Controls.Add(Me.btnSorteer)
        Me.Controls.Add(Me.lstGetallen)
        Me.Name = "MainForm"
        Me.Text = "Bubble Sort 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGetallen As ListBox
    Friend WithEvents btnSorteer As Button
    Friend WithEvents txtBerg As TextBox
End Class
