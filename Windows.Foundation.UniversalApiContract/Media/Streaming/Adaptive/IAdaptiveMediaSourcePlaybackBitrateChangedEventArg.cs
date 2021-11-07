// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourcePlaybackBitrateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(597860205, 32218, 19025, 135, 169, 111, 168, 197, 178, 146, 190)]
  [ExclusiveTo(typeof (AdaptiveMediaSourcePlaybackBitrateChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdaptiveMediaSourcePlaybackBitrateChangedEventArgs
  {
    uint OldValue { get; }

    uint NewValue { get; }

    bool AudioOnly { get; }
  }
}
