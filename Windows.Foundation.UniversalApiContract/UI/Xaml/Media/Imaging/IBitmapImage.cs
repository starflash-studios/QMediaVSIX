// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapImage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Guid(833565297, 58292, 17453, 163, 65, 76, 2, 38, 178, 114, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BitmapImage))]
  internal interface IBitmapImage
  {
    BitmapCreateOptions CreateOptions { get; set; }

    Uri UriSource { get; set; }

    int DecodePixelWidth { get; set; }

    int DecodePixelHeight { get; set; }

    event DownloadProgressEventHandler DownloadProgress;

    event RoutedEventHandler ImageOpened;

    event ExceptionRoutedEventHandler ImageFailed;
  }
}
