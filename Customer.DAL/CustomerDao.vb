Imports System.Configuration
Imports System.Data.SqlClient

Public Module CustomerDao


    Private connectionString As String = ConfigurationManager.ConnectionStrings("con").ConnectionString


    Public Function GetCustomers() As DataTable


        Dim dt As New DataTable()

        dt.Columns.Add(New DataColumn("FistName", GetType(String)))
        dt.Columns.Add(New DataColumn("LastName", GetType(String)))

        'Dim dr As DataRow = dt.NewRow()
        'dr("FistName") = "Sam"
        'dr("LastName") = "Healey"
        'dt.Rows.Add(dr)

        'dr = dt.NewRow()
        'dr("FistName") = "Sam"
        'dr("LastName") = "Healey"
        'dt.Rows.Add(dr)


        'DataSet
        'DataTables
        'DataColumns And DataRows


        Dim connection As SqlConnection = New SqlConnection(connectionString)
        connection.Open()

        Dim command As SqlCommand = New SqlCommand()
        command.Connection = connection
        command.CommandText = "SELECT FirstName, LastName From Customer "
        command.CommandType = CommandType.Text


        'Dim adapater As SqlDataAdapter = New SqlDataAdapter(command)
        'Dim dataSet As DataSet = New DataSet
        'adapater.Fill(dataSet)
        'Return dataSet.Tables(0)

        'Dim sqlDataReader As SqlDataReader = New SqlDataReader()


        Dim sqlReader As SqlDataReader = command.ExecuteReader()

        While sqlReader.Read()

            Dim dr As DataRow = dt.NewRow()
            dr("FistName") = sqlReader.GetString(0)

            dr("LastName") = sqlReader.GetString(0)
            dt.Rows.Add(dr)


        End While


        Return dt

    End Function

End Module



'Array
'ArrayList
'Stack LIFO/FILO
'Queue FIFO
'Hash Table 'Key Value
'Dictionary 'Key Value

'List - List(Of Integer)

'DataTable
