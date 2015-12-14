<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventana))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cTipo = New System.Windows.Forms.CheckedListBox()
        Me.cConduccion = New System.Windows.Forms.CheckedListBox()
        Me.cMontajeBruto = New System.Windows.Forms.CheckedListBox()
        Me.cTransmision = New System.Windows.Forms.CheckedListBox()
        Me.cNivelCarga = New System.Windows.Forms.CheckedListBox()
        Me.cVariantesPais = New System.Windows.Forms.CheckedListBox()
        Me.cNoAsignado = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tset = New System.Windows.Forms.TextBox()
        Me.Lab = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tlevel = New System.Windows.Forms.TextBox()
        Me.tAligment = New System.Windows.Forms.TextBox()
        Me.tFunction = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BRefrescar = New System.Windows.Forms.Button()
        Me.Beditar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "(Tipo)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(522, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "(Montaje Bruto)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(622, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "(Transmision)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(715, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "(Nivel de Carga)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(803, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "(Variante de País)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(908, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "(No Asignado)"
        '
        'cTipo
        '
        Me.cTipo.CheckOnClick = True
        Me.cTipo.FormattingEnabled = True
        Me.cTipo.Location = New System.Drawing.Point(336, 51)
        Me.cTipo.Name = "cTipo"
        Me.cTipo.Size = New System.Drawing.Size(78, 139)
        Me.cTipo.TabIndex = 7
        '
        'cConduccion
        '
        Me.cConduccion.CheckOnClick = True
        Me.cConduccion.FormattingEnabled = True
        Me.cConduccion.Location = New System.Drawing.Point(430, 51)
        Me.cConduccion.Name = "cConduccion"
        Me.cConduccion.Size = New System.Drawing.Size(78, 139)
        Me.cConduccion.TabIndex = 8
        '
        'cMontajeBruto
        '
        Me.cMontajeBruto.CheckOnClick = True
        Me.cMontajeBruto.FormattingEnabled = True
        Me.cMontajeBruto.Location = New System.Drawing.Point(525, 51)
        Me.cMontajeBruto.Name = "cMontajeBruto"
        Me.cMontajeBruto.Size = New System.Drawing.Size(78, 139)
        Me.cMontajeBruto.TabIndex = 9
        '
        'cTransmision
        '
        Me.cTransmision.CheckOnClick = True
        Me.cTransmision.FormattingEnabled = True
        Me.cTransmision.Location = New System.Drawing.Point(620, 51)
        Me.cTransmision.Name = "cTransmision"
        Me.cTransmision.Size = New System.Drawing.Size(78, 139)
        Me.cTransmision.TabIndex = 10
        '
        'cNivelCarga
        '
        Me.cNivelCarga.CheckOnClick = True
        Me.cNivelCarga.FormattingEnabled = True
        Me.cNivelCarga.Location = New System.Drawing.Point(715, 51)
        Me.cNivelCarga.Name = "cNivelCarga"
        Me.cNivelCarga.Size = New System.Drawing.Size(78, 139)
        Me.cNivelCarga.TabIndex = 11
        '
        'cVariantesPais
        '
        Me.cVariantesPais.CheckOnClick = True
        Me.cVariantesPais.FormattingEnabled = True
        Me.cVariantesPais.Location = New System.Drawing.Point(810, 51)
        Me.cVariantesPais.Name = "cVariantesPais"
        Me.cVariantesPais.Size = New System.Drawing.Size(78, 139)
        Me.cVariantesPais.TabIndex = 12
        '
        'cNoAsignado
        '
        Me.cNoAsignado.CheckOnClick = True
        Me.cNoAsignado.FormattingEnabled = True
        Me.cNoAsignado.Location = New System.Drawing.Point(908, 52)
        Me.cNoAsignado.Name = "cNoAsignado"
        Me.cNoAsignado.Size = New System.Drawing.Size(78, 169)
        Me.cNoAsignado.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Nuevo CruceSet"
        '
        'Tset
        '
        Me.Tset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tset.Location = New System.Drawing.Point(123, 248)
        Me.Tset.Name = "Tset"
        Me.Tset.Size = New System.Drawing.Size(957, 22)
        Me.Tset.TabIndex = 15
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.Location = New System.Drawing.Point(11, 35)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(113, 13)
        Me.Lab.TabIndex = 16
        Me.Lab.Text = "(Nivel de Ensamblado)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "(Función)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(245, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "(Alineación)"
        '
        'tlevel
        '
        Me.tlevel.Location = New System.Drawing.Point(18, 52)
        Me.tlevel.Name = "tlevel"
        Me.tlevel.Size = New System.Drawing.Size(100, 20)
        Me.tlevel.TabIndex = 19
        '
        'tAligment
        '
        Me.tAligment.Location = New System.Drawing.Point(230, 52)
        Me.tAligment.Name = "tAligment"
        Me.tAligment.Size = New System.Drawing.Size(100, 20)
        Me.tAligment.TabIndex = 21
        '
        'tFunction
        '
        Me.tFunction.Location = New System.Drawing.Point(124, 52)
        Me.tFunction.Name = "tFunction"
        Me.tFunction.Size = New System.Drawing.Size(100, 20)
        Me.tFunction.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(359, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Typ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(Conducción)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(441, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Lenker"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(536, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Rohbau"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(633, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Antrieb"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(731, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Laststufe"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(810, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Ländervariante"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(926, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "N/N"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(250, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Alignment"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(139, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Function"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(26, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Assembly Level"
        '
        'BRefrescar
        '
        Me.BRefrescar.Location = New System.Drawing.Point(937, 286)
        Me.BRefrescar.Name = "BRefrescar"
        Me.BRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.BRefrescar.TabIndex = 36
        Me.BRefrescar.Text = "Refrescar"
        Me.BRefrescar.UseVisualStyleBackColor = True
        '
        'Beditar
        '
        Me.Beditar.Location = New System.Drawing.Point(856, 286)
        Me.Beditar.Name = "Beditar"
        Me.Beditar.Size = New System.Drawing.Size(75, 23)
        Me.Beditar.TabIndex = 35
        Me.Beditar.Text = "Editar"
        Me.Beditar.UseVisualStyleBackColor = True
        '
        'ventana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 321)
        Me.Controls.Add(Me.BRefrescar)
        Me.Controls.Add(Me.Beditar)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tAligment)
        Me.Controls.Add(Me.tFunction)
        Me.Controls.Add(Me.tlevel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Lab)
        Me.Controls.Add(Me.Tset)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cNoAsignado)
        Me.Controls.Add(Me.cVariantesPais)
        Me.Controls.Add(Me.cNivelCarga)
        Me.Controls.Add(Me.cTransmision)
        Me.Controls.Add(Me.cMontajeBruto)
        Me.Controls.Add(Me.cConduccion)
        Me.Controls.Add(Me.cTipo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ventana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Generador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cTipo As System.Windows.Forms.CheckedListBox
    Friend WithEvents cConduccion As System.Windows.Forms.CheckedListBox
    Friend WithEvents cMontajeBruto As System.Windows.Forms.CheckedListBox
    Friend WithEvents cTransmision As System.Windows.Forms.CheckedListBox
    Friend WithEvents cNivelCarga As System.Windows.Forms.CheckedListBox
    Friend WithEvents cVariantesPais As System.Windows.Forms.CheckedListBox
    Friend WithEvents cNoAsignado As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tset As System.Windows.Forms.TextBox
    Friend WithEvents Lab As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tlevel As System.Windows.Forms.TextBox
    Friend WithEvents tAligment As System.Windows.Forms.TextBox
    Friend WithEvents tFunction As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BRefrescar As System.Windows.Forms.Button
    Friend WithEvents Beditar As System.Windows.Forms.Button

End Class
