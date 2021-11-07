// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (PackageManager))]
  [Guid(1014077795, 47798, 18111, 143, 247, 218, 71, 25, 35, 10, 230)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPackageManager4
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<PackageVolume>> GetPackageVolumesAsync();
  }
}
