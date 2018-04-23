<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim TemaLabel As System.Windows.Forms.Label
        Dim MateriaLabel As System.Windows.Forms.Label
        Dim DescripciónTemaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.BD_ProyectoDataSet = New Proyecto_SPPC.BD_ProyectoDataSet()
        Me.TFormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TFormulaTableAdapter = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TFormulaTableAdapter()
        Me.TableAdapterManager = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager()
        Me.TMateriaTableAdapter = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TMateriaTableAdapter()
        Me.TTemaTableAdapter = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TTemaTableAdapter()
        Me.TFormulaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TFormulaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TMateriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TemaLabel2 = New System.Windows.Forms.Label()
        Me.TTemaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTemaComboBox = New System.Windows.Forms.ComboBox()
        Me.TemaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MateriaLabel1 = New System.Windows.Forms.Label()
        Me.DescripciónTemaLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        TemaLabel = New System.Windows.Forms.Label()
        MateriaLabel = New System.Windows.Forms.Label()
        DescripciónTemaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TFormulaBindingNavigator.SuspendLayout()
        CType(Me.TMateriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTemaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.Location = New System.Drawing.Point(21, 246)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(37, 13)
        TemaLabel.TabIndex = 5
        TemaLabel.Text = "Tema:"
        '
        'MateriaLabel
        '
        MateriaLabel.AutoSize = True
        MateriaLabel.Location = New System.Drawing.Point(21, 151)
        MateriaLabel.Name = "MateriaLabel"
        MateriaLabel.Size = New System.Drawing.Size(45, 13)
        MateriaLabel.TabIndex = 3
        MateriaLabel.Text = "Materia:"
        '
        'DescripciónTemaLabel
        '
        DescripciónTemaLabel.AutoSize = True
        DescripciónTemaLabel.Location = New System.Drawing.Point(21, 183)
        DescripciónTemaLabel.Name = "DescripciónTemaLabel"
        DescripciónTemaLabel.Size = New System.Drawing.Size(96, 13)
        DescripciónTemaLabel.TabIndex = 6
        DescripciónTemaLabel.Text = "Descripción Tema:"
        '
        'BD_ProyectoDataSet
        '
        Me.BD_ProyectoDataSet.DataSetName = "BD_ProyectoDataSet"
        Me.BD_ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TFormulaBindingSource
        '
        Me.TFormulaBindingSource.DataMember = "TFormula"
        Me.TFormulaBindingSource.DataSource = Me.BD_ProyectoDataSet
        '
        'TFormulaTableAdapter
        '
        Me.TFormulaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TFormulaTableAdapter = Me.TFormulaTableAdapter
        Me.TableAdapterManager.TMateriaTableAdapter = Me.TMateriaTableAdapter
        Me.TableAdapterManager.TTemaTableAdapter = Me.TTemaTableAdapter
        Me.TableAdapterManager.TUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TMateriaTableAdapter
        '
        Me.TMateriaTableAdapter.ClearBeforeFill = True
        '
        'TTemaTableAdapter
        '
        Me.TTemaTableAdapter.ClearBeforeFill = True
        '
        'TFormulaBindingNavigator
        '
        Me.TFormulaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TFormulaBindingNavigator.BindingSource = Me.TFormulaBindingSource
        Me.TFormulaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TFormulaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TFormulaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TFormulaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TFormulaBindingNavigatorSaveItem})
        Me.TFormulaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TFormulaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TFormulaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TFormulaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TFormulaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TFormulaBindingNavigator.Name = "TFormulaBindingNavigator"
        Me.TFormulaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TFormulaBindingNavigator.Size = New System.Drawing.Size(490, 27)
        Me.TFormulaBindingNavigator.TabIndex = 0
        Me.TFormulaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TFormulaBindingNavigatorSaveItem
        '
        Me.TFormulaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TFormulaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TFormulaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TFormulaBindingNavigatorSaveItem.Name = "TFormulaBindingNavigatorSaveItem"
        Me.TFormulaBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.TFormulaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TMateriaBindingSource
        '
        Me.TMateriaBindingSource.DataMember = "TMateria"
        Me.TMateriaBindingSource.DataSource = Me.BD_ProyectoDataSet
        '
        'TTemaBindingSource
        '
        Me.TTemaBindingSource.DataMember = "TTema"
        Me.TTemaBindingSource.DataSource = Me.BD_ProyectoDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FORMULAS UNIVERSITARIAS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 41)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "VOLVER A LA PAG. PRINCIPAL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TemaLabel2
        '
        Me.TemaLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TTemaBindingSource, "Tema", True))
        Me.TemaLabel2.Location = New System.Drawing.Point(337, 298)
        Me.TemaLabel2.Name = "TemaLabel2"
        Me.TemaLabel2.Size = New System.Drawing.Size(100, 23)
        Me.TemaLabel2.TabIndex = 11
        Me.TemaLabel2.Text = "Label2"
        '
        'TTemaBindingSource1
        '
        Me.TTemaBindingSource1.DataMember = "TTema"
        Me.TTemaBindingSource1.DataSource = Me.BD_ProyectoDataSet
        '
        'TTemaComboBox
        '
        Me.TTemaComboBox.DataSource = Me.TTemaBindingSource1
        Me.TTemaComboBox.DisplayMember = "Materia"
        Me.TTemaComboBox.FormattingEnabled = True
        Me.TTemaComboBox.Location = New System.Drawing.Point(23, 105)
        Me.TTemaComboBox.Name = "TTemaComboBox"
        Me.TTemaComboBox.Size = New System.Drawing.Size(300, 21)
        Me.TTemaComboBox.TabIndex = 12
        Me.TTemaComboBox.ValueMember = "Id"
        '
        'TemaComboBox
        '
        Me.TemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TTemaBindingSource, "Tema", True))
        Me.TemaComboBox.FormattingEnabled = True
        Me.TemaComboBox.Location = New System.Drawing.Point(64, 246)
        Me.TemaComboBox.Name = "TemaComboBox"
        Me.TemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TemaComboBox.TabIndex = 6
        Me.TemaComboBox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Seleccione tema:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "IR"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(339, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "SELECCIONAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MateriaLabel1
        '
        Me.MateriaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TTemaBindingSource, "Materia", True))
        Me.MateriaLabel1.Location = New System.Drawing.Point(81, 151)
        Me.MateriaLabel1.Name = "MateriaLabel1"
        Me.MateriaLabel1.Size = New System.Drawing.Size(121, 23)
        Me.MateriaLabel1.TabIndex = 4
        Me.MateriaLabel1.Visible = False
        '
        'DescripciónTemaLabel1
        '
        Me.DescripciónTemaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TTemaBindingSource, "DescripciónTema", True))
        Me.DescripciónTemaLabel1.Location = New System.Drawing.Point(123, 183)
        Me.DescripciónTemaLabel1.Name = "DescripciónTemaLabel1"
        Me.DescripciónTemaLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DescripciónTemaLabel1.TabIndex = 7
        Me.DescripciónTemaLabel1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Seleccione asignatura:"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 385)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TTemaComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(DescripciónTemaLabel)
        Me.Controls.Add(Me.DescripciónTemaLabel1)
        Me.Controls.Add(MateriaLabel)
        Me.Controls.Add(Me.MateriaLabel1)
        Me.Controls.Add(TemaLabel)
        Me.Controls.Add(Me.TemaComboBox)
        Me.Controls.Add(Me.TFormulaBindingNavigator)
        Me.Controls.Add(Me.TemaLabel2)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TFormulaBindingNavigator.ResumeLayout(False)
        Me.TFormulaBindingNavigator.PerformLayout()
        CType(Me.TMateriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTemaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ProyectoDataSet As BD_ProyectoDataSet
    Friend WithEvents TFormulaBindingSource As BindingSource
    Friend WithEvents TFormulaTableAdapter As BD_ProyectoDataSetTableAdapters.TFormulaTableAdapter
    Friend WithEvents TableAdapterManager As BD_ProyectoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TFormulaBindingNavigator As BindingNavigator
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
    Friend WithEvents TFormulaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TMateriaTableAdapter As BD_ProyectoDataSetTableAdapters.TMateriaTableAdapter
    Friend WithEvents TMateriaBindingSource As BindingSource
    Friend WithEvents TTemaTableAdapter As BD_ProyectoDataSetTableAdapters.TTemaTableAdapter
    Friend WithEvents TTemaBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TemaLabel2 As Label
    Friend WithEvents TTemaBindingSource1 As BindingSource
    Friend WithEvents TTemaComboBox As ComboBox
    Friend WithEvents TemaComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MateriaLabel1 As Label
    Friend WithEvents DescripciónTemaLabel1 As Label
    Friend WithEvents Label3 As Label
End Class
