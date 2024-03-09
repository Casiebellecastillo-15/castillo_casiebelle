Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim math As Integer
        Dim science As Integer
        Dim english As Integer
        Dim Grade As Double


        math = Val(TextBox1)
        science = Val(TextBox2)
        english = Val(TextBox3)

        Grade = (math + science + english)
        Grade = Grade / 3
        If Grade >= 90 Then
            MsgBox("A+")
        ElseIf Grade >= 80 Then
            MsgBox("B+")
        ElseIf Grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("failed")

        End If

    End Sub
End Class
