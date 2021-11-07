// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaClipStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.UI;

namespace Windows.Media.Editing
{
  [Guid(4198509416, 37519, 17348, 188, 110, 120, 58, 26, 53, 150, 86)]
  [ExclusiveTo(typeof (MediaClip))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaClipStatics
  {
    MediaClip CreateFromColor(Color color, TimeSpan originalDuration);

    [RemoteAsync]
    IAsyncOperation<MediaClip> CreateFromFileAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<MediaClip> CreateFromImageFileAsync(
      IStorageFile file,
      TimeSpan originalDuration);
  }
}
