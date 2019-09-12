// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: dolittle/timeseries/connectors/client/stream_connector.proto
// </auto-generated>
// Original file comments:
// ---------------------------------------------------------------------------------------------
//  Copyright (c) Dolittle. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// --------------------------------------------------------------------------------------------
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client {
  /// <summary>
  /// Represents the service for working with a connector that is stream based
  /// </summary>
  public static partial class StreamConnector
  {
    static readonly string __ServiceName = "dolittle.timeseries.connectors.client.StreamConnector";

    static readonly grpc::Marshaller<global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest> __Marshaller_dolittle_timeseries_connectors_client_StreamRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dolittle.TimeSeries.DataTypes.TagDataPoint> __Marshaller_dolittle_timeseries_datatypes_TagDataPoint = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.TimeSeries.DataTypes.TagDataPoint.Parser.ParseFrom);

    static readonly grpc::Method<global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest, global::Dolittle.TimeSeries.DataTypes.TagDataPoint> __Method_Connect = new grpc::Method<global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest, global::Dolittle.TimeSeries.DataTypes.TagDataPoint>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Connect",
        __Marshaller_dolittle_timeseries_connectors_client_StreamRequest,
        __Marshaller_dolittle_timeseries_datatypes_TagDataPoint);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamConnectorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StreamConnector</summary>
    [grpc::BindServiceMethod(typeof(StreamConnector), "BindService")]
    public abstract partial class StreamConnectorBase
    {
      public virtual global::System.Threading.Tasks.Task Connect(global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest request, grpc::IServerStreamWriter<global::Dolittle.TimeSeries.DataTypes.TagDataPoint> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for StreamConnector</summary>
    public partial class StreamConnectorClient : grpc::ClientBase<StreamConnectorClient>
    {
      /// <summary>Creates a new client for StreamConnector</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StreamConnectorClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StreamConnector that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StreamConnectorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StreamConnectorClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StreamConnectorClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Dolittle.TimeSeries.DataTypes.TagDataPoint> Connect(global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Connect(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Dolittle.TimeSeries.DataTypes.TagDataPoint> Connect(global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Connect, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StreamConnectorClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StreamConnectorClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StreamConnectorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Connect, serviceImpl.Connect).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StreamConnectorBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Connect, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.StreamRequest, global::Dolittle.TimeSeries.DataTypes.TagDataPoint>(serviceImpl.Connect));
    }

  }
}
#endregion