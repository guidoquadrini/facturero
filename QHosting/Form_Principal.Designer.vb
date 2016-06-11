<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Principal
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
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.MenuStrip_Principal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirRecientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReHacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReemplazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropiedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestrosDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContenidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.MenuStrip_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'MenuStrip_Principal
        '
        Me.MenuStrip_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdicionToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.MaestrosDeClientesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_Principal.Name = "MenuStrip_Principal"
        Me.MenuStrip_Principal.Size = New System.Drawing.Size(627, 24)
        Me.MenuStrip_Principal.TabIndex = 3
        Me.MenuStrip_Principal.Text = "Manu Principal"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.SalirToolStripMenuItem, Me.AbrirRecientesToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AbrirRecientesToolStripMenuItem
        '
        Me.AbrirRecientesToolStripMenuItem.Name = "AbrirRecientesToolStripMenuItem"
        Me.AbrirRecientesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AbrirRecientesToolStripMenuItem.Text = "Abrir Recientes"
        '
        'EdicionToolStripMenuItem
        '
        Me.EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.ReHacerToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.PegarToolStripMenuItem1, Me.BuscarToolStripMenuItem, Me.ReemplazarToolStripMenuItem, Me.PropiedadesToolStripMenuItem})
        Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdicionToolStripMenuItem.Text = "Edicion"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'ReHacerToolStripMenuItem
        '
        Me.ReHacerToolStripMenuItem.Name = "ReHacerToolStripMenuItem"
        Me.ReHacerToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ReHacerToolStripMenuItem.Text = "Re hacer"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PegarToolStripMenuItem.Text = "Cortar"
        '
        'PegarToolStripMenuItem1
        '
        Me.PegarToolStripMenuItem1.Name = "PegarToolStripMenuItem1"
        Me.PegarToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.PegarToolStripMenuItem1.Text = "Pegar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar..."
        '
        'ReemplazarToolStripMenuItem
        '
        Me.ReemplazarToolStripMenuItem.Name = "ReemplazarToolStripMenuItem"
        Me.ReemplazarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ReemplazarToolStripMenuItem.Text = "Reemplazar..."
        '
        'PropiedadesToolStripMenuItem
        '
        Me.PropiedadesToolStripMenuItem.Name = "PropiedadesToolStripMenuItem"
        Me.PropiedadesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PropiedadesToolStripMenuItem.Text = "Propiedades"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'MaestrosDeClientesToolStripMenuItem
        '
        Me.MaestrosDeClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.HostingToolStripMenuItem})
        Me.MaestrosDeClientesToolStripMenuItem.Name = "MaestrosDeClientesToolStripMenuItem"
        Me.MaestrosDeClientesToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MaestrosDeClientesToolStripMenuItem.Text = "Mantenimiento"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'HostingToolStripMenuItem
        '
        Me.HostingToolStripMenuItem.Name = "HostingToolStripMenuItem"
        Me.HostingToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.HostingToolStripMenuItem.Text = "Hosting"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContenidosToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ContenidosToolStripMenuItem
        '
        Me.ContenidosToolStripMenuItem.Name = "ContenidosToolStripMenuItem"
        Me.ContenidosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ContenidosToolStripMenuItem.Text = "Contenidos"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.Size = New System.Drawing.Size(627, 365)
        '
        'Form_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 411)
        Me.Controls.Add(Me.MenuStrip_Principal)
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip_Principal
        Me.Name = "Form_Principal"
        Me.Text = "Panel de Control"
        Me.MenuStrip_Principal.ResumeLayout(False)
        Me.MenuStrip_Principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents MenuStrip_Principal As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirRecientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReHacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReemplazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropiedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaestrosDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HostingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContenidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel

End Class
