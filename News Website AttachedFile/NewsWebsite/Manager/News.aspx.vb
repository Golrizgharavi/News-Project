Imports System.Data
Imports System.Data.SqlClient

Partial Class Manager_News
    Inherits System.Web.UI.Page
    Public strcon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString

    Protected Sub btmSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btmSave.Click
        Dim ObjCon As New SqlConnection(strcon)
        Dim objComm As New SqlCommand("INSERT INTO [TblNews]([Title],[Summery],[Content],[Type],[Date])values (@Title,@summery,@Content,@type,@date); select @@Identity ", ObjCon)
        objComm.Parameters.Add("@Title", SqlDbType.NVarChar, 150).Value = txtTitle.Text.Trim
        objComm.Parameters.Add("@summery", SqlDbType.NVarChar, 300).Value = txtSummery.Text.Trim
        objComm.Parameters.Add("@Content", SqlDbType.NVarChar).Value = txtContent.Text.Trim
        objComm.Parameters.Add("@Type", SqlDbType.Int).Value = ddlType.SelectedValue
        objComm.Parameters.Add("@date", SqlDbType.VarChar).Value = DateShamsi()
        objComm.CommandType = CommandType.Text
        ObjCon.Open()
        Dim NewsID As Integer = CInt(objComm.ExecuteScalar)

        If NewsID > 0 Then
            FUImage.SaveAs(Server.MapPath("/NewsImage/" & NewsID.ToString & ".jpg"))
            li_Message.Text = "ثبت با موفقیت انجام شد"
            txtContent.Text = ""
            txtSummery.Text = ""
            txtTitle.Text = ""
        Else
            li_Message.Text = "در ورود اطلاعات خطایی رخ داده"
        End If



        ObjCon.Close()


    End Sub

    Private Function DateShamsi() As String
        Dim T As Integer
        Dim S As String
        T = ValDayMiladi()
        S = ValDaySal(T - 226900)
        DateShamsi = S
    End Function
    Private Function ValDayMiladi() As Int32
        Dim x(2) As Integer
        Dim v() As Byte = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30}
        Dim i As Byte
        Dim Sum As Int32
        Sum = 0
        x(0) = Convert.ToInt16(Now.Year)
        x(1) = Convert.ToInt16(Now.Month)
        x(2) = Convert.ToInt16(Now.Day)
        If x(1) = 1 Then
            Sum = x(2)
            x(2) = 0
        Else
            For i = 0 To x(1) - 2
                Sum = Sum + v(i)
            Next
        End If
        ValDayMiladi = x(0) * 365 + x(0) \ 4 + 1 + Sum + x(2)

    End Function
    Private Function ValDaySal(ByVal Digit As Int32) As String
        Dim x, y, z As Integer
        Dim a As Int16
        Dim str As String
        x = Digit
        y = (4 * x) \ ((4 * 365) + 1)
        z = (y * 365) + (y \ 4)
        a = x - z
        str = TarikhShamsi(a)
        If a = 0 Then
            y = y - 1
        End If
        ValDaySal = y.ToString & "/" & str

    End Function
    Private Function TarikhShamsi(ByVal b As Int16) As String
        Dim v() As Integer = {31, 62, 93, 124, 155, 186, 216, 246, 276, 306, 336, 365}
        Dim Mon, Day As Integer
        Dim i As Integer
        If b = 366 Or b = 0 Then
            Mon = 12
            Day = 30
        Else
            Mon = 1
            Day = b
            For i = 10 To 0 Step -1
                If b > v(i) Then
                    If b <> v(i + 1) Then
                        Mon = i + 2
                        Day = b - v(i)
                        Exit For
                    Else
                        Mon = i + 2
                        Day = v(i + 1) - v(i)
                        Exit For
                    End If
                End If
            Next
        End If
        TarikhShamsi = Mon.ToString & "/" & Day.ToString
    End Function
End Class
