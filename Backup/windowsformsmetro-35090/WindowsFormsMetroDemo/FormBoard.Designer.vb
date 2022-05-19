<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBoard
    Inherits System.Windows.Forms.Metro.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TBoard1 = New System.Windows.Forms.Metro.TBoard()
        Me.NavegationBar1 = New WindowsFormsMetroDemo.NavegationBar()
        Me.SuspendLayout()
        '
        'TBoard1
        '
        Me.TBoard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBoard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBoard1.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoard1.ForeColor = System.Drawing.Color.DimGray
        Me.TBoard1.Location = New System.Drawing.Point(2, 81)
        Me.TBoard1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TBoard1.Name = "TBoard1"
        Me.TBoard1.Size = New System.Drawing.Size(476, 245)
        Me.TBoard1.States = New String() {"Waiting", "Tech", "Jobs", "Completed"}
        Me.TBoard1.StatesColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        Me.TBoard1.TabIndex = 10
        '
        'NavegationBar1
        '
        Me.NavegationBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NavegationBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavegationBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavegationBar1.ForeColor = System.Drawing.Color.White
        Me.NavegationBar1.Location = New System.Drawing.Point(2, 30)
        Me.NavegationBar1.Name = "NavegationBar1"
        Me.NavegationBar1.Padding = New System.Windows.Forms.Padding(8)
        Me.NavegationBar1.Size = New System.Drawing.Size(476, 51)
        Me.NavegationBar1.TabIndex = 11
        '
        'FormBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 328)
        Me.Controls.Add(Me.TBoard1)
        Me.Controls.Add(Me.NavegationBar1)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MinimumSize = New System.Drawing.Size(180, 112)
        Me.Name = "FormBoard"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "System Windows Forms Metro Task Board"
        Me.Controls.SetChildIndex(Me.NavegationBar1, 0)
        Me.Controls.SetChildIndex(Me.TBoard1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBoard1 As System.Windows.Forms.Metro.TBoard
    Friend WithEvents NavegationBar1 As WindowsFormsMetroDemo.NavegationBar
End Class
