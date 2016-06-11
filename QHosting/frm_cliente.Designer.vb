<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_buscar_cliente = New System.Windows.Forms.TextBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_buscar_cliente
        '
        Me.txt_buscar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_cliente.Location = New System.Drawing.Point(13, 10)
        Me.txt_buscar_cliente.Name = "txt_buscar_cliente"
        Me.txt_buscar_cliente.Size = New System.Drawing.Size(447, 26)
        Me.txt_buscar_cliente.TabIndex = 30
        Me.txt_buscar_cliente.Text = "Buscar Cliente..."
        '
        'dgv_clientes
        '
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(12, 39)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.Size = New System.Drawing.Size(447, 170)
        Me.dgv_clientes.TabIndex = 29
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(13, 215)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(102, 35)
        Me.btn_nuevo.TabIndex = 31
        Me.btn_nuevo.Text = "Seleccionar"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 35)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 258)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_buscar_cliente)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Name = "frm_cliente"
        Me.Text = "Gestor de Clientes"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_buscar_cliente As TextBox
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents Button3 As Button
End Class
