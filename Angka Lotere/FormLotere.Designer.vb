<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLotere
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
        Me.labelPertama = New System.Windows.Forms.Label()
        Me.labelKedua = New System.Windows.Forms.Label()
        Me.labelKetiga = New System.Windows.Forms.Label()
        Me.labelKeempat = New System.Windows.Forms.Label()
        Me.labelKelima = New System.Windows.Forms.Label()
        Me.tombolBangkitkan = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelPertama
        '
        Me.labelPertama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelPertama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPertama.Location = New System.Drawing.Point(13, 13)
        Me.labelPertama.Name = "labelPertama"
        Me.labelPertama.Size = New System.Drawing.Size(55, 30)
        Me.labelPertama.TabIndex = 0
        Me.labelPertama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelKedua
        '
        Me.labelKedua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelKedua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKedua.Location = New System.Drawing.Point(91, 13)
        Me.labelKedua.Name = "labelKedua"
        Me.labelKedua.Size = New System.Drawing.Size(55, 30)
        Me.labelKedua.TabIndex = 1
        Me.labelKedua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelKetiga
        '
        Me.labelKetiga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelKetiga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKetiga.Location = New System.Drawing.Point(169, 13)
        Me.labelKetiga.Name = "labelKetiga"
        Me.labelKetiga.Size = New System.Drawing.Size(55, 30)
        Me.labelKetiga.TabIndex = 2
        Me.labelKetiga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelKeempat
        '
        Me.labelKeempat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelKeempat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKeempat.Location = New System.Drawing.Point(246, 13)
        Me.labelKeempat.Name = "labelKeempat"
        Me.labelKeempat.Size = New System.Drawing.Size(55, 30)
        Me.labelKeempat.TabIndex = 3
        Me.labelKeempat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelKelima
        '
        Me.labelKelima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelKelima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKelima.Location = New System.Drawing.Point(321, 13)
        Me.labelKelima.Name = "labelKelima"
        Me.labelKelima.Size = New System.Drawing.Size(55, 30)
        Me.labelKelima.TabIndex = 4
        Me.labelKelima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tombolBangkitkan
        '
        Me.tombolBangkitkan.Location = New System.Drawing.Point(13, 78)
        Me.tombolBangkitkan.Name = "tombolBangkitkan"
        Me.tombolBangkitkan.Size = New System.Drawing.Size(102, 39)
        Me.tombolBangkitkan.TabIndex = 5
        Me.tombolBangkitkan.Text = "Bangkitkan Angka"
        Me.tombolBangkitkan.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(274, 78)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(102, 39)
        Me.tombolKeluar.TabIndex = 6
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormLotere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 136)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolBangkitkan)
        Me.Controls.Add(Me.labelKelima)
        Me.Controls.Add(Me.labelKeempat)
        Me.Controls.Add(Me.labelKetiga)
        Me.Controls.Add(Me.labelKedua)
        Me.Controls.Add(Me.labelPertama)
        Me.Name = "FormLotere"
        Me.Text = "Angka Lotere"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelPertama As System.Windows.Forms.Label
    Friend WithEvents labelKedua As System.Windows.Forms.Label
    Friend WithEvents labelKetiga As System.Windows.Forms.Label
    Friend WithEvents labelKeempat As System.Windows.Forms.Label
    Friend WithEvents labelKelima As System.Windows.Forms.Label
    Friend WithEvents tombolBangkitkan As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
