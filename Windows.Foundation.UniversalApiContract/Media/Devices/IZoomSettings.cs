// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IZoomSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(1792437028, 5300, 19453, 177, 143, 136, 254, 36, 70, 59, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ZoomSettings))]
  internal interface IZoomSettings
  {
    ZoomTransitionMode Mode { get; set; }

    float Value { get; set; }
  }
}
