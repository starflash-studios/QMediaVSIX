// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.OcrWord
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  /// <summary>Represents a single word in a line of text recognized by the OCR engine and returned as part of the OcrLine.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class OcrWord : IOcrWord
  {
    /// <summary>Gets the position and size in pixels of the recognized word from the top left corner of image when the value of TextAngle property is 0 (zero).</summary>
    /// <returns>The position and size in pixels of the recognized word from the top left corner of image when the value of TextAngle property is 0 (zero).</returns>
    public extern Rect BoundingRect { [MethodImpl] get; }

    /// <summary>Gets the text of the recognized word.</summary>
    /// <returns>The text of the recognized word.</returns>
    public extern string Text { [MethodImpl] get; }
  }
}
