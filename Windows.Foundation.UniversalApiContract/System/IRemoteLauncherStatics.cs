// Decompiled with JetBrains decompiler
// Type: Windows.System.IRemoteLauncherStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.System
{
  [ExclusiveTo(typeof (RemoteLauncher))]
  [Guid(3621485203, 41740, 18615, 159, 33, 5, 16, 38, 164, 229, 23)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteLauncherStatics
  {
    [Overload("LaunchUriAsync")]
    IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri);

    [Overload("LaunchUriWithOptionsAsync")]
    IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri,
      RemoteLauncherOptions options);

    [Overload("LaunchUriWithDataAsync")]
    IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri,
      RemoteLauncherOptions options,
      ValueSet inputData);
  }
}
