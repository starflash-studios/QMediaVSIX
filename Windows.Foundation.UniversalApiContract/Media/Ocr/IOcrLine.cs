// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrLine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrLine))]
  [Guid(4432239, 58143, 14884, 137, 156, 212, 68, 189, 8, 129, 36)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOcrLine
  {
    IVectorView<OcrWord> Words { get; }

    string Text { get; }
  }
}
