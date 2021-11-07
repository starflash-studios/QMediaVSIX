// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageAllUserProvisioningOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Activatable(851968, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  public sealed class PackageAllUserProvisioningOptions : IPackageAllUserProvisioningOptions
  {
    [MethodImpl]
    public extern PackageAllUserProvisioningOptions();

    public extern IVector<string> OptionalPackageFamilyNames { [MethodImpl] get; }

    public extern IVector<string> ProjectionOrderPackageFamilyNames { [MethodImpl] get; }
  }
}
