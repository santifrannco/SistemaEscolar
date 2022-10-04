<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargarImagenAlum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarImagenAlum))
        Me.lstIDImg = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscarImagen = New System.Windows.Forms.Button()
        Me.pbPicture = New System.Windows.Forms.PictureBox()
        Me.txtPathImg = New System.Windows.Forms.TextBox()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BTNSalirDeCargarImagen = New System.Windows.Forms.Button()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstIDImg
        '
        Me.lstIDImg.FormattingEnabled = True
        Me.lstIDImg.Location = New System.Drawing.Point(451, 15)
        Me.lstIDImg.Name = "lstIDImg"
        Me.lstIDImg.Size = New System.Drawing.Size(107, 212)
        Me.lstIDImg.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID REGISTRO"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(443, 259)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(126, 20)
        Me.txtId.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PATH DE IMAGEN"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGuardar.Location = New System.Drawing.Point(178, 301)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 41)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "GUARDAR IMAGEN"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarImagen.Location = New System.Drawing.Point(40, 301)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(110, 41)
        Me.btnBuscarImagen.TabIndex = 12
        Me.btnBuscarImagen.Text = "BUSCAR IMAGEN"
        Me.btnBuscarImagen.UseVisualStyleBackColor = False
        '
        'pbPicture
        '
        Me.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPicture.Location = New System.Drawing.Point(82, 12)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(281, 215)
        Me.pbPicture.TabIndex = 11
        Me.pbPicture.TabStop = False
        '
        'txtPathImg
        '
        Me.txtPathImg.Location = New System.Drawing.Point(26, 259)
        Me.txtPathImg.Name = "txtPathImg"
        Me.txtPathImg.Size = New System.Drawing.Size(391, 20)
        Me.txtPathImg.TabIndex = 10
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCargarImagen.Location = New System.Drawing.Point(320, 301)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(110, 41)
        Me.btnCargarImagen.TabIndex = 9
        Me.btnCargarImagen.Text = "CARGAR IMAGEN DESDE BD"
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BTNSalirDeCargarImagen
        '
        Me.BTNSalirDeCargarImagen.BackColor = System.Drawing.Color.OrangeRed
        Me.BTNSalirDeCargarImagen.Location = New System.Drawing.Point(460, 301)
        Me.BTNSalirDeCargarImagen.Name = "BTNSalirDeCargarImagen"
        Me.BTNSalirDeCargarImagen.Size = New System.Drawing.Size(109, 42)
        Me.BTNSalirDeCargarImagen.TabIndex = 18
        Me.BTNSalirDeCargarImagen.Text = "SALIR"
        Me.BTNSalirDeCargarImagen.UseVisualStyleBackColor = False
        '
        'FormCargarImagenAlum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(623, 352)
        Me.Controls.Add(Me.BTNSalirDeCargarImagen)
        Me.Controls.Add(Me.lstIDImg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBuscarImagen)
        Me.Controls.Add(Me.pbPicture)
        Me.Controls.Add(Me.txtPathImg)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCargarImagenAlum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstIDImg As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarImagen As System.Windows.Forms.Button
    Friend WithEvents pbPicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtPathImg As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarImagen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BTNSalirDeCargarImagen As System.Windows.Forms.Button
End Class
