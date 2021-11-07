// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaSourceAppServiceConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Enables the implementation of an app service that provides a custom media source that can be consumed by UWP apps.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Activatable(typeof (IMediaSourceAppServiceConnectionFactory), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaSourceAppServiceConnection : IMediaSourceAppServiceConnection
  {
    /// <summary>Initializes a new instance of the **MediaSourceAppServiceConnection** class.</summary>
    /// <param name="appServiceConnection">An AppServiceConnection object representing the connection to the endpoint for an app service.</param>
    [MethodImpl]
    public extern MediaSourceAppServiceConnection(AppServiceConnection appServiceConnection);

    /// <summary>Raised by the system to request the initialization of a new MediaStreamSource.</summary>
    public extern event TypedEventHandler<MediaSourceAppServiceConnection, InitializeMediaStreamSourceRequestedEventArgs> InitializeMediaStreamSourceRequested;

    /// <summary>Notifies the system that the app service is ready to receive media stream source requests.</summary>
    [MethodImpl]
    public extern void Start();
  }
}
