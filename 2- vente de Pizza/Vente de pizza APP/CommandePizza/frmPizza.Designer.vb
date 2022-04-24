<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.taille2 = New System.Windows.Forms.RadioButton()
        Me.taille1 = New System.Windows.Forms.RadioButton()
        Me.taille3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.croute2 = New System.Windows.Forms.RadioButton()
        Me.croute1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.igr1 = New System.Windows.Forms.CheckBox()
        Me.igr2 = New System.Windows.Forms.CheckBox()
        Me.igr3 = New System.Windows.Forms.CheckBox()
        Me.igr4 = New System.Windows.Forms.CheckBox()
        Me.igr5 = New System.Windows.Forms.CheckBox()
        Me.igr6 = New System.Windows.Forms.CheckBox()
        Me.où1 = New System.Windows.Forms.RadioButton()
        Me.où2 = New System.Windows.Forms.RadioButton()
        Me.Fabriquer = New System.Windows.Forms.Button()
        Me.Sortir = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.taille2)
        Me.GroupBox1.Controls.Add(Me.taille1)
        Me.GroupBox1.Controls.Add(Me.taille3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Taille"
        '
        'taille2
        '
        Me.taille2.AutoSize = True
        Me.taille2.Location = New System.Drawing.Point(0, 46)
        Me.taille2.Name = "taille2"
        Me.taille2.Size = New System.Drawing.Size(69, 17)
        Me.taille2.TabIndex = 2
        Me.taille2.Text = "Moyenne"
        Me.taille2.UseVisualStyleBackColor = True
        '
        'taille1
        '
        Me.taille1.AutoSize = True
        Me.taille1.Checked = True
        Me.taille1.Location = New System.Drawing.Point(0, 23)
        Me.taille1.Name = "taille1"
        Me.taille1.Size = New System.Drawing.Size(52, 17)
        Me.taille1.TabIndex = 1
        Me.taille1.TabStop = True
        Me.taille1.Text = "Petite"
        Me.taille1.UseVisualStyleBackColor = True
        '
        'taille3
        '
        Me.taille3.AutoSize = True
        Me.taille3.Location = New System.Drawing.Point(0, 69)
        Me.taille3.Name = "taille3"
        Me.taille3.Size = New System.Drawing.Size(52, 17)
        Me.taille3.TabIndex = 3
        Me.taille3.Text = "Large"
        Me.taille3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.croute2)
        Me.GroupBox2.Controls.Add(Me.croute1)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type de croûte"
        '
        'croute2
        '
        Me.croute2.AutoSize = True
        Me.croute2.Location = New System.Drawing.Point(0, 46)
        Me.croute2.Name = "croute2"
        Me.croute2.Size = New System.Drawing.Size(95, 17)
        Me.croute2.TabIndex = 5
        Me.croute2.Text = "Croûte épaisse"
        Me.croute2.UseVisualStyleBackColor = True
        '
        'croute1
        '
        Me.croute1.AutoSize = True
        Me.croute1.Checked = True
        Me.croute1.Location = New System.Drawing.Point(0, 23)
        Me.croute1.Name = "croute1"
        Me.croute1.Size = New System.Drawing.Size(76, 17)
        Me.croute1.TabIndex = 4
        Me.croute1.TabStop = True
        Me.croute1.Text = "Croûte fine"
        Me.croute1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.igr1)
        Me.GroupBox3.Controls.Add(Me.igr2)
        Me.GroupBox3.Controls.Add(Me.igr3)
        Me.GroupBox3.Controls.Add(Me.igr4)
        Me.GroupBox3.Controls.Add(Me.igr5)
        Me.GroupBox3.Controls.Add(Me.igr6)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrédients"
        '
        'igr1
        '
        Me.igr1.AutoSize = True
        Me.igr1.Location = New System.Drawing.Point(19, 31)
        Me.igr1.Name = "igr1"
        Me.igr1.Size = New System.Drawing.Size(94, 17)
        Me.igr1.TabIndex = 8
        Me.igr1.Text = "Extra Fromage"
        Me.igr1.UseVisualStyleBackColor = True
        '
        'igr2
        '
        Me.igr2.AutoSize = True
        Me.igr2.Location = New System.Drawing.Point(19, 54)
        Me.igr2.Name = "igr2"
        Me.igr2.Size = New System.Drawing.Size(90, 17)
        Me.igr2.TabIndex = 9
        Me.igr2.Text = "Champignons"
        Me.igr2.UseVisualStyleBackColor = True
        '
        'igr3
        '
        Me.igr3.AutoSize = True
        Me.igr3.Location = New System.Drawing.Point(19, 77)
        Me.igr3.Name = "igr3"
        Me.igr3.Size = New System.Drawing.Size(84, 17)
        Me.igr3.TabIndex = 10
        Me.igr3.Text = "olives noires"
        Me.igr3.UseVisualStyleBackColor = True
        '
        'igr4
        '
        Me.igr4.AutoSize = True
        Me.igr4.Location = New System.Drawing.Point(116, 31)
        Me.igr4.Name = "igr4"
        Me.igr4.Size = New System.Drawing.Size(57, 17)
        Me.igr4.TabIndex = 11
        Me.igr4.Text = "onions"
        Me.igr4.UseVisualStyleBackColor = True
        '
        'igr5
        '
        Me.igr5.AutoSize = True
        Me.igr5.Location = New System.Drawing.Point(116, 54)
        Me.igr5.Name = "igr5"
        Me.igr5.Size = New System.Drawing.Size(77, 17)
        Me.igr5.TabIndex = 12
        Me.igr5.Text = "Poivre vert"
        Me.igr5.UseVisualStyleBackColor = True
        '
        'igr6
        '
        Me.igr6.AutoSize = True
        Me.igr6.Location = New System.Drawing.Point(116, 77)
        Me.igr6.Name = "igr6"
        Me.igr6.Size = New System.Drawing.Size(67, 17)
        Me.igr6.TabIndex = 13
        Me.igr6.Text = "Tomates"
        Me.igr6.UseVisualStyleBackColor = True
        '
        'où1
        '
        Me.où1.AutoSize = True
        Me.où1.Checked = True
        Me.où1.Location = New System.Drawing.Point(220, 156)
        Me.où1.Name = "où1"
        Me.où1.Size = New System.Drawing.Size(70, 17)
        Me.où1.TabIndex = 6
        Me.où1.TabStop = True
        Me.où1.Text = "Sur place"
        Me.où1.UseVisualStyleBackColor = True
        '
        'où2
        '
        Me.où2.AutoSize = True
        Me.où2.Location = New System.Drawing.Point(316, 156)
        Me.où2.Name = "où2"
        Me.où2.Size = New System.Drawing.Size(76, 17)
        Me.où2.TabIndex = 7
        Me.où2.Text = "A emporter"
        Me.où2.UseVisualStyleBackColor = True
        '
        'Fabriquer
        '
        Me.Fabriquer.Location = New System.Drawing.Point(215, 199)
        Me.Fabriquer.Name = "Fabriquer"
        Me.Fabriquer.Size = New System.Drawing.Size(75, 39)
        Me.Fabriquer.TabIndex = 14
        Me.Fabriquer.Text = "&Fabriquer la pizza"
        Me.Fabriquer.UseVisualStyleBackColor = True
        '
        'Sortir
        '
        Me.Sortir.Location = New System.Drawing.Point(316, 226)
        Me.Sortir.Name = "Sortir"
        Me.Sortir.Size = New System.Drawing.Size(75, 23)
        Me.Sortir.TabIndex = 15
        Me.Sortir.Text = "&Sortir"
        Me.Sortir.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(316, 199)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 6
        Me.reset.Text = "Réinitialiser"
        Me.reset.UseVisualStyleBackColor = True
        '
        'frmPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.Fabriquer)
        Me.Controls.Add(Me.Sortir)
        Me.Controls.Add(Me.où2)
        Me.Controls.Add(Me.où1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPizza"
        Me.Text = "Commande de pizza"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents taille2 As System.Windows.Forms.RadioButton
    Friend WithEvents taille1 As System.Windows.Forms.RadioButton
    Friend WithEvents taille3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents croute2 As System.Windows.Forms.RadioButton
    Friend WithEvents croute1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents igr1 As System.Windows.Forms.CheckBox
    Friend WithEvents igr2 As System.Windows.Forms.CheckBox
    Friend WithEvents igr3 As System.Windows.Forms.CheckBox
    Friend WithEvents igr4 As System.Windows.Forms.CheckBox
    Friend WithEvents igr5 As System.Windows.Forms.CheckBox
    Friend WithEvents igr6 As System.Windows.Forms.CheckBox
    Friend WithEvents où1 As System.Windows.Forms.RadioButton
    Friend WithEvents où2 As System.Windows.Forms.RadioButton
    Friend WithEvents Fabriquer As System.Windows.Forms.Button
    Friend WithEvents Sortir As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button

End Class
