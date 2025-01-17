﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using BlazorApp1.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace BlazorApp1.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace BlazorApp1.Data
{
    using global::Model.Entidades;
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIRemoteService : IRemoteService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIRemoteService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<Usuario>> IRemoteService.GetAllUsuarios()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllUsuarios", new Type[] {  });
            return (Task<List<Usuario>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> IRemoteService.GetUsuario(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUsuario", new Type[] { typeof(int) });
            return (Task<Usuario>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> IRemoteService.DeleteUsuario(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteUsuario", new Type[] { typeof(int) });
            return (Task<Usuario>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> IRemoteService.CreateUsuario(Usuario usuario)
        {
            var arguments = new object[] { usuario };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreateUsuario", new Type[] { typeof(Usuario) });
            return (Task<Usuario>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> IRemoteService.EditUsuario(Usuario usuario)
        {
            var arguments = new object[] { usuario };
            var func = requestBuilder.BuildRestResultFuncForMethod("EditUsuario", new Type[] { typeof(Usuario) });
            return (Task<Usuario>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Tarea>> IRemoteService.GetAllTareas()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllTareas", new Type[] {  });
            return (Task<List<Tarea>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tarea> IRemoteService.GetTarea(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetTarea", new Type[] { typeof(int) });
            return (Task<Tarea>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tarea> IRemoteService.DeleteTarea(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteTarea", new Type[] { typeof(int) });
            return (Task<Tarea>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tarea> IRemoteService.CreateTarea(Tarea tarea)
        {
            var arguments = new object[] { tarea };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreateTarea", new Type[] { typeof(Tarea) });
            return (Task<Tarea>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tarea> IRemoteService.EditTarea(Tarea tarea)
        {
            var arguments = new object[] { tarea };
            var func = requestBuilder.BuildRestResultFuncForMethod("EditTarea", new Type[] { typeof(Tarea) });
            return (Task<Tarea>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Recurso>> IRemoteService.GetAllRecursos()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllRecursos", new Type[] {  });
            return (Task<List<Recurso>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recurso> IRemoteService.GetRecurso(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetRecurso", new Type[] { typeof(int) });
            return (Task<Recurso>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recurso> IRemoteService.DeleteRecurso(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteRecurso", new Type[] { typeof(int) });
            return (Task<Recurso>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recurso> IRemoteService.CreateRecurso(Recurso recurso)
        {
            var arguments = new object[] { recurso };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreateRecurso", new Type[] { typeof(Recurso) });
            return (Task<Recurso>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recurso> IRemoteService.EditRecurso(Recurso recurso)
        {
            var arguments = new object[] { recurso };
            var func = requestBuilder.BuildRestResultFuncForMethod("EditRecurso", new Type[] { typeof(Recurso) });
            return (Task<Recurso>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Detalle>> IRemoteService.GetAllDetalles(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllDetalles", new Type[] { typeof(int) });
            return (Task<List<Detalle>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalle> IRemoteService.GetDetalle(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetDetalle", new Type[] { typeof(int) });
            return (Task<Detalle>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalle> IRemoteService.DeleteDetalle(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteDetalle", new Type[] { typeof(int) });
            return (Task<Detalle>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalle> IRemoteService.CreateDetalle(Detalle detalle)
        {
            var arguments = new object[] { detalle };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreateDetalle", new Type[] { typeof(Detalle) });
            return (Task<Detalle>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalle> IRemoteService.EditDetalle(Detalle detalle)
        {
            var arguments = new object[] { detalle };
            var func = requestBuilder.BuildRestResultFuncForMethod("EditDetalle", new Type[] { typeof(Detalle) });
            return (Task<Detalle>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
