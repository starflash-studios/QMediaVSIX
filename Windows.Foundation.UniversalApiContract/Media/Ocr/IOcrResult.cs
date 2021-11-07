// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrResult))]
  [Guid(2614244786, 5979, 15722, 146, 226, 56, 140, 32, 110, 47, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOcrResult
  {
    IVectorView<OcrLine> Lines { get; }

    IReference<double> TextAngle { get; }

    string Text { get; }
  }
}
