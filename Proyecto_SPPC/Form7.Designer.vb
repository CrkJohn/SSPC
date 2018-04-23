<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TFormulaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TFormulaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TFormulaComboBox = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
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
        CType(Me.TFormulaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFormulaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MateriaLabel
        '
        MateriaLabel.AutoSize = True
        MateriaLabel.Location = New System.Drawing.Point(30, 109)
        MateriaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MateriaLabel.Name = "MateriaLabel"
        MateriaLabel.Size = New System.Drawing.Size(59, 17)
        MateriaLabel.TabIndex = 3
        MateriaLabel.Text = "Materia:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.Location = New System.Drawing.Point(30, 141)
        TemaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(48, 17)
        TemaLabel.TabIndex = 5
        TemaLabel.Text = "Tema:"
        '
        'SubtemaLabel
        '
        SubtemaLabel.AutoSize = True
        SubtemaLabel.Location = New System.Drawing.Point(30, 173)
        SubtemaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubtemaLabel.Name = "SubtemaLabel"
        SubtemaLabel.Size = New System.Drawing.Size(68, 17)
        SubtemaLabel.TabIndex = 7
        SubtemaLabel.Text = "Subtema:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(30, 205)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 9
        NombreLabel.Text = "Nombre:"
        '
        'EjemploLabel
        '
        EjemploLabel.AutoSize = True
        EjemploLabel.Location = New System.Drawing.Point(30, 237)
        EjemploLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EjemploLabel.Name = "EjemploLabel"
        EjemploLabel.Size = New System.Drawing.Size(62, 17)
        EjemploLabel.TabIndex = 11
        EjemploLabel.Text = "Ejemplo:"
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.Location = New System.Drawing.Point(30, 269)
        DescripciónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(86, 17)
        DescripciónLabel.TabIndex = 13
        DescripciónLabel.Text = "Descripción:"
        '
        'ImportanciaLabel
        '
        ImportanciaLabel.AutoSize = True
        ImportanciaLabel.Location = New System.Drawing.Point(31, 319)
        ImportanciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ImportanciaLabel.Name = "ImportanciaLabel"
        ImportanciaLabel.Size = New System.Drawing.Size(85, 17)
        ImportanciaLabel.TabIndex = 24
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
        Me.TFormulaBindingNavigator.Size = New System.Drawing.Size(1164, 27)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 53)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "AGREGAR NUEVA FORMULA "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Llene todos los datos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "FORMULAS UNIVERSITARIAS "
        '
        'TFormulaDataGridView
        '
        Me.TFormulaDataGridView.AutoGenerateColumns = False
        Me.TFormulaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TFormulaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TFormulaDataGridView.DataSource = Me.TFormulaBindingSource
        Me.TFormulaDataGridView.Location = New System.Drawing.Point(398, 109)
        Me.TFormulaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TFormulaDataGridView.Name = "TFormulaDataGridView"
        Me.TFormulaDataGridView.Size = New System.Drawing.Size(744, 260)
        Me.TFormulaDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Materia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Materia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tema"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tema"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Subtema"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subtema"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ejemplo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ejemplo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Descripción"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Importancia"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importancia"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 141)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 173)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 21
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(127, 210)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 22
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(127, 242)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 22)
        Me.TextBox4.TabIndex = 23
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(127, 274)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 24
        '
        'TFormulaBindingSource1
        '
        Me.TFormulaBindingSource1.DataMember = "TFormula"
        Me.TFormulaBindingSource1.DataSource = Me.BD_ProyectoDataSet
        '
        'TFormulaComboBox
        '
        Me.TFormulaComboBox.DataSource = Me.TFormulaBindingSource1
        Me.TFormulaComboBox.DisplayMember = "Materia"
        Me.TFormulaComboBox.FormattingEnabled = True
        Me.TFormulaComboBox.Location = New System.Drawing.Point(96, 109)
        Me.TFormulaComboBox.Name = "TFormulaComboBox"
        Me.TFormulaComboBox.Size = New System.Drawing.Size(275, 24)
        Me.TFormulaComboBox.TabIndex = 25
        Me.TFormulaComboBox.ValueMember = "Id"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(139, 317)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 39)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "MENÚ PRINCIPAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 449)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TFormulaComboBox)
        Me.Controls.Add(ImportanciaLabel)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TFormulaDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MateriaLabel)
        Me.Controls.Add(TemaLabel)
        Me.Controls.Add(SubtemaLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(EjemploLabel)
        Me.Controls.Add(DescripciónLabel)
        Me.Controls.Add(Me.TFormulaBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.BD_ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TFormulaBindingNavigator.ResumeLayout(False)
        Me.TFormulaBindingNavigator.PerformLayout()
        CType(Me.TFormulaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFormulaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TFormulaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TFormulaBindingSource1 As BindingSource
    Friend WithEvents TFormulaComboBox As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button2 As Button
End Class
