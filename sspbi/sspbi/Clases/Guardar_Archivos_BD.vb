Imports System.Data.SqlClient

Public Class Guardar_Archivos_BD
    Public Sub insertar_archivo(id_formulario As Integer, nombre_archivo As String, file As Byte())

        Dim numr As Integer
        Dim numreg As Integer
        Dim sql As String = "insert into archivos_adjuntos (isfolder,namefield,parentid,id_formulario,contenido,lastwrite) values (0, @namefield, 0, @id_formulario, @contenido, @lastwrite);SELECT SCOPE_IDENTITY()"
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"

        If numreg = 0 Then
            Using conn As New SqlConnection(cn)
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@namefield", nombre_archivo)
                cmd.Parameters.Add("@contenido", SqlDbType.Binary, 8000).Value = file
                cmd.Parameters.AddWithValue("@id_formulario", id_formulario)
                cmd.Parameters.AddWithValue("@lastwrite", Now)

                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd.ExecuteScalar())
                    conn.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            End Using
        Else

        End If

    End Sub
End Class
