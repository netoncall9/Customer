<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAssociatedWith = New System.Windows.Forms.Label()
        Me.lstBoxAssociatedWith = New System.Windows.Forms.ListBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.lblResidence = New System.Windows.Forms.Label()
        Me.chkListResidence = New System.Windows.Forms.CheckedListBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.chkCar = New System.Windows.Forms.CheckBox()
        Me.chkEmployee = New System.Windows.Forms.CheckBox()
        Me.cmbDepartments = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.grpAddCustomer = New System.Windows.Forms.GroupBox()
        Me.grpCustomerList = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.grpAddCustomer.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAssociatedWith)
        Me.Panel1.Controls.Add(Me.lstBoxAssociatedWith)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.rbtnFemale)
        Me.Panel1.Controls.Add(Me.rbtnMale)
        Me.Panel1.Controls.Add(Me.lblResidence)
        Me.Panel1.Controls.Add(Me.chkListResidence)
        Me.Panel1.Controls.Add(Me.lblDetails)
        Me.Panel1.Controls.Add(Me.chkCar)
        Me.Panel1.Controls.Add(Me.chkEmployee)
        Me.Panel1.Controls.Add(Me.cmbDepartments)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.lblLastName)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Location = New System.Drawing.Point(6, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 241)
        Me.Panel1.TabIndex = 4
        '
        'lblAssociatedWith
        '
        Me.lblAssociatedWith.AutoSize = True
        Me.lblAssociatedWith.Location = New System.Drawing.Point(293, 14)
        Me.lblAssociatedWith.Name = "lblAssociatedWith"
        Me.lblAssociatedWith.Size = New System.Drawing.Size(84, 13)
        Me.lblAssociatedWith.TabIndex = 19
        Me.lblAssociatedWith.Text = "Associated With"
        '
        'lstBoxAssociatedWith
        '
        Me.lstBoxAssociatedWith.FormattingEnabled = True
        Me.lstBoxAssociatedWith.Location = New System.Drawing.Point(393, 11)
        Me.lstBoxAssociatedWith.Name = "lstBoxAssociatedWith"
        Me.lstBoxAssociatedWith.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstBoxAssociatedWith.Size = New System.Drawing.Size(252, 95)
        Me.lstBoxAssociatedWith.TabIndex = 18
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(12, 202)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 17
        Me.lblGender.Text = "Gender"
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Location = New System.Drawing.Point(170, 205)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbtnFemale.TabIndex = 16
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Location = New System.Drawing.Point(104, 205)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(48, 17)
        Me.rbtnMale.TabIndex = 15
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'lblResidence
        '
        Me.lblResidence.AutoSize = True
        Me.lblResidence.Location = New System.Drawing.Point(12, 140)
        Me.lblResidence.Name = "lblResidence"
        Me.lblResidence.Size = New System.Drawing.Size(58, 13)
        Me.lblResidence.TabIndex = 14
        Me.lblResidence.Text = "Residence"
        '
        'chkListResidence
        '
        Me.chkListResidence.FormattingEnabled = True
        Me.chkListResidence.Location = New System.Drawing.Point(104, 140)
        Me.chkListResidence.Name = "chkListResidence"
        Me.chkListResidence.Size = New System.Drawing.Size(161, 49)
        Me.chkListResidence.TabIndex = 13
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(12, 110)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(39, 13)
        Me.lblDetails.TabIndex = 12
        Me.lblDetails.Text = "Details"
        '
        'chkCar
        '
        Me.chkCar.AutoSize = True
        Me.chkCar.Location = New System.Drawing.Point(193, 112)
        Me.chkCar.Name = "chkCar"
        Me.chkCar.Size = New System.Drawing.Size(72, 17)
        Me.chkCar.TabIndex = 11
        Me.chkCar.Text = "Owns Car"
        Me.chkCar.UseVisualStyleBackColor = True
        '
        'chkEmployee
        '
        Me.chkEmployee.AutoSize = True
        Me.chkEmployee.Location = New System.Drawing.Point(104, 113)
        Me.chkEmployee.Name = "chkEmployee"
        Me.chkEmployee.Size = New System.Drawing.Size(83, 17)
        Me.chkEmployee.TabIndex = 10
        Me.chkEmployee.Text = "Is Employee"
        Me.chkEmployee.UseVisualStyleBackColor = True
        '
        'cmbDepartments
        '
        Me.cmbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartments.FormattingEnabled = True
        Me.cmbDepartments.Location = New System.Drawing.Point(104, 73)
        Me.cmbDepartments.Name = "cmbDepartments"
        Me.cmbDepartments.Size = New System.Drawing.Size(161, 21)
        Me.cmbDepartments.TabIndex = 9
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(12, 73)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 8
        Me.lblDepartment.Text = "Department"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(675, 205)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(104, 40)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(161, 20)
        Me.txtLastName.TabIndex = 7
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 40)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(104, 11)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(161, 20)
        Me.txtFirstName.TabIndex = 5
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 11)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name"
        '
        'grpAddCustomer
        '
        Me.grpAddCustomer.Controls.Add(Me.Panel1)
        Me.grpAddCustomer.Location = New System.Drawing.Point(12, 12)
        Me.grpAddCustomer.Name = "grpAddCustomer"
        Me.grpAddCustomer.Size = New System.Drawing.Size(778, 287)
        Me.grpAddCustomer.TabIndex = 6
        Me.grpAddCustomer.TabStop = False
        Me.grpAddCustomer.Text = "Add a Customer"
        '
        'grpCustomerList
        '
        Me.grpCustomerList.Location = New System.Drawing.Point(12, 317)
        Me.grpCustomerList.Name = "grpCustomerList"
        Me.grpCustomerList.Size = New System.Drawing.Size(778, 235)
        Me.grpCustomerList.TabIndex = 7
        Me.grpCustomerList.TabStop = False
        Me.grpCustomerList.Text = "List of Customers"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 339)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 196)
        Me.DataGridView1.TabIndex = 5
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 564)
        Me.Controls.Add(Me.grpAddCustomer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpCustomerList)
        Me.Name = "NewCustomer"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpAddCustomer.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblDepartment As Label
    Friend WithEvents cmbDepartments As ComboBox
    Friend WithEvents grpAddCustomer As GroupBox
    Friend WithEvents grpCustomerList As GroupBox
    Friend WithEvents chkEmployee As CheckBox
    Friend WithEvents chkCar As CheckBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblResidence As Label
    Friend WithEvents chkListResidence As CheckedListBox
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblAssociatedWith As Label
    Friend WithEvents lstBoxAssociatedWith As ListBox
    Friend WithEvents lblGender As Label
End Class
