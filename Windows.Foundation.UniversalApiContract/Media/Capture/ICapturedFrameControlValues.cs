// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrameControlValues
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [Guid(2428918655, 19981, 19620, 136, 45, 122, 20, 79, 237, 10, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CapturedFrameControlValues))]
  internal interface ICapturedFrameControlValues
  {
    IReference<TimeSpan> Exposure { get; }

    IReference<float> ExposureCompensation { get; }

    IReference<uint> IsoSpeed { get; }

    IReference<uint> Focus { get; }

    IReference<CaptureSceneMode> SceneMode { get; }

    IReference<bool> Flashed { get; }

    IReference<float> FlashPowerPercent { get; }

    IReference<uint> WhiteBalance { get; }

    IReference<float> ZoomFactor { get; }
  }
}
