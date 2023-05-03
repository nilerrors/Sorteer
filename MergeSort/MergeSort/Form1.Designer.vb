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
        btnSorteer = New Button()
        lstGetallen = New ListBox()
        SuspendLayout()
        ' 
        ' btnSorteer
        ' 
        btnSorteer.Location = New Point(192, 89)
        btnSorteer.Name = "btnSorteer"
        btnSorteer.Size = New Size(75, 23)
        btnSorteer.TabIndex = 1
        btnSorteer.Text = "Sorteer"
        btnSorteer.UseVisualStyleBackColor = True
        ' 
        ' lstGetallen
        ' 
        lstGetallen.FormattingEnabled = True
        lstGetallen.ItemHeight = 15
        lstGetallen.Location = New Point(12, 12)
        lstGetallen.Name = "lstGetallen"
        lstGetallen.Size = New Size(120, 184)
        lstGetallen.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstGetallen)
        Controls.Add(btnSorteer)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSorteer As Button
    Friend WithEvents lstGetallen As ListBox
End Class
