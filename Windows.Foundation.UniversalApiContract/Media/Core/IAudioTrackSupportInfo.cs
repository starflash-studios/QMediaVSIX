// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioTrackSupportInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(395046903, 52281, 17574, 185, 81, 74, 86, 83, 240, 115, 250)]
  [ExclusiveTo(typeof (AudioTrackSupportInfo))]
  internal interface IAudioTrackSupportInfo
  {
    MediaDecoderStatus DecoderStatus { get; }

    AudioDecoderDegradation Degradation { get; }

    AudioDecoderDegradationReason DegradationReason { get; }

    MediaSourceStatus MediaSourceStatus { get; }
  }
}
