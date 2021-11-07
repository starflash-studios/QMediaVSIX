// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSubfolderDateFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the date format of a subfolder for a photo import operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum PhotoImportSubfolderDateFormat
  {
    /// <summary>The date format specifies a year.</summary>
    Year,
    /// <summary>The date format specifies year and month.</summary>
    YearMonth,
    /// <summary>The date format specifies a year, month, and day.</summary>
    YearMonthDay,
  }
}
