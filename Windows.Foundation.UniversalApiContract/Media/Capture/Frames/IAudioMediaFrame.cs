// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IAudioMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture.Frames
{
  [Guid(2745827071, 32801, 17435, 154, 70, 231, 240, 19, 123, 121, 129)]
  [ExclusiveTo(typeof (AudioMediaFrame))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAudioMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    AudioEncodingProperties AudioEncodingProperties { get; }

    AudioFrame GetAudioFrame();
  }
}
