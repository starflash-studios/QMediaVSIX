// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.SelectionOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Describes the options that apply to a selection.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SelectionOptions : uint
  {
    /// <summary>The start position of the selection is the active end; that is, the end that is changed by pressing Shift+Right Arrow and Shift+Left Arrow.</summary>
    StartActive = 1,
    /// <summary>For a degenerate selection (insertion point), the character position at the beginning of a line is the same as the character position at the end of the preceding line. As such, the character position is ambiguous. If this flag is 1, display the caret at the end of the preceding line; otherwise, display it at the beginning of the line.</summary>
    AtEndOfLine = 2,
    /// <summary>Insert/overtype mode is set to overtype.</summary>
    Overtype = 4,
    /// <summary>The selection is active; that is, the text control has the input focus.</summary>
    Active = 8,
    /// <summary>Typing and pasting replaces the selection.</summary>
    Replace = 16, // 0x00000010
  }
}
