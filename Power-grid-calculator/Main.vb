Public Class Main
    Dim total_cash As Integer = 0

    Private Sub Refresh_cash(Optional add As Integer = 0)
        total_cash = NumericCash.Value
        total_cash += add
        NumericCash.Value = total_cash
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonUndo_Click(sender As Object, e As EventArgs) Handles ButtonUndo.Click
        If ListBoxOut.Items.Count > 0 Then
            Dim item As String = ListBoxOut.Items(ListBoxOut.Items.Count - 1)
            Refresh_cash(Split(item, "$")(2))
            ListBoxOut.Items.RemoveAt(ListBoxOut.Items.Count - 1)
        End If
    End Sub

    Private Sub NumericCash_ValueChanged(sender As Object, e As EventArgs) Handles NumericCash.ValueChanged
        Refresh_cash()
    End Sub

    Private Sub Button1_Click(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        If e.Button = MouseButtons.Left And Button1.Text < 10 Then
            Button1.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button1.Text > 0 Then
            Button1.Text -= 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        If e.Button = MouseButtons.Left And Button2.Text < 10 Then
            Button2.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button2.Text > 0 Then
            Button2.Text -= 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If e.Button = MouseButtons.Left And Button3.Text < 10 Then
            Button3.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button3.Text > 0 Then
            Button3.Text -= 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        If e.Button = MouseButtons.Left And Button4.Text < 10 Then
            Button4.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button4.Text > 0 Then
            Button4.Text -= 1
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As MouseEventArgs) Handles Button5.MouseDown
        If e.Button = MouseButtons.Left And Button5.Text < 10 Then
            Button5.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button5.Text > 0 Then
            Button5.Text -= 1
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown
        If e.Button = MouseButtons.Left And Button6.Text < 10 Then
            Button6.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button6.Text > 0 Then
            Button6.Text -= 1
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        If e.Button = MouseButtons.Left And Button7.Text < 10 Then
            Button7.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button7.Text > 0 Then
            Button7.Text -= 1
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        If e.Button = MouseButtons.Left And Button8.Text < 10 Then
            Button8.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button8.Text > 0 Then
            Button8.Text -= 1
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As MouseEventArgs) Handles Button10.MouseDown
        If e.Button = MouseButtons.Left And Button10.Text < 1 Then
            Button10.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button10.Text > 0 Then
            Button10.Text -= 1
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown
        If e.Button = MouseButtons.Left And Button12.Text < 1 Then
            Button12.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button12.Text > 0 Then
            Button12.Text -= 1
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As MouseEventArgs) Handles Button14.MouseDown
        If e.Button = MouseButtons.Left And Button14.Text < 1 Then
            Button14.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button14.Text > 0 Then
            Button14.Text -= 1
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As MouseEventArgs) Handles Button16.MouseDown
        If e.Button = MouseButtons.Left And Button16.Text < 1 Then
            Button16.Text += 1
        ElseIf e.Button = MouseButtons.Right And Button16.Text > 0 Then
            Button16.Text -= 1
        End If
    End Sub

    Private Sub ButtonRes_Click(sender As Object, e As EventArgs) Handles ButtonRes.Click
        Dim cost As Integer = 0
        cost += Button1.Text * 1
        cost += Button2.Text * 2
        cost += Button3.Text * 3
        cost += Button4.Text * 4
        cost += Button5.Text * 5
        cost += Button6.Text * 6
        cost += Button7.Text * 7
        cost += Button8.Text * 8
        cost += Button10.Text * 10
        cost += Button12.Text * 12
        cost += Button14.Text * 14
        cost += Button16.Text * 16
        Button1.Text = 0
        Button2.Text = 0
        Button3.Text = 0
        Button4.Text = 0
        Button5.Text = 0
        Button6.Text = 0
        Button7.Text = 0
        Button8.Text = 0
        Button10.Text = 0
        Button12.Text = 0
        Button14.Text = 0
        Button16.Text = 0
        Refresh_cash(-cost)
        ListBoxOut.Items.Add("Your cash is now: $" & total_cash & " The resources cost: $" & cost)
    End Sub
End Class
