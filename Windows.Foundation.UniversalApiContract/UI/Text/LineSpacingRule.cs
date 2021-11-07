// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.LineSpacingRule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies options for line-spacing rules.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LineSpacingRule
  {
    /// <summary>The line spacing is undefined.</summary>
    Undefined,
    /// <summary>Single space. The line-spacing value is ignored.</summary>
    Single,
    /// <summary>One-and-a-half line spacing. The line-spacing value is ignored.</summary>
    OneAndHalf,
    /// <summary>Double line spacing. The line-spacing value is ignored.</summary>
    Double,
    /// <summary>The line-spacing value specifies the spacing from one line to the next. However, if the value is less than single spacing, text is single spaced.</summary>
    AtLeast,
    /// <summary>The line-spacing value specifies the exact spacing from one line to the next, even if the value is less than single spacing.</summary>
    Exactly,
    /// <summary>The line-spacing value specifies the line spacing, in lines.</summary>
    Multiple,
    /// <summary>The line-spacing value specifies the line spacing by percent of line height. This option is not supported by Windows.UI.Xaml.Controls.RichEditBox. Setting it will always return an InvalidArgumentException.</summary>
    Percent,
  }
}
