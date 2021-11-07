// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Pdf
{
  [ExclusiveTo(typeof (PdfDocument))]
  [Guid(2893987549, 33018, 16521, 132, 110, 129, 183, 127, 245, 168, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPdfDocument
  {
    PdfPage GetPage(uint pageIndex);

    uint PageCount { get; }

    bool IsPasswordProtected { get; }
  }
}
