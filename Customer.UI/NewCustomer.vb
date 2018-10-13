Imports Customer.DAL

Public Class NewCustomer



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim vFirstName As String = txtFirstName.Text.Trim()

            Dim vLastName As String = txtLastName.Text.Trim()
            Dim dao As CustomerDao = New CustomerDao


            Dim i As Integer = 0
            Dim j As Integer = 25

            j = j / i

            If Not String.IsNullOrWhiteSpace(vFirstName) And Not String.IsNullOrWhiteSpace(vLastName) Then
                Dim id As Integer = dao.SaveNames(vFirstName, vLastName)
                MessageBox.Show(String.Format("Names inserted with id {0} ", id))
            Else
                MessageBox.Show("Please enter firstname and last name")
            End If





            DataGridView1.DataSource = dao.GetCustomers()

        Catch ex As Exception

            MessageBox.Show("Sorry, unable to prcess your request. Pleasse cont tech support")

            ' ex.Message
        Finally



        End Try










    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartmentsComboBox()
        LoadResidenceCheckBoxList()
        LoadAssociationsListBox()
    End Sub

    Private Sub LoadAssociationsListBox()
        lstBoxAssociatedWith.DataSource = New HelperDao().GetAllAssociations()
        lstBoxAssociatedWith.DisplayMember = "Name"
        lstBoxAssociatedWith.ValueMember = "ID"

    End Sub

    Private Sub LoadResidenceCheckBoxList()
        chkListResidence.DataSource = New HelperDao().GetAllResidenceTypes()
        chkListResidence.DisplayMember = "Name"
        chkListResidence.ValueMember = "ID"

    End Sub

    Private Sub LoadDepartmentsComboBox()
        cmbDepartments.DataSource = New HelperDao().GetAllDepartments()
        cmbDepartments.DisplayMember = "Name"
        cmbDepartments.ValueMember = "ID"
    End Sub
End Class
