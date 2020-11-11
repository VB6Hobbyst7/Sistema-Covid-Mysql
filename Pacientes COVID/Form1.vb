Imports MySql.Data.MySqlClient
Public Class Form1
    ' Declaracion de variables'
    Friend conexion As MySqlConnection

    Private server As String = "127.0.0.1"
    Private user As String = "root"
    Private db As String = "COVID"
    Dim data As MySqlDataAdapter = New MySqlDataAdapter()
    Dim cmd As MySqlCommand

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Create()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_view.CellContentClick


        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.dg_view.Rows(e.RowIndex)

            txt_no.Text = row.Cells("Id").Value.ToString
            txt_name.Text = row.Cells("Paciente").Value.ToString
            txt_state.Text = row.Cells("Estado").Value.ToString
            txt_status.Text = row.Cells("StatusCovid").Value.ToString
            cmb_ob.Text = row.Cells("Obesidad").Value.ToString
            cmb_dia.Text = row.Cells("Obesidad").Value.ToString
            cmb_hip.Text = row.Cells("Obesidad").Value.ToString
            cmb_ts.Text = row.Cells("Obesidad").Value.ToString
            cmb_cans.Text = row.Cells("Obesidad").Value.ToString
            cmb_fie.Text = row.Cells("Obesidad").Value.ToString
            txt_age.Text = row.Cells("Edad").Value.ToString
            txt_oe.Text = row.Cells("Otras_Enfermedades").Value.ToString

        End If

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Find()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Delete()
    End Sub

    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click

        GetAllData()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Update()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
    End Sub
    ' ################ CRUD ##################'
    '''Create Data
    Private Sub Create()

        If Len(Trim(txt_name.Text)) > 0 And
           Len(Trim(txt_state.Text)) > 0 And
           Len(Trim(txt_status.Text)) > 0 And
           Len(Trim(txt_age.Text)) > 0 And
           Len(Trim(cmb_ob.Text)) > 0 And
           Len(Trim(cmb_dia.Text)) > 0 And
           Len(Trim(cmb_hip.Text)) > 0 And
           Len(Trim(cmb_ts.Text)) > 0 And
           Len(Trim(cmb_cans.Text)) > 0 And
           Len(Trim(cmb_fie.Text)) > 0 Then

            Try
                conexion = New MySqlConnection()
                conexion.ConnectionString = "Server=" & server & ";" & "Uid=" & user & ";" & "Pwd=" & ";" & "Database=" & db & ";"
                conexion.Open()
                ''MessageBox.Show("Conectado al servidor")
            Catch ex As Exception
                MsgBox("Error de conexion", MsgBoxStyle.Critical, "Error")
                Console.WriteLine(ex)
            End Try

            Dim SQL = "
            INSERT INTO pacientescovid 
            (
                Paciente,
                Estado,
                StatusCovid,
                Obesidad,
                Diabetes,
                Hipertencion,
                TosSeca,
                Cansancio,
                Fiebre,
                Edad,
                Otras_Enfermedades
            )
            VALUES
            (
                @Paciente,
                @Estado,
                @StatusCovid,
                @Obesidad,
                @Diabetes,
                @Hipertencion,
                @TosSeca,
                @Cansancio,
                @Fiebre,
                @Edad,
                @Otras_Enfermedades
            );"

            Dim cmd = New MySqlCommand(SQL, conexion)

            cmd.Parameters.AddWithValue("@Paciente", txt_name.Text)
            cmd.Parameters.AddWithValue("@Estado", txt_state.Text)
            cmd.Parameters.AddWithValue("@StatusCovid", txt_status.Text)
            cmd.Parameters.AddWithValue("@Obesidad", cmb_ob.Text)
            cmd.Parameters.AddWithValue("@Diabetes", cmb_dia.Text)
            cmd.Parameters.AddWithValue("@Hipertencion", cmb_hip.Text)
            cmd.Parameters.AddWithValue("@TosSeca", cmb_ts.Text)
            cmd.Parameters.AddWithValue("@Cansancio", cmb_cans.Text)
            cmd.Parameters.AddWithValue("@Fiebre", cmb_fie.Text)
            cmd.Parameters.AddWithValue("@Edad", Convert.ToInt32(txt_age.Text))
            cmd.Parameters.AddWithValue("@Otras_Enfermedades", txt_oe.Text)

            Try
                cmd.ExecuteNonQuery()
                conexion.Close()
                ''Limpiar los datos
                Clear()
                GetAllData()
                MsgBox("Paciente Agregado...", MsgBoxStyle.Information, "Correcto")
            Catch ex As MySql.Data.MySqlClient.MySqlException
                Console.WriteLine(ex)
                MsgBox("Error", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Falta informacion....", MsgBoxStyle.Information, "Info")
        End If

    End Sub

    '''Update Data 
    Private Sub Update()

        If Len(Trim(txt_name.Text)) > 0 And Len(Trim(txt_state.Text)) > 0 And Len(Trim(txt_status.Text)) > 0 And Convert.ToInt32(txt_age.Text) > 0 Then

            Try
                conexion = New MySqlConnection()
                conexion.ConnectionString = "Server=" & server & ";" & "Uid=" & user & ";" & "Pwd=" & ";" & "Database=" & db & ";"
                conexion.Open()
                ''MessageBox.Show("Conectado al servidor")
            Catch ex As Exception
                MessageBox.Show("Error de conexion")
                Console.WriteLine(ex)
            End Try

            Dim SQL = "
            UPDATE 
                pacientescovid 
            SET
                Paciente = @Paciente,
                Estado = @Estado,
                StatusCovid = @StatusCovid,
                Obesidad = @Obesidad,
                Diabetes = @Diabetes,
                Hipertencion = @Hipertencion,
                TosSeca = @TosSeca,
                Cansancio = @Cansancio,
                Fiebre = @Fiebre,
                Edad = @Edad,
                Otras_Enfermedades = @Otras_Enfermedades
            WHERE 
                Id = @Id
             ;"

            Dim cmd = New MySqlCommand(SQL, conexion)

            cmd.Parameters.AddWithValue("@Id", txt_no.Text)
            cmd.Parameters.AddWithValue("@Paciente", txt_name.Text)
            cmd.Parameters.AddWithValue("@Estado", txt_state.Text)
            cmd.Parameters.AddWithValue("@StatusCovid", txt_status.Text)
            cmd.Parameters.AddWithValue("@Obesidad", cmb_ob.Text)
            cmd.Parameters.AddWithValue("@Diabetes", cmb_dia.Text)
            cmd.Parameters.AddWithValue("@Hipertencion", cmb_hip.Text)
            cmd.Parameters.AddWithValue("@TosSeca", cmb_ts.Text)
            cmd.Parameters.AddWithValue("@Cansancio", cmb_cans.Text)
            cmd.Parameters.AddWithValue("@Fiebre", cmb_fie.Text)
            cmd.Parameters.AddWithValue("@Edad", Convert.ToInt32(txt_age.Text))
            cmd.Parameters.AddWithValue("@Otras_Enfermedades", txt_oe.Text)

            Try
                cmd.ExecuteNonQuery()
                conexion.Close()
                ''Actualizar la tabla de registros
                GetAllData()
                MsgBox("Datos actualizados...", MsgBoxStyle.OkOnly, "Correcto")

            Catch ex As MySql.Data.MySqlClient.MySqlException
                Console.WriteLine(ex)
                MsgBox("Error", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Falta informacion....", MsgBoxStyle.Information, "Info")
        End If


    End Sub

    '''Delete Data
    Private Sub Delete()

        If Len(Trim(txt_no.Text)) > 0 Then
            Try
                conexion = New MySqlConnection()
                conexion.ConnectionString = "Server=" & server & ";" & "Uid=" & user & ";" & "Pwd=" & ";" & "Database=" & db & ";"
                conexion.Open()
                ''MessageBox.Show("Conectado al servidor")
            Catch ex As Exception
                MsgBox("Error de conexion", MsgBoxStyle.Critical, "Error")
                Console.WriteLine(ex)
            End Try

            Dim SQL = "
            DELETE FROM pacientescovid WHERE Id = @Id;"

            Dim cmd = New MySqlCommand(SQL, conexion)

            cmd.Parameters.AddWithValue("@Id", txt_no.Text)

            Try

                cmd.ExecuteNonQuery()
                conexion.Close()
                ''Actualizar la tabla de registros
                GetAllData()
                ''Limpiar los datos
                Clear()
                MsgBox("Paciente Eliminado", MsgBoxStyle.OkOnly, "Correcto")
                conexion.Close()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                Console.WriteLine(ex)
                MsgBox("Error", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    ' Get All data
    Private Sub GetAllData()
        dg_view.DataSource = Nothing
        dg_view.Columns.Clear()
        dg_view.Refresh()

        Try
            conexion = New MySqlConnection()
            conexion.ConnectionString = "Server=" & server & ";" & "Uid=" & user & ";" & "Pwd=" & ";" & "Database=" & db & ";"
            conexion.Open()
            ''MessageBox.Show("Conectado al servidor")
        Catch ex As Exception
            MsgBox("Error de conexion", MsgBoxStyle.Critical, "Error")
            Console.WriteLine(ex)
        End Try

        Dim SQL = "
            SELECT * FROM pacientescovid;"

        Dim cmd = New MySqlCommand(SQL, conexion)

        Dim datatable As DataTable = New DataTable()
        Try

            data = New MySqlDataAdapter(cmd)

            data.Fill(datatable)

            dg_view.DataSource = datatable
            conexion.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine(ex)
            MsgBox("Error", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    '''Limpiar los datos
    Private Sub Clear()

        txt_no.Clear()
        txt_name.Clear()
        txt_state.Clear()
        txt_status.Clear()
        cmb_ob.SelectedIndex = -1
        cmb_dia.SelectedIndex = -1
        cmb_hip.SelectedIndex = -1
        cmb_ts.SelectedIndex = -1
        cmb_cans.SelectedIndex = -1
        cmb_fie.SelectedIndex = -1
        txt_age.Clear()
        txt_oe.Clear()

    End Sub

    '''Buscar paciente por parametros
    Private Sub Find()
        If Len(Trim(txt_name.Text)) > 0 Or Len(Trim(txt_state.Text)) > 0 Or Len(Trim(txt_status.Text)) > 0 Or Len(Trim(txt_age.Text)) > 0 Then
            dg_view.DataSource = Nothing
            dg_view.Columns.Clear()
            dg_view.Refresh()

            Try
                conexion = New MySqlConnection()
                conexion.ConnectionString = "Server=" & server & ";" & "Uid=" & user & ";" & "Pwd=" & ";" & "Database=" & db & ";"
                conexion.Open()
                ''MessageBox.Show("Conectado al servidor")
            Catch ex As Exception
                MsgBox("Error de conexion", MsgBoxStyle.Critical, "Error")
                Console.WriteLine(ex)
            End Try

            Dim SQL = "
            SELECT 
                *
            FROM
                pacientescovid 
            WHERE
                Id LIKE @Id AND
                Paciente LIKE @Paciente AND
                Estado LIKE @Estado AND
                StatusCovid LIKE @StatusCovid AND
                Edad LIKE @Edad;"

            Dim cmd = New MySqlCommand(SQL, conexion)

            cmd.Parameters.AddWithValue("@Id", "%" + txt_no.Text + "%")
            cmd.Parameters.AddWithValue("@Paciente", "%" + txt_name.Text + "%")
            cmd.Parameters.AddWithValue("@Estado", "%" + txt_state.Text + "%")
            cmd.Parameters.AddWithValue("@StatusCovid", "%" + txt_status.Text + "%")
            cmd.Parameters.AddWithValue("@Edad", "%" + txt_age.Text + "%")

            Dim datatable As DataTable = New DataTable()
            Try

                data = New MySqlDataAdapter(cmd)

                data.Fill(datatable)
                dg_view.DataSource = datatable
                conexion.Close()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                Console.WriteLine(ex)
                MsgBox("Error", MsgBoxStyle.Critical, "Error")
            End Try

        End If

    End Sub


End Class
