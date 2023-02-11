<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contractFrm
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
        Me.ctdate = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ctregistrationNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ctnumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ctapprovingProject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CtusageType = New System.Windows.Forms.ComboBox()
        Me.ctapprovingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cttype = New System.Windows.Forms.ComboBox()
        Me.ContractActive = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctdate
        '
        Me.ctdate.AccessibleName = "ctdate"
        Me.ctdate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.ctdate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.forestUsageReport_VB.My.MySettings.Default, "DateTimePicker3Value", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ctdate.Location = New System.Drawing.Point(315, 130)
        Me.ctdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ctdate.Name = "ctdate"
        Me.ctdate.Size = New System.Drawing.Size(171, 22)
        Me.ctdate.TabIndex = 3
        Me.ctdate.Value = Global.forestUsageReport_VB.My.MySettings.Default.DateTimePicker3Value
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(297, 23)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Номер государственной регистраци"
        '
        'ctregistrationNumber
        '
        Me.ctregistrationNumber.AccessibleName = "ctregistrationNumber"
        Me.ctregistrationNumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ctregistrationNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctregistrationNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ctregistrationNumber.Location = New System.Drawing.Point(315, 160)
        Me.ctregistrationNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ctregistrationNumber.Name = "ctregistrationNumber"
        Me.ctregistrationNumber.Size = New System.Drawing.Size(171, 22)
        Me.ctregistrationNumber.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(297, 23)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Дата договора аренды лесного участка"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(297, 23)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Номер договора аренды лесного участка или иного документа"
        '
        'ctnumber
        '
        Me.ctnumber.AccessibleName = "ctnumber"
        Me.ctnumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ctnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ctnumber.Location = New System.Drawing.Point(315, 103)
        Me.ctnumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ctnumber.Name = "ctnumber"
        Me.ctnumber.Size = New System.Drawing.Size(171, 22)
        Me.ctnumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 23)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Вид документа"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 23)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Организация, утвердившая проект освоения лесов"
        '
        'ctapprovingProject
        '
        Me.ctapprovingProject.AccessibleName = ""
        Me.ctapprovingProject.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ctapprovingProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctapprovingProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ctapprovingProject.Location = New System.Drawing.Point(315, 295)
        Me.ctapprovingProject.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ctapprovingProject.Name = "ctapprovingProject"
        Me.ctapprovingProject.Size = New System.Drawing.Size(303, 22)
        Me.ctapprovingProject.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 23)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Дата, утверждения"
        '
        'CtusageType
        '
        Me.CtusageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtusageType.FormattingEnabled = True
        Me.CtusageType.Location = New System.Drawing.Point(315, 267)
        Me.CtusageType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtusageType.Name = "CtusageType"
        Me.CtusageType.Size = New System.Drawing.Size(304, 24)
        Me.CtusageType.TabIndex = 5
        '
        'ctapprovingDate
        '
        Me.ctapprovingDate.AccessibleName = ""
        Me.ctapprovingDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.ctapprovingDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.forestUsageReport_VB.My.MySettings.Default, "DateTimePicker3Value", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ctapprovingDate.Location = New System.Drawing.Point(315, 326)
        Me.ctapprovingDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ctapprovingDate.Name = "ctapprovingDate"
        Me.ctapprovingDate.Size = New System.Drawing.Size(171, 22)
        Me.ctapprovingDate.TabIndex = 7
        Me.ctapprovingDate.Value = Global.forestUsageReport_VB.My.MySettings.Default.DateTimePicker3Value
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 23)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Вид использования лесов"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(607, 23)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Не обязательные сведения (могут использоваться другими програмами)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(656, 57)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1213, 679)
        Me.Panel1.TabIndex = 74
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1213, 642)
        Me.DataGridView1.TabIndex = 54
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1213, 37)
        Me.Panel2.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(471, 5)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(171, 28)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Выбрать договор"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(293, 5)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 28)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Удалить договор"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(136, 5)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 28)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Изменить договор"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(4, 5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 28)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Новый договор"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.Location = New System.Drawing.Point(12, 36)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(160, 26)
        Me.Button10.TabIndex = 75
        Me.Button10.Text = "Создать"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(523, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 23)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "ID"
        '
        'ID
        '
        Me.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ID.Location = New System.Drawing.Point(570, 36)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(79, 23)
        Me.ID.TabIndex = 77
        Me.ID.Text = "0"
        Me.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(177, 36)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 26)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Изменить"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(343, 36)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 26)
        Me.Button6.TabIndex = 90
        Me.Button6.Text = "Отмена"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'cttype
        '
        Me.cttype.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cttype.FormattingEnabled = True
        Me.cttype.Items.AddRange(New Object() {"Договор купли-продажи лесных насаждений", "Договор безвозмездного пользования", "Постоянное (бессрочное) пользование", "Договор аренды"})
        Me.cttype.Location = New System.Drawing.Point(315, 74)
        Me.cttype.Name = "cttype"
        Me.cttype.Size = New System.Drawing.Size(303, 24)
        Me.cttype.TabIndex = 1
        Me.cttype.Tag = "1"
        '
        'ContractActive
        '
        Me.ContractActive.AutoSize = True
        Me.ContractActive.Checked = True
        Me.ContractActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ContractActive.Location = New System.Drawing.Point(55, 361)
        Me.ContractActive.Name = "ContractActive"
        Me.ContractActive.Size = New System.Drawing.Size(344, 21)
        Me.ContractActive.TabIndex = 8
        Me.ContractActive.Text = "Это действующий договор в настоящий момент"
        Me.ContractActive.UseVisualStyleBackColor = True
        '
        'contractFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1213, 679)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CtusageType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ctapprovingProject)
        Me.Controls.Add(Me.ctapprovingDate)
        Me.Controls.Add(Me.ctdate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ctregistrationNumber)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ctnumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.cttype)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ContractActive)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "contractFrm"
        Me.Text = "Контракты"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ctdate As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents ctregistrationNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ctnumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ctapprovingProject As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CtusageType As ComboBox
    Friend WithEvents ctapprovingDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button10 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ID As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cttype As ComboBox
    Friend WithEvents ContractActive As CheckBox
End Class
