// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControlsDisplayUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media
{
  [Guid(2327561534, 64085, 20175, 173, 142, 201, 132, 229, 221, 21, 80)]
  [ExclusiveTo(typeof (SystemMediaTransportControlsDisplayUpdater))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemMediaTransportControlsDisplayUpdater
  {
    MediaPlaybackType Type { get; set; }

    string AppMediaId { get; set; }

    RandomAccessStreamReference Thumbnail { get; set; }

    MusicDisplayProperties MusicProperties { get; }

    VideoDisplayProperties VideoProperties { get; }

    ImageDisplayProperties ImageProperties { get; }

    [RemoteAsync]
    IAsyncOperation<bool> CopyFromFileAsync(
      MediaPlaybackType type,
      StorageFile source);

    void ClearAll();

    void Update();
  }
}
