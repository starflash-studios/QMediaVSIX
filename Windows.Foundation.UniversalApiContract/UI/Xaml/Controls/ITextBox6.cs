// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1107242247, 20613, 20050, 165, 28, 249, 75, 6, 205, 85, 139)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextBox))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ITextBox6
  {
    TextAlignment HorizontalTextAlignment { get; set; }

    CharacterCasing CharacterCasing { get; set; }

    Brush PlaceholderForeground { get; set; }

    event TypedEventHandler<TextBox, TextControlCopyingToClipboardEventArgs> CopyingToClipboard;

    event TypedEventHandler<TextBox, TextControlCuttingToClipboardEventArgs> CuttingToClipboard;

    event TypedEventHandler<TextBox, TextBoxBeforeTextChangingEventArgs> BeforeTextChanging;
  }
}
