<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.quitterapropos = New System.Windows.Forms.Button()
        Me.texteapropos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'quitterapropos
        '
        Me.quitterapropos.Location = New System.Drawing.Point(100, 104)
        Me.quitterapropos.Name = "quitterapropos"
        Me.quitterapropos.Size = New System.Drawing.Size(75, 23)
        Me.quitterapropos.TabIndex = 0
        Me.quitterapropos.Text = "Ok"
        Me.quitterapropos.UseVisualStyleBackColor = True
        '
        'texteapropos
        '
        Me.texteapropos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.texteapropos.Location = New System.Drawing.Point(38, 50)
        Me.texteapropos.Margin = New System.Windows.Forms.Padding(5)
        Me.texteapropos.Multiline = True
        Me.texteapropos.Name = "texteapropos"
        Me.texteapropos.ReadOnly = True
        Me.texteapropos.Size = New System.Drawing.Size(209, 46)
        Me.texteapropos.TabIndex = 1
        Me.texteapropos.Text = "Application salon de Coiffure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright Moutoussamy Kévin"
        Me.texteapropos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.texteapropos.WordWrap = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.texteapropos)
        Me.Controls.Add(Me.quitterapropos)
        Me.Name = "Form3"
        Me.Text = "à propos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents quitterapropos As System.Windows.Forms.Button
    Friend WithEvents texteapropos As System.Windows.Forms.TextBox
End Class
