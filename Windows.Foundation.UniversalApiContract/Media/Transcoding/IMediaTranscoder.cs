// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.IMediaTranscoder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Transcoding
{
  [ExclusiveTo(typeof (MediaTranscoder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(420256210, 41130, 19764, 134, 188, 238, 209, 177, 44, 47, 91)]
  internal interface IMediaTranscoder
  {
    TimeSpan TrimStartTime { set; get; }

    TimeSpan TrimStopTime { set; get; }

    bool AlwaysReencode { set; get; }

    bool HardwareAccelerationEnabled { set; get; }

    [Overload("AddAudioEffect")]
    void AddAudioEffect(string activatableClassId);

    [Overload("AddAudioEffectWithSettings")]
    void AddAudioEffect(string activatableClassId, bool effectRequired, IPropertySet configuration);

    [Overload("AddVideoEffect")]
    void AddVideoEffect(string activatableClassId);

    [Overload("AddVideoEffectWithSettings")]
    void AddVideoEffect(string activatableClassId, bool effectRequired, IPropertySet configuration);

    void ClearEffects();

    IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync(
      IStorageFile source,
      IStorageFile destination,
      MediaEncodingProfile profile);

    IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync(
      IRandomAccessStream source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);
  }
}
