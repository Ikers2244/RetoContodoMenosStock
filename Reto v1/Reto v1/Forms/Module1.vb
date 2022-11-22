Module Module1
    Dim id = 0
    Dim precio As Double = 0
    Dim idPedidoAnterior = 0
    Dim precioTotal As Double = 0

    Public Sub setId(a As Integer)
        id = a
    End Sub

    Public Function getId()
        Return id
    End Function

    Public Sub setprecioTotal(a As Double)
        precioTotal = a
    End Sub

    Public Function getprecioTotal()
        Return precioTotal
    End Function
    Public Sub setidPedidoAnterior(a As Integer)
        idPedidoAnterior = a
    End Sub

    Public Function getidPedidoAnterior()
        Return idPedidoAnterior
    End Function
    Public Sub setPrecio(a As Double)
        precio = a
    End Sub

    Public Function getPrecio()
        Return precio
    End Function
End Module