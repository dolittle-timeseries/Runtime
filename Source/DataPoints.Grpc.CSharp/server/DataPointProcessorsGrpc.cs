// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: dolittle/timeseries/datapoints/server/data_point_processors.proto
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
  public static partial class DataPointProcessors
  {
    static readonly string __ServiceName = "dolittle.timeseries.datapoints.server.DataPointProcessors";

    static readonly grpc::Marshaller<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor> __Marshaller_dolittle_timeseries_datapoints_server_DataPointProcessor = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint> __Marshaller_dolittle_timeseries_datatypes_DataPoint = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint.Parser.ParseFrom);

    static readonly grpc::Method<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor, global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint> __Method_Open = new grpc::Method<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor, global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Open",
        __Marshaller_dolittle_timeseries_datapoints_server_DataPointProcessor,
        __Marshaller_dolittle_timeseries_datatypes_DataPoint);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessorsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DataPointProcessors</summary>
    [grpc::BindServiceMethod(typeof(DataPointProcessors), "BindService")]
    public abstract partial class DataPointProcessorsBase
    {
      public virtual global::System.Threading.Tasks.Task Open(global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor request, grpc::IServerStreamWriter<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DataPointProcessors</summary>
    public partial class DataPointProcessorsClient : grpc::ClientBase<DataPointProcessorsClient>
    {
      /// <summary>Creates a new client for DataPointProcessors</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DataPointProcessorsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DataPointProcessors that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DataPointProcessorsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DataPointProcessorsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DataPointProcessorsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint> Open(global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Open(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint> Open(global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Open, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DataPointProcessorsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DataPointProcessorsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DataPointProcessorsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Open, serviceImpl.Open).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DataPointProcessorsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Open, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointProcessor, global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint>(serviceImpl.Open));
    }

  }
}
#endregion
