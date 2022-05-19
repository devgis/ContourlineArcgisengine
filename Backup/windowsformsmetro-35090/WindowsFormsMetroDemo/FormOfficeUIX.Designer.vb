<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOfficeUIX
    Inherits Windows.Forms.Metro.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOfficeUIX))
        Me.RibbonTab1 = New System.Windows.Forms.Metro.RibbonTab()
        Me.StatusStrip1 = New System.Windows.Forms.Metro.StatusStrip(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToggleTrackBar1 = New System.Windows.Forms.Metro.ToggleTrackBar()
        Me.ToggleTrackBar2 = New System.Windows.Forms.Metro.ToggleTrackBar()
        Me.ToggleTrackBar3 = New System.Windows.Forms.Metro.ToggleTrackBar()
        Me.ToggleSwitch1 = New System.Windows.Forms.Metro.ToggleSwitch()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
       '
        'RibbonTab1
        '
        Me.RibbonTab1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RibbonTab1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonTab1.FileText = "ARCHIVOS"
        Me.RibbonTab1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonTab1.Items = CType(resources.GetObject("RibbonTab1.Items"), System.Collections.Generic.List(Of String))
        Me.RibbonTab1.Location = New System.Drawing.Point(2, 30)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Size = New System.Drawing.Size(476, 25)
        Me.RibbonTab1.TabIndex = 10
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(2, 304)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(476, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(81, 17)
        Me.ToolStripStatusLabel1.Text = "Demostracion"
        '
        'ToggleTrackBar1
        '
        Me.ToggleTrackBar1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToggleTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.ToggleTrackBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleTrackBar1.InactiveColor = System.Drawing.SystemColors.ScrollBar
        Me.ToggleTrackBar1.Location = New System.Drawing.Point(12, 61)
        Me.ToggleTrackBar1.MaxValue = 255
        Me.ToggleTrackBar1.MinimumSize = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar1.Name = "ToggleTrackBar1"
        Me.ToggleTrackBar1.Size = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar1.TabIndex = 14
        '
        'ToggleTrackBar2
        '
        Me.ToggleTrackBar2.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToggleTrackBar2.BackColor = System.Drawing.Color.Transparent
        Me.ToggleTrackBar2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleTrackBar2.InactiveColor = System.Drawing.SystemColors.ScrollBar
        Me.ToggleTrackBar2.Location = New System.Drawing.Point(12, 91)
        Me.ToggleTrackBar2.MaxValue = 255
        Me.ToggleTrackBar2.MinimumSize = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar2.Name = "ToggleTrackBar2"
        Me.ToggleTrackBar2.Size = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar2.TabIndex = 14
        '
        'ToggleTrackBar3
        '
        Me.ToggleTrackBar3.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToggleTrackBar3.BackColor = System.Drawing.Color.Transparent
        Me.ToggleTrackBar3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleTrackBar3.InactiveColor = System.Drawing.SystemColors.ScrollBar
        Me.ToggleTrackBar3.Location = New System.Drawing.Point(12, 121)
        Me.ToggleTrackBar3.MaxValue = 255
        Me.ToggleTrackBar3.MinimumSize = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar3.Name = "ToggleTrackBar3"
        Me.ToggleTrackBar3.Size = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar3.TabIndex = 14
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToggleSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.ToggleSwitch1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleSwitch1.InactiveColor = System.Drawing.SystemColors.ScrollBar
        Me.ToggleSwitch1.Location = New System.Drawing.Point(12, 151)
        Me.ToggleSwitch1.MinimumSize = New System.Drawing.Size(64, 24)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(64, 24)
        Me.ToggleSwitch1.TabIndex = 15
        '
        'FormOfficeUIX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 328)
        Me.Controls.Add(Me.ToggleSwitch1)
        Me.Controls.Add(Me.ToggleTrackBar3)
        Me.Controls.Add(Me.ToggleTrackBar2)
        Me.Controls.Add(Me.ToggleTrackBar1)
        Me.Controls.Add(Me.RibbonTab1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FormOfficeUIX"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "FormOfficeUIX"
        Me.Controls.SetChildIndex(Me.StatusStrip1, 0)
        Me.Controls.SetChildIndex(Me.RibbonTab1, 0)
        Me.Controls.SetChildIndex(Me.ToggleTrackBar1, 0)
        Me.Controls.SetChildIndex(Me.ToggleTrackBar2, 0)
        Me.Controls.SetChildIndex(Me.ToggleTrackBar3, 0)
        Me.Controls.SetChildIndex(Me.ToggleSwitch1, 0)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonTab1 As System.Windows.Forms.Metro.RibbonTab
    Friend WithEvents StatusStrip1 As System.Windows.Forms.Metro.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToggleTrackBar1 As System.Windows.Forms.Metro.ToggleTrackBar
    Friend WithEvents ToggleTrackBar2 As System.Windows.Forms.Metro.ToggleTrackBar
    Friend WithEvents ToggleTrackBar3 As System.Windows.Forms.Metro.ToggleTrackBar
    Friend WithEvents ToggleSwitch1 As System.Windows.Forms.Metro.ToggleSwitch
End Class
