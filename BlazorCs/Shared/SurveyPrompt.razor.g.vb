Imports Microsoft.AspNetCore.Components
Imports Microsoft.AspNetCore.Components.Rendering

Namespace [Shared]
    Public Class SurveyPrompt
        Inherits ComponentBase

        <Parameter>
        Public Property Title As String

        Protected Overrides Sub BuildRenderTree(ByVal __builder As RenderTreeBuilder)
            __builder.OpenElement(0, "div")
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4")
            __builder.AddAttribute(2, "role", "alert")
            __builder.AddMarkupContent(3, "<span class=""oi oi-pencil mr-2"" aria-hidden=""true""></span>" & vbCrLf & "    ")
            __builder.OpenElement(4, "strong")
            __builder.AddContent(5, Title)
            __builder.CloseElement()
            __builder.AddMarkupContent(6, vbCrLf & vbCrLf & "    ")
            __builder.AddMarkupContent(7, "<span class=""text-nowrap"">" & vbCrLf & "        Please take our" & vbCrLf & "        <a target=""_blank"" class=""font-weight-bold"" href=""https://go.microsoft.com/fwlink/?linkid=2137916"">brief survey</a></span>" & vbCrLf & "    and tell us what you think." & vbCrLf)
            __builder.CloseElement()
        End Sub
    End Class
End Namespace
