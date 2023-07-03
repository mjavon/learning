Public Class Player
    Property ID As Long
    Property firstName As String
    Property lastName As String
    Property position As String
    Property jerseyNumber As Long
    Property overallRating As Long
    Property potentialCeiling As String
    Property potentialLikelihood As String
    Property role As String
    Property contractAAV As Double
    Property contractYearsRemaining As Long
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
End Class
