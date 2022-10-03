<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENÚ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENÚ))
        Me.btnCARGARGRILLA = New System.Windows.Forms.Button()
        Me.BTNmodificar = New System.Windows.Forms.Button()
        Me.BTNagregar = New System.Windows.Forms.Button()
        Me.BTNconectar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BTNsalir = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCARGARGRILLA
        '
        Me.btnCARGARGRILLA.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCARGARGRILLA.Location = New System.Drawing.Point(295, 228)
        Me.btnCARGARGRILLA.Name = "btnCARGARGRILLA"
        Me.btnCARGARGRILLA.Size = New System.Drawing.Size(133, 36)
        Me.btnCARGARGRILLA.TabIndex = 23
        Me.btnCARGARGRILLA.Text = "CARGAR GRILLA"
        Me.btnCARGARGRILLA.UseVisualStyleBackColor = False
        '
        'BTNmodificar
        '
        Me.BTNmodificar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNmodificar.Location = New System.Drawing.Point(460, 101)
        Me.BTNmodificar.Name = "BTNmodificar"
        Me.BTNmodificar.Size = New System.Drawing.Size(133, 36)
        Me.BTNmodificar.TabIndex = 22
        Me.BTNmodificar.Text = "MODIFICAR ALUMNOS"
        Me.BTNmodificar.UseVisualStyleBackColor = False
        '
        'BTNagregar
        '
        Me.BTNagregar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNagregar.Location = New System.Drawing.Point(295, 101)
        Me.BTNagregar.Name = "BTNagregar"
        Me.BTNagregar.Size = New System.Drawing.Size(133, 36)
        Me.BTNagregar.TabIndex = 21
        Me.BTNagregar.Text = "AGREGAR ALUMNO"
        Me.BTNagregar.UseVisualStyleBackColor = False
        '
        'BTNconectar
        '
        Me.BTNconectar.BackColor = System.Drawing.SystemColors.Menu
        Me.BTNconectar.Location = New System.Drawing.Point(167, 119)
        Me.BTNconectar.Name = "BTNconectar"
        Me.BTNconectar.Size = New System.Drawing.Size(75, 36)
        Me.BTNconectar.TabIndex = 19
        Me.BTNconectar.Text = "Conectar"
        Me.BTNconectar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(305, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 81)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(480, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 79)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(305, 143)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'BTNsalir
        '
        Me.BTNsalir.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNsalir.Location = New System.Drawing.Point(460, 228)
        Me.BTNsalir.Name = "BTNsalir"
        Me.BTNsalir.Size = New System.Drawing.Size(133, 36)
        Me.BTNsalir.TabIndex = 27
        Me.BTNsalir.Text = "SALIR"
        Me.BTNsalir.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(470, 143)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(102, 99)
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'MENÚ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(639, 272)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BTNsalir)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCARGARGRILLA)
        Me.Controls.Add(Me.BTNmodificar)
        Me.Controls.Add(Me.BTNagregar)
        Me.Controls.Add(Me.BTNconectar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "MENÚ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENÚ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCARGARGRILLA As System.Windows.Forms.Button
    Friend WithEvents BTNmodificar As System.Windows.Forms.Button
    Friend WithEvents BTNagregar As System.Windows.Forms.Button
    Friend WithEvents BTNconectar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BTNsalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
