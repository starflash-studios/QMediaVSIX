// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageVolume2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (PackageVolume))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1185664814, 40404, 18338, 171, 140, 198, 64, 131, 73, 188, 216)]
  internal interface IPackageVolume2
  {
    bool IsFullTrustPackageSupported { get; }

    bool IsAppxInstallSupported { get; }

    [RemoteAsync]
    IAsyncOperation<ulong> GetAvailableSpaceAsync();
  }
}
