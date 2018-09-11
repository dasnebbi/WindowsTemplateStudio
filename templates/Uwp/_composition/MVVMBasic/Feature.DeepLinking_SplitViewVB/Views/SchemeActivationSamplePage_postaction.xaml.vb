﻿Namespace Views
    Public NotInheritable Partial Class SchemeActivationSamplePage
        Inherits Page
'{[{
        Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
            MyBase.OnNavigatedTo(e)
            If e.Parameter IsNot Nothing Then
                Dim parameters = TryCast(e.Parameter, Dictionary(Of String, String))
                ViewModel.Initialize(parameters)
            End If
        End Sub
'}]}
    End Class
End Namespace

