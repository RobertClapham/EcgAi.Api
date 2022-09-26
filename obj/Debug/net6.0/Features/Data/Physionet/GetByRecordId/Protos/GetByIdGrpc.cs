// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Features/Data/Physionet/GetByRecordId/Protos/get_by_id.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace EcgAi.Data.Api.Features.Physionet.Grpc {
  public static partial class GetByIdService
  {
    static readonly string __ServiceName = "get_by_id_service.GetByIdService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest> __Marshaller_get_by_id_service_GetByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse> __Marshaller_get_by_id_service_GetByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest, global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse> __Method_GetById = new grpc::Method<global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest, global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_get_by_id_service_GetByIdRequest,
        __Marshaller_get_by_id_service_GetByIdResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for GetByIdService</summary>
    public partial class GetByIdServiceClient : grpc::ClientBase<GetByIdServiceClient>
    {
      /// <summary>Creates a new client for GetByIdService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GetByIdServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GetByIdService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GetByIdServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GetByIdServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GetByIdServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse GetById(global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse GetById(global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse> GetByIdAsync(global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdResponse> GetByIdAsync(global::EcgAi.Data.Api.Features.Physionet.Grpc.GetByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override GetByIdServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GetByIdServiceClient(configuration);
      }
    }

  }
}
#endregion