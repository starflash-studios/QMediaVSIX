// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ExclusiveTo(typeof (BitmapSource))]
  [Guid(601383953, 8239, 16818, 140, 91, 168, 163, 179, 51, 128, 11)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapSource
  {
    int PixelWidth { get; }

    int PixelHeight { get; }

    void SetSource(IRandomAccessStream streamSource);

    [RemoteAsync]
    IAsyncAction SetSourceAsync(IRandomAccessStream streamSource);
  }
}
