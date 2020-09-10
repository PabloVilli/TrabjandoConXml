<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeerToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LeerToolStripMenuItem
        '
        Me.LeerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeerToolStripMenuItem1, Me.MoverToolStripMenuItem})
        Me.LeerToolStripMenuItem.Name = "LeerToolStripMenuItem"
        Me.LeerToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.LeerToolStripMenuItem.Text = "Xml"
        '
        'LeerToolStripMenuItem1
        '
        Me.LeerToolStripMenuItem1.Name = "LeerToolStripMenuItem1"
        Me.LeerToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LeerToolStripMenuItem1.Text = "Leer"
        '
        'MoverToolStripMenuItem
        '
        Me.MoverToolStripMenuItem.Name = "MoverToolStripMenuItem"
        Me.MoverToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MoverToolStripMenuItem.Text = "Mover"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(13, 46)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(1329, 638)
        Me.dgv1.TabIndex = 7
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(13, 27)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(235, 13)
        Me.lb1.TabIndex = 8
        Me.lb1.Text = "______________________________________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 696)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LeerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
