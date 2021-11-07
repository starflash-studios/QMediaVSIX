// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.AlternateNormalizationFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Identifies the normalization format of an AlternateWordForm object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AlternateNormalizationFormat
  {
    /// <summary>A regular string that has not been recognized as a number, currency, date, or time.</summary>
    NotNormalized = 0,
    /// <summary>A string that has been recognized as a number.</summary>
    Number = 1,
    /// <summary>A string that has been recognized as a monetary amount.</summary>
    Currency = 3,
    /// <summary>A string that has been recognized as a date.</summary>
    Date = 4,
    /// <summary>A string that has been recognized as a time.</summary>
    Time = 5,
  }
}
