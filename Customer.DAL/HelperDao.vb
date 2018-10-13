Imports System.Configuration
Imports System.Data.SqlClient

Public Class HelperDao

    Private connectionString As String = ConfigurationManager.ConnectionStrings("con").ConnectionString

    Public Function GetAllAssociations() As List(Of Association)


        Dim connection As SqlConnection = New SqlConnection(connectionString)
        connection.Open()

        Dim command As SqlCommand = New SqlCommand()
        command.Connection = connection
        command.CommandText = "SELECT Id, Name From Association "
        command.CommandType = CommandType.Text

        Dim sqlReader As SqlDataReader = command.ExecuteReader()
        Dim list As List(Of Association) = New List(Of Association)


        While sqlReader.Read()

            Dim dp As Association = New Association With {
                .ID = sqlReader.GetInt32(0),
                .Name = sqlReader.GetString(1)
            }
            list.Add(dp)

        End While

        Return list

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

    Public Function GetAllResidenceTypes() As List(Of ResidenceType)


        Dim connection As SqlConnection = New SqlConnection(connectionString)
        connection.Open()

        Dim command As SqlCommand = New SqlCommand()
        command.Connection = connection
        command.CommandText = "SELECT Id, Name From ResidenceType "
        command.CommandType = CommandType.Text

        Dim sqlReader As SqlDataReader = command.ExecuteReader()
        Dim list As List(Of ResidenceType) = New List(Of ResidenceType)


        While sqlReader.Read()

            Dim dp As ResidenceType = New ResidenceType With {
                .ID = sqlReader.GetInt32(0),
                .Name = sqlReader.GetString(1)
            }
            list.Add(dp)

        End While

        Return list

    End Function

End Class

