Module modVMSXChangeClient

    Public m_Version As String = "4.1.090916"

    '
    ' This routine adds an arraylist to the list of items of a control, by creating a table and binding to it
    '
    Public Sub AddToList(ByRef inListObject As ComboBox, ByVal inArray As ArrayList, Optional ByVal addBlank As Boolean = False, Optional ByVal blankMessage As String = "", Optional ByVal nothingMessage As String = "", Optional ByVal blankValue As Object = -1, Optional ByVal nothingValue As Object = 0)
        Try
            Dim aryItem As clsListItem
            inListObject.BeginUpdate()
            inListObject.SelectedItem = Nothing
            inListObject.DataSource = Nothing
            inListObject.Items.Clear()
            inListObject.DisplayMember = "Text"
            inListObject.ValueMember = "Key"
            '
            If inArray.Count = 0 Then
                If nothingMessage.Length > 0 Then inListObject.Items.Add(New clsListItem(nothingMessage, nothingValue))
            Else
                '
                If addBlank = True Then
                    Select Case CType(inArray(0), clsListItem).KeyType
                        Case "System.DateTime"
                            inListObject.Items.Add(New clsListItem(blankMessage, CDate("00:00")))

                        Case "System.String"
                            If blankValue.GetType.ToString = "System.String" Then
                                inListObject.Items.Add(New clsListItem(blankMessage, blankValue))
                            Else
                                inListObject.Items.Add(New clsListItem(blankMessage, ""))
                            End If

                        Case Else
                            inListObject.Items.Add(New clsListItem(blankMessage, blankValue))
                    End Select
                End If
                '
                ' Load items into combo
                '
                For Each aryItem In inArray
                    inListObject.Items.Add(aryItem)
                Next
            End If
            inListObject.DataSource = inListObject.Items
            inListObject.EndUpdate()
        Catch ex As Exception
            Throw New Exception(ex.Message + " " + ex.Source)
        End Try
    End Sub

    Public Function AddXMLTag(ByVal name As String, ByVal Value As String, Optional ByVal maxLength As Integer = 0, Optional ByVal whiteSpaceVal As String = "") As String
        Static badAmpersand As New System.Text.RegularExpressions.Regex("&(?![a-zA-Z]{2,6};|#[0-9]{2,4};)")
        If Value = "" Then Value = whiteSpaceVal
        If maxLength > 0 And Value.Length > maxLength Then Value = Value.Substring(0, maxLength)
        Value = badAmpersand.Replace(Value, "&amp;")
        Value = Value.Replace("<", "&lt;").Replace("""", "&quot;").Replace(">", "gt;")
        Return "<" & name & ">" & Value & "</" & name & ">"
    End Function

    Public Sub CheckError(inds As DataSet)
        If inds.Tables.Contains("Error") Then Throw New Exception(inds.Tables("Error").Rows(0)(1))
    End Sub
    '
    ' Finds key in list of items
    '
    Public Sub FindKeyInList(ByRef inListObject As ComboBox, ByVal inKey As Object)
        If inKey Is Nothing Then If inListObject.Items.Count Then inListObject.SelectedIndex = 0 : Exit Sub
        '
        ' Determine the type 
        '
        Dim cnt As Integer
        Try
            For cnt = 0 To inListObject.Items.Count - 1
                Select Case CType(inListObject.Items(cnt), clsListItem).KeyType
                    Case "System.DateTime"
                        If IsDate(inKey) Then If CType(inListObject.Items(cnt), clsListItem).Key = CDate(inKey) Then inListObject.SelectedIndex = cnt : Exit Sub

                    Case "System.Double", "System.Int16", "System.Int32", "System.Int64", "System.Long", "System.Single"
                        If CType(inListObject.Items(cnt), clsListItem).Key = Val(inKey) Then inListObject.SelectedIndex = cnt : Exit Sub

                    Case "System.String"
                        If CType(inListObject.Items(cnt), clsListItem).Key = CStr(inKey) Then inListObject.SelectedIndex = cnt : Exit Sub
                End Select
            Next
            If inListObject.Items.Count Then inListObject.SelectedIndex = 0
        Catch ex As Exception
            Throw New Exception(ex.Message + " " + ex.Source)
        End Try
    End Sub

    Public Class clsListItem
        Private _keyType As String
        Private _lstKey As Object
        Private _lstText As String

        Public Sub New(ByVal Text As String, ByVal Key As Object)
            MyBase.New()
            Me._lstText = Text
            Me._lstKey = Key
            Me._keyType = Key.GetType.ToString
        End Sub

        Public Property Key() As Object
            Set(ByVal Value As Object)
                _lstKey = Value
            End Set
            Get
                Return _lstKey
            End Get
        End Property

        Public ReadOnly Property KeyType() As String
            Get
                Return _keyType
            End Get
        End Property

        Public Property Text() As String
            Set(ByVal Value As String)
                _lstText = Value
            End Set
            Get
                Return _lstText
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return Me._lstText
        End Function

        Public Shared Function Contains(ByVal inAry As ArrayList, ByVal inKey As Object) As Boolean
            Dim clsAryList As clsListItem
            '
            For Each clsAryList In inAry
                If clsAryList.Key = inKey Then Return True
            Next
            Return False
        End Function

        Public Shared Function IndexOfKey(ByVal inAry As ArrayList, ByVal inKey As Object) As Integer
            Dim clsAryList As clsListItem
            Dim index As Integer = 0
            '
            For Each clsAryList In inAry
                If clsAryList.Key = inKey Then Return index
                index += 1
            Next
            Return -1
        End Function

        Public Shared Function IndexOfText(ByVal inAry As ArrayList, ByVal inText As String) As Integer
            Dim clsAryList As clsListItem
            Dim index As Integer = 0
            '
            For Each clsAryList In inAry
                If clsAryList.Text = inText Then Return index
                index += 1
            Next
            Return -1
        End Function
        '
        ' This routine returns a string from selected items in a listbox that uses the clsListItem
        '
        Public Shared Function GetListSelections(ByVal inLst As ListBox) As String
            If inLst.SelectedValue Is Nothing Then Return ""
            Dim cnt As Integer
            Dim iTemp As Integer
            Dim rtnString As String = ""
            '
            If TypeOf (inLst.SelectedValue) Is String Then
                If inLst.SelectedValue = "" Then Return ""
            Else
                If inLst.SelectedValue = -1 Then
                    For cnt = 0 To inLst.Items.Count - 1
                        rtnString += CType(CType(inLst.Items(cnt), clsListItem).Key, String) + "|"
                    Next
                    Return rtnString.Substring(0, rtnString.Length - 1)
                End If
            End If
            '
            ' Save values
            '
            If inLst.SelectedItems.Count = 1 And inLst.Items.Count = 1 Then
                rtnString = CType(CType(inLst.Items(0), clsListItem).Key, String)
            Else
                For cnt = 0 To inLst.SelectedItems.Count - 1
                    iTemp = inLst.SelectedIndices(cnt)
                    If iTemp > 0 Then rtnString += CType(CType(inLst.Items(iTemp), clsListItem).Key, String) + "|"
                Next
                If rtnString.Length > 0 Then rtnString = rtnString.Substring(0, rtnString.Length - 1)
            End If
            Return rtnString
        End Function

        Public Shared Sub SetListSelections(ByVal inSelections As Object, ByRef inLst As ListBox)
            If IsDBNull(inSelections) Or inLst.Items.Count = 0 Then Exit Sub
            Dim cnt As Integer
            Dim sKey() As String = inSelections.Split("|")
            inLst.BeginUpdate()
            inLst.ClearSelected()
            inLst.SetSelected(0, False)
            '
            If sKey(0).Length = 0 Or sKey(0) = "-1" Then
                inLst.SetSelected(0, True)
            Else
                For cnt = 0 To inLst.Items.Count - 1
                    If Array.IndexOf(sKey, CType(CType(inLst.Items(cnt), clsListItem).Key, String)) <> -1 Then inLst.SetSelected(cnt, True)
                Next
            End If
            inLst.EndUpdate()
        End Sub
    End Class
End Module
