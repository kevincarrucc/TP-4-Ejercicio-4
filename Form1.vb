Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaMatriz.ColumnCount = 8
        GrillaMatriz.Rows.Add(10)
        GrillaVector.ColumnCount = 1
        GrillaVector.Rows.Add(10)
    End Sub
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        Dim matriz(10, 8)
        Dim vector(10)
        Dim dato, cuenta, minimo, numero As Integer
        Dim rand As New Random()
        dato = 1
        cuenta = 0
        For f = 0 To 9
            For c = 0 To 7
                matriz(f, c) = rand.Next(1, 200)
                GrillaMatriz.Item(c, f).Value = matriz(f, c)
                If dato = 1 Then
                    minimo = matriz(f, c)
                    dato = 2
                End If
                If minimo > matriz(f, c) Then
                    minimo = matriz(f, c)
                End If
                cuenta = cuenta + 1
                If cuenta = 8 Then
                    vector(f) = minimo
                    dato = 1
                    cuenta = 0
                    numero = vector(f)
                    GrillaVector.Item(0, f).Value = vector(f)
                End If
            Next
        Next

    End Sub

End Class
