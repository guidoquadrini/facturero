<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ReportViewer
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CR_ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        '  Me.CrystalReport11 = New Reporting.CrystalReport1()
        Me.SuspendLayout()
        '
        'CR_ReportViewer
        '
        Me.CR_ReportViewer.ActiveViewIndex = 0
        Me.CR_ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_ReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CR_ReportViewer.Name = "CR_ReportViewer"
        'Me.CR_ReportViewer.ReportSource = Me.CrystalReport11
        Me.CR_ReportViewer.Size = New System.Drawing.Size(792, 566)
        Me.CR_ReportViewer.TabIndex = 0
        '
        'FRM_ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.CR_ReportViewer)
        Me.Name = "FRM_ReportViewer"
        Me.Text = "Visualizador de Reportes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CR_ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents CrystalReport11 As CrystalReport1

End Class
