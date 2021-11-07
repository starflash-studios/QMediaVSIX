// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(224473569, 44841, 18638, 138, 175, 116, 236, 194, 139, 251, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RichTextBlock))]
  internal interface IRichTextBlockStatics2
  {
    DependencyProperty MaxLinesProperty { get; }

    DependencyProperty TextLineBoundsProperty { get; }

    DependencyProperty SelectionHighlightColorProperty { get; }

    DependencyProperty OpticalMarginAlignmentProperty { get; }

    DependencyProperty IsColorFontEnabledProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }
  }
}
