// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (CashDrawer))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1048674593, 35906, 16616, 156, 14, 64, 41, 112, 72, 16, 76)]
  internal interface ICashDrawerStatics2
  {
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
