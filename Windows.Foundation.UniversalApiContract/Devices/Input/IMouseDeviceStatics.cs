// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IMouseDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (MouseDevice))]
  [Guid(1212846149, 28016, 18907, 142, 104, 70, 255, 189, 23, 211, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMouseDeviceStatics
  {
    MouseDevice GetForCurrentView();
  }
}
