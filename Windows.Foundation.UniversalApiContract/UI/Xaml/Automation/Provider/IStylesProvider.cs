// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IStylesProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Provides access to the visual styles associated with the content of a document.</summary>
  [Guid(442202647, 31745, 19436, 156, 212, 45, 250, 125, 194, 70, 205)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStylesProvider
  {
    /// <summary>Gets a string value that contains additional property info. The info is for properties are that are not included in this control pattern, but that provide information about the document content that might be useful to the user.</summary>
    /// <returns>A localized, formatted string that contains the list of extended properties. The string must be formatted as a list of name/value pairs, as follows: "prop1=value;prop2=value2".</returns>
    string ExtendedProperties { get; }

    /// <summary>Gets the fill color of an element in a document.</summary>
    /// <returns>The fill color, represented as a Windows Runtime  Color value.</returns>
    Color FillColor { get; }

    /// <summary>Gets the color of the pattern used to fill an element in a document.</summary>
    /// <returns>The color of the fill pattern, represented as a Windows Runtime  Color value.</returns>
    Color FillPatternColor { get; }

    /// <summary>Gets a string that represents the fill pattern style of an element in a document.</summary>
    /// <returns>A localized string that indicates the fill pattern style, such as "Vertical Stripe".</returns>
    string FillPatternStyle { get; }

    /// <summary>Gets a string that represents the shape of an element in a document.</summary>
    /// <returns>A localized string that indicates the shape.</returns>
    string Shape { get; }

    /// <summary>Gets the identifier for a visual style of an element in a document.</summary>
    /// <returns>The style identifier. For a list of possible values, see Style Identifiers.</returns>
    int StyleId { get; }

    /// <summary>Gets the name of the visual style of an element in a document.</summary>
    /// <returns>The name of the style, or empty string if the style has no name.</returns>
    string StyleName { get; }
  }
}
