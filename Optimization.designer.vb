<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.btnSolve1 = New System.Windows.Forms.Button()
        Me.btnSolve2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSolve1
        '
        Me.btnSolve1.Location = New System.Drawing.Point(31, 38)
        Me.btnSolve1.Name = "btnSolve1"
        Me.btnSolve1.Size = New System.Drawing.Size(222, 97)
        Me.btnSolve1.TabIndex = 0
        Me.btnSolve1.Text = "Solve Example 1"
        Me.btnSolve1.UseVisualStyleBackColor = True
        '
        'btnSolve2
        '
        Me.btnSolve2.Location = New System.Drawing.Point(31, 153)
        Me.btnSolve2.Name = "btnSolve2"
        Me.btnSolve2.Size = New System.Drawing.Size(222, 97)
        Me.btnSolve2.TabIndex = 1
        Me.btnSolve2.Text = "Solve Example 2"
        Me.btnSolve2.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 450)
        Me.Controls.Add(Me.btnSolve2)
        Me.Controls.Add(Me.btnSolve1)
        Me.Name = "frmHome"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSolve1 As Button
    Friend WithEvents btnSolve2 As Button
End Class
