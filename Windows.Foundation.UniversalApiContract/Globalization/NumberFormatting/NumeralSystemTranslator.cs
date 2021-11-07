// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.NumeralSystemTranslator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>Translates digits of the Latin numerical system into digits of another numerical system.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (INumeralSystemTranslatorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class NumeralSystemTranslator : INumeralSystemTranslator
  {
    [MethodImpl]
    public extern NumeralSystemTranslator(IIterable<string> languages);

    /// <summary>Creates a NumeralSystemTranslator object initialized by the list of current runtime language values preferred by the user.</summary>
    [MethodImpl]
    public extern NumeralSystemTranslator();

    /// <summary>Gets the BCP-47 language tag(s) used to initialize this NumeralSystemTranslator object.</summary>
    /// <returns>The BCP-47 language tag(s) used to initialize this NumeralSystemTranslator object. There is always at least one.</returns>
    public extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets the language used to determine the numeral system when this object was initialized.</summary>
    /// <returns>The particular BCP-47 language tag used during the construction of this object to determine the initial value of NumeralSystem.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Gets or sets the numeral system that Latin digits will be converted to on calls to TranslateNumerals.</summary>
    /// <returns>A string that indicates the target numeral system of the translator, such as "Arab" for the Arabic-Indic numeral system (٠١٢٣٤٥٦٧٨٩). See the supported [NumeralSystem values](https://docs.microsoft.com/previous-versions/windows/apps/jj236471(v=win.10)).</returns>
    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Converts a string of characters containing Latin digits to a string containing the corresponding digits of NumeralSystem.</summary>
    /// <param name="value">A string of characters containing Latin digits to be converted.</param>
    /// <returns>A string containing the converted digits. This string may be a different length than *value*.</returns>
    [MethodImpl]
    public extern string TranslateNumerals(string value);
  }
}
