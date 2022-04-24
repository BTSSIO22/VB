Public Class Form1
    Private Sub calculer_ronde_Click(sender As Object, e As EventArgs) Handles calculer_ronde.Click
        If IsNumeric(hauteur_table_ronde.Text) And IsNumeric(epaisseur_table_ronde.Text) And IsNumeric(diametre_table_ronde.Text) = True Then
            volume.Text = volume_Rond(diametre_table_ronde.Text, epaisseur_table_ronde.Text) + volume_pieds_rond(diametre_table_ronde.Text, hauteur_table_ronde.Text, epaisseur_table_ronde.Text)
            Dim mo_nombre As Double
            If Val(volume.Text) <= 0.1 Then
                mo_nombre = 10 * heure_mo.Text
            Else : mo_nombre = 12 * heure_mo.Text
            End If
            mo.Text = mo_nombre.ToString + ""
            Dim cout_nombre As Double
            cout_nombre = Val(volume.Text) + mo_nombre + (volume.Text) * cout_bois.Text
            cout.Text = cout_nombre.ToString
        Else : MsgBox("Erreur détectée, veuillez vérifier les valeurs", vbOKOnly)
            Exit Sub
        End If
    End Sub
    Private Sub calculer_rectangle_Click(sender As Object, e As EventArgs) Handles calculer_rectangle.Click
        If IsNumeric(hauteur_table_rectangulaire.Text) And IsNumeric(epaisseur_table_rectangulaire.Text) And IsNumeric(longueur_table_rectangulaire.Text) And IsNumeric(largeur_table_rectangulaire.Text) = True Then
            volume_table_rectangulaire.Text = volume_Rectangle(longueur_table_rectangulaire.Text, largeur_table_rectangulaire.Text, epaisseur_table_rectangulaire.Text) + volume_pieds_carres(longueur_table_rectangulaire.Text, largeur_table_rectangulaire.Text, hauteur_table_rectangulaire.Text, epaisseur_table_rectangulaire.Text)
            If volume_table_rectangulaire.Text <= 0.1 Then
                mo_table_rectangulaire.Text = 10 * heure_mo.Text
            Else : mo_table_rectangulaire.Text = 12 * heure_mo.Text
            End If
            cout_table_rectangulaire.Text = Format(Val(volume_table_rectangulaire.Text * cout_bois.Text + mo_table_rectangulaire.Text), "#0.00")
            coeff = 1
        Else : MsgBox("Erreur détectée, veuillez vérifier les valeurs", vbOKOnly)
            Exit Sub
        End If
    End Sub
    Private Sub calculer_ovale_Click(sender As Object, e As EventArgs) Handles calculer_ovale.Click
        If IsNumeric(hauteur_table_ovale.Text) And IsNumeric(epaisseur_table_ovale.Text) And IsNumeric(longueur_table_ovale.Text) And IsNumeric(largeur_table_ovale.Text) = True Then
            volume_table_ovale.Text = volume_Ovale(longueur_table_ovale.Text, largeur_table_ovale.Text, epaisseur_table_ovale.Text) + volume_pieds_ovale(longueur_table_ovale.Text, largeur_table_ovale.Text, hauteur_table_ovale.Text, epaisseur_table_ovale.Text)
            If Val(volume_table_ovale.Text) <= 0.1 Then
                mo_table_ovale.Text = 10 * heure_mo.Text
            Else : mo_table_ovale.Text = 12 * heure_mo.Text
            End If
            cout_table_ovale.Text = Format(Val(volume_table_ovale.Text * cout_bois.Text + mo_table_ovale.Text), "#0.00")
        Else : MsgBox("Erreur détectée, veuillez vérifier les valeurs", vbOKOnly)
            Exit Sub
        End If
    End Sub
    Private Sub bouton_bordure_Click(sender As Object, e As EventArgs) Handles bouton_bordure.Click
        Dialog1.Show()
    End Sub
End Class