// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageAllUserProvisioningOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (PackageAllUserProvisioningOptions))]
  [Guid(3660950050, 7648, 23870, 153, 255, 210, 79, 49, 24, 191, 94)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPackageAllUserProvisioningOptions
  {
    IVector<string> OptionalPackageFamilyNames { get; }

    IVector<string> ProjectionOrderPackageFamilyNames { get; }
  }
}
