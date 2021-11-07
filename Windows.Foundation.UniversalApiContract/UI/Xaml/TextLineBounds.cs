// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TextLineBounds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Influences how a line box height is calculated</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TextLineBounds
  {
    /// <summary>Uses normal line box height calculation, this is the default.</summary>
    Full,
    /// <summary>Top of line box height is the cap height from the font.</summary>
    TrimToCapHeight,
    /// <summary>Bottom of line box height is the text baseline.</summary>
    TrimToBaseline,
    /// <summary>Top of line box height is the cap height from the font, bottom of line box height is the text baseline.</summary>
    Tight,
  }
}
