﻿Imports wflSistema
Public Class FrmNuevoProducto
    Private Sub LblNuevoProducto_Click(sender As Object, e As EventArgs) Handles LblNuevoProducto.Click

    End Sub

    Private Sub FrmNuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblEstado_Click(sender As Object, e As EventArgs) Handles LblEstado.Click

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim x As New wflClientes


        x.NuevoProducto(
                         TxtNombre.Text,
                         TxtMarca.Text,
                         TxtDetalle.Text,
                         TxtCantidad.Text,
                         CBEstado.Text,
                         cbProducto.Text,
                         TxtObservaciones.Text
                                               )

        TxtNombre.Text = ""
        TxtMarca.Text = ""
        TxtDetalle.Text = ""
        TxtCantidad.Text = ""
        CBEstado.Text = ""
        cbProducto.Text = ""
        TxtObservaciones.Text = ""


    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

    End Sub

    Private Sub cbProducto_MouseClick(sender As Object, e As MouseEventArgs) Handles cbProducto.MouseClick

        Dim x As New wflClientes
        Dim dt As New DataTable

        x.ObtenerProveedor(dt)

        cbProducto.SelectedValue = ""
        cbProducto.Text = ""
        cbProducto.DataSource = dt

        cbProducto.ValueMember = "nombre"

        cbProducto.DisplayMember = "nombre"






    End Sub
End Class