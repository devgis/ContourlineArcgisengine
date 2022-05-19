Public Class FormOfficeUIX

    Private Sub ButtonNormal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RibbonTab1_ItemClick(sender As Object, e As EventArgs) Handles RibbonTab1.ItemClick
        'MsgBox(Me.RibbonTab1.Items.IndexOf(sender.text))
    End Sub


    Private Sub ToggleTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles ToggleTrackBar3.ValueChanged, ToggleTrackBar2.ValueChanged, ToggleTrackBar1.ValueChanged
        Me.BorderColor = System.Drawing.Color.FromArgb(ToggleTrackBar1.Value, ToggleTrackBar2.Value, ToggleTrackBar3.Value)
    End Sub
End Class