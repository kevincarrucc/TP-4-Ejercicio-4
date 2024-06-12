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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEjecutar = New System.Windows.Forms.Button()
        Me.GrillaMatriz = New System.Windows.Forms.DataGridView()
        Me.GrillaVector = New System.Windows.Forms.DataGridView()
        CType(Me.GrillaMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(390, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEjecutar.Location = New System.Drawing.Point(713, 315)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 1
        Me.BtnEjecutar.Text = "Ejecutar"
        Me.BtnEjecutar.UseVisualStyleBackColor = True
        '
        'GrillaMatriz
        '
        Me.GrillaMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaMatriz.ColumnHeadersVisible = False
        Me.GrillaMatriz.Location = New System.Drawing.Point(12, 31)
        Me.GrillaMatriz.Name = "GrillaMatriz"
        Me.GrillaMatriz.RowHeadersVisible = False
        Me.GrillaMatriz.ShowCellErrors = False
        Me.GrillaMatriz.Size = New System.Drawing.Size(682, 305)
        Me.GrillaMatriz.TabIndex = 2
        '
        'GrillaVector
        '
        Me.GrillaVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaVector.ColumnHeadersVisible = False
        Me.GrillaVector.Location = New System.Drawing.Point(713, 31)
        Me.GrillaVector.Name = "GrillaVector"
        Me.GrillaVector.RowHeadersVisible = False
        Me.GrillaVector.Size = New System.Drawing.Size(75, 278)
        Me.GrillaVector.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GrillaVector)
        Me.Controls.Add(Me.GrillaMatriz)
        Me.Controls.Add(Me.BtnEjecutar)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GrillaMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEjecutar As Button
    Friend WithEvents GrillaMatriz As DataGridView
    Friend WithEvents GrillaVector As DataGridView
End Class
