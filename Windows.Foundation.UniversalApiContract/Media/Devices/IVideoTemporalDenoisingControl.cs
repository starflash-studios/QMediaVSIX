// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IVideoTemporalDenoisingControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (VideoTemporalDenoisingControl))]
  [Guid(2058569525, 15914, 18994, 186, 255, 67, 88, 196, 251, 221, 87)]
  internal interface IVideoTemporalDenoisingControl
  {
    bool Supported { get; }

    IVectorView<VideoTemporalDenoisingMode> SupportedModes { get; }

    VideoTemporalDenoisingMode Mode { get; set; }
  }
}
