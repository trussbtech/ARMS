﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace com.vmshoa.vmsxchange.vmsaccountvalidation
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="VMSAccountValidationSoap", [Namespace]:="http://VillageManagementSoftware.com/")>  _
    Partial Public Class VMSAccountValidation
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private VMSAccountDataOperationCompleted As System.Threading.SendOrPostCallback
        
        Private VMSValidationOperationCompleted As System.Threading.SendOrPostCallback
        
        Private VMSSetAccountForeignPasswordOperationCompleted As System.Threading.SendOrPostCallback
        
        Private VMSClearUserOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://vmsxchange.tssvendor.com/VMSAccountValidation.asmx"
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event VMSAccountDataCompleted As VMSAccountDataCompletedEventHandler
        
        '''<remarks/>
        Public Event VMSValidationCompleted As VMSValidationCompletedEventHandler
        
        '''<remarks/>
        Public Event VMSSetAccountForeignPasswordCompleted As VMSSetAccountForeignPasswordCompletedEventHandler
        
        '''<remarks/>
        Public Event VMSClearUserCompleted As VMSClearUserCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/VMSAccountData", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function VMSAccountData(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountContactKey As Integer, ByVal AccountPassword As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long, ByVal PeriodDate As Date) As String
            Dim results() As Object = Me.Invoke("VMSAccountData", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, AccountContactKey, AccountPassword, Provider, AccountInformationBitMap, PeriodDate})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginVMSAccountData(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountContactKey As Integer, ByVal AccountPassword As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long, ByVal PeriodDate As Date, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("VMSAccountData", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, AccountContactKey, AccountPassword, Provider, AccountInformationBitMap, PeriodDate}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndVMSAccountData(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub VMSAccountDataAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountContactKey As Integer, ByVal AccountPassword As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long, ByVal PeriodDate As Date)
            Me.VMSAccountDataAsync(PartnerKey, VendorID, VendorPassword, AccountKey, AccountContactKey, AccountPassword, Provider, AccountInformationBitMap, PeriodDate, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub VMSAccountDataAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountContactKey As Integer, ByVal AccountPassword As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long, ByVal PeriodDate As Date, ByVal userState As Object)
            If (Me.VMSAccountDataOperationCompleted Is Nothing) Then
                Me.VMSAccountDataOperationCompleted = AddressOf Me.OnVMSAccountDataOperationCompleted
            End If
            Me.InvokeAsync("VMSAccountData", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, AccountContactKey, AccountPassword, Provider, AccountInformationBitMap, PeriodDate}, Me.VMSAccountDataOperationCompleted, userState)
        End Sub
        
        Private Sub OnVMSAccountDataOperationCompleted(ByVal arg As Object)
            If (Not (Me.VMSAccountDataCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent VMSAccountDataCompleted(Me, New VMSAccountDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/VMSValidation", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function VMSValidation(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long) As String
            Dim results() As Object = Me.Invoke("VMSValidation", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider, AccountInformationBitMap})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginVMSValidation(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("VMSValidation", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider, AccountInformationBitMap}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndVMSValidation(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub VMSValidationAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long)
            Me.VMSValidationAsync(PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider, AccountInformationBitMap, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub VMSValidationAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal AccountInformationBitMap As Long, ByVal userState As Object)
            If (Me.VMSValidationOperationCompleted Is Nothing) Then
                Me.VMSValidationOperationCompleted = AddressOf Me.OnVMSValidationOperationCompleted
            End If
            Me.InvokeAsync("VMSValidation", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider, AccountInformationBitMap}, Me.VMSValidationOperationCompleted, userState)
        End Sub
        
        Private Sub OnVMSValidationOperationCompleted(ByVal arg As Object)
            If (Not (Me.VMSValidationCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent VMSValidationCompleted(Me, New VMSValidationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/VMSSetAccountForeignPassword", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function VMSSetAccountForeignPassword(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountPassword As String, ByVal PrivateKey As String, ByVal Provider As Integer) As String
            Dim results() As Object = Me.Invoke("VMSSetAccountForeignPassword", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, AccountPassword, PrivateKey, Provider})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginVMSSetAccountForeignPassword(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountPassword As String, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("VMSSetAccountForeignPassword", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, AccountPassword, PrivateKey, Provider}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndVMSSetAccountForeignPassword(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub VMSSetAccountForeignPasswordAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountPassword As String, ByVal PrivateKey As String, ByVal Provider As Integer)
            Me.VMSSetAccountForeignPasswordAsync(PartnerKey, VendorID, VendorPassword, AccountKey, AccountPassword, PrivateKey, Provider, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub VMSSetAccountForeignPasswordAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal AccountPassword As String, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal userState As Object)
            If (Me.VMSSetAccountForeignPasswordOperationCompleted Is Nothing) Then
                Me.VMSSetAccountForeignPasswordOperationCompleted = AddressOf Me.OnVMSSetAccountForeignPasswordOperationCompleted
            End If
            Me.InvokeAsync("VMSSetAccountForeignPassword", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, AccountPassword, PrivateKey, Provider}, Me.VMSSetAccountForeignPasswordOperationCompleted, userState)
        End Sub
        
        Private Sub OnVMSSetAccountForeignPasswordOperationCompleted(ByVal arg As Object)
            If (Not (Me.VMSSetAccountForeignPasswordCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent VMSSetAccountForeignPasswordCompleted(Me, New VMSSetAccountForeignPasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/VMSClearUser", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function VMSClearUser(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer) As String
            Dim results() As Object = Me.Invoke("VMSClearUser", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginVMSClearUser(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("VMSClearUser", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndVMSClearUser(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub VMSClearUserAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer)
            Me.VMSClearUserAsync(PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub VMSClearUserAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal AccountKey As Integer, ByVal PrivateKey As String, ByVal Provider As Integer, ByVal userState As Object)
            If (Me.VMSClearUserOperationCompleted Is Nothing) Then
                Me.VMSClearUserOperationCompleted = AddressOf Me.OnVMSClearUserOperationCompleted
            End If
            Me.InvokeAsync("VMSClearUser", New Object() {PartnerKey, VendorID, VendorPassword, AccountKey, PrivateKey, Provider}, Me.VMSClearUserOperationCompleted, userState)
        End Sub
        
        Private Sub OnVMSClearUserOperationCompleted(ByVal arg As Object)
            If (Not (Me.VMSClearUserCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent VMSClearUserCompleted(Me, New VMSClearUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")>  _
    Public Delegate Sub VMSAccountDataCompletedEventHandler(ByVal sender As Object, ByVal e As VMSAccountDataCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class VMSAccountDataCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")>  _
    Public Delegate Sub VMSValidationCompletedEventHandler(ByVal sender As Object, ByVal e As VMSValidationCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class VMSValidationCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")>  _
    Public Delegate Sub VMSSetAccountForeignPasswordCompletedEventHandler(ByVal sender As Object, ByVal e As VMSSetAccountForeignPasswordCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class VMSSetAccountForeignPasswordCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")>  _
    Public Delegate Sub VMSClearUserCompletedEventHandler(ByVal sender As Object, ByVal e As VMSClearUserCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class VMSClearUserCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
