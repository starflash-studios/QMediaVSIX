// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IImage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.PlayTo;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1230730242, 39667, 20048, 170, 144, 3, 56, 143, 48, 134, 210)]
  [ExclusiveTo(typeof (Image))]
  internal interface IImage
  {
    ImageSource Source { get; set; }

    Stretch Stretch { get; set; }

    Thickness NineGrid { get; set; }

    PlayToSource PlayToSource { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event ExceptionRoutedEventHandler ImageFailed;

    event RoutedEventHandler ImageOpened;
  }
}
