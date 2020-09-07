Public Class Form1
    Dim bmp As New Drawing.Bitmap(640, 400)
    Dim gfx As Graphics = Graphics.FromImage(bmp)
    Dim color As Color = Color.Black
    Dim mode As String = "dot"
    Dim count As Integer = 0
    Dim pSize As Integer = 1
    Dim x1, y1, x2, y2 As Integer
    Dim lineCase As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gfx.FillRectangle(Brushes.White, 0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
    End Sub

    Private Sub drawLine(X1 As Integer, Y1 As Integer, X2 As Integer, Y2 As Integer)
        Dim j As Integer = 1
        Dim dx As Integer
        Dim dy As Integer

        dx = Math.Abs(X2 - X1)
        dy = Math.Abs(Y2 - Y1)

        If Y1 = Y2 And X1 <= X2 Then 'case 1
            For X As Integer = X1 To X2
                bmp.SetPixel(X, Y1, color)
            Next
            lineCase = 1
        ElseIf Y1 = Y2 And X1 > X2 Then 'case 2
            For X As Integer = X1 To X2 Step -1
                bmp.SetPixel(X, Y1, color)
            Next
            lineCase = 2
        ElseIf X1 = X2 And Y1 < Y2 Then 'case 3
            For Y As Integer = Y1 To Y2
                bmp.SetPixel(X1, Y, color)
            Next
            lineCase = 3
        ElseIf X1 = X2 And Y1 > Y2 Then 'case 4
            For Y As Integer = Y1 To Y2 Step -1
                bmp.SetPixel(X1, Y, color)
            Next
            lineCase = 4
        ElseIf X1 < X2 And Y1 < Y2 And dx = dy Then 'case 5
            For i As Integer = 0 To dx
                bmp.SetPixel(X1 + i, Y1 + i, color)
            Next
            lineCase = 5
            If pSize > 1 Then
                While j < pSize
                    For i As Integer = 0 To dx - j
                        bmp.SetPixel(X1 + i + j, Y1 + i, color)
                        bmp.SetPixel(X1 + i, Y1 + i + j, color)
                    Next
                    j = j + 1
                End While
            End If
        ElseIf X1 > X2 And Y1 < Y2 And dx = dy Then 'case 6
            For i As Integer = 0 To dx
                bmp.SetPixel(X1 - i, Y1 + i, color)
            Next
            lineCase = 6
            If pSize > 1 Then
                While j < pSize
                    For i As Integer = 0 To dx - j
                        bmp.SetPixel(X1 - i - j, Y1 + i, color)
                        bmp.SetPixel(X1 - i, Y1 + i + j, color)
                    Next
                    j = j + 1
                End While
            End If
        ElseIf X1 > X2 And Y1 > Y2 And dx = dy Then 'case 7
            For i As Integer = 0 To dx
                bmp.SetPixel(X1 - i, Y1 - i, color)
            Next
            lineCase = 7
            If pSize > 1 Then
                While j < pSize
                    For i As Integer = 0 To dx - j
                        bmp.SetPixel(X1 - i - j, Y1 - i, color)
                        bmp.SetPixel(X1 - i, Y1 - i - j, color)
                    Next
                    j = j + 1
                End While
            End If
        ElseIf X1 < X2 And Y1 > Y2 And dx = dy Then 'case 8
            For i As Integer = 0 To dx
                bmp.SetPixel(X1 + i, Y1 - i, color)
            Next
            lineCase = 8
            If pSize > 1 Then
                While j < pSize
                    For i As Integer = 0 To dx - j
                        bmp.SetPixel(X1 + i + j, Y1 - i, color)
                        bmp.SetPixel(X1 + i, Y1 - i - j, color)
                    Next
                    j = j + 1
                End While
            End If
        Else
            lineMidPoint(X1, Y1, X2, Y2)
        End If
    End Sub

    Private Sub lineMidPoint(X1 As Integer, Y1 As Integer, X2 As Integer, Y2 As Integer)
        Dim dx, dy, d, dR, dUR, X, Y As Integer

        dx = Math.Abs(X2 - X1)
        dy = Math.Abs(Y2 - Y1)

        X = X1
        Y = Y1
        If X1 < X2 And Y1 < Y2 And Math.Abs(dx) > Math.Abs(dy) Then 'Case 9
            dR = 2 * dy
            dUR = 2 * (dy - dx)
            d = 2 * dy - dx
            While X <= X2
                bmp.SetPixel(X, Y, color)
                X = X + 1
                If d <= 0 Then
                    d = d + dR
                ElseIf d > 0 Then
                    d = d + dUR
                    Y = Y + 1
                End If
            End While
            lineCase = 9
        ElseIf X1 < X2 And Y1 < Y2 And Math.Abs(dx) < Math.Abs(dy) Then 'Case 10
            dR = -2 * dx
            dUR = 2 * (dy - dx)
            d = dy - (2 * dx)
            While Y <= Y2
                bmp.SetPixel(X, Y, color)
                Y = Y + 1
                If d >= 0 Then
                    d = d + dR
                ElseIf d < 0 Then
                    d = d + dUR
                    X = X + 1
                End If
            End While
            lineCase = 10
        ElseIf X1 > X2 And Y1 < Y2 And Math.Abs(dx) < Math.Abs(dy) Then 'Case 11
            dR = -2 * dx
            dUR = 2 * (dy - dx)
            d = dy - (2 * dx)
            While Y <= Y2
                bmp.SetPixel(X, Y, color)
                Y = Y + 1
                If d >= 0 Then
                    d = d + dR
                ElseIf d < 0 Then
                    d = d + dUR
                    X = X - 1
                End If
            End While
            lineCase = 11
        ElseIf X1 > X2 And Y1 < Y2 And Math.Abs(dx) > Math.Abs(dy) Then 'case 12
            dR = 2 * dy
            dUR = 2 * (dy - dx)
            d = 2 * dy - dx
            While X >= X2
                bmp.SetPixel(X, Y, color)
                X = X - 1
                If d <= 0 Then
                    d = d + dR
                ElseIf d > 0 Then
                    d = d + dUR
                    Y = Y + 1
                End If
            End While
            lineCase = 12
        ElseIf X1 > X2 And Y1 > Y2 And Math.Abs(dx) > Math.Abs(dy) Then 'case 13
            dR = 2 * dy
            dUR = 2 * (dy - dx)
            d = 2 * dy - dx
            While X >= X2
                bmp.SetPixel(X, Y, color)
                X = X - 1
                If d <= 0 Then
                    d = d + dR
                ElseIf d > 0 Then
                    d = d + dUR
                    Y = Y - 1
                End If
            End While
            lineCase = 13
        ElseIf X1 > X2 And Y1 > Y2 And Math.Abs(dx) < Math.Abs(dy) Then 'case 14
            dR = -2 * dx
            dUR = 2 * (dy - dx)
            d = dy - (2 * dx)
            While Y >= Y2
                bmp.SetPixel(X, Y, color)
                Y = Y - 1
                If d >= 0 Then
                    d = d + dR
                ElseIf d < 0 Then
                    d = d + dUR
                    X = X - 1
                End If
            End While
            lineCase = 14
        ElseIf X1 < X2 And Y1 > Y2 And Math.Abs(dx) < Math.Abs(dy) Then 'case 15
            dR = -2 * dx
            dUR = 2 * (dy - dx)
            d = dy - (2 * dx)
            While Y >= Y2
                bmp.SetPixel(X, Y, color)
                Y = Y - 1
                If d >= 0 Then
                    d = d + dR
                ElseIf d < 0 Then
                    d = d + dUR
                    X = X + 1
                End If
            End While
            lineCase = 15
        ElseIf X1 < X2 And Y1 > Y2 And Math.Abs(dx) > Math.Abs(dy) Then 'case 16
            dR = 2 * dy
            dUR = 2 * (dy - dx)
            d = 2 * dy - dx
            While X <= X2
                bmp.SetPixel(X, Y, color)
                X = X + 1
                If d <= 0 Then
                    d = d + dR
                ElseIf d > 0 Then
                    d = d + dUR
                    Y = Y - 1
                End If
            End While
            lineCase = 16
        End If
    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If mode = "dot" Then
            x1 = e.X
            y1 = e.Y
            For i As Integer = 0 To pSize - 1 'algorithm to draw dot with specified thickness
                For j As Integer = 0 To pSize - 1
                    bmp.SetPixel(x1 + j, y1, color)
                Next
                y1 = y1 + 1
            Next
            PictureBox1.Image = bmp
        ElseIf mode = "line" Then
            bmp.SetPixel(e.X, e.Y, color)
            PictureBox1.Image = bmp
            If count = 0 Then
                x1 = e.X
                y1 = e.Y
            ElseIf count = 1 Then
                x2 = e.X
                y2 = e.Y
            End If
            count = count + 1
            If count = 2 Then
                line()
                count = 0
            End If
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        mode = "dot"
    End Sub

    Private Sub btnLine_Click(sender As Object, e As EventArgs) Handles btnLine.Click
        mode = "line"
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        lblX.Text = e.X
        lblY.Text = e.Y
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            color = ColorDialog1.Color
        End If
    End Sub

    Private Sub clear() 'clear screen
        count = 0
        gfx.FillRectangle(Brushes.White, 0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
    End Sub

    Private Sub line() 'draw line with specified thickness
        Dim j As Integer = 1
        drawLine(x1, y1, x2, y2)
        PictureBox1.Image = bmp
        If pSize > 1 Then
            Select Case lineCase
                Case 1, 2, 9, 12, 13, 16
                    While j < pSize
                        If j Mod 2 <> 0 Then
                            y1 = y1 - j
                            y2 = y2 - j
                        Else
                            y1 = y1 + j
                            y2 = y2 + j
                        End If
                        j = j + 1
                        drawLine(x1, y1, x2, y2)
                    End While
                Case 3, 4, 10, 11, 14, 15
                    While j < pSize
                        If j Mod 2 <> 0 Then
                            x1 = x1 - j
                            x2 = x2 - j
                        Else
                            x1 = x1 + j
                            x2 = x2 + j
                        End If
                        j = j + 1
                        drawLine(x1, y1, x2, y2)
                    End While
                Case 5 To 8
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub tsbtnOpen_Click(sender As Object, e As EventArgs) Handles tsbtnOpen.Click
        Dim filename As String
        OpenFileDialog1.Filter = "PNG Files (*.png)|*.png" +
                                 "|JPG Files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif" +
                                 "|GIF Files (*.gif)|*.gif" +
                                 "|Bitmap Files (*.bmp;*.dib)|*.bmp;*.dib" +
                                 "|All Picture Files|*.jpeg;*.jpg;*.jpe;*.jfif;*.png;*.gif;*.bmp;*.dib"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            filename = OpenFileDialog1.FileName
            clear()
            gfx.DrawImage(Image.FromFile(filename), 0, 0)
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub tsbtnSave_Click(sender As Object, e As EventArgs) Handles tsbtnSave.Click
        PictureBox1.DrawToBitmap(bmp, New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height))
        SaveFileDialog1.Filter = "PNG Files (*.png)|*.png" +
                                 "|JPG Files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif" +
                                 "|GIF Files (*.gif)|*.gif" +
                                 "|Bitmap Files (*.bmp;*.dib)|*.bmp;*.dib"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            bmp.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Bmp)
        End If
    End Sub

    Private Sub cmbSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSize.SelectedIndexChanged
        pSize = cmbSize.SelectedItem
    End Sub
End Class
