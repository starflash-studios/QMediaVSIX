// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PackageManager))]
  [Guid(3092730672, 4760, 20194, 128, 238, 127, 101, 156, 93, 39, 130)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IPackageManager8
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> DeprovisionPackageForAllUsersAsync(
      string packageFamilyName);
  }
}
