// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.FontFamily
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a family of related fonts.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IFontFamilyFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFontFamilyStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class FontFamily : IFontFamily
  {
    /// <summary>Initializes a new instance of the FontFamily class from the specified font family string.</summary>
    /// <param name="familyName">The family name of the font to represent. This can include a hashed suffix. </param>
    [MethodImpl]
    public extern FontFamily(string familyName);

    /// <summary>Gets the font family name that is used to construct the FontFamily object.</summary>
    /// <returns>The font family name of the FontFamily object.</returns>
    public extern string Source { [MethodImpl] get; }

    /// <summary>Gets the default font family based on an app's language settings.</summary>
    /// <returns>The default font family based on an app's language settings. See Remarks.</returns>
    public static extern FontFamily XamlAutoFontFamily { [MethodImpl] get; }
  }
}
