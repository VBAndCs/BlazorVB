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
Imports BlazorVB.Shared

Partial Public Class App
    Inherits Microsoft.AspNetCore.Components.ComponentBase

    Protected Overrides Sub BuildRenderTree(ByVal __builder As Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder)
        __builder.OpenComponent(Of Microsoft.AspNetCore.Components.Routing.Router)(0)
        __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck(Of System.Reflection.Assembly)(GetType(Program).Assembly))
        __builder.AddAttribute(2, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck(Of System.Boolean)(True))
        __builder.AddAttribute(3, "Found", CType((
                                   Function(routeData)
                                       Return Sub(__builder2)
                                                  __builder2.OpenComponent(Of Microsoft.AspNetCore.Components.RouteView)(4)
                                                  __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck(Of Microsoft.AspNetCore.Components.RouteData)(routeData))
                                                  __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck(Of System.Type)(GetType(MainLayout)))
                                                  __builder2.CloseComponent()
                                              End Sub
                                   End Function), Microsoft.AspNetCore.Components.RenderFragment(Of Microsoft.AspNetCore.Components.RouteData)))
        __builder.AddAttribute(7, "NotFound", CType((
                               Sub(__builder2)
                                   __builder2.OpenComponent(Of Microsoft.AspNetCore.Components.LayoutView)(8)
                                   __builder2.AddAttribute(9, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck(Of System.Type)(GetType(MainLayout)))
                                   __builder2.AddAttribute(10, "ChildContent", CType((
                                                                                     Sub(__builder3)
                                                                                         __builder3.AddMarkupContent(11, "<p>Sorry, there's nothing at this address.</p>")
                                                                                     End Sub), Microsoft.AspNetCore.Components.RenderFragment))
                                   __builder2.CloseComponent()
                               End Sub), Microsoft.AspNetCore.Components.RenderFragment))
        __builder.CloseComponent()
    End Sub
End Class
