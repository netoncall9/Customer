Imports Customer.DAL

Public Class Form1



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        Dim vFirstName As String = txtFirstName.Text.Trim()

        Dim vLastName As String = txtLastName.Text.Trim()




        If Not String.IsNullOrWhiteSpace(vFirstName) And Not String.IsNullOrWhiteSpace(vLastName) Then

            Dim dao As NameDao = New NameDao
            Dim id As Integer = dao.SaveNames(vFirstName, vLastName)
            MessageBox.Show(String.Format("Names inserted with id {0} ", id))

        Else

            MessageBox.Show("Please enter firstname and last name")
            'txtFirstName.F

        End If


        DataGridView1.DataSource = CustomerDao.GetCustomers()




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbDepartments.DataSource = New NameDao().GetAllDepartments()
        cmbDepartments.DisplayMember = "Name"
        cmbDepartments.ValueMember = "ID"



    End Sub



End Class
