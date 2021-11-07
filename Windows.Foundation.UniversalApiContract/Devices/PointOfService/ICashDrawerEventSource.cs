// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerEventSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3758548076, 62201, 17455, 141, 214, 6, 193, 10, 66, 39, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CashDrawerEventSource))]
  internal interface ICashDrawerEventSource
  {
    event TypedEventHandler<CashDrawerEventSource, CashDrawerClosedEventArgs> DrawerClosed;

    event TypedEventHandler<CashDrawerEventSource, CashDrawerOpenedEventArgs> DrawerOpened;
  }
}
