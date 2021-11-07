// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlockStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextBlock))]
  [WebHostHidden]
  [Guid(423542850, 43079, 17746, 180, 232, 219, 54, 101, 91, 132, 10)]
  internal interface ITextBlockStatics
  {
    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty TextTrimmingProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty TextProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty IsTextSelectionEnabledProperty { get; }

    DependencyProperty SelectedTextProperty { get; }
  }
}
