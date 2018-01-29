﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Xunit;
using Nustache;
using Nustache.Core;
using Refit;
using Refit.Generator;
using Task =  System.Threading.Tasks.Task;
using System.Net;
using System.Reactive.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RichardSzalay.MockHttp;
using static System.Math;
using SomeType =  CollisionA.SomeType;
using CollisionB;
using System.Reflection;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace RefitInternalGenerated
{
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

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIAmARefitInterfaceButNobodyUsesMe : IAmARefitInterfaceButNobodyUsesMe
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIAmARefitInterfaceButNobodyUsesMe(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task RefitMethod()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("RefitMethod()", _ => requestBuilder.BuildRestResultFuncForMethod("RefitMethod", new Type[] {  }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task AnotherRefitMethod()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("AnotherRefitMethod()", _ => requestBuilder.BuildRestResultFuncForMethod("AnotherRefitMethod", new Type[] {  }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NoConstantsAllowed()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

        /// <inheritdoc />
        public virtual Task SpacesShouldntBreakMe()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("SpacesShouldntBreakMe()", _ => requestBuilder.BuildRestResultFuncForMethod("SpacesShouldntBreakMe", new Type[] {  }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task ReservedWordsForParameterNames(int @int,string @string,float @long)
        {
            var arguments = new object[] { @int,@string,@long };
            var func = methodImpls.GetOrAdd("ReservedWordsForParameterNames(int @int,string @string,float @long)", _ => requestBuilder.BuildRestResultFuncForMethod("ReservedWordsForParameterNames", new Type[] { typeof(int),typeof(string),typeof(float) }));
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIAmHalfRefit : IAmHalfRefit
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIAmHalfRefit(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("Post()", _ => requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIApiWithDecimal : IApiWithDecimal
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIApiWithDecimal(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<string> GetWithDecimal(decimal value)
        {
            var arguments = new object[] { value };
            var func = methodImpls.GetOrAdd("GetWithDecimal(decimal value)", _ => requestBuilder.BuildRestResultFuncForMethod("GetWithDecimal", new Type[] { typeof(decimal) }));
            return (Task<string>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIBoringCrudApi<T, TKey> : IBoringCrudApi<T, TKey>
        where T : class
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIBoringCrudApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<T> Create(T paylod)
        {
            var arguments = new object[] { paylod };
            var func = methodImpls.GetOrAdd("Create(T paylod)", _ => requestBuilder.BuildRestResultFuncForMethod("Create", new Type[] { typeof(T) }));
            return (Task<T>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<T>> ReadAll()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("ReadAll()", _ => requestBuilder.BuildRestResultFuncForMethod("ReadAll", new Type[] {  }));
            return (Task<List<T>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<T> ReadOne(TKey key)
        {
            var arguments = new object[] { key };
            var func = methodImpls.GetOrAdd("ReadOne(TKey key)", _ => requestBuilder.BuildRestResultFuncForMethod("ReadOne", new Type[] { typeof(TKey) }));
            return (Task<T>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Update(TKey key,T payload)
        {
            var arguments = new object[] { key,payload };
            var func = methodImpls.GetOrAdd("Update(TKey key,T payload)", _ => requestBuilder.BuildRestResultFuncForMethod("Update", new Type[] { typeof(TKey),typeof(T) }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Delete(TKey key)
        {
            var arguments = new object[] { key };
            var func = methodImpls.GetOrAdd("Delete(TKey key)", _ => requestBuilder.BuildRestResultFuncForMethod("Delete", new Type[] { typeof(TKey) }));
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIBrokenWebApi : IBrokenWebApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIBrokenWebApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<bool> PostAValue(string derp)
        {
            var arguments = new object[] { derp };
            var func = methodImpls.GetOrAdd("PostAValue(string derp)", _ => requestBuilder.BuildRestResultFuncForMethod("PostAValue", new Type[] { typeof(string) }));
            return (Task<bool>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIGitHubApi : IGitHubApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUser(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] { typeof(string) }));
            return (Task<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUserObservable(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUserObservable", new Type[] { typeof(string) }));
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUserCamelCase(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUserCamelCase", new Type[] { typeof(string) }));
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            var func = methodImpls.GetOrAdd("GetOrgMembers(string orgName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetOrgMembers", new Type[] { typeof(string) }));
            return (Task<List<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            var func = methodImpls.GetOrAdd("FindUsers(string q)", _ => requestBuilder.BuildRestResultFuncForMethod("FindUsers", new Type[] { typeof(string) }));
            return (Task<UserSearchResult>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("GetIndex()", _ => requestBuilder.BuildRestResultFuncForMethod("GetIndex", new Type[] {  }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("GetIndexObservable()", _ => requestBuilder.BuildRestResultFuncForMethod("GetIndexObservable", new Type[] {  }));
            return (IObservable<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("NothingToSeeHere()", _ => requestBuilder.BuildRestResultFuncForMethod("NothingToSeeHere", new Type[] {  }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<User>> GetUserWithMetadata(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUserWithMetadata(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUserWithMetadata", new Type[] { typeof(string) }));
            return (Task<ApiResponse<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<ApiResponse<User>> GetUserObservableWithMetadata(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUserObservableWithMetadata(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUserObservableWithMetadata", new Type[] { typeof(string) }));
            return (IObservable<ApiResponse<User>>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIHttpBinApi<TResponse, TParam, THeader> : IHttpBinApi<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIHttpBinApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            var func = methodImpls.GetOrAdd("Get(TParam param,THeader header)", _ => requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TParam),typeof(THeader) }));
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQuery(TParam param)
        {
            var arguments = new object[] { param };
            var func = methodImpls.GetOrAdd("GetQuery(TParam param)", _ => requestBuilder.BuildRestResultFuncForMethod("GetQuery", new Type[] { typeof(TParam) }));
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQueryWithIncludeParameterName(TParam param)
        {
            var arguments = new object[] { param };
            var func = methodImpls.GetOrAdd("GetQueryWithIncludeParameterName(TParam param)", _ => requestBuilder.BuildRestResultFuncForMethod("GetQueryWithIncludeParameterName", new Type[] { typeof(TParam) }));
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TValue> GetQuery1<TValue>(TParam param)
        {
            var arguments = new object[] { param };
            var func = methodImpls.GetOrAdd("GetQuery1<TValue>(TParam param)", _ => requestBuilder.BuildRestResultFuncForMethod("GetQuery1", new Type[] { typeof(TParam) }, new Type[] { typeof(TValue) }));
            return (Task<TValue>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIHttpContentApi : IHttpContentApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIHttpContentApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<HttpContent> PostFileUpload(HttpContent content)
        {
            var arguments = new object[] { content };
            var func = methodImpls.GetOrAdd("PostFileUpload(HttpContent content)", _ => requestBuilder.BuildRestResultFuncForMethod("PostFileUpload", new Type[] { typeof(HttpContent) }));
            return (Task<HttpContent>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<HttpContent>> PostFileUploadWithMetadata(HttpContent content)
        {
            var arguments = new object[] { content };
            var func = methodImpls.GetOrAdd("PostFileUploadWithMetadata(HttpContent content)", _ => requestBuilder.BuildRestResultFuncForMethod("PostFileUploadWithMetadata", new Type[] { typeof(HttpContent) }));
            return (Task<ApiResponse<HttpContent>>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedINamespaceCollisionApi : INamespaceCollisionApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedINamespaceCollisionApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<SomeType> SomeRequest()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("SomeRequest()", _ => requestBuilder.BuildRestResultFuncForMethod("SomeRequest", new Type[] {  }));
            return (Task<SomeType>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedTestNestedINestedGitHubApi : TestNested.INestedGitHubApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedTestNestedINestedGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUser(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] { typeof(string) }));
            return (Task<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUserObservable(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUserObservable", new Type[] { typeof(string) }));
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            var func = methodImpls.GetOrAdd("GetUserCamelCase(string userName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetUserCamelCase", new Type[] { typeof(string) }));
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            var func = methodImpls.GetOrAdd("GetOrgMembers(string orgName)", _ => requestBuilder.BuildRestResultFuncForMethod("GetOrgMembers", new Type[] { typeof(string) }));
            return (Task<List<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            var func = methodImpls.GetOrAdd("FindUsers(string q)", _ => requestBuilder.BuildRestResultFuncForMethod("FindUsers", new Type[] { typeof(string) }));
            return (Task<UserSearchResult>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("GetIndex()", _ => requestBuilder.BuildRestResultFuncForMethod("GetIndex", new Type[] {  }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("GetIndexObservable()", _ => requestBuilder.BuildRestResultFuncForMethod("GetIndexObservable", new Type[] {  }));
            return (IObservable<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("NothingToSeeHere()", _ => requestBuilder.BuildRestResultFuncForMethod("NothingToSeeHere", new Type[] {  }));
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedINonGenericInterfaceWithGenericMethod : INonGenericInterfaceWithGenericMethod
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedINonGenericInterfaceWithGenericMethod(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task PostMessage<T>(T message)
            where T : IMessage
        {
            var arguments = new object[] { message };
            var func = methodImpls.GetOrAdd("PostMessage<T>(T message)", _ => requestBuilder.BuildRestResultFuncForMethod("PostMessage", new Type[] { typeof(T) }, new Type[] { typeof(T) }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task PostMessage<T, U, V>(T message,U param1,V param2)
            where T : IMessage where U : T
        {
            var arguments = new object[] { message,param1,param2 };
            var func = methodImpls.GetOrAdd("PostMessage<T, U, V>(T message,U param1,V param2)", _ => requestBuilder.BuildRestResultFuncForMethod("PostMessage", new Type[] { typeof(T),typeof(U),typeof(V) }, new Type[] { typeof(T), typeof(U), typeof(V) }));
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedINpmJs : INpmJs
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedINpmJs(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<RootObject> GetCongruence()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("GetCongruence()", _ => requestBuilder.BuildRestResultFuncForMethod("GetCongruence", new Type[] {  }));
            return (Task<RootObject>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIRequestBin : IRequestBin
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIRequestBin(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("Post()", _ => requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  }));
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task PostGeneric<T>(T param)
        {
            var arguments = new object[] { param };
            var func = methodImpls.GetOrAdd("PostGeneric<T>(T param)", _ => requestBuilder.BuildRestResultFuncForMethod("PostGeneric", new Type[] { typeof(T) }, new Type[] { typeof(T) }));
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIRunscopeApi : IRunscopeApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIRunscopeApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStream(Stream stream)
        {
            var arguments = new object[] { stream };
            var func = methodImpls.GetOrAdd("UploadStream(Stream stream)", _ => requestBuilder.BuildRestResultFuncForMethod("UploadStream", new Type[] { typeof(Stream) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStreamPart(StreamPart stream)
        {
            var arguments = new object[] { stream };
            var func = methodImpls.GetOrAdd("UploadStreamPart(StreamPart stream)", _ => requestBuilder.BuildRestResultFuncForMethod("UploadStreamPart", new Type[] { typeof(StreamPart) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytes(byte[] bytes)
        {
            var arguments = new object[] { bytes };
            var func = methodImpls.GetOrAdd("UploadBytes(byte[] bytes)", _ => requestBuilder.BuildRestResultFuncForMethod("UploadBytes", new Type[] { typeof(byte[]) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytesPart(ByteArrayPart bytes)
        {
            var arguments = new object[] { bytes };
            var func = methodImpls.GetOrAdd("UploadBytesPart(ByteArrayPart bytes)", _ => requestBuilder.BuildRestResultFuncForMethod("UploadBytesPart", new Type[] { typeof(ByteArrayPart) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadString(string someString)
        {
            var arguments = new object[] { someString };
            var func = methodImpls.GetOrAdd("UploadString(string someString)", _ => requestBuilder.BuildRestResultFuncForMethod("UploadString", new Type[] { typeof(string) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            var func = methodImpls.GetOrAdd("UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)", _ => requestBuilder.BuildRestResultFuncForMethod("UploadFileInfo", new Type[] { typeof(IEnumerable<FileInfo>),typeof(FileInfo) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfoPart(IEnumerable<FileInfoPart> fileInfos,FileInfoPart anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            var func = methodImpls.GetOrAdd("UploadFileInfoPart(IEnumerable<FileInfoPart> fileInfos,FileInfoPart anotherFile)", _ => requestBuilder.BuildRestResultFuncForMethod("UploadFileInfoPart", new Type[] { typeof(IEnumerable<FileInfoPart>),typeof(FileInfoPart) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIStreamApi : IStreamApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIStreamApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<Stream> GetRemoteFile(string filename)
        {
            var arguments = new object[] { filename };
            var func = methodImpls.GetOrAdd("GetRemoteFile(string filename)", _ => requestBuilder.BuildRestResultFuncForMethod("GetRemoteFile", new Type[] { typeof(string) }));
            return (Task<Stream>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<Stream>> GetRemoteFileWithMetadata(string filename)
        {
            var arguments = new object[] { filename };
            var func = methodImpls.GetOrAdd("GetRemoteFileWithMetadata(string filename)", _ => requestBuilder.BuildRestResultFuncForMethod("GetRemoteFileWithMetadata", new Type[] { typeof(string) }));
            return (Task<ApiResponse<Stream>>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIUseOverloadedGenericMethods<TResponse, TParam, THeader> : IUseOverloadedGenericMethods<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIUseOverloadedGenericMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<string> Get()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("Get()", _ => requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  }));
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            var func = methodImpls.GetOrAdd("Get(TParam param,THeader header)", _ => requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TParam),typeof(THeader) }));
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(THeader param,TParam header)
        {
            var arguments = new object[] { param,header };
            var func = methodImpls.GetOrAdd("Get(THeader param,TParam header)", _ => requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(THeader),typeof(TParam) }));
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> Get(int httpstatuscode)
        {
            var arguments = new object[] { httpstatuscode };
            var func = methodImpls.GetOrAdd("Get(int httpstatuscode)", _ => requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(int) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIUseOverloadedMethods : IUseOverloadedMethods
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly ConcurrentDictionary<string, Func<HttpClient, object[], object>> methodImpls = new ConcurrentDictionary<string, Func<HttpClient, object[], object>>();
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIUseOverloadedMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<string> Get()
        {
            var arguments = new object[] {  };
            var func = methodImpls.GetOrAdd("Get()", _ => requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  }));
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> Get(int httpstatuscode)
        {
            var arguments = new object[] { httpstatuscode };
            var func = methodImpls.GetOrAdd("Get(int httpstatuscode)", _ => requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(int) }));
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

    }
}
