#pragma checksum "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be954ffeb75fa321125b408cee85e10b4a42bf08"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
using Model.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listadoUsuarios")]
    public partial class ListadoUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Listado de Usuarios</h1>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
                                                        ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Nuevo");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n\n\n");
#nullable restore
#line 14 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
 if (usuarios == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 17 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddMarkupContent(13, "<thead>\n            <tr>\n                <th>Id</th>\n                <th>Nombre</th>\n                <th>Acciones</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 29 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
             foreach (var item in usuarios)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 33 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
                         item.User

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-success");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
                                                                                ()=>Editar(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Editar");
            __builder.CloseElement();
            __builder.AddContent(31, " ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-danger");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
                                                                                                                                                                            ()=>Borrar(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n");
#nullable restore
#line 36 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
#nullable restore
#line 39 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoUsuarios.razor"
       
    /*
    private Usuario[] usuario;
    protected override async Task OnInitializedAsync()
    {
        usuario = ServicioUsuario.GetUsuarios();
    }*/
    private List<Usuario> usuarios;

    protected override async Task OnInitializedAsync()
    {
        usuarios = await ServicioUsuario.GetAll();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("/EditarUsuario/" + id);
    }

    protected async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el usuario?");
        if (confirmed)
        {
            await ServicioUsuario.Remove(id);
            usuarios = await ServicioUsuario.GetAll();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioService ServicioUsuario { get; set; }
    }
}
#pragma warning restore 1591
