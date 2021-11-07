// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketParameterDataType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Contains values that describe the data type of a print ticket parameter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum PrintTicketParameterDataType
  {
    /// <summary>Integer data type.</summary>
    Integer,
    /// <summary>Numeric string data type.</summary>
    NumericString,
    /// <summary>String data type.</summary>
    String,
  }
}
