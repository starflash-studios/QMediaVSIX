// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextSetOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies options for setting the text in a text range.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TextSetOptions : uint
  {
    /// <summary>No text setting option is specified.</summary>
    None = 0,
    /// <summary>Use the Unicode bidirectional algorithm.</summary>
    UnicodeBidi = 1,
    /// <summary>Don't include text as part of a hyperlink.</summary>
    Unlink = 8,
    /// <summary>Don't insert as hidden text.</summary>
    Unhide = 16, // 0x00000010
    /// <summary>Obey the current text limit instead of increasing the limit to fit.</summary>
    CheckTextLimit = 32, // 0x00000020
    /// <summary>Treat input text as Rich Text Format (RTF) (the Rich Text Format (RTF) text will be validated).</summary>
    FormatRtf = 8192, // 0x00002000
    /// <summary>Apply the Rich Text Format (RTF) default settings for the document. Rich Text Format (RTF) often contains document default properties. These properties are typically ignored when inserting Rich Text Format (RTF) (as distinguished from opening an Rich Text Format (RTF) file).</summary>
    ApplyRtfDocumentDefaults = 16384, // 0x00004000
  }
}
