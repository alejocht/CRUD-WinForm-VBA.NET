﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formularioVentaForm
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
        Me.fechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.btnAgregarItem = New System.Windows.Forms.Button()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fechaPicker
        '
        Me.fechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaPicker.Location = New System.Drawing.Point(102, 70)
        Me.fechaPicker.Name = "fechaPicker"
        Me.fechaPicker.Size = New System.Drawing.Size(200, 20)
        Me.fechaPicker.TabIndex = 0
        '
        'cmbCliente
        '
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(102, 35)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(200, 21)
        Me.cmbCliente.TabIndex = 1
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(29, 42)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(29, 76)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        '
        'dgvItems
        '
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Location = New System.Drawing.Point(22, 151)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.Size = New System.Drawing.Size(348, 218)
        Me.dgvItems.TabIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(272, 408)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(32, 408)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(29, 109)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.Location = New System.Drawing.Point(102, 109)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblImporteTotal.TabIndex = 8
        '
        'btnAgregarItem
        '
        Me.btnAgregarItem.AutoEllipsis = True
        Me.btnAgregarItem.Location = New System.Drawing.Point(295, 122)
        Me.btnAgregarItem.Name = "btnAgregarItem"
        Me.btnAgregarItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarItem.TabIndex = 9
        Me.btnAgregarItem.Text = "Agregar Item"
        Me.btnAgregarItem.UseVisualStyleBackColor = True
        '
        'formularioVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 450)
        Me.Controls.Add(Me.btnAgregarItem)
        Me.Controls.Add(Me.lblImporteTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.fechaPicker)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(411, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(411, 489)
        Me.Name = "formularioVentaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formularioVentaForm"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fechaPicker As DateTimePicker
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents btnAgregarItem As Button
End Class
