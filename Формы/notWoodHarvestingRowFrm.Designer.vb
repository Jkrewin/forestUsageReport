<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class notWoodHarvestingRowFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notWoodHarvestingRowFrm))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.usageType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.tract = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.subforestry = New System.Windows.Forms.ComboBox()
        Me.forestry = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.taxationUnit = New System.Windows.Forms.TextBox()
        Me.quarter = New System.Windows.Forms.TextBox()
        Me.area = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.resourceType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.unitType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.volume = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volume, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel6.Size = New System.Drawing.Size(1118, 39)
        Me.Panel6.TabIndex = 58
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
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.OldLace
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label41.Location = New System.Drawing.Point(409, 56)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 24)
        Me.Label41.TabIndex = 108
        Me.Label41.Text = "1"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FloralWhite
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label42.Location = New System.Drawing.Point(12, 56)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(399, 24)
        Me.Label42.TabIndex = 109
        Me.Label42.Text = "Вид использования лесов"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usageType
        '
        Me.usageType.AccessibleName = ""
        Me.usageType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.usageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usageType.FormattingEnabled = True
        Me.usageType.Location = New System.Drawing.Point(450, 56)
        Me.usageType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usageType.Name = "usageType"
        Me.usageType.Size = New System.Drawing.Size(569, 24)
        Me.usageType.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FloralWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 24)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Наименование лесничества (лесопарка)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.OldLace
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label39.Location = New System.Drawing.Point(409, 116)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(40, 24)
        Me.Label39.TabIndex = 124
        Me.Label39.Text = "3"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FloralWhite
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label40.Location = New System.Drawing.Point(12, 116)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(399, 24)
        Me.Label40.TabIndex = 125
        Me.Label40.Text = "Наименование участкового лесничества"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tract
        '
        Me.tract.AccessibleName = ""
        Me.tract.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tract.FormattingEnabled = True
        Me.tract.Location = New System.Drawing.Point(450, 148)
        Me.tract.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tract.Name = "tract"
        Me.tract.Size = New System.Drawing.Size(569, 24)
        Me.tract.TabIndex = 112
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.OldLace
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label37.Location = New System.Drawing.Point(409, 148)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(40, 24)
        Me.Label37.TabIndex = 122
        Me.Label37.Text = "4"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FloralWhite
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 148)
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
        Me.Label29.Location = New System.Drawing.Point(409, 180)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 24)
        Me.Label29.TabIndex = 120
        Me.Label29.Text = "5"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FloralWhite
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 180)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(399, 24)
        Me.Label30.TabIndex = 121
        Me.Label30.Text = "Номер лесного квартала"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subforestry
        '
        Me.subforestry.AccessibleName = ""
        Me.subforestry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.subforestry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subforestry.FormattingEnabled = True
        Me.subforestry.Location = New System.Drawing.Point(450, 116)
        Me.subforestry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subforestry.Name = "subforestry"
        Me.subforestry.Size = New System.Drawing.Size(569, 24)
        Me.subforestry.TabIndex = 111
        '
        'forestry
        '
        Me.forestry.AccessibleName = ""
        Me.forestry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.forestry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.forestry.FormattingEnabled = True
        Me.forestry.Location = New System.Drawing.Point(450, 86)
        Me.forestry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.forestry.Name = "forestry"
        Me.forestry.Size = New System.Drawing.Size(569, 24)
        Me.forestry.TabIndex = 110
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.OldLace
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.Location = New System.Drawing.Point(409, 212)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 24)
        Me.Label24.TabIndex = 118
        Me.Label24.Text = "6"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FloralWhite
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 212)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(399, 24)
        Me.Label28.TabIndex = 119
        Me.Label28.Text = "Номер лесотаксационного выдела"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'taxationUnit
        '
        Me.taxationUnit.AccessibleName = ""
        Me.taxationUnit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.taxationUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxationUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.taxationUnit.Location = New System.Drawing.Point(450, 212)
        Me.taxationUnit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxationUnit.Name = "taxationUnit"
        Me.taxationUnit.Size = New System.Drawing.Size(61, 24)
        Me.taxationUnit.TabIndex = 114
        Me.taxationUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'quarter
        '
        Me.quarter.AccessibleName = ""
        Me.quarter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.quarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.quarter.Location = New System.Drawing.Point(450, 180)
        Me.quarter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.quarter.Name = "quarter"
        Me.quarter.Size = New System.Drawing.Size(60, 24)
        Me.quarter.TabIndex = 113
        Me.quarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'area
        '
        Me.area.BackColor = System.Drawing.Color.WhiteSmoke
        Me.area.DecimalPlaces = 2
        Me.area.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.area.Location = New System.Drawing.Point(451, 243)
        Me.area.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.area.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.area.Name = "area"
        Me.area.Size = New System.Drawing.Size(199, 24)
        Me.area.TabIndex = 128
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.OldLace
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(409, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 24)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "7"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FloralWhite
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 243)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(399, 24)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "Площадь га"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resourceType
        '
        Me.resourceType.AccessibleName = ""
        Me.resourceType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.resourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.resourceType.FormattingEnabled = True
        Me.resourceType.Location = New System.Drawing.Point(450, 274)
        Me.resourceType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.resourceType.Name = "resourceType"
        Me.resourceType.Size = New System.Drawing.Size(569, 24)
        Me.resourceType.TabIndex = 131
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.OldLace
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 24)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "8"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FloralWhite
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 24)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Вид заготавливаемых лесных ресурсов"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'unitType
        '
        Me.unitType.AccessibleName = ""
        Me.unitType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.unitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unitType.FormattingEnabled = True
        Me.unitType.Location = New System.Drawing.Point(450, 306)
        Me.unitType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.unitType.Name = "unitType"
        Me.unitType.Size = New System.Drawing.Size(200, 24)
        Me.unitType.TabIndex = 134
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.OldLace
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(409, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "9"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FloralWhite
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(399, 24)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Единица измерения"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'volume
        '
        Me.volume.BackColor = System.Drawing.Color.WhiteSmoke
        Me.volume.DecimalPlaces = 2
        Me.volume.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.volume.Location = New System.Drawing.Point(451, 337)
        Me.volume.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.volume.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(199, 24)
        Me.volume.TabIndex = 137
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.OldLace
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(409, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 24)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FloralWhite
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(399, 24)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Объем использования лесов"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'notWoodHarvestingRowFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1118, 688)
        Me.Controls.Add(Me.volume)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.unitType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.resourceType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.area)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.usageType)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "notWoodHarvestingRowFrm"
        Me.Text = "Использование лесов в целях, не связанных с заготовкой древесины"
        Me.Panel6.ResumeLayout(False)
        CType(Me.area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents usageType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents tract As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents subforestry As ComboBox
    Friend WithEvents forestry As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents taxationUnit As TextBox
    Friend WithEvents quarter As TextBox
    Friend WithEvents area As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents resourceType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents unitType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents volume As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
