// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PackageManager))]
  [Guid(4068889844, 11175, 19328, 136, 214, 190, 21, 249, 162, 63, 186)]
  [WebHostHidden]
  internal interface IPackageManager7
  {
    [Overload("RequestAddPackageAndRelatedSetAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RequestAddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> relatedPackageUris,
      IIterable<Uri> packageUrisToInstall);
  }
}
