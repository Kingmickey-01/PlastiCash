
Imports Npgsql
Imports NpgsqlTypes
Imports System.Data

Public Module CompanyProfileRepository

    '========================================
    ' SAVE OR UPDATE COMPANY PROFILE
    '========================================

    Public Function SaveCompanyProfile(
        userId As Integer,
        companyName As String,
        companyEmail As String,
        companyPhone As String,
        companyAddress As String,
        companyWebsite As String,
        companyDescription As String,
        companyLogo As Byte()
    ) As Boolean

        Try

            Using conn As NpgsqlConnection =
                DatabaseConnection.GetConnection()

                conn.Open()

                Dim sql As String =
                    "INSERT INTO companies " &
                    "(user_id, company_name, company_email, " &
                    "company_phone, company_address, company_website, " &
                    "company_description, company_logo, updated_at) " &
                    "VALUES (@user_id, @name, @email, @phone, " &
                    "@address, @website, @description, @logo, CURRENT_TIMESTAMP) " &
                    "ON CONFLICT (user_id) DO UPDATE SET " &
                    "company_name = EXCLUDED.company_name, " &
                    "company_email = EXCLUDED.company_email, " &
                    "company_phone = EXCLUDED.company_phone, " &
                    "company_address = EXCLUDED.company_address, " &
                    "company_website = EXCLUDED.company_website, " &
                    "company_description = EXCLUDED.company_description, " &
                    "company_logo = EXCLUDED.company_logo, " &
                    "updated_at = CURRENT_TIMESTAMP;"

                Using cmd As New NpgsqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue(
                        "user_id", userId
                    )

                    cmd.Parameters.AddWithValue(
                        "name", companyName
                    )

                    cmd.Parameters.AddWithValue(
                        "email", companyEmail
                    )

                    cmd.Parameters.AddWithValue(
                        "phone",
                        If(String.IsNullOrWhiteSpace(companyPhone),
                           CType(DBNull.Value, Object), companyPhone)
                    )

                    cmd.Parameters.AddWithValue(
                        "address",
                        If(String.IsNullOrWhiteSpace(companyAddress),
                           CType(DBNull.Value, Object), companyAddress)
                    )

                    cmd.Parameters.AddWithValue(
                        "website",
                        If(String.IsNullOrWhiteSpace(companyWebsite),
                           CType(DBNull.Value, Object), companyWebsite)
                    )

                    cmd.Parameters.AddWithValue(
                        "description",
                        If(String.IsNullOrWhiteSpace(companyDescription),
                           CType(DBNull.Value, Object), companyDescription)
                    )

                    Dim logoParameter =
                        cmd.Parameters.Add("logo", NpgsqlDbType.Bytea)

                    If companyLogo Is Nothing Then
                        logoParameter.Value = DBNull.Value
                    Else
                        logoParameter.Value = companyLogo
                    End If

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            Return True

        Catch ex As Exception

            MessageBox.Show(
                "Unable to save company profile: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return False

        End Try

    End Function

    '========================================
    ' LOAD COMPANY PROFILE
    '========================================

    Public Function LoadCompanyProfile(
        userId As Integer
    ) As DataTable

        Dim result As New DataTable()

        Try

            Using conn As NpgsqlConnection =
                DatabaseConnection.GetConnection()

                conn.Open()

                Dim sql As String =
                    "SELECT company_name, company_email, " &
                    "company_phone, company_address, " &
                    "company_website, company_description, " &
                    "company_logo " &
                    "FROM companies WHERE user_id = @user_id;"

                Using cmd As New NpgsqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue(
                        "user_id", userId
                    )

                    Using reader = cmd.ExecuteReader()

                        result.Load(reader)

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load company profile: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

        Return result

    End Function

End Module
