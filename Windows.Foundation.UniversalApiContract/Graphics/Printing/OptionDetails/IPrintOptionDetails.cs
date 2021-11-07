// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents the base class for the PrintTaskOptionXxx objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(956729039, 54914, 18783, 173, 254, 215, 51, 63, 92, 24, 8)]
  public interface IPrintOptionDetails
  {
    /// <summary>Gets the ID for a print task option.</summary>
    /// <returns>The ID for the print task option.</returns>
    string OptionId { get; }

    /// <summary>Gets the option type for a print task option.</summary>
    /// <returns>The option type for a print task option.</returns>
    PrintOptionType OptionType { get; }

    /// <summary>Gets or sets the string for an error condition.</summary>
    /// <returns>String that describes the error condition.</returns>
    string ErrorText { set; get; }

    /// <summary>Gets or sets the state of a print task option.</summary>
    /// <returns>The state of a print task option.</returns>
    PrintOptionStates State { set; get; }

    /// <summary>Gets the enumerated value of a print task option.</summary>
    /// <returns>The enumerated value of a print task option.</returns>
    object Value { [return: Variant] get; }

    /// <summary>Sets the value for the print task option.</summary>
    /// <param name="value">Value for the print task option.</param>
    /// <returns>Boolean value that indicates TRUE for a successful Get or Set, and FALSE for a failed Get or Set.</returns>
    bool TrySetValue([Variant] object value);
  }
}
