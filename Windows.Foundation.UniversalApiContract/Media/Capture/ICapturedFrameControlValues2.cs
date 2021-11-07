// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrameControlValues2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [Guid(1342909320, 1746, 19111, 167, 219, 211, 122, 247, 51, 33, 216)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CapturedFrameControlValues))]
  internal interface ICapturedFrameControlValues2
  {
    IReference<MediaCaptureFocusState> FocusState { get; }

    IReference<double> IsoDigitalGain { get; }

    IReference<double> IsoAnalogGain { get; }

    MediaRatio SensorFrameRate { get; }

    IReference<global::Windows.Media.Capture.WhiteBalanceGain> WhiteBalanceGain { get; }
  }
}
