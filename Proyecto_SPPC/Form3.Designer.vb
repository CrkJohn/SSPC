<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim UsereNameLabel As System.Windows.Forms.Label
        Dim ClaveLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim RolLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
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
        Me.TUsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsereNameLabel1 = New System.Windows.Forms.Label()
        Me.ClaveLabel1 = New System.Windows.Forms.Label()
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.RolLabel1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        UsereNameLabel = New System.Windows.Forms.Label()
        ClaveLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        RolLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TUsuarioBindingNavigator.SuspendLayout()
        CType(Me.TUsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsereNameLabel
        '
        UsereNameLabel.AutoSize = True
        UsereNameLabel.Location = New System.Drawing.Point(16, 105)
        UsereNameLabel.Name = "UsereNameLabel"
        UsereNameLabel.Size = New System.Drawing.Size(69, 13)
        UsereNameLabel.TabIndex = 18
        UsereNameLabel.Text = "Usere Name:"
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.Location = New System.Drawing.Point(16, 143)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(37, 13)
        ClaveLabel.TabIndex = 19
        ClaveLabel.Text = "Clave:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(16, 174)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 20
        NombreLabel.Text = "Nombre:"
        '
        'RolLabel
        '
        RolLabel.AutoSize = True
        RolLabel.Location = New System.Drawing.Point(16, 206)
        RolLabel.Name = "RolLabel"
        RolLabel.Size = New System.Drawing.Size(26, 13)
        RolLabel.TabIndex = 21
        RolLabel.Text = "Rol:"
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
        Me.TUsuarioBindingNavigator.Size = New System.Drawing.Size(828, 25)
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
        'TUsuarioDataGridView
        '
        Me.TUsuarioDataGridView.AutoGenerateColumns = False
        Me.TUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TUsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TUsuarioDataGridView.DataSource = Me.TUsuarioBindingSource
        Me.TUsuarioDataGridView.Location = New System.Drawing.Point(436, 56)
        Me.TUsuarioDataGridView.Name = "TUsuarioDataGridView"
        Me.TUsuarioDataGridView.Size = New System.Drawing.Size(357, 220)
        Me.TUsuarioDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UsereName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UsereName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Clave"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Clave"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Rol"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Rol"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Creacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Creacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "FORMULAS UNIVERSITARIAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ingrese sus datos para poder ser registrado:"
        '
        'UsereNameLabel1
        '
        Me.UsereNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TUsuarioBindingSource, "UsereName", True))
        Me.UsereNameLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.UsereNameLabel1.Location = New System.Drawing.Point(307, 105)
        Me.UsereNameLabel1.Name = "UsereNameLabel1"
        Me.UsereNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UsereNameLabel1.TabIndex = 19
        Me.UsereNameLabel1.Text = "Label3"
        '
        'ClaveLabel1
        '
        Me.ClaveLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TUsuarioBindingSource, "Clave", True))
        Me.ClaveLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ClaveLabel1.Location = New System.Drawing.Point(279, 133)
        Me.ClaveLabel1.Name = "ClaveLabel1"
        Me.ClaveLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ClaveLabel1.TabIndex = 20
        Me.ClaveLabel1.Text = "Label3"
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TUsuarioBindingSource, "Nombre", True))
        Me.NombreLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.NombreLabel1.Location = New System.Drawing.Point(305, 186)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel1.TabIndex = 21
        Me.NombreLabel1.Text = "Label3"
        '
        'RolLabel1
        '
        Me.RolLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TUsuarioBindingSource, "Rol", True))
        Me.RolLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.RolLabel1.Location = New System.Drawing.Point(290, 232)
        Me.RolLabel1.Name = "RolLabel1"
        Me.RolLabel1.Size = New System.Drawing.Size(100, 23)
        Me.RolLabel1.TabIndex = 22
        Me.RolLabel1.Text = "Label3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 140)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(91, 171)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "REGISTRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 47)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "MENÚ PRINCIPAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ESTUDIANTE ", "PROFESOR"})
        Me.ComboBox1.Location = New System.Drawing.Point(91, 206)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 325)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(RolLabel)
        Me.Controls.Add(Me.RolLabel1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreLabel1)
        Me.Controls.Add(ClaveLabel)
        Me.Controls.Add(Me.ClaveLabel1)
        Me.Controls.Add(UsereNameLabel)
        Me.Controls.Add(Me.UsereNameLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TUsuarioDataGridView)
        Me.Controls.Add(Me.TUsuarioBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TUsuarioBindingNavigator.ResumeLayout(False)
        Me.TUsuarioBindingNavigator.PerformLayout()
        CType(Me.TUsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TUsuarioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsereNameLabel1 As Label
    Friend WithEvents ClaveLabel1 As Label
    Friend WithEvents NombreLabel1 As Label
    Friend WithEvents RolLabel1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
