// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStatus2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PackageStatus))]
  [Guid(4096326291, 31830, 18530, 172, 250, 171, 174, 220, 192, 105, 77)]
  internal interface IPackageStatus2
  {
    bool IsPartiallyStaged { get; }
  }
}
