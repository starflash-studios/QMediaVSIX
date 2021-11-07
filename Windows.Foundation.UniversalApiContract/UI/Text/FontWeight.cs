// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.FontWeight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Expresses the density of a typeface, in terms of the lightness or heaviness of the strokes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct FontWeight
  {
    /// <summary>The font weight expressed as a numeric value. See Remarks.</summary>
    public ushort Weight;
  }
}
