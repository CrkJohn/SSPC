<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario menu"
        '
        'bv
        '
        Me.bv.AutoSize = True
        Me.bv.BackColor = System.Drawing.Color.White
        Me.bv.Font = New System.Drawing.Font("Script MT Bold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.bv.Location = New System.Drawing.Point(36, 118)
        Me.bv.Name = "bv"
        Me.bv.Size = New System.Drawing.Size(132, 33)
        Me.bv.TabIndex = 7
        Me.bv.Text = "Bienvenido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(42, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Promedio de pruebas "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.Location = New System.Drawing.Point(337, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cerrar Session"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(366, 233)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(36, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 33)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Que actividad deseas jugar"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button2.Location = New System.Drawing.Point(337, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(251, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Jugar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'panelUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(620, 452)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "panelUsuario"
        Me.Text = "panelUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bv As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
