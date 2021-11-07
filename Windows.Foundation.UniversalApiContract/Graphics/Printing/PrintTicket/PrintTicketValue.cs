// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Represents a value of a printing parameter or print option property.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class PrintTicketValue : IPrintTicketValue
  {
    /// <summary>Gets the type of value that this class object represents.</summary>
    /// <returns>The value type.</returns>
    public extern PrintTicketValueType Type { [MethodImpl] get; }

    /// <summary>Converts the print value to an `int`.</summary>
    /// <returns>An `int` indicating the value.</returns>
    [MethodImpl]
    public extern int GetValueAsInteger();

    /// <summary>Converts the print value to a string.</summary>
    /// <returns>A string indicating the value.</returns>
    [MethodImpl]
    public extern string GetValueAsString();
  }
}
