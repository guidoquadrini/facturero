Public Class frm_cliente
    Dim Clientes As Controller.Ctrl_Clientes

    Private Sub frm_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clientes = New Controller.Ctrl_Clientes()
        dgv_clientes.DataSource = Clientes.ObtenerCatalogo
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class