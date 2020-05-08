Imports System.ComponentModel.DataAnnotations
Imports t329154VB.My.Resources

Public Class Invoice
    Public Property Id() As Integer
    Public Property Description() As String
    Public Property Price() As Decimal

    <Display(Name:="RegDate", ResourceType:=GetType(Localization))>
    Public Property RegisterDate() As Date

    Public Shared Function GetData() As List(Of Invoice)
        Dim invoices As New List(Of Invoice)()
        Const count As Integer = 3

        For i As Integer = 0 To count - 1
            invoices.Add(New Invoice() With {.Id = i, .Description = "Invoice" & i.ToString(), .Price = i * 10, .RegisterDate = Date.Today.AddDays(i - count)})
        Next i

        Return invoices
    End Function
End Class
