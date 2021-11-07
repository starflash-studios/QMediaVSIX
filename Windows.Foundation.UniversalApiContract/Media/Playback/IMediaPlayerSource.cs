// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Media.Protection;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Playback
{
  [Guid(3176106135, 5155, 19518, 130, 197, 15, 177, 175, 148, 247, 21)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayerSource
  {
    MediaProtectionManager ProtectionManager { get; set; }

    [Deprecated("Use Source instead of SetFileSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetFileSource(IStorageFile file);

    [Deprecated("Use Source instead of SetStreamSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetStreamSource(IRandomAccessStream stream);

    [Deprecated("Use Source instead of SetMediaSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetMediaSource(IMediaSource source);
  }
}
