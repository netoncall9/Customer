Public Class Customer

    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property


    Private _departmentId As Integer
    Public Property DepartId() As Integer
        Get
            Return _departmentId
        End Get
        Set(ByVal value As Integer)
            _departmentId = value
        End Set
    End Property


    Private _isEmployee As Boolean
    Public Property IsEmployee() As Boolean
        Get
            Return _isEmployee
        End Get
        Set(ByVal value As Boolean)
            _isEmployee = value
        End Set
    End Property

    Private _ownsCar As Boolean
    Public Property OwnsCar() As Boolean
        Get
            Return _ownsCar
        End Get
        Set(ByVal value As Boolean)
            _ownsCar = value
        End Set
    End Property

    Private _residenceType As String
    Public Property ResidenceType() As String
        Get
            Return _residenceType
        End Get
        Set(ByVal value As String)
            _residenceType = value
        End Set
    End Property


    Private _gender As String
    Public Property Gender() As String
        Get
            Return _gender
        End Get
        Set(ByVal value As String)
            _gender = value
        End Set
    End Property


    Private _associations As List(Of String)
    Public Property Associations() As List(Of String)
        Get
            Return _associations
        End Get
        Set(ByVal value As List(Of String))
            _associations = value
        End Set
    End Property


End Class
