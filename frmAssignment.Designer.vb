<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssignment
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCreateAssignments = New System.Windows.Forms.Button()
        Me.lblTotalExpertise = New System.Windows.Forms.Label()
        Me.txtTotalExpertise = New System.Windows.Forms.TextBox()
        Me.lblMechanic = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lstboxMechanic = New System.Windows.Forms.ListBox()
        Me.lstboxBrand = New System.Windows.Forms.ListBox()
        Me.txtAssignment = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(557, 54)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(587, 46)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Good Service Auto Mechanics"
        '
        'btnCreateAssignments
        '
        Me.btnCreateAssignments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAssignments.Location = New System.Drawing.Point(554, 143)
        Me.btnCreateAssignments.Name = "btnCreateAssignments"
        Me.btnCreateAssignments.Size = New System.Drawing.Size(306, 76)
        Me.btnCreateAssignments.TabIndex = 1
        Me.btnCreateAssignments.Text = "Create Assignments"
        Me.btnCreateAssignments.UseVisualStyleBackColor = True
        '
        'lblTotalExpertise
        '
        Me.lblTotalExpertise.AutoSize = True
        Me.lblTotalExpertise.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpertise.Location = New System.Drawing.Point(949, 143)
        Me.lblTotalExpertise.Name = "lblTotalExpertise"
        Me.lblTotalExpertise.Size = New System.Drawing.Size(205, 32)
        Me.lblTotalExpertise.TabIndex = 2
        Me.lblTotalExpertise.Text = "Total Expertise"
        Me.lblTotalExpertise.UseMnemonic = False
        '
        'txtTotalExpertise
        '
        Me.txtTotalExpertise.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalExpertise.Location = New System.Drawing.Point(954, 184)
        Me.txtTotalExpertise.Name = "txtTotalExpertise"
        Me.txtTotalExpertise.Size = New System.Drawing.Size(200, 35)
        Me.txtTotalExpertise.TabIndex = 3
        '
        'lblMechanic
        '
        Me.lblMechanic.AutoSize = True
        Me.lblMechanic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMechanic.Location = New System.Drawing.Point(548, 245)
        Me.lblMechanic.Name = "lblMechanic"
        Me.lblMechanic.Size = New System.Drawing.Size(145, 32)
        Me.lblMechanic.TabIndex = 4
        Me.lblMechanic.Text = "Mechanic"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(886, 245)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(96, 32)
        Me.lblBrand.TabIndex = 5
        Me.lblBrand.Text = "Brand"
        '
        'lstboxMechanic
        '
        Me.lstboxMechanic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxMechanic.FormattingEnabled = True
        Me.lstboxMechanic.ItemHeight = 29
        Me.lstboxMechanic.Location = New System.Drawing.Point(554, 298)
        Me.lstboxMechanic.Name = "lstboxMechanic"
        Me.lstboxMechanic.Size = New System.Drawing.Size(247, 352)
        Me.lstboxMechanic.TabIndex = 6
        '
        'lstboxBrand
        '
        Me.lstboxBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxBrand.FormattingEnabled = True
        Me.lstboxBrand.ItemHeight = 29
        Me.lstboxBrand.Location = New System.Drawing.Point(892, 298)
        Me.lstboxBrand.Name = "lstboxBrand"
        Me.lstboxBrand.Size = New System.Drawing.Size(262, 352)
        Me.lstboxBrand.TabIndex = 7
        '
        'txtAssignment
        '
        Me.txtAssignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssignment.Location = New System.Drawing.Point(554, 681)
        Me.txtAssignment.Name = "txtAssignment"
        Me.txtAssignment.Size = New System.Drawing.Size(600, 41)
        Me.txtAssignment.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Homework4.My.Resources.Resources.car_service_and_maintenance_P3S4PPQ
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(516, 774)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 768)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAssignment)
        Me.Controls.Add(Me.lstboxBrand)
        Me.Controls.Add(Me.lstboxMechanic)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblMechanic)
        Me.Controls.Add(Me.txtTotalExpertise)
        Me.Controls.Add(Me.lblTotalExpertise)
        Me.Controls.Add(Me.btnCreateAssignments)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAssignment"
        Me.Text = "Optimal Mechanic Assignments"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCreateAssignments As Button
    Friend WithEvents lblTotalExpertise As Label
    Friend WithEvents txtTotalExpertise As TextBox
    Friend WithEvents lblMechanic As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lstboxMechanic As ListBox
    Friend WithEvents lstboxBrand As ListBox
    Friend WithEvents txtAssignment As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
