// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1227720764, 44522, 17212, 190, 28, 32, 138, 22, 66, 98, 190)]
  [ExclusiveTo(typeof (RichTextBlock))]
  [WebHostHidden]
  internal interface IRichTextBlockStatics
  {
    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty TextTrimmingProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty OverflowContentTargetProperty { get; }

    DependencyProperty IsTextSelectionEnabledProperty { get; }

    DependencyProperty HasOverflowContentProperty { get; }

    DependencyProperty SelectedTextProperty { get; }

    DependencyProperty TextIndentProperty { get; }
  }
}
