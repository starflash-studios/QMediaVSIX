// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.RowOrColumnMajor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Specifies whether data in a table should be read primarily by row or by column.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum RowOrColumnMajor
  {
    /// <summary>Data in the table should be read row by row.</summary>
    RowMajor,
    /// <summary>Data in the table should be read column by column.</summary>
    ColumnMajor,
    /// <summary>The best way to present the data is indeterminate.</summary>
    Indeterminate,
  }
}
