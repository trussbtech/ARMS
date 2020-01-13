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
Namespace com.villagemanagementsoftware.VMSDocumentRequest
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="DocumentRequestSoap", [Namespace]:="http://VillageManagementSoftware.com/")>  _
    Partial Public Class DocumentRequest
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private CertificateRequestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CertificateRequestV2OperationCompleted As System.Threading.SendOrPostCallback
        
        Private DemandRequestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DemandRequestV2OperationCompleted As System.Threading.SendOrPostCallback
        
        Private ManagedListRequestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private PropertyRequestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ResaleOrderOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://vmsxchange.tssvendor.com/DocumentRequest.asmx"
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
        Public Event CertificateRequestCompleted As CertificateRequestCompletedEventHandler
        
        '''<remarks/>
        Public Event CertificateRequestV2Completed As CertificateRequestV2CompletedEventHandler
        
        '''<remarks/>
        Public Event DemandRequestCompleted As DemandRequestCompletedEventHandler
        
        '''<remarks/>
        Public Event DemandRequestV2Completed As DemandRequestV2CompletedEventHandler
        
        '''<remarks/>
        Public Event ManagedListRequestCompleted As ManagedListRequestCompletedEventHandler
        
        '''<remarks/>
        Public Event PropertyRequestCompleted As PropertyRequestCompletedEventHandler
        
        '''<remarks/>
        Public Event ResaleOrderCompleted As ResaleOrderCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/CertificateRequest", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CertificateRequest(ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String) As String
            Dim results() As Object = Me.Invoke("CertificateRequest", New Object() {VendorID, VendorPassword, TaxID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginCertificateRequest(ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("CertificateRequest", New Object() {VendorID, VendorPassword, TaxID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndCertificateRequest(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CertificateRequestAsync(ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String)
            Me.CertificateRequestAsync(VendorID, VendorPassword, TaxID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CertificateRequestAsync(ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal userState As Object)
            If (Me.CertificateRequestOperationCompleted Is Nothing) Then
                Me.CertificateRequestOperationCompleted = AddressOf Me.OnCertificateRequestOperationCompleted
            End If
            Me.InvokeAsync("CertificateRequest", New Object() {VendorID, VendorPassword, TaxID}, Me.CertificateRequestOperationCompleted, userState)
        End Sub
        
        Private Sub OnCertificateRequestOperationCompleted(ByVal arg As Object)
            If (Not (Me.CertificateRequestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CertificateRequestCompleted(Me, New CertificateRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/CertificateRequestV2", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CertificateRequestV2(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String) As String
            Dim results() As Object = Me.Invoke("CertificateRequestV2", New Object() {PartnerKey, VendorID, VendorPassword, TaxID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginCertificateRequestV2(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("CertificateRequestV2", New Object() {PartnerKey, VendorID, VendorPassword, TaxID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndCertificateRequestV2(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CertificateRequestV2Async(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String)
            Me.CertificateRequestV2Async(PartnerKey, VendorID, VendorPassword, TaxID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CertificateRequestV2Async(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal userState As Object)
            If (Me.CertificateRequestV2OperationCompleted Is Nothing) Then
                Me.CertificateRequestV2OperationCompleted = AddressOf Me.OnCertificateRequestV2OperationCompleted
            End If
            Me.InvokeAsync("CertificateRequestV2", New Object() {PartnerKey, VendorID, VendorPassword, TaxID}, Me.CertificateRequestV2OperationCompleted, userState)
        End Sub
        
        Private Sub OnCertificateRequestV2OperationCompleted(ByVal arg As Object)
            If (Not (Me.CertificateRequestV2CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CertificateRequestV2Completed(Me, New CertificateRequestV2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/DemandRequest", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DemandRequest(ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal AccountID As String, ByVal LastName As String, ByVal StreetNumber As String, ByVal StreetName As String, ByVal Door As String, ByVal City As String, ByVal Region As String, ByVal PostalCode As String, ByVal Lot As String, ByVal Block As String, ByVal Section As String) As String
            Dim results() As Object = Me.Invoke("DemandRequest", New Object() {VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginDemandRequest( _
                    ByVal VendorID As String,  _
                    ByVal VendorPassword As String,  _
                    ByVal TaxID As String,  _
                    ByVal AccountID As String,  _
                    ByVal LastName As String,  _
                    ByVal StreetNumber As String,  _
                    ByVal StreetName As String,  _
                    ByVal Door As String,  _
                    ByVal City As String,  _
                    ByVal Region As String,  _
                    ByVal PostalCode As String,  _
                    ByVal Lot As String,  _
                    ByVal Block As String,  _
                    ByVal Section As String,  _
                    ByVal callback As System.AsyncCallback,  _
                    ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("DemandRequest", New Object() {VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndDemandRequest(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub DemandRequestAsync(ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal AccountID As String, ByVal LastName As String, ByVal StreetNumber As String, ByVal StreetName As String, ByVal Door As String, ByVal City As String, ByVal Region As String, ByVal PostalCode As String, ByVal Lot As String, ByVal Block As String, ByVal Section As String)
            Me.DemandRequestAsync(VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DemandRequestAsync(ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal AccountID As String, ByVal LastName As String, ByVal StreetNumber As String, ByVal StreetName As String, ByVal Door As String, ByVal City As String, ByVal Region As String, ByVal PostalCode As String, ByVal Lot As String, ByVal Block As String, ByVal Section As String, ByVal userState As Object)
            If (Me.DemandRequestOperationCompleted Is Nothing) Then
                Me.DemandRequestOperationCompleted = AddressOf Me.OnDemandRequestOperationCompleted
            End If
            Me.InvokeAsync("DemandRequest", New Object() {VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section}, Me.DemandRequestOperationCompleted, userState)
        End Sub
        
        Private Sub OnDemandRequestOperationCompleted(ByVal arg As Object)
            If (Not (Me.DemandRequestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DemandRequestCompleted(Me, New DemandRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/DemandRequestV2", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DemandRequestV2(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal AccountID As String, ByVal LastName As String, ByVal StreetNumber As String, ByVal StreetName As String, ByVal Door As String, ByVal City As String, ByVal Region As String, ByVal PostalCode As String, ByVal Lot As String, ByVal Block As String, ByVal Section As String) As String
            Dim results() As Object = Me.Invoke("DemandRequestV2", New Object() {PartnerKey, VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginDemandRequestV2( _
                    ByVal PartnerKey As String,  _
                    ByVal VendorID As String,  _
                    ByVal VendorPassword As String,  _
                    ByVal TaxID As String,  _
                    ByVal AccountID As String,  _
                    ByVal LastName As String,  _
                    ByVal StreetNumber As String,  _
                    ByVal StreetName As String,  _
                    ByVal Door As String,  _
                    ByVal City As String,  _
                    ByVal Region As String,  _
                    ByVal PostalCode As String,  _
                    ByVal Lot As String,  _
                    ByVal Block As String,  _
                    ByVal Section As String,  _
                    ByVal callback As System.AsyncCallback,  _
                    ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("DemandRequestV2", New Object() {PartnerKey, VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndDemandRequestV2(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub DemandRequestV2Async(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal AccountID As String, ByVal LastName As String, ByVal StreetNumber As String, ByVal StreetName As String, ByVal Door As String, ByVal City As String, ByVal Region As String, ByVal PostalCode As String, ByVal Lot As String, ByVal Block As String, ByVal Section As String)
            Me.DemandRequestV2Async(PartnerKey, VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DemandRequestV2Async( _
                    ByVal PartnerKey As String,  _
                    ByVal VendorID As String,  _
                    ByVal VendorPassword As String,  _
                    ByVal TaxID As String,  _
                    ByVal AccountID As String,  _
                    ByVal LastName As String,  _
                    ByVal StreetNumber As String,  _
                    ByVal StreetName As String,  _
                    ByVal Door As String,  _
                    ByVal City As String,  _
                    ByVal Region As String,  _
                    ByVal PostalCode As String,  _
                    ByVal Lot As String,  _
                    ByVal Block As String,  _
                    ByVal Section As String,  _
                    ByVal userState As Object)
            If (Me.DemandRequestV2OperationCompleted Is Nothing) Then
                Me.DemandRequestV2OperationCompleted = AddressOf Me.OnDemandRequestV2OperationCompleted
            End If
            Me.InvokeAsync("DemandRequestV2", New Object() {PartnerKey, VendorID, VendorPassword, TaxID, AccountID, LastName, StreetNumber, StreetName, Door, City, Region, PostalCode, Lot, Block, Section}, Me.DemandRequestV2OperationCompleted, userState)
        End Sub
        
        Private Sub OnDemandRequestV2OperationCompleted(ByVal arg As Object)
            If (Not (Me.DemandRequestV2CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DemandRequestV2Completed(Me, New DemandRequestV2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/ManagedListRequest", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ManagedListRequest(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String) As String
            Dim results() As Object = Me.Invoke("ManagedListRequest", New Object() {PartnerKey, VendorID, VendorPassword})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginManagedListRequest(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ManagedListRequest", New Object() {PartnerKey, VendorID, VendorPassword}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndManagedListRequest(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ManagedListRequestAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String)
            Me.ManagedListRequestAsync(PartnerKey, VendorID, VendorPassword, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ManagedListRequestAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal userState As Object)
            If (Me.ManagedListRequestOperationCompleted Is Nothing) Then
                Me.ManagedListRequestOperationCompleted = AddressOf Me.OnManagedListRequestOperationCompleted
            End If
            Me.InvokeAsync("ManagedListRequest", New Object() {PartnerKey, VendorID, VendorPassword}, Me.ManagedListRequestOperationCompleted, userState)
        End Sub
        
        Private Sub OnManagedListRequestOperationCompleted(ByVal arg As Object)
            If (Not (Me.ManagedListRequestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ManagedListRequestCompleted(Me, New ManagedListRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/PropertyRequest", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function PropertyRequest(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal LastName As String, ByVal StreetName As String, ByVal Door As String, ByVal PostalCode As String, ByVal StreetNumber As String) As String
            Dim results() As Object = Me.Invoke("PropertyRequest", New Object() {PartnerKey, VendorID, VendorPassword, TaxID, LastName, StreetName, Door, PostalCode, StreetNumber})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginPropertyRequest(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal LastName As String, ByVal StreetName As String, ByVal Door As String, ByVal PostalCode As String, ByVal StreetNumber As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("PropertyRequest", New Object() {PartnerKey, VendorID, VendorPassword, TaxID, LastName, StreetName, Door, PostalCode, StreetNumber}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndPropertyRequest(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub PropertyRequestAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal LastName As String, ByVal StreetName As String, ByVal Door As String, ByVal PostalCode As String, ByVal StreetNumber As String)
            Me.PropertyRequestAsync(PartnerKey, VendorID, VendorPassword, TaxID, LastName, StreetName, Door, PostalCode, StreetNumber, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub PropertyRequestAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal TaxID As String, ByVal LastName As String, ByVal StreetName As String, ByVal Door As String, ByVal PostalCode As String, ByVal StreetNumber As String, ByVal userState As Object)
            If (Me.PropertyRequestOperationCompleted Is Nothing) Then
                Me.PropertyRequestOperationCompleted = AddressOf Me.OnPropertyRequestOperationCompleted
            End If
            Me.InvokeAsync("PropertyRequest", New Object() {PartnerKey, VendorID, VendorPassword, TaxID, LastName, StreetName, Door, PostalCode, StreetNumber}, Me.PropertyRequestOperationCompleted, userState)
        End Sub
        
        Private Sub OnPropertyRequestOperationCompleted(ByVal arg As Object)
            If (Not (Me.PropertyRequestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent PropertyRequestCompleted(Me, New PropertyRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://VillageManagementSoftware.com/ResaleOrder", RequestNamespace:="http://VillageManagementSoftware.com/", ResponseNamespace:="http://VillageManagementSoftware.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ResaleOrder(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal ResaleRecordXML As String) As String
            Dim results() As Object = Me.Invoke("ResaleOrder", New Object() {PartnerKey, VendorID, VendorPassword, ResaleRecordXML})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginResaleOrder(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal ResaleRecordXML As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ResaleOrder", New Object() {PartnerKey, VendorID, VendorPassword, ResaleRecordXML}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndResaleOrder(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ResaleOrderAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal ResaleRecordXML As String)
            Me.ResaleOrderAsync(PartnerKey, VendorID, VendorPassword, ResaleRecordXML, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ResaleOrderAsync(ByVal PartnerKey As String, ByVal VendorID As String, ByVal VendorPassword As String, ByVal ResaleRecordXML As String, ByVal userState As Object)
            If (Me.ResaleOrderOperationCompleted Is Nothing) Then
                Me.ResaleOrderOperationCompleted = AddressOf Me.OnResaleOrderOperationCompleted
            End If
            Me.InvokeAsync("ResaleOrder", New Object() {PartnerKey, VendorID, VendorPassword, ResaleRecordXML}, Me.ResaleOrderOperationCompleted, userState)
        End Sub
        
        Private Sub OnResaleOrderOperationCompleted(ByVal arg As Object)
            If (Not (Me.ResaleOrderCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ResaleOrderCompleted(Me, New ResaleOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub CertificateRequestCompletedEventHandler(ByVal sender As Object, ByVal e As CertificateRequestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class CertificateRequestCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub CertificateRequestV2CompletedEventHandler(ByVal sender As Object, ByVal e As CertificateRequestV2CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class CertificateRequestV2CompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub DemandRequestCompletedEventHandler(ByVal sender As Object, ByVal e As DemandRequestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class DemandRequestCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub DemandRequestV2CompletedEventHandler(ByVal sender As Object, ByVal e As DemandRequestV2CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class DemandRequestV2CompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub ManagedListRequestCompletedEventHandler(ByVal sender As Object, ByVal e As ManagedListRequestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ManagedListRequestCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub PropertyRequestCompletedEventHandler(ByVal sender As Object, ByVal e As PropertyRequestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class PropertyRequestCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")>  _
    Public Delegate Sub ResaleOrderCompletedEventHandler(ByVal sender As Object, ByVal e As ResaleOrderCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ResaleOrderCompletedEventArgs
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