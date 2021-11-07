// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfPageRotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Pdf
{
  /// <summary>Specifies the number of degrees that a page in a Portable Document Format (PDF) document is rotated in the rendered output.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PdfPageRotation
  {
    /// <summary>No rotation.</summary>
    Normal,
    /// <summary>A 90-degree rotation.</summary>
    Rotate90,
    /// <summary>A 180-degree rotation.</summary>
    Rotate180,
    /// <summary>A 270-degree rotation.</summary>
    Rotate270,
  }
}
