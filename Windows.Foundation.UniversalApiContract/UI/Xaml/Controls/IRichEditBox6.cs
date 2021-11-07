// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RichEditBox))]
  [Guid(210359552, 59608, 20142, 136, 4, 51, 100, 146, 5, 215, 210)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IRichEditBox6
  {
    TextAlignment HorizontalTextAlignment { get; set; }

    CharacterCasing CharacterCasing { get; set; }

    DisabledFormattingAccelerators DisabledFormattingAccelerators { get; set; }

    event TypedEventHandler<RichEditBox, TextControlCopyingToClipboardEventArgs> CopyingToClipboard;

    event TypedEventHandler<RichEditBox, TextControlCuttingToClipboardEventArgs> CuttingToClipboard;
  }
}
