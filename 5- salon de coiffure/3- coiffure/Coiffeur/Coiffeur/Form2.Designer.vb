<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nouveausoin
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
        Me.prixsointexte = New System.Windows.Forms.TextBox()
        Me.nomsointexte = New System.Windows.Forms.TextBox()
        Me.nomsoin = New System.Windows.Forms.Label()
        Me.labelnewsoin = New System.Windows.Forms.Label()
        Me.prixsoin = New System.Windows.Forms.Label()
        Me.newsoinannuler = New System.Windows.Forms.Button()
        Me.oknewsoin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prixsointexte
        '
        Me.prixsointexte.Location = New System.Drawing.Point(55, 113)
        Me.prixsointexte.Name = "prixsointexte"
        Me.prixsointexte.Size = New System.Drawing.Size(100, 20)
        Me.prixsointexte.TabIndex = 0
        '
        'nomsointexte
        '
        Me.nomsointexte.Location = New System.Drawing.Point(55, 64)
        Me.nomsointexte.Name = "nomsointexte"
        Me.nomsointexte.Size = New System.Drawing.Size(100, 20)
        Me.nomsointexte.TabIndex = 1
        '
        'nomsoin
        '
        Me.nomsoin.AutoSize = True
        Me.nomsoin.Location = New System.Drawing.Point(10, 67)
        Me.nomsoin.Name = "nomsoin"
        Me.nomsoin.Size = New System.Drawing.Size(29, 13)
        Me.nomsoin.TabIndex = 2
        Me.nomsoin.Text = "Nom"
        '
        'labelnewsoin
        '
        Me.labelnewsoin.AutoSize = True
        Me.labelnewsoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnewsoin.Location = New System.Drawing.Point(12, 20)
        Me.labelnewsoin.Name = "labelnewsoin"
        Me.labelnewsoin.Size = New System.Drawing.Size(124, 24)
        Me.labelnewsoin.TabIndex = 3
        Me.labelnewsoin.Text = "Entrez le soin"
        '
        'prixsoin
        '
        Me.prixsoin.AutoSize = True
        Me.prixsoin.Location = New System.Drawing.Point(12, 113)
        Me.prixsoin.Name = "prixsoin"
        Me.prixsoin.Size = New System.Drawing.Size(24, 13)
        Me.prixsoin.TabIndex = 4
        Me.prixsoin.Text = "Prix"
        '
        'newsoinannuler
        '
        Me.newsoinannuler.Location = New System.Drawing.Point(197, 113)
        Me.newsoinannuler.Name = "newsoinannuler"
        Me.newsoinannuler.Size = New System.Drawing.Size(75, 23)
        Me.newsoinannuler.TabIndex = 5
        Me.newsoinannuler.Text = "Annuler"
        Me.newsoinannuler.UseVisualStyleBackColor = True
        '
        'oknewsoin
        '
        Me.oknewsoin.Location = New System.Drawing.Point(197, 64)
        Me.oknewsoin.Name = "oknewsoin"
        Me.oknewsoin.Size = New System.Drawing.Size(75, 23)
        Me.oknewsoin.TabIndex = 6
        Me.oknewsoin.Text = "OK"
        Me.oknewsoin.UseVisualStyleBackColor = True
        '
        'nouveausoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.Controls.Add(Me.oknewsoin)
        Me.Controls.Add(Me.newsoinannuler)
        Me.Controls.Add(Me.prixsoin)
        Me.Controls.Add(Me.labelnewsoin)
        Me.Controls.Add(Me.nomsoin)
        Me.Controls.Add(Me.nomsointexte)
        Me.Controls.Add(Me.prixsointexte)
        Me.Name = "nouveausoin"
        Me.Text = "Nouveau Soin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prixsointexte As System.Windows.Forms.TextBox
    Friend WithEvents nomsointexte As System.Windows.Forms.TextBox
    Friend WithEvents nomsoin As System.Windows.Forms.Label
    Friend WithEvents labelnewsoin As System.Windows.Forms.Label
    Friend WithEvents prixsoin As System.Windows.Forms.Label
    Friend WithEvents newsoinannuler As System.Windows.Forms.Button
    Friend WithEvents oknewsoin As System.Windows.Forms.Button
End Class
