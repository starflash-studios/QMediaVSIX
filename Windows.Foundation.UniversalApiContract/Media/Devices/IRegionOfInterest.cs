// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IRegionOfInterest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (RegionOfInterest))]
  [Guid(3857500212, 52838, 19973, 167, 143, 207, 57, 26, 94, 194, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRegionOfInterest
  {
    bool AutoFocusEnabled { get; set; }

    bool AutoWhiteBalanceEnabled { get; set; }

    bool AutoExposureEnabled { get; set; }

    Rect Bounds { get; set; }
  }
}
