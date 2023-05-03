<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RippleSort
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
        lstNamen = New ListBox()
        btnSorteer = New Button()
        SuspendLayout()
        ' 
        ' lstNamen
        ' 
        lstNamen.FormattingEnabled = True
        lstNamen.ItemHeight = 15
        lstNamen.Location = New Point(12, 12)
        lstNamen.Name = "lstNamen"
        lstNamen.Size = New Size(120, 184)
        lstNamen.TabIndex = 0
        ' 
        ' btnSorteer
        ' 
        btnSorteer.Location = New Point(138, 12)
        btnSorteer.Name = "btnSorteer"
        btnSorteer.Size = New Size(75, 23)
        btnSorteer.TabIndex = 1
        btnSorteer.Text = "Sorteer"
        btnSorteer.UseVisualStyleBackColor = True
        ' 
        ' RippleSort
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSorteer)
        Controls.Add(lstNamen)
        Name = "RippleSort"
        Text = "Ripple Sort"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstNamen As ListBox
    Friend WithEvents btnSorteer As Button
End Class