// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPointerDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (PointerDevice))]
  [Guid(2479471356, 60363, 18046, 130, 198, 39, 111, 234, 227, 107, 90)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerDevice
  {
    PointerDeviceType PointerDeviceType { get; }

    bool IsIntegrated { get; }

    uint MaxContacts { get; }

    Rect PhysicalDeviceRect { get; }

    Rect ScreenRect { get; }

    IVectorView<PointerDeviceUsage> SupportedUsages { get; }
  }
}
