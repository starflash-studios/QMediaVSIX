// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintPageRangeOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents the list of print page range options.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class PrintPageRangeOptionDetails : IPrintOptionDetails, IPrintPageRangeOptionDetails
  {
    /// <summary>Gets the ID of the print page range option.</summary>
    /// <returns>The ID for the print page range option.</returns>
    public extern string OptionId { [MethodImpl] get; }

    /// <summary>Gets the option type for the print page range option.</summary>
    /// <returns>The option type.</returns>
    public extern PrintOptionType OptionType { [MethodImpl] get; }

    /// <summary>Gets or sets the string for an error condition.</summary>
    /// <returns>String that describes an error condition.</returns>
    public extern string ErrorText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the state for the print page range option.</summary>
    /// <returns>The state of the print page range option.</returns>
    public extern PrintOptionStates State { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the enumerated value of the print page range option.</summary>
    /// <returns>The enumerated value of the print page range option.</returns>
    public extern object Value { [MethodImpl] [return: Variant] get; }

    /// <summary>Sets the value for the print page range option.</summary>
    /// <param name="value">Value for the print page range option</param>
    /// <returns>Boolean value that indicates TRUE for a successful Get or Set, and FALSE for a failed Get or Set.</returns>
    [MethodImpl]
    public extern bool TrySetValue([Variant] object value);

    /// <summary>Gets or sets a string for a warning condition.</summary>
    /// <returns>String that describes a warning condition.</returns>
    public extern string WarningText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a description of the print page range option.</summary>
    /// <returns>String that describes the print page range option.</returns>
    public extern string Description { [MethodImpl] set; [MethodImpl] get; }
  }
}
