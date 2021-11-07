// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FontFraction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes a fraction style value for the Typography.Fraction attached property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum FontFraction
  {
    /// <summary>Default style is used.</summary>
    Normal,
    /// <summary>Slashed fraction style is used.</summary>
    Stacked,
    /// <summary>Stacked fraction style is used.</summary>
    Slashed,
  }
}
