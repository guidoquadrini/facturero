<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EnviarA
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Email", 2)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Facebook", 1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("WhatsApp", 6)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Reporte", 5)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Imprimir", 4)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("PDF", 3)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Excel", 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_EnviarA))
        Me.ListView_Estrategias = New System.Windows.Forms.ListView()
        Me.ImageList_Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ListView_Estrategias
        '
        Me.ListView_Estrategias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_Estrategias.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
        Me.ListView_Estrategias.LargeImageList = Me.ImageList_Icons
        Me.ListView_Estrategias.Location = New System.Drawing.Point(0, 0)
        Me.ListView_Estrategias.MultiSelect = False
        Me.ListView_Estrategias.Name = "ListView_Estrategias"
        Me.ListView_Estrategias.Size = New System.Drawing.Size(767, 76)
        Me.ListView_Estrategias.TabIndex = 0
        Me.ListView_Estrategias.UseCompatibleStateImageBehavior = False
        '
        'ImageList_Icons
        '
        Me.ImageList_Icons.ImageStream = CType(resources.GetObject("ImageList_Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Icons.Images.SetKeyName(0, "excel_logo-48.png")
        Me.ImageList_Icons.Images.SetKeyName(1, "facebook-48.png")
        Me.ImageList_Icons.Images.SetKeyName(2, "message_outline-48.png")
        Me.ImageList_Icons.Images.SetKeyName(3, "pdf-48.png")
        Me.ImageList_Icons.Images.SetKeyName(4, "print-48.png")
        Me.ImageList_Icons.Images.SetKeyName(5, "ratings-48.png")
        Me.ImageList_Icons.Images.SetKeyName(6, "whatsapp-48.png")
        '
        'Form_EnviarA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 76)
        Me.Controls.Add(Me.ListView_Estrategias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_EnviarA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Elija el metodo de envio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView_Estrategias As System.Windows.Forms.ListView
    Friend WithEvents ImageList_Icons As System.Windows.Forms.ImageList
End Class
