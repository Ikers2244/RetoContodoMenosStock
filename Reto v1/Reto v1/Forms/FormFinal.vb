Public Class FormFinal
    Dim conexion As New Conexion
    Private Sub FormFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTodo()
        editarCols()
        lblTotal.Text = getprecioTotal()
    End Sub

    Private Sub editarCols()
        dgvVentas.Columns(1).Visible = False
        dgvVentas.Columns(6).Visible = False
        dgvVentas.Columns(7).Visible = False
    End Sub

    Private Sub CargarTodo()
        Conexion.Conectar()
        Dim MiDataRow As DataRow
        MiDataRow = conexion.MiDataSet5.Tables("Ventas").Rows(0)

        dgvVentas.DataSource = conexion.MiDataSet5
        dgvVentas.DataMember = "Ventas"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim miDataRow As DataRow
        Dim miDataRow1 As DataRow

        Dim i As Integer
        i = dgvVentas.CurrentRow.Index

        Try
            miDataRow1 = conexion.MiDataSet5.Tables("Ventas").Rows(i)

            miDataRow = miDataRow1
            miDataRow("Eliminado") = True

            Dim TablaBorrados As DataTable
            TablaBorrados = conexion.MiDataSet5.Tables("Ventas").GetChanges(DataRowState.Modified)
            conexion.MiDataAdapter4.Update(TablaBorrados)
            conexion.MiDataSet5.Tables("Ventas").AcceptChanges()

            CargarTodo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        btnFinalizar.Visible = False
        btnEliminar.Visible = False
        Using bmp = New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
            bmp.Save("screenshot.png")
            System.Diagnostics.Process.Start("MSPaint.exe", "screenshot.png")

        End Using
        btnFinalizar.Visible = True
        btnEliminar.Visible = True
    End Sub
End Class