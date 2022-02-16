<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Boton1 = New System.Windows.Forms.Button()
        Me.Texto1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Boton2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Texto2 = New System.Windows.Forms.TextBox()
        Me.Link1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Boton1
        '
        Me.Boton1.BackColor = System.Drawing.Color.DarkOrange
        Me.Boton1.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.Location = New System.Drawing.Point(226, 173)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(125, 48)
        Me.Boton1.TabIndex = 0
        Me.Boton1.Text = "Factorial"
        Me.Boton1.UseVisualStyleBackColor = False
        '
        'Texto1
        '
        Me.Texto1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Texto1.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto1.Location = New System.Drawing.Point(187, 129)
        Me.Texto1.Name = "Texto1"
        Me.Texto1.Size = New System.Drawing.Size(377, 28)
        Me.Texto1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(210, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Factorial de un número"
        '
        'Boton2
        '
        Me.Boton2.BackColor = System.Drawing.Color.LightCoral
        Me.Boton2.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton2.Location = New System.Drawing.Point(383, 173)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(125, 48)
        Me.Boton2.TabIndex = 3
        Me.Boton2.Text = "Limpiar "
        Me.Boton2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(286, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 35)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Respuesta"
        '
        'Texto2
        '
        Me.Texto2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto2.Location = New System.Drawing.Point(314, 271)
        Me.Texto2.Name = "Texto2"
        Me.Texto2.Size = New System.Drawing.Size(100, 30)
        Me.Texto2.TabIndex = 6
        '
        'Link1
        '
        Me.Link1.AutoSize = True
        Me.Link1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link1.Location = New System.Drawing.Point(297, 315)
        Me.Link1.Name = "Link1"
        Me.Link1.Size = New System.Drawing.Size(148, 20)
        Me.Link1.TabIndex = 7
        Me.Link1.TabStop = True
        Me.Link1.Text = "GitHub_TareaNo.4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(494, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 43)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "201800988"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Link1)
        Me.Controls.Add(Me.Texto2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Boton2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Texto1)
        Me.Controls.Add(Me.Boton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Boton1 As Button
    Friend WithEvents Texto1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Boton2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Texto2 As TextBox
    Friend WithEvents Link1 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
