
Imports Npgsql

Public Module DatabaseConnection

    '========================================
    ' POSTGRESQL CONNECTION STRING
    '========================================

    Private ReadOnly connectionString As String =
        "Host=localhost;" &
        "Port=5432;" &
        "Database=PlasticashDB;" &
        "Username=postgres;" &
        "Password=Senju Hashirama;" &
        "Pooling=true;"

    '========================================
    ' GET DATABASE CONNECTION
    '========================================

    Public Function GetConnection() As NpgsqlConnection

        Return New NpgsqlConnection(connectionString)

    End Function

    '========================================
    ' TEST DATABASE CONNECTION
    '========================================

    Public Function TestConnection() As Boolean

        Try

            Using conn As NpgsqlConnection = GetConnection()

                conn.Open()

                Return conn.State = ConnectionState.Open

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Database connection failed!" &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Plasticash Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return False

        End Try

    End Function

End Module
