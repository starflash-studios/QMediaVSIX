// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3823838942, 10056, 16907, 177, 252, 206, 149, 182, 232, 94, 236)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBoxStatics2
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }

    DependencyProperty SelectionHighlightColorProperty { get; }

    DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; }

    DependencyProperty IsColorFontEnabledProperty { get; }
  }
}
