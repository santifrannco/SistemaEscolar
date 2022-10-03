<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarAlumno))
        Me.BTNsalirr = New System.Windows.Forms.Button()
        Me.BTNagregar = New System.Windows.Forms.Button()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.TXTdni = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTdireccion = New System.Windows.Forms.TextBox()
        Me.TXTapellido = New System.Windows.Forms.TextBox()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.TXTciudad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTfecha_nac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBsexo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTfecha_inscp = New System.Windows.Forms.TextBox()
        Me.TXTano = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha_insc = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha_Naci = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'BTNsalirr
        '
        Me.BTNsalirr.Location = New System.Drawing.Point(367, 222)
        Me.BTNsalirr.Name = "BTNsalirr"
        Me.BTNsalirr.Size = New System.Drawing.Size(87, 37)
        Me.BTNsalirr.TabIndex = 11
        Me.BTNsalirr.Text = "Salir"
        Me.BTNsalirr.UseVisualStyleBackColor = True
        '
        'BTNagregar
        '
        Me.BTNagregar.Location = New System.Drawing.Point(255, 222)
        Me.BTNagregar.Name = "BTNagregar"
        Me.BTNagregar.Size = New System.Drawing.Size(87, 37)
        Me.BTNagregar.TabIndex = 10
        Me.BTNagregar.Text = "Agregar"
        Me.BTNagregar.UseVisualStyleBackColor = True
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Location = New System.Drawing.Point(63, 45)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(26, 13)
        Me.lbl7.TabIndex = 40
        Me.lbl7.Text = "DNI"
        '
        'TXTdni
        '
        Me.TXTdni.Location = New System.Drawing.Point(95, 42)
        Me.TXTdni.Name = "TXTdni"
        Me.TXTdni.Size = New System.Drawing.Size(100, 20)
        Me.TXTdni.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Nombre"
        '
        'TXTdireccion
        '
        Me.TXTdireccion.Location = New System.Drawing.Point(313, 90)
        Me.TXTdireccion.Name = "TXTdireccion"
        Me.TXTdireccion.Size = New System.Drawing.Size(100, 20)
        Me.TXTdireccion.TabIndex = 5
        '
        'TXTapellido
        '
        Me.TXTapellido.Location = New System.Drawing.Point(545, 42)
        Me.TXTapellido.Name = "TXTapellido"
        Me.TXTapellido.Size = New System.Drawing.Size(100, 20)
        Me.TXTapellido.TabIndex = 3
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(313, 45)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(100, 20)
        Me.TXTnombre.TabIndex = 2
        '
        'TXTciudad
        '
        Me.TXTciudad.Location = New System.Drawing.Point(95, 90)
        Me.TXTciudad.Name = "TXTciudad"
        Me.TXTciudad.Size = New System.Drawing.Size(100, 20)
        Me.TXTciudad.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Ciudad"
        '
        'TXTfecha_nac
        '
        Me.TXTfecha_nac.Location = New System.Drawing.Point(557, 248)
        Me.TXTfecha_nac.Name = "TXTfecha_nac"
        Me.TXTfecha_nac.Size = New System.Drawing.Size(100, 20)
        Me.TXTfecha_nac.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Fecha de nacimiento"
        '
        'CMBsexo
        '
        Me.CMBsexo.FormattingEnabled = True
        Me.CMBsexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CMBsexo.Location = New System.Drawing.Point(95, 145)
        Me.CMBsexo.Name = "CMBsexo"
        Me.CMBsexo.Size = New System.Drawing.Size(100, 21)
        Me.CMBsexo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Sexo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Fecha de inscripcion"
        '
        'TXTfecha_inscp
        '
        Me.TXTfecha_inscp.Location = New System.Drawing.Point(557, 222)
        Me.TXTfecha_inscp.Name = "TXTfecha_inscp"
        Me.TXTfecha_inscp.Size = New System.Drawing.Size(100, 20)
        Me.TXTfecha_inscp.TabIndex = 50
        '
        'TXTano
        '
        Me.TXTano.Location = New System.Drawing.Point(545, 141)
        Me.TXTano.Name = "TXTano"
        Me.TXTano.Size = New System.Drawing.Size(100, 20)
        Me.TXTano.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(463, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Año"
        '
        'dtpFecha_insc
        '
        Me.dtpFecha_insc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_insc.Location = New System.Drawing.Point(313, 146)
        Me.dtpFecha_insc.MinDate = New Date(2022, 9, 2, 0, 0, 0, 0)
        Me.dtpFecha_insc.Name = "dtpFecha_insc"
        Me.dtpFecha_insc.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecha_insc.TabIndex = 8
        '
        'dtpFecha_Naci
        '
        Me.dtpFecha_Naci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Naci.Location = New System.Drawing.Point(545, 91)
        Me.dtpFecha_Naci.MaxDate = New Date(2022, 10, 3, 0, 0, 0, 0)
        Me.dtpFecha_Naci.Name = "dtpFecha_Naci"
        Me.dtpFecha_Naci.Size = New System.Drawing.Size(94, 20)
        Me.dtpFecha_Naci.TabIndex = 6
        '
        'FormAgregarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 271)
        Me.Controls.Add(Me.dtpFecha_Naci)
        Me.Controls.Add(Me.dtpFecha_insc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTano)
        Me.Controls.Add(Me.TXTfecha_inscp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CMBsexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTfecha_nac)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTciudad)
        Me.Controls.Add(Me.BTNsalirr)
        Me.Controls.Add(Me.BTNagregar)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.TXTdni)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTdireccion)
        Me.Controls.Add(Me.TXTapellido)
        Me.Controls.Add(Me.TXTnombre)
        Me.Name = "FormAgregarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNsalirr As System.Windows.Forms.Button
    Friend WithEvents BTNagregar As System.Windows.Forms.Button
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents TXTdni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTdireccion As System.Windows.Forms.TextBox
    Friend WithEvents TXTapellido As System.Windows.Forms.TextBox
    Friend WithEvents TXTnombre As System.Windows.Forms.TextBox
    Friend WithEvents TXTciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTfecha_nac As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMBsexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTfecha_inscp As System.Windows.Forms.TextBox
    Friend WithEvents TXTano As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_insc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha_Naci As System.Windows.Forms.DateTimePicker
End Class
