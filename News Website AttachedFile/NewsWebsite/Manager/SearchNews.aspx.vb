Imports System.Data
Imports System.Data.SqlClient

Partial Class Manager_SearchNews
    Inherits System.Web.UI.Page
    Public StrCon As String = ConfigurationManager.ConnectionStrings("StrConnection").ConnectionString


    Protected Sub DdlNews_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdlNews.SelectedIndexChanged
        Dim ObjCon As New SqlConnection(StrCon)
        Dim strQuery As String = ""
        If DdlNews.SelectedValue = 0 Then
            strQuery = "Select ID as 'شناسه',Title as 'عنوان خبر',Summery as 'خلاصه خبر',[Content] as 'محتوای خبر',Type as 'نوع خبر',Date as 'تاریخ' from TblNews"
        ElseIf DdlNews.SelectedValue = 1 Then
            strQuery = "Select ID as 'شناسه',Title as 'عنوان خبر',Summery as 'خلاصه خبر',[Content] as 'محتوای خبر',Type as 'نوع خبر',Date as 'تاریخ' from TblNews where Type = 1"
        Else
            strQuery = "Select ID as 'شناسه',Title as 'عنوان خبر',Summery as 'خلاصه خبر',[Content] as 'محتوای خبر',Type as 'نوع خبر',Date as 'تاریخ' from TblNews where Type = 2"
        End If

        Dim objComm As New SqlCommand(strQuery, ObjCon)
        objComm.CommandType = CommandType.Text
        ObjCon.Open()
        Dim Objdr As SqlDataReader = objComm.ExecuteReader
        If Objdr.HasRows Then
            GridView1.DataSource = Objdr
            GridView1.DataBind()
        End If
        Objdr.Close()
        ObjCon.Close()
    End Sub

 
    Protected Sub BtnDlt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDlt.Click

        Dim objcon As New SqlConnection(StrCon)
        Dim objcom As New SqlCommand("delete from TblNews where id=@id", objcon)
        objcom.Parameters.Add("@id", SqlDbType.Int).Value = CInt(TextBox1.Text)
        objcom.CommandType = CommandType.Text

        objcon.Open()
        IO.File.Delete(Server.MapPath("/NewsImage/" & TextBox1.Text.ToString & ".jpg"))
        Dim objadopt As New SqlDataAdapter(objcom)
        objcon.Close()
        Dim dtTable As New DataTable
        objadopt.Fill(dtTable)


        Label1.Text = "رکورد " & TextBox1.Text & " باموفقیت حذف شد."
        TextBox1.Text = " "
    End Sub


    Protected Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Dim objcon As New SqlConnection(strcon)
        Dim objcom As New SqlCommand("update TblNews set Title=@title,Summery=@summery,[content]=@contnt,Type=@type,Date=@date where id=@id", objcon)

        objcom.Parameters.Add("@title", SqlDbType.NVarChar, 150).Value = txtTitle.Text
        objcom.Parameters.Add("@summery", SqlDbType.NChar, 300).Value = txtSumery.Text
        objcom.Parameters.Add("@contnt", SqlDbType.NVarChar).Value = txtContent.Text
        objcom.Parameters.Add("@Date", SqlDbType.VarChar).Value = TxtDate.Text
        objcom.Parameters.Add("@type", SqlDbType.Int).Value = DropDownList2.SelectedValue
        objcom.Parameters.Add("@id", SqlDbType.Int).Value = CInt(TextBox1.Text)
        objcom.CommandType = CommandType.Text
        objcon.Open()
        objcom.ExecuteNonQuery()
        'If objDR.HasRows Then
        '    GridView1.DataSource = objDR
        '    GridView1.DataBind()
        'End If
        'objDR.Close()
        objcon.Close()



    End Sub


    Protected Sub DropDownList3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList3.SelectedIndexChanged
        If DropDownList3.SelectedValue = 1 Then
            searchByName()

        ElseIf DropDownList3.SelectedValue = 2 Then
            Editٍsearch()
        ElseIf DropDownList3.SelectedValue = 3 Then
            searchByID()
        End If
    End Sub
    Public Sub searchByName()
        Dim objcon As New SqlConnection(strcon)
        Dim objcomm As New SqlCommand("Select ID as 'شناسه',Title as 'عنوان خبر',Summery as 'خلاصه خبر',[Content] as 'محتوای خبر',Type as 'نوع خبر',Date as 'تاریخ' from TblNews where Title like N'%'+@title+'%'", objcon)
        objcomm.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value = TextBox1.Text.Trim
        objcomm.CommandType = CommandType.Text
        objcon.Open()
        Dim objDR As SqlDataReader = objcomm.ExecuteReader
        If objDR.HasRows Then
            GridView1.DataSource = objDR
            GridView1.DataBind()
            Label1.Text = "با موفقیت انجام شد"
            TextBox1.Text = " "
        Else
            Label1.Text = "ناموفق !"
        End If
       
        objDR.Close()
        objcon.Close()


    End Sub
    Public Sub searchByID()

        Dim objcon As New SqlConnection(StrCon)
        Dim objcom As New SqlCommand("Select ID as 'شناسه',Title as 'عنوان خبر',Summery as 'خلاصه خبر',[Content] as 'محتوای خبر',Type as 'نوع خبر',Date as 'تاریخ' from TblNews where id=@id ", objcon)
        objcom.Parameters.Add("@id", SqlDbType.Int).Value = CInt(TextBox1.Text)
        objcom.CommandType = CommandType.Text
        objcon.Open()
        Dim objDR As SqlDataReader = objcom.ExecuteReader

        If objDR.HasRows Then
            GridView1.DataSource = objDR
            GridView1.DataBind()
        End If
        objDR.Close()
    End Sub
    Public Sub Editٍsearch()

        Dim objcon As New SqlConnection(StrCon)
        Dim objcom As New SqlCommand("select * from TblNews where id=@id ", objcon)
        objcom.Parameters.Add("@id", SqlDbType.Int).Value = CInt(TextBox1.Text)
        objcom.CommandType = CommandType.Text
        objcon.Open()
        Dim objDR As SqlDataReader = objcom.ExecuteReader
        If objDR.Read Then
            txtTitle.Text = objDR!Title.ToString
            txtSumery.Text = objDR!Summery.ToString
            txtContent.Text = objDR![content].ToString
            TxtDate.Text = objDR!Date.ToString
            DropDownList2.SelectedValue = objDR!type.ToString



        End If

    End Sub
End Class
