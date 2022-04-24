Public Class fenetreprincipale
    'Private Sub fenetreprincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim PrixCoupe, PrixSoin As New ArrayList
    'PrixCoupe.Add(New PrixCoupe("Coupe enfant", 40))
    'PrixCoupe.Add(New PrixCoupe("Coupe adulte", 60))
    'PrixSoin.Add(New PrixSoin("Shampoing", 35))
    'PrixSoin.Add(New PrixSoin("Coloration", 40))
    'PrixSoin.Add(New PrixSoin("Lotion", 20))
    'combocoupe.DataSource = PrixCoupe
    'listesoin.DataSource = PrixSoin
    '''''''''''''''''''''''''''''''''''''''''''Comment faire pour créer une bdd ???
    'End Sub

    Dim tarifcoupe, tarifsoin As Decimal
    Private Sub boutonnewsoin_Click(sender As Object, e As EventArgs) Handles boutonnewsoin.Click
        nouveausoin.Show()
    End Sub
    Private Sub quitter_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Dim MessageBox = MsgBox("Voulez-vous quitter ?", vbOKCancel, "Salon de coiffure")
        If MessageBox = MsgBoxResult.Ok Then End
        If MessageBox = MsgBoxResult.Cancel Then Exit Sub
    End Sub


    Private Sub ÀProposToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÀProposToolStripMenuItem1.Click
        Form3.Show()
    End Sub
    Private Sub QuitterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem1.Click
        End
    End Sub

    Private Sub calculer_Click(sender As Object, e As EventArgs) Handles calculer.Click
        If combocoupe.SelectedItem = "coupe enfant" Then tarifcoupe = 40
        If combocoupe.SelectedItem = "coupe adulte" Then tarifcoupe = 60
        tarifsoin = 0
        Dim nomsoins As String
        nomsoins = ""
        Dim index As Integer
        index = 0
        If listesoin.SelectedIndex = -1 Then
    End Sub
        else if
        nomsoins += listesoin.SelectedItems.Item(index)
        If nomsoins.Contains("Shampoing") Then
            tarifsoin += 40
        End If
        Next
        prixaffiche.Text = tarifsoin + tarifcoupe
        tarifsoin = 0
        tarifcoupe = 0
    End Sub

End Class