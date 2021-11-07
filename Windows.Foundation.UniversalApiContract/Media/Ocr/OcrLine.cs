// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.OcrLine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  /// <summary>Represents a single line of text recognized by the OCR engine and returned as part of the OcrResult.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class OcrLine : IOcrLine
  {
    /// <summary>Gets the collection of OcrWord objects that represents the words detected in the current line of text by the RecognizeAsync method.</summary>
    /// <returns>The collection of OcrWord objects that represents the words detected in the current line of text by the RecognizeAsync method.</returns>
    public extern IVectorView<OcrWord> Words { [MethodImpl] get; }

    /// <summary>Gets the text of the recognized line.</summary>
    /// <returns>The text of the recognized line.</returns>
    public extern string Text { [MethodImpl] get; }
  }
}
