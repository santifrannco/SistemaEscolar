<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarioLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarioLogin))
        Me.BTNprofesor = New System.Windows.Forms.Button()
        Me.BTNpreceptor = New System.Windows.Forms.Button()
        Me.BTNadministracion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNsalirUsuarioLogin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNprofesor
        '
        Me.BTNprofesor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNprofesor.Location = New System.Drawing.Point(70, 260)
        Me.BTNprofesor.Name = "BTNprofesor"
        Me.BTNprofesor.Size = New System.Drawing.Size(135, 71)
        Me.BTNprofesor.TabIndex = 0
        Me.BTNprofesor.Text = "PROFESOR"
        Me.BTNprofesor.UseVisualStyleBackColor = False
        '
        'BTNpreceptor
        '
        Me.BTNpreceptor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNpreceptor.Location = New System.Drawing.Point(280, 260)
        Me.BTNpreceptor.Name = "BTNpreceptor"
        Me.BTNpreceptor.Size = New System.Drawing.Size(135, 71)
        Me.BTNpreceptor.TabIndex = 1
        Me.BTNpreceptor.Text = "PRECEPTOR"
        Me.BTNpreceptor.UseVisualStyleBackColor = False
        '
        'BTNadministracion
        '
        Me.BTNadministracion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNadministracion.Location = New System.Drawing.Point(472, 260)
        Me.BTNadministracion.Name = "BTNadministracion"
        Me.BTNadministracion.Size = New System.Drawing.Size(135, 71)
        Me.BTNadministracion.TabIndex = 2
        Me.BTNadministracion.Text = "ADMINISTRACIÓN"
        Me.BTNadministracion.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(85, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 124)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(280, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(127, 122)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(472, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(138, 124)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(177, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "¿Quien va a iniciar sesión?"
        '
        'BTNsalirUsuarioLogin
        '
        Me.BTNsalirUsuarioLogin.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNsalirUsuarioLogin.Location = New System.Drawing.Point(630, 279)
        Me.BTNsalirUsuarioLogin.Name = "BTNsalirUsuarioLogin"
        Me.BTNsalirUsuarioLogin.Size = New System.Drawing.Size(75, 33)
        Me.BTNsalirUsuarioLogin.TabIndex = 7
        Me.BTNsalirUsuarioLogin.Text = "SALIR"
        Me.BTNsalirUsuarioLogin.UseVisualStyleBackColor = False
        '
        'FormUsuarioLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 377)
        Me.Controls.Add(Me.BTNsalirUsuarioLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNadministracion)
        Me.Controls.Add(Me.BTNpreceptor)
        Me.Controls.Add(Me.BTNprofesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUsuarioLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNprofesor As System.Windows.Forms.Button
    Friend WithEvents BTNpreceptor As System.Windows.Forms.Button
    Friend WithEvents BTNadministracion As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNsalirUsuarioLogin As System.Windows.Forms.Button
End Class
