// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrEngine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;
using Windows.Graphics.Imaging;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrEngine))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1511308353, 23414, 12608, 182, 128, 136, 37, 86, 38, 131, 172)]
  internal interface IOcrEngine
  {
    [RemoteAsync]
    IAsyncOperation<OcrResult> RecognizeAsync(SoftwareBitmap bitmap);

    Language RecognizerLanguage { get; }
  }
}
