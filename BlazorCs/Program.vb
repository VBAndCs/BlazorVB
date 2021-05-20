Imports Microsoft.AspNetCore.Components.WebAssembly.Hosting
Imports Microsoft.Extensions.DependencyInjection
Imports System
Imports System.Net.Http
Imports System.Threading.Tasks

Public Class Program
    Public Shared Sub Main(ByVal args As String())
        Dim builder = WebAssemblyHostBuilder.CreateDefault(args)
        builder.RootComponents.Add(Of App)("#app")
        builder.Services.AddScoped(Function(sp) New HttpClient With {
            .BaseAddress = New Uri(builder.HostEnvironment.BaseAddress)
        })
        Task.Run(Sub() builder.Build().RunAsync())
    End Sub
End Class
