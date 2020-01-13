Module cmdModARVMS
    Sub Nain()

        Dim results As String
        Dim XChangeRequest As New ARVMSXChangeAPI

        results = XChangeRequest.InformationBit("Owner")
        Console.WriteLine(results)
        results = XChangeRequest.InformationBit("PropertyData")
        Console.WriteLine(results)
        results = XChangeRequest.InformationBit("Orders")
        Console.WriteLine(results)

    End Sub

End Module
