// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintCopiesOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents the option for the number of printed copies.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintCopiesOptionDetails : 
    IPrintOptionDetails,
    IPrintNumberOptionDetails,
    IPrintCopiesOptionDetails
  {
    /// <summary>Gets the ID for the option for the number of printed copies.</summary>
    /// <returns>The ID of the option.</returns>
    public extern string OptionId { [MethodImpl] get; }

    /// <summary>Gets the option type for the option for the number of printed copies.</summary>
    /// <returns>The option type.</returns>
    public extern PrintOptionType OptionType { [MethodImpl] get; }

    /// <summary>Gets or sets the string for an error condition.</summary>
    /// <returns>String that describes the error condition.</returns>
    public extern string ErrorText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the state of the option for the number of printed copies.</summary>
    /// <returns>The state of the option.</returns>
    public extern PrintOptionStates State { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the number of copies for a print task.</summary>
    /// <returns>The number of copies for a print task.</returns>
    public extern object Value { [MethodImpl] [return: Variant] get; }

    /// <summary>Sets the value for the print copies option.</summary>
    /// <param name="value">Value for the print copies option.</param>
    /// <returns>Boolean value that indicates TRUE for a successful Get or Set, and FALSE for a failed Get or Set.</returns>
    [MethodImpl]
    public extern bool TrySetValue([Variant] object value);

    /// <summary>Gets the value for the minimum number of printed copies allowed.</summary>
    /// <returns>The minimum number of printed copies allowed.</returns>
    public extern uint MinValue { [MethodImpl] get; }

    /// <summary>Gets the value for the maximum number of printed copies allowed.</summary>
    /// <returns>The maximum number of printed copies allowed.</returns>
    public extern uint MaxValue { [MethodImpl] get; }

    /// <summary>Gets or sets a string for a warning condition.</summary>
    /// <returns>String that describes a warning condition.</returns>
    public extern string WarningText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the description of the print copies option.</summary>
    /// <returns>String containing the description.</returns>
    public extern string Description { [MethodImpl] set; [MethodImpl] get; }
  }
}
