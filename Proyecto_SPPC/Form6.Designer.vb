<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim MateriaLabel As System.Windows.Forms.Label
        Dim TemaLabel As System.Windows.Forms.Label
        Dim SubtemaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim EjemploLabel As System.Windows.Forms.Label
        Dim DescripciónLabel As System.Windows.Forms.Label
        Dim ImportanciaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TFormulaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriaLabel1 = New System.Windows.Forms.Label()
        Me.TemaLabel1 = New System.Windows.Forms.Label()
        Me.SubtemaComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.EjemploLabel1 = New System.Windows.Forms.Label()
        Me.DescripciónLabel1 = New System.Windows.Forms.Label()
        Me.ImportanciaLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TFormulaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        MateriaLabel = New System.Windows.Forms.Label()
        TemaLabel = New System.Windows.Forms.Label()
        SubtemaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        EjemploLabel = New System.Windows.Forms.Label()
        DescripciónLabel = New System.Windows.Forms.Label()
        ImportanciaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TFormulaBindingNavigator.SuspendLayout()
        CType(Me.TFormulaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MateriaLabel
        '
        MateriaLabel.AutoSize = True
        MateriaLabel.Location = New System.Drawing.Point(26, 106)
        MateriaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MateriaLabel.Name = "MateriaLabel"
        MateriaLabel.Size = New System.Drawing.Size(45, 13)
        MateriaLabel.TabIndex = 23
        MateriaLabel.Text = "Materia:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.Location = New System.Drawing.Point(26, 125)
        TemaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(37, 13)
        TemaLabel.TabIndex = 25
        TemaLabel.Text = "Tema:"
        '
        'SubtemaLabel
        '
        SubtemaLabel.AutoSize = True
        SubtemaLabel.Location = New System.Drawing.Point(27, 154)
        SubtemaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SubtemaLabel.Name = "SubtemaLabel"
        SubtemaLabel.Size = New System.Drawing.Size(52, 13)
        SubtemaLabel.TabIndex = 27
        SubtemaLabel.Text = "Subtema:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(27, 178)
        NombreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 29
        NombreLabel.Text = "Nombre:"
        '
        'EjemploLabel
        '
        EjemploLabel.AutoSize = True
        EjemploLabel.Location = New System.Drawing.Point(27, 203)
        EjemploLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EjemploLabel.Name = "EjemploLabel"
        EjemploLabel.Size = New System.Drawing.Size(47, 13)
        EjemploLabel.TabIndex = 31
        EjemploLabel.Text = "Ejemplo:"
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.Location = New System.Drawing.Point(26, 226)
        DescripciónLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(66, 13)
        DescripciónLabel.TabIndex = 33
        DescripciónLabel.Text = "Descripción:"
        '
        'ImportanciaLabel
        '
        ImportanciaLabel.AutoSize = True
        ImportanciaLabel.Location = New System.Drawing.Point(27, 252)
        ImportanciaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ImportanciaLabel.Name = "ImportanciaLabel"
        ImportanciaLabel.Size = New System.Drawing.Size(65, 13)
        ImportanciaLabel.TabIndex = 35
        ImportanciaLabel.Text = "Importancia:"
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
        Me.TFormulaBindingNavigator.Size = New System.Drawing.Size(420, 27)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 46)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "VOLVER A LA PAG. ANTERIOR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(29, 294)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 32)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "AGREGAR FORMULAS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TFormulaBindingSource1
        '
        Me.TFormulaBindingSource1.DataMember = "TFormula"
        Me.TFormulaBindingSource1.DataSource = Me.BD_ProyectoDataSet
        '
        'MateriaLabel1
        '
        Me.MateriaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Materia", True))
        Me.MateriaLabel1.Location = New System.Drawing.Point(96, 106)
        Me.MateriaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MateriaLabel1.Name = "MateriaLabel1"
        Me.MateriaLabel1.Size = New System.Drawing.Size(272, 19)
        Me.MateriaLabel1.TabIndex = 24
        Me.MateriaLabel1.Text = "Label1"
        '
        'TemaLabel1
        '
        Me.TemaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Tema", True))
        Me.TemaLabel1.Location = New System.Drawing.Point(95, 125)
        Me.TemaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TemaLabel1.Name = "TemaLabel1"
        Me.TemaLabel1.Size = New System.Drawing.Size(281, 19)
        Me.TemaLabel1.TabIndex = 26
        Me.TemaLabel1.Text = "Label1"
        '
        'SubtemaComboBox
        '
        Me.SubtemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Subtema", True))
        Me.SubtemaComboBox.FormattingEnabled = True
        Me.SubtemaComboBox.Location = New System.Drawing.Point(96, 148)
        Me.SubtemaComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SubtemaComboBox.Name = "SubtemaComboBox"
        Me.SubtemaComboBox.Size = New System.Drawing.Size(207, 21)
        Me.SubtemaComboBox.TabIndex = 28
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Nombre", True))
        Me.NombreLabel1.Location = New System.Drawing.Point(96, 178)
        Me.NombreLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(170, 19)
        Me.NombreLabel1.TabIndex = 30
        Me.NombreLabel1.Text = "Label1"
        '
        'EjemploLabel1
        '
        Me.EjemploLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Ejemplo", True))
        Me.EjemploLabel1.Location = New System.Drawing.Point(96, 203)
        Me.EjemploLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EjemploLabel1.Name = "EjemploLabel1"
        Me.EjemploLabel1.Size = New System.Drawing.Size(206, 19)
        Me.EjemploLabel1.TabIndex = 32
        Me.EjemploLabel1.Text = "Label1"
        '
        'DescripciónLabel1
        '
        Me.DescripciónLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Descripción", True))
        Me.DescripciónLabel1.Location = New System.Drawing.Point(95, 226)
        Me.DescripciónLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DescripciónLabel1.Name = "DescripciónLabel1"
        Me.DescripciónLabel1.Size = New System.Drawing.Size(206, 19)
        Me.DescripciónLabel1.TabIndex = 34
        Me.DescripciónLabel1.Text = "Label1"
        '
        'ImportanciaLabel1
        '
        Me.ImportanciaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TFormulaBindingSource, "Importancia", True))
        Me.ImportanciaLabel1.Location = New System.Drawing.Point(96, 252)
        Me.ImportanciaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ImportanciaLabel1.Name = "ImportanciaLabel1"
        Me.ImportanciaLabel1.Size = New System.Drawing.Size(206, 19)
        Me.ImportanciaLabel1.TabIndex = 36
        Me.ImportanciaLabel1.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "FORMULAS UNIVERSITARIAS "
        '
        'TFormulaBindingSource2
        '
        Me.TFormulaBindingSource2.DataMember = "TFormula"
        Me.TFormulaBindingSource2.DataSource = Me.BD_ProyectoDataSet
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 391)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(MateriaLabel)
        Me.Controls.Add(Me.MateriaLabel1)
        Me.Controls.Add(TemaLabel)
        Me.Controls.Add(Me.TemaLabel1)
        Me.Controls.Add(SubtemaLabel)
        Me.Controls.Add(Me.SubtemaComboBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreLabel1)
        Me.Controls.Add(EjemploLabel)
        Me.Controls.Add(Me.EjemploLabel1)
        Me.Controls.Add(DescripciónLabel)
        Me.Controls.Add(Me.DescripciónLabel1)
        Me.Controls.Add(ImportanciaLabel)
        Me.Controls.Add(Me.ImportanciaLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TFormulaBindingNavigator)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TFormulaBindingNavigator.ResumeLayout(False)
        Me.TFormulaBindingNavigator.PerformLayout()
        CType(Me.TFormulaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TFormulaBindingSource1 As BindingSource
    Friend WithEvents MateriaLabel1 As Label
    Friend WithEvents TemaLabel1 As Label
    Friend WithEvents SubtemaComboBox As ComboBox
    Friend WithEvents NombreLabel1 As Label
    Friend WithEvents EjemploLabel1 As Label
    Friend WithEvents DescripciónLabel1 As Label
    Friend WithEvents ImportanciaLabel1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TFormulaBindingSource2 As BindingSource
End Class
