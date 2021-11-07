// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrWord
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrWord))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1009403770, 23769, 13605, 186, 42, 35, 209, 224, 166, 138, 29)]
  internal interface IOcrWord
  {
    Rect BoundingRect { get; }

    string Text { get; }
  }
}
