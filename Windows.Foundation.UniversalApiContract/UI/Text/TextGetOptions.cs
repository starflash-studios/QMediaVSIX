// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextGetOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies options for retrieving the text in a document or text range.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TextGetOptions : uint
  {
    /// <summary>None of the following options is used.</summary>
    None = 0,
    /// <summary>If the starting character position is in the middle of a construct such as a CRLF (U+000D U+000A), surrogate pair, variation-selector sequence, or table-row delimiter, move to the beginning of the construct.</summary>
    AdjustCrlf = 1,
    /// <summary>Use carriage return/line feed (CR/LF) in place of a carriage return.</summary>
    UseCrlf = 2,
    /// <summary>Retrieve text including the alternate text for the images in the range.</summary>
    UseObjectText = 4,
    /// <summary>Allow retrieving the final end-of-paragraph (EOP) if it’s included in the range. This EOP exists in all rich-text controls and cannot be deleted. It does not exist in plain-text controls.</summary>
    AllowFinalEop = 8,
    /// <summary>Don't include hidden text.</summary>
    NoHidden = 32, // 0x00000020
    /// <summary>Include list numbers.</summary>
    IncludeNumbering = 64, // 0x00000040
    /// <summary>Retrieve Rich Text Format (RTF) instead of plain text. Rich Text Format (RTF) is a BYTE (8-bit) format, but because ITextRange.GetText returns a string, the Rich Text Format (RTF) is returned as WCHARs (16-bit or UTF-16), not bytes, when you call ITextRange.GetText with the **FormatRtf** value. When you call ITextRange.SetText with **FormatRtf**, the method accepts an string containing either bytes or WCHARs, but other Rich Text Format (RTF) readers only understand bytes.</summary>
    FormatRtf = 8192, // 0x00002000
    /// <summary>Use line feed (LF) in place of all carriage returns.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] UseLf = 16777216, // 0x01000000
  }
}
