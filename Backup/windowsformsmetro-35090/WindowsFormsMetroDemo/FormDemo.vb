Public Class FormDemo

    Private Sub _Changed(sender As Object, e As EventArgs)
        If ToggleSwitch1.Value = True Then
            Me.Notices1.Add(New System.Windows.Forms.Metro.Notice(Me.Text, ToggleSwitch1.Value.ToString, 10000))
        End If
    End Sub

    Private Sub _Focus(sender As Object, e As EventArgs) Handles _
        ToggleTrackBar1.GotFocus, ToggleSwitch1.GotFocus, Tile1.GotFocus, _
        Shortcut1.GotFocus, TextBox1.GotFocus, Me.Click
        Me.PropertyGrid1.SelectedObject = sender
    End Sub

    Private Sub FormDemo_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler ToggleSwitch1.ValueChanged, AddressOf _Changed
    End Sub

    Private Sub Shortcut1_Click(sender As Object, e As EventArgs) Handles Shortcut1.Click
        If ToggleSwitch1.Value = True Then _
        Me.Notices1.Add(New System.Windows.Forms.Metro.Notice(Me.Text, Shortcut1.Text, Shortcut1.Image, Shortcut1.HoverColor, 10000, Me.Tile1.Image))
    End Sub

    Private Sub Tile1_Click(sender As Object, e As EventArgs) Handles Tile1.Click
        If ToggleSwitch1.Value = True Then _
            Me.Notices1.Add(New System.Windows.Forms.Metro.Notice(Me.Text, Tile1.Text, Me.Tile1.Image, Tile1.BackColor, 10000))
    End Sub


End Class
