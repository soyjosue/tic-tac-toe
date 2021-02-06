<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameTable
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn31 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn22 = New System.Windows.Forms.Button()
        Me.btn32 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn23 = New System.Windows.Forms.Button()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.LabelPlayer = New System.Windows.Forms.Label()
        Me.LabelBot = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn11
        '
        Me.btn11.Location = New System.Drawing.Point(13, 13)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(75, 23)
        Me.btn11.TabIndex = 0
        Me.btn11.UseVisualStyleBackColor = True
        '
        'btn31
        '
        Me.btn31.Location = New System.Drawing.Point(360, 13)
        Me.btn31.Name = "btn31"
        Me.btn31.Size = New System.Drawing.Size(75, 23)
        Me.btn31.TabIndex = 1
        Me.btn31.UseVisualStyleBackColor = True
        '
        'btn21
        '
        Me.btn21.Location = New System.Drawing.Point(189, 12)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(75, 23)
        Me.btn21.TabIndex = 2
        Me.btn21.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Location = New System.Drawing.Point(13, 86)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(75, 23)
        Me.btn12.TabIndex = 3
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn22
        '
        Me.btn22.Location = New System.Drawing.Point(189, 85)
        Me.btn22.Name = "btn22"
        Me.btn22.Size = New System.Drawing.Size(75, 23)
        Me.btn22.TabIndex = 4
        Me.btn22.UseVisualStyleBackColor = True
        '
        'btn32
        '
        Me.btn32.Location = New System.Drawing.Point(360, 84)
        Me.btn32.Name = "btn32"
        Me.btn32.Size = New System.Drawing.Size(75, 23)
        Me.btn32.TabIndex = 5
        Me.btn32.UseVisualStyleBackColor = True
        '
        'btn13
        '
        Me.btn13.Location = New System.Drawing.Point(13, 168)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(75, 23)
        Me.btn13.TabIndex = 6
        Me.btn13.UseVisualStyleBackColor = True
        '
        'btn23
        '
        Me.btn23.Location = New System.Drawing.Point(189, 167)
        Me.btn23.Name = "btn23"
        Me.btn23.Size = New System.Drawing.Size(75, 23)
        Me.btn23.TabIndex = 7
        Me.btn23.UseVisualStyleBackColor = True
        '
        'btn33
        '
        Me.btn33.Location = New System.Drawing.Point(360, 166)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(75, 23)
        Me.btn33.TabIndex = 8
        Me.btn33.UseVisualStyleBackColor = True
        '
        'LabelPlayer
        '
        Me.LabelPlayer.AutoSize = True
        Me.LabelPlayer.Location = New System.Drawing.Point(91, 228)
        Me.LabelPlayer.Name = "LabelPlayer"
        Me.LabelPlayer.Size = New System.Drawing.Size(23, 13)
        Me.LabelPlayer.TabIndex = 9
        Me.LabelPlayer.Text = "Tu:"
        '
        'LabelBot
        '
        Me.LabelBot.AutoSize = True
        Me.LabelBot.Location = New System.Drawing.Point(309, 228)
        Me.LabelBot.Name = "LabelBot"
        Me.LabelBot.Size = New System.Drawing.Size(51, 13)
        Me.LabelBot.TabIndex = 10
        Me.LabelBot.Text = "Maquina:"
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(13, 281)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(422, 23)
        Me.ResetBtn.TabIndex = 11
        Me.ResetBtn.Text = "Reiniciar"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Ganaste"
        Me.Label3.Visible = False
        '
        'GameTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 324)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.LabelBot)
        Me.Controls.Add(Me.LabelPlayer)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn23)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn32)
        Me.Controls.Add(Me.btn22)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.btn31)
        Me.Controls.Add(Me.btn11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameTable"
        Me.Text = "gameTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn11 As Button
    Friend WithEvents btn31 As Button
    Friend WithEvents btn21 As Button
    Friend WithEvents btn12 As Button
    Friend WithEvents btn22 As Button
    Friend WithEvents btn32 As Button
    Friend WithEvents btn13 As Button
    Friend WithEvents btn23 As Button
    Friend WithEvents btn33 As Button
    Friend WithEvents LabelPlayer As Label
    Friend WithEvents LabelBot As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Label3 As Label
End Class
