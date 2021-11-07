// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IGetEntitlementResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (GetEntitlementResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1962705983, 6814, 17929, 142, 77, 129, 144, 134, 208, 138, 61)]
  internal interface IGetEntitlementResult
  {
    GetEntitlementStatus Status { get; }
  }
}
