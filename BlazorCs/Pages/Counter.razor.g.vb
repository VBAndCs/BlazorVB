Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Components
Imports System.Net.Http
Imports System.Net.Http.Json
Imports Microsoft.AspNetCore.Components.Forms
Imports Microsoft.AspNetCore.Components.Routing
Imports Microsoft.AspNetCore.Components.Web
Imports Microsoft.AspNetCore.Components.Web.Virtualization
Imports Microsoft.AspNetCore.Components.WebAssembly.Http
Imports Microsoft.JSInterop

Namespace Pages
    <Microsoft.AspNetCore.Components.RouteAttribute("/counter")>
    Partial Public Class Counter
        Inherits Microsoft.AspNetCore.Components.ComponentBase

        Protected Overrides Sub BuildRenderTree(ByVal __builder As Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder)
            __builder.AddMarkupContent(0, "<h1>Counter</h1>" & vbCrLf & vbCrLf)
            __builder.OpenElement(1, "p")
            __builder.AddContent(2, "Current count: ")
            __builder.AddContent(3, currentCount)
            __builder.CloseElement()
            __builder.AddMarkupContent(4, vbCrLf & vbCrLf)
            __builder.OpenElement(5, "button")
            __builder.AddAttribute(6, "class", "btn btn-primary")
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create(Of Microsoft.AspNetCore.Components.Web.MouseEventArgs)(Me, AddressOf IncrementCount))
            __builder.AddContent(8, "Click me")
            __builder.CloseElement()
        End Sub

        Private currentCount As Integer = 0

        Private Sub IncrementCount()
            currentCount += 1
        End Sub
    End Class
End Namespace
