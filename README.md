

<h1 align="center">
  <br>
  
  
  
            _________                                    __   
          \_   ___ \  ____   ____   ____   ____   _____/  |_ 
          /    \  \/ /  _ \ /    \ /    \_/ __ \_/ ___\   __\
          \     \___(  <_> )   |  \   |  \  ___/\  \___|  |  
           \______  /\____/|___|  /___|  /\___  >\___  >__|  
                  \/            \/     \/     \/     \/     

  
  
  
  <br>
  Connect
  <br>
</h1>

<h4 align="center">A Insurance Management Software (.NET)
.</h4>


<p align="center">
  <a href="#key-features">Key Features</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#credits">Credits</a> •
  <a href="#license">License</a>
</p>

![Cattura](https://user-images.githubusercontent.com/113531412/208209271-5216cc32-2dd4-497f-b883-9efbc49514aa.PNG)

## Key Features

* Track the status of each customer easy
  - Store easy all information about your customer with the integrated database.
* Search function
* Automatic local notice when the policy has expired
* Automatic sms notice to customer phone number when the policy has expired
  - You can manually set how long before the deadline to send a reminder sms (default is 30 days before).
  - You can manually send istant sms.
  - You can manually change the default text of the sms.
  - Sms system api by TextLocal.
* Integrated Microsoft Access Database

![Cattura2](https://user-images.githubusercontent.com/113531412/208210418-4d491a32-7eb8-42ed-82a4-0b39a4cf67be.PNG)


## How To Use

You can build the project using Visual Studio (full version), or you can use the prebuild exe in the repository. Check out the code to change TextLocal API Key

```
Private Sub txtAuto_Click(sender As Object, e As EventArgs) Handles txtAuto.Click
        Dim uTime As Integer
        Dim Ndate As Date
        Ndate = DateAdd("m", -1, DateTimePicker1.Value)
        uTime = (Ndate - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim apikey = " ------------------ your api key -------------------------"
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

```

```
Private Sub Button19_Click(sender As Object, e As EventArgs)
        Dim uTime As Integer
        Dim Ndate As Date
        Ndate = DateAdd("m", -1, DateTimePicker1.Value)
        uTime = (Ndate - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim apikey = "------------------ your api key -------------------------"
        MessageBox.Show(uTime)
    End Sub
```
```
Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Dim apikey = "------------------ your api key -------------------------"
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
```
Access Database engine is required!

You can simply host the Microsoft Access database online

> **Note**
> I will update UI/UX Design


## Credits

Russo Giovanni M.
TextLocal


## License

MIT

---

