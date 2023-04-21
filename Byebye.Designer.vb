<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Byebye
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.veggies = New System.Windows.Forms.Button()
        Me.icedTea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(44, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Again, thank you!"
        '
        'veggies
        '
        Me.veggies.BackColor = System.Drawing.Color.Orange
        Me.veggies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.veggies.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.veggies.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.veggies.Location = New System.Drawing.Point(75, 120)
        Me.veggies.Name = "veggies"
        Me.veggies.Size = New System.Drawing.Size(102, 49)
        Me.veggies.TabIndex = 12
        Me.veggies.Text = "Go Back"
        Me.veggies.UseVisualStyleBackColor = False
        '
        'icedTea
        '
        Me.icedTea.BackColor = System.Drawing.Color.Chocolate
        Me.icedTea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.icedTea.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icedTea.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.icedTea.Location = New System.Drawing.Point(192, 120)
        Me.icedTea.Name = "icedTea"
        Me.icedTea.Size = New System.Drawing.Size(102, 49)
        Me.icedTea.TabIndex = 15
        Me.icedTea.Text = "Close"
        Me.icedTea.UseVisualStyleBackColor = False
        '
        'Byebye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(372, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.icedTea)
        Me.Controls.Add(Me.veggies)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Byebye"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Joshua Ruiz's Mid Term submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents veggies As Button
    Friend WithEvents icedTea As Button
End Class
