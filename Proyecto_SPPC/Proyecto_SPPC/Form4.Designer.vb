<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SubtemaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.BD_ProyectoDataSet = New Proyecto_SPPC.BD_ProyectoDataSet()
        Me.TFormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TFormulaTableAdapter = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TFormulaTableAdapter()
        Me.TableAdapterManager = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager()
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
        Me.SubtemaComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SubtemaLabel2 = New System.Windows.Forms.Label()
        SubtemaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TFormulaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubtemaLabel
        '
        SubtemaLabel.AutoSize = True
        SubtemaLabel.Location = New System.Drawing.Point(40, 113)
        SubtemaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubtemaLabel.Name = "SubtemaLabel"
        SubtemaLabel.Size = New System.Drawing.Size(68, 17)
        SubtemaLabel.TabIndex = 2
        SubtemaLabel.Text = "Subtema:"
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
        Me.TableAdapterManager.TMateriaTableAdapter = Nothing
        Me.TableAdapterManager.TTemaTableAdapter = Nothing
        Me.TableAdapterManager.TUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TFormulaBindingNavigator.Size = New System.Drawing.Size(761, 27)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
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
        'SubtemaComboBox
        '
        Me.SubtemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Subtema", True))
        Me.SubtemaComboBox.FormattingEnabled = True
        Me.SubtemaComboBox.Location = New System.Drawing.Point(117, 113)
        Me.SubtemaComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubtemaComboBox.Name = "SubtemaComboBox"
        Me.SubtemaComboBox.Size = New System.Drawing.Size(353, 24)
        Me.SubtemaComboBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 209)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "IR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 194)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 59)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "AGREGAR NUEVOS TEMAS "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FORMULAS UNIVERSITARIAS "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(498, 194)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 59)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "VOLVER A LA PAG. ANTERIOR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SubtemaLabel2
        '
        Me.SubtemaLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Subtema", True))
        Me.SubtemaLabel2.Location = New System.Drawing.Point(357, 208)
        Me.SubtemaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SubtemaLabel2.Name = "SubtemaLabel2"
        Me.SubtemaLabel2.Size = New System.Drawing.Size(133, 28)
        Me.SubtemaLabel2.TabIndex = 8
        Me.SubtemaLabel2.Text = "Label2"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 328)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(SubtemaLabel)
        Me.Controls.Add(Me.SubtemaComboBox)
        Me.Controls.Add(Me.TFormulaBindingNavigator)
        Me.Controls.Add(Me.SubtemaLabel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TFormulaBindingNavigator.ResumeLayout(False)
        Me.TFormulaBindingNavigator.PerformLayout()
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
    Friend WithEvents SubtemaComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents SubtemaLabel2 As Label
End Class
