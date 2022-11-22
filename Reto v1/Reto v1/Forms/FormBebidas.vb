Public Class FormBebidas

    Public conexion As New Conexion

    Private Sub FormBebidas_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Public Sub dgvBebidas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBebidas.CellClick
        Module1.setId(dgvBebidas.SelectedCells.Item(0).Value)
        Module1.setPrecio(dgvBebidas.SelectedCells.Item(2).Value)
    End Sub

    Private Sub editarCols()
        dgvBebidas.Columns(0).Visible = False
    End Sub

    Private Sub CargarTodo()
        conexion.Conectar()
        Dim MiDataRow As DataRow
        MiDataRow = conexion.MiDataSet2.Tables("Articulos").Rows(0)

        dgvBebidas.DataSource = conexion.MiDataSet2
        dgvBebidas.DataMember = "Articulos"
    End Sub

End Class