Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Public Class From1
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub From1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'Your_DatabaseDataSet.Table1'. È possibile spostarla o rimuoverla se necessario.
        Me.Table1TableAdapter.Fill(Me.Your_DatabaseDataSet.Table1)
        'TODO: questa riga di codice carica i dati nella tabella 'Your_DatabaseDataSet1.Table1'. È possibile spostarla o rimuoverla se necessario.
        Me.Table1TableAdapter.Fill(Me.Your_DatabaseDataSet.Table1)
        'TODO: questa riga di codice carica i dati nella tabella 'Your_DatabaseDataSet1.Table1'. È possibile spostarla o rimuoverla se necessario.
        Me.Table1TableAdapter.Fill(Me.Your_DatabaseDataSet.Table1)
        'TODO: questa riga di codice carica i dati nella tabella 'Your_DatabaseDataSet.Table1'. È possibile spostarla o rimuoverla se necessario.
        Me.Table1TableAdapter.Fill(Me.Your_DatabaseDataSet.Table1)

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

        Dim colors() As String = [Enum].GetNames(GetType(KnownColor))

        ' cboDfColor.Items.AddRange(colors)
        ' cboAltColor.Items.AddRange(colors)

        '  Me.reset()
        Me.dgvFill()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Your_DatabaseDataSet.Table1)
        MessageBox.Show("Salvato con successo.")
SaveErr:
        Exit Sub

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Sei sicuro vuoi eliminare?", "Delete Record", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
                       Windows.Forms.DialogResult.Yes Then

            Table1BindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim msg As String = "Vuoi Uscire?"
        Dim title As String = "Chiudi Applicazione"

        If MessageBox.Show(msg, title, MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
                       Windows.Forms.DialogResult.Yes Then
            Me.Close() 'End
        End If

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error GoTo SearchErr
        If txtSearch.Text = "" Then

            Exit Sub

        Else

            Dim cantFind As String = txtSearch.Text

            Table1BindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (Nome LIKE '" & txtSearch.Text & "') OR (Cognome LIKE '" & txtSearch.Text & "')" &
                "OR (Telefono LIKE '" & txtSearch.Text & "') OR (Email LIKE '" & txtSearch.Text & "')" &
                "OR (Targa LIKE '" & txtSearch.Text & "') OR (Targa LIKE '" & txtSearch.Text & "')" &
                "OR (Modello LIKE '" & txtSearch.Text & "') OR (Assicurazione LIKE '" & txtSearch.Text & "')"

            If Table1BindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = Table1BindingSource
                End With

            Else



                MsgBox("--> " & cantFind & vbNewLine &
                       "Elemento non Trovato.",
                       MsgBoxStyle.Information, "Attenzione!")

                Table1BindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = Table1BindingSource
                End With

            End If

        End If

ErrExit:
        Exit Sub
SearchErr:
        MsgBox("Error Number " & Err.Number & vbNewLine &
               "Error Description " & Err.Description, MsgBoxStyle.Critical,
               "Reset Error!")
        Resume ErrExit

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Sviluppato da Giovanni M. Russo & Gennaro Sigillo")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Table1BindingSource.Filter = Nothing
    End Sub



    Private Sub NuovoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        On Error GoTo SearchErr
        If TextBox10.Text = "" Then

            Exit Sub

        Else

            Dim cantFind As String = TextBox10.Text



            Table1BindingSource1.Filter = "(Convert(ID, 'System.String') LIKE '" & TextBox10.Text & "')" &
                "OR (Nome LIKE '" & TextBox10.Text & "') OR (Cognome LIKE '" & TextBox10.Text & "')" &
                "OR (Telefono LIKE '" & TextBox10.Text & "')"


            If Table1BindingSource1.Count <> 0 Then
                With DataGridView2
                    .DataSource = Table1BindingSource1
                End With

            Else



                MsgBox("--> " & cantFind & vbNewLine &
                       "Elemento non Trovato.",
                       MsgBoxStyle.Information, "Attenzione!")

                Table1BindingSource1.Filter = Nothing

                With DataGridView2
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = Table1BindingSource1
                End With

            End If

        End If

ErrExit:
        Exit Sub
SearchErr:
        MsgBox("Error Number " & Err.Number & vbNewLine &
               "Error Description " & Err.Description, MsgBoxStyle.Critical,
               "Reset Error!")
        Resume ErrExit

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Table1BindingSource1.Filter = Nothing

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim apikey = "your api key"
        Dim uTime As Integer

        uTime = (DateTimePicker3.Value - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim message = txtsms.Text & DataGridView1.CurrentCell.Value.ToString
        Dim numbers = txtT.Text
        Dim schedule = uTime.ToString
        Dim strGet As String
        Dim senderName = txtN.Text
        Dim url As String = "https://api.txtlocal.com/send/?"

        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + senderName _
        + "&schedule_time=" + schedule

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        MessageBox.Show(result, "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Console.WriteLine(result)
        'Return result
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub olo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtAuto_Click(sender As Object, e As EventArgs) Handles txtAuto.Click
        Dim uTime As Integer
        Dim Ndate As Date
        Ndate = DateAdd("m", -1, DateTimePicker1.Value)
        uTime = (Ndate - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim apikey = "your api key"
        'MessageBox.Show(uTime)
        Dim message = txtsms.Text & TextBox6.Text
        Dim numbers = TextBox3.Text
        Dim schedule = uTime.ToString
        Dim strGet As String
        Dim senderName = txtN.Text
        Dim url As String = "https://api.txtlocal.com/send/?"

        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + senderName _
        + "&schedule_time=" + schedule

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        MessageBox.Show(result, "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Console.WriteLine(result)
        'Return result
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub





    Private Sub dgvFill()
        txtSearch.BackColor = Color.LightBlue

        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If

        DataGridView2.RowsDefaultCellStyle.BackColor = Color.MistyRose
        DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.Gold

        Dim myDGV1 As DataGridView = DataGridView1
        With myDGV1
            .RowsDefaultCellStyle.BackColor = Color.MistyRose
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gold
        End With
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        Dim uTime As Integer
        Dim Ndate As Date
        Ndate = DateAdd("m", -1, DateTimePicker1.Value)
        uTime = (Ndate - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim apikey = ""
        MessageBox.Show(uTime)
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Dim apikey = "your api key"
        Dim uTime As Integer

        uTime = (DateTimePicker3.Value - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim message = txtsms.Text & DataGridView1.CurrentCell.Value.ToString
        Dim numbers = txtT.Text

        Dim strGet As String
        Dim senderName = txtN.Text
        Dim url As String = "https://api.txtlocal.com/send/?"

        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + senderName

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        MessageBox.Show(result, "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Console.WriteLine(result)
        'Return result
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub


End Class
