// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TabAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Alignment options for tab positions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TabAlignment
  {
    /// <summary>Text is left justified from the tab position. This is the default.</summary>
    Left,
    /// <summary>Text is centered on the tab position.</summary>
    Center,
    /// <summary>Text is right justified from the tab position.</summary>
    Right,
    /// <summary>The decimal point is set at the tab position. This is useful for aligning a column of decimal numbers.</summary>
    Decimal,
    /// <summary>A vertical bar is positioned at the tab position. Text is not affected. Alignment bars on nearby lines at the same position form a continuous vertical line.</summary>
    Bar,
  }
}
