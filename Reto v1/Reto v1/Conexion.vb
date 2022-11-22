Imports System.Data.SqlClient

Public Class Conexion

    Public MiDataAdapter, MiDataAdapter2, MiDataAdapter3, da1, da2, da3, MiDataAdapter4 As SqlDataAdapter
    Public MiDataSet, MiDataSet2, MiDataSet3, MiDataSet4, MiDataSet5 As DataSet
    Public MiConexion As New SqlConnection
    Public CadenaConexion = "SERVER=PC-FIRE\SQLEXPRESS; INTEGRATED Security=SSPI;DATABASE=reto"

    Public Sub Conectar()
        Try
            MiConexion.ConnectionString = CadenaConexion
            MiDataAdapter = New SqlDataAdapter("Select * From Articulos WHERE Eliminado= 'False'", MiConexion)
            MiDataAdapter2 = New SqlDataAdapter("Select * From Empleados WHERE Eliminado= 'False'", MiConexion)
            MiDataAdapter3 = New SqlDataAdapter("Select * From Ventas WHERE Eliminado= 'False'", MiConexion)
            MiDataAdapter4 = New SqlDataAdapter("Select * From Ventas WHERE Eliminado= 'False' AND IdPedido= '" & Module1.getidPedidoAnterior + 1 & "'", MiConexion)
            da1 = New SqlDataAdapter("Select IdArticulo, Nombre, Precio From Articulos Where Eliminado= 'False' AND Tipo= 'Bebida'", MiConexion)
            da2 = New SqlDataAdapter("Select IdArticulo, Nombre, Precio From Articulos Where Eliminado= 'False' AND Tipo= 'Entrante'", MiConexion)
            da3 = New SqlDataAdapter("Select IdArticulo, Nombre, Precio From Articulos Where Eliminado= 'False' AND Tipo= 'Principal'", MiConexion)

            Dim MicommBuilder As SqlCommandBuilder = New SqlCommandBuilder(MiDataAdapter)
            Dim MicommBuilder2 As SqlCommandBuilder = New SqlCommandBuilder(MiDataAdapter2)
            Dim MicommBuilder3 As SqlCommandBuilder = New SqlCommandBuilder(da1)
            Dim MicommBuilder4 As SqlCommandBuilder = New SqlCommandBuilder(da2)
            Dim MicommBuilder5 As SqlCommandBuilder = New SqlCommandBuilder(da3)
            Dim MicommBuilder6 As SqlCommandBuilder = New SqlCommandBuilder(MiDataAdapter3)
            Dim MicommBuilder7 As SqlCommandBuilder = New SqlCommandBuilder(MiDataAdapter4)

            MiDataSet = New DataSet
            MiDataSet2 = New DataSet
            MiDataSet3 = New DataSet
            MiDataSet4 = New DataSet
            MiDataSet5 = New DataSet

            MiConexion.Open()
            MiDataAdapter.Fill(MiDataSet, "Articulos")
            MiDataAdapter2.Fill(MiDataSet, "Empleados")
            MiDataAdapter3.Fill(MiDataSet, "Ventas")
            MiDataAdapter4.Fill(MiDataSet5, "Ventas")
            da1.Fill(MiDataSet2, "Articulos")
            da2.Fill(MiDataSet3, "Articulos")
            da3.Fill(MiDataSet4, "Articulos")
            MiConexion.Close()

        Catch ex As Exception
            MsgBox("Error al crear la conexion:" & vbCrLf & ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub CargarDatosArticulos()
        Dim MiDataRow As DataRow
        MiDataRow = MiDataSet.Tables("Articulos").Rows(0)
        FormArticulos.txtNombre.Text = MiDataRow("Nombre")
        FormArticulos.txtPrecio.Text = MiDataRow("Precio")
        FormArticulos.txtStock.Text = MiDataRow("Stock")
        FormArticulos.cbTipo.Text = MiDataRow("Tipo")
    End Sub

    Public Sub CargarDatosEmpleados()
        Dim MiDataRow As DataRow
        MiDataRow = MiDataSet.Tables("Empleados").Rows(0)
        FormEmpleados.txtNombre.Text = MiDataRow("Nombre")
        FormEmpleados.txtPswd.Text = MiDataRow("Contraseña")
        FormEmpleados.txtSueldo.Text = MiDataRow("Sueldo")
        FormEmpleados.cbAdmin.Text = MiDataRow("Admin")
        FormEmpleados.txtPuesto.Text = MiDataRow("Puesto")
    End Sub

    Public Sub ActualizarDgvArticulos()
        Dim dtTabla As New DataTable
        Dim sql = "SELECT * FROM Articulos"

        Try
            Dim conectorSQL = New SqlClient.SqlConnection(CadenaConexion)
            conectorSQL.Open()
            Dim comando = New SqlClient.SqlCommand(sql, conectorSQL)

            Dim adaptador = New SqlClient.SqlDataAdapter(comando)
            MiDataAdapter.Fill(dtTabla)
            FormArticulos.dgvLista.DataSource = dtTabla

            conectorSQL.Close()
        Catch ex As Exception
            MsgBox("ERROR AL CONECTAR")
        End Try
    End Sub

    Public Sub ActualizarDgvEmpleados()
        Dim dtTabla As New DataTable
        Dim sql = "SELECT * FROM Empleados"

        Try
            Dim conectorSQL = New SqlClient.SqlConnection(CadenaConexion)
            conectorSQL.Open()
            Dim comando = New SqlClient.SqlCommand(sql, conectorSQL)

            Dim adaptador = New SqlClient.SqlDataAdapter(comando)
            MiDataAdapter2.Fill(dtTabla)
            FormEmpleados.dgvLista.DataSource = dtTabla

            conectorSQL.Close()
        Catch ex As Exception
            MsgBox("ERROR AL CONECTAR")
        End Try
    End Sub

End Class
