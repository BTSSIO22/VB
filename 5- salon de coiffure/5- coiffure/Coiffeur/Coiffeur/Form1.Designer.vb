<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fenetreprincipale
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
        Me.labelcoupe = New System.Windows.Forms.Label()
        Me.labelsoinsspeciaux = New System.Windows.Forms.Label()
        Me.labelprix = New System.Windows.Forms.Label()
        Me.typeetudiant = New System.Windows.Forms.CheckBox()
        Me.typeabonné = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.typeclientbox = New System.Windows.Forms.GroupBox()
        Me.promobox = New System.Windows.Forms.GroupBox()
        Me.nopromo = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.combocoupe = New System.Windows.Forms.ComboBox()
        Me.listesoin = New System.Windows.Forms.ListBox()
        Me.boutonnewsoin = New System.Windows.Forms.Button()
        Me.calculer = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.labeltitre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.prenomclient = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.nomclient = New System.Windows.Forms.Label()
        Me.prixaffiche = New System.Windows.Forms.TextBox()
        Me.menuhover = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀProposToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.typeclientbox.SuspendLayout()
        Me.promobox.SuspendLayout()
        Me.menuhover.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelcoupe
        '
        Me.labelcoupe.AutoSize = True
        Me.labelcoupe.Location = New System.Drawing.Point(14, 199)
        Me.labelcoupe.Name = "labelcoupe"
        Me.labelcoupe.Size = New System.Drawing.Size(38, 13)
        Me.labelcoupe.TabIndex = 4
        Me.labelcoupe.Text = "Coupe"
        '
        'labelsoinsspeciaux
        '
        Me.labelsoinsspeciaux.AutoSize = True
        Me.labelsoinsspeciaux.Location = New System.Drawing.Point(54, 279)
        Me.labelsoinsspeciaux.Name = "labelsoinsspeciaux"
        Me.labelsoinsspeciaux.Size = New System.Drawing.Size(78, 13)
        Me.labelsoinsspeciaux.TabIndex = 5
        Me.labelsoinsspeciaux.Text = "Soins spéciaux"
        '
        'labelprix
        '
        Me.labelprix.AutoSize = True
        Me.labelprix.Location = New System.Drawing.Point(226, 432)
        Me.labelprix.Name = "labelprix"
        Me.labelprix.Size = New System.Drawing.Size(75, 13)
        Me.labelprix.TabIndex = 6
        Me.labelprix.Text = "Prix Total TTC"
        '
        'typeetudiant
        '
        Me.typeetudiant.AutoSize = True
        Me.typeetudiant.Location = New System.Drawing.Point(18, 68)
        Me.typeetudiant.Name = "typeetudiant"
        Me.typeetudiant.Size = New System.Drawing.Size(97, 17)
        Me.typeetudiant.TabIndex = 9
        Me.typeetudiant.Text = "Etudiant (-15%)"
        Me.typeetudiant.UseVisualStyleBackColor = True
        '
        'typeabonné
        '
        Me.typeabonné.AutoSize = True
        Me.typeabonné.Location = New System.Drawing.Point(18, 34)
        Me.typeabonné.Name = "typeabonné"
        Me.typeabonné.Size = New System.Drawing.Size(89, 17)
        Me.typeabonné.TabIndex = 10
        Me.typeabonné.Text = "Abonné (-5%)"
        Me.typeabonné.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 67)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "-10%"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'typeclientbox
        '
        Me.typeclientbox.Controls.Add(Me.typeabonné)
        Me.typeclientbox.Controls.Add(Me.typeetudiant)
        Me.typeclientbox.Location = New System.Drawing.Point(229, 85)
        Me.typeclientbox.Name = "typeclientbox"
        Me.typeclientbox.Size = New System.Drawing.Size(171, 100)
        Me.typeclientbox.TabIndex = 13
        Me.typeclientbox.TabStop = False
        Me.typeclientbox.Text = "Type de Client"
        '
        'promobox
        '
        Me.promobox.Controls.Add(Me.nopromo)
        Me.promobox.Controls.Add(Me.RadioButton3)
        Me.promobox.Controls.Add(Me.RadioButton2)
        Me.promobox.Location = New System.Drawing.Point(229, 208)
        Me.promobox.Name = "promobox"
        Me.promobox.Size = New System.Drawing.Size(171, 133)
        Me.promobox.TabIndex = 0
        Me.promobox.TabStop = False
        Me.promobox.Text = "Promotion spéciale"
        '
        'nopromo
        '
        Me.nopromo.AutoSize = True
        Me.nopromo.Location = New System.Drawing.Point(6, 33)
        Me.nopromo.Name = "nopromo"
        Me.nopromo.Size = New System.Drawing.Size(93, 17)
        Me.nopromo.TabIndex = 19
        Me.nopromo.TabStop = True
        Me.nopromo.Text = "aucune promo"
        Me.nopromo.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 101)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton3.TabIndex = 14
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "-20%"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'combocoupe
        '
        Me.combocoupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocoupe.FormattingEnabled = True
        Me.combocoupe.Items.AddRange(New Object() {"coupe enfant", "coupe adulte"})
        Me.combocoupe.Location = New System.Drawing.Point(58, 196)
        Me.combocoupe.Name = "combocoupe"
        Me.combocoupe.Size = New System.Drawing.Size(121, 21)
        Me.combocoupe.TabIndex = 14
        '
        'listesoin
        '
        Me.listesoin.FormattingEnabled = True
        Me.listesoin.Items.AddRange(New Object() {"Shampoing", "Coloration", "Lotion"})
        Me.listesoin.Location = New System.Drawing.Point(31, 309)
        Me.listesoin.Name = "listesoin"
        Me.listesoin.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.listesoin.Size = New System.Drawing.Size(120, 95)
        Me.listesoin.TabIndex = 15
        '
        'boutonnewsoin
        '
        Me.boutonnewsoin.Location = New System.Drawing.Point(31, 410)
        Me.boutonnewsoin.Name = "boutonnewsoin"
        Me.boutonnewsoin.Size = New System.Drawing.Size(120, 23)
        Me.boutonnewsoin.TabIndex = 16
        Me.boutonnewsoin.Text = "Nouveau soin"
        Me.boutonnewsoin.UseVisualStyleBackColor = True
        '
        'calculer
        '
        Me.calculer.Location = New System.Drawing.Point(229, 368)
        Me.calculer.Name = "calculer"
        Me.calculer.Size = New System.Drawing.Size(170, 23)
        Me.calculer.TabIndex = 17
        Me.calculer.Text = "Calculer la facture"
        Me.calculer.UseVisualStyleBackColor = True
        '
        'quitter
        '
        Me.quitter.Location = New System.Drawing.Point(160, 522)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(75, 23)
        Me.quitter.TabIndex = 18
        Me.quitter.Text = "Quitter"
        Me.quitter.UseVisualStyleBackColor = True
        '
        'labeltitre
        '
        Me.labeltitre.AutoSize = True
        Me.labeltitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltitre.Location = New System.Drawing.Point(12, 29)
        Me.labeltitre.Name = "labeltitre"
        Me.labeltitre.Size = New System.Drawing.Size(223, 25)
        Me.labeltitre.TabIndex = 19
        Me.labeltitre.Text = "Facturation d'un client"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 1
        '
        'prenomclient
        '
        Me.prenomclient.AutoSize = True
        Me.prenomclient.Location = New System.Drawing.Point(12, 114)
        Me.prenomclient.Name = "prenomclient"
        Me.prenomclient.Size = New System.Drawing.Size(43, 13)
        Me.prenomclient.TabIndex = 3
        Me.prenomclient.Text = "Prénom"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(57, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 0
        '
        'nomclient
        '
        Me.nomclient.AutoSize = True
        Me.nomclient.Location = New System.Drawing.Point(12, 88)
        Me.nomclient.Name = "nomclient"
        Me.nomclient.Size = New System.Drawing.Size(29, 13)
        Me.nomclient.TabIndex = 2
        Me.nomclient.Text = "Nom"
        '
        'prixaffiche
        '
        Me.prixaffiche.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.prixaffiche.Cursor = System.Windows.Forms.Cursors.No
        Me.prixaffiche.Location = New System.Drawing.Point(307, 429)
        Me.prixaffiche.Name = "prixaffiche"
        Me.prixaffiche.ReadOnly = True
        Me.prixaffiche.Size = New System.Drawing.Size(92, 20)
        Me.prixaffiche.TabIndex = 21
        '
        'menuhover
        '
        Me.menuhover.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.menuhover.Location = New System.Drawing.Point(0, 0)
        Me.menuhover.Name = "menuhover"
        Me.menuhover.Size = New System.Drawing.Size(417, 24)
        Me.menuhover.TabIndex = 22
        Me.menuhover.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem1, Me.ÀProposToolStripMenuItem1})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem1
        '
        Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
        Me.QuitterToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.QuitterToolStripMenuItem1.Text = "Quitter"
        '
        'ÀProposToolStripMenuItem1
        '
        Me.ÀProposToolStripMenuItem1.Name = "ÀProposToolStripMenuItem1"
        Me.ÀProposToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.ÀProposToolStripMenuItem1.Text = "à propos"
        '
        'fenetreprincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 593)
        Me.Controls.Add(Me.menuhover)
        Me.Controls.Add(Me.prixaffiche)
        Me.Controls.Add(Me.labeltitre)
        Me.Controls.Add(Me.quitter)
        Me.Controls.Add(Me.calculer)
        Me.Controls.Add(Me.boutonnewsoin)
        Me.Controls.Add(Me.listesoin)
        Me.Controls.Add(Me.combocoupe)
        Me.Controls.Add(Me.promobox)
        Me.Controls.Add(Me.typeclientbox)
        Me.Controls.Add(Me.labelprix)
        Me.Controls.Add(Me.labelsoinsspeciaux)
        Me.Controls.Add(Me.labelcoupe)
        Me.Controls.Add(Me.prenomclient)
        Me.Controls.Add(Me.nomclient)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.MainMenuStrip = Me.menuhover
        Me.Name = "fenetreprincipale"
        Me.Text = "Salon de coiffure pour homme"
        Me.typeclientbox.ResumeLayout(False)
        Me.typeclientbox.PerformLayout()
        Me.promobox.ResumeLayout(False)
        Me.promobox.PerformLayout()
        Me.menuhover.ResumeLayout(False)
        Me.menuhover.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelcoupe As System.Windows.Forms.Label
    Friend WithEvents labelsoinsspeciaux As System.Windows.Forms.Label
    Friend WithEvents labelprix As System.Windows.Forms.Label
    Friend WithEvents typeetudiant As System.Windows.Forms.CheckBox
    Friend WithEvents typeabonné As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents typeclientbox As System.Windows.Forms.GroupBox
    Friend WithEvents promobox As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents combocoupe As System.Windows.Forms.ComboBox
    Friend WithEvents listesoin As System.Windows.Forms.ListBox
    Friend WithEvents boutonnewsoin As System.Windows.Forms.Button
    Friend WithEvents calculer As System.Windows.Forms.Button
    Friend WithEvents quitter As System.Windows.Forms.Button
    Friend WithEvents nopromo As System.Windows.Forms.RadioButton
    Friend WithEvents labeltitre As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents prenomclient As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents nomclient As System.Windows.Forms.Label
    Friend WithEvents prixaffiche As System.Windows.Forms.TextBox
    Friend WithEvents menuhover As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÀProposToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
