<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargarGrilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarGrilla))
        Me.LViewAlumnos = New System.Windows.Forms.ListView()
        Me.ColumnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDNI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnAPE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNOM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDIREC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnFechaNac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNimprimir = New System.Windows.Forms.Button()
        Me.BTNsalirGrilla = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LViewAlumnos
        '
        Me.LViewAlumnos.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LViewAlumnos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnID, Me.ColumnDNI, Me.ColumnAPE, Me.ColumnNOM, Me.ColumnDIREC, Me.ColumnSexo, Me.ColumnFechaNac})
        Me.LViewAlumnos.Location = New System.Drawing.Point(48, 31)
        Me.LViewAlumnos.Name = "LViewAlumnos"
        Me.LViewAlumnos.Size = New System.Drawing.Size(727, 345)
        Me.LViewAlumnos.TabIndex = 1
        Me.LViewAlumnos.UseCompatibleStateImageBehavior = False
        Me.LViewAlumnos.View = System.Windows.Forms.View.Details
        '
        'ColumnID
        '
        Me.ColumnID.Text = "ID"
        Me.ColumnID.Width = 69
        '
        'ColumnDNI
        '
        Me.ColumnDNI.Text = "DNI"
        Me.ColumnDNI.Width = 82
        '
        'ColumnAPE
        '
        Me.ColumnAPE.Text = "APELLIDO"
        Me.ColumnAPE.Width = 110
        '
        'ColumnNOM
        '
        Me.ColumnNOM.Text = "NOMBRE"
        Me.ColumnNOM.Width = 136
        '
        'ColumnDIREC
        '
        Me.ColumnDIREC.Text = "DIRECCION"
        Me.ColumnDIREC.Width = 129
        '
        'ColumnSexo
        '
        Me.ColumnSexo.Text = "SEXO"
        Me.ColumnSexo.Width = 72
        '
        'ColumnFechaNac
        '
        Me.ColumnFechaNac.Text = "FECHA NACIMIENTO"
        Me.ColumnFechaNac.Width = 121
        '
        'BTNimprimir
        '
        Me.BTNimprimir.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNimprimir.Location = New System.Drawing.Point(284, 426)
        Me.BTNimprimir.Name = "BTNimprimir"
        Me.BTNimprimir.Size = New System.Drawing.Size(103, 48)
        Me.BTNimprimir.TabIndex = 2
        Me.BTNimprimir.Text = "IMPRIMIR"
        Me.BTNimprimir.UseVisualStyleBackColor = False
        '
        'BTNsalirGrilla
        '
        Me.BTNsalirGrilla.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNsalirGrilla.Location = New System.Drawing.Point(457, 426)
        Me.BTNsalirGrilla.Name = "BTNsalirGrilla"
        Me.BTNsalirGrilla.Size = New System.Drawing.Size(103, 48)
        Me.BTNsalirGrilla.TabIndex = 3
        Me.BTNsalirGrilla.Text = "SALIR"
        Me.BTNsalirGrilla.UseVisualStyleBackColor = False
        '
        'FormCargarGrilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(828, 509)
        Me.Controls.Add(Me.BTNsalirGrilla)
        Me.Controls.Add(Me.BTNimprimir)
        Me.Controls.Add(Me.LViewAlumnos)
        Me.Name = "FormCargarGrilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Grilla"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LViewAlumnos As System.Windows.Forms.ListView
    Friend WithEvents ColumnID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnDNI As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnAPE As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnNOM As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnDIREC As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNimprimir As System.Windows.Forms.Button
    Friend WithEvents ColumnSexo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnFechaNac As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNsalirGrilla As System.Windows.Forms.Button
End Class
