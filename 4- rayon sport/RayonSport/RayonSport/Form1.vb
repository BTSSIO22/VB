Public Class Form1
    'déclaration des variables
    Dim TEXTENOM, TEXTEAGE, TEXTESEXE, TEXTEVILLE, TEXTEACTIVITE, TEXTENIVEAU, MESSAGE As String
    'Enregistrement des informations entrées sous forme de texte'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Charger la combo avec les villes
        entreeville.Items.AddRange({"St Denis", "Ste Clotilde", "St André", "St Suzanne", "St benoit", "St Joseph", "St Pierre", "St Louis", "L'étang salé", "Les avirons", "St Gilles", "St Leu", "Piton St Leu", "St Paul", "La Possession", "Le Port", "Cilaos"})
    End Sub
    Private Sub entrenom_TextChanged(sender As Object, e As EventArgs) Handles entrenom.TextChanged
        TEXTENOM = entrenom.Text
    End Sub

    Private Sub entreage_TextChanged(sender As Object, e As EventArgs) Handles entreage.TextChanged
        TEXTEAGE = entreage.Text
    End Sub

    Private Sub Masculin_CheckedChanged(sender As Object, e As EventArgs) Handles Masculin.CheckedChanged
        TEXTESEXE = "Mr"
    End Sub
    Private Sub Feminin_CheckedChanged(sender As Object, e As EventArgs) Handles Feminin.CheckedChanged
        TEXTESEXE = "Mme"
    End Sub

    'Private Sub
    'entreeville_TextUpdate(sender As Object, e As EventArgs) Handles entreeville.TextUpdate
    ' TEXTEVILLE = entreeville.Text
    ' End Sub
    ' comment faire pour que l'utilisateur ajoute une nouvelle ville ?

    Private Sub Extreme_CheckedChanged(sender As Object, e As EventArgs) Handles Extreme.CheckedChanged
        TEXTENIVEAU = Extreme.Text()
    End Sub
    Private Sub Avance_Checked(sender As Object, e As EventArgs) Handles Avance.CheckedChanged
        TEXTENIVEAU = Avance.Text()
    End Sub
    Private Sub Intermediaire_Checked(sender As Object, e As EventArgs) Handles Intermediaire.CheckedChanged
        TEXTENIVEAU = Intermediaire.Text()
    End Sub
    Private Sub Debutant_CheckedChanged(sender As Object, e As EventArgs) Handles Debutant.CheckedChanged
        TEXTENIVEAU = Debutant.Text()
    End Sub

    Private Sub AfficherProfil_Click(sender As Object, e As EventArgs) Handles AfficherProfil.Click
        'Affichage du récap
        If Course.Checked = True Then TEXTEACTIVITE += Course.Text + ", "
        If Marche.Checked = True Then TEXTEACTIVITE += Marche.Text + ", "
        If Vélo.Checked = True Then TEXTEACTIVITE += Vélo.Text + ", "
        If Natation.Checked = True Then TEXTEACTIVITE += Natation.Text + ", "
        If Surf.Checked = True Then TEXTEACTIVITE += Surf.Text + ", "
        If LineRoller.Checked = True Then TEXTEACTIVITE += LineRoller.Text + ", "
        MESSAGE = TEXTESEXE + " " + TEXTENOM + ", " + TEXTEAGE + ans.Text + " résidant à " + TEXTEVILLE + vbCr + vbCr + "Activités choisies au niveau " + TEXTENIVEAU + ": " + vbCr + TEXTEACTIVITE
        MsgBox(MESSAGE, vbOKOnly, "votre profil")
    End Sub
    Private Sub NouveauProfilBouton_Click(sender As Object, e As EventArgs) Handles NouveauProfilBouton.Click
        'Mise à blanc du nom et de l'âge et des cases à cocher (position décochée)
        Nom.Text = ""
        Age.Text = ""
        Vélo.Checked = False
        Course.Checked = False
        Natation.Checked = False
        LineRoller.Checked = False
        Surf.Checked = False
        Marche.Checked = False
    End Sub
    Private Sub Sortie_Click(sender As Object, e As EventArgs) Handles Sortie.Click
        End
        'Bouton "sortie"
    End Sub
End Class
