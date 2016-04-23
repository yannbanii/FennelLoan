Public Class ClientDashboard

    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.0005

    'Private Sub ListView1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseWheel
    '    'if very sensitive mouse, change 0.00005 to something even smaller   
    '    _scaleDelta = Math.Sqrt(PictureBox1.Width * PictureBox1.Height) * 0.00005

    '    If e.Delta < 0 Then
    '        _scale -= _scaleDelta
    '    ElseIf e.Delta > 0 Then
    '        _scale += _scaleDelta
    '    End If

    '    If e.Delta <> 0 Then _
    '    PictureBox1.Size = New Size(CInt(Math.Round(_originalSize.Width * _scale)), _
    '                                CInt(Math.Round(_originalSize.Height * _scale)))
    'End Sub

    'Private Sub ClientDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    '    'init this from here or a method depending on your needs
    '    If PictureBox1.Image IsNot Nothing Then
    '        PictureBox1.Size = Panel1.Size
    '        _originalSize = Panel1.Size
    '    End If
    'End Sub
End Class
