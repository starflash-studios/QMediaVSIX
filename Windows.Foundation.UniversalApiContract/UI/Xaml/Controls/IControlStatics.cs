// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1195061339, 34685, 19509, 143, 202, 70, 160, 95, 150, 96, 122)]
  [ExclusiveTo(typeof (Control))]
  [WebHostHidden]
  internal interface IControlStatics
  {
    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty IsTabStopProperty { get; }

    DependencyProperty IsEnabledProperty { get; }

    DependencyProperty TabIndexProperty { get; }

    DependencyProperty TabNavigationProperty { get; }

    DependencyProperty TemplateProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty HorizontalContentAlignmentProperty { get; }

    DependencyProperty VerticalContentAlignmentProperty { get; }

    DependencyProperty BackgroundProperty { get; }

    DependencyProperty BorderThicknessProperty { get; }

    DependencyProperty BorderBrushProperty { get; }

    DependencyProperty DefaultStyleKeyProperty { get; }

    DependencyProperty FocusStateProperty { get; }
  }
}
