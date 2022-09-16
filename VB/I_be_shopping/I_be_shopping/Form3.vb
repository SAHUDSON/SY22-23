Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dropdownBody.FindStringExact("Classic soft") Then

        Else
            Button1.Hide()
        End If

        'WORK ON THIS

        If dropdownBody.SelectedText = "Classic soft" Then

        Else
            Button1.Hide()
        End If
    End Sub
End Class