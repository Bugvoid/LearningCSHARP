Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
        ''Sai do form
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal) ''Coloca as janelas abertas alinhadas horizontalmente
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical) ''Coloca as janelas abertas alinhadas vertical
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade) ''Coloca as janelas abertas alinhadas em cascata
    End Sub

    Private Sub IncluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncluirToolStripMenuItem.Click
        Dim incluir As New Incluir
        incluir.MdiParent = Me ''Permite que o form filho seja aberto dentro do FORM MDI
        incluir.Show() ''Chama o form Incluir, lembrar de declarar o form
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim excluir As New Excluir
        excluir.MdiParent = Me ''Permite que o form filho seja aberto dentro do FORM MDI
        excluir.Show() ''Chama o form Excluir, lembrar de declarar o form
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarToolStripMenuItem.Click
        Dim alterar As New Alterar
        alterar.MdiParent = Me ''Permite que o form filho seja aberto dentro do FORM MDI
        alterar.Show() ''Chama o form alterar, lembrar de declarar o form
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim consultar As New Consultar
        consultar.MdiParent = Me ''Permite que o form filho seja aberto dentro do FORM MDI
        consultar.Show() ''Chama o form consultar, lembrar de declarar o form
    End Sub
End Class
