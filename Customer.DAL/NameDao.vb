Imports System.Configuration
Imports System.Data.SqlClient

Public Class NameDao

    Private connectionString As String = ConfigurationManager.ConnectionStrings("con").ConnectionString


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

    Public Function GetAllDepartments() As List(Of Department)


        Dim connection As SqlConnection = New SqlConnection(connectionString)
        connection.Open()

        Dim command As SqlCommand = New SqlCommand()
        command.Connection = connection
        command.CommandText = "SELECT Id, Name From Department "
        command.CommandType = CommandType.Text

        Dim sqlReader As SqlDataReader = command.ExecuteReader()
        Dim deptList As List(Of Department) = New List(Of Department)


        While sqlReader.Read()

            'Dim dp As Department = New Department
            'dp.ID = sqlReader.GetInt32(0)
            'dp.Name = sqlReader.GetString(1)
            'deptList.Add(dp)

            Dim dp As Department = New Department With {
                .ID = sqlReader.GetInt32(0),
                .Name = sqlReader.GetString(1)
            }
            deptList.Add(dp)

        End While

        Return deptList

    End Function

End Class
