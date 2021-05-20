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

Namespace [Shared]
    Partial Public Class MainLayout
        Inherits LayoutComponentBase

        Protected Overrides Sub BuildRenderTree(ByVal __builder As Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder)
            __builder.OpenElement(0, "div")
            __builder.AddAttribute(1, "class", "page")
            __builder.AddAttribute(2, "b-1llmwwk7gd")
            __builder.OpenElement(3, "div")
            __builder.AddAttribute(4, "class", "sidebar")
            __builder.AddAttribute(5, "b-1llmwwk7gd")
            __builder.OpenComponent(Of [Shared].NavMenu)(6)
            __builder.CloseComponent()
            __builder.CloseElement()
            __builder.AddMarkupContent(7, vbCrLf & vbCrLf & "    ")
            __builder.OpenElement(8, "div")
            __builder.AddAttribute(9, "class", "main")
            __builder.AddAttribute(10, "b-1llmwwk7gd")
            __builder.AddMarkupContent(11, "<div class=""top-row px-4"" b-1llmwwk7gd><a href=""http://blazor.net"" target=""_blank"" class=""ml-md-auto"" b-1llmwwk7gd>About</a></div>" & vbCrLf & vbCrLf & "        ")
            __builder.OpenElement(12, "div")
            __builder.AddAttribute(13, "class", "content px-4")
            __builder.AddAttribute(14, "b-1llmwwk7gd")
            __builder.AddContent(15, Body)
            __builder.CloseElement()
            __builder.CloseElement()
            __builder.CloseElement()
        End Sub
    End Class
End Namespace
