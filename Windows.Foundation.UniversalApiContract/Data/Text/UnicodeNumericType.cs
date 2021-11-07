// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.UnicodeNumericType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Defines the type of numeral when a Unicode character represents a number.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UnicodeNumericType
  {
    /// <summary>Not a numeric character.</summary>
    None,
    /// <summary>A decimal digit in a decimal system that uses 0 through 9.</summary>
    Decimal,
    /// <summary>A digit in the range 0 through 9 that is used in special contexts.</summary>
    Digit,
    /// <summary>A character that represents another type of numeric value, such as a fraction.</summary>
    Numeric,
  }
}
