Imports System.Configuration
Imports System.Data.SqlClient

Public Class CustomerDao


    Private connectionString As String = ConfigurationManager.ConnectionStrings("con").ConnectionString


    Public Function GetCustomers() As DataTable
        Dim connection As SqlConnection = Nothing
        Dim dt As New DataTable()

        Try

            connection = New SqlConnection(connectionString)
            connection.Open()

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

        Catch ex As Exception

            Throw ex

        Finally
            If (connection.State = ConnectionState.Open) Then
                connection.Close()
                connection.Dispose()
            End If
        End Try


        Return dt

    End Function


    Public Function SaveNames(ByVal fname As String, ByVal lname As String) As Integer


        Dim connection As SqlConnection = New SqlConnection(connectionString)
        connection.Open()

        Dim command As SqlCommand = New SqlCommand()
        command.Connection = connection
        command.CommandText = "INSERT INTO Customer VALUES(@firstname, @lastname) SELECT SCOPE_IDENTITY() "
        command.CommandType = CommandType.Text

        Dim param As SqlParameter = New SqlParameter
        param.ParameterName = "@firstname"
        param.Value = fname
        param.DbType = DbType.String

        Dim param2 As SqlParameter = New SqlParameter
        param2.ParameterName = "@lastname"
        param2.Value = lname
        param2.DbType = DbType.String


        command.Parameters.Add(param)
        command.Parameters.Add(param2)


        Dim id As Integer = CInt(command.ExecuteScalar())

        connection.Close()

        Return id

    End Function
End Class



'Array
'ArrayList
'Stack LIFO/FILO
'Queue FIFO
'Hash Table 'Key Value
'Dictionary 'Key Value

'List - List(Of Integer)

'DataTable
