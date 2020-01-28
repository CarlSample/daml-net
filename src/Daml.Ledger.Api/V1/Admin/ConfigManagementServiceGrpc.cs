// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/admin/config_management_service.proto
// </auto-generated>
// Original file comments:
// Copyright (c) 2019 The DAML Authors. All rights reserved.
// SPDX-License-Identifier: Apache-2.0
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Com.DigitalAsset.Ledger.Api.V1.Admin {
  /// <summary>
  /// Ledger configuration management service provides methods for the ledger administrator
  /// to change the current ledger configuration. The services provides methods to modify
  /// different aspects of the configuration.
  /// </summary>
  public static partial class ConfigManagementService
  {
    static readonly string __ServiceName = "com.digitalasset.ledger.api.v1.admin.ConfigManagementService";

    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest> __Marshaller_com_digitalasset_ledger_api_v1_admin_GetTimeModelRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse> __Marshaller_com_digitalasset_ledger_api_v1_admin_GetTimeModelResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest> __Marshaller_com_digitalasset_ledger_api_v1_admin_SetTimeModelRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse> __Marshaller_com_digitalasset_ledger_api_v1_admin_SetTimeModelResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse> __Method_GetTimeModel = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTimeModel",
        __Marshaller_com_digitalasset_ledger_api_v1_admin_GetTimeModelRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_admin_GetTimeModelResponse);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse> __Method_SetTimeModel = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetTimeModel",
        __Marshaller_com_digitalasset_ledger_api_v1_admin_SetTimeModelRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_admin_SetTimeModelResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.ConfigManagementServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ConfigManagementService</summary>
    [grpc::BindServiceMethod(typeof(ConfigManagementService), "BindService")]
    public abstract partial class ConfigManagementServiceBase
    {
      /// <summary>
      /// Return the currently active time model and the current configuration generation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse> GetTimeModel(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Set the ledger time model.
      /// In case of failure this method responds with:
      /// - INVALID_ARGUMENT if arguments are invalid, or the provided configuration generation
      ///   does not match the current active configuration generation. The caller is expected
      ///   to retry by again fetching current time model using 'GetTimeModel', applying changes
      ///   and resubmitting.
      /// - ABORTED if the request is rejected or times out. Note that a timed out request may
      ///   have still been committed to the ledger. Application should re-query the current
      ///   time model before retrying.
      /// - UNIMPLEMENTED if this method is not supported by the backing ledger.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse> SetTimeModel(global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ConfigManagementService</summary>
    public partial class ConfigManagementServiceClient : grpc::ClientBase<ConfigManagementServiceClient>
    {
      /// <summary>Creates a new client for ConfigManagementService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ConfigManagementServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ConfigManagementService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ConfigManagementServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ConfigManagementServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ConfigManagementServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Return the currently active time model and the current configuration generation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse GetTimeModel(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTimeModel(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Return the currently active time model and the current configuration generation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse GetTimeModel(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTimeModel, null, options, request);
      }
      /// <summary>
      /// Return the currently active time model and the current configuration generation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse> GetTimeModelAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTimeModelAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Return the currently active time model and the current configuration generation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse> GetTimeModelAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTimeModel, null, options, request);
      }
      /// <summary>
      /// Set the ledger time model.
      /// In case of failure this method responds with:
      /// - INVALID_ARGUMENT if arguments are invalid, or the provided configuration generation
      ///   does not match the current active configuration generation. The caller is expected
      ///   to retry by again fetching current time model using 'GetTimeModel', applying changes
      ///   and resubmitting.
      /// - ABORTED if the request is rejected or times out. Note that a timed out request may
      ///   have still been committed to the ledger. Application should re-query the current
      ///   time model before retrying.
      /// - UNIMPLEMENTED if this method is not supported by the backing ledger.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse SetTimeModel(global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetTimeModel(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Set the ledger time model.
      /// In case of failure this method responds with:
      /// - INVALID_ARGUMENT if arguments are invalid, or the provided configuration generation
      ///   does not match the current active configuration generation. The caller is expected
      ///   to retry by again fetching current time model using 'GetTimeModel', applying changes
      ///   and resubmitting.
      /// - ABORTED if the request is rejected or times out. Note that a timed out request may
      ///   have still been committed to the ledger. Application should re-query the current
      ///   time model before retrying.
      /// - UNIMPLEMENTED if this method is not supported by the backing ledger.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse SetTimeModel(global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetTimeModel, null, options, request);
      }
      /// <summary>
      /// Set the ledger time model.
      /// In case of failure this method responds with:
      /// - INVALID_ARGUMENT if arguments are invalid, or the provided configuration generation
      ///   does not match the current active configuration generation. The caller is expected
      ///   to retry by again fetching current time model using 'GetTimeModel', applying changes
      ///   and resubmitting.
      /// - ABORTED if the request is rejected or times out. Note that a timed out request may
      ///   have still been committed to the ledger. Application should re-query the current
      ///   time model before retrying.
      /// - UNIMPLEMENTED if this method is not supported by the backing ledger.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse> SetTimeModelAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetTimeModelAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Set the ledger time model.
      /// In case of failure this method responds with:
      /// - INVALID_ARGUMENT if arguments are invalid, or the provided configuration generation
      ///   does not match the current active configuration generation. The caller is expected
      ///   to retry by again fetching current time model using 'GetTimeModel', applying changes
      ///   and resubmitting.
      /// - ABORTED if the request is rejected or times out. Note that a timed out request may
      ///   have still been committed to the ledger. Application should re-query the current
      ///   time model before retrying.
      /// - UNIMPLEMENTED if this method is not supported by the backing ledger.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse> SetTimeModelAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetTimeModel, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ConfigManagementServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ConfigManagementServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ConfigManagementServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetTimeModel, serviceImpl.GetTimeModel)
          .AddMethod(__Method_SetTimeModel, serviceImpl.SetTimeModel).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ConfigManagementServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetTimeModel, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse>(serviceImpl.GetTimeModel));
      serviceBinder.AddMethod(__Method_SetTimeModel, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse>(serviceImpl.SetTimeModel));
    }

  }
}
#endregion