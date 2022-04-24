Public Class frmPizza
    Dim taillepizza As String
    Dim croutepizza As String
    Dim oùpizza As String
    Dim Message As String
    Private Sub Sortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sortir.Click
        End
    End Sub
    Private Sub taille1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles taille1.CheckedChanged
        taillepizza = "Petite"
    End Sub
    Private Sub taille2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles taille2.CheckedChanged
        taillepizza = "Moyenne"
    End Sub
    Private Sub croute1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles croute1.CheckedChanged
        croutepizza = "Croûte fine"
    End Sub
    Private Sub croute2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles croute2.CheckedChanged
        croutepizza = "Croûte épaisse"
    End Sub
    Private Sub où1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles où1.CheckedChanged
        oùpizza = "Sur place"
    End Sub
    Private Sub où2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles où2.CheckedChanged
        oùpizza = "A emporter"
    End Sub
    Private Sub Fabriquer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fabriquer.Click
        Message = oùpizza + vbCr
        Message = Message + taillepizza + " Pizza" + vbCr
        Message = Message + croutepizza + vbCr + vbCr
        If igr1.Checked = True Then
            Message = Message + igr1.Text + vbCr
        End If
        If igr2.Checked = True Then
            Message = Message + igr2.Text + vbCr
        End If
        If igr3.Checked = True Then
            Message = Message + igr3.Text + vbCr
        End If
        If igr4.Checked = True Then
            Message = Message + igr4.Text + vbCr
        End If
        If igr5.Checked = True Then
            Message = Message + igr5.Text + vbCr
        End If
        If igr6.Checked = True Then
            Message = Message + igr6.Text + vbCr
        End If
        If igr1.Checked = False And igr2.Checked = False And igr3.Checked = False And igr4.Checked = False And igr5.Checked = False And igr6.Checked = False Then
            Message = oùpizza + vbCr + taillepizza + " pizza" + vbCr + croutepizza + vbCr + "Seulement Fromage!!"
        End If
            MsgBox(Message, vbOKOnly, "Votre Pizza")
    End Sub
    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        taille1.Checked = True
        croute1.Checked = True
        où1.Checked = True
        igr1.Checked = False
        igr2.Checked = False
        igr3.Checked = False
        igr4.Checked = False
        igr5.Checked = False
        igr6.Checked = False
    End Sub
End Class