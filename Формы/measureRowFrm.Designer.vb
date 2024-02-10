<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class measureRowFrm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(measureRowFrm))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.objectCB = New System.Windows.Forms.ComboBox()
        Me.measure = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tract = New System.Windows.Forms.ComboBox()
        Me.subforestry = New System.Windows.Forms.ComboBox()
        Me.forestry = New System.Windows.Forms.ComboBox()
        Me.taxationUnit = New System.Windows.Forms.TextBox()
        Me.quarter = New System.Windows.Forms.TextBox()
        Me.cuttingArea = New System.Windows.Forms.TextBox()
        Me.area = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.farm = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.sortiment = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.wood = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.formCutting = New System.Windows.Forms.ComboBox()
        Me.typeCutting = New System.Windows.Forms.ComboBox()
        Me.value_n = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.commercialValue = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tree = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        CType(Me.area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.value_n, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.commercialValue, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel6.TabIndex = 59
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
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.OldLace
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(409, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 24)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FloralWhite
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(399, 24)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Наименование мероприятия"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.OldLace
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label39.Location = New System.Drawing.Point(409, 98)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(39, 24)
        Me.Label39.TabIndex = 106
        Me.Label39.Text = "2"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FloralWhite
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label40.Location = New System.Drawing.Point(12, 98)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(399, 24)
        Me.Label40.TabIndex = 107
        Me.Label40.Text = "Вид объекта"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'objectCB
        '
        Me.objectCB.AccessibleName = ""
        Me.objectCB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.objectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.objectCB.FormattingEnabled = True
        Me.objectCB.Location = New System.Drawing.Point(451, 98)
        Me.objectCB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.objectCB.Name = "objectCB"
        Me.objectCB.Size = New System.Drawing.Size(569, 24)
        Me.objectCB.TabIndex = 105
        '
        'measure
        '
        Me.measure.AccessibleName = "measure"
        Me.measure.BackColor = System.Drawing.Color.WhiteSmoke
        Me.measure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.measure.FormattingEnabled = True
        Me.measure.Location = New System.Drawing.Point(451, 69)
        Me.measure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.measure.Name = "measure"
        Me.measure.Size = New System.Drawing.Size(569, 24)
        Me.measure.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 24)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "3"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FloralWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 24)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Наименование лесничества (лесопарка)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.OldLace
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(409, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 24)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "4"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FloralWhite
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(399, 24)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Наименование участкового лесничества"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.OldLace
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label37.Location = New System.Drawing.Point(409, 191)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(39, 24)
        Me.Label37.TabIndex = 122
        Me.Label37.Text = "5"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FloralWhite
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 191)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(399, 24)
        Me.Label38.TabIndex = 123
        Me.Label38.Text = "Наименование урочища (при наличии)"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.OldLace
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label29.Location = New System.Drawing.Point(409, 223)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(39, 24)
        Me.Label29.TabIndex = 120
        Me.Label29.Text = "6"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FloralWhite
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 223)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(399, 24)
        Me.Label30.TabIndex = 121
        Me.Label30.Text = "Номер лесного квартала"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.OldLace
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.Location = New System.Drawing.Point(409, 255)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 24)
        Me.Label24.TabIndex = 118
        Me.Label24.Text = "7"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FloralWhite
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 255)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(399, 24)
        Me.Label28.TabIndex = 119
        Me.Label28.Text = "Номер лесотаксационного выдела"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.OldLace
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.Location = New System.Drawing.Point(409, 287)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 24)
        Me.Label22.TabIndex = 116
        Me.Label22.Text = "8"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FloralWhite
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 287)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(399, 24)
        Me.Label23.TabIndex = 117
        Me.Label23.Text = "Номер лесосеки"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tract
        '
        Me.tract.AccessibleName = ""
        Me.tract.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tract.FormattingEnabled = True
        Me.tract.Location = New System.Drawing.Point(451, 191)
        Me.tract.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tract.Name = "tract"
        Me.tract.Size = New System.Drawing.Size(569, 24)
        Me.tract.TabIndex = 130
        '
        'subforestry
        '
        Me.subforestry.AccessibleName = ""
        Me.subforestry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.subforestry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subforestry.FormattingEnabled = True
        Me.subforestry.Location = New System.Drawing.Point(451, 159)
        Me.subforestry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subforestry.Name = "subforestry"
        Me.subforestry.Size = New System.Drawing.Size(569, 24)
        Me.subforestry.TabIndex = 129
        '
        'forestry
        '
        Me.forestry.AccessibleName = ""
        Me.forestry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.forestry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.forestry.FormattingEnabled = True
        Me.forestry.Location = New System.Drawing.Point(451, 129)
        Me.forestry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.forestry.Name = "forestry"
        Me.forestry.Size = New System.Drawing.Size(569, 24)
        Me.forestry.TabIndex = 128
        '
        'taxationUnit
        '
        Me.taxationUnit.AccessibleName = ""
        Me.taxationUnit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.taxationUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxationUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.taxationUnit.Location = New System.Drawing.Point(451, 255)
        Me.taxationUnit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxationUnit.MaxLength = 4
        Me.taxationUnit.Name = "taxationUnit"
        Me.taxationUnit.Size = New System.Drawing.Size(61, 24)
        Me.taxationUnit.TabIndex = 132
        Me.taxationUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'quarter
        '
        Me.quarter.AccessibleName = ""
        Me.quarter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.quarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.quarter.Location = New System.Drawing.Point(451, 223)
        Me.quarter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.quarter.MaxLength = 4
        Me.quarter.Name = "quarter"
        Me.quarter.Size = New System.Drawing.Size(61, 24)
        Me.quarter.TabIndex = 131
        Me.quarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cuttingArea
        '
        Me.cuttingArea.AccessibleName = ""
        Me.cuttingArea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cuttingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cuttingArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cuttingArea.Location = New System.Drawing.Point(451, 287)
        Me.cuttingArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cuttingArea.MaxLength = 4
        Me.cuttingArea.Name = "cuttingArea"
        Me.cuttingArea.Size = New System.Drawing.Size(61, 24)
        Me.cuttingArea.TabIndex = 133
        Me.cuttingArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'area
        '
        Me.area.BackColor = System.Drawing.Color.WhiteSmoke
        Me.area.DecimalPlaces = 6
        Me.area.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.area.Location = New System.Drawing.Point(451, 318)
        Me.area.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.area.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.area.Name = "area"
        Me.area.Size = New System.Drawing.Size(199, 24)
        Me.area.TabIndex = 134
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.OldLace
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(409, 318)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 24)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "9"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FloralWhite
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 318)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(399, 24)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "Площадь лесосеки, га"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'farm
        '
        Me.farm.AccessibleName = ""
        Me.farm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.farm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.farm.FormattingEnabled = True
        Me.farm.Items.AddRange(New Object() {"Мягколиственное", "Твердолиственное", "Хвойное"})
        Me.farm.Location = New System.Drawing.Point(451, 350)
        Me.farm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.farm.Name = "farm"
        Me.farm.Size = New System.Drawing.Size(568, 24)
        Me.farm.TabIndex = 135
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.OldLace
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(409, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 24)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "10"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FloralWhite
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 350)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(399, 24)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "Хозяйство"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.OldLace
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(409, 478)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 24)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "14"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sortiment
        '
        Me.sortiment.AccessibleName = ""
        Me.sortiment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sortiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sortiment.FormattingEnabled = True
        Me.sortiment.Location = New System.Drawing.Point(451, 510)
        Me.sortiment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sortiment.Name = "sortiment"
        Me.sortiment.Size = New System.Drawing.Size(568, 24)
        Me.sortiment.TabIndex = 143
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FloralWhite
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 508)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(399, 24)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "сортиментный"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.OldLace
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(409, 382)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 24)
        Me.Label17.TabIndex = 148
        Me.Label17.Text = "11"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FloralWhite
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 382)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(399, 24)
        Me.Label18.TabIndex = 149
        Me.Label18.Text = "Форма рубки"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.OldLace
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.Location = New System.Drawing.Point(409, 446)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 24)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "13"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wood
        '
        Me.wood.AccessibleName = ""
        Me.wood.BackColor = System.Drawing.Color.WhiteSmoke
        Me.wood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.wood.FormattingEnabled = True
        Me.wood.Location = New System.Drawing.Point(451, 479)
        Me.wood.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.wood.Name = "wood"
        Me.wood.Size = New System.Drawing.Size(568, 24)
        Me.wood.TabIndex = 142
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FloralWhite
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 478)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(399, 24)
        Me.Label20.TabIndex = 147
        Me.Label20.Text = "видовой (породный)"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.OldLace
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.Location = New System.Drawing.Point(409, 414)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 24)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "12"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FloralWhite
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 446)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(399, 24)
        Me.Label25.TabIndex = 145
        Me.Label25.Text = "вид рубки"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formCutting
        '
        Me.formCutting.AccessibleDescription = "formCutting"
        Me.formCutting.AccessibleName = ""
        Me.formCutting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.formCutting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.formCutting.FormattingEnabled = True
        Me.formCutting.Items.AddRange(New Object() {"Сплошная рубка", "Выборочная рубка"})
        Me.formCutting.Location = New System.Drawing.Point(451, 382)
        Me.formCutting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.formCutting.Name = "formCutting"
        Me.formCutting.Size = New System.Drawing.Size(568, 24)
        Me.formCutting.TabIndex = 140
        '
        'typeCutting
        '
        Me.typeCutting.AccessibleName = ""
        Me.typeCutting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.typeCutting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeCutting.FormattingEnabled = True
        Me.typeCutting.Location = New System.Drawing.Point(451, 446)
        Me.typeCutting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.typeCutting.Name = "typeCutting"
        Me.typeCutting.Size = New System.Drawing.Size(568, 24)
        Me.typeCutting.TabIndex = 141
        '
        'value_n
        '
        Me.value_n.BackColor = System.Drawing.Color.WhiteSmoke
        Me.value_n.DecimalPlaces = 2
        Me.value_n.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.value_n.Location = New System.Drawing.Point(451, 542)
        Me.value_n.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.value_n.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.value_n.Name = "value_n"
        Me.value_n.Size = New System.Drawing.Size(199, 24)
        Me.value_n.TabIndex = 152
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.OldLace
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label26.Location = New System.Drawing.Point(409, 508)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 24)
        Me.Label26.TabIndex = 153
        Me.Label26.Text = "15"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FloralWhite
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 542)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(399, 24)
        Me.Label27.TabIndex = 154
        Me.Label27.Text = "всего"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'commercialValue
        '
        Me.commercialValue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.commercialValue.DecimalPlaces = 2
        Me.commercialValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.commercialValue.Location = New System.Drawing.Point(451, 574)
        Me.commercialValue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.commercialValue.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.commercialValue.Name = "commercialValue"
        Me.commercialValue.Size = New System.Drawing.Size(199, 24)
        Me.commercialValue.TabIndex = 155
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.OldLace
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label31.Location = New System.Drawing.Point(409, 542)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(39, 24)
        Me.Label31.TabIndex = 156
        Me.Label31.Text = "16"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FloralWhite
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label32.Location = New System.Drawing.Point(12, 574)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(399, 24)
        Me.Label32.TabIndex = 157
        Me.Label32.Text = "в том числе деловой"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.OldLace
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 574)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "17"
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
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Древесные породы"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tree
        '
        Me.tree.AccessibleName = ""
        Me.tree.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tree.FormattingEnabled = True
        Me.tree.Location = New System.Drawing.Point(451, 414)
        Me.tree.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tree.Name = "tree"
        Me.tree.Size = New System.Drawing.Size(568, 24)
        Me.tree.TabIndex = 160
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.forestUsageReport_VB.My.Resources.Resources.fsearch
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1025, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 25)
        Me.Button1.TabIndex = 161
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.forestUsageReport_VB.My.Resources.Resources.fsearch
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(1025, 479)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 25)
        Me.Button3.TabIndex = 162
        Me.Button3.UseVisualStyleBackColor = True
        '
        'measureRowFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1117, 688)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tree)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.commercialValue)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.value_n)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.sortiment)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.wood)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.formCutting)
        Me.Controls.Add(Me.typeCutting)
        Me.Controls.Add(Me.area)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.farm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tract)
        Me.Controls.Add(Me.subforestry)
        Me.Controls.Add(Me.forestry)
        Me.Controls.Add(Me.taxationUnit)
        Me.Controls.Add(Me.quarter)
        Me.Controls.Add(Me.cuttingArea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.objectCB)
        Me.Controls.Add(Me.measure)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "measureRowFrm"
        Me.Text = "Мероприятия, связанные с использованием лесов"
        Me.Panel6.ResumeLayout(False)
        CType(Me.area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.value_n, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.commercialValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents objectCB As ComboBox
    Friend WithEvents measure As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tract As ComboBox
    Friend WithEvents subforestry As ComboBox
    Friend WithEvents forestry As ComboBox
    Friend WithEvents taxationUnit As TextBox
    Friend WithEvents quarter As TextBox
    Friend WithEvents cuttingArea As TextBox
    Friend WithEvents area As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents farm As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents sortiment As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents wood As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents formCutting As ComboBox
    Friend WithEvents typeCutting As ComboBox
    Friend WithEvents value_n As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents commercialValue As NumericUpDown
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tree As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
