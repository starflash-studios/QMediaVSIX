// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2046682548, 52535, 18716, 136, 69, 218, 244, 114, 222, 255, 246)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IContentPresenter
  {
    object Content { get; set; }

    DataTemplate ContentTemplate { get; set; }

    DataTemplateSelector ContentTemplateSelector { get; set; }

    TransitionCollection ContentTransitions { get; set; }

    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    int CharacterSpacing { get; set; }

    Brush Foreground { get; set; }
  }
}
