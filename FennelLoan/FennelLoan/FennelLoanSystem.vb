Public Class FennelLoanSystem
    ' General Declearation

    Dim ClientDash As New ClientDashboard

    Sub GeneralAddControl(ByVal PMainContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer, ByVal UI As UserControl, ByVal Info As String)
        Me.Cursor = Cursors.WaitCursor
        PMainContainer.Controls.Clear()
        PMainContainer.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PMainContainer.Controls.Add(UI)
        Me.Cursor = Cursors.Default
        'uiPanel2.Text = Info
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub


    Private Sub BtnClientDashBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientDashBoard.Click
        GeneralAddControl(uiPanelMainContainer, ClientDash, "")
    End Sub
End Class
