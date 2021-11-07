// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.OcrResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  /// <summary>Contains the results of Optical Character Recognition (OCR).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class OcrResult : IOcrResult
  {
    /// <summary>Gets the collection of OcrLine objects that represents the lines of text detected in the image by the RecognizeAsync method.</summary>
    /// <returns>The collection of OcrLine objects that represents the lines of text detected in the image by the RecognizeAsync method.</returns>
    public extern IVectorView<OcrLine> Lines { [MethodImpl] get; }

    /// <summary>Gets the clockwise rotation of the recognized text, in degrees, around the center of the image.</summary>
    /// <returns>The clockwise rotation of the recognized text, in degrees, around the center of the image. If the angle of the text can't be detected, the value of this property is **null**. If the image contains text at different angles, only part of the text will be recognized correctly.</returns>
    public extern IReference<double> TextAngle { [MethodImpl] get; }

    /// <summary>Gets the recognized text.</summary>
    /// <returns>The recognized text.</returns>
    public extern string Text { [MethodImpl] get; }
  }
}
