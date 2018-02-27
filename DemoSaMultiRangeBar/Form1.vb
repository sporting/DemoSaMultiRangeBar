Imports SportingAppFW.SaWindows.Forms

Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler SaMultiRangeBar1.ValueInvalidateHandler, AddressOf ValueChanged
    End Sub

    Private Sub ValueChanged(ByVal sender As Object, ByVal e As SaRangeValueChangeEventArgs)
        ListBox1.Items.Clear()

        For Each rv As SaRangeValue In SaMultiRangeBar1.SaRangeValues
            ListBox1.Items.Add(String.Format("{0} - {1}: {2}", rv.MinValue, rv.MaxValue, rv.DefineValue))
        Next
    End Sub
End Class
