// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILoadedImageSurfaceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (LoadedImageSurface))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(582544886, 33965, 16555, 147, 125, 72, 113, 97, 62, 118, 93)]
  internal interface ILoadedImageSurfaceStatics
  {
    [Overload("StartLoadFromUriWithSize")]
    LoadedImageSurface StartLoadFromUri(Uri uri, Size desiredMaxSize);

    [Overload("StartLoadFromUri")]
    LoadedImageSurface StartLoadFromUri(Uri uri);

    [Overload("StartLoadFromStreamWithSize")]
    LoadedImageSurface StartLoadFromStream(
      IRandomAccessStream stream,
      Size desiredMaxSize);

    [Overload("StartLoadFromStream")]
    LoadedImageSurface StartLoadFromStream(IRandomAccessStream stream);
  }
}
