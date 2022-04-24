Module TableRectangle
    Public coeff = 1
    Function volume_Rectangle(ByVal longueur_table_rectangulaire As Double, ByVal largeur_table_rectangulaire As Double, ByVal epaisseur_table_rectangulaire As Double) As Double
        If Form1.bordure.SelectedItem = "Maximale" Then coeff = 0.7
        If Form1.bordure.SelectedItem = "Moyenne" Then coeff = 0.9
        Return (longueur_table_rectangulaire * largeur_table_rectangulaire * epaisseur_table_rectangulaire * TableRectangle.coeff)
    End Function
    Function volume_pieds_carres(ByVal longueur_table_rectangulaire As Double, ByVal largeur_table_rectangulaire As Double, ByVal hauteur_table_rectangulaire As Double, ByVal epaisseur_table_rectangulaire As Double) As Double
        Return (volume_pieds_carres = 0.04 * longueur_table_rectangulaire * largeur_table_rectangulaire * hauteur_table_rectangulaire - epaisseur_table_rectangulaire)
    End Function
End Module