<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Cliente
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
        Me.Panel_Abajo = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Guadar = New System.Windows.Forms.Button()
        Me.BTN_Cancelar = New System.Windows.Forms.Button()
        Me.Panel_Arriba = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox_Icon = New System.Windows.Forms.PictureBox()
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Apellido = New System.Windows.Forms.TextBox()
        Me.TextBox_Empresa = New System.Windows.Forms.TextBox()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.TextBox_Direccion = New System.Windows.Forms.TextBox()
        Me.TextBox_Direccion2 = New System.Windows.Forms.TextBox()
        Me.TextBox_Ciudad = New System.Windows.Forms.TextBox()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.TextBox_Moneda = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefono = New System.Windows.Forms.TextBox()
        Me.TextBox_Pais = New System.Windows.Forms.TextBox()
        Me.TextBox_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.TextBox_Provincia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel_Abajo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_Arriba.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Abajo
        '
        Me.Panel_Abajo.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel_Abajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Abajo.Location = New System.Drawing.Point(0, 333)
        Me.Panel_Abajo.Name = "Panel_Abajo"
        Me.Panel_Abajo.Size = New System.Drawing.Size(577, 67)
        Me.Panel_Abajo.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(577, 67)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Guadar)
        Me.GroupBox1.Controls.Add(Me.BTN_Cancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(424, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 58)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'Button_Guadar
        '
        Me.Button_Guadar.Location = New System.Drawing.Point(6, 19)
        Me.Button_Guadar.Name = "Button_Guadar"
        Me.Button_Guadar.Size = New System.Drawing.Size(65, 31)
        Me.Button_Guadar.TabIndex = 9
        Me.Button_Guadar.Text = "Guardar"
        Me.Button_Guadar.UseVisualStyleBackColor = True
        '
        'BTN_Cancelar
        '
        Me.BTN_Cancelar.Location = New System.Drawing.Point(77, 19)
        Me.BTN_Cancelar.Name = "BTN_Cancelar"
        Me.BTN_Cancelar.Size = New System.Drawing.Size(65, 31)
        Me.BTN_Cancelar.TabIndex = 8
        Me.BTN_Cancelar.Text = "Cencelar"
        Me.BTN_Cancelar.UseVisualStyleBackColor = True
        '
        'Panel_Arriba
        '
        Me.Panel_Arriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Arriba.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel_Arriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Arriba.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Arriba.Name = "Panel_Arriba"
        Me.Panel_Arriba.Size = New System.Drawing.Size(577, 54)
        Me.Panel_Arriba.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.43284!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.56716!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox_Icon, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label_Titulo, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(575, 52)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'PictureBox_Icon
        '
        Me.PictureBox_Icon.Image = Global.View.My.Resources.Resources.pencil_48
        Me.PictureBox_Icon.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox_Icon.Name = "PictureBox_Icon"
        Me.PictureBox_Icon.Size = New System.Drawing.Size(47, 48)
        Me.PictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_Icon.TabIndex = 1
        Me.PictureBox_Icon.TabStop = False
        '
        'Label_Titulo
        '
        Me.Label_Titulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(56, 0)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(335, 54)
        Me.Label_Titulo.TabIndex = 0
        Me.Label_Titulo.Text = "Alta / Edicion de Cliente"
        Me.Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Enabled = False
        Me.TextBox_ID.Location = New System.Drawing.Point(89, 106)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_ID.TabIndex = 3
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(89, 132)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Nombre.TabIndex = 4
        '
        'TextBox_Apellido
        '
        Me.TextBox_Apellido.Location = New System.Drawing.Point(89, 158)
        Me.TextBox_Apellido.Name = "TextBox_Apellido"
        Me.TextBox_Apellido.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Apellido.TabIndex = 5
        '
        'TextBox_Empresa
        '
        Me.TextBox_Empresa.Location = New System.Drawing.Point(89, 184)
        Me.TextBox_Empresa.Name = "TextBox_Empresa"
        Me.TextBox_Empresa.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Empresa.TabIndex = 6
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Location = New System.Drawing.Point(89, 210)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Email.TabIndex = 7
        '
        'TextBox_Direccion
        '
        Me.TextBox_Direccion.Location = New System.Drawing.Point(89, 236)
        Me.TextBox_Direccion.Name = "TextBox_Direccion"
        Me.TextBox_Direccion.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Direccion.TabIndex = 8
        '
        'TextBox_Direccion2
        '
        Me.TextBox_Direccion2.Location = New System.Drawing.Point(89, 262)
        Me.TextBox_Direccion2.Name = "TextBox_Direccion2"
        Me.TextBox_Direccion2.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Direccion2.TabIndex = 9
        '
        'TextBox_Ciudad
        '
        Me.TextBox_Ciudad.Location = New System.Drawing.Point(376, 106)
        Me.TextBox_Ciudad.Name = "TextBox_Ciudad"
        Me.TextBox_Ciudad.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Ciudad.TabIndex = 10
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(376, 236)
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Contraseña.TabIndex = 11
        '
        'TextBox_Moneda
        '
        Me.TextBox_Moneda.Location = New System.Drawing.Point(376, 210)
        Me.TextBox_Moneda.Name = "TextBox_Moneda"
        Me.TextBox_Moneda.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Moneda.TabIndex = 12
        '
        'TextBox_Telefono
        '
        Me.TextBox_Telefono.Location = New System.Drawing.Point(89, 288)
        Me.TextBox_Telefono.Name = "TextBox_Telefono"
        Me.TextBox_Telefono.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Telefono.TabIndex = 13
        '
        'TextBox_Pais
        '
        Me.TextBox_Pais.Location = New System.Drawing.Point(376, 184)
        Me.TextBox_Pais.Name = "TextBox_Pais"
        Me.TextBox_Pais.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Pais.TabIndex = 14
        '
        'TextBox_CodigoPostal
        '
        Me.TextBox_CodigoPostal.Location = New System.Drawing.Point(376, 158)
        Me.TextBox_CodigoPostal.Name = "TextBox_CodigoPostal"
        Me.TextBox_CodigoPostal.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_CodigoPostal.TabIndex = 15
        '
        'TextBox_Provincia
        '
        Me.TextBox_Provincia.Location = New System.Drawing.Point(376, 132)
        Me.TextBox_Provincia.Name = "TextBox_Provincia"
        Me.TextBox_Provincia.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Provincia.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Moneda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Provincia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(337, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Pais"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Empresa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(324, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Ciudad"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(292, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Codigo Postal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 291)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Telefono"
        '
        'Form_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 400)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Provincia)
        Me.Controls.Add(Me.TextBox_CodigoPostal)
        Me.Controls.Add(Me.TextBox_Pais)
        Me.Controls.Add(Me.TextBox_Telefono)
        Me.Controls.Add(Me.TextBox_Moneda)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.TextBox_Ciudad)
        Me.Controls.Add(Me.TextBox_Direccion2)
        Me.Controls.Add(Me.TextBox_Direccion)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.TextBox_Empresa)
        Me.Controls.Add(Me.TextBox_Apellido)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Panel_Arriba)
        Me.Controls.Add(Me.Panel_Abajo)
        Me.Name = "Form_Cliente"
        Me.Text = "Formulario de Alta / Edicion"
        Me.Panel_Abajo.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel_Arriba.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_Abajo As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_Arriba As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Guadar As System.Windows.Forms.Button
    Friend WithEvents BTN_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label_Titulo As System.Windows.Forms.Label
    Friend WithEvents TextBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Email As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Direccion2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Moneda As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Pais As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_CodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Provincia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Icon As System.Windows.Forms.PictureBox
End Class
