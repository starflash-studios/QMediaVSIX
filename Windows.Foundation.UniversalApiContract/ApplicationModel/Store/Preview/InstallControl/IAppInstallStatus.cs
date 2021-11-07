// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2473446650, 9296, 16678, 136, 177, 97, 39, 166, 68, 221, 92)]
  [ExclusiveTo(typeof (AppInstallStatus))]
  internal interface IAppInstallStatus
  {
    AppInstallState InstallState { get; }

    ulong DownloadSizeInBytes { get; }

    ulong BytesDownloaded { get; }

    double PercentComplete { get; }

    HResult ErrorCode { get; }
  }
}
