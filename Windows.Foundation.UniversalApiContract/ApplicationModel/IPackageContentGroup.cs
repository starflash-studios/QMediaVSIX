// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageContentGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2405591389, 4618, 18328, 181, 225, 88, 0, 221, 168, 242, 225)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PackageContentGroup))]
  internal interface IPackageContentGroup
  {
    Package Package { get; }

    string Name { get; }

    PackageContentGroupState State { get; }

    bool IsRequired { get; }
  }
}
