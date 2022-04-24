Module TableOvale
    Function volume_Ovale(ByVal longueur_table_ovale As Double, ByVal largeur_table_ovale As Double, ByVal epaisseur_table_ovale As Double) As Double
        Return (Format(longueur_table_ovale * largeur_table_ovale * epaisseur_table_ovale * 3.14, "#0.00"))
    End Function
    Function volume_pieds_ovale(longueur_table_ovale, largeur_table_ovale, hauteur_table_ovale, epaisseur_table_ovale) As Double
        volume_pieds_ovale = longueur_table_ovale * largeur_table_ovale * (hauteur_table_ovale - epaisseur_table_ovale) * 3.14 * 0.08
        Return (Format(volume_pieds_ovale, "#0.00"))
    End Function
End Module