// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.LanguageFont
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Windows.Globalization.Fonts
{
  /// <summary>Provides data related to a particular font recommendation for a given language.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LanguageFont : ILanguageFont
  {
    /// <summary>Gets the family name of the font.</summary>
    /// <returns>The font family name.</returns>
    public extern string FontFamily { [MethodImpl] get; }

    /// <summary>Gets the weight of the font (FontWeight ).</summary>
    /// <returns>The weight of the font.</returns>
    public extern FontWeight FontWeight { [MethodImpl] get; }

    /// <summary>Gets the FontStretch property of the font.</summary>
    /// <returns>The FontStretch property.</returns>
    public extern FontStretch FontStretch { [MethodImpl] get; }

    /// <summary>Gets the FontStyle property of the font.</summary>
    /// <returns>The FontStyle property.</returns>
    public extern FontStyle FontStyle { [MethodImpl] get; }

    /// <summary>Gets a recommended font size scaling factor for the font.</summary>
    /// <returns>The recommended font size scaling factor.</returns>
    public extern double ScaleFactor { [MethodImpl] get; }
  }
}
