<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMC_Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_Clientes = New System.Windows.Forms.DataGridView()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox_Filtro = New System.Windows.Forms.TextBox()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.BTN_Agregar = New System.Windows.Forms.Button()
        Me.BTN_Modificar = New System.Windows.Forms.Button()
        Me.BTN_Borrar = New System.Windows.Forms.Button()
        Me.BTN_Ayuda = New System.Windows.Forms.Button()
        Me.GRP_Herramientas = New System.Windows.Forms.GroupBox()
        Me.BTN_EnviarA = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip_AMBC = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_Herramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.AllowUserToAddRows = False
        Me.DGV_Clientes.AllowUserToDeleteRows = False
        Me.DGV_Clientes.AllowUserToOrderColumns = True
        Me.DGV_Clientes.AutoGenerateColumns = False
        Me.DGV_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.DGV_Clientes.DataSource = Me.ClienteBindingSource
        Me.DGV_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Clientes.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Clientes.Location = New System.Drawing.Point(0, 66)
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.ReadOnly = True
        Me.DGV_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Clientes.Size = New System.Drawing.Size(915, 299)
        Me.DGV_Clientes.TabIndex = 0
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(Model.Cliente)
        '
        'TextBox_Filtro
        '
        Me.TextBox_Filtro.Location = New System.Drawing.Point(6, 24)
        Me.TextBox_Filtro.Name = "TextBox_Filtro"
        Me.TextBox_Filtro.Size = New System.Drawing.Size(440, 20)
        Me.TextBox_Filtro.TabIndex = 2
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(802, 3)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(110, 25)
        Me.BTN_Salir.TabIndex = 6
        Me.BTN_Salir.Text = "Cerrar"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'BTN_Agregar
        '
        Me.BTN_Agregar.Location = New System.Drawing.Point(8, 18)
        Me.BTN_Agregar.Name = "BTN_Agregar"
        Me.BTN_Agregar.Size = New System.Drawing.Size(65, 31)
        Me.BTN_Agregar.TabIndex = 7
        Me.BTN_Agregar.Text = "Agregar"
        Me.BTN_Agregar.UseVisualStyleBackColor = True
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Location = New System.Drawing.Point(79, 18)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(65, 31)
        Me.BTN_Modificar.TabIndex = 9
        Me.BTN_Modificar.Text = "Modificar"
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'BTN_Borrar
        '
        Me.BTN_Borrar.Location = New System.Drawing.Point(150, 18)
        Me.BTN_Borrar.Name = "BTN_Borrar"
        Me.BTN_Borrar.Size = New System.Drawing.Size(65, 31)
        Me.BTN_Borrar.TabIndex = 10
        Me.BTN_Borrar.Text = "Borrar"
        Me.BTN_Borrar.UseVisualStyleBackColor = True
        '
        'BTN_Ayuda
        '
        Me.BTN_Ayuda.Location = New System.Drawing.Point(221, 18)
        Me.BTN_Ayuda.Name = "BTN_Ayuda"
        Me.BTN_Ayuda.Size = New System.Drawing.Size(65, 31)
        Me.BTN_Ayuda.TabIndex = 11
        Me.BTN_Ayuda.Text = "Ayuda"
        Me.BTN_Ayuda.UseVisualStyleBackColor = True
        '
        'GRP_Herramientas
        '
        Me.GRP_Herramientas.Controls.Add(Me.BTN_Ayuda)
        Me.GRP_Herramientas.Controls.Add(Me.BTN_Agregar)
        Me.GRP_Herramientas.Controls.Add(Me.BTN_Borrar)
        Me.GRP_Herramientas.Controls.Add(Me.BTN_Modificar)
        Me.GRP_Herramientas.Location = New System.Drawing.Point(617, 3)
        Me.GRP_Herramientas.Name = "GRP_Herramientas"
        Me.GRP_Herramientas.Size = New System.Drawing.Size(295, 55)
        Me.GRP_Herramientas.TabIndex = 12
        Me.GRP_Herramientas.TabStop = False
        Me.GRP_Herramientas.Text = "Herramientas"
        '
        'BTN_EnviarA
        '
        Me.BTN_EnviarA.Location = New System.Drawing.Point(3, 3)
        Me.BTN_EnviarA.Name = "BTN_EnviarA"
        Me.BTN_EnviarA.Size = New System.Drawing.Size(110, 25)
        Me.BTN_EnviarA.TabIndex = 15
        Me.BTN_EnviarA.Text = "Enviar a ..."
        Me.BTN_EnviarA.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Filtro)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 55)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda Inteligente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 66)
        Me.Panel1.TabIndex = 19
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GRP_Herramientas, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(915, 66)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 365)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(915, 37)
        Me.Panel2.TabIndex = 20
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.BTN_EnviarA, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BTN_Salir, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(915, 31)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdCliente"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PrimerNombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PrimerNombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 98
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombreEmpresa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NombreEmpresa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "eMail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "eMail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 57
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Direccion1"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Direccion1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 83
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Direccion2"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Direccion2"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 83
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 65
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Provincia"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 76
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CodigoPostal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CodigoPostal"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 94
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Pais"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Pais"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 52
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 74
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 86
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 71
        '
        'ABMC_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 402)
        Me.Controls.Add(Me.DGV_Clientes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ABMC_Clientes"
        Me.Text = "Maestro de Clientes"
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_Herramientas.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox_Filtro As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Salir As System.Windows.Forms.Button
    Friend WithEvents BTN_Agregar As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents BTN_Borrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Ayuda As System.Windows.Forms.Button
    Friend WithEvents GRP_Herramientas As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_EnviarA As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip_AMBC As System.Windows.Forms.ToolTip
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
