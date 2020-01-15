Imports System
#Region "Modifications"
'
' Project: AR - VMS integration
' Arthor: Tyrone Russ
' Last date modified: 01/14/2020
'
'
#End Region

Public Class ARVMSXChangeAPI
    ''' <summary>
    ''' Function manages the bit map for the request of information through the VMSAccountData, DownloadProperty. Function returns the bit map based on the selection checkboxes
    ''' </summary>
    Dim iInformationBit As Integer = 0
    iInformationBit += 256 'VMSStructure

    End Sub

    Pub Function CreateXMLFile(inString As String) As Stringlic

        Dim sFile As String = System.IO.Path.GetTempPath & "VMS"

        If Not IO.Directory.Exists(sFile) Then
            IO.Directory.CreateDirectory(sFile)
        End If

        sFile &= "\temp" & Now.Ticks / System.TimeSpan.TicksPerMillisecond & ".xml"
        Dim ss As New System.IO.StreamWriter(sFile)
        ss.WriteLine(inString)
        ss.Close()

        System.Diagnostics.Process.Start(sFile)

        Return sFile

    End Function

    ' Function downloads property data, using the Property Tab and Information Bit flag, 
    ' calling VMSDataXChange.DownloadProperty
    '
    Public Function DownloadProperty(PartnerKey As String, VendorID As String, VendorPassword As String,
                           PropertyCompanyKey As String, PropertyResident As String,
                           PropertyResidentContactKeys As String, InformationBit As Long, dtpTransactionAsOf As Date) As Integer

        Dim sXML As String
        Dim vmsXChangeRequest As New com.villagemanagementsoftware.VMSDataXChange.VMSDataXChange
        Dim ReturnDataProperty As String

        vmsXChangeRequest.Url = "/VMSDataXChange.asmx"

        sXML = vmsXChangeRequest.DownloadProperty(PartnerKey, PropertyCompanyKey, VendorID, PropertyCompanyKey, PropertyResident, PropertyResidentContactKeys, InformationBit, dtpTransactionAsOf)
        ReturnDataProperty = sXML


        Return ReturnDataProperty


    End Function

    Public Function AddXMLTag(ByVal name As String, ByVal Value As String, Optional ByVal maxLength As Integer = 0, Optional ByVal whiteSpaceVal As String = "") As String
        Static badAmpersand As New System.Text.RegularExpressions.Regex("&(?![a-zA-Z]{2,6};|#[0-9]{2,4};)")
        If Value = "" Then Value = whiteSpaceVal
        If maxLength > 0 And Value.Length > maxLength Then Value = Value.Substring(0, maxLength)
        Value = badAmpersand.Replace(Value, "&amp;")
        Value = Value.Replace("<", "&lt;").Replace("""", "&quot;").Replace(">", "gt;")
        Return "<" & name & ">" & Value & "</" & name & ">"
    End Function


#Region "XSD Links"
    Private Sub DocumentRequest(requestType As String)
        System.Diagnostics.Process.Start("http://document.villagemanagementsoftware.com/xmlvalidation/DemandRequestV30.xsd")
    End Sub

#End Region
End Class




