// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(4006423580, 45264, 17127, 177, 55, 184, 155, 22, 36, 77, 65)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PosPrinter))]
  internal interface IPosPrinterStatics2
  {
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
