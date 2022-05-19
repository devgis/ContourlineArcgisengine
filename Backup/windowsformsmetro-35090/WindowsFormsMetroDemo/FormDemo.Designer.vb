<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDemo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDemo))
        Me.Divider1 = New System.Windows.Forms.Extras.Divider()
        Me.ToggleSwitch1 = New System.Windows.Forms.Metro.ToggleSwitch()
        Me.ToggleTrackBar1 = New System.Windows.Forms.Metro.ToggleTrackBar()
        Me.Shortcut1 = New System.Windows.Forms.Metro.Shortcut()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tile1 = New System.Windows.Forms.Metro.Tile()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.Divider2 = New System.Windows.Forms.Extras.Divider()
        Me.Notices1 = New System.Windows.Forms.Metro.Notices(Me.components)
        Me.TextBox1 = New System.Windows.Forms.Metro.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.Metro.StatusStrip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Divider1
        '
        Me.Divider1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Divider1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Divider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Divider1.LineColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Divider1.Location = New System.Drawing.Point(2, 30)
        Me.Divider1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(791, 15)
        Me.Divider1.TabIndex = 0
        Me.Divider1.Text = "Controls"
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToggleSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.ToggleSwitch1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleSwitch1.InactiveColor = System.Drawing.SystemColors.ScrollBar
        Me.ToggleSwitch1.Location = New System.Drawing.Point(15, 126)
        Me.ToggleSwitch1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ToggleSwitch1.MinimumSize = New System.Drawing.Size(64, 24)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(64, 24)
        Me.ToggleSwitch1.TabIndex = 2
        '
        'ToggleTrackBar1
        '
        Me.ToggleTrackBar1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToggleTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.ToggleTrackBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleTrackBar1.InactiveColor = System.Drawing.SystemColors.ScrollBar
        Me.ToggleTrackBar1.Location = New System.Drawing.Point(99, 126)
        Me.ToggleTrackBar1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ToggleTrackBar1.MinimumSize = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar1.Name = "ToggleTrackBar1"
        Me.ToggleTrackBar1.Size = New System.Drawing.Size(192, 24)
        Me.ToggleTrackBar1.TabIndex = 4
        Me.ToggleTrackBar1.Value = 45
        '
        'Shortcut1
        '
        Me.Shortcut1.BackColor = System.Drawing.Color.DarkGray
        Me.Shortcut1.Badge = "99"
        Me.Shortcut1.BadgeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Shortcut1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Shortcut1.Image = CType(resources.GetObject("Shortcut1.Image"), System.Drawing.Image)
        Me.Shortcut1.Location = New System.Drawing.Point(15, 230)
        Me.Shortcut1.Margin = New System.Windows.Forms.Padding(4)
        Me.Shortcut1.Name = "Shortcut1"
        Me.Shortcut1.Padding = New System.Windows.Forms.Padding(4)
        Me.Shortcut1.ShowBadge = True
        Me.Shortcut1.Size = New System.Drawing.Size(92, 92)
        Me.Shortcut1.TabIndex = 8
        Me.Shortcut1.Text = "Windows Forms Metro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ToggleSwitch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ToggleTrackBar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TextBox"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Shortcut"
        '
        'Tile1
        '
        Me.Tile1.AllowCheck = True
        Me.Tile1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Tile1.Badge = "99"
        Me.Tile1.BrandColor = System.Drawing.Color.Black
        Me.Tile1.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Tile1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tile1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile1.ForeColor = System.Drawing.Color.White
        Me.Tile1.Image = CType(resources.GetObject("Tile1.Image"), System.Drawing.Image)
        Me.Tile1.Location = New System.Drawing.Point(115, 230)
        Me.Tile1.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile1.Name = "Tile1"
        Me.Tile1.Size = New System.Drawing.Size(150, 150)
        Me.Tile1.TabIndex = 10
        Me.Tile1.Text = "Windows Forms"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 214)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tile"
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropertyGrid1.Location = New System.Drawing.Point(436, 108)
        Me.PropertyGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(353, 285)
        Me.PropertyGrid1.TabIndex = 13
        '
        'Divider2
        '
        Me.Divider2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Divider2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Divider2.LineColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(432, 68)
        Me.Divider2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(357, 15)
        Me.Divider2.TabIndex = 12
        Me.Divider2.Text = "Properties"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BackgroundWorkerSearch = Me.BackgroundWorker1
        Me.TextBox1.CueText = "Serial"
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 180)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ProgressBarColor = System.Drawing.Color.LightGreen
        Me.TextBox1.Size = New System.Drawing.Size(276, 30)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "1234" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5678" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9012" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3456"
        Me.TextBox1.TextFormat = "{0}-{1}-{2}"
        Me.TextBox1.UseCue = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatusLabel1.Text = "StatusStrip"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(2, 408)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(791, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FormDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 432)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Shortcut1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.Tile1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToggleTrackBar1)
        Me.Controls.Add(Me.ToggleSwitch1)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(427, 351)
        Me.Name = "FormDemo"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Windows Forms Metro Demostration"
        Me.Controls.SetChildIndex(Me.StatusStrip1, 0)
        Me.Controls.SetChildIndex(Me.Divider1, 0)
        Me.Controls.SetChildIndex(Me.ToggleSwitch1, 0)
        Me.Controls.SetChildIndex(Me.ToggleTrackBar1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Tile1, 0)
        Me.Controls.SetChildIndex(Me.PropertyGrid1, 0)
        Me.Controls.SetChildIndex(Me.Divider2, 0)
        Me.Controls.SetChildIndex(Me.Shortcut1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Divider1 As System.Windows.Forms.Extras.Divider
    Friend WithEvents ToggleSwitch1 As System.Windows.Forms.Metro.ToggleSwitch
    Friend WithEvents ToggleTrackBar1 As System.Windows.Forms.Metro.ToggleTrackBar
    Friend WithEvents Shortcut1 As System.Windows.Forms.Metro.Shortcut
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tile1 As System.Windows.Forms.Metro.Tile
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents Divider2 As System.Windows.Forms.Extras.Divider
    Friend WithEvents Notices1 As System.Windows.Forms.Metro.Notices
    Friend WithEvents TextBox1 As System.Windows.Forms.Metro.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.Metro.StatusStrip

End Class
