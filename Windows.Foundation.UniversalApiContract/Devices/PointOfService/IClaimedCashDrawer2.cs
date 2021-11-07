// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedCashDrawer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedCashDrawer))]
  [Guid(2629481890, 56898, 19803, 176, 193, 155, 87, 162, 186, 137, 195)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IClaimedCashDrawer2
  {
    event TypedEventHandler<ClaimedCashDrawer, ClaimedCashDrawerClosedEventArgs> Closed;
  }
}
