// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4145449984, 5170, 17962, 148, 5, 56, 243, 133, 191, 195, 124)]
  [WebHostHidden]
  internal interface ITextBox2
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string PlaceholderText { get; set; }

    SolidColorBrush SelectionHighlightColor { get; set; }

    bool PreventKeyboardDisplayOnProgrammaticFocus { get; set; }

    bool IsColorFontEnabled { get; set; }

    event TextControlPasteEventHandler Paste;
  }
}
