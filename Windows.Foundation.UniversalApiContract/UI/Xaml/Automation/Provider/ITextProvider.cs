// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support Microsoft UI Automation client access to controls that contain text. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Text.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3680222367, 18439, 20266, 134, 120, 27, 19, 243, 198, 14, 34)]
  public interface ITextProvider
  {
    /// <summary>Gets a text range that encloses the main text of a document.</summary>
    /// <returns>A text range that encloses the main text of a document.</returns>
    ITextRangeProvider DocumentRange { get; }

    /// <summary>Gets a value that specifies whether a text provider supports selection, and if it does, the type of selection that is supported.</summary>
    /// <returns>A value of SupportedTextSelection.</returns>
    SupportedTextSelection SupportedTextSelection { get; }

    /// <summary>Retrieves a collection of disjoint text ranges that are associated with the current text selection or selections.</summary>
    /// <returns>A collection of disjoint text ranges.</returns>
    ITextRangeProvider[] GetSelection();

    /// <summary>Retrieves an array of disjoint text ranges from a text container. Each text range begins with the first partially visible line and ends with the last partially visible line.</summary>
    /// <returns>The collection of visible text ranges within a container or an empty array. This method never returns null.</returns>
    ITextRangeProvider[] GetVisibleRanges();

    /// <summary>Retrieves a text range that encloses a child element, such as an image, hyperlink, or other embedded object.</summary>
    /// <param name="childElement">The enclosed object.</param>
    /// <returns>A range that spans the child element.</returns>
    ITextRangeProvider RangeFromChild(IRawElementProviderSimple childElement);

    /// <summary>Retrieves a text range from the vicinity of a screen coordinate.</summary>
    /// <param name="screenLocation">The coordinate screen location.</param>
    /// <returns>A range that contains text. </returns>
    ITextRangeProvider RangeFromPoint(Point screenLocation);
  }
}
