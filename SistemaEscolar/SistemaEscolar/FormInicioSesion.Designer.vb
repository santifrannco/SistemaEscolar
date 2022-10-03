<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicioSesion))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTcontra = New System.Windows.Forms.TextBox()
        Me.TXTusuario = New System.Windows.Forms.TextBox()
        Me.BTNcancelar = New System.Windows.Forms.Button()
        Me.BTNaceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(94, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "&Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(103, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "&Usuario"
        '
        'TXTcontra
        '
        Me.TXTcontra.Location = New System.Drawing.Point(68, 194)
        Me.TXTcontra.Name = "TXTcontra"
        Me.TXTcontra.Size = New System.Drawing.Size(121, 20)
        Me.TXTcontra.TabIndex = 9
        '
        'TXTusuario
        '
        Me.TXTusuario.Location = New System.Drawing.Point(68, 142)
        Me.TXTusuario.Name = "TXTusuario"
        Me.TXTusuario.Size = New System.Drawing.Size(121, 20)
        Me.TXTusuario.TabIndex = 8
        '
        'BTNcancelar
        '
        Me.BTNcancelar.BackColor = System.Drawing.Color.Transparent
        Me.BTNcancelar.BackgroundImage = CType(resources.GetObject("BTNcancelar.BackgroundImage"), System.Drawing.Image)
        Me.BTNcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNcancelar.Location = New System.Drawing.Point(140, 238)
        Me.BTNcancelar.Name = "BTNcancelar"
        Me.BTNcancelar.Size = New System.Drawing.Size(60, 48)
        Me.BTNcancelar.TabIndex = 7
        Me.BTNcancelar.UseVisualStyleBackColor = False
        '
        'BTNaceptar
        '
        Me.BTNaceptar.BackColor = System.Drawing.Color.Transparent
        Me.BTNaceptar.BackgroundImage = CType(resources.GetObject("BTNaceptar.BackgroundImage"), System.Drawing.Image)
        Me.BTNaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNaceptar.Location = New System.Drawing.Point(52, 238)
        Me.BTNaceptar.Name = "BTNaceptar"
        Me.BTNaceptar.Size = New System.Drawing.Size(60, 48)
        Me.BTNaceptar.TabIndex = 6
        Me.BTNaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNaceptar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(64, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 111)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'FormInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(252, 307)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTcontra)
        Me.Controls.Add(Me.TXTusuario)
        Me.Controls.Add(Me.BTNcancelar)
        Me.Controls.Add(Me.BTNaceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTcontra As System.Windows.Forms.TextBox
    Friend WithEvents TXTusuario As System.Windows.Forms.TextBox
    Friend WithEvents BTNcancelar As System.Windows.Forms.Button
    Friend WithEvents BTNaceptar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
