Imports System.Windows.Forms.Metro

Public Class FormBoard

    Private Sub FormBoard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TBoard1.Add("Demo 1" & vbCrLf & "19/12/1986" & vbCrLf & vbCrLf & "by Enner Pérez.", 0).BackColor = Color.WhiteSmoke
        Me.TBoard1.Add("Demo 2", 1).BackColor = Color.WhiteSmoke
        Me.TBoard1.Add("Demo 3", 2).BackColor = Color.WhiteSmoke
        Me.TBoard1.Add("Demo 4", 3).BackColor = Color.WhiteSmoke
    End Sub

    'Private Sub TBoard1_ItemClick(sender As Object, e As TBoard.TBoardItemEventArgs) Handles TBoard1.ItemClick
    '    MsgBox(e.item.State)
    'End Sub

    'Private Sub TBoard1_ItemStateChanged(sender As Object, e As TBoard.TBoardItemEventArgs) Handles TBoard1.ItemStateChanged
    '    MsgBox(e.Item.State)
    'End Sub

    Private Sub TBoard1_ItemDoubleClick(sender As Object, e As TBoard.TBoardItemEventArgs) Handles TBoard1.ItemDoubleClick
        MsgBox(e.Item.State)
    End Sub
End Class