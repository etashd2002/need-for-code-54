Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Text

Public Class GlobalVariables
    Public Shared UserCode As String
    Public Shared UsrName As String
    Public Shared UserId As Integer
    Public Shared LoginName As String
    Public Shared loginDate As Date
    Public Shared enFormMode As Integer
    Public Shared strConnString As String '= "Server=103.197.221.123;Database=SIAMMSData;User=sa;Pwd=Mh03@123;"
    Public Shared strServer As String
    Public Shared strDatabase As String
    Public Shared strUser As String
    Public Shared strPswd As String
    Public Shared strDSN As String
    Public Shared strReportPath As String
    Public Enum FormMode
        fmAddData = 0
        fmEditData = 1
        fmSaveData = 2
        fmCancelData = 3
        fmDeleteData = 4
        fmPrint = 5
        fmPreview = 6
        fmView = 7
    End Enum
End Class

Public Class SQLControl
    ' get Server Connection Details

    '    Public DBConn As New SqlConnection("Server=103.197.221.123;Database=SIAMMSData;User=sa;Pwd=Mh03@123;")
    Public DBConn As New SqlConnection(GlobalVariables.strConnString)
    Public DBCmd As SqlCommand

    ' DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)
    Public ParamsSql As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public ReturnValue As VariantType
    Public intCtrlEntryNo As Integer
    Public intCtrlErrCode As Integer
    Public strCtrlErrMsg As String
    Public Exception As String

    Public Sub New()
    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBConn = New SqlConnection(ConnectionString)
    End Sub

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
        ReturnValue = 0

        Try
            DBConn.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBConn)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
            If RecordCount > 0 Then
                ReturnValue = Val(DBDT.Rows(0)(0)).ToString()
            Else
                ReturnValue = 0
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBConn.State = ConnectionState.Open Then DBConn.Close()
        End Try
    End Sub

    Public Sub ExecProcedure(SPName As String)
        ' RESET QUERY STATS
        RecordCount = 0
        intCtrlErrCode = 0
        strCtrlErrMsg = ""
        Exception = ""

        Try
            DBConn.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(SPName, DBConn)
            DBCmd.CommandType = CommandType.StoredProcedure

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            If SPName = "SIA_TrnPurchaseAUD" Or SPName = "SIA_TrnProductionAUD" Or SPName = "SIA_TrnDeliveryAUD" Then
                DBCmd.Parameters.Add("@out_EntryNo", SqlDbType.Int, 6).Direction = ParameterDirection.Output
            End If
            DBCmd.Parameters.Add("@out_ErrCode", SqlDbType.Int, 6).Direction = ParameterDirection.Output
            DBCmd.Parameters.Add("@out_ErrMsg", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
            ' CLEAR PARAM LIST
            Params.Clear()
            DBCmd.CommandTimeout = 300
            ' EXECUTE COMMAND & FILL DATASET
            DBDA = New SqlDataAdapter(DBCmd)
            DBDT = New DataTable

            DBDA.SelectCommand = DBCmd
            DBDA.Fill(DBDT)
            If SPName = "SIA_TrnPurchaseAUD" Or SPName = "SIA_TrnProductionAUD" Or SPName = "SIA_TrnDeliveryAUD" Then
                If IsNumeric(DBCmd.Parameters("@out_EntryNo").Value) Then
                    intCtrlEntryNo = DBCmd.Parameters("@out_EntryNo").Value
                End If
            End If
            intCtrlErrCode = DBCmd.Parameters("@out_ErrCode").Value
            strCtrlErrMsg = DBCmd.Parameters("@out_ErrMsg").Value
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecProcedure Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBConn.State = ConnectionState.Open Then DBConn.Close()
        End Try
    End Sub
    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
    ' ADD PARAMS
    Public Sub AddParamSQL(Name As String, DataType As SqlDbType, Precision As Integer, direction As ParameterDirection, Value As Object)
        Dim NewParam As New SqlParameter(Name, DataType, Precision, Value)
        ParamsSql.Add(NewParam)
    End Sub
    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = True) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
    ' Clear Datatable
    Public Sub ClearDBDT()
        DBDT.Clear()
    End Sub
    Public Shared Function GetMenuFormId(strMenuName As String, strFormName As String) As Integer
        Dim cnData As New SQLControl
        Try
            cnData.AddParam("@MenuName", strMenuName)
            cnData.AddParam("@formName", strFormName)
            cnData.ExecQuery("Select MenuFormId from sysMenuForms Where MenuName = @MenuName And FormName = @FormName;")
            If cnData.HasException = True Then
                Return cnData.ReturnValue
                Exit Function
            End If

            If cnData.ReturnValue = 0 Then
                MessageBox.Show("Form Name not mentioned in the SysMenuForm Table, cannot proceed with this Menu option ...")
            End If
        Catch ex As Exception
            MessageBox.Show(cnData.Exception)
        Finally
            '            cnData = Nothing
        End Try
        Return cnData.ReturnValue
    End Function

    Public Shared Function GetUserRights(intMenuFormId As Integer, strUserCode As String, blnEnaFlag As Boolean) As Integer
        Dim cnData As New SQLControl
        Try
            cnData.AddParam("@MenuFormId", intMenuFormId)
            cnData.AddParam("@UserCode", strUserCode)
            cnData.ExecQuery("Select * from SysGenAuthority Where MenuFormId = @MenuformId And UserCode = @UserCode;")
            If cnData.HasException = True Then
                Return 0
                Exit Function
            End If


            If cnData.RecordCount = 0 Then
                MessageBox.Show("Rights for the User for this option has not been initiated ...")
                For Each button In SIAMain.MainToolBar.Items.OfType(Of ToolStripButton)()
                    button.Enabled = False
                Next
                Return 0
                Exit Function
            Else
                If cnData.DBDT(0)("AllowAdd").ToString() = "Y" Then
                    SIAMain.NewToolBtn.Enabled = blnEnaFlag
                Else
                    SIAMain.NewToolBtn.Enabled = False
                End If
                If cnData.DBDT(0)("AllowEdit").ToString() = "Y" Then
                    SIAMain.EditToolBtn.Enabled = blnEnaFlag
                Else
                    SIAMain.EditToolBtn.Enabled = False
                End If
                If cnData.DBDT(0)("AllowDelete").ToString() = "Y" Then
                    SIAMain.DeleteToolBtn.Enabled = blnEnaFlag
                Else
                    SIAMain.DeleteToolBtn.Enabled = False
                End If
                If cnData.DBDT(0)("AllowPrint").ToString() = "Y" Then
                    SIAMain.PrintToolBtn.Enabled = blnEnaFlag
                Else
                    SIAMain.PrintToolBtn.Enabled = False
                End If
                If cnData.DBDT(0)("AllowPreview").ToString() = "Y" Then
                    SIAMain.PreviewToolBtn.Enabled = blnEnaFlag
                Else
                    SIAMain.PreviewToolBtn.Enabled = False
                End If
                SIAMain.SaveToolBtn.Enabled = Not blnEnaFlag
                SIAMain.CancelToolBtn.Enabled = Not blnEnaFlag
            End If
        Catch ex As Exception
            MessageBox.Show(cnData.Exception)
        Finally

        End Try
        Return cnData.RecordCount
    End Function

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As StringBuilder,
        ByVal nSize As Integer,
        ByVal lpFileName As String) As Integer

    Public Shared Function GetIniValue(section As String, key As String, filename As String, Optional defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function

    Public Shared Sub setDateTimePickerBlank(ByVal dateTimePicker As DateTimePicker)
        dateTimePicker.Visible = True
        dateTimePicker.Value = DateTime.Now
        dateTimePicker.CustomFormat = "    "
        dateTimePicker.Format = DateTimePickerFormat.Custom
    End Sub

End Class
