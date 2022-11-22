Public Class FormEntrantes
    Public conexion As New Conexion

    Private Sub FormEntrantes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarTodo()
        editarCols()
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        WindowState = FormWindowState.Maximized
    End Sub

    Public Sub dgvEntrantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntrantes.CellClick
        Module1.setId(dgvEntrantes.SelectedCells.Item(0).Value)
        Module1.setPrecio(dgvEntrantes.SelectedCells.Item(2).Value)
    End Sub

    Private Sub editarCols()
        dgvEntrantes.Columns(0).Visible = False
    End Sub

    Private Sub CargarTodo()
        conexion.Conectar()
        Dim MiDataRow As DataRow
        MiDataRow = conexion.MiDataSet3.Tables("Articulos").Rows(0)

        dgvEntrantes.DataSource = conexion.MiDataSet3
        dgvEntrantes.DataMember = "Articulos"
    End Sub
End Class