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
        Me.titre = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.hauteur_table_ronde = New System.Windows.Forms.TextBox()
        Me.epaisseur_table_ronde = New System.Windows.Forms.TextBox()
        Me.cout = New System.Windows.Forms.TextBox()
        Me.mo = New System.Windows.Forms.TextBox()
        Me.volume = New System.Windows.Forms.TextBox()
        Me.resultats = New System.Windows.Forms.GroupBox()
        Me.label_mo = New System.Windows.Forms.Label()
        Me.label_cout = New System.Windows.Forms.Label()
        Me.label_volume = New System.Windows.Forms.Label()
        Me.Tarifs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.calculer_ronde = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.diametre_table_ronde = New System.Windows.Forms.TextBox()
        Me.calcul_rectangulaire = New System.Windows.Forms.TabPage()
        Me.bordure = New System.Windows.Forms.ComboBox()
        Me.calculer_rectangle = New System.Windows.Forms.Button()
        Me.bouton_bordure = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.largeur_table_rectangulaire = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.longueur_table_rectangulaire = New System.Windows.Forms.TextBox()
        Me.epaisseur_table_rectangulaire = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.volume_table_rectangulaire = New System.Windows.Forms.TextBox()
        Me.mo_table_rectangulaire = New System.Windows.Forms.TextBox()
        Me.cout_table_rectangulaire = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.hauteur_table_rectangulaire = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.largeur_table_ovale = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.calculer_ovale = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.longueur_table_ovale = New System.Windows.Forms.TextBox()
        Me.epaisseur_table_ovale = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.volume_table_ovale = New System.Windows.Forms.TextBox()
        Me.mo_table_ovale = New System.Windows.Forms.TextBox()
        Me.cout_table_ovale = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.hauteur_table_ovale = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.heure_mo = New System.Windows.Forms.TextBox()
        Me.cout_bois = New System.Windows.Forms.TextBox()
        Me.resultats.SuspendLayout()
        Me.Tarifs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.calcul_rectangulaire.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'titre
        '
        Me.titre.AutoSize = True
        Me.titre.Location = New System.Drawing.Point(29, 78)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(76, 13)
        Me.titre.TabIndex = 0
        Me.titre.Text = "Tables en bois"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 77)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Hauteur (m)"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 127)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Epaisseur (m)"
        '
        'hauteur_table_ronde
        '
        Me.hauteur_table_ronde.Location = New System.Drawing.Point(105, 74)
        Me.hauteur_table_ronde.Name = "hauteur_table_ronde"
        Me.hauteur_table_ronde.Size = New System.Drawing.Size(100, 20)
        Me.hauteur_table_ronde.TabIndex = 4
        '
        'epaisseur_table_ronde
        '
        Me.epaisseur_table_ronde.Location = New System.Drawing.Point(105, 124)
        Me.epaisseur_table_ronde.Name = "epaisseur_table_ronde"
        Me.epaisseur_table_ronde.Size = New System.Drawing.Size(100, 20)
        Me.epaisseur_table_ronde.TabIndex = 5
        '
        'cout
        '
        Me.cout.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cout.Location = New System.Drawing.Point(117, 155)
        Me.cout.Name = "cout"
        Me.cout.ReadOnly = True
        Me.cout.Size = New System.Drawing.Size(100, 13)
        Me.cout.TabIndex = 6
        '
        'mo
        '
        Me.mo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mo.Location = New System.Drawing.Point(117, 112)
        Me.mo.Name = "mo"
        Me.mo.ReadOnly = True
        Me.mo.Size = New System.Drawing.Size(100, 13)
        Me.mo.TabIndex = 7
        '
        'volume
        '
        Me.volume.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.volume.Location = New System.Drawing.Point(117, 68)
        Me.volume.Name = "volume"
        Me.volume.ReadOnly = True
        Me.volume.Size = New System.Drawing.Size(100, 13)
        Me.volume.TabIndex = 8
        '
        'resultats
        '
        Me.resultats.Controls.Add(Me.label_mo)
        Me.resultats.Controls.Add(Me.label_cout)
        Me.resultats.Controls.Add(Me.label_volume)
        Me.resultats.Controls.Add(Me.volume)
        Me.resultats.Controls.Add(Me.mo)
        Me.resultats.Controls.Add(Me.cout)
        Me.resultats.Location = New System.Drawing.Point(294, 77)
        Me.resultats.Name = "resultats"
        Me.resultats.Size = New System.Drawing.Size(236, 255)
        Me.resultats.TabIndex = 9
        Me.resultats.TabStop = False
        Me.resultats.Text = "Résultats"
        '
        'label_mo
        '
        Me.label_mo.AutoSize = True
        Me.label_mo.Location = New System.Drawing.Point(9, 112)
        Me.label_mo.Name = "label_mo"
        Me.label_mo.Size = New System.Drawing.Size(59, 13)
        Me.label_mo.TabIndex = 0
        Me.label_mo.Text = "Temps MO"
        '
        'label_cout
        '
        Me.label_cout.AutoSize = True
        Me.label_cout.Location = New System.Drawing.Point(9, 155)
        Me.label_cout.Name = "label_cout"
        Me.label_cout.Size = New System.Drawing.Size(29, 13)
        Me.label_cout.TabIndex = 1
        Me.label_cout.Text = "Coût"
        '
        'label_volume
        '
        Me.label_volume.AutoSize = True
        Me.label_volume.Location = New System.Drawing.Point(9, 68)
        Me.label_volume.Name = "label_volume"
        Me.label_volume.Size = New System.Drawing.Size(80, 13)
        Me.label_volume.TabIndex = 2
        Me.label_volume.Text = "Volume de Bois"
        '
        'Tarifs
        '
        Me.Tarifs.Controls.Add(Me.TabPage1)
        Me.Tarifs.Controls.Add(Me.calcul_rectangulaire)
        Me.Tarifs.Controls.Add(Me.TabPage3)
        Me.Tarifs.Controls.Add(Me.TabPage2)
        Me.Tarifs.Location = New System.Drawing.Point(0, 0)
        Me.Tarifs.Name = "Tarifs"
        Me.Tarifs.SelectedIndex = 0
        Me.Tarifs.Size = New System.Drawing.Size(572, 464)
        Me.Tarifs.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.calculer_ronde)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.diametre_table_ronde)
        Me.TabPage1.Controls.Add(Me.epaisseur_table_ronde)
        Me.TabPage1.Controls.Add(Me.resultats)
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Controls.Add(Me.label2)
        Me.TabPage1.Controls.Add(Me.hauteur_table_ronde)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(564, 438)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Table Ronde"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'calculer_ronde
        '
        Me.calculer_ronde.Location = New System.Drawing.Point(114, 286)
        Me.calculer_ronde.Name = "calculer_ronde"
        Me.calculer_ronde.Size = New System.Drawing.Size(75, 23)
        Me.calculer_ronde.TabIndex = 12
        Me.calculer_ronde.Text = "Calculer"
        Me.calculer_ronde.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(13, 177)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 13)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Diamètre (m)"
        '
        'diametre_table_ronde
        '
        Me.diametre_table_ronde.Location = New System.Drawing.Point(105, 174)
        Me.diametre_table_ronde.Name = "diametre_table_ronde"
        Me.diametre_table_ronde.Size = New System.Drawing.Size(100, 20)
        Me.diametre_table_ronde.TabIndex = 10
        '
        'calcul_rectangulaire
        '
        Me.calcul_rectangulaire.Controls.Add(Me.bordure)
        Me.calcul_rectangulaire.Controls.Add(Me.calculer_rectangle)
        Me.calcul_rectangulaire.Controls.Add(Me.bouton_bordure)
        Me.calcul_rectangulaire.Controls.Add(Me.Label18)
        Me.calcul_rectangulaire.Controls.Add(Me.largeur_table_rectangulaire)
        Me.calcul_rectangulaire.Controls.Add(Me.Label16)
        Me.calcul_rectangulaire.Controls.Add(Me.Label4)
        Me.calcul_rectangulaire.Controls.Add(Me.longueur_table_rectangulaire)
        Me.calcul_rectangulaire.Controls.Add(Me.epaisseur_table_rectangulaire)
        Me.calcul_rectangulaire.Controls.Add(Me.GroupBox1)
        Me.calcul_rectangulaire.Controls.Add(Me.Label8)
        Me.calcul_rectangulaire.Controls.Add(Me.Label9)
        Me.calcul_rectangulaire.Controls.Add(Me.hauteur_table_rectangulaire)
        Me.calcul_rectangulaire.Location = New System.Drawing.Point(4, 22)
        Me.calcul_rectangulaire.Name = "calcul_rectangulaire"
        Me.calcul_rectangulaire.Padding = New System.Windows.Forms.Padding(3)
        Me.calcul_rectangulaire.Size = New System.Drawing.Size(564, 438)
        Me.calcul_rectangulaire.TabIndex = 2
        Me.calcul_rectangulaire.Text = "Table Rectangulaire"
        Me.calcul_rectangulaire.UseVisualStyleBackColor = True
        '
        'bordure
        '
        Me.bordure.FormattingEnabled = True
        Me.bordure.Items.AddRange(New Object() {"Aucune", "Moyenne", "Maximale"})
        Me.bordure.Location = New System.Drawing.Point(116, 292)
        Me.bordure.Name = "bordure"
        Me.bordure.Size = New System.Drawing.Size(100, 21)
        Me.bordure.TabIndex = 27
        '
        'calculer_rectangle
        '
        Me.calculer_rectangle.Location = New System.Drawing.Point(128, 362)
        Me.calculer_rectangle.Name = "calculer_rectangle"
        Me.calculer_rectangle.Size = New System.Drawing.Size(75, 23)
        Me.calculer_rectangle.TabIndex = 26
        Me.calculer_rectangle.Text = "Calculer"
        Me.calculer_rectangle.UseVisualStyleBackColor = True
        '
        'bouton_bordure
        '
        Me.bouton_bordure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.bouton_bordure.Location = New System.Drawing.Point(65, 286)
        Me.bouton_bordure.Name = "bouton_bordure"
        Me.bouton_bordure.Size = New System.Drawing.Size(27, 23)
        Me.bouton_bordure.TabIndex = 25
        Me.bouton_bordure.Text = "(?)"
        Me.bouton_bordure.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(25, 292)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Bordure"
        '
        'largeur_table_rectangulaire
        '
        Me.largeur_table_rectangulaire.Location = New System.Drawing.Point(116, 238)
        Me.largeur_table_rectangulaire.Name = "largeur_table_rectangulaire"
        Me.largeur_table_rectangulaire.Size = New System.Drawing.Size(100, 20)
        Me.largeur_table_rectangulaire.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Largeur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Longueur"
        '
        'longueur_table_rectangulaire
        '
        Me.longueur_table_rectangulaire.Location = New System.Drawing.Point(116, 190)
        Me.longueur_table_rectangulaire.Name = "longueur_table_rectangulaire"
        Me.longueur_table_rectangulaire.Size = New System.Drawing.Size(100, 20)
        Me.longueur_table_rectangulaire.TabIndex = 17
        '
        'epaisseur_table_rectangulaire
        '
        Me.epaisseur_table_rectangulaire.Location = New System.Drawing.Point(116, 140)
        Me.epaisseur_table_rectangulaire.Name = "epaisseur_table_rectangulaire"
        Me.epaisseur_table_rectangulaire.Size = New System.Drawing.Size(100, 20)
        Me.epaisseur_table_rectangulaire.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.volume_table_rectangulaire)
        Me.GroupBox1.Controls.Add(Me.mo_table_rectangulaire)
        Me.GroupBox1.Controls.Add(Me.cout_table_rectangulaire)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 255)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Résultats"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Temps MO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Coût"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Volume de Bois"
        '
        'volume_table_rectangulaire
        '
        Me.volume_table_rectangulaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.volume_table_rectangulaire.Location = New System.Drawing.Point(117, 68)
        Me.volume_table_rectangulaire.Name = "volume_table_rectangulaire"
        Me.volume_table_rectangulaire.ReadOnly = True
        Me.volume_table_rectangulaire.Size = New System.Drawing.Size(100, 13)
        Me.volume_table_rectangulaire.TabIndex = 8
        '
        'mo_table_rectangulaire
        '
        Me.mo_table_rectangulaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mo_table_rectangulaire.Location = New System.Drawing.Point(117, 112)
        Me.mo_table_rectangulaire.Name = "mo_table_rectangulaire"
        Me.mo_table_rectangulaire.ReadOnly = True
        Me.mo_table_rectangulaire.Size = New System.Drawing.Size(100, 13)
        Me.mo_table_rectangulaire.TabIndex = 7
        '
        'cout_table_rectangulaire
        '
        Me.cout_table_rectangulaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cout_table_rectangulaire.Location = New System.Drawing.Point(117, 155)
        Me.cout_table_rectangulaire.Name = "cout_table_rectangulaire"
        Me.cout_table_rectangulaire.ReadOnly = True
        Me.cout_table_rectangulaire.Size = New System.Drawing.Size(100, 13)
        Me.cout_table_rectangulaire.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Hauteur"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Epaisseur"
        '
        'hauteur_table_rectangulaire
        '
        Me.hauteur_table_rectangulaire.Location = New System.Drawing.Point(116, 90)
        Me.hauteur_table_rectangulaire.Name = "hauteur_table_rectangulaire"
        Me.hauteur_table_rectangulaire.Size = New System.Drawing.Size(100, 20)
        Me.hauteur_table_rectangulaire.TabIndex = 14
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.largeur_table_ovale)
        Me.TabPage3.Controls.Add(Me.label17)
        Me.TabPage3.Controls.Add(Me.calculer_ovale)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.longueur_table_ovale)
        Me.TabPage3.Controls.Add(Me.epaisseur_table_ovale)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.hauteur_table_ovale)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(564, 438)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Table Ovale"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'largeur_table_ovale
        '
        Me.largeur_table_ovale.Location = New System.Drawing.Point(116, 241)
        Me.largeur_table_ovale.Name = "largeur_table_ovale"
        Me.largeur_table_ovale.Size = New System.Drawing.Size(100, 20)
        Me.largeur_table_ovale.TabIndex = 21
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(25, 244)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(43, 13)
        Me.label17.TabIndex = 20
        Me.label17.Text = "Largeur"
        '
        'calculer_ovale
        '
        Me.calculer_ovale.Location = New System.Drawing.Point(130, 291)
        Me.calculer_ovale.Name = "calculer_ovale"
        Me.calculer_ovale.Size = New System.Drawing.Size(75, 23)
        Me.calculer_ovale.TabIndex = 19
        Me.calculer_ovale.Text = "Calculer"
        Me.calculer_ovale.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Longueur"
        '
        'longueur_table_ovale
        '
        Me.longueur_table_ovale.Location = New System.Drawing.Point(116, 190)
        Me.longueur_table_ovale.Name = "longueur_table_ovale"
        Me.longueur_table_ovale.Size = New System.Drawing.Size(100, 20)
        Me.longueur_table_ovale.TabIndex = 17
        '
        'epaisseur_table_ovale
        '
        Me.epaisseur_table_ovale.Location = New System.Drawing.Point(116, 140)
        Me.epaisseur_table_ovale.Name = "epaisseur_table_ovale"
        Me.epaisseur_table_ovale.Size = New System.Drawing.Size(100, 20)
        Me.epaisseur_table_ovale.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.volume_table_ovale)
        Me.GroupBox2.Controls.Add(Me.mo_table_ovale)
        Me.GroupBox2.Controls.Add(Me.cout_table_ovale)
        Me.GroupBox2.Location = New System.Drawing.Point(305, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 255)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Résultats"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Temps MO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Coût"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Volume de Bois"
        '
        'volume_table_ovale
        '
        Me.volume_table_ovale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.volume_table_ovale.Location = New System.Drawing.Point(117, 68)
        Me.volume_table_ovale.Name = "volume_table_ovale"
        Me.volume_table_ovale.ReadOnly = True
        Me.volume_table_ovale.Size = New System.Drawing.Size(100, 13)
        Me.volume_table_ovale.TabIndex = 8
        '
        'mo_table_ovale
        '
        Me.mo_table_ovale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mo_table_ovale.Location = New System.Drawing.Point(117, 112)
        Me.mo_table_ovale.Name = "mo_table_ovale"
        Me.mo_table_ovale.ReadOnly = True
        Me.mo_table_ovale.Size = New System.Drawing.Size(100, 13)
        Me.mo_table_ovale.TabIndex = 7
        '
        'cout_table_ovale
        '
        Me.cout_table_ovale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cout_table_ovale.Location = New System.Drawing.Point(117, 155)
        Me.cout_table_ovale.Name = "cout_table_ovale"
        Me.cout_table_ovale.ReadOnly = True
        Me.cout_table_ovale.Size = New System.Drawing.Size(100, 13)
        Me.cout_table_ovale.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Hauteur"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Epaisseur"
        '
        'hauteur_table_ovale
        '
        Me.hauteur_table_ovale.Location = New System.Drawing.Point(116, 90)
        Me.hauteur_table_ovale.Name = "hauteur_table_ovale"
        Me.hauteur_table_ovale.Size = New System.Drawing.Size(100, 20)
        Me.hauteur_table_ovale.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.heure_mo)
        Me.TabPage2.Controls.Add(Me.cout_bois)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(564, 438)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Tarifs"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(188, 195)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Cout horaire MO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(188, 230)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Cout m3 de bois"
        '
        'heure_mo
        '
        Me.heure_mo.Location = New System.Drawing.Point(277, 192)
        Me.heure_mo.Name = "heure_mo"
        Me.heure_mo.Size = New System.Drawing.Size(100, 20)
        Me.heure_mo.TabIndex = 27
        '
        'cout_bois
        '
        Me.cout_bois.Location = New System.Drawing.Point(277, 227)
        Me.cout_bois.Name = "cout_bois"
        Me.cout_bois.Size = New System.Drawing.Size(100, 20)
        Me.cout_bois.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 467)
        Me.Controls.Add(Me.Tarifs)
        Me.Controls.Add(Me.titre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.resultats.ResumeLayout(False)
        Me.resultats.PerformLayout()
        Me.Tarifs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.calcul_rectangulaire.ResumeLayout(False)
        Me.calcul_rectangulaire.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titre As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents hauteur_table_ronde As System.Windows.Forms.TextBox
    Friend WithEvents epaisseur_table_ronde As System.Windows.Forms.TextBox
    Friend WithEvents cout As System.Windows.Forms.TextBox
    Friend WithEvents mo As System.Windows.Forms.TextBox
    Friend WithEvents volume As System.Windows.Forms.TextBox
    Friend WithEvents resultats As System.Windows.Forms.GroupBox
    Friend WithEvents label_mo As System.Windows.Forms.Label
    Friend WithEvents label_cout As System.Windows.Forms.Label
    Friend WithEvents label_volume As System.Windows.Forms.Label
    Friend WithEvents Tarifs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents calcul_rectangulaire As System.Windows.Forms.TabPage
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents diametre_table_ronde As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents largeur_table_rectangulaire As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents longueur_table_rectangulaire As System.Windows.Forms.TextBox
    Friend WithEvents epaisseur_table_rectangulaire As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents volume_table_rectangulaire As System.Windows.Forms.TextBox
    Friend WithEvents mo_table_rectangulaire As System.Windows.Forms.TextBox
    Friend WithEvents cout_table_rectangulaire As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hauteur_table_rectangulaire As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents longueur_table_ovale As System.Windows.Forms.TextBox
    Friend WithEvents epaisseur_table_ovale As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents volume_table_ovale As System.Windows.Forms.TextBox
    Friend WithEvents mo_table_ovale As System.Windows.Forms.TextBox
    Friend WithEvents cout_table_ovale As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents hauteur_table_ovale As System.Windows.Forms.TextBox
    Friend WithEvents bouton_bordure As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents calculer_rectangle As System.Windows.Forms.Button
    Friend WithEvents calculer_ronde As System.Windows.Forms.Button
    Friend WithEvents calculer_ovale As System.Windows.Forms.Button
    Friend WithEvents largeur_table_ovale As System.Windows.Forms.TextBox
    Friend WithEvents label17 As System.Windows.Forms.Label
    Friend WithEvents bordure As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents heure_mo As System.Windows.Forms.TextBox
    Friend WithEvents cout_bois As System.Windows.Forms.TextBox

End Class
