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
    <Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")>
    Partial Public Class FetchData
        Inherits Microsoft.AspNetCore.Components.ComponentBase

        Protected Overrides Sub BuildRenderTree(ByVal __builder As Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder)
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>" & vbCrLf & vbCrLf)
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>")

            If forecasts Is Nothing Then
                __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>")
            Else
                __builder.OpenElement(3, "table")
                __builder.AddAttribute(4, "class", "table")
                __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>" & vbCrLf & "                <th>Temp. (C)</th>" & vbCrLf & "                <th>Temp. (F)</th>" & vbCrLf & "                <th>Summary</th></tr></thead>" & vbCrLf & "        ")
                __builder.OpenElement(6, "tbody")

                For Each forecast In forecasts
                    __builder.OpenElement(7, "tr")
                    __builder.OpenElement(8, "td")
                    __builder.AddContent(9, forecast.Date.ToShortDateString())
                    __builder.CloseElement()
                    __builder.AddMarkupContent(10, vbCrLf & "                    ")
                    __builder.OpenElement(11, "td")
                    __builder.AddContent(12, forecast.TemperatureC)
                    __builder.CloseElement()
                    __builder.AddMarkupContent(13, vbCrLf & "                    ")
                    __builder.OpenElement(14, "td")
                    __builder.AddContent(15, forecast.TemperatureF)
                    __builder.CloseElement()
                    __builder.AddMarkupContent(16, vbCrLf & "                    ")
                    __builder.OpenElement(17, "td")
                    __builder.AddContent(18, forecast.Summary)
                    __builder.CloseElement()
                    __builder.CloseElement()
                Next

                __builder.CloseElement()
                __builder.CloseElement()
            End If
        End Sub

        Private forecasts As WeatherForecast()

        Protected Overrides Async Function OnInitializedAsync() As Task
            forecasts = Await Http.GetFromJsonAsync(Of WeatherForecast())("sample-data/weather.json")
        End Function

        Public Class WeatherForecast
            Public Property [Date] As DateTime
            Public Property TemperatureC As Integer
            Public Property Summary As String

            Public ReadOnly Property TemperatureF As Integer
                Get
                    Return 32 + CInt((TemperatureC / 0.5556))
                End Get
            End Property
        End Class

        <Microsoft.AspNetCore.Components.InjectAttribute>
        Private Property Http As HttpClient
    End Class


End Namespace
