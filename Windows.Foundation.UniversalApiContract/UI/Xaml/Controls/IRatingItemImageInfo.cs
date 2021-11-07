// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingItemImageInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(623120012, 57554, 18702, 184, 248, 150, 200, 238, 5, 18, 185)]
  [ExclusiveTo(typeof (RatingItemImageInfo))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IRatingItemImageInfo
  {
    ImageSource DisabledImage { get; set; }

    ImageSource Image { get; set; }

    ImageSource PlaceholderImage { get; set; }

    ImageSource PointerOverImage { get; set; }

    ImageSource PointerOverPlaceholderImage { get; set; }

    ImageSource UnsetImage { get; set; }
  }
}
