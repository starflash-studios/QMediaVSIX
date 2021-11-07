// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfPageRenderOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Data.Pdf
{
  [Guid(1016595823, 47055, 19497, 154, 4, 82, 217, 2, 103, 244, 37)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PdfPageRenderOptions))]
  internal interface IPdfPageRenderOptions
  {
    Rect SourceRect { get; set; }

    uint DestinationWidth { get; set; }

    uint DestinationHeight { get; set; }

    Color BackgroundColor { get; set; }

    bool IsIgnoringHighContrast { get; set; }

    Guid BitmapEncoderId { get; set; }
  }
}
