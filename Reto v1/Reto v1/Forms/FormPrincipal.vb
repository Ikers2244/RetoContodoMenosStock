Public Class FormPrincipal
    Public conexion As New Conexion

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Public Sub dgvPrincipal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrincipal.CellClick
        Module1.setId(dgvPrincipal.SelectedCells.Item(0).Value)
        Module1.setPrecio(dgvPrincipal.SelectedCells.Item(2).Value)
    End Sub

    Private Sub editarCols()
        dgvPrincipal.Columns(0).Visible = False
    End Sub

    Private Sub CargarTodo()
        conexion.Conectar()
        Dim MiDataRow As DataRow
        MiDataRow = conexion.MiDataSet4.Tables("Articulos").Rows(0)

        dgvPrincipal.DataSource = conexion.MiDataSet4
        dgvPrincipal.DataMember = "Articulos"
    End Sub
End Class