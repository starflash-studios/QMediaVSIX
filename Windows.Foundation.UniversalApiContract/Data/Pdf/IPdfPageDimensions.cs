// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfPageDimensions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Pdf
{
  [ExclusiveTo(typeof (PdfPageDimensions))]
  [Guid(571933809, 12606, 17640, 131, 93, 99, 163, 231, 98, 74, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPdfPageDimensions
  {
    Rect MediaBox { get; }

    Rect CropBox { get; }

    Rect BleedBox { get; }

    Rect TrimBox { get; }

    Rect ArtBox { get; }
  }
}
