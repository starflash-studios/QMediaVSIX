// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>A collection of events, methods and properties for advanced print tasks.</summary>
  [Static(typeof (IPrintTaskOptionDetailsStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  public sealed class PrintTaskOptionDetails : 
    IPrintTaskOptionDetails,
    IPrintTaskOptionsCore,
    IPrintTaskOptionsCoreUIConfiguration,
    IPrintTaskOptionDetails2
  {
    /// <summary>Gets the list of options for the advanced print task.</summary>
    /// <returns>The list of options for the advanced print task.</returns>
    public extern IMapView<string, IPrintOptionDetails> Options { [MethodImpl] get; }

    /// <summary>Creates a custom list of items that allow the user to choose the page format.</summary>
    /// <param name="optionId">The ID for the custom item.</param>
    /// <param name="displayName">The display name for the custom item.</param>
    /// <returns>The list of custom items.</returns>
    [MethodImpl]
    public extern PrintCustomItemListOptionDetails CreateItemListOption(
      string optionId,
      string displayName);

    /// <summary>Creates a CustomPrintTaskOptionText object to handle the display name and other parameters of the advanced print task option item.</summary>
    /// <param name="optionId">The ID of the print task option.</param>
    /// <param name="displayName">The display name of the print task option.</param>
    /// <returns>The **CustomPrintTaskOptionText** object.</returns>
    [MethodImpl]
    public extern PrintCustomTextOptionDetails CreateTextOption(
      string optionId,
      string displayName);

    /// <summary>Raised when any one of the advanced print task options is changed.</summary>
    public extern event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged;

    /// <summary>Raised when the print system begins a validation pass on the current state of the print ticket.</summary>
    public extern event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation;

    /// <summary>Returns a **PrintPageDescription** object for the referenced page number.</summary>
    /// <param name="jobPageNumber">The page number.</param>
    /// <returns>The **PrintPageDescription** object.</returns>
    [MethodImpl]
    public extern PrintPageDescription GetPageDescription(uint jobPageNumber);

    /// <summary>Gets the list of print task options that are currently displayed.</summary>
    /// <returns>A pointer to the list of options.</returns>
    public extern IVector<string> DisplayedOptions { [MethodImpl] get; }

    /// <summary>Creates a PrintCustomToggleOptionDetails object to handle the display name and other parameters of the advanced print task option item.</summary>
    /// <param name="optionId">The ID of the print task option.</param>
    /// <param name="displayName">The display name of the print task option.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern PrintCustomToggleOptionDetails CreateToggleOption(
      string optionId,
      string displayName);

    /// <summary>Used to retrieve the available options for a print task.</summary>
    /// <param name="printTaskOptions">Pointer to a **PrintTaskOptions** object.</param>
    /// <returns>Pointer to a **PrintTaskOptionDetails** object.</returns>
    [MethodImpl]
    public static extern PrintTaskOptionDetails GetFromPrintTaskOptions(
      PrintTaskOptions printTaskOptions);
  }
}
