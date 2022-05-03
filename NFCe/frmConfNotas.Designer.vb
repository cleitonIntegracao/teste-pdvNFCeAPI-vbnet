<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfNotas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfNotas))
        Me.btnConsContig = New System.Windows.Forms.Button()
        Me.GridConti = New System.Windows.Forms.DataGridView()
        CType(Me.GridConti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsContig
        '
        Me.btnConsContig.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnConsContig.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConsContig.Location = New System.Drawing.Point(16, 12)
        Me.btnConsContig.Name = "btnConsContig"
        Me.btnConsContig.Size = New System.Drawing.Size(123, 35)
        Me.btnConsContig.TabIndex = 2
        Me.btnConsContig.Text = "Contingencia Ret"
        Me.btnConsContig.UseVisualStyleBackColor = False
        '
        'GridConti
        '
        Me.GridConti.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GridConti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridConti.Location = New System.Drawing.Point(12, 53)
        Me.GridConti.Name = "GridConti"
        Me.GridConti.Size = New System.Drawing.Size(1005, 478)
        Me.GridConti.TabIndex = 10
        '
        'frmConfNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1029, 543)
        Me.Controls.Add(Me.GridConti)
        Me.Controls.Add(Me.btnConsContig)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfNotas"
        Me.Text = "frmConfNotas"
        CType(Me.GridConti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConsContig As Button
    Friend WithEvents GridConti As DataGridView
End Class
