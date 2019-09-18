// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: dolittle/timeseries/datapoints/server/data_point_stream.proto
// </auto-generated>
// Original file comments:
// ---------------------------------------------------------------------------------------------
//  Copyright (c) Dolittle. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// --------------------------------------------------------------------------------------------
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server {
  /// <summary>
  /// Represents the service for working with data point processors that are stream based
  /// </summary>
  public static partial class DataPointStream
  {
    static readonly string __ServiceName = "dolittle.timeseries.datapoints.server.DataPointStream";

    static readonly grpc::Marshaller<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint> __Marshaller_dolittle_timeseries_datatypes_DataPoint = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Open = new grpc::Method<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "Open",
        __Marshaller_dolittle_timeseries_datatypes_DataPoint,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointStreamReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DataPointStream</summary>
    [grpc::BindServiceMethod(typeof(DataPointStream), "BindService")]
    public abstract partial class DataPointStreamBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Open(grpc::IAsyncStreamReader<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DataPointStream</summary>
    public partial class DataPointStreamClient : grpc::ClientBase<DataPointStreamClient>
    {
      /// <summary>Creates a new client for DataPointStream</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DataPointStreamClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DataPointStream that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DataPointStreamClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DataPointStreamClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DataPointStreamClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncClientStreamingCall<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint, global::Google.Protobuf.WellKnownTypes.Empty> Open(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Open(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint, global::Google.Protobuf.WellKnownTypes.Empty> Open(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_Open, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DataPointStreamClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DataPointStreamClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DataPointStreamBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Open, serviceImpl.Open).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DataPointStreamBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Open, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Open));
    }

  }
}
#endregion
