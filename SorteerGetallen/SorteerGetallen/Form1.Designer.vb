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
        lstGetallen = New ListBox()
        btnSorteren = New Button()
        SuspendLayout()
        ' 
        ' lstGetallen
        ' 
        lstGetallen.FormattingEnabled = True
        lstGetallen.ItemHeight = 15
        lstGetallen.Location = New Point(12, 12)
        lstGetallen.Name = "lstGetallen"
        lstGetallen.Size = New Size(120, 94)
        lstGetallen.TabIndex = 0
        ' 
        ' btnSorteren
        ' 
        btnSorteren.Location = New Point(138, 12)
        btnSorteren.Name = "btnSorteren"
        btnSorteren.Size = New Size(75, 23)
        btnSorteren.TabIndex = 1
        btnSorteren.Text = "Sorteren"
        btnSorteren.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(226, 116)
        Controls.Add(btnSorteren)
        Controls.Add(lstGetallen)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstGetallen As ListBox
    Friend WithEvents btnSorteren As Button
End Class
