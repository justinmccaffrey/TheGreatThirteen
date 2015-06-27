Public Class Form1
    Dim frogSelected As Integer = -1
    Dim colorState As Integer = 0
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        SetLevel(ComboBox1.SelectedIndex)
    End Sub
    Private Sub SetLevel(level As Integer)
        ResetLevel()
        Select Case level
            Case 1
                Button4.BackColor = Color.Green
                Button7.BackColor = Color.Green
                Button10.BackColor = Color.Green
                Button11.BackColor = Color.Green
            Case 2
                Button1.BackColor = Color.Green
                Button2.BackColor = Color.Green
                Button6.BackColor = Color.Green
                Button7.BackColor = Color.Green
            Case 3
                Button1.BackColor = Color.Green
                Button3.BackColor = Color.Green
                Button4.BackColor = Color.Green
                Button6.BackColor = Color.Green
                Button8.BackColor = Color.Green
                Button9.BackColor = Color.Green
            Case 4
                Button3.BackColor = Color.Green
                Button4.BackColor = Color.Green
                Button5.BackColor = Color.Green
                Button6.BackColor = Color.Green
                Button7.BackColor = Color.Green
                Button8.BackColor = Color.Green
                Button9.BackColor = Color.Green
            Case 5
                Button0.BackColor = Color.Green
                Button1.BackColor = Color.Green
                Button2.BackColor = Color.Green
                Button3.BackColor = Color.Green
                Button4.BackColor = Color.Green
                Button5.BackColor = Color.Green
                Button7.BackColor = Color.Green
                Button8.BackColor = Color.Green
                Button9.BackColor = Color.Green
                Button10.BackColor = Color.Green
                Button11.BackColor = Color.Green
                Button12.BackColor = Color.Green
        End Select
    End Sub

    Private Sub FrogButton_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click
        Dim ClickedButton As Button
        ClickedButton = CType(sender, Button)
        'If (frogSelected < 0) Then
        If (ClickedButton.BackColor = Color.Green) Then
            ClearWhite()
            frogSelected = ClickedButton.Tag
            Select Case CInt(frogSelected)
                Case 0
                    If (Button1.BackColor = Color.Green And Not Button2.BackColor = Color.Green) Then Button2.BackColor = Color.White
                    If (Button3.BackColor = Color.Green And Not Button6.BackColor = Color.Green) Then Button6.BackColor = Color.White
                    If (Button5.BackColor = Color.Green And Not Button10.BackColor = Color.Green) Then Button10.BackColor = Color.White
                Case 1
                    If (Button3.BackColor = Color.Green And Not Button5.BackColor = Color.Green) Then Button5.BackColor = Color.White
                    If (Button6.BackColor = Color.Green And Not Button11.BackColor = Color.Green) Then Button11.BackColor = Color.White
                    If (Button4.BackColor = Color.Green And Not Button7.BackColor = Color.Green) Then Button7.BackColor = Color.White
                Case 2
                    If (Button1.BackColor = Color.Green And Not Button0.BackColor = Color.Green) Then Button0.BackColor = Color.White
                    If (Button4.BackColor = Color.Green And Not Button6.BackColor = Color.Green) Then Button6.BackColor = Color.White
                    If (Button7.BackColor = Color.Green And Not Button12.BackColor = Color.Green) Then Button12.BackColor = Color.White
                Case 3
                    If (Button6.BackColor = Color.Green And Not Button9.BackColor = Color.Green) Then Button9.BackColor = Color.White
                Case 4
                    If (Button6.BackColor = Color.Green And Not Button8.BackColor = Color.Green) Then Button8.BackColor = Color.White
                Case 5
                    If (Button3.BackColor = Color.Green And Not Button1.BackColor = Color.Green) Then Button1.BackColor = Color.White
                    If (Button6.BackColor = Color.Green And Not Button7.BackColor = Color.Green) Then Button7.BackColor = Color.White
                    If (Button8.BackColor = Color.Green And Not Button11.BackColor = Color.Green) Then Button11.BackColor = Color.White
                Case 6
                    If (Button3.BackColor = Color.Green And Not Button0.BackColor = Color.Green) Then Button0.BackColor = Color.White
                    If (Button4.BackColor = Color.Green And Not Button2.BackColor = Color.Green) Then Button2.BackColor = Color.White
                    If (Button8.BackColor = Color.Green And Not Button10.BackColor = Color.Green) Then Button10.BackColor = Color.White
                    If (Button9.BackColor = Color.Green And Not Button12.BackColor = Color.Green) Then Button12.BackColor = Color.White
                Case 7
                    If (Button4.BackColor = Color.Green And Not Button1.BackColor = Color.Green) Then Button1.BackColor = Color.White
                    If (Button6.BackColor = Color.Green And Not Button5.BackColor = Color.Green) Then Button5.BackColor = Color.White
                    If (Button9.BackColor = Color.Green And Not Button11.BackColor = Color.Green) Then Button11.BackColor = Color.White
                Case 8
                    If (Button6.BackColor = Color.Green And Not Button4.BackColor = Color.Green) Then Button4.BackColor = Color.White
                Case 9
                    If (Button6.BackColor = Color.Green And Not Button3.BackColor = Color.Green) Then Button3.BackColor = Color.White
                Case 10
                    If (Button5.BackColor = Color.Green And Not Button0.BackColor = Color.Green) Then Button0.BackColor = Color.White
                    If (Button8.BackColor = Color.Green And Not Button6.BackColor = Color.Green) Then Button6.BackColor = Color.White
                    If (Button11.BackColor = Color.Green And Not Button12.BackColor = Color.Green) Then Button12.BackColor = Color.White
                Case 11
                    If (Button8.BackColor = Color.Green And Not Button5.BackColor = Color.Green) Then Button5.BackColor = Color.White
                    If (Button6.BackColor = Color.Green And Not Button1.BackColor = Color.Green) Then Button1.BackColor = Color.White
                    If (Button9.BackColor = Color.Green And Not Button7.BackColor = Color.Green) Then Button7.BackColor = Color.White
                Case 12
                    If (Button11.BackColor = Color.Green And Not Button10.BackColor = Color.Green) Then Button10.BackColor = Color.White
                    If (Button9.BackColor = Color.Green And Not Button6.BackColor = Color.Green) Then Button6.BackColor = Color.White
                    If (Button7.BackColor = Color.Green And Not Button2.BackColor = Color.Green) Then Button2.BackColor = Color.White
            End Select
            If (Not AnyWhite()) Then frogSelected = -1
            'End If
        Else
            If (ClickedButton.BackColor = Color.White) Then
                Select Case CInt(ClickedButton.Tag)
                    Case 0
                        If (frogSelected = 2) Then Button2.BackColor = Color.DarkTurquoise : Button1.BackColor = Color.DarkTurquoise : Button0.BackColor = Color.Green
                        If (frogSelected = 6) Then Button6.BackColor = Color.DarkTurquoise : Button3.BackColor = Color.DarkTurquoise : Button0.BackColor = Color.Green
                        If (frogSelected = 10) Then Button10.BackColor = Color.DarkTurquoise : Button5.BackColor = Color.DarkTurquoise : Button0.BackColor = Color.Green
                    Case 1
                        If (frogSelected = 5) Then Button5.BackColor = Color.DarkTurquoise : Button3.BackColor = Color.DarkTurquoise : Button1.BackColor = Color.Green
                        If (frogSelected = 11) Then Button11.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button1.BackColor = Color.Green
                        If (frogSelected = 7) Then Button7.BackColor = Color.DarkTurquoise : Button4.BackColor = Color.DarkTurquoise : Button1.BackColor = Color.Green
                    Case 2
                        If (frogSelected = 0) Then Button0.BackColor = Color.DarkTurquoise : Button1.BackColor = Color.DarkTurquoise : Button2.BackColor = Color.Green
                        If (frogSelected = 6) Then Button6.BackColor = Color.DarkTurquoise : Button4.BackColor = Color.DarkTurquoise : Button2.BackColor = Color.Green
                        If (frogSelected = 12) Then Button12.BackColor = Color.DarkTurquoise : Button7.BackColor = Color.DarkTurquoise : Button2.BackColor = Color.Green
                    Case 3
                        If (frogSelected = 9) Then Button9.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button3.BackColor = Color.Green
                    Case 4
                        If (frogSelected = 8) Then Button8.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button4.BackColor = Color.Green
                    Case 5
                        If (frogSelected = 1) Then Button1.BackColor = Color.DarkTurquoise : Button3.BackColor = Color.DarkTurquoise : Button5.BackColor = Color.Green
                        If (frogSelected = 7) Then Button7.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button5.BackColor = Color.Green
                        If (frogSelected = 11) Then Button11.BackColor = Color.DarkTurquoise : Button8.BackColor = Color.DarkTurquoise : Button5.BackColor = Color.Green
                    Case 6
                        If (frogSelected = 0) Then Button0.BackColor = Color.DarkTurquoise : Button3.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.Green
                        If (frogSelected = 2) Then Button2.BackColor = Color.DarkTurquoise : Button4.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.Green
                        If (frogSelected = 10) Then Button10.BackColor = Color.DarkTurquoise : Button8.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.Green
                        If (frogSelected = 12) Then Button12.BackColor = Color.DarkTurquoise : Button9.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.Green
                    Case 7
                        If (frogSelected = 1) Then Button1.BackColor = Color.DarkTurquoise : Button4.BackColor = Color.DarkTurquoise : Button7.BackColor = Color.Green
                        If (frogSelected = 5) Then Button5.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button7.BackColor = Color.Green
                        If (frogSelected = 11) Then Button11.BackColor = Color.DarkTurquoise : Button9.BackColor = Color.DarkTurquoise : Button7.BackColor = Color.Green
                    Case 8
                        If (frogSelected = 4) Then Button4.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button8.BackColor = Color.Green
                    Case 9
                        If (frogSelected = 3) Then Button3.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button9.BackColor = Color.Green
                    Case 10
                        If (frogSelected = 0) Then Button0.BackColor = Color.DarkTurquoise : Button5.BackColor = Color.DarkTurquoise : Button10.BackColor = Color.Green
                        If (frogSelected = 6) Then Button6.BackColor = Color.DarkTurquoise : Button8.BackColor = Color.DarkTurquoise : Button10.BackColor = Color.Green
                        If (frogSelected = 12) Then Button12.BackColor = Color.DarkTurquoise : Button11.BackColor = Color.DarkTurquoise : Button10.BackColor = Color.Green
                    Case 11
                        If (frogSelected = 5) Then Button5.BackColor = Color.DarkTurquoise : Button8.BackColor = Color.DarkTurquoise : Button11.BackColor = Color.Green
                        If (frogSelected = 1) Then Button1.BackColor = Color.DarkTurquoise : Button6.BackColor = Color.DarkTurquoise : Button11.BackColor = Color.Green
                        If (frogSelected = 7) Then Button7.BackColor = Color.DarkTurquoise : Button9.BackColor = Color.DarkTurquoise : Button11.BackColor = Color.Green
                    Case 12
                        If (frogSelected = 2) Then Button2.BackColor = Color.DarkTurquoise : Button7.BackColor = Color.DarkTurquoise : Button12.BackColor = Color.Green
                        If (frogSelected = 6) Then Button6.BackColor = Color.DarkTurquoise : Button9.BackColor = Color.DarkTurquoise : Button12.BackColor = Color.Green
                        If (frogSelected = 10) Then Button10.BackColor = Color.DarkTurquoise : Button11.BackColor = Color.DarkTurquoise : Button12.BackColor = Color.Green
                End Select
                frogSelected = -1
                ClearWhite()
            End If
        End If
        CheckForWin()
    End Sub

    Private Function AnyWhite() As Boolean
        Return Button0.BackColor = Color.White Or Button1.BackColor = Color.White Or Button2.BackColor = Color.White Or Button3.BackColor = Color.White Or Button4.BackColor = Color.White Or Button5.BackColor = Color.White Or Button6.BackColor = Color.White Or Button7.BackColor = Color.White Or Button8.BackColor = Color.White Or Button9.BackColor = Color.White Or Button10.BackColor = Color.White Or Button11.BackColor = Color.White Or Button12.BackColor = Color.White
    End Function

    Private Sub ClearWhite()
        If (Button0.BackColor = Color.White) Then Button0.BackColor = Color.DarkTurquoise
        If (Button1.BackColor = Color.White) Then Button1.BackColor = Color.DarkTurquoise
        If (Button2.BackColor = Color.White) Then Button2.BackColor = Color.DarkTurquoise
        If (Button3.BackColor = Color.White) Then Button3.BackColor = Color.DarkTurquoise
        If (Button4.BackColor = Color.White) Then Button4.BackColor = Color.DarkTurquoise
        If (Button5.BackColor = Color.White) Then Button5.BackColor = Color.DarkTurquoise
        If (Button6.BackColor = Color.White) Then Button6.BackColor = Color.DarkTurquoise
        If (Button7.BackColor = Color.White) Then Button7.BackColor = Color.DarkTurquoise
        If (Button8.BackColor = Color.White) Then Button8.BackColor = Color.DarkTurquoise
        If (Button9.BackColor = Color.White) Then Button9.BackColor = Color.DarkTurquoise
        If (Button10.BackColor = Color.White) Then Button10.BackColor = Color.DarkTurquoise
        If (Button11.BackColor = Color.White) Then Button11.BackColor = Color.DarkTurquoise
        If (Button12.BackColor = Color.White) Then Button12.BackColor = Color.DarkTurquoise
    End Sub
    Private Sub ResetLevel()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Me.BackColor = Color.DarkTurquoise
        frogSelected = -1
        Button0.BackColor = Color.DarkTurquoise
        Button1.BackColor = Color.DarkTurquoise
        Button2.BackColor = Color.DarkTurquoise
        Button3.BackColor = Color.DarkTurquoise
        Button4.BackColor = Color.DarkTurquoise
        Button5.BackColor = Color.DarkTurquoise
        Button6.BackColor = Color.DarkTurquoise
        Button7.BackColor = Color.DarkTurquoise
        Button8.BackColor = Color.DarkTurquoise
        Button9.BackColor = Color.DarkTurquoise
        Button10.BackColor = Color.DarkTurquoise
        Button11.BackColor = Color.DarkTurquoise
        Button12.BackColor = Color.DarkTurquoise
    End Sub



    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub


    Private Sub CustomButton_Click(sender As Object, e As EventArgs) Handles CustomButton.Click
        ResetLevel()
        Dim custom As New Custom
        custom.Show()
    End Sub

    Private Sub CheckForWin()
        Dim frogCount As Integer = 0
        If (Button0.BackColor = Color.Green) Then frogCount += 1
        If (Button1.BackColor = Color.Green) Then frogCount += 1
        If (Button2.BackColor = Color.Green) Then frogCount += 1
        If (Button3.BackColor = Color.Green) Then frogCount += 1
        If (Button4.BackColor = Color.Green) Then frogCount += 1
        If (Button5.BackColor = Color.Green) Then frogCount += 1
        If (Button6.BackColor = Color.Green) Then frogCount += 1
        If (Button7.BackColor = Color.Green) Then frogCount += 1
        If (Button8.BackColor = Color.Green) Then frogCount += 1
        If (Button9.BackColor = Color.Green) Then frogCount += 1
        If (Button10.BackColor = Color.Green) Then frogCount += 1
        If (Button11.BackColor = Color.Green) Then frogCount += 1
        If (Button12.BackColor = Color.Green) Then frogCount += 1
        If (frogCount = 1) Then
            Timer1.Enabled = True
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ResetLevel()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case colorState
            Case 0
                Button0.BackColor = Color.DarkTurquoise
                Button1.BackColor = Color.DarkTurquoise
                Button2.BackColor = Color.DarkTurquoise
                Button5.BackColor = Color.DarkTurquoise
                Button7.BackColor = Color.DarkTurquoise
                Button10.BackColor = Color.DarkTurquoise
                Button11.BackColor = Color.DarkTurquoise
                Button12.BackColor = Color.DarkTurquoise

                Button3.BackColor = Color.DarkTurquoise
                Button4.BackColor = Color.DarkTurquoise
                Button8.BackColor = Color.DarkTurquoise
                Button9.BackColor = Color.DarkTurquoise

                Button6.BackColor = Color.Green
            Case 1
                Button0.BackColor = Color.DarkTurquoise
                Button1.BackColor = Color.DarkTurquoise
                Button2.BackColor = Color.DarkTurquoise
                Button5.BackColor = Color.DarkTurquoise
                Button7.BackColor = Color.DarkTurquoise
                Button10.BackColor = Color.DarkTurquoise
                Button11.BackColor = Color.DarkTurquoise
                Button12.BackColor = Color.DarkTurquoise

                Button3.BackColor = Color.Green
                Button4.BackColor = Color.Green
                Button8.BackColor = Color.Green
                Button9.BackColor = Color.Green

                Button6.BackColor = Color.DarkTurquoise
            Case 2
                Button0.BackColor = Color.Green
                Button1.BackColor = Color.Green
                Button2.BackColor = Color.Green
                Button5.BackColor = Color.Green
                Button7.BackColor = Color.Green
                Button10.BackColor = Color.Green
                Button11.BackColor = Color.Green
                Button12.BackColor = Color.Green

                Button3.BackColor = Color.DarkTurquoise
                Button4.BackColor = Color.DarkTurquoise
                Button8.BackColor = Color.DarkTurquoise
                Button9.BackColor = Color.DarkTurquoise

                Button6.BackColor = Color.DarkTurquoise

                colorState = -1
        End Select
        colorState += 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (Me.BackColor = Color.DarkTurquoise) Then
            Me.BackColor = Color.Orange
        ElseIf (Me.BackColor = Color.Orange) Then
            Me.BackColor = Color.OrangeRed
        ElseIf (Me.BackColor = Color.OrangeRed) Then
            Me.BackColor = Color.DarkTurquoise
        End If
    End Sub
End Class
