﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajaProducto))
        Me.LblIngresarDato = New System.Windows.Forms.Label()
        Me.PictureBajaProducto = New System.Windows.Forms.PictureBox()
        Me.LblBajaProducto = New System.Windows.Forms.Label()
        Me.TxtIngresarDato = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DGVBajaProducto = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBajaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBajaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIngresarDato
        '
        Me.LblIngresarDato.AutoSize = True
        Me.LblIngresarDato.Location = New System.Drawing.Point(39, 172)
        Me.LblIngresarDato.Name = "LblIngresarDato"
        Me.LblIngresarDato.Size = New System.Drawing.Size(69, 13)
        Me.LblIngresarDato.TabIndex = 1
        Me.LblIngresarDato.Text = "Ingresar dato"
        '
        'PictureBajaProducto
        '
        Me.PictureBajaProducto.Image = CType(resources.GetObject("PictureBajaProducto.Image"), System.Drawing.Image)
        Me.PictureBajaProducto.Location = New System.Drawing.Point(516, 58)
        Me.PictureBajaProducto.Name = "PictureBajaProducto"
        Me.PictureBajaProducto.Size = New System.Drawing.Size(218, 167)
        Me.PictureBajaProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBajaProducto.TabIndex = 2
        Me.PictureBajaProducto.TabStop = False
        '
        'LblBajaProducto
        '
        Me.LblBajaProducto.AutoSize = True
        Me.LblBajaProducto.Location = New System.Drawing.Point(586, 42)
        Me.LblBajaProducto.Name = "LblBajaProducto"
        Me.LblBajaProducto.Size = New System.Drawing.Size(88, 13)
        Me.LblBajaProducto.TabIndex = 3
        Me.LblBajaProducto.Text = "Baja de producto"
        '
        'TxtIngresarDato
        '
        Me.TxtIngresarDato.Location = New System.Drawing.Point(122, 169)
        Me.TxtIngresarDato.Name = "TxtIngresarDato"
        Me.TxtIngresarDato.Size = New System.Drawing.Size(121, 20)
        Me.TxtIngresarDato.TabIndex = 5
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(312, 162)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(150, 434)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(599, 434)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DGVBajaProducto
        '
        Me.DGVBajaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBajaProducto.Location = New System.Drawing.Point(42, 256)
        Me.DGVBajaProducto.Name = "DGVBajaProducto"
        Me.DGVBajaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVBajaProducto.Size = New System.Drawing.Size(812, 150)
        Me.DGVBajaProducto.TabIndex = 9
        '
        'FrmBajaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 475)
        Me.Controls.Add(Me.DGVBajaProducto)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtIngresarDato)
        Me.Controls.Add(Me.LblBajaProducto)
        Me.Controls.Add(Me.PictureBajaProducto)
        Me.Controls.Add(Me.LblIngresarDato)
        Me.Name = "FrmBajaProducto"
        Me.Text = "Asistente para eliminar producto"
        CType(Me.PictureBajaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBajaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIngresarDato As Label
    Friend WithEvents PictureBajaProducto As PictureBox
    Friend WithEvents LblBajaProducto As Label
    Friend WithEvents TxtIngresarDato As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DGVBajaProducto As DataGridView
End Class
