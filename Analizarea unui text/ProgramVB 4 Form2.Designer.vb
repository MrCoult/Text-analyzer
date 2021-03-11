<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.ListCuvinte = New System.Windows.Forms.ListBox()
        Me.ListPropozitii = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListCuvinte
        '
        Me.ListCuvinte.FormattingEnabled = True
        Me.ListCuvinte.Location = New System.Drawing.Point(12, 12)
        Me.ListCuvinte.Name = "ListCuvinte"
        Me.ListCuvinte.Size = New System.Drawing.Size(277, 160)
        Me.ListCuvinte.TabIndex = 0
        '
        'ListPropozitii
        '
        Me.ListPropozitii.FormattingEnabled = True
        Me.ListPropozitii.Location = New System.Drawing.Point(12, 178)
        Me.ListPropozitii.Name = "ListPropozitii"
        Me.ListPropozitii.Size = New System.Drawing.Size(277, 186)
        Me.ListPropozitii.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(295, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 352)
        Me.TextBox1.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 380)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListPropozitii)
        Me.Controls.Add(Me.ListCuvinte)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListCuvinte As ListBox
    Friend WithEvents ListPropozitii As ListBox
    Friend WithEvents TextBox1 As TextBox
End Class
