<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FirstTitle = New System.Windows.Forms.Label()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FirstTitle
        '
        Me.FirstTitle.AutoSize = True
        Me.FirstTitle.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstTitle.ForeColor = System.Drawing.Color.LightYellow
        Me.FirstTitle.Location = New System.Drawing.Point(143, 96)
        Me.FirstTitle.Name = "FirstTitle"
        Me.FirstTitle.Size = New System.Drawing.Size(197, 42)
        Me.FirstTitle.TabIndex = 0
        Me.FirstTitle.Text = "Tic Tac Toe"
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(150, 198)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(184, 39)
        Me.FirstButton.TabIndex = 1
        Me.FirstButton.Text = "Iniciar Juego"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(463, 363)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.FirstTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstTitle As Label
    Friend WithEvents FirstButton As Button
End Class
