// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISelectionProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that act as containers for a collection of individual, selectable child items. The children of this element must implement ISelectionItemProvider. Implement ISelectionProvider in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.SelectionItem.</summary>
  [WebHostHidden]
  [Guid(520196042, 47428, 17301, 141, 225, 136, 246, 116, 175, 81, 211)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISelectionProvider
  {
    /// <summary>Gets a value that indicates whether the Microsoft UI Automation provider allows more than one child element to be selected concurrently.</summary>
    /// <returns>**true** if multiple selection is allowed; otherwise, **false**.</returns>
    bool CanSelectMultiple { get; }

    /// <summary>Gets a value that indicates whether the UI Automation provider requires at least one child element to be selected.</summary>
    /// <returns>**true** if selection is required; otherwise, **false**.</returns>
    bool IsSelectionRequired { get; }

    /// <summary>Retrieves a UI Automation provider for each child element that is selected.</summary>
    /// <returns>An array of UI Automation providers.</returns>
    IRawElementProviderSimple[] GetSelection();
  }
}
