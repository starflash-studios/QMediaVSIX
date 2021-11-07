// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteLauncher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.System
{
  /// <summary>Starts the default app associated with the specified URI on a remote device.</summary>
  [Static(typeof (IRemoteLauncherStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public static class RemoteLauncher
  {
    [Overload("LaunchUriAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri);

    [Overload("LaunchUriWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri,
      RemoteLauncherOptions options);

    [Overload("LaunchUriWithDataAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri,
      RemoteLauncherOptions options,
      ValueSet inputData);
  }
}
