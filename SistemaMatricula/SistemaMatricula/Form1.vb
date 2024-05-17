Imports System.Data.OleDb
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=F:\Programación\Segundo Parcial\Sistema Matricula 2024\BasedeDatos(2002-2003)\SistemadeMatricula.mdb")
        Try
            con.Open()
            MsgBox("Conectado")

            Dim query = "Select * from esudiante"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub
End Class

