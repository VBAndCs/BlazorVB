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
    <Microsoft.AspNetCore.Components.RouteAttribute("/")>
    Partial Public Class Index
        Inherits Microsoft.AspNetCore.Components.ComponentBase

        Protected Overrides Sub BuildRenderTree(ByVal __builder As Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder)
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>" & vbCrLf & vbCrLf & "Welcome to your new app." & vbCrLf & vbCrLf)
            __builder.OpenComponent(Of [Shared].SurveyPrompt)(1)
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?")
            __builder.CloseComponent()
        End Sub
    End Class
End Namespace
