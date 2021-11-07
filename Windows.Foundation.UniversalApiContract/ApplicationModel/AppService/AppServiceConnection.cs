// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.System.RemoteSystems;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Represents a connection to the endpoint for an app service. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAppServiceConnectionStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppServiceConnection : IAppServiceConnection, IAppServiceConnection2, IClosable
  {
    /// <summary>Creates and initializes a new instance of the AppServiceConnection class.</summary>
    [MethodImpl]
    public extern AppServiceConnection();

    /// <summary>Gets or sets the name of the app service to which you want to connect.</summary>
    /// <returns>The name of the app service to which you want to connect.</returns>
    public extern string AppServiceName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the package family name for the package that contains the endpoint for the app service.</summary>
    /// <returns>The package family name for the package that contains the endpoint for the app service.</returns>
    public extern string PackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Opens a connection to the endpoint for the app service.</summary>
    /// <returns>An asynchronous operation to open a connection to the endpoint for the app service.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppServiceConnectionStatus> OpenAsync();

    /// <summary>Sends a message to the other endpoint of the app service connection.</summary>
    /// <param name="message">The message that you want to send.</param>
    /// <returns>An asynchronous operation to send the message that optionally returns a response message when complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppServiceResponse> SendMessageAsync(
      ValueSet message);

    /// <summary>Occurs when a message arrives from the other endpoint of the app service connection.</summary>
    public extern event TypedEventHandler<AppServiceConnection, AppServiceRequestReceivedEventArgs> RequestReceived;

    /// <summary>Occurs when the other endpoint closes the connection to the app service.</summary>
    public extern event TypedEventHandler<AppServiceConnection, AppServiceClosedEventArgs> ServiceClosed;

    /// <summary>Opens a connection to the endpoint on another device for the app service.</summary>
    /// <param name="remoteSystemConnectionRequest">Specifies the connection preferences for the AppServiceConnection, such as transport preferences (cloud/proximal/any) as well as the target System.RemoteSystems object.</param>
    /// <returns>An asynchronous operation to open a connection to the endpoint for the app service on another device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppServiceConnectionStatus> OpenRemoteAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest);

    /// <summary>Gets/sets the user context. This property returns **null** if the caller did not specify a user.</summary>
    /// <returns>The user of the app service.</returns>
    public extern User User { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Opens an app service connection, sends a single message, waits for a single response, and then closes the connection.</summary>
    /// <param name="connection">The app service to connect to.</param>
    /// <param name="connectionRequest">Specifies the connection preferences for the AppServiceConnection, such as transport preferences (cloud/proximal/any) as well as the target System.RemoteSystems object.</param>
    /// <param name="message">The message that you want to send.</param>
    /// <returns>An asynchronous operation to send the message that optionally returns a response message when complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StatelessAppServiceResponse> SendStatelessMessageAsync(
      AppServiceConnection connection,
      RemoteSystemConnectionRequest connectionRequest,
      ValueSet message);
  }
}
