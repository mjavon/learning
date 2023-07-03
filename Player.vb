Public Class Player
    Property ID As Long
    Property firstName As String
    Property lastName As String
    ReadOnly Property displayName As String
        Get
            Return "#" & Me.jerseyNumber & " " & Me.lastName & ", " & Me.firstName
        End Get
    End Property

    Property primaryPosition As String

    Property secondaryPosition As String

    ReadOnly Property displayPosition As String
        Get
            Return Me.primaryPosition & "/" & Me.secondaryPosition
        End Get
    End Property

    Property age As Long
    Property jerseyNumber As Long

    Property captaincy As String
    Property overallRating As Long
    Property potentialCeiling As String
    Property potentialLikelihood As String
    Property role As String
    Property contractAAV As Double
    Property contractYearsRemaining As Long

    ReadOnly Property displayContract As String
        Get
            Return "$" & Math.Round(Me.contractAAV, 3) & " / " & Me.contractYearsRemaining & " YR"
        End Get
    End Property
    Property goals As Long
    Property assists As Long
    ReadOnly Property points As Long
        Get
            Return Me.goals + Me.assists
        End Get
    End Property
    Property gamesPlayed As Long

    ReadOnly Property pointsPerGame As Double
        Get
            Return Me.points / Me.gamesPlayed
        End Get
    End Property

    Property height As Long
    Property weight As Long
    ReadOnly Property displayHeight As String ' add handling for metric system later
        Get
            Return Me.height / 12 & "' " & Me.height Mod 12 & """"
        End Get
    End Property
    ReadOnly Property displayWeight As String ' add handling for metric system later
        Get
            Return Me.weight & " lbs"
        End Get
    End Property

    Property handedness As String

End Class
