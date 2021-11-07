// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintCustomItemListOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents a list of the custom print task option items.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  public sealed class PrintCustomItemListOptionDetails : 
    IPrintOptionDetails,
    IPrintCustomOptionDetails,
    IPrintItemListOptionDetails,
    IPrintCustomItemListOptionDetails,
    IPrintCustomItemListOptionDetails2,
    IPrintCustomItemListOptionDetails3
  {
    /// <summary>Gets the ID of a custom print task option.</summary>
    /// <returns>The option ID.</returns>
    public extern string OptionId { [MethodImpl] get; }

    /// <summary>Gets the option type for a custom print task option.</summary>
    /// <returns>The option type.</returns>
    public extern PrintOptionType OptionType { [MethodImpl] get; }

    /// <summary>Gets or sets the string for an error condition.</summary>
    /// <returns>String that describes the error condition.</returns>
    public extern string ErrorText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the state of the list of custom print task option items.</summary>
    /// <returns>The state value.</returns>
    public extern PrintOptionStates State { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the value of the list of custom print tasks.</summary>
    /// <returns>The value of the list.</returns>
    public extern object Value { [MethodImpl] [return: Variant] get; }

    /// <summary>Sets the value for the item ID or the display name of the custom item.</summary>
    /// <param name="value">Value for the item ID or the display name of the custom item.</param>
    /// <returns>Boolean value that indicates TRUE for a successful Get or Set, and FALSE for a failed Get or Set.</returns>
    [MethodImpl]
    public extern bool TrySetValue([Variant] object value);

    /// <summary>Gets or sets the display name of an item in the list of custom print task options.</summary>
    /// <returns>The display name of the option item.</returns>
    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets an item from the list of custom print tasks.</summary>
    /// <returns>Pointer to the item.</returns>
    public extern IVectorView<object> Items { [MethodImpl] [return: HasVariant] get; }

    /// <summary>Sets the ID or display name of an item in the list of custom print task options.</summary>
    /// <param name="itemId">The ID of the option item.</param>
    /// <param name="displayName">The display name of the option item.</param>
    [MethodImpl]
    public extern void AddItem(string itemId, string displayName);

    /// <summary>Sets the item ID, display name, description, or icon in the list of custom print item options.</summary>
    /// <param name="itemId">The ID of the option item.</param>
    /// <param name="displayName">The display name of the option item.</param>
    /// <param name="description">The description of the option item.</param>
    /// <param name="icon">The icon used by the option item. The icon needs to be in the SVG file format.</param>
    [MethodImpl]
    public extern void AddItem(
      string itemId,
      string displayName,
      string description,
      IRandomAccessStreamWithContentType icon);

    /// <summary>Gets or sets a string for a warning condition.</summary>
    /// <returns>String that describes a warning condition.</returns>
    public extern string WarningText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the description for the print custom item list option.</summary>
    /// <returns>String containing the description.</returns>
    public extern string Description { [MethodImpl] set; [MethodImpl] get; }
  }
}
