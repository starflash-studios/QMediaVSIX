// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISvgImageSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(65130179, 3240, 19022, 141, 124, 200, 8, 160, 131, 133, 134)]
  [ExclusiveTo(typeof (SvgImageSource))]
  internal interface ISvgImageSource
  {
    Uri UriSource { get; set; }

    double RasterizePixelWidth { get; set; }

    double RasterizePixelHeight { get; set; }

    event TypedEventHandler<SvgImageSource, SvgImageSourceOpenedEventArgs> Opened;

    event TypedEventHandler<SvgImageSource, SvgImageSourceFailedEventArgs> OpenFailed;

    [RemoteAsync]
    IAsyncOperation<SvgImageSourceLoadStatus> SetSourceAsync(
      IRandomAccessStream streamSource);
  }
}
