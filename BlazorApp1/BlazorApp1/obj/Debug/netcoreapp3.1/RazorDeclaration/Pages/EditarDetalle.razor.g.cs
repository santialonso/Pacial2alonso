#pragma checksum "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\EditarDetalle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f067b07df19573fb21e5ea66c5ef590ec269a5e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\EditarDetalle.razor"
using Model.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\EditarDetalle.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Editardetalle/{id:int}/TareaId/{TareaId:int}")]
    public partial class EditarDetalle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\360\Desktop\20201013_Parcial_2\BlazorApp1\BlazorApp1\Pages\EditarDetalle.razor"
       
    [Parameter]
    public int Id { get; set; }
    [Parameter]
    public int TareaId { get; set; }

    public Detalle Detalle { get; set; } = new Detalle();

    public string Recurso { get; set; }

    public string Tarea { get; set; }


    private List<Recurso> Recursos;

    private List<Tarea> Tareas;


    protected override async Task OnInitializedAsync()
    {
        Tarea = TareaId.ToString();
        if (Id > 0)
        {
            Detalle = await service.Get(Id);
            Recurso = Detalle.RecursoId.ToString();

        }
        else
        {
            Detalle = new Detalle();
            Detalle.TareaId = TareaId;
        }
        Recursos = await servicerecurso.GetAll();
        Tareas = await servicetarea.GetAll();
    }


    private async void Guardar()
    {
        Detalle.RecursoId = int.Parse(Recurso);
        Detalle.TareaId = int.Parse(Tarea);
        await service.Save(Detalle);
        navigation.NavigateTo("/ListadoDetalles/"+TareaId);
    }

    //Usuario:<InputNumber @bind-Value="Recurso.Usuario" />

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TareaService servicetarea { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursoService servicerecurso { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetalleService service { get; set; }
    }
}
#pragma warning restore 1591