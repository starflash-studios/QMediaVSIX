// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageContentGroupStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageContentGroup))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1894675993, 24338, 19346, 185, 234, 108, 202, 218, 19, 188, 117)]
  internal interface IPackageContentGroupStatics
  {
    string RequiredGroupName { get; }
  }
}
