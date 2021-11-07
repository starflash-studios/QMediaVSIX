// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.OpticalMarginAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Specifies how side bearing values in per-character typography are handled when aligning to a text container boundary.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum OpticalMarginAlignment
  {
    /// <summary>Use side bearings that come from font typography values. This is the default.</summary>
    None,
    /// <summary>Don't use side bearings that come from font typography values, and align the side of the glyph to where the "ink" part of the glyph begins.</summary>
    TrimSideBearings,
  }
}
