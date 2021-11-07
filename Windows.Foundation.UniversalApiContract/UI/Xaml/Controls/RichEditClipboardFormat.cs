// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichEditClipboardFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the format of text copied from a RichEditBox.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum RichEditClipboardFormat
  {
    /// <summary>Text is copied as both plain text and rich text.</summary>
    AllFormats,
    /// <summary>Text is copied only as plain text.</summary>
    PlainText,
  }
}
