#pragma checksum "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a4717aae327dcdfe4bf45614ed20c1dc8c6581e"
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
#line 2 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
using Model.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoTareas")]
    public partial class ListadoTareas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Listado de Tareas</h1>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                                                        ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Nuevo");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n\n");
#nullable restore
#line 14 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
 if (tareas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 17 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
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
            __builder.AddMarkupContent(13, @"<thead>
            <tr>
                <th>Id</th>
                <th>Titulo</th>
                <th>Vencimiento</th>
                <th>Estimacion</th>
                <th>Estado</th>
                <th>Acciones</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 32 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
             foreach (var f in tareas)
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
#line 35 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                         f.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 36 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                         f.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 37 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                         f.Vencimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 38 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                         f.Estimacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 39 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                         f.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n                    ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                                                                                ()=>VerDetalleTarea(f.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Detalles");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-success");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                                                                                ()=>Editar(f.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-danger");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
                                                                               ()=>Borrar(f.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
#nullable restore
#line 46 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#nullable restore
#line 49 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\ListadoTareas.razor"
       
    /*
    private Tarea[] tarea;
    protected override async Task OnInitializedAsync()
    {
        tarea = ServicioTarea.GetTareas();
    }
    */

    private List<Tarea> tareas;

    protected override async Task OnInitializedAsync()
    {
        tareas = await ServicioTarea.GetAll();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("/EditarTarea/" + id);
    }

    protected async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar una tarea?");
        if (confirmed)
        {
            await ServicioTarea.Remove(id);
            tareas = await ServicioTarea.GetAll();
        }
    }

    protected void VerDetalleTarea(int id)
    {
        navigation.NavigateTo("/ListadoDetalles/" + id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TareaService ServicioTarea { get; set; }
    }
}
#pragma warning restore 1591
