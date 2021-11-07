// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPointerDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3635976865, 53702, 16750, 189, 141, 87, 144, 145, 77, 197, 99)]
  [ExclusiveTo(typeof (PointerDevice))]
  internal interface IPointerDeviceStatics
  {
    PointerDevice GetPointerDevice(uint pointerId);

    IVectorView<PointerDevice> GetPointerDevices();
  }
}
