﻿' <auto-generated/>
' TODO: Check VB does not support Line Directive Trivia, Original Directive #line hidden    Imports System
Imports Microsoft.AspNetCore.Components
Imports Microsoft.AspNetCore.Components.Routing
Imports Microsoft.AspNetCore.Components.Web

Namespace [Shared]
    Partial Public Class NavMenu
        Inherits ComponentBase
        Private Sub __RazorDirectiveTokenHelpers__()
        End Sub
        Private Shared __o As Object = Nothing
        Protected Overrides Sub BuildRenderTree(ByVal __builder As Rendering.RenderTreeBuilder)
            __o = EventCallback.Factory.Create(Of MouseEventArgs)(Me, New Action(AddressOf ToggleNavMenu))
            __o = ""
            __o = ""
            __o = CompilerServices.RuntimeHelpers.TypeCheck(NavLinkMatch.All)
            __builder.AddAttribute(-1, "ChildContent", CType(Sub(__builder2)
                                                             End Sub, RenderFragment))
            __o = GetType(NavLink)
            __o = ""
            __o = ""
            __builder.AddAttribute(-1, "ChildContent", CType(Sub(__builder2)
                                                             End Sub, RenderFragment))
            __o = GetType(NavLink)
            __o = ""
            __o = ""
            __builder.AddAttribute(-1, "ChildContent", CType(Sub(__builder2)
                                                             End Sub, RenderFragment))
            __o = GetType(NavLink)
            __o = NavMenuCssClass
            __o = EventCallback.Factory.Create(Of MouseEventArgs)(Me, New Action(AddressOf ToggleNavMenu))
        End Sub
        Private collapseNavMenu As Boolean = True

        Private ReadOnly Property NavMenuCssClass As String
            Get
                Return If(collapseNavMenu, "collapse", Nothing)
            End Get
        End Property

        Private Sub ToggleNavMenu()
            collapseNavMenu = Not collapseNavMenu
        End Sub
    End Class
End Namespace