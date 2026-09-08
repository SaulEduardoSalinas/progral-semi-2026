<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.LaboratorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EstudiantesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaboratorioToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 30)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'LaboratorioToolStripMenuItem
        '
        Me.LaboratorioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstudiantesToolStripMenuItem, Me.MaestroToolStripMenuItem, Me.DirectoresToolStripMenuItem})
        Me.LaboratorioToolStripMenuItem.Name = "LaboratorioToolStripMenuItem"
        Me.LaboratorioToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.LaboratorioToolStripMenuItem.Text = "laboratorio"
        '
        'EstudiantesToolStripMenuItem
        '
        Me.EstudiantesToolStripMenuItem.Name = "EstudiantesToolStripMenuItem"
        Me.EstudiantesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EstudiantesToolStripMenuItem.Text = "Estudiantes"
        '
        'MaestroToolStripMenuItem
        '
        Me.MaestroToolStripMenuItem.Name = "MaestroToolStripMenuItem"
        Me.MaestroToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MaestroToolStripMenuItem.Text = "Maestro"
        '
        'DirectoresToolStripMenuItem
        '
        Me.DirectoresToolStripMenuItem.Name = "DirectoresToolStripMenuItem"
        Me.DirectoresToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DirectoresToolStripMenuItem.Text = "directores"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstudiantesToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EstudiantesToolStripMenuItem1
        '
        Me.EstudiantesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AestroToolStripMenuItem, Me.DirectoryToolStripMenuItem})
        Me.EstudiantesToolStripMenuItem1.Name = "EstudiantesToolStripMenuItem1"
        Me.EstudiantesToolStripMenuItem1.Size = New System.Drawing.Size(98, 26)
        Me.EstudiantesToolStripMenuItem1.Text = "estudiantes"
        '
        'AestroToolStripMenuItem
        '
        Me.AestroToolStripMenuItem.Name = "AestroToolStripMenuItem"
        Me.AestroToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AestroToolStripMenuItem.Text = "maestro"
        '
        'DirectoryToolStripMenuItem
        '
        Me.DirectoryToolStripMenuItem.Name = "DirectoryToolStripMenuItem"
        Me.DirectoryToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DirectoryToolStripMenuItem.Text = "directory"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents LaboratorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoresToolStripMenuItem As ToolStripMenuItem

    Private Sub MaestroToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaestroToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DirectoreToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudiantesToolStripMenuItem.Click
        Dim FrmEstudia As New fmrestudiantes()

        FrmEstudia.ShowDialog()
    End Sub

    Private Sub MaestroToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MaestroToolStripMenuItem.Click
        Dim FrmMaest As New fmrmaestro()

        FrmMaest.ShowDialog()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EstudiantesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AestroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryToolStripMenuItem As ToolStripMenuItem
End Class
