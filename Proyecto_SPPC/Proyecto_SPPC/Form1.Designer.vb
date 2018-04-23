<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ClaveLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BD_ProyectoDataSet = New Proyecto_SPPC.BD_ProyectoDataSet()
        Me.TUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TUsuarioTableAdapter = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TUsuarioTableAdapter()
        Me.TableAdapterManager = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager()
        Me.TUsuarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TUsuarioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TUsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TUsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ClaveLabel1 = New System.Windows.Forms.Label()
        ClaveLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TUsuarioBindingNavigator.SuspendLayout()
        CType(Me.TUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.ForeColor = System.Drawing.SystemColors.Control
        ClaveLabel.Location = New System.Drawing.Point(25, 236)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(37, 13)
        ClaveLabel.TabIndex = 11
        ClaveLabel.Text = "Clave:"
        '
        'BD_ProyectoDataSet
        '
        Me.BD_ProyectoDataSet.DataSetName = "BD_ProyectoDataSet"
        Me.BD_ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TUsuarioBindingSource
        '
        Me.TUsuarioBindingSource.DataMember = "TUsuario"
        Me.TUsuarioBindingSource.DataSource = Me.BD_ProyectoDataSet
        '
        'TUsuarioTableAdapter
        '
        Me.TUsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TFormulaTableAdapter = Nothing
        Me.TableAdapterManager.TMateriaTableAdapter = Nothing
        Me.TableAdapterManager.TTemaTableAdapter = Nothing
        Me.TableAdapterManager.TUsuarioTableAdapter = Me.TUsuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TUsuarioBindingNavigator
        '
        Me.TUsuarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TUsuarioBindingNavigator.BindingSource = Me.TUsuarioBindingSource
        Me.TUsuarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TUsuarioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TUsuarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TUsuarioBindingNavigatorSaveItem})
        Me.TUsuarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TUsuarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TUsuarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TUsuarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TUsuarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TUsuarioBindingNavigator.Name = "TUsuarioBindingNavigator"
        Me.TUsuarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TUsuarioBindingNavigator.Size = New System.Drawing.Size(411, 25)
        Me.TUsuarioBindingNavigator.TabIndex = 0
        Me.TUsuarioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TUsuarioBindingNavigatorSaveItem
        '
        Me.TUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TUsuarioBindingNavigatorSaveItem.Image = CType(resources.GetObject("TUsuarioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TUsuarioBindingNavigatorSaveItem.Name = "TUsuarioBindingNavigatorSaveItem"
        Me.TUsuarioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TUsuarioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TUsuarioBindingSource1
        '
        Me.TUsuarioBindingSource1.DataMember = "TUsuario"
        Me.TUsuarioBindingSource1.DataSource = Me.BD_ProyectoDataSet
        '
        'TUsuarioComboBox
        '
        Me.TUsuarioComboBox.DataSource = Me.TUsuarioBindingSource1
        Me.TUsuarioComboBox.DisplayMember = "UsereName"
        Me.TUsuarioComboBox.FormattingEnabled = True
        Me.TUsuarioComboBox.Location = New System.Drawing.Point(12, 75)
        Me.TUsuarioComboBox.Name = "TUsuarioComboBox"
        Me.TUsuarioComboBox.Size = New System.Drawing.Size(300, 21)
        Me.TUsuarioComboBox.TabIndex = 1
        Me.TUsuarioComboBox.ValueMember = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FORMULAS UNIVERSITARIAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USUARIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CONTRASEÑA:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "ACTUALIZAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "¿USUARIO NUEVO?"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(127, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "REGISTRAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(316, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "SALIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ClaveLabel1
        '
        Me.ClaveLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TUsuarioBindingSource1, "Clave", True))
        Me.ClaveLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ClaveLabel1.Location = New System.Drawing.Point(68, 236)
        Me.ClaveLabel1.Name = "ClaveLabel1"
        Me.ClaveLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ClaveLabel1.TabIndex = 12
        Me.ClaveLabel1.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 269)
        Me.Controls.Add(ClaveLabel)
        Me.Controls.Add(Me.ClaveLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TUsuarioComboBox)
        Me.Controls.Add(Me.TUsuarioBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TUsuarioBindingNavigator.ResumeLayout(False)
        Me.TUsuarioBindingNavigator.PerformLayout()
        CType(Me.TUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ProyectoDataSet As BD_ProyectoDataSet
    Friend WithEvents TUsuarioBindingSource As BindingSource
    Friend WithEvents TUsuarioTableAdapter As BD_ProyectoDataSetTableAdapters.TUsuarioTableAdapter
    Friend WithEvents TableAdapterManager As BD_ProyectoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TUsuarioBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TUsuarioBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TUsuarioBindingSource1 As BindingSource
    Friend WithEvents TUsuarioComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ClaveLabel1 As Label
End Class
