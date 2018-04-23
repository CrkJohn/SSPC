<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BD_ProyectoDataSet = New Proyecto_SPPC.BD_ProyectoDataSet()
        Me.TMateriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TMateriaTableAdapter = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TMateriaTableAdapter()
        Me.TableAdapterManager = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager()
        Me.TMateriaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TMateriaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TMateriaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TTemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTemaTableAdapter = New Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TTemaTableAdapter()
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMateriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMateriaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TMateriaBindingNavigator.SuspendLayout()
        CType(Me.TTemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_ProyectoDataSet
        '
        Me.BD_ProyectoDataSet.DataSetName = "BD_ProyectoDataSet"
        Me.BD_ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TMateriaBindingSource
        '
        Me.TMateriaBindingSource.DataMember = "TMateria"
        Me.TMateriaBindingSource.DataSource = Me.BD_ProyectoDataSet
        '
        'TMateriaTableAdapter
        '
        Me.TMateriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TFormulaTableAdapter = Nothing
        Me.TableAdapterManager.TMateriaTableAdapter = Me.TMateriaTableAdapter
        Me.TableAdapterManager.TTemaTableAdapter = Nothing
        Me.TableAdapterManager.TUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_SPPC.BD_ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TMateriaBindingNavigator
        '
        Me.TMateriaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TMateriaBindingNavigator.BindingSource = Me.TMateriaBindingSource
        Me.TMateriaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TMateriaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TMateriaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TMateriaBindingNavigatorSaveItem})
        Me.TMateriaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TMateriaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TMateriaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TMateriaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TMateriaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TMateriaBindingNavigator.Name = "TMateriaBindingNavigator"
        Me.TMateriaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TMateriaBindingNavigator.Size = New System.Drawing.Size(491, 25)
        Me.TMateriaBindingNavigator.TabIndex = 0
        Me.TMateriaBindingNavigator.Text = "BindingNavigator1"
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
        'TMateriaBindingNavigatorSaveItem
        '
        Me.TMateriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TMateriaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TMateriaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TMateriaBindingNavigatorSaveItem.Name = "TMateriaBindingNavigatorSaveItem"
        Me.TMateriaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TMateriaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TMateriaComboBox
        '
        Me.TMateriaComboBox.DataSource = Me.TMateriaBindingSource
        Me.TMateriaComboBox.DisplayMember = "Nombre"
        Me.TMateriaComboBox.FormattingEnabled = True
        Me.TMateriaComboBox.Location = New System.Drawing.Point(56, 111)
        Me.TMateriaComboBox.Name = "TMateriaComboBox"
        Me.TMateriaComboBox.Size = New System.Drawing.Size(300, 21)
        Me.TMateriaComboBox.TabIndex = 1
        Me.TMateriaComboBox.ValueMember = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SELECCIONE EL AREA DE INTERES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FORMULAS UNIVERSITARIAS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "IR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TTemaBindingSource
        '
        Me.TTemaBindingSource.DataMember = "TTema"
        Me.TTemaBindingSource.DataSource = Me.BD_ProyectoDataSet
        '
        'TTemaTableAdapter
        '
        Me.TTemaTableAdapter.ClearBeforeFill = True
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TMateriaBindingSource, "Nombre", True))
        Me.NombreLabel1.Location = New System.Drawing.Point(82, 160)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel1.TabIndex = 9
        Me.NombreLabel1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(238, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CERRAR SESION "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 249)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TMateriaComboBox)
        Me.Controls.Add(Me.TMateriaBindingNavigator)
        Me.Controls.Add(Me.NombreLabel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMateriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMateriaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TMateriaBindingNavigator.ResumeLayout(False)
        Me.TMateriaBindingNavigator.PerformLayout()
        CType(Me.TTemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_ProyectoDataSet As BD_ProyectoDataSet
    Friend WithEvents TMateriaBindingSource As BindingSource
    Friend WithEvents TMateriaTableAdapter As BD_ProyectoDataSetTableAdapters.TMateriaTableAdapter
    Friend WithEvents TableAdapterManager As BD_ProyectoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TMateriaBindingNavigator As BindingNavigator
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
    Friend WithEvents TMateriaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TMateriaComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TTemaBindingSource As BindingSource
    Friend WithEvents TTemaTableAdapter As BD_ProyectoDataSetTableAdapters.TTemaTableAdapter
    Friend WithEvents NombreLabel1 As Label
    Friend WithEvents Button2 As Button
End Class
