// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to individual, selectable child controls of containers that implement ISelectionProvider. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.SelectionItem.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1783199681, 33549, 17106, 191, 98, 4, 46, 189, 222, 204, 25)]
  public interface ISelectionItemProvider
  {
    /// <summary>Gets a value that indicates whether an item is selected.</summary>
    /// <returns>**true** if the element is selected; otherwise, **false**.</returns>
    bool IsSelected { get; }

    /// <summary>Gets the UI Automation provider that implements ISelectionProvider and acts as the container for the calling object.</summary>
    /// <returns>The UI Automation provider.</returns>
    IRawElementProviderSimple SelectionContainer { get; }

    /// <summary>Adds the current element to the collection of selected items.</summary>
    void AddToSelection();

    /// <summary>Removes the current element from the collection of selected items.</summary>
    void RemoveFromSelection();

    /// <summary>Clears any existing selection and then selects the current element.</summary>
    void Select();
  }
}
