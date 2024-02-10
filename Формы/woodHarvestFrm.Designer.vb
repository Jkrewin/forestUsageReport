<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class woodHarvestFrm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(woodHarvestFrm))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tract = New System.Windows.Forms.ComboBox()
        Me.cuttingArea = New System.Windows.Forms.TextBox()
        Me.taxationUnit = New System.Windows.Forms.TextBox()
        Me.quarter = New System.Windows.Forms.TextBox()
        Me.subforestry = New System.Windows.Forms.ComboBox()
        Me.forestry = New System.Windows.Forms.ComboBox()
        Me.areaCutting = New System.Windows.Forms.NumericUpDown()
        Me.areaSquare = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.farm = New System.Windows.Forms.ComboBox()
        Me.wood = New System.Windows.Forms.ComboBox()
        Me.value_n = New System.Windows.Forms.NumericUpDown()
        Me.sortiment = New System.Windows.Forms.ComboBox()
        Me.typeCutting = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.formCutting = New System.Windows.Forms.ComboBox()
        Me.note = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tree = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        CType(Me.areaCutting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.areaSquare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.value_n, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.Button7)
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1117, 39)
        Me.Panel6.TabIndex = 57
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(148, 7)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(136, 27)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Изменить"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 7)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Новая строка"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tract
        '
        Me.tract.AccessibleName = ""
        Me.tract.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tract.FormattingEnabled = True
        Me.tract.Location = New System.Drawing.Point(451, 124)
        Me.tract.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tract.Name = "tract"
        Me.tract.Size = New System.Drawing.Size(569, 24)
        Me.tract.TabIndex = 3
        '
        'cuttingArea
        '
        Me.cuttingArea.AccessibleName = ""
        Me.cuttingArea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cuttingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cuttingArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cuttingArea.Location = New System.Drawing.Point(451, 220)
        Me.cuttingArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cuttingArea.Name = "cuttingArea"
        Me.cuttingArea.Size = New System.Drawing.Size(61, 24)
        Me.cuttingArea.TabIndex = 6
        Me.cuttingArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'taxationUnit
        '
        Me.taxationUnit.AccessibleName = ""
        Me.taxationUnit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.taxationUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxationUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.taxationUnit.Location = New System.Drawing.Point(451, 188)
        Me.taxationUnit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxationUnit.Name = "taxationUnit"
        Me.taxationUnit.Size = New System.Drawing.Size(61, 24)
        Me.taxationUnit.TabIndex = 5
        Me.taxationUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'quarter
        '
        Me.quarter.AccessibleName = ""
        Me.quarter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.quarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.quarter.Location = New System.Drawing.Point(451, 156)
        Me.quarter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.quarter.Name = "quarter"
        Me.quarter.Size = New System.Drawing.Size(61, 24)
        Me.quarter.TabIndex = 4
        Me.quarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subforestry
        '
        Me.subforestry.AccessibleName = ""
        Me.subforestry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.subforestry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subforestry.FormattingEnabled = True
        Me.subforestry.Location = New System.Drawing.Point(451, 92)
        Me.subforestry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subforestry.Name = "subforestry"
        Me.subforestry.Size = New System.Drawing.Size(569, 24)
        Me.subforestry.TabIndex = 2
        '
        'forestry
        '
        Me.forestry.AccessibleName = ""
        Me.forestry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.forestry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.forestry.FormattingEnabled = True
        Me.forestry.Location = New System.Drawing.Point(451, 62)
        Me.forestry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.forestry.Name = "forestry"
        Me.forestry.Size = New System.Drawing.Size(569, 24)
        Me.forestry.TabIndex = 1
        '
        'areaCutting
        '
        Me.areaCutting.AccessibleDescription = "area"
        Me.areaCutting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.areaCutting.DecimalPlaces = 6
        Me.areaCutting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.areaCutting.Location = New System.Drawing.Point(451, 316)
        Me.areaCutting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.areaCutting.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.areaCutting.Name = "areaCutting"
        Me.areaCutting.Size = New System.Drawing.Size(199, 24)
        Me.areaCutting.TabIndex = 8
        '
        'areaSquare
        '
        Me.areaSquare.AccessibleDescription = "area"
        Me.areaSquare.BackColor = System.Drawing.Color.WhiteSmoke
        Me.areaSquare.DecimalPlaces = 6
        Me.areaSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.areaSquare.Location = New System.Drawing.Point(451, 284)
        Me.areaSquare.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.areaSquare.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.areaSquare.Name = "areaSquare"
        Me.areaSquare.Size = New System.Drawing.Size(199, 24)
        Me.areaSquare.TabIndex = 7
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FloralWhite
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label36.Location = New System.Drawing.Point(12, 252)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(1007, 25)
        Me.Label36.TabIndex = 30
        Me.Label36.Text = "Площадь, га"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'farm
        '
        Me.farm.AccessibleDescription = "farm"
        Me.farm.AccessibleName = ""
        Me.farm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.farm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.farm.FormattingEnabled = True
        Me.farm.Items.AddRange(New Object() {"Мягколиственное", "Твердолиственное", "Хвойное"})
        Me.farm.Location = New System.Drawing.Point(451, 348)
        Me.farm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.farm.Name = "farm"
        Me.farm.Size = New System.Drawing.Size(568, 24)
        Me.farm.TabIndex = 9
        '
        'wood
        '
        Me.wood.AccessibleName = ""
        Me.wood.BackColor = System.Drawing.Color.WhiteSmoke
        Me.wood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.wood.FormattingEnabled = True
        Me.wood.Location = New System.Drawing.Point(451, 513)
        Me.wood.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.wood.Name = "wood"
        Me.wood.Size = New System.Drawing.Size(568, 24)
        Me.wood.TabIndex = 12
        '
        'value_n
        '
        Me.value_n.AccessibleDescription = "valueCutting"
        Me.value_n.BackColor = System.Drawing.Color.WhiteSmoke
        Me.value_n.DecimalPlaces = 2
        Me.value_n.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.value_n.Location = New System.Drawing.Point(451, 576)
        Me.value_n.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.value_n.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.value_n.Name = "value_n"
        Me.value_n.Size = New System.Drawing.Size(199, 24)
        Me.value_n.TabIndex = 14
        '
        'sortiment
        '
        Me.sortiment.AccessibleName = ""
        Me.sortiment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sortiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sortiment.FormattingEnabled = True
        Me.sortiment.Location = New System.Drawing.Point(451, 544)
        Me.sortiment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sortiment.Name = "sortiment"
        Me.sortiment.Size = New System.Drawing.Size(568, 24)
        Me.sortiment.TabIndex = 13
        '
        'typeCutting
        '
        Me.typeCutting.AccessibleName = ""
        Me.typeCutting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.typeCutting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeCutting.FormattingEnabled = True
        Me.typeCutting.Location = New System.Drawing.Point(451, 478)
        Me.typeCutting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.typeCutting.Name = "typeCutting"
        Me.typeCutting.Size = New System.Drawing.Size(568, 24)
        Me.typeCutting.TabIndex = 11
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.FloralWhite
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label53.Location = New System.Drawing.Point(12, 380)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(1007, 25)
        Me.Label53.TabIndex = 65
        Me.Label53.Text = "Заготовка древесины"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formCutting
        '
        Me.formCutting.AccessibleDescription = "formCutting"
        Me.formCutting.AccessibleName = ""
        Me.formCutting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.formCutting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.formCutting.FormattingEnabled = True
        Me.formCutting.Items.AddRange(New Object() {"Сплошная рубка", "Выборочная рубка"})
        Me.formCutting.Location = New System.Drawing.Point(451, 414)
        Me.formCutting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.formCutting.Name = "formCutting"
        Me.formCutting.Size = New System.Drawing.Size(568, 24)
        Me.formCutting.TabIndex = 10
        '
        'note
        '
        Me.note.AccessibleName = ""
        Me.note.BackColor = System.Drawing.Color.WhiteSmoke
        Me.note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.note.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.note.Location = New System.Drawing.Point(451, 608)
        Me.note.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(403, 24)
        Me.note.TabIndex = 15
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.FloralWhite
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label52.Location = New System.Drawing.Point(12, 446)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(399, 24)
        Me.Label52.TabIndex = 67
        Me.Label52.Text = "Древесные породы"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.OldLace
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label51.Location = New System.Drawing.Point(409, 446)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(39, 24)
        Me.Label51.TabIndex = 67
        Me.Label51.Text = "11"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 512)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 24)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "13"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FloralWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 512)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 24)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "видовой (породный)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.OldLace
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "10"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FloralWhite
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 24)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Форма рубки"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.OldLace
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(409, 544)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 24)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "14"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FloralWhite
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 544)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(399, 24)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "сортиментный"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FloralWhite
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 576)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(399, 24)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "объем древесины, куб. м., всего"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.OldLace
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(409, 576)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 24)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "15"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.OldLace
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(409, 608)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 24)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "16"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FloralWhite
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 608)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(399, 24)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Примечание"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.OldLace
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(409, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 24)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "9"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FloralWhite
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 348)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(399, 24)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Хозяйство"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.OldLace
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(409, 316)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 24)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "8"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FloralWhite
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(399, 24)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "рубки"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.OldLace
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(409, 284)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 24)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "7"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FloralWhite
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 284)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(399, 24)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "Лесосеки (лесотаксационного выдела)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.OldLace
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.Location = New System.Drawing.Point(409, 220)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 24)
        Me.Label22.TabIndex = 92
        Me.Label22.Text = "6"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FloralWhite
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 220)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(399, 24)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "Номер лесосеки"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.OldLace
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.Location = New System.Drawing.Point(409, 188)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 24)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "5"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FloralWhite
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 188)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(399, 24)
        Me.Label28.TabIndex = 95
        Me.Label28.Text = "Номер лесотаксационного выдела"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.OldLace
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label29.Location = New System.Drawing.Point(409, 156)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(39, 24)
        Me.Label29.TabIndex = 96
        Me.Label29.Text = "4"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FloralWhite
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 156)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(399, 24)
        Me.Label30.TabIndex = 97
        Me.Label30.Text = "Номер лесного квартала"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.OldLace
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label37.Location = New System.Drawing.Point(409, 124)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(39, 24)
        Me.Label37.TabIndex = 98
        Me.Label37.Text = "3"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FloralWhite
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 124)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(399, 24)
        Me.Label38.TabIndex = 99
        Me.Label38.Text = "Наименование урочища (при наличии)"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.OldLace
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label39.Location = New System.Drawing.Point(409, 92)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(39, 24)
        Me.Label39.TabIndex = 100
        Me.Label39.Text = "2"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FloralWhite
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label40.Location = New System.Drawing.Point(12, 92)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(399, 24)
        Me.Label40.TabIndex = 101
        Me.Label40.Text = "Наименование участкового лесничества"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.OldLace
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label41.Location = New System.Drawing.Point(409, 62)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(39, 24)
        Me.Label41.TabIndex = 102
        Me.Label41.Text = "1"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FloralWhite
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label42.Location = New System.Drawing.Point(12, 62)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(399, 24)
        Me.Label42.TabIndex = 103
        Me.Label42.Text = "Наименование лесничества (лесопарка)"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(859, 608)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(280, 51)
        Me.LinkLabel1.TabIndex = 104
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Добавить в примечание, инф. об файлах" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "прикрепленные в настоящий момент" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "к этому " &
    "документу. "
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.OldLace
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(409, 478)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 24)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "12"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FloralWhite
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 478)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(399, 24)
        Me.Label18.TabIndex = 106
        Me.Label18.Text = "вид рубки"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tree
        '
        Me.tree.AccessibleName = ""
        Me.tree.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tree.FormattingEnabled = True
        Me.tree.Location = New System.Drawing.Point(451, 446)
        Me.tree.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tree.Name = "tree"
        Me.tree.Size = New System.Drawing.Size(568, 24)
        Me.tree.TabIndex = 105
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.forestUsageReport_VB.My.Resources.Resources.fsearch
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1027, 446)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 25)
        Me.Button1.TabIndex = 108
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.forestUsageReport_VB.My.Resources.Resources.fsearch
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(1025, 513)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 25)
        Me.Button3.TabIndex = 109
        Me.Button3.UseVisualStyleBackColor = True
        '
        'woodHarvestFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1117, 688)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tree)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.tract)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.subforestry)
        Me.Controls.Add(Me.forestry)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.taxationUnit)
        Me.Controls.Add(Me.quarter)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cuttingArea)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.areaSquare)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.areaCutting)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.farm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.note)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.value_n)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sortiment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wood)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.formCutting)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.typeCutting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "woodHarvestFrm"
        Me.Text = "Использование лесов для заготовки древесины"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel6.ResumeLayout(False)
        CType(Me.areaCutting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.areaSquare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.value_n, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents tract As ComboBox
    Friend WithEvents cuttingArea As TextBox
    Friend WithEvents taxationUnit As TextBox
    Friend WithEvents quarter As TextBox
    Friend WithEvents subforestry As ComboBox
    Friend WithEvents forestry As ComboBox
    Friend WithEvents areaCutting As NumericUpDown
    Friend WithEvents areaSquare As NumericUpDown
    Friend WithEvents Label36 As Label
    Friend WithEvents farm As ComboBox
    Friend WithEvents value_n As NumericUpDown
    Friend WithEvents sortiment As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents formCutting As ComboBox
    Friend WithEvents wood As ComboBox
    Friend WithEvents typeCutting As ComboBox
    Friend WithEvents note As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tree As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
