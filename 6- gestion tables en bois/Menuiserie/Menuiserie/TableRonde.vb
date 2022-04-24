Module TableRonde
    Function volume_Rond(ByVal diametre_table_ronde As Double, ByVal epaisseur_table_ronde As Double) As Double
        Return (diametre_table_ronde * diametre_table_ronde * 2 * 0.25 * 3.14 * epaisseur_table_ronde)
    End Function
    Function volume_pieds_rond(ByVal diametre_table_ronde As Double, ByVal hauteur_table_ronde As Double, ByVal epaisseur_table_ronde As Double) As Double
        Return (Format(0.08 * diametre_table_ronde ^ 2 * 3.14 * (hauteur_table_ronde - epaisseur_table_ronde), "#0.00"))
    End Function
End Module
