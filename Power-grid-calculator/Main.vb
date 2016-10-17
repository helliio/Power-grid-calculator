﻿Public Class Main
    Dim total_cash As Integer = 0
    Dim city_cost As Integer = 10
    Dim earnings As String = "Your earnings is: $"
    Dim city_tier = New Integer() {10, 22, 33, 44, 54, 64, 73, 82, 90, 98, 105, 112, 118, 124, 129, 134, 138, 142, 145, 148, 150}

    Private Sub Refresh_cash(Optional add As Integer = 0)
        total_cash = NumericCash.Value
        total_cash += add
        If total_cash <= NumericCash.Maximum And total_cash >= NumericCash.Minimum Then
            NumericCash.Value = total_cash
        Else
            total_cash -= add
        End If
    End Sub

    Private Sub Add_element(text As String, cost As Integer)
        If total_cash <= NumericCash.Maximum And total_cash >= NumericCash.Minimum Then
            ListBoxOut.Items.Add("Your cash is now: $" & total_cash & " " & text & cost)
            ListBoxOut.TopIndex = ListBoxOut.Items.Count - 1
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh_cash()
    End Sub

    Private Sub ButtonUndo_Click(sender As Object, e As EventArgs) Handles ButtonUndo.Click
        If ListBoxOut.Items.Count > 0 Then
            Dim item As String = ListBoxOut.Items(ListBoxOut.Items.Count - 1)
            If item.IndexOf(earnings) > 0 Then
                Refresh_cash(-Split(item, "$")(2))
            Else
                Refresh_cash(Split(item, "$")(2))
            End If
            ListBoxOut.Items.RemoveAt(ListBoxOut.Items.Count - 1)
            ListBoxOut.TopIndex = ListBoxOut.Items.Count - 1
        End If
    End Sub

    Private Sub NumericCash_ValueChanged(sender As Object, e As EventArgs) Handles NumericCash.ValueChanged
        Refresh_cash()
    End Sub

    Private Sub ButtonPlant_Click(sender As Object, e As EventArgs) Handles ButtonPlant.Click
        Refresh_cash(-NumericPlant.Value)
        Add_element("The plant cost: $", NumericPlant.Value)
        NumericPlant.Value = 0
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
        Add_element("The resources cost: $", cost)
    End Sub

    Private Sub ButtonConnection_Click(sender As Object, e As EventArgs) Handles ButtonConnection.Click
        Refresh_cash(-NumericConnection.Value)
        Add_element("The connection cost: $", NumericConnection.Value)
        NumericConnection.Value = 0
    End Sub

    Private Sub RadioButtonStep1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStep1.CheckedChanged
        city_cost = 10
    End Sub

    Private Sub RadioButtonStep2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStep2.CheckedChanged
        city_cost = 15
    End Sub

    Private Sub RadioButtonStep3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStep3.CheckedChanged
        city_cost = 20
    End Sub

    Private Sub ButtonBuyCity_Click(sender As Object, e As EventArgs) Handles ButtonBuyCity.Click
        Refresh_cash(-city_cost)
        Add_element("The city cost: $", city_cost)
    End Sub

    Private Sub ButtonBureaucracy_Click(sender As Object, e As EventArgs) Handles ButtonBureaucracy.Click
        Refresh_cash(city_tier(NumericFromTier.Value))
        Add_element(earnings, city_tier(NumericFromTier.Value))
    End Sub

    Private Sub Tier_ValueChanged(sender As Object, e As EventArgs) Handles NumericFromTier.ValueChanged, NumericToTier.ValueChanged
        If NumericFromTier.Value <= NumericToTier.Value Then
            LabelProfit.Text = city_tier(NumericToTier.Value) - city_tier(NumericFromTier.Value)
        Else
            LabelProfit.Text = "Invalid to tier value"
        End If
    End Sub
End Class
