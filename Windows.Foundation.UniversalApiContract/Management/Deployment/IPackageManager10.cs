// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager10
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (PackageManager))]
  [Guid(2815938686, 11878, 16531, 174, 213, 224, 147, 237, 135, 179, 187)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPackageManager10
  {
    [RemoteAsync]
    [Overload("ProvisionPackageForAllUsersWithOptionsAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> ProvisionPackageForAllUsersAsync(
      string mainPackageFamilyName,
      PackageAllUserProvisioningOptions options);
  }
}
