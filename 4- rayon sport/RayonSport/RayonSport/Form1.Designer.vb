<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Sortie = New System.Windows.Forms.Button()
        Me.AfficherProfil = New System.Windows.Forms.Button()
        Me.NouveauProfilBouton = New System.Windows.Forms.Button()
        Me.Course = New System.Windows.Forms.CheckBox()
        Me.Masculin = New System.Windows.Forms.RadioButton()
        Me.Feminin = New System.Windows.Forms.RadioButton()
        Me.Extreme = New System.Windows.Forms.RadioButton()
        Me.Avance = New System.Windows.Forms.RadioButton()
        Me.Intermediaire = New System.Windows.Forms.RadioButton()
        Me.Debutant = New System.Windows.Forms.RadioButton()
        Me.Sexe = New System.Windows.Forms.GroupBox()
        Me.Activites = New System.Windows.Forms.GroupBox()
        Me.LineRoller = New System.Windows.Forms.CheckBox()
        Me.Surf = New System.Windows.Forms.CheckBox()
        Me.Natation = New System.Windows.Forms.CheckBox()
        Me.Vélo = New System.Windows.Forms.CheckBox()
        Me.Marche = New System.Windows.Forms.CheckBox()
        Me.Niveau = New System.Windows.Forms.GroupBox()
        Me.entreeville = New System.Windows.Forms.ComboBox()
        Me.entreage = New System.Windows.Forms.TextBox()
        Me.entrenom = New System.Windows.Forms.TextBox()
        Me.Nom = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.Label()
        Me.ville = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.Label()
        Me.Sexe.SuspendLayout()
        Me.Activites.SuspendLayout()
        Me.Niveau.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sortie
        '
        Me.Sortie.Location = New System.Drawing.Point(603, 476)
        Me.Sortie.Name = "Sortie"
        Me.Sortie.Size = New System.Drawing.Size(75, 23)
        Me.Sortie.TabIndex = 0
        Me.Sortie.Text = "Sortie"
        Me.Sortie.UseVisualStyleBackColor = True
        '
        'AfficherProfil
        '
        Me.AfficherProfil.Location = New System.Drawing.Point(591, 330)
        Me.AfficherProfil.Name = "AfficherProfil"
        Me.AfficherProfil.Size = New System.Drawing.Size(100, 23)
        Me.AfficherProfil.TabIndex = 1
        Me.AfficherProfil.Text = "Afficher le Profil"
        Me.AfficherProfil.UseVisualStyleBackColor = True
        '
        'NouveauProfilBouton
        '
        Me.NouveauProfilBouton.Location = New System.Drawing.Point(591, 404)
        Me.NouveauProfilBouton.Name = "NouveauProfilBouton"
        Me.NouveauProfilBouton.Size = New System.Drawing.Size(105, 23)
        Me.NouveauProfilBouton.TabIndex = 2
        Me.NouveauProfilBouton.Text = "Nouveau Profil"
        Me.NouveauProfilBouton.UseVisualStyleBackColor = True
        '
        'Course
        '
        Me.Course.AutoSize = True
        Me.Course.Location = New System.Drawing.Point(27, 41)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(59, 17)
        Me.Course.TabIndex = 3
        Me.Course.Text = "Course"
        Me.Course.UseVisualStyleBackColor = True
        '
        'Masculin
        '
        Me.Masculin.AutoSize = True
        Me.Masculin.Location = New System.Drawing.Point(33, 34)
        Me.Masculin.Name = "Masculin"
        Me.Masculin.Size = New System.Drawing.Size(67, 17)
        Me.Masculin.TabIndex = 4
        Me.Masculin.TabStop = True
        Me.Masculin.Text = "Masculin"
        Me.Masculin.UseVisualStyleBackColor = True
        '
        'Feminin
        '
        Me.Feminin.AutoSize = True
        Me.Feminin.Location = New System.Drawing.Point(33, 67)
        Me.Feminin.Name = "Feminin"
        Me.Feminin.Size = New System.Drawing.Size(61, 17)
        Me.Feminin.TabIndex = 5
        Me.Feminin.TabStop = True
        Me.Feminin.Text = "Feminin"
        Me.Feminin.UseVisualStyleBackColor = True
        '
        'Extreme
        '
        Me.Extreme.AutoSize = True
        Me.Extreme.Location = New System.Drawing.Point(30, 52)
        Me.Extreme.Name = "Extreme"
        Me.Extreme.Size = New System.Drawing.Size(63, 17)
        Me.Extreme.TabIndex = 6
        Me.Extreme.TabStop = True
        Me.Extreme.Text = "Extrême"
        Me.Extreme.UseVisualStyleBackColor = True
        '
        'Avance
        '
        Me.Avance.AutoSize = True
        Me.Avance.Location = New System.Drawing.Point(30, 90)
        Me.Avance.Name = "Avance"
        Me.Avance.Size = New System.Drawing.Size(62, 17)
        Me.Avance.TabIndex = 7
        Me.Avance.TabStop = True
        Me.Avance.Text = "Avancé"
        Me.Avance.UseVisualStyleBackColor = True
        '
        'Intermediaire
        '
        Me.Intermediaire.AutoSize = True
        Me.Intermediaire.Location = New System.Drawing.Point(30, 136)
        Me.Intermediaire.Name = "Intermediaire"
        Me.Intermediaire.Size = New System.Drawing.Size(79, 17)
        Me.Intermediaire.TabIndex = 8
        Me.Intermediaire.TabStop = True
        Me.Intermediaire.Text = "Itermédiaire"
        Me.Intermediaire.UseVisualStyleBackColor = True
        '
        'Debutant
        '
        Me.Debutant.AutoSize = True
        Me.Debutant.Location = New System.Drawing.Point(30, 173)
        Me.Debutant.Name = "Debutant"
        Me.Debutant.Size = New System.Drawing.Size(69, 17)
        Me.Debutant.TabIndex = 9
        Me.Debutant.TabStop = True
        Me.Debutant.Text = "Debutant"
        Me.Debutant.UseVisualStyleBackColor = True
        '
        'Sexe
        '
        Me.Sexe.Controls.Add(Me.Masculin)
        Me.Sexe.Controls.Add(Me.Feminin)
        Me.Sexe.Location = New System.Drawing.Point(31, 106)
        Me.Sexe.Name = "Sexe"
        Me.Sexe.Size = New System.Drawing.Size(200, 100)
        Me.Sexe.TabIndex = 10
        Me.Sexe.TabStop = False
        Me.Sexe.Text = "Sexe"
        '
        'Activites
        '
        Me.Activites.Controls.Add(Me.LineRoller)
        Me.Activites.Controls.Add(Me.Surf)
        Me.Activites.Controls.Add(Me.Natation)
        Me.Activites.Controls.Add(Me.Vélo)
        Me.Activites.Controls.Add(Me.Marche)
        Me.Activites.Controls.Add(Me.Course)
        Me.Activites.Location = New System.Drawing.Point(31, 226)
        Me.Activites.Name = "Activites"
        Me.Activites.Size = New System.Drawing.Size(200, 320)
        Me.Activites.TabIndex = 0
        Me.Activites.TabStop = False
        Me.Activites.Text = "Activités"
        '
        'LineRoller
        '
        Me.LineRoller.AutoSize = True
        Me.LineRoller.Location = New System.Drawing.Point(27, 277)
        Me.LineRoller.Name = "LineRoller"
        Me.LineRoller.Size = New System.Drawing.Size(76, 17)
        Me.LineRoller.TabIndex = 8
        Me.LineRoller.Text = "Line Roller"
        Me.LineRoller.UseVisualStyleBackColor = True
        '
        'Surf
        '
        Me.Surf.AutoSize = True
        Me.Surf.Location = New System.Drawing.Point(27, 230)
        Me.Surf.Name = "Surf"
        Me.Surf.Size = New System.Drawing.Size(45, 17)
        Me.Surf.TabIndex = 7
        Me.Surf.Text = "Surf"
        Me.Surf.UseVisualStyleBackColor = True
        '
        'Natation
        '
        Me.Natation.AutoSize = True
        Me.Natation.Location = New System.Drawing.Point(27, 184)
        Me.Natation.Name = "Natation"
        Me.Natation.Size = New System.Drawing.Size(66, 17)
        Me.Natation.TabIndex = 6
        Me.Natation.Text = "Natation"
        Me.Natation.UseVisualStyleBackColor = False
        '
        'Vélo
        '
        Me.Vélo.AutoSize = True
        Me.Vélo.Location = New System.Drawing.Point(27, 138)
        Me.Vélo.Name = "Vélo"
        Me.Vélo.Size = New System.Drawing.Size(47, 17)
        Me.Vélo.TabIndex = 5
        Me.Vélo.Text = "Vélo"
        Me.Vélo.UseVisualStyleBackColor = True
        '
        'Marche
        '
        Me.Marche.AutoSize = True
        Me.Marche.Location = New System.Drawing.Point(27, 91)
        Me.Marche.Name = "Marche"
        Me.Marche.Size = New System.Drawing.Size(62, 17)
        Me.Marche.TabIndex = 4
        Me.Marche.Text = "Marche"
        Me.Marche.UseVisualStyleBackColor = True
        '
        'Niveau
        '
        Me.Niveau.Controls.Add(Me.Debutant)
        Me.Niveau.Controls.Add(Me.Intermediaire)
        Me.Niveau.Controls.Add(Me.Extreme)
        Me.Niveau.Controls.Add(Me.Avance)
        Me.Niveau.Location = New System.Drawing.Point(332, 333)
        Me.Niveau.Name = "Niveau"
        Me.Niveau.Size = New System.Drawing.Size(200, 213)
        Me.Niveau.TabIndex = 0
        Me.Niveau.TabStop = False
        Me.Niveau.Text = "Niveau"
        '
        'entreeville
        '
        Me.entreeville.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.entreeville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.entreeville.FormattingEnabled = True
        Me.entreeville.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.entreeville.Location = New System.Drawing.Point(411, 149)
        Me.entreeville.Name = "entreeville"
        Me.entreeville.Size = New System.Drawing.Size(121, 150)
        Me.entreeville.TabIndex = 11
        '
        'entreage
        '
        Me.entreage.Location = New System.Drawing.Point(591, 27)
        Me.entreage.Name = "entreage"
        Me.entreage.Size = New System.Drawing.Size(100, 20)
        Me.entreage.TabIndex = 12
        '
        'entrenom
        '
        Me.entrenom.Location = New System.Drawing.Point(183, 30)
        Me.entrenom.Name = "entrenom"
        Me.entrenom.Size = New System.Drawing.Size(100, 20)
        Me.entrenom.TabIndex = 13
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.Location = New System.Drawing.Point(100, 30)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(29, 13)
        Me.Nom.TabIndex = 14
        Me.Nom.Text = "Nom"
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Location = New System.Drawing.Point(549, 30)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(26, 13)
        Me.Age.TabIndex = 15
        Me.Age.Text = "Age"
        '
        'ville
        '
        Me.ville.AutoSize = True
        Me.ville.Location = New System.Drawing.Point(408, 120)
        Me.ville.Name = "ville"
        Me.ville.Size = New System.Drawing.Size(90, 13)
        Me.ville.TabIndex = 16
        Me.ville.Text = "Ville de résidence"
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Location = New System.Drawing.Point(706, 30)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(24, 13)
        Me.ans.TabIndex = 17
        Me.ans.Text = "ans"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 586)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.ville)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.entrenom)
        Me.Controls.Add(Me.entreage)
        Me.Controls.Add(Me.entreeville)
        Me.Controls.Add(Me.Activites)
        Me.Controls.Add(Me.NouveauProfilBouton)
        Me.Controls.Add(Me.AfficherProfil)
        Me.Controls.Add(Me.Sortie)
        Me.Controls.Add(Me.Sexe)
        Me.Controls.Add(Me.Niveau)
        Me.Name = "Form1"
        Me.Text = "Fiche d'adhésion"
        Me.Sexe.ResumeLayout(False)
        Me.Sexe.PerformLayout()
        Me.Activites.ResumeLayout(False)
        Me.Activites.PerformLayout()
        Me.Niveau.ResumeLayout(False)
        Me.Niveau.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sortie As System.Windows.Forms.Button
    Friend WithEvents AfficherProfil As System.Windows.Forms.Button
    Friend WithEvents NouveauProfilBouton As System.Windows.Forms.Button
    Friend WithEvents Course As System.Windows.Forms.CheckBox
    Friend WithEvents Masculin As System.Windows.Forms.RadioButton
    Friend WithEvents Feminin As System.Windows.Forms.RadioButton
    Friend WithEvents Extreme As System.Windows.Forms.RadioButton
    Friend WithEvents Avance As System.Windows.Forms.RadioButton
    Friend WithEvents Intermediaire As System.Windows.Forms.RadioButton
    Friend WithEvents Debutant As System.Windows.Forms.RadioButton
    Friend WithEvents Sexe As System.Windows.Forms.GroupBox
    Friend WithEvents Activites As System.Windows.Forms.GroupBox
    Friend WithEvents LineRoller As System.Windows.Forms.CheckBox
    Friend WithEvents Surf As System.Windows.Forms.CheckBox
    Friend WithEvents Natation As System.Windows.Forms.CheckBox
    Friend WithEvents Vélo As System.Windows.Forms.CheckBox
    Friend WithEvents Marche As System.Windows.Forms.CheckBox
    Friend WithEvents Niveau As System.Windows.Forms.GroupBox
    Friend WithEvents entreeville As System.Windows.Forms.ComboBox
    Friend WithEvents entreage As System.Windows.Forms.TextBox
    Friend WithEvents entrenom As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.Label
    Friend WithEvents Age As System.Windows.Forms.Label
    Friend WithEvents ville As System.Windows.Forms.Label
    Friend WithEvents ans As System.Windows.Forms.Label

End Class
