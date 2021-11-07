// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.OcrEngine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;
using Windows.Graphics.Imaging;

namespace Windows.Media.Ocr
{
  /// <summary>Provides optical character recognition (OCR) functionality.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IOcrEngineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class OcrEngine : IOcrEngine
  {
    /// <summary>Scans the specified image for text in the language specified by the RecognizerLanguage property.</summary>
    /// <param name="bitmap">Represents an uncompressed bitmap.</param>
    /// <returns>The result of the OCR that was initiated by the OcrEngine object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<OcrResult> RecognizeAsync(
      SoftwareBitmap bitmap);

    /// <summary>Gets the language being used for text recognition.</summary>
    /// <returns>The language being used for text recognition.</returns>
    public extern Language RecognizerLanguage { [MethodImpl] get; }

    /// <summary>Gets the maximum image pixel dimensions supported by the OCR engine.</summary>
    /// <returns>The maximum image pixel dimensions supported by the OCR engine.</returns>
    public static extern uint MaxImageDimension { [MethodImpl] get; }

    /// <summary>Returns a collection of all available OCR languages on the device.</summary>
    /// <returns>A collection of all available OCR languages on the device.</returns>
    public static extern IVectorView<Language> AvailableRecognizerLanguages { [MethodImpl] get; }

    /// <summary>Returns true if a specified language can be resolved to any of the available OCR languages. See language matching for a further explanation of language resolving.</summary>
    /// <param name="language">The language being used for text recognition.</param>
    /// <returns>TRUE, if the specified language can be resolved to any of the available OCR languages; otherwise, FALSE.</returns>
    [MethodImpl]
    public static extern bool IsLanguageSupported(Language language);

    /// <summary>Creates a new instance of the OcrEngine class.</summary>
    /// <param name="language">The language being used for text recognition.</param>
    /// <returns>If the specified language can be resolved to any of the OCR languages available on the device, returns new instance of **OcrEngine** class, otherwise returns **null**. See language matching for a further explanation of language resolving.</returns>
    [MethodImpl]
    public static extern OcrEngine TryCreateFromLanguage(Language language);

    /// <summary>Creates a new instance of the OcrEngine class.</summary>
    /// <returns>If any language from **GlobalizationPreferences.Languages** can be resolved to any of the available OCR languages returns new instance of **OcrEngine** class, otherwise returns **null**.</returns>
    [MethodImpl]
    public static extern OcrEngine TryCreateFromUserProfileLanguages();
  }
}
