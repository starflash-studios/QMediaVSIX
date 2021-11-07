// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISpreadsheetItemProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Provides access to information about an item (cell) in a spreadsheet.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3957231506, 24597, 18470, 183, 25, 71, 82, 26, 129, 198, 126)]
  public interface ISpreadsheetItemProvider
  {
    /// <summary>Gets the formula for this spreadsheet cell, as a string.</summary>
    /// <returns>The formula for this cell, as a string.</returns>
    string Formula { get; }

    /// <summary>Returns an array of objects that represent the annotations associated with this spreadsheet cell.</summary>
    /// <returns>An array of IRawElementProviderSimple interfaces for Microsoft UI Automation elements that represent the annotations associated with the spreadsheet cell.</returns>
    IRawElementProviderSimple[] GetAnnotationObjects();

    /// <summary>Returns an array of annotation type identifiers indicating the types of annotations that are associated with this spreadsheet cell.</summary>
    /// <returns>An array of annotation type identifiers, which contains one entry for each type of annotation associated with the spreadsheet cell. For a list of possible values, see AnnotationType.</returns>
    AnnotationType[] GetAnnotationTypes();
  }
}
