// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenter4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2574981911, 15352, 17195, 143, 217, 104, 199, 186, 178, 31, 157)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IContentPresenter4
  {
    TextWrapping TextWrapping { get; set; }

    int MaxLines { get; set; }

    LineStackingStrategy LineStackingStrategy { get; set; }

    double LineHeight { get; set; }

    Brush BorderBrush { get; set; }

    Thickness BorderThickness { get; set; }

    CornerRadius CornerRadius { get; set; }

    Thickness Padding { get; set; }

    Brush Background { get; set; }

    HorizontalAlignment HorizontalContentAlignment { get; set; }

    VerticalAlignment VerticalContentAlignment { get; set; }
  }
}
